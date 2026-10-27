using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x02000EBF RID: 3775
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueInputLayer : InputLayer
{
	// Token: 0x06005D9B RID: 23963 RVA: 0x0011495D File Offset: 0x00112B5D
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.SurvivorsRogue;
	}

	// Token: 0x06005D9C RID: 23964 RVA: 0x00114964 File Offset: 0x00112B64
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		switch (action)
		{
		case 3:
		case 5:
			return null;
		case 6:
			this.ExecSkillAction();
			return InputLayer.GetSwallowCommand();
		}
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005D9D RID: 23965 RVA: 0x001149A5 File Offset: 0x00112BA5
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005D9E RID: 23966 RVA: 0x001149AC File Offset: 0x00112BAC
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005D9F RID: 23967 RVA: 0x001149B4 File Offset: 0x00112BB4
	private void ExecSkillAction()
	{
		KscSubControllerBase curSubController = KuroSimpleCombatController.Instance.CurSubController;
		if (curSubController == null)
		{
			return;
		}
		((SurvivorsRogueSubController)curSubController).ExecSkillAction();
	}
}
