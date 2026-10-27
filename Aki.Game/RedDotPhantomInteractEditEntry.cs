using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033F8 RID: 13304
public class RedDotPhantomInteractEditEntry : RedDotBase
{
	// Token: 0x0601CCC0 RID: 117952 RVA: 0x0080A8CD File Offset: 0x00808ACD
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomInteractModel.Instance.CheckAnyPhantomInteractUnlockRedDot();
	}

	// Token: 0x0601CCC1 RID: 117953 RVA: 0x0080A8D9 File Offset: 0x00808AD9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCC2 RID: 117954 RVA: 0x0080A8F7 File Offset: 0x00808AF7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCC3 RID: 117955 RVA: 0x0080A915 File Offset: 0x00808B15
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
