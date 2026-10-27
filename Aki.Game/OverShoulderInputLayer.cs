using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x020030C9 RID: 12489
[NullableContext(2)]
[Nullable(0)]
public class OverShoulderInputLayer : InputLayer
{
	// Token: 0x0601ABED RID: 109549 RVA: 0x007359C5 File Offset: 0x00733BC5
	[NullableContext(1)]
	public void Init(Entity entity)
	{
		this.InputComp = entity.GetComponent<CharacterInputComponent>();
	}

	// Token: 0x0601ABEE RID: 109550 RVA: 0x007359D3 File Offset: 0x00733BD3
	public override void Clear()
	{
		this.InputComp = null;
	}

	// Token: 0x0601ABEF RID: 109551 RVA: 0x007359DC File Offset: 0x00733BDC
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.OverShoulder;
	}

	// Token: 0x0601ABF0 RID: 109552 RVA: 0x007359E0 File Offset: 0x00733BE0
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (action == 5)
		{
			CharacterInputComponent inputComp = this.InputComp;
			if (inputComp != null)
			{
				inputComp.TrySwitchOverShoulderSprintMode();
			}
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABF1 RID: 109553 RVA: 0x00735A03 File Offset: 0x00733C03
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (action == 5)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABF2 RID: 109554 RVA: 0x00735A15 File Offset: 0x00733C15
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (action == 5)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0400CE81 RID: 52865
	protected CharacterInputComponent InputComp;
}
