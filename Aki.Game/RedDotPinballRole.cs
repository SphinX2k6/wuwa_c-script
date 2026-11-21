using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028B0 RID: 10416
public class RedDotPinballRole : RedDotBase
{
	// Token: 0x0601A666 RID: 108134 RVA: 0x0082AA99 File Offset: 0x00828C99
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshPinballRoleRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A667 RID: 108135 RVA: 0x0082AAB7 File Offset: 0x00828CB7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshPinballRoleRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A668 RID: 108136 RVA: 0x0082AAD5 File Offset: 0x00828CD5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPinballRoleFunction);
	}

	// Token: 0x0601A669 RID: 108137 RVA: 0x0082AAE1 File Offset: 0x00828CE1
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}
