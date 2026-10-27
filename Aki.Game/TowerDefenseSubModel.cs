using System;
using System.Runtime.CompilerServices;

// Token: 0x02000ED6 RID: 3798
[NullableContext(1)]
[Nullable(0)]
public class TowerDefenseSubModel : KscSubModelBase
{
	// Token: 0x06005EBE RID: 24254 RVA: 0x00119D36 File Offset: 0x00117F36
	public override string GetSkillDtPath()
	{
		return TowerDefenseSubModel.SkillDtPath;
	}

	// Token: 0x06005EBF RID: 24255 RVA: 0x00119D3D File Offset: 0x00117F3D
	public override string GetEntityDtPath()
	{
		return TowerDefenseSubModel.EntityDtPath;
	}

	// Token: 0x04002B02 RID: 11010
	public static readonly string SkillDtPath = "/Game/Aki/Data/SimpleCombat/2_6TaFang/Player/AssistMachine/SkillComp/DT_KscSkill_AssistMachine.DT_KscSkill_AssistMachine";

	// Token: 0x04002B03 RID: 11011
	public static readonly string EntityDtPath = "/Game/Aki/Data/SimpleCombat/2_6TaFang/Player/DT_KscEntity.DT_KscEntity";
}
