using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x02000371 RID: 881
[NullableContext(2)]
[Nullable(0)]
public class PotatoInputLayer : InputLayer
{
	// Token: 0x06003121 RID: 12577 RVA: 0x0011C325 File Offset: 0x0011A525
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Potato;
	}

	// Token: 0x06003122 RID: 12578 RVA: 0x0011C329 File Offset: 0x0011A529
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (5 == action)
		{
			this.ExecSkillDodge();
		}
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06003123 RID: 12579 RVA: 0x0011C33F File Offset: 0x0011A53F
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06003124 RID: 12580 RVA: 0x0011C346 File Offset: 0x0011A546
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06003125 RID: 12581 RVA: 0x0011C350 File Offset: 0x0011A550
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
