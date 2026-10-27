using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x020030C7 RID: 12487
[NullableContext(2)]
[Nullable(0)]
public class InteractionInputLayer : InputLayer
{
	// Token: 0x0601ABDB RID: 109531 RVA: 0x00735540 File Offset: 0x00733740
	[NullableContext(1)]
	public void Init(Func<EInputAction?> getTriggerAction, Action onPress, Action onRelease)
	{
		this.GetTriggerAction = getTriggerAction;
		this.OnPress = onPress;
		this.OnRelease = onRelease;
	}

	// Token: 0x0601ABDC RID: 109532 RVA: 0x00735557 File Offset: 0x00733757
	public override void Clear()
	{
		this.GetTriggerAction = null;
		this.OnPress = null;
		this.OnRelease = null;
		this.PressedAction = EInputAction.None;
	}

	// Token: 0x0601ABDD RID: 109533 RVA: 0x00735579 File Offset: 0x00733779
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Interaction;
	}

	// Token: 0x0601ABDE RID: 109534 RVA: 0x0073557C File Offset: 0x0073377C
	private bool Matches(EInputAction action)
	{
		if (action == EInputAction.None)
		{
			return false;
		}
		Func<EInputAction?> getTriggerAction = this.GetTriggerAction;
		return getTriggerAction != null && getTriggerAction() == action;
	}

	// Token: 0x0601ABDF RID: 109535 RVA: 0x007355C4 File Offset: 0x007337C4
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

	// Token: 0x0601ABE0 RID: 109536 RVA: 0x007355F0 File Offset: 0x007337F0
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

	// Token: 0x0601ABE1 RID: 109537 RVA: 0x00735640 File Offset: 0x00733840
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (this.PressedAction != EInputAction.None && action == this.PressedAction)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0400CE77 RID: 52855
	private Func<EInputAction?> GetTriggerAction;

	// Token: 0x0400CE78 RID: 52856
	private Action OnPress;

	// Token: 0x0400CE79 RID: 52857
	private Action OnRelease;

	// Token: 0x0400CE7A RID: 52858
	private EInputAction PressedAction = EInputAction.None;
}
