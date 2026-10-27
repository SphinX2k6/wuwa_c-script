using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x02000EBC RID: 3772
[NullableContext(2)]
[Nullable(0)]
public class PotatoInputLayer : InputLayer
{
	// Token: 0x06005D8A RID: 23946 RVA: 0x00114645 File Offset: 0x00112845
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Potato;
	}

	// Token: 0x06005D8B RID: 23947 RVA: 0x00114649 File Offset: 0x00112849
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (5 == action)
		{
			this.ExecSkillDodge();
		}
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005D8C RID: 23948 RVA: 0x0011465F File Offset: 0x0011285F
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005D8D RID: 23949 RVA: 0x00114666 File Offset: 0x00112866
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005D8E RID: 23950 RVA: 0x00114670 File Offset: 0x00112870
	private void ExecSkillDodge()
	{
		KscSubControllerBase curSubController = KuroSimpleCombatController.Instance.CurSubController;
		if (curSubController == null || !(curSubController is PotatoSubController))
		{
			return;
		}
		((PotatoSubController)curSubController).ExecSkillDodge();
	}
}
