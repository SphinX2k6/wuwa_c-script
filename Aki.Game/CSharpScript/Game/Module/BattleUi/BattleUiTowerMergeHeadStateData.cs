using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CA6 RID: 23718
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiTowerMergeHeadStateData
	{
		// Token: 0x0603BEBC RID: 245436 RVA: 0x00E517B6 File Offset: 0x00E4F9B6
		public void Init()
		{
		}

		// Token: 0x0603BEBD RID: 245437 RVA: 0x00E517B8 File Offset: 0x00E4F9B8
		public void OnLeaveLevel()
		{
			this.Clear();
		}

		// Token: 0x0603BEBE RID: 245438 RVA: 0x00E517C0 File Offset: 0x00E4F9C0
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

		// Token: 0x0603BEBF RID: 245439 RVA: 0x00E51870 File Offset: 0x00E4FA70
		public void UpdateTowerMonsterHpInfo(NewTowerMonsterHpInfoNotify notify)
		{
			this.UpdateProgress(notify.MonsterHpInfos);
		}

		// Token: 0x0603BEC0 RID: 245440 RVA: 0x00E51880 File Offset: 0x00E4FA80
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

		// Token: 0x0603BEC1 RID: 245441 RVA: 0x00E51AF0 File Offset: 0x00E4FCF0
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

		// Token: 0x0603BEC2 RID: 245442 RVA: 0x00E51BA0 File Offset: 0x00E4FDA0
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

		// Token: 0x0603BEC3 RID: 245443 RVA: 0x00E51C10 File Offset: 0x00E4FE10
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

		// Token: 0x0603BEC4 RID: 245444 RVA: 0x00E51C74 File Offset: 0x00E4FE74
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

		// Token: 0x0603BEC5 RID: 245445 RVA: 0x00E51D02 File Offset: 0x00E4FF02
		private void AttachMonsterListener(TowerMergeHeadStateMonsterInfo monsterInfo)
		{
			if (!monsterInfo.AddListener())
			{
				return;
			}
			this.ListenMonsterRemoveMap[monsterInfo.EntityHandle.Id] = monsterInfo;
		}

		// Token: 0x0603BEC6 RID: 245446 RVA: 0x00E51D24 File Offset: 0x00E4FF24
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

		// Token: 0x0603BEC7 RID: 245447 RVA: 0x00E51E00 File Offset: 0x00E50000
		private void DispatchHpChanged()
		{
			if (this.Info == null)
			{
				return;
			}
			EventSystem.Instance.Emit<TowerMergeHeadStateInfo>(EEventName.BattleUiTowerMergeHeadStateMonsterHpChanged, this.Info);
		}

		// Token: 0x0401F450 RID: 128080
		[Nullable(2)]
		public TowerMergeHeadStateInfo Info;

		// Token: 0x0401F451 RID: 128081
		private readonly Dictionary<long, TowerMergeHeadStateMonsterInfo> ListenMonsterAddMap = new Dictionary<long, TowerMergeHeadStateMonsterInfo>();

		// Token: 0x0401F452 RID: 128082
		private readonly Dictionary<int, TowerMergeHeadStateMonsterInfo> ListenMonsterRemoveMap = new Dictionary<int, TowerMergeHeadStateMonsterInfo>();
	}
}
