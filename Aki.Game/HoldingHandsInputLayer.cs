using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

// Token: 0x0200261E RID: 9758
[NullableContext(2)]
[Nullable(0)]
public class HoldingHandsInputLayer : InputLayer
{
	// Token: 0x060185E6 RID: 99814 RVA: 0x0075B061 File Offset: 0x00759261
	[NullableContext(1)]
	public void Init(CharacterHoldingHandsComponent holdingComp)
	{
		this.HoldingHandsComp = holdingComp;
		this.LongHoldLeaveTime = holdingComp.Params.LongPressDuration;
	}

	// Token: 0x060185E7 RID: 99815 RVA: 0x0075B07B File Offset: 0x0075927B
	public override void Clear()
	{
		this.HoldingHandsComp = null;
		this.HoldingActionMap.Clear();
	}

	// Token: 0x060185E8 RID: 99816 RVA: 0x0075B08F File Offset: 0x0075928F
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.HoldingHands;
	}

	// Token: 0x060185E9 RID: 99817 RVA: 0x0075B093 File Offset: 0x00759293
	public bool GetIsHoldingHands()
	{
		return this.HoldingHandsComp.GetRoleState() > EHoldingHandsRoleState.None;
	}

	// Token: 0x060185EA RID: 99818 RVA: 0x0075B0A3 File Offset: 0x007592A3
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (action == 6)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x060185EB RID: 99819 RVA: 0x0075B0B8 File Offset: 0x007592B8
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

	// Token: 0x060185EC RID: 99820 RVA: 0x0075B13C File Offset: 0x0075933C
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

	// Token: 0x060185ED RID: 99821 RVA: 0x0075B16C File Offset: 0x0075936C
	public bool IsHoldingAction(EInputAction action)
	{
		return this.HoldingActionMap.ContainsKey(action);
	}

	// Token: 0x0400D262 RID: 53858
	public double LongHoldLeaveTime = 1.0;

	// Token: 0x0400D263 RID: 53859
	private CharacterHoldingHandsComponent HoldingHandsComp;

	// Token: 0x0400D264 RID: 53860
	[Nullable(1)]
	private readonly Dictionary<EInputAction, bool> HoldingActionMap = new Dictionary<EInputAction, bool>();
}
