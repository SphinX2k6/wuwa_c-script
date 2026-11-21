using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x02002623 RID: 9763
[NullableContext(2)]
[Nullable(0)]
public class SwallowInputLayer : InputLayer
{
	// Token: 0x06018610 RID: 99856 RVA: 0x0075B7E1 File Offset: 0x007599E1
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Swallow;
	}

	// Token: 0x06018611 RID: 99857 RVA: 0x0075B7E5 File Offset: 0x007599E5
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06018612 RID: 99858 RVA: 0x0075B7EC File Offset: 0x007599EC
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06018613 RID: 99859 RVA: 0x0075B7F3 File Offset: 0x007599F3
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		return InputLayer.GetSwallowCommand();
	}
}
