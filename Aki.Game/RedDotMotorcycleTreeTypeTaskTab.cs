using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D3 RID: 13267
public class RedDotMotorcycleTreeTypeTaskTab : RedDotBase
{
	// Token: 0x0601CC0C RID: 117772 RVA: 0x008095B9 File Offset: 0x008077B9
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC0D RID: 117773 RVA: 0x008095BC File Offset: 0x008077BC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC0E RID: 117774 RVA: 0x008095F6 File Offset: 0x008077F6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC0F RID: 117775 RVA: 0x00809630 File Offset: 0x00807830
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotCanGetTaskReward(new int?(uId));
	}
}
