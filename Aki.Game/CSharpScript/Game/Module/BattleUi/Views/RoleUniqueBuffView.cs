using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DB1 RID: 23985
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleUniqueBuffView : BattleVisibleChildView
	{
		// Token: 0x0603CEBB RID: 249531 RVA: 0x00EA2908 File Offset: 0x00EA0B08
		protected override void OnStart()
		{
			base.OnStart();
			base.InitChildType(EBattleUiChild.Ignore);
			this.InitExceedTipItem();
			int value = ConfigCommonParamById.GetIntConfig("RoleUniqueBuffItemCount").Value;
			this.BuffItemContainer.Init(this.RootItem, value, false, true, true, this.ExceedTipItem.GetRootItem());
			this.AddEvents();
		}

		// Token: 0x0603CEBC RID: 249532 RVA: 0x00EA2964 File Offset: 0x00EA0B64
		protected override void OnBeforeDestroy()
		{
			this.Refresh(null);
			this.DestroyExceedTipItem();
			this.CurRoleBar = null;
			foreach (TopBuffContainer topBuffContainer in this.RoleBarMap.Values)
			{
				topBuffContainer.Destroy();
			}
		}

		// Token: 0x0603CEBD RID: 249533 RVA: 0x00EA29D0 File Offset: 0x00EA0BD0
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603CEBE RID: 249534 RVA: 0x00EA29DE File Offset: 0x00EA0BDE
		private void InitExceedTipItem()
		{
			this.ExceedTipItem = new BuffItem(this.RootItem);
			this.ExceedTipItem.ActivateExceedTip();
		}

		// Token: 0x0603CEBF RID: 249535 RVA: 0x00EA29FC File Offset: 0x00EA0BFC
		private void DestroyExceedTipItem()
		{
			if (this.ExceedTipItem != null)
			{
				this.ExceedTipItem.DestroyCompatible();
				this.ExceedTipItem = null;
			}
		}

		// Token: 0x0603CEC0 RID: 249536 RVA: 0x00EA2A18 File Offset: 0x00EA0C18
		[NullableContext(2)]
		public void Refresh(BattleUiRoleData roleData)
		{
			int? num;
			if (roleData == null)
			{
				num = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				num = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			}
			int? num2 = num;
			this.EntityId = new int?(num2.GetValueOrDefault());
			if (roleData != null)
			{
				this.BuffItemContainer.RefreshBuff(roleData.EntityHandle);
				this.LoadRoleTopBuff(roleData).Forget();
			}
			else
			{
				this.BuffItemContainer.ClearAll();
			}
			this.RefreshAllRoleTopBuffVisible();
		}

		// Token: 0x0603CEC1 RID: 249537 RVA: 0x00EA2A98 File Offset: 0x00EA0C98
		public void Tick(float delta)
		{
			this.BuffItemContainer.Tick(delta);
			foreach (TopBuffContainer topBuffContainer in this.RoleBarMap.Values)
			{
				topBuffContainer.Tick(delta);
			}
		}

		// Token: 0x0603CEC2 RID: 249538 RVA: 0x00EA2AFC File Offset: 0x00EA0CFC
		public void AddBuff(GameplayCue buffCueConfig, int handleId)
		{
			this.BuffItemContainer.AddBuffByCue(buffCueConfig, handleId, true);
		}

		// Token: 0x0603CEC3 RID: 249539 RVA: 0x00EA2B0C File Offset: 0x00EA0D0C
		public void RemoveBuff(GameplayCue buffCueConfig, int handleId)
		{
			this.BuffItemContainer.RemoveBuffByCue(buffCueConfig, handleId, true);
		}

		// Token: 0x0603CEC4 RID: 249540 RVA: 0x00EA2B20 File Offset: 0x00EA0D20
		public void OnRemoveEntity(int entityId)
		{
			TopBuffContainer topBuffContainer;
			if (this.RoleBarMap.Remove(entityId, out topBuffContainer))
			{
				topBuffContainer.Destroy();
				if (this.CurRoleBar == topBuffContainer)
				{
					this.CurRoleBar = null;
					return;
				}
			}
			else
			{
				this.NoRoleBarSet.Remove(entityId);
			}
		}

		// Token: 0x0603CEC5 RID: 249541 RVA: 0x00EA2B61 File Offset: 0x00EA0D61
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoaded));
		}

		// Token: 0x0603CEC6 RID: 249542 RVA: 0x00EA2B7F File Offset: 0x00EA0D7F
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoaded));
		}

		// Token: 0x0603CEC7 RID: 249543 RVA: 0x00EA2B9D File Offset: 0x00EA0D9D
		private void OnFormationLoaded()
		{
			this.LoadAllRoleTopBuff();
			this.RefreshAllRoleTopBuffVisible();
		}

		// Token: 0x0603CEC8 RID: 249544 RVA: 0x00EA2BAC File Offset: 0x00EA0DAC
		private void LoadAllRoleTopBuff()
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
				if (num != null)
				{
					BattleUiRoleData roleData = BattleUiModel.Instance.GetRoleData(num.Value);
					if (roleData != null)
					{
						this.LoadRoleTopBuff(roleData).Forget();
					}
				}
			}
		}

		// Token: 0x0603CEC9 RID: 249545 RVA: 0x00EA2C48 File Offset: 0x00EA0E48
		private UniTask LoadRoleTopBuff(BattleUiRoleData roleData)
		{
			RoleUniqueBuffView.<LoadRoleTopBuff>d__21 <LoadRoleTopBuff>d__;
			<LoadRoleTopBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRoleTopBuff>d__.<>4__this = this;
			<LoadRoleTopBuff>d__.roleData = roleData;
			<LoadRoleTopBuff>d__.<>1__state = -1;
			<LoadRoleTopBuff>d__.<>t__builder.Start<RoleUniqueBuffView.<LoadRoleTopBuff>d__21>(ref <LoadRoleTopBuff>d__);
			return <LoadRoleTopBuff>d__.<>t__builder.Task;
		}

		// Token: 0x0603CECA RID: 249546 RVA: 0x00EA2C94 File Offset: 0x00EA0E94
		private void RefreshAllRoleTopBuffVisible()
		{
			foreach (KeyValuePair<int, TopBuffContainer> keyValuePair in this.RoleBarMap)
			{
				int num;
				TopBuffContainer topBuffContainer;
				keyValuePair.Deconstruct(out num, out topBuffContainer);
				int num2 = num;
				TopBuffContainer topBuffContainer2 = topBuffContainer;
				int? entityId = this.EntityId;
				if (num2 == entityId.GetValueOrDefault() & entityId != null)
				{
					topBuffContainer2.SetVisible(true);
					this.CurRoleBar = topBuffContainer2;
				}
				else
				{
					topBuffContainer2.SetVisible(false);
				}
			}
		}

		// Token: 0x0603CECC RID: 249548 RVA: 0x00EA2D4D File Offset: 0x00EA0F4D
		// Note: this type is marked as 'beforefieldinit'.
		static RoleUniqueBuffView()
		{
			Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
			dictionary[1106] = typeof(TopBuffYouHu);
			dictionary[1307] = typeof(TopBuffBuLing);
			RoleUniqueBuffView.RoleClassMap = dictionary;
		}

		// Token: 0x0401FB9D RID: 129949
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, Type> RoleClassMap;

		// Token: 0x0401FB9E RID: 129950
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401FB9F RID: 129951
		[Nullable(2)]
		private BuffItem ExceedTipItem;

		// Token: 0x0401FBA0 RID: 129952
		private int? EntityId;

		// Token: 0x0401FBA1 RID: 129953
		[Nullable(2)]
		private TopBuffContainer CurRoleBar;

		// Token: 0x0401FBA2 RID: 129954
		private readonly Dictionary<int, TopBuffContainer> RoleBarMap = new Dictionary<int, TopBuffContainer>();

		// Token: 0x0401FBA3 RID: 129955
		private readonly HashSet<int> NoRoleBarSet = new HashSet<int>();
	}
}
