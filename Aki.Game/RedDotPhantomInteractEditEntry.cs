using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200296A RID: 10602
public class RedDotPhantomInteractEditEntry : RedDotBase
{
	// Token: 0x0601A9B8 RID: 108984 RVA: 0x00830E91 File Offset: 0x0082F091
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomInteractModel.Instance.CheckAnyPhantomInteractUnlockRedDot();
	}

	// Token: 0x0601A9B9 RID: 108985 RVA: 0x00830E9D File Offset: 0x0082F09D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9BA RID: 108986 RVA: 0x00830EBB File Offset: 0x0082F0BB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9BB RID: 108987 RVA: 0x00830ED9 File Offset: 0x0082F0D9
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
