using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02000B39 RID: 2873
public class RedDotCommonActivityPage : RedDotBase
{
	// Token: 0x060076DF RID: 30431 RVA: 0x0024A423 File Offset: 0x00248623
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.ActivityEntrance);
	}

	// Token: 0x060076E0 RID: 30432 RVA: 0x0024A42C File Offset: 0x0024862C
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x060076E1 RID: 30433 RVA: 0x0024A42F File Offset: 0x0024862F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x060076E2 RID: 30434 RVA: 0x0024A44D File Offset: 0x0024864D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x060076E3 RID: 30435 RVA: 0x0024A46B File Offset: 0x0024866B
	protected override bool OnCheck(int uid)
	{
		return ActivityModel.Instance.GetActivityRedDotState(uid);
	}
}
