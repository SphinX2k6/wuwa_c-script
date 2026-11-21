using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028F0 RID: 10480
public class RedDotDangoRole : RedDotBase
{
	// Token: 0x0601A783 RID: 108419 RVA: 0x0082CC15 File Offset: 0x0082AE15
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotDangoDevelop);
	}

	// Token: 0x0601A784 RID: 108420 RVA: 0x0082CC21 File Offset: 0x0082AE21
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A785 RID: 108421 RVA: 0x0082CC24 File Offset: 0x0082AE24
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssAddRole, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.RefreshAbyssDevelopRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A786 RID: 108422 RVA: 0x0082CCC0 File Offset: 0x0082AEC0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssAddRole, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.RefreshAbyssDevelopRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A787 RID: 108423 RVA: 0x0082CD59 File Offset: 0x0082AF59
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.GetDangoRoleRedDot(uId);
	}

	// Token: 0x0601A788 RID: 108424 RVA: 0x0082CD66 File Offset: 0x0082AF66
	private void OnEventTwoInt(int _1, int _2)
	{
		base.EventCheck();
	}
}
