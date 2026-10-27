using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200337E RID: 13182
public class RedDotDangoRole : RedDotBase
{
	// Token: 0x0601CA8B RID: 117387 RVA: 0x00806651 File Offset: 0x00804851
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotDangoDevelop);
	}

	// Token: 0x0601CA8C RID: 117388 RVA: 0x0080665D File Offset: 0x0080485D
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CA8D RID: 117389 RVA: 0x00806660 File Offset: 0x00804860
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssAddRole, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.RefreshAbyssDevelopRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CA8E RID: 117390 RVA: 0x008066FC File Offset: 0x008048FC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssAddRole, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.RefreshAbyssDevelopRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CA8F RID: 117391 RVA: 0x00806795 File Offset: 0x00804995
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.GetDangoRoleRedDot(uId);
	}

	// Token: 0x0601CA90 RID: 117392 RVA: 0x008067A2 File Offset: 0x008049A2
	private void OnEventTwoInt(int _1, int _2)
	{
		base.EventCheck();
	}
}
