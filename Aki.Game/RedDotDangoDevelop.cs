using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003379 RID: 13177
public class RedDotDangoDevelop : RedDotBase
{
	// Token: 0x0601CA6B RID: 117355 RVA: 0x008061AF File Offset: 0x008043AF
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CA6C RID: 117356 RVA: 0x008061B4 File Offset: 0x008043B4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssAddRole, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.RefreshAbyssDevelopRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CA6D RID: 117357 RVA: 0x00806250 File Offset: 0x00804450
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssAddRole, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.RefreshAbyssDevelopRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CA6E RID: 117358 RVA: 0x008062E9 File Offset: 0x008044E9
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.GetDangoDevelopRedDot();
	}

	// Token: 0x0601CA6F RID: 117359 RVA: 0x008062F5 File Offset: 0x008044F5
	private void OnEventTwoInt(int _1, int _2)
	{
		base.EventCheck();
	}
}
