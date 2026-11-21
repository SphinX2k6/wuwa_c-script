using System;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x0200021F RID: 543
public class ModifyEndContext
{
	// Token: 0x0600219A RID: 8602 RVA: 0x000BD87D File Offset: 0x000BBA7D
	public void Clear()
	{
		this.SkillId = 0;
	}

	// Token: 0x04001580 RID: 5504
	public ECameraModifier_Settings_ArmLengthDynamicValueType ArmLengthDynamicValueType;

	// Token: 0x04001581 RID: 5505
	public int SkillId;
}
