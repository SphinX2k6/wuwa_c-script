using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using UnrealEngine;

// Token: 0x0200053F RID: 1343
public class RhythmGameUtil
{
	// Token: 0x060041D9 RID: 16857 RVA: 0x0016FE54 File Offset: 0x0016E054
	[NullableContext(1)]
	public static TArray<FKuroRhythmSkillEffectParam> GetRhythmGameSkillEffectParam(int roleId)
	{
		TArray<FKuroRhythmSkillEffectParam> tarray = new TArray<FKuroRhythmSkillEffectParam>();
		RhythmRole? rhythmRoleById = RhythmShipConfig.Instance.GetRhythmRoleById(roleId);
		if (rhythmRoleById == null)
		{
			return tarray;
		}
		foreach (int id in rhythmRoleById.Value.SkillEffectListIter())
		{
			RhythmEffect? rhythmRoleEffectById = RhythmShipConfig.Instance.GetRhythmRoleEffectById(id);
			if (rhythmRoleEffectById != null)
			{
				FKuroRhythmSkillEffectParam fkuroRhythmSkillEffectParam = new FKuroRhythmSkillEffectParam();
				fkuroRhythmSkillEffectParam.EffectType = rhythmRoleEffectById.Value.Type;
				TArray<string> tarray2 = new TArray<string>();
				if (rhythmRoleEffectById.Value.Param1 != "")
				{
					tarray2.Add(rhythmRoleEffectById.Value.Param1);
				}
				if (rhythmRoleEffectById.Value.Param2 != "")
				{
					tarray2.Add(rhythmRoleEffectById.Value.Param2);
				}
				if (rhythmRoleEffectById.Value.Param3 != "")
				{
					tarray2.Add(rhythmRoleEffectById.Value.Param3);
				}
				fkuroRhythmSkillEffectParam.EffectParams = tarray2;
				tarray.Add(fkuroRhythmSkillEffectParam);
			}
		}
		return tarray;
	}
}
