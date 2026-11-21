using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002938 RID: 10552
public class RedDotMoonChasingRole : RedDotBase
{
	// Token: 0x0601A8C4 RID: 108740 RVA: 0x0082F331 File Offset: 0x0082D531
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingDelegation);
	}

	// Token: 0x0601A8C5 RID: 108741 RVA: 0x0082F33D File Offset: 0x0082D53D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshRoleRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8C6 RID: 108742 RVA: 0x0082F35B File Offset: 0x0082D55B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshRoleRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8C7 RID: 108743 RVA: 0x0082F379 File Offset: 0x0082D579
	protected override bool OnCheck(int uId = 0)
	{
		return MoonChasingModel.Instance.CheckRoleRedDotState();
	}
}
