using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x0200261F RID: 9759
[NullableContext(2)]
[Nullable(0)]
public class InteractionInputLayer : InputLayer
{
	// Token: 0x060185EF RID: 99823 RVA: 0x0075B19C File Offset: 0x0075939C
	[NullableContext(1)]
	public void Init(Func<EInputAction?> getTriggerAction, Action onPress, Action onRelease)
	{
		this.GetTriggerAction = getTriggerAction;
		this.OnPress = onPress;
		this.OnRelease = onRelease;
	}

	// Token: 0x060185F0 RID: 99824 RVA: 0x0075B1B3 File Offset: 0x007593B3
	public override void Clear()
	{
		this.GetTriggerAction = null;
		this.OnPress = null;
		this.OnRelease = null;
		this.PressedAction = EInputAction.None;
	}

	// Token: 0x060185F1 RID: 99825 RVA: 0x0075B1D5 File Offset: 0x007593D5
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Interaction;
	}

	// Token: 0x060185F2 RID: 99826 RVA: 0x0075B1D8 File Offset: 0x007593D8
	private bool Matches(EInputAction action)
	{
		if (action == EInputAction.None)
		{
			return false;
		}
		Func<EInputAction?> getTriggerAction = this.GetTriggerAction;
		return getTriggerAction != null && getTriggerAction() == action;
	}

	// Token: 0x060185F3 RID: 99827 RVA: 0x0075B220 File Offset: 0x00759420
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (this.Matches(action))
		{
			this.PressedAction = action;
			Action onPress = this.OnPress;
			if (onPress != null)
			{
				onPress();
			}
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x060185F4 RID: 99828 RVA: 0x0075B24C File Offset: 0x0075944C
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (this.PressedAction != EInputAction.None && action == this.PressedAction)
		{
			this.PressedAction = EInputAction.None;
			Action onRelease = this.OnRelease;
			if (onRelease != null)
			{
				onRelease();
			}
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x060185F5 RID: 99829 RVA: 0x0075B29C File Offset: 0x0075949C
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (this.PressedAction != EInputAction.None && action == this.PressedAction)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0400D265 RID: 53861
	private Func<EInputAction?> GetTriggerAction;

	// Token: 0x0400D266 RID: 53862
	private Action OnPress;

	// Token: 0x0400D267 RID: 53863
	private Action OnRelease;

	// Token: 0x0400D268 RID: 53864
	private EInputAction PressedAction = EInputAction.None;
}
