using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000346 RID: 838
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowEffectManager
{
	// Token: 0x06002F0E RID: 12046 RVA: 0x00112E17 File Offset: 0x00111017
	public static MotorcycleArrowEffectManager Create(MotorcycleArrowSubController controller)
	{
		return new MotorcycleArrowEffectManager
		{
			Controller = controller
		};
	}

	// Token: 0x06002F0F RID: 12047 RVA: 0x00112E28 File Offset: 0x00111028
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

	// Token: 0x06002F10 RID: 12048 RVA: 0x00113013 File Offset: 0x00111213
	public void OnEnterNextWaveGroup()
	{
		this.OnEnterNextCount(this.PlayerWaveGroupBuff, true);
		this.OnEnterNextCount(this.MonsterWaveGroupBuff, false);
	}

	// Token: 0x06002F11 RID: 12049 RVA: 0x0011302F File Offset: 0x0011122F
	public void OnEnterNextSubLevel()
	{
		this.OnEnterNextWaveGroup();
		this.OnEnterNextCount(this.PlayerLevelBuff, true);
		this.OnEnterNextCount(this.MonsterLevelBuff, false);
	}

	// Token: 0x06002F12 RID: 12050 RVA: 0x00113054 File Offset: 0x00111254
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

	// Token: 0x06002F13 RID: 12051 RVA: 0x001130C0 File Offset: 0x001112C0
	public void RemovePlayerBuff(int buffId)
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = KuroSimpleCombatController.Instance.CurSubModel as MotorcycleArrowSubModel;
		KuroSimpleCombatController.Instance.ModifyBuffAsync(motorcycleArrowSubModel.KscPlayerEntityId, false, buffId);
		KuroSimpleCombatController.Instance.ModifyBuffAsync(motorcycleArrowSubModel.MotorcycleKscEntityId, false, buffId);
	}

	// Token: 0x06002F14 RID: 12052 RVA: 0x00113101 File Offset: 0x00111301
	public void Clear()
	{
		this.PlayerLevelBuff.Clear();
		this.PlayerWaveGroupBuff.Clear();
		this.MonsterLevelBuff.Clear();
		this.MonsterWaveGroupBuff.Clear();
		this.MonsterBuff.Clear();
		this.DamageAmplifyWaveGroupId = 0;
	}

	// Token: 0x06002F15 RID: 12053 RVA: 0x00113144 File Offset: 0x00111344
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

	// Token: 0x06002F16 RID: 12054 RVA: 0x00113250 File Offset: 0x00111450
	public void AddPlayerBornEffect(IList<MotorFightRoundBuffPb> buffs)
	{
		for (int i = 0; i < buffs.Count; i++)
		{
			MotorFightRoundBuffPb motorFightRoundBuffPb = buffs[i];
			int? fixValidCount = this.GetFixValidCount(motorFightRoundBuffPb);
			this.AddBuffEffect(motorFightRoundBuffPb.BuffId, fixValidCount, true);
		}
	}

	// Token: 0x06002F17 RID: 12055 RVA: 0x0011328C File Offset: 0x0011148C
	public void AddMonsterBornEffect(IList<MotorFightRoundBuffPb> buffs)
	{
		for (int i = 0; i < buffs.Count; i++)
		{
			MotorFightRoundBuffPb motorFightRoundBuffPb = buffs[i];
			int? fixValidCount = this.GetFixValidCount(motorFightRoundBuffPb);
			this.AddBuffEffect(motorFightRoundBuffPb.BuffId, fixValidCount, false);
		}
	}

	// Token: 0x06002F18 RID: 12056 RVA: 0x001132C8 File Offset: 0x001114C8
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

	// Token: 0x04002A4F RID: 10831
	public Dictionary<int, int> PlayerLevelBuff = new Dictionary<int, int>();

	// Token: 0x04002A50 RID: 10832
	public Dictionary<int, int> PlayerWaveGroupBuff = new Dictionary<int, int>();

	// Token: 0x04002A51 RID: 10833
	public MotorcycleArrowSubController Controller;

	// Token: 0x04002A52 RID: 10834
	public HashSet<int> MonsterBuff = new HashSet<int>();

	// Token: 0x04002A53 RID: 10835
	public Dictionary<int, int> MonsterLevelBuff = new Dictionary<int, int>();

	// Token: 0x04002A54 RID: 10836
	public Dictionary<int, int> MonsterWaveGroupBuff = new Dictionary<int, int>();

	// Token: 0x04002A55 RID: 10837
	private int DamageAmplifyWaveGroupId;
}
