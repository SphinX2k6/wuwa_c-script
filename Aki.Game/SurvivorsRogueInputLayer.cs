using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x02000374 RID: 884
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueInputLayer : InputLayer
{
	// Token: 0x06003132 RID: 12594 RVA: 0x0011C63D File Offset: 0x0011A83D
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.SurvivorsRogue;
	}

	// Token: 0x06003133 RID: 12595 RVA: 0x0011C644 File Offset: 0x0011A844
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

	// Token: 0x06003134 RID: 12596 RVA: 0x0011C685 File Offset: 0x0011A885
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06003135 RID: 12597 RVA: 0x0011C68C File Offset: 0x0011A88C
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x0011C694 File Offset: 0x0011A894
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
