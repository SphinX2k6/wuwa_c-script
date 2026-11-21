using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002941 RID: 10561
public class RedDotMotorcycleLevelTab : RedDotBase
{
	// Token: 0x0601A8EF RID: 108783 RVA: 0x0082F905 File Offset: 0x0082DB05
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A8F0 RID: 108784 RVA: 0x0082F908 File Offset: 0x0082DB08
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8F1 RID: 108785 RVA: 0x0082F926 File Offset: 0x0082DB26
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8F2 RID: 108786 RVA: 0x0082F944 File Offset: 0x0082DB44
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotHasLevelUpReward();
	}
}
