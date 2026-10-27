using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

// Token: 0x020030C6 RID: 12486
[NullableContext(2)]
[Nullable(0)]
public class HoldingHandsInputLayer : InputLayer
{
	// Token: 0x0601ABD2 RID: 109522 RVA: 0x00735405 File Offset: 0x00733605
	[NullableContext(1)]
	public void Init(CharacterHoldingHandsComponent holdingComp)
	{
		this.HoldingHandsComp = holdingComp;
		this.LongHoldLeaveTime = holdingComp.Params.LongPressDuration;
	}

	// Token: 0x0601ABD3 RID: 109523 RVA: 0x0073541F File Offset: 0x0073361F
	public override void Clear()
	{
		this.HoldingHandsComp = null;
		this.HoldingActionMap.Clear();
	}

	// Token: 0x0601ABD4 RID: 109524 RVA: 0x00735433 File Offset: 0x00733633
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.HoldingHands;
	}

	// Token: 0x0601ABD5 RID: 109525 RVA: 0x00735437 File Offset: 0x00733637
	public bool GetIsHoldingHands()
	{
		return this.HoldingHandsComp.GetRoleState() > EHoldingHandsRoleState.None;
	}

	// Token: 0x0601ABD6 RID: 109526 RVA: 0x00735447 File Offset: 0x00733647
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (action == 6)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABD7 RID: 109527 RVA: 0x0073545C File Offset: 0x0073365C
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (action == 6)
		{
			if (this.GetIsHoldingHands())
			{
				if (!this.HoldingActionMap.ContainsKey(action))
				{
					EventSystem.Instance.Emit<EInputAction>(EEventName.SkillLongPressStart, action);
				}
				if ((double)time > this.LongHoldLeaveTime)
				{
					CharacterHoldingHandsComponent holdingHandsComp = this.HoldingHandsComp;
					if (holdingHandsComp != null)
					{
						holdingHandsComp.ReleaseAllHands("长按技能键", true, true);
					}
					EventSystem.Instance.Emit<EInputAction>(EEventName.SkillLongPressEnd, action);
				}
				this.HoldingActionMap[action] = true;
			}
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABD8 RID: 109528 RVA: 0x007354E0 File Offset: 0x007336E0
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		this.HoldingActionMap.Remove(action);
		if (action == 6)
		{
			EventSystem.Instance.Emit<EInputAction>(EEventName.SkillLongPressEnd, action);
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABD9 RID: 109529 RVA: 0x00735510 File Offset: 0x00733710
	public bool IsHoldingAction(EInputAction action)
	{
		return this.HoldingActionMap.ContainsKey(action);
	}

	// Token: 0x0400CE74 RID: 52852
	public double LongHoldLeaveTime = 1.0;

	// Token: 0x0400CE75 RID: 52853
	private CharacterHoldingHandsComponent HoldingHandsComp;

	// Token: 0x0400CE76 RID: 52854
	[Nullable(1)]
	private readonly Dictionary<EInputAction, bool> HoldingActionMap = new Dictionary<EInputAction, bool>();
}
