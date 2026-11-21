using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x02002621 RID: 9761
[NullableContext(2)]
[Nullable(0)]
public class OverShoulderInputLayer : InputLayer
{
	// Token: 0x06018601 RID: 99841 RVA: 0x0075B661 File Offset: 0x00759861
	[NullableContext(1)]
	public void Init(Entity entity)
	{
		this.InputComp = entity.GetComponent<CharacterInputComponent>();
	}

	// Token: 0x06018602 RID: 99842 RVA: 0x0075B66F File Offset: 0x0075986F
	public override void Clear()
	{
		this.InputComp = null;
	}

	// Token: 0x06018603 RID: 99843 RVA: 0x0075B678 File Offset: 0x00759878
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.OverShoulder;
	}

	// Token: 0x06018604 RID: 99844 RVA: 0x0075B67C File Offset: 0x0075987C
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

	// Token: 0x06018605 RID: 99845 RVA: 0x0075B69F File Offset: 0x0075989F
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (action == 5)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x06018606 RID: 99846 RVA: 0x0075B6B1 File Offset: 0x007598B1
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (action == 5)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0400D271 RID: 53873
	protected CharacterInputComponent InputComp;
}
