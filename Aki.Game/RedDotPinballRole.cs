using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200333E RID: 13118
public class RedDotPinballRole : RedDotBase
{
	// Token: 0x0601C96E RID: 117102 RVA: 0x008044D5 File Offset: 0x008026D5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshPinballRoleRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C96F RID: 117103 RVA: 0x008044F3 File Offset: 0x008026F3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshPinballRoleRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C970 RID: 117104 RVA: 0x00804511 File Offset: 0x00802711
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPinballRoleFunction);
	}

	// Token: 0x0601C971 RID: 117105 RVA: 0x0080451D File Offset: 0x0080271D
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}
