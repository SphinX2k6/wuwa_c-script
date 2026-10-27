using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C95 RID: 23701
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiMergeHeadStateData
	{
		// Token: 0x0603BDB4 RID: 245172 RVA: 0x00E4BDE4 File Offset: 0x00E49FE4
		public void Init()
		{
		}

		// Token: 0x0603BDB5 RID: 245173 RVA: 0x00E4BDE8 File Offset: 0x00E49FE8
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

		// Token: 0x0603BDB6 RID: 245174 RVA: 0x00E4BEC0 File Offset: 0x00E4A0C0
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

		// Token: 0x0603BDB7 RID: 245175 RVA: 0x00E4BF3C File Offset: 0x00E4A13C
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

		// Token: 0x0603BDB8 RID: 245176 RVA: 0x00E4BFD0 File Offset: 0x00E4A1D0
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

		// Token: 0x0603BDB9 RID: 245177 RVA: 0x00E4C048 File Offset: 0x00E4A248
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

		// Token: 0x0603BDBA RID: 245178 RVA: 0x00E4C0C8 File Offset: 0x00E4A2C8
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

		// Token: 0x0603BDBB RID: 245179 RVA: 0x00E4C230 File Offset: 0x00E4A430
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

		// Token: 0x0603BDBC RID: 245180 RVA: 0x00E4C2E0 File Offset: 0x00E4A4E0
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

		// Token: 0x0603BDBD RID: 245181 RVA: 0x00E4C590 File Offset: 0x00E4A790
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

		// Token: 0x0603BDBE RID: 245182 RVA: 0x00E4C6FC File Offset: 0x00E4A8FC
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

		// Token: 0x0603BDBF RID: 245183 RVA: 0x00E4C7B0 File Offset: 0x00E4A9B0
		private void AddMonsterListener(MergeHeadStateMonsterInfo monsterInfo)
		{
			if (!monsterInfo.AddListener())
			{
				return;
			}
			this.ListenMonsterRemoveMap[monsterInfo.EntityHandle.Id] = monsterInfo;
		}

		// Token: 0x0603BDC0 RID: 245184 RVA: 0x00E4C7D2 File Offset: 0x00E4A9D2
		private void RemoveMonsterListener(MergeHeadStateMonsterInfo monsterInfo)
		{
			monsterInfo.RemoveListener();
			if (!monsterInfo.IsDead)
			{
				this.ListenMonsterAddMap[monsterInfo.PbDataId] = monsterInfo;
			}
		}

		// Token: 0x0603BDC1 RID: 245185 RVA: 0x00E4C7F4 File Offset: 0x00E4A9F4
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

		// Token: 0x0603BDC2 RID: 245186 RVA: 0x00E4C864 File Offset: 0x00E4AA64
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

		// Token: 0x0603BDC3 RID: 245187 RVA: 0x00E4C8DC File Offset: 0x00E4AADC
		private void DispatchVisibleChangeEvent(MergeHeadStateInfo info)
		{
			EventSystem.Instance.Emit<MergeHeadStateInfo>(EEventName.BattleUiMergeHeadStateVisibleChanged, info);
		}

		// Token: 0x0603BDC4 RID: 245188 RVA: 0x00E4C8F0 File Offset: 0x00E4AAF0
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

		// Token: 0x0603BDC5 RID: 245189 RVA: 0x00E4C94F File Offset: 0x00E4AB4F
		private void DispatchHealthChangeEvent(MergeHeadStateInfo info)
		{
			EventSystem.Instance.Emit<MergeHeadStateInfo>(EEventName.BattleUiMergeHeadStateHealthChanged, info);
		}

		// Token: 0x0401F364 RID: 127844
		private int IncId;

		// Token: 0x0401F365 RID: 127845
		public Dictionary<int, MergeHeadStateInfo> InfoMap = new Dictionary<int, MergeHeadStateInfo>();

		// Token: 0x0401F366 RID: 127846
		public Dictionary<int, MergeHeadStateMonsterInfo> ListenMonsterAddMap = new Dictionary<int, MergeHeadStateMonsterInfo>();

		// Token: 0x0401F367 RID: 127847
		public Dictionary<int, MergeHeadStateMonsterInfo> ListenMonsterRemoveMap = new Dictionary<int, MergeHeadStateMonsterInfo>();
	}
}
