using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001102 RID: 4354
public class ExploreSkillFlagDefine : IStaticVariableResetter
{
	// Token: 0x0600AE48 RID: 44616 RVA: 0x00336453 File Offset: 0x00334653
	static ExploreSkillFlagDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreSkillFlagDefine.CreateStaticDefaultValue), new Action(ExploreSkillFlagDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600AE49 RID: 44617 RVA: 0x00336474 File Offset: 0x00334674
	public static void CreateStaticDefaultValue()
	{
		ExploreSkillFlagDefine.levelExploreSkillFlagDefaultVal = new Dictionary<EExploreSkillType, bool>
		{
			{
				EExploreSkillType.Hook,
				true
			},
			{
				EExploreSkillType.Throw,
				true
			},
			{
				EExploreSkillType.Control,
				true
			},
			{
				EExploreSkillType.Scan,
				true
			},
			{
				EExploreSkillType.ShowVision,
				true
			},
			{
				EExploreSkillType.Photo,
				true
			},
			{
				EExploreSkillType.PlaceTemporaryTeleport,
				true
			},
			{
				EExploreSkillType.DetectSoundBox,
				true
			},
			{
				EExploreSkillType.DetectTreasure,
				true
			},
			{
				EExploreSkillType.FollowShooterEnter,
				true
			},
			{
				EExploreSkillType.Soaring,
				true
			},
			{
				EExploreSkillType.SummonMotorcycle,
				true
			},
			{
				EExploreSkillType.SummonMotorcyclePark,
				true
			},
			{
				EExploreSkillType.MotorcycleCruise,
				true
			}
		};
		Dictionary<EExploreSkillType, bool>.KeyCollection keys = ExploreSkillFlagDefine.levelExploreSkillFlagDefaultVal.Keys;
		int num = 0;
		EExploreSkillType[] array = new EExploreSkillType[2 + keys.Count];
		foreach (EExploreSkillType eexploreSkillType in keys)
		{
			array[num] = eexploreSkillType;
			num++;
		}
		array[num] = EExploreSkillType.MotorcycleHook;
		num++;
		array[num] = EExploreSkillType.MotorcycleCollect;
		ExploreSkillFlagDefine.levelOperationRestrictExploreSkillTypes = array;
	}

	// Token: 0x0600AE4A RID: 44618 RVA: 0x003365AC File Offset: 0x003347AC
	public static void ResetStaticDefaultValue()
	{
		ExploreSkillFlagDefine.levelExploreSkillFlagDefaultVal = null;
		ExploreSkillFlagDefine.levelOperationRestrictExploreSkillTypes = null;
	}

	// Token: 0x0400642E RID: 25646
	[Nullable(2)]
	public static Dictionary<EExploreSkillType, bool> levelExploreSkillFlagDefaultVal;

	// Token: 0x0400642F RID: 25647
	[Nullable(2)]
	public static EExploreSkillType[] levelOperationRestrictExploreSkillTypes;
}
