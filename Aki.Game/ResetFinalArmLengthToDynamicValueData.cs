using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x0200021A RID: 538
public class ResetFinalArmLengthToDynamicValueData
{
	// Token: 0x060020EB RID: 8427 RVA: 0x000B652B File Offset: 0x000B472B
	[NullableContext(1)]
	public ResetFinalArmLengthToDynamicValueData(SCameraModifier_Settings_ArmLengthDynamicValue data)
	{
	}

	// Token: 0x0400153B RID: 5435
	public ECameraModifier_Settings_ArmLengthDynamicValueType ArmLengthDynamicValueType = data.ArmLengthDynamicValueType;

	// Token: 0x0400153C RID: 5436
	public int SkillId = data.SkillId;

	// Token: 0x0400153D RID: 5437
	public float ArmLength = (float)data.ArmLength;
}
