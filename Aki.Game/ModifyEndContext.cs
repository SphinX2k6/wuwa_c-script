using System;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x0200021B RID: 539
public class ModifyEndContext
{
	// Token: 0x060020EC RID: 8428 RVA: 0x000B655D File Offset: 0x000B475D
	public void Clear()
	{
		this.SkillId = 0;
	}

	// Token: 0x0400153E RID: 5438
	public ECameraModifier_Settings_ArmLengthDynamicValueType ArmLengthDynamicValueType;

	// Token: 0x0400153F RID: 5439
	public int SkillId;
}
