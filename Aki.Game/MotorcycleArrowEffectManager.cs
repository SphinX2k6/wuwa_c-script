using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000E91 RID: 3729
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowEffectManager
{
	// Token: 0x06005B77 RID: 23415 RVA: 0x0010B17F File Offset: 0x0010937F
	public static MotorcycleArrowEffectManager Create(MotorcycleArrowSubController controller)
	{
		return new MotorcycleArrowEffectManager
		{
			Controller = controller
		};
	}

	// Token: 0x06005B78 RID: 23416 RVA: 0x0010B190 File Offset: 0x00109390
	public void AddBuffEffect(int buffEffectId, int? fixValidCount, bool bPlayerBuff)
	{
		MotorFightBuffEffect? buffEffectById = MotorcycleArrowConfig.Instance.GetBuffEffectById(buffEffectId);
		if (buffEffectById == null)
		{
			return;
		}
		if (fixValidCount != null && fixValidCount.Value <= 0)
		{
			return;
		}
		if (bPlayerBuff)
		{
			MotorcycleArrowSubModel motorcycleArrowSubModel = KuroSimpleCombatController.Instance.CurSubModel as MotorcycleArrowSubModel;
			KuroSimpleCombatController.Instance.ModifyBuffAsync(motorcycleArrowSubModel.KscPlayerEntityId, true, buffEffectById.Value.BuffId);
			KuroSimpleCombatController.Instance.ModifyBuffAsync(motorcycleArrowSubModel.MotorcycleKscEntityId, true, buffEffectById.Value.BuffId);
			if (buffEffectById.Value.DurationType == 1)
			{
				this.PlayerLevelBuff[buffEffectById.Value.BuffId] = (fixValidCount ?? buffEffectById.Value.Param1);
				return;
			}
			if (buffEffectById.Value.DurationType == 2)
			{
				this.PlayerWaveGroupBuff[buffEffectById.Value.BuffId] = (fixValidCount ?? buffEffectById.Value.Param1);
				return;
			}
		}
		else
		{
			if (buffEffectById.Value.DurationType == 1)
			{
				this.MonsterLevelBuff[buffEffectById.Value.BuffId] = (fixValidCount ?? buffEffectById.Value.Param1);
			}
			else if (buffEffectById.Value.DurationType == 2)
			{
				this.MonsterWaveGroupBuff[buffEffectById.Value.BuffId] = (fixValidCount ?? buffEffectById.Value.Param1);
			}
			this.MonsterBuff.Add(buffEffectById.Value.BuffId);
		}
	}

	// Token: 0x06005B79 RID: 23417 RVA: 0x0010B37B File Offset: 0x0010957B
	public void OnEnterNextWaveGroup()
	{
		this.OnEnterNextCount(this.PlayerWaveGroupBuff, true);
		this.OnEnterNextCount(this.MonsterWaveGroupBuff, false);
	}

	// Token: 0x06005B7A RID: 23418 RVA: 0x0010B397 File Offset: 0x00109597
	public void OnEnterNextSubLevel()
	{
		this.OnEnterNextWaveGroup();
		this.OnEnterNextCount(this.PlayerLevelBuff, true);
		this.OnEnterNextCount(this.MonsterLevelBuff, false);
	}

	// Token: 0x06005B7B RID: 23419 RVA: 0x0010B3BC File Offset: 0x001095BC
	private void OnEnterNextCount(Dictionary<int, int> buffMap, bool bPlayerBuff)
	{
		List<int> list = new List<int>(buffMap.Keys);
		for (int i = 0; i < list.Count; i++)
		{
			int num = list[i];
			int num2 = buffMap[num];
			if (num2 <= 1)
			{
				buffMap.Remove(num);
				if (bPlayerBuff)
				{
					this.RemovePlayerBuff(num);
				}
				else
				{
					this.MonsterBuff.Remove(num);
				}
			}
			else
			{
				buffMap[num] = num2 - 1;
			}
		}
	}

	// Token: 0x06005B7C RID: 23420 RVA: 0x0010B428 File Offset: 0x00109628
	public void RemovePlayerBuff(int buffId)
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = KuroSimpleCombatController.Instance.CurSubModel as MotorcycleArrowSubModel;
		KuroSimpleCombatController.Instance.ModifyBuffAsync(motorcycleArrowSubModel.KscPlayerEntityId, false, buffId);
		KuroSimpleCombatController.Instance.ModifyBuffAsync(motorcycleArrowSubModel.MotorcycleKscEntityId, false, buffId);
	}

	// Token: 0x06005B7D RID: 23421 RVA: 0x0010B469 File Offset: 0x00109669
	public void Clear()
	{
		this.PlayerLevelBuff.Clear();
		this.PlayerWaveGroupBuff.Clear();
		this.MonsterLevelBuff.Clear();
		this.MonsterWaveGroupBuff.Clear();
		this.MonsterBuff.Clear();
		this.DamageAmplifyWaveGroupId = 0;
	}

	// Token: 0x06005B7E RID: 23422 RVA: 0x0010B4AC File Offset: 0x001096AC
	public int? GetFixValidCount(MotorFightRoundBuffPb buffData)
	{
		MotorFightBuffEffect? buffEffectById = MotorcycleArrowConfig.Instance.GetBuffEffectById(buffData.BuffId);
		if (buffEffectById == null)
		{
			return null;
		}
		if (buffEffectById.Value.DurationType == 0)
		{
			return null;
		}
		if (buffEffectById.Value.DurationType == 1)
		{
			MotorcycleArrowSubModel motorcycleArrowSubModel = KuroSimpleCombatController.Instance.CurSubModel as MotorcycleArrowSubModel;
			return new int?(buffEffectById.Value.Param1 - (motorcycleArrowSubModel.SubLevelIndex - buffData.SubLevelIndex));
		}
		if (buffEffectById.Value.DurationType == 2)
		{
			MotorcycleArrowSubModel motorcycleArrowSubModel2 = KuroSimpleCombatController.Instance.CurSubModel as MotorcycleArrowSubModel;
			int num = motorcycleArrowSubModel2.WaveGroupCount[motorcycleArrowSubModel2.SubLevelIndex] - motorcycleArrowSubModel2.WaveGroupCount[buffData.SubLevelIndex] + buffData.WaveGroupIndex - motorcycleArrowSubModel2.CurrentGroupWaveIndex;
			return new int?(buffEffectById.Value.Param1 - num);
		}
		return null;
	}

	// Token: 0x06005B7F RID: 23423 RVA: 0x0010B5B8 File Offset: 0x001097B8
	public void AddPlayerBornEffect(IList<MotorFightRoundBuffPb> buffs)
	{
		for (int i = 0; i < buffs.Count; i++)
		{
			MotorFightRoundBuffPb motorFightRoundBuffPb = buffs[i];
			int? fixValidCount = this.GetFixValidCount(motorFightRoundBuffPb);
			this.AddBuffEffect(motorFightRoundBuffPb.BuffId, fixValidCount, true);
		}
	}

	// Token: 0x06005B80 RID: 23424 RVA: 0x0010B5F4 File Offset: 0x001097F4
	public void AddMonsterBornEffect(IList<MotorFightRoundBuffPb> buffs)
	{
		for (int i = 0; i < buffs.Count; i++)
		{
			MotorFightRoundBuffPb motorFightRoundBuffPb = buffs[i];
			int? fixValidCount = this.GetFixValidCount(motorFightRoundBuffPb);
			this.AddBuffEffect(motorFightRoundBuffPb.BuffId, fixValidCount, false);
		}
	}

	// Token: 0x06005B81 RID: 23425 RVA: 0x0010B630 File Offset: 0x00109830
	public void UpdateWaveDamageAmplify(int waveGroupId)
	{
		if (this.DamageAmplifyWaveGroupId == waveGroupId)
		{
			return;
		}
		this.DamageAmplifyWaveGroupId = waveGroupId;
		MotorFightWaveGroup? motorFightWaveGroupById = MotorcycleArrowConfig.Instance.GetMotorFightWaveGroupById(waveGroupId);
		if (motorFightWaveGroupById == null)
		{
			return;
		}
		int[] array = motorFightWaveGroupById.Value.GetDamageIdsArray() ?? Array.Empty<int>();
		float num = (float)motorFightWaveGroupById.Value.Amplify * 0.0001f;
		if (array.Length == 0)
		{
			return;
		}
		KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
		Dictionary<int, FKSCDamage> dictionary = (curSubModel != null) ? curSubModel.DamageIds : null;
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		UKSC_DamageId uksc_DamageId = (kscWorld != null) ? kscWorld.DamageData : null;
		if (dictionary == null || uksc_DamageId == null)
		{
			KscLog.Error(KscLog.EModule.Common, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "[摩托战斗]UpdateWaveDamageAmplify失败:未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (int num2 in array)
		{
			FKSCDamage fkscdamage;
			if (!dictionary.TryGetValue(num2, out fkscdamage))
			{
				KscLog.Error(KscLog.EModule.Common, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "[摩托战斗]UpdateWaveDamageAmplify失败:未找到伤害数据" + num2.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				uksc_DamageId.UpdateDamageAmplify(num2, fkscdamage.Amplify * num);
			}
		}
	}

	// Token: 0x040029B4 RID: 10676
	public Dictionary<int, int> PlayerLevelBuff = new Dictionary<int, int>();

	// Token: 0x040029B5 RID: 10677
	public Dictionary<int, int> PlayerWaveGroupBuff = new Dictionary<int, int>();

	// Token: 0x040029B6 RID: 10678
	public MotorcycleArrowSubController Controller;

	// Token: 0x040029B7 RID: 10679
	public HashSet<int> MonsterBuff = new HashSet<int>();

	// Token: 0x040029B8 RID: 10680
	public Dictionary<int, int> MonsterLevelBuff = new Dictionary<int, int>();

	// Token: 0x040029B9 RID: 10681
	public Dictionary<int, int> MonsterWaveGroupBuff = new Dictionary<int, int>();

	// Token: 0x040029BA RID: 10682
	private int DamageAmplifyWaveGroupId;
}
