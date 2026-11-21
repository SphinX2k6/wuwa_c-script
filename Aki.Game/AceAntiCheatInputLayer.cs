using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x0200261A RID: 9754
public class AceAntiCheatInputLayer : InputLayer
{
	// Token: 0x060185B2 RID: 99762 RVA: 0x00759773 File Offset: 0x00757973
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.AceAntiCheat;
	}

	// Token: 0x060185B3 RID: 99763 RVA: 0x00759777 File Offset: 0x00757977
	[NullableContext(2)]
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		AceAntiCheatController.Instance.HandlePress(action, time);
		return null;
	}
}
