using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x020030CB RID: 12491
[NullableContext(2)]
[Nullable(0)]
public class SwallowInputLayer : InputLayer
{
	// Token: 0x0601ABFB RID: 109563 RVA: 0x00735AFB File Offset: 0x00733CFB
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Swallow;
	}

	// Token: 0x0601ABFC RID: 109564 RVA: 0x00735AFF File Offset: 0x00733CFF
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x0601ABFD RID: 109565 RVA: 0x00735B06 File Offset: 0x00733D06
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x0601ABFE RID: 109566 RVA: 0x00735B0D File Offset: 0x00733D0D
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}
}
