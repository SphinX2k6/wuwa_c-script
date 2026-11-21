using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C88 RID: 19592
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiTowerMergeHeadStateData
	{
		// Token: 0x06030E0F RID: 200207 RVA: 0x00DA1E5E File Offset: 0x00DA005E
		public void Init()
		{
		}

		// Token: 0x06030E10 RID: 200208 RVA: 0x00DA1E60 File Offset: 0x00DA0060
		public void OnLeaveLevel()
		{
			this.Clear();
		}

		// Token: 0x06030E11 RID: 200209 RVA: 0x00DA1E68 File Offset: 0x00DA0068
		public void Clear()
		{
			if (this.Info != null)
			{
				foreach (TowerMergeHeadStateMonsterInfo towerMergeHeadStateMonsterInfo in this.Info.MonsterInfos.Values)
				{
					towerMergeHeadStateMonsterInfo.RemoveListener();
				}
				if (this.Info.IsVisible)
				{
					this.Info.IsVisible = false;
					EventSystem.Instance.Emit<TowerMergeHeadStateInfo>(EEventName.BattleUiTowerMergeHeadStateVisibleChanged, this.Info);
				}
			}
			this.Info = null;
			this.ListenMonsterAddMap.Clear();
			this.ListenMonsterRemoveMap.Clear();
		}

		// Token: 0x06030E12 RID: 200210 RVA: 0x00DA1F18 File Offset: 0x00DA0118
		public void UpdateTowerMonsterHpInfo(NewTowerMonsterHpInfoNotify notify)
		{
			this.UpdateProgress(notify.MonsterHpInfos);
		}

		// Token: 0x06030E13 RID: 200211 RVA: 0x00DA1F28 File Offset: 0x00DA0128
		public void UpdateProgress(IList<NewTowerMonsterHpInfo> param)
		{
			if (param == null || param.Count <= 1)
			{
				this.Clear();
				return;
			}
			int waveConfigId = param[0].WaveConfigId;
			if (this.Info == null)
			{
				this.Info = new TowerMergeHeadStateInfo();
			}
			else if (this.Info.MainMonsterInfoId != waveConfigId)
			{
				this.Clear();
				this.Info = new TowerMergeHeadStateInfo();
			}
			this.Info.MainMonsterInfoId = waveConfigId;
			foreach (NewTowerMonsterHpInfo newTowerMonsterHpInfo in param)
			{
				TowerMergeHeadStateMonsterInfo towerMergeHeadStateMonsterInfo;
				if (!this.Info.MonsterInfos.TryGetValue(newTowerMonsterHpInfo.WaveConfigId, out towerMergeHeadStateMonsterInfo))
				{
					towerMergeHeadStateMonsterInfo = new TowerMergeHeadStateMonsterInfo
					{
						MonsterInfoId = newTowerMonsterHpInfo.WaveConfigId,
						CreatureDataId = newTowerMonsterHpInfo.IncId
					};
					towerMergeHeadStateMonsterInfo.Hp = (float)((towerMergeHeadStateMonsterInfo.CreatureDataId <= 0L) ? 0L : MathUtils.Instance.LongToNumber(newTowerMonsterHpInfo.CurHp));
					towerMergeHeadStateMonsterInfo.HpMax = (float)MathUtils.Instance.LongToNumber(newTowerMonsterHpInfo.MaxHp);
					this.Info.MonsterInfos[towerMergeHeadStateMonsterInfo.MonsterInfoId] = towerMergeHeadStateMonsterInfo;
					this.TryAttachListener(towerMergeHeadStateMonsterInfo);
				}
				else if (towerMergeHeadStateMonsterInfo.CreatureDataId != newTowerMonsterHpInfo.IncId)
				{
					towerMergeHeadStateMonsterInfo.RemoveListener();
					this.ListenMonsterAddMap.Remove(towerMergeHeadStateMonsterInfo.CreatureDataId);
					if (towerMergeHeadStateMonsterInfo.EntityHandle != null && towerMergeHeadStateMonsterInfo.EntityHandle.Id != 0)
					{
						this.ListenMonsterRemoveMap.Remove(towerMergeHeadStateMonsterInfo.EntityHandle.Id);
					}
					towerMergeHeadStateMonsterInfo.EntityHandle = null;
					towerMergeHeadStateMonsterInfo.CreatureDataId = newTowerMonsterHpInfo.IncId;
					towerMergeHeadStateMonsterInfo.Hp = (float)((towerMergeHeadStateMonsterInfo.CreatureDataId <= 0L) ? 0L : MathUtils.Instance.LongToNumber(newTowerMonsterHpInfo.CurHp));
					towerMergeHeadStateMonsterInfo.HpMax = (float)MathUtils.Instance.LongToNumber(newTowerMonsterHpInfo.MaxHp);
					this.TryAttachListener(towerMergeHeadStateMonsterInfo);
				}
				else if (towerMergeHeadStateMonsterInfo.AttributeComponent != null)
				{
					towerMergeHeadStateMonsterInfo.Hp = towerMergeHeadStateMonsterInfo.AttributeComponent.GetCurrentValue(EAttributeType.Life);
					towerMergeHeadStateMonsterInfo.HpMax = towerMergeHeadStateMonsterInfo.AttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
				}
				else
				{
					towerMergeHeadStateMonsterInfo.Hp = (float)((towerMergeHeadStateMonsterInfo.CreatureDataId <= 0L) ? 0L : MathUtils.Instance.LongToNumber(newTowerMonsterHpInfo.CurHp));
					towerMergeHeadStateMonsterInfo.HpMax = (float)MathUtils.Instance.LongToNumber(newTowerMonsterHpInfo.MaxHp);
				}
			}
			this.ReCalcTotalHp();
			this.DispatchHpChanged();
		}

		// Token: 0x06030E14 RID: 200212 RVA: 0x00DA2198 File Offset: 0x00DA0398
		public void OnAddEntity(EntityHandle handle)
		{
			if (this.ListenMonsterAddMap.Count <= 0)
			{
				return;
			}
			long creatureDataId = CreatureModel.Instance.GetCreatureDataId(handle.Id);
			TowerMergeHeadStateMonsterInfo towerMergeHeadStateMonsterInfo;
			if (!this.ListenMonsterAddMap.TryGetValue(creatureDataId, out towerMergeHeadStateMonsterInfo))
			{
				return;
			}
			this.ListenMonsterAddMap.Remove(creatureDataId);
			towerMergeHeadStateMonsterInfo.EntityHandle = handle;
			this.AttachMonsterListener(towerMergeHeadStateMonsterInfo);
			if (towerMergeHeadStateMonsterInfo.AttributeComponent == null)
			{
				return;
			}
			float currentValue = towerMergeHeadStateMonsterInfo.AttributeComponent.GetCurrentValue(EAttributeType.Life);
			float currentValue2 = towerMergeHeadStateMonsterInfo.AttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
			bool flag = currentValue != towerMergeHeadStateMonsterInfo.Hp || currentValue2 != towerMergeHeadStateMonsterInfo.HpMax;
			towerMergeHeadStateMonsterInfo.Hp = currentValue;
			towerMergeHeadStateMonsterInfo.HpMax = currentValue2;
			if (flag)
			{
				this.ReCalcTotalHp();
				this.DispatchHpChanged();
			}
		}

		// Token: 0x06030E15 RID: 200213 RVA: 0x00DA2248 File Offset: 0x00DA0448
		public void OnRemoveEntity(EntityHandle handle)
		{
			if (this.ListenMonsterRemoveMap.Count <= 0)
			{
				return;
			}
			TowerMergeHeadStateMonsterInfo towerMergeHeadStateMonsterInfo;
			if (!this.ListenMonsterRemoveMap.TryGetValue(handle.Id, out towerMergeHeadStateMonsterInfo))
			{
				return;
			}
			this.ListenMonsterRemoveMap.Remove(handle.Id);
			towerMergeHeadStateMonsterInfo.RemoveListener();
			towerMergeHeadStateMonsterInfo.EntityHandle = null;
			if (towerMergeHeadStateMonsterInfo.Hp > 0f)
			{
				this.ListenMonsterAddMap[towerMergeHeadStateMonsterInfo.CreatureDataId] = towerMergeHeadStateMonsterInfo;
			}
		}

		// Token: 0x06030E16 RID: 200214 RVA: 0x00DA22B8 File Offset: 0x00DA04B8
		public void OnMonsterHpChanged(int monsterInfoId)
		{
			if (this.Info == null)
			{
				return;
			}
			TowerMergeHeadStateMonsterInfo towerMergeHeadStateMonsterInfo;
			if (!this.Info.MonsterInfos.TryGetValue(monsterInfoId, out towerMergeHeadStateMonsterInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "[Tower合并怪物血条]更新血量时MonsterInfoId错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("monsterInfoId", monsterInfoId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ReCalcTotalHp();
			this.DispatchHpChanged();
		}

		// Token: 0x06030E17 RID: 200215 RVA: 0x00DA231C File Offset: 0x00DA051C
		private void TryAttachListener(TowerMergeHeadStateMonsterInfo monsterInfo)
		{
			if (monsterInfo.CreatureDataId <= 0L)
			{
				return;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(monsterInfo.CreatureDataId);
			if (entity != null && entity.Valid)
			{
				monsterInfo.EntityHandle = entity;
				this.AttachMonsterListener(monsterInfo);
				if (monsterInfo.AttributeComponent != null)
				{
					monsterInfo.Hp = monsterInfo.AttributeComponent.GetCurrentValue(EAttributeType.Life);
					monsterInfo.HpMax = monsterInfo.AttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
				}
				return;
			}
			if (monsterInfo.Hp > 0f)
			{
				this.ListenMonsterAddMap[monsterInfo.CreatureDataId] = monsterInfo;
			}
		}

		// Token: 0x06030E18 RID: 200216 RVA: 0x00DA23AA File Offset: 0x00DA05AA
		private void AttachMonsterListener(TowerMergeHeadStateMonsterInfo monsterInfo)
		{
			if (!monsterInfo.AddListener())
			{
				return;
			}
			this.ListenMonsterRemoveMap[monsterInfo.EntityHandle.Id] = monsterInfo;
		}

		// Token: 0x06030E19 RID: 200217 RVA: 0x00DA23CC File Offset: 0x00DA05CC
		private void ReCalcTotalHp()
		{
			if (this.Info == null)
			{
				return;
			}
			float num = 0f;
			float num2 = 0f;
			foreach (TowerMergeHeadStateMonsterInfo towerMergeHeadStateMonsterInfo in this.Info.MonsterInfos.Values)
			{
				num += towerMergeHeadStateMonsterInfo.Hp;
				num2 += towerMergeHeadStateMonsterInfo.HpMax;
			}
			bool flag = num > 0f;
			this.Info.TotalHp = num;
			this.Info.TotalHpMax = num2;
			if (this.Info.IsVisible != flag)
			{
				this.Info.IsVisible = flag;
				EventSystem.Instance.Emit<TowerMergeHeadStateInfo>(EEventName.BattleUiTowerMergeHeadStateVisibleChanged, this.Info);
			}
			if (!flag)
			{
				this.Clear();
			}
		}

		// Token: 0x06030E1A RID: 200218 RVA: 0x00DA24A8 File Offset: 0x00DA06A8
		private void DispatchHpChanged()
		{
			if (this.Info == null)
			{
				return;
			}
			EventSystem.Instance.Emit<TowerMergeHeadStateInfo>(EEventName.BattleUiTowerMergeHeadStateMonsterHpChanged, this.Info);
		}

		// Token: 0x04019F09 RID: 106249
		[Nullable(2)]
		public TowerMergeHeadStateInfo Info;

		// Token: 0x04019F0A RID: 106250
		private readonly Dictionary<long, TowerMergeHeadStateMonsterInfo> ListenMonsterAddMap = new Dictionary<long, TowerMergeHeadStateMonsterInfo>();

		// Token: 0x04019F0B RID: 106251
		private readonly Dictionary<int, TowerMergeHeadStateMonsterInfo> ListenMonsterRemoveMap = new Dictionary<int, TowerMergeHeadStateMonsterInfo>();
	}
}
