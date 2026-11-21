using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200296C RID: 10604
public class RedDotPhantomInteractUnlock : RedDotBase
{
	// Token: 0x0601A9C2 RID: 108994 RVA: 0x00830F37 File Offset: 0x0082F137
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomInteractModel.Instance.CheckPhantomInteractUnlockRedDot(uId);
	}

	// Token: 0x0601A9C3 RID: 108995 RVA: 0x00830F44 File Offset: 0x0082F144
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9C4 RID: 108996 RVA: 0x00830F62 File Offset: 0x0082F162
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}
}
