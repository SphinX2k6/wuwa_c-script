using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001C43 RID: 7235
public class ExploreSkillFlagDefine : IStaticVariableResetter
{
	// Token: 0x0600DA32 RID: 55858 RVA: 0x0032B053 File Offset: 0x00329253
	static ExploreSkillFlagDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreSkillFlagDefine.CreateStaticDefaultValue), new Action(ExploreSkillFlagDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600DA33 RID: 55859 RVA: 0x0032B074 File Offset: 0x00329274
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

	// Token: 0x0600DA34 RID: 55860 RVA: 0x0032B1A0 File Offset: 0x003293A0
	public static void ResetStaticDefaultValue()
	{
		ExploreSkillFlagDefine.levelExploreSkillFlagDefaultVal = null;
		ExploreSkillFlagDefine.levelOperationRestrictExploreSkillTypes = null;
	}

	// Token: 0x0400635C RID: 25436
	[Nullable(2)]
	public static Dictionary<EExploreSkillType, bool> levelExploreSkillFlagDefaultVal;

	// Token: 0x0400635D RID: 25437
	[Nullable(2)]
	public static EExploreSkillType[] levelOperationRestrictExploreSkillTypes;
}
