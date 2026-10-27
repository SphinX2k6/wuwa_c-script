using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033FA RID: 13306
public class RedDotPhantomInteractUnlock : RedDotBase
{
	// Token: 0x0601CCCA RID: 117962 RVA: 0x0080A973 File Offset: 0x00808B73
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomInteractModel.Instance.CheckPhantomInteractUnlockRedDot(uId);
	}

	// Token: 0x0601CCCB RID: 117963 RVA: 0x0080A980 File Offset: 0x00808B80
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCCC RID: 117964 RVA: 0x0080A99E File Offset: 0x00808B9E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}
}
