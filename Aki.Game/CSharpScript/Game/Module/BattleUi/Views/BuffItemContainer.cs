using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D11 RID: 23825
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffItemContainer
	{
		// Token: 0x0603C63A RID: 247354 RVA: 0x00E792C8 File Offset: 0x00E774C8
		public void Init(UUIItem buffParentItem, int maxItemCount = 6, bool isSmallContainer = false, bool isPlayer = false, bool isRoleBuff = false, [Nullable(2)] UUIItem exceedTipItem = null)
		{
			this.BuffParentItem = buffParentItem;
			this.MaxItemCount = maxItemCount;
			this.IsSmallContainer = isSmallContainer;
			this.IsPlayer = isPlayer;
			this.IsRoleBuff = isRoleBuff;
			this.ExceedTipItem = exceedTipItem;
			this.RefreshExceedTipItemVisible();
		}

		// Token: 0x0603C63B RID: 247355 RVA: 0x00E79300 File Offset: 0x00E77500
		public void Tick(float delta)
		{
			int frame = Time.Instance.Frame;
			if (frame < this.NextTickFrame)
			{
				return;
			}
			if (this.BuffItemInfoList.Count > 6)
			{
				this.NextTickFrame = frame + 2;
			}
			foreach (BuffItemInfo buffItemInfo in this.BuffItemInfoList)
			{
				BuffItemBase buffItem = buffItemInfo.BuffItem;
				if (buffItem == null)
				{
					break;
				}
				buffItem.Tick(delta);
			}
			for (int i = this.HidingBuffItemList.Count - 1; i >= 0; i--)
			{
				BuffItemBase buffItemBase = this.HidingBuffItemList[i];
				if (!buffItemBase.TickHiding(delta))
				{
					this.HidingBuffItemList.RemoveAt(i);
					buffItemBase.GetRootItem().SetHierarchyIndex(this.BuffItemInfoList.Count + this.HidingBuffItemList.Count);
					this.HiddenBuffItemPool.RecycleBuffItem(buffItemBase);
				}
			}
		}

		// Token: 0x0603C63C RID: 247356 RVA: 0x00E793F8 File Offset: 0x00E775F8
		[NullableContext(2)]
		public void RefreshBuff(EntityHandle entityHandle)
		{
			this.ClearAll();
			if (entityHandle == null || !entityHandle.IsInit)
			{
				this.BuffComponent = null;
				this.RoleBuffComponent = null;
				return;
			}
			this.BuffComponent = entityHandle.Entity.GetComponent<CharacterBuffComponent>();
			this.RoleBuffComponent = entityHandle.Entity.GetComponent<RoleBuffComponent>();
			CharacterGameplayCueComponent component = entityHandle.Entity.GetComponent<CharacterGameplayCueComponent>();
			this.AddBuffByCueComp(component);
			if (!this.IsPlayer)
			{
				return;
			}
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
			PlayerGameplayCueComponent playerGameplayCueComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerGameplayCueComponent>() : null;
			if (playerGameplayCueComponent != null)
			{
				this.AddBuffByCueComp(playerGameplayCueComponent);
			}
		}

		// Token: 0x0603C63D RID: 247357 RVA: 0x00E79494 File Offset: 0x00E77694
		private void AddBuffByCueComp(BaseGameplayCueComponent cueComp)
		{
			foreach (GameplayCueBase gameplayCueBase in cueComp.GetAllCurrentCueRef())
			{
				GameplayCue cueConfig = gameplayCueBase.CueConfig;
				ECueType cueType = (ECueType)cueConfig.CueType;
				if (cueType == ECueType.UITexture || cueType == ECueType.StateUITexture || cueType == ECueType.RoleUITexture || cueType == ECueType.CustomStyleUITexture)
				{
					this.AddBuffByCue(cueConfig, gameplayCueBase.BuffHandleId, false);
				}
			}
		}

		// Token: 0x0603C63E RID: 247358 RVA: 0x00E7950C File Offset: 0x00E7770C
		public void AddBuffByCue(GameplayCue buffCueConfig, int handleId, bool playAnim = false)
		{
			ECueType cueType = (ECueType)buffCueConfig.CueType;
			if (cueType == ECueType.UITexture && !this.IsRoleBuff)
			{
				if (!this.CheckCanShow(buffCueConfig))
				{
					return;
				}
				if (this.BuffItemInfoMap.ContainsKey(handleId))
				{
					return;
				}
				IActiveBuff buffByHandleId = this.GetBuffByHandleId(handleId);
				if (buffByHandleId == null)
				{
					return;
				}
				BuffItemInfo buffItemInfo = this.NewBuffItemInfo(buffCueConfig);
				buffItemInfo.SingleBuff = buffByHandleId;
				this.BuffItemInfoMap[handleId] = buffItemInfo;
				this.AddBuffItemInfo(buffItemInfo, playAnim);
				return;
			}
			else if (cueType == ECueType.StateUITexture && !this.IsRoleBuff)
			{
				if (!this.CheckCanShow(buffCueConfig))
				{
					return;
				}
				long id = buffCueConfig.Id;
				BuffItemInfo buffItemInfo2;
				if (!this.StateBuffItemInfoMap.TryGetValue(id, out buffItemInfo2))
				{
					buffItemInfo2 = this.NewBuffItemInfo(buffCueConfig);
					buffItemInfo2.BuffHandleSet.Add((long)handleId);
					this.StateBuffItemInfoMap[id] = buffItemInfo2;
					this.AddBuffItemInfo(buffItemInfo2, playAnim);
					return;
				}
				if (!buffItemInfo2.BuffHandleSet.Add((long)handleId))
				{
					return;
				}
				if (buffItemInfo2.BuffItem != null)
				{
					buffItemInfo2.BuffItem.SetNum(buffItemInfo2.BuffHandleSet.Count);
					if (playAnim && this.BuffItemInfoList.IndexOf(buffItemInfo2) < this.MaxItemCount)
					{
						buffItemInfo2.BuffItem.PlayAddBuffAnim();
					}
				}
				return;
			}
			else
			{
				if (cueType != ECueType.RoleUITexture || !this.IsRoleBuff)
				{
					if (cueType == ECueType.CustomStyleUITexture && !this.IsRoleBuff)
					{
						if (this.BuffItemInfoMap.ContainsKey(handleId))
						{
							return;
						}
						IActiveBuff buffByHandleId2 = this.GetBuffByHandleId(handleId);
						if (buffByHandleId2 == null)
						{
							return;
						}
						BuffItemInfo buffItemInfo3 = this.NewBuffItemInfo(buffCueConfig);
						buffItemInfo3.SingleBuff = buffByHandleId2;
						this.BuffItemInfoMap[handleId] = buffItemInfo3;
						this.AddBuffItemInfo(buffItemInfo3, playAnim);
					}
					return;
				}
				if (!this.CheckCanShow(buffCueConfig))
				{
					return;
				}
				if (this.BuffItemInfoMap.ContainsKey(handleId))
				{
					return;
				}
				IActiveBuff buffByHandleId3 = this.GetBuffByHandleId(handleId);
				if (buffByHandleId3 == null)
				{
					return;
				}
				BuffItemInfo buffItemInfo4 = this.NewBuffItemInfo(buffCueConfig);
				buffItemInfo4.SingleBuff = buffByHandleId3;
				this.BuffItemInfoMap[handleId] = buffItemInfo4;
				this.AddBuffItemInfo(buffItemInfo4, playAnim);
				return;
			}
		}

		// Token: 0x0603C63F RID: 247359 RVA: 0x00E796E4 File Offset: 0x00E778E4
		private bool CheckCanShow(GameplayCue buffCueConfig)
		{
			return !this.IsSmallContainer || buffCueConfig.ParametersLength <= 4 || !(buffCueConfig.Parameters(4) == "1");
		}

		// Token: 0x0603C640 RID: 247360 RVA: 0x00E79710 File Offset: 0x00E77910
		public void RemoveBuffByCue(in GameplayCue buffCueConfig, int handleId, bool playAnim = false)
		{
			GameplayCue gameplayCue = buffCueConfig;
			ECueType cueType = (ECueType)gameplayCue.CueType;
			if (cueType != ECueType.UITexture && cueType != ECueType.RoleUITexture && cueType != ECueType.CustomStyleUITexture)
			{
				if (cueType == ECueType.StateUITexture)
				{
					gameplayCue = buffCueConfig;
					long id = gameplayCue.Id;
					BuffItemInfo buffItemInfo;
					if (!this.StateBuffItemInfoMap.TryGetValue(id, out buffItemInfo))
					{
						return;
					}
					if (!buffItemInfo.BuffHandleSet.Remove((long)handleId))
					{
						return;
					}
					if (buffItemInfo.BuffHandleSet.Count <= 0)
					{
						this.StateBuffItemInfoMap.Remove(id);
						this.RemoveBuffItemInfo(buffItemInfo, playAnim);
						return;
					}
					if (buffItemInfo.BuffItem != null)
					{
						buffItemInfo.BuffItem.SetNum(buffItemInfo.BuffHandleSet.Count);
					}
				}
				return;
			}
			BuffItemInfo buffItemInfo2;
			if (!this.BuffItemInfoMap.Remove(handleId, out buffItemInfo2))
			{
				return;
			}
			this.RemoveBuffItemInfo(buffItemInfo2, playAnim);
		}

		// Token: 0x0603C641 RID: 247361 RVA: 0x00E797D4 File Offset: 0x00E779D4
		private BuffItemInfo NewBuffItemInfo(GameplayCue buffCueConfig)
		{
			BuffItemInfo buffItemInfo = (this.BuffItemInfoPool.Count > 0) ? this.BuffItemInfoPool.Pop<BuffItemInfo>() : new BuffItemInfo();
			buffItemInfo.SortId = BuffItemInfo.GenSortId();
			buffItemInfo.Priority = buffCueConfig.Priority;
			buffItemInfo.BuffCueConfig = new GameplayCue?(buffCueConfig);
			return buffItemInfo;
		}

		// Token: 0x0603C642 RID: 247362 RVA: 0x00E79825 File Offset: 0x00E77A25
		private void RecycleBuffItemInfo(BuffItemInfo buffItemInfo)
		{
			buffItemInfo.Clear();
			this.BuffItemInfoPool.Add(buffItemInfo);
		}

		// Token: 0x0603C643 RID: 247363 RVA: 0x00E7983C File Offset: 0x00E77A3C
		private void AddBuffItemInfo(BuffItemInfo buffItemInfo, bool playAnim = false)
		{
			int num = this.InsertBuffItemInfo(buffItemInfo);
			if (num < this.MaxItemCount)
			{
				if (this.BuffItemInfoList.Count > this.MaxItemCount)
				{
					this.DeactivateBuffItem(this.BuffItemInfoList[this.MaxItemCount], false);
				}
				buffItemInfo.BuffItem = this.NewBuffItem(buffItemInfo.BuffCueConfig);
				this.ActivateBuffItem(buffItemInfo, num, playAnim);
			}
			this.RefreshExceedTipItemVisible();
		}

		// Token: 0x0603C644 RID: 247364 RVA: 0x00E798A8 File Offset: 0x00E77AA8
		private int InsertBuffItemInfo(BuffItemInfo newInfo)
		{
			int count = this.BuffItemInfoList.Count;
			for (int i = 0; i < count; i++)
			{
				if (BuffItemInfo.Compare(this.BuffItemInfoList[i], newInfo) >= 0)
				{
					this.BuffItemInfoList.Insert(i, newInfo);
					return i;
				}
			}
			this.BuffItemInfoList.Add(newInfo);
			return count;
		}

		// Token: 0x0603C645 RID: 247365 RVA: 0x00E79900 File Offset: 0x00E77B00
		private void RemoveBuffItemInfo(BuffItemInfo buffItemInfo, bool playAnim = false)
		{
			int num = this.BuffItemInfoList.IndexOf(buffItemInfo);
			if (num < 0)
			{
				return;
			}
			this.BuffItemInfoList.RemoveAt(num);
			if (num < this.MaxItemCount)
			{
				this.DeactivateBuffItem(buffItemInfo, playAnim);
				if (this.BuffItemInfoList.Count >= this.MaxItemCount)
				{
					BuffItemInfo buffItemInfo2 = this.BuffItemInfoList[this.MaxItemCount - 1];
					if (buffItemInfo2.BuffItem != null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.CFT;
						string message = "有残留的buffItem引用";
						string item = "cueId";
						BuffItemInfo buffItemInfo3 = buffItemInfo2;
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (buffItemInfo3.BuffCueConfig != null) ? new long?(buffItemInfo3.BuffCueConfig.GetValueOrDefault().Id) : null);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					buffItemInfo2.BuffItem = this.NewBuffItem(buffItemInfo2.BuffCueConfig);
					this.ActivateBuffItem(buffItemInfo2, this.MaxItemCount - 1, false);
				}
			}
			this.RecycleBuffItemInfo(buffItemInfo);
			this.RefreshExceedTipItemVisible();
		}

		// Token: 0x0603C646 RID: 247366 RVA: 0x00E799F8 File Offset: 0x00E77BF8
		[NullableContext(2)]
		private IActiveBuff GetBuffByHandleId(int handleId)
		{
			IActiveBuff buffByHandle;
			if ((buffByHandle = this.BuffComponent.GetBuffByHandle(handleId)) == null)
			{
				RoleBuffComponent roleBuffComponent = this.RoleBuffComponent;
				if (roleBuffComponent == null)
				{
					return null;
				}
				PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
				if (formationBuffComp == null)
				{
					return null;
				}
				buffByHandle = formationBuffComp.GetBuffByHandle(handleId);
			}
			return buffByHandle;
		}

		// Token: 0x0603C647 RID: 247367 RVA: 0x00E79A27 File Offset: 0x00E77C27
		private BuffItemBase NewBuffItem(GameplayCue? cueConfig)
		{
			return this.HiddenBuffItemPool.GetBuffItem(this.BuffParentItem, cueConfig);
		}

		// Token: 0x0603C648 RID: 247368 RVA: 0x00E79A3C File Offset: 0x00E77C3C
		private void ActivateBuffItem(BuffItemInfo buffItemInfo, int index, bool playAnim = false)
		{
			BuffItemBase buffItem = buffItemInfo.BuffItem;
			buffItem.Activate(buffItemInfo.BuffCueConfig.Value, buffItemInfo.SingleBuff, playAnim, buffItemInfo.BuffHandleSet.Count);
			if (index <= 0)
			{
				buffItem.GetRootItem().SetHierarchyIndex(0);
				return;
			}
			BuffItemBase buffItem2 = this.BuffItemInfoList[index - 1].BuffItem;
			if (buffItem2 != null)
			{
				buffItem.GetRootItem().SetHierarchyIndex(buffItem2.GetRootItem().GetHierarchyIndex() + 1);
				return;
			}
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "要插入的buff图标前面的buff没有buffItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603C649 RID: 247369 RVA: 0x00E79AD0 File Offset: 0x00E77CD0
		public void DeactivateBuffItem(BuffItemInfo buffItemInfo, bool playAnim = false)
		{
			BuffItemBase buffItem = buffItemInfo.BuffItem;
			if (buffItem == null)
			{
				return;
			}
			buffItemInfo.BuffItem = null;
			if (playAnim)
			{
				buffItem.DeactivateWithCloseAnim();
				this.HidingBuffItemList.Add(buffItem);
				return;
			}
			buffItem.Deactivate();
			buffItem.GetRootItem().SetHierarchyIndex(this.BuffItemInfoList.Count + this.HidingBuffItemList.Count);
			this.HiddenBuffItemPool.RecycleBuffItem(buffItem);
		}

		// Token: 0x0603C64A RID: 247370 RVA: 0x00E79B39 File Offset: 0x00E77D39
		private void RefreshExceedTipItemVisible()
		{
			UUIItem exceedTipItem = this.ExceedTipItem;
			if (exceedTipItem == null)
			{
				return;
			}
			exceedTipItem.SetUIActive(this.BuffItemInfoList.Count > this.MaxItemCount);
		}

		// Token: 0x0603C64B RID: 247371 RVA: 0x00E79B60 File Offset: 0x00E77D60
		public void ClearAll()
		{
			foreach (BuffItemInfo buffItemInfo in this.BuffItemInfoList)
			{
				BuffItemBase buffItem = buffItemInfo.BuffItem;
				if (buffItem != null)
				{
					buffItem.DestroyCompatible();
				}
			}
			this.BuffItemInfoList.Clear();
			this.BuffItemInfoMap.Clear();
			this.StateBuffItemInfoMap.Clear();
			this.BuffItemInfoPool.Clear();
			foreach (BuffItemBase buffItemBase in this.HidingBuffItemList)
			{
				buffItemBase.Deactivate();
				buffItemBase.DestroyCompatible();
			}
			this.HidingBuffItemList.Clear();
			this.HiddenBuffItemPool.Clear();
			this.NextTickFrame = 0;
		}

		// Token: 0x0401F76D RID: 128877
		private const int MAX_ITEM_COUNT = 6;

		// Token: 0x0401F76E RID: 128878
		private const int TICK_INTERVAL_FRAME_AT_MORE = 2;

		// Token: 0x0401F76F RID: 128879
		private readonly List<BuffItemInfo> BuffItemInfoList = new List<BuffItemInfo>();

		// Token: 0x0401F770 RID: 128880
		private readonly Dictionary<int, BuffItemInfo> BuffItemInfoMap = new Dictionary<int, BuffItemInfo>();

		// Token: 0x0401F771 RID: 128881
		private readonly Dictionary<long, BuffItemInfo> StateBuffItemInfoMap = new Dictionary<long, BuffItemInfo>();

		// Token: 0x0401F772 RID: 128882
		private readonly List<BuffItemInfo> BuffItemInfoPool = new List<BuffItemInfo>();

		// Token: 0x0401F773 RID: 128883
		private readonly List<BuffItemBase> HidingBuffItemList = new List<BuffItemBase>();

		// Token: 0x0401F774 RID: 128884
		private readonly BuffItemPool HiddenBuffItemPool = new BuffItemPool();

		// Token: 0x0401F775 RID: 128885
		[Nullable(2)]
		private UUIItem BuffParentItem;

		// Token: 0x0401F776 RID: 128886
		private int MaxItemCount;

		// Token: 0x0401F777 RID: 128887
		private bool IsSmallContainer;

		// Token: 0x0401F778 RID: 128888
		private bool IsPlayer;

		// Token: 0x0401F779 RID: 128889
		private bool IsRoleBuff;

		// Token: 0x0401F77A RID: 128890
		[Nullable(2)]
		private UUIItem ExceedTipItem;

		// Token: 0x0401F77B RID: 128891
		[Nullable(2)]
		private CharacterBuffComponent BuffComponent;

		// Token: 0x0401F77C RID: 128892
		[Nullable(2)]
		private RoleBuffComponent RoleBuffComponent;

		// Token: 0x0401F77D RID: 128893
		private int NextTickFrame;
	}
}
