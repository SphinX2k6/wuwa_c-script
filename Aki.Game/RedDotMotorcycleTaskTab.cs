using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D1 RID: 13265
public class RedDotMotorcycleTaskTab : RedDotBase
{
	// Token: 0x0601CC01 RID: 117761 RVA: 0x008093ED File Offset: 0x008075ED
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC02 RID: 117762 RVA: 0x008093F0 File Offset: 0x008075F0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC03 RID: 117763 RVA: 0x0080942A File Offset: 0x0080762A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC04 RID: 117764 RVA: 0x00809464 File Offset: 0x00807664
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotCanGetAnyTaskReward();
	}
}
