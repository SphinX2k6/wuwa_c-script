using System;
using System.Runtime.CompilerServices;

// Token: 0x0200038B RID: 907
[NullableContext(1)]
[Nullable(0)]
public class TowerDefenseSubModel : KscSubModelBase
{
	// Token: 0x06003255 RID: 12885 RVA: 0x00121A16 File Offset: 0x0011FC16
	public override string GetSkillDtPath()
	{
		return TowerDefenseSubModel.SkillDtPath;
	}

	// Token: 0x06003256 RID: 12886 RVA: 0x00121A1D File Offset: 0x0011FC1D
	public override string GetEntityDtPath()
	{
		return TowerDefenseSubModel.EntityDtPath;
	}

	// Token: 0x04002B9D RID: 11165
	public static readonly string SkillDtPath = "/Game/Aki/Data/SimpleCombat/2_6TaFang/Player/AssistMachine/SkillComp/DT_KscSkill_AssistMachine.DT_KscSkill_AssistMachine";

	// Token: 0x04002B9E RID: 11166
	public static readonly string EntityDtPath = "/Game/Aki/Data/SimpleCombat/2_6TaFang/Player/DT_KscEntity.DT_KscEntity";
}
