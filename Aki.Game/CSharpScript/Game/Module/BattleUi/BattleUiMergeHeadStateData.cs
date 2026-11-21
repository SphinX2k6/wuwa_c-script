using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C77 RID: 19575
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiMergeHeadStateData
	{
		// Token: 0x06030D07 RID: 199943 RVA: 0x00D9C3D8 File Offset: 0x00D9A5D8
		public void Init()
		{
		}

		// Token: 0x06030D08 RID: 199944 RVA: 0x00D9C3DC File Offset: 0x00D9A5DC
		public void OnLeaveLevel()
		{
			if (this.ListenMonsterRemoveMap.Count <= 0)
			{
				return;
			}
			foreach (MergeHeadStateMonsterInfo mergeHeadStateMonsterInfo in this.ListenMonsterRemoveMap.Values)
			{
				mergeHeadStateMonsterInfo.EntityHandle = null;
				this.RemoveMonsterListener(mergeHeadStateMonsterInfo);
				MergeHeadStateInfo valueOrDefault = this.InfoMap.GetValueOrDefault(mergeHeadStateMonsterInfo.Id);
				if (valueOrDefault == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.CFT;
					string message = "合并怪物血条移除实体时InfoId错误";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", mergeHeadStateMonsterInfo.Id);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (mergeHeadStateMonsterInfo.HasFightTag)
				{
					mergeHeadStateMonsterInfo.HasFightTag = false;
					valueOrDefault.IsVisible = false;
				}
			}
			this.ListenMonsterRemoveMap.Clear();
		}

		// Token: 0x06030D09 RID: 199945 RVA: 0x00D9C4B4 File Offset: 0x00D9A6B4
		public void Clear()
		{
			foreach (MergeHeadStateInfo info in this.InfoMap.Values)
			{
				this.DeleteMergeHeadStateInfo(info);
			}
			this.InfoMap.Clear();
			this.ListenMonsterAddMap.Clear();
			this.ListenMonsterRemoveMap.Clear();
		}

		// Token: 0x06030D0A RID: 199946 RVA: 0x00D9C530 File Offset: 0x00D9A730
		[NullableContext(2)]
		public void UpdateProgress(long treeId, int nodeId, MonsterCreatorProgress monsterCreator, string monsterGroupName, IMonsterMergedHpBarSettings monsterMergedHpBarSettings = null)
		{
			if (monsterCreator == null)
			{
				return;
			}
			foreach (MergeHeadStateInfo mergeHeadStateInfo in this.InfoMap.Values)
			{
				long? treeId2 = mergeHeadStateInfo.TreeId;
				if ((treeId2.GetValueOrDefault() == treeId & treeId2 != null) && mergeHeadStateInfo.NodeId == nodeId)
				{
					this.UpdateMergeHeadStateInfo(mergeHeadStateInfo, monsterCreator);
					return;
				}
			}
			this.CreateMergeHeadStateInfo(treeId, nodeId, monsterCreator, monsterGroupName, monsterMergedHpBarSettings);
		}

		// Token: 0x06030D0B RID: 199947 RVA: 0x00D9C5C4 File Offset: 0x00D9A7C4
		public void RemoveTree(long treeId)
		{
			foreach (MergeHeadStateInfo mergeHeadStateInfo in this.InfoMap.Values)
			{
				long? treeId2 = mergeHeadStateInfo.TreeId;
				if (treeId2.GetValueOrDefault() == treeId & treeId2 != null)
				{
					this.DeleteMergeHeadStateInfo(mergeHeadStateInfo);
				}
			}
		}

		// Token: 0x06030D0C RID: 199948 RVA: 0x00D9C63C File Offset: 0x00D9A83C
		public void RemoveNode(long treeId, int nodeId)
		{
			foreach (MergeHeadStateInfo mergeHeadStateInfo in this.InfoMap.Values)
			{
				long? treeId2 = mergeHeadStateInfo.TreeId;
				if ((treeId2.GetValueOrDefault() == treeId & treeId2 != null) && mergeHeadStateInfo.NodeId == nodeId)
				{
					this.DeleteMergeHeadStateInfo(mergeHeadStateInfo);
					break;
				}
			}
		}

		// Token: 0x06030D0D RID: 199949 RVA: 0x00D9C6BC File Offset: 0x00D9A8BC
		public void OnAddEntity(EntityHandle handle)
		{
			if (this.ListenMonsterAddMap.Count <= 0)
			{
				return;
			}
			int pbDataIdByEntity = CreatureModel.Instance.GetPbDataIdByEntity(handle);
			MergeHeadStateMonsterInfo valueOrDefault = this.ListenMonsterAddMap.GetValueOrDefault(pbDataIdByEntity);
			if (valueOrDefault == null)
			{
				return;
			}
			this.ListenMonsterAddMap.Remove(pbDataIdByEntity);
			valueOrDefault.EntityHandle = handle;
			this.AddMonsterListener(valueOrDefault);
			MergeHeadStateInfo valueOrDefault2 = this.InfoMap.GetValueOrDefault(valueOrDefault.Id);
			if (valueOrDefault2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "合并怪物血条添加实体时InfoId错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", valueOrDefault.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			bool flag = false;
			if (valueOrDefault.AttributeComponent != null)
			{
				float currentValue = valueOrDefault.AttributeComponent.GetCurrentValue(EAttributeType.Life);
				float currentValue2 = valueOrDefault.AttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
				if (currentValue != valueOrDefault.Hp || currentValue2 != valueOrDefault.HpMax)
				{
					float num = 0f;
					if (valueOrDefault.HpMax > 0f)
					{
						num = valueOrDefault.Hp / valueOrDefault.HpMax;
					}
					float num2 = 0f;
					if (currentValue2 > 0f)
					{
						num2 = currentValue / currentValue2;
					}
					valueOrDefault2.TotalHp += (float)((int)((num2 - num) * valueOrDefault.BaseLife));
					valueOrDefault.Hp = currentValue;
					valueOrDefault.HpMax = currentValue2;
					flag = true;
				}
			}
			if (valueOrDefault2.IsVisible)
			{
				if (flag)
				{
					this.DispatchHealthChangeEvent(valueOrDefault2);
				}
				return;
			}
			if (valueOrDefault.HasFightTag)
			{
				valueOrDefault2.IsVisible = true;
				this.DispatchVisibleChangeEvent(valueOrDefault2);
			}
		}

		// Token: 0x06030D0E RID: 199950 RVA: 0x00D9C824 File Offset: 0x00D9AA24
		public void OnRemoveEntity(EntityHandle handle)
		{
			if (this.ListenMonsterRemoveMap.Count <= 0)
			{
				return;
			}
			MergeHeadStateMonsterInfo valueOrDefault = this.ListenMonsterRemoveMap.GetValueOrDefault(handle.Id);
			if (valueOrDefault == null)
			{
				return;
			}
			this.ListenMonsterRemoveMap.Remove(handle.Id);
			valueOrDefault.EntityHandle = null;
			this.RemoveMonsterListener(valueOrDefault);
			MergeHeadStateInfo valueOrDefault2 = this.InfoMap.GetValueOrDefault(valueOrDefault.Id);
			if (valueOrDefault2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "合并怪物血条移除实体时InfoId错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", valueOrDefault.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (valueOrDefault.HasFightTag)
			{
				valueOrDefault.HasFightTag = false;
				this.UpdateVisible(valueOrDefault2, true);
			}
		}

		// Token: 0x06030D0F RID: 199951 RVA: 0x00D9C8D4 File Offset: 0x00D9AAD4
		[NullableContext(2)]
		private void CreateMergeHeadStateInfo(long treeId, int nodeId, [Nullable(1)] MonsterCreatorProgress monsterCreator, string monsterGroupName, IMonsterMergedHpBarSettings monsterMergedHpBarSettings)
		{
			MergeHeadStateInfo mergeHeadStateInfo = new MergeHeadStateInfo();
			this.IncId++;
			mergeHeadStateInfo.Id = this.IncId;
			mergeHeadStateInfo.TreeId = new long?(treeId);
			mergeHeadStateInfo.NodeId = nodeId;
			mergeHeadStateInfo.MonsterGroupName = (monsterGroupName ?? string.Empty);
			mergeHeadStateInfo.MonsterMergedHpBarSettings = monsterMergedHpBarSettings;
			foreach (MonsterCreatorProgressSlot monsterCreatorProgressSlot in monsterCreator.Slots)
			{
				foreach (SceneMonsterCreatedMonsterInfo sceneMonsterCreatedMonsterInfo in monsterCreatorProgressSlot.MonsterInfo)
				{
					MergeHeadStateMonsterInfo mergeHeadStateMonsterInfo = new MergeHeadStateMonsterInfo();
					mergeHeadStateMonsterInfo.Id = mergeHeadStateInfo.Id;
					mergeHeadStateMonsterInfo.PbDataId = sceneMonsterCreatedMonsterInfo.EntityConfigId;
					mergeHeadStateMonsterInfo.IsDead = (sceneMonsterCreatedMonsterInfo.State == 2);
					mergeHeadStateMonsterInfo.BaseLife = (float)((int)sceneMonsterCreatedMonsterInfo.BaseLife);
					mergeHeadStateMonsterInfo.EntityHandle = CreatureModel.Instance.GetEntityByPbDataId(mergeHeadStateMonsterInfo.PbDataId);
					EntityHandle entityHandle = mergeHeadStateMonsterInfo.EntityHandle;
					if (entityHandle != null && entityHandle.Valid)
					{
						this.AddMonsterListener(mergeHeadStateMonsterInfo);
						if (mergeHeadStateMonsterInfo.AttributeComponent != null)
						{
							mergeHeadStateMonsterInfo.Hp = mergeHeadStateMonsterInfo.AttributeComponent.GetCurrentValue(EAttributeType.Life);
							mergeHeadStateMonsterInfo.HpMax = mergeHeadStateMonsterInfo.AttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
						}
					}
					else
					{
						if (!mergeHeadStateMonsterInfo.IsDead)
						{
							this.ListenMonsterAddMap[mergeHeadStateMonsterInfo.PbDataId] = mergeHeadStateMonsterInfo;
							mergeHeadStateMonsterInfo.Hp = mergeHeadStateMonsterInfo.BaseLife;
						}
						else
						{
							mergeHeadStateMonsterInfo.Hp = 0f;
						}
						mergeHeadStateMonsterInfo.HpMax = mergeHeadStateMonsterInfo.BaseLife;
					}
					mergeHeadStateInfo.MonsterInfos[mergeHeadStateMonsterInfo.PbDataId] = mergeHeadStateMonsterInfo;
				}
			}
			foreach (MergeHeadStateMonsterInfo mergeHeadStateMonsterInfo2 in mergeHeadStateInfo.MonsterInfos.Values)
			{
				if (mergeHeadStateMonsterInfo2.HpMax > 0f)
				{
					mergeHeadStateInfo.TotalHp += (float)((int)((double)mergeHeadStateMonsterInfo2.Hp / (double)mergeHeadStateMonsterInfo2.HpMax * (double)mergeHeadStateMonsterInfo2.BaseLife));
				}
				mergeHeadStateInfo.TotalHpMax += mergeHeadStateMonsterInfo2.BaseLife;
			}
			this.UpdateVisible(mergeHeadStateInfo, false);
			this.InfoMap[mergeHeadStateInfo.Id] = mergeHeadStateInfo;
			if (mergeHeadStateInfo.IsVisible)
			{
				this.DispatchVisibleChangeEvent(mergeHeadStateInfo);
			}
		}

		// Token: 0x06030D10 RID: 199952 RVA: 0x00D9CB84 File Offset: 0x00D9AD84
		private void UpdateMergeHeadStateInfo(MergeHeadStateInfo info, MonsterCreatorProgress monsterCreator)
		{
			foreach (MonsterCreatorProgressSlot monsterCreatorProgressSlot in monsterCreator.Slots)
			{
				foreach (SceneMonsterCreatedMonsterInfo sceneMonsterCreatedMonsterInfo in monsterCreatorProgressSlot.MonsterInfo)
				{
					MergeHeadStateMonsterInfo valueOrDefault = info.MonsterInfos.GetValueOrDefault(sceneMonsterCreatedMonsterInfo.EntityConfigId);
					if (valueOrDefault == null)
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "合并怪物血条更新怪物数据时与缓存对不上", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else if (!valueOrDefault.IsDead)
					{
						valueOrDefault.IsDead = (sceneMonsterCreatedMonsterInfo.State == 2);
						if (valueOrDefault.IsDead)
						{
							this.RemoveMonsterListener(valueOrDefault);
							if (valueOrDefault.Hp != 0f || valueOrDefault.HpMax != valueOrDefault.BaseLife)
							{
								if (valueOrDefault.HpMax > 0f)
								{
									info.TotalHp -= (float)((int)((double)valueOrDefault.Hp / (double)valueOrDefault.HpMax * (double)valueOrDefault.BaseLife));
								}
								valueOrDefault.Hp = 0f;
								valueOrDefault.HpMax = valueOrDefault.BaseLife;
								this.DispatchHealthChangeEvent(info);
							}
						}
					}
				}
			}
		}

		// Token: 0x06030D11 RID: 199953 RVA: 0x00D9CCF0 File Offset: 0x00D9AEF0
		private void DeleteMergeHeadStateInfo(MergeHeadStateInfo info)
		{
			foreach (MergeHeadStateMonsterInfo mergeHeadStateMonsterInfo in info.MonsterInfos.Values)
			{
				mergeHeadStateMonsterInfo.RemoveListener();
				if (mergeHeadStateMonsterInfo.EntityHandle != null)
				{
					this.ListenMonsterRemoveMap.Remove(mergeHeadStateMonsterInfo.EntityHandle.Id);
				}
				else
				{
					this.ListenMonsterAddMap.Remove(mergeHeadStateMonsterInfo.PbDataId);
				}
			}
			if (info.IsVisible)
			{
				info.IsVisible = false;
				this.DispatchVisibleChangeEvent(info);
			}
			this.InfoMap.Remove(info.Id);
		}

		// Token: 0x06030D12 RID: 199954 RVA: 0x00D9CDA4 File Offset: 0x00D9AFA4
		private void AddMonsterListener(MergeHeadStateMonsterInfo monsterInfo)
		{
			if (!monsterInfo.AddListener())
			{
				return;
			}
			this.ListenMonsterRemoveMap[monsterInfo.EntityHandle.Id] = monsterInfo;
		}

		// Token: 0x06030D13 RID: 199955 RVA: 0x00D9CDC6 File Offset: 0x00D9AFC6
		private void RemoveMonsterListener(MergeHeadStateMonsterInfo monsterInfo)
		{
			monsterInfo.RemoveListener();
			if (!monsterInfo.IsDead)
			{
				this.ListenMonsterAddMap[monsterInfo.PbDataId] = monsterInfo;
			}
		}

		// Token: 0x06030D14 RID: 199956 RVA: 0x00D9CDE8 File Offset: 0x00D9AFE8
		public void OnMonsterFightTagChange(int id, bool hasFightTag)
		{
			MergeHeadStateInfo valueOrDefault = this.InfoMap.GetValueOrDefault(id);
			if (valueOrDefault == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "合并怪物血条更新进战时InfoId错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (valueOrDefault.IsVisible == hasFightTag)
			{
				return;
			}
			if (hasFightTag)
			{
				valueOrDefault.IsVisible = true;
				this.DispatchVisibleChangeEvent(valueOrDefault);
				return;
			}
			this.UpdateVisible(valueOrDefault, true);
		}

		// Token: 0x06030D15 RID: 199957 RVA: 0x00D9CE58 File Offset: 0x00D9B058
		public void UpdateVisible(MergeHeadStateInfo info, bool dispatchEvent)
		{
			bool flag = false;
			using (Dictionary<int, MergeHeadStateMonsterInfo>.ValueCollection.Enumerator enumerator = info.MonsterInfos.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasFightTag)
					{
						flag = true;
						break;
					}
				}
			}
			if (info.IsVisible != flag)
			{
				info.IsVisible = flag;
				if (dispatchEvent)
				{
					this.DispatchVisibleChangeEvent(info);
				}
			}
		}

		// Token: 0x06030D16 RID: 199958 RVA: 0x00D9CED0 File Offset: 0x00D9B0D0
		private void DispatchVisibleChangeEvent(MergeHeadStateInfo info)
		{
			EventSystem.Instance.Emit<MergeHeadStateInfo>(EEventName.BattleUiMergeHeadStateVisibleChanged, info);
		}

		// Token: 0x06030D17 RID: 199959 RVA: 0x00D9CEE4 File Offset: 0x00D9B0E4
		public void OnMonsterHealthChange(int id, float hpChange)
		{
			MergeHeadStateInfo valueOrDefault = this.InfoMap.GetValueOrDefault(id);
			if (valueOrDefault == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "合并怪物血条更新血量时InfoId错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			valueOrDefault.TotalHp += hpChange;
			this.DispatchHealthChangeEvent(valueOrDefault);
		}

		// Token: 0x06030D18 RID: 199960 RVA: 0x00D9CF43 File Offset: 0x00D9B143
		private void DispatchHealthChangeEvent(MergeHeadStateInfo info)
		{
			EventSystem.Instance.Emit<MergeHeadStateInfo>(EEventName.BattleUiMergeHeadStateHealthChanged, info);
		}

		// Token: 0x04019E1D RID: 106013
		private int IncId;

		// Token: 0x04019E1E RID: 106014
		public Dictionary<int, MergeHeadStateInfo> InfoMap = new Dictionary<int, MergeHeadStateInfo>();

		// Token: 0x04019E1F RID: 106015
		public Dictionary<int, MergeHeadStateMonsterInfo> ListenMonsterAddMap = new Dictionary<int, MergeHeadStateMonsterInfo>();

		// Token: 0x04019E20 RID: 106016
		public Dictionary<int, MergeHeadStateMonsterInfo> ListenMonsterRemoveMap = new Dictionary<int, MergeHeadStateMonsterInfo>();
	}
}
