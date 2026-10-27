using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x020030C2 RID: 12482
public class AceAntiCheatInputLayer : InputLayer
{
	// Token: 0x0601ABA3 RID: 109475 RVA: 0x00733E0B File Offset: 0x0073200B
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.AceAntiCheat;
	}

	// Token: 0x0601ABA4 RID: 109476 RVA: 0x00733E0F File Offset: 0x0073200F
	[NullableContext(2)]
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		AceAntiCheatController.Instance.HandlePress(action, time);
		return null;
	}
}
