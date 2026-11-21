using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x0200021E RID: 542
public class ResetFinalArmLengthToDynamicValueData
{
	// Token: 0x06002199 RID: 8601 RVA: 0x000BD84B File Offset: 0x000BBA4B
	[NullableContext(1)]
	public ResetFinalArmLengthToDynamicValueData(SCameraModifier_Settings_ArmLengthDynamicValue data)
	{
	}

	// Token: 0x0400157D RID: 5501
	public ECameraModifier_Settings_ArmLengthDynamicValueType ArmLengthDynamicValueType = data.ArmLengthDynamicValueType;

	// Token: 0x0400157E RID: 5502
	public int SkillId = data.SkillId;

	// Token: 0x0400157F RID: 5503
	public float ArmLength = (float)data.ArmLength;
}
