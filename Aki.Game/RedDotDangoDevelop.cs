using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028EB RID: 10475
public class RedDotDangoDevelop : RedDotBase
{
	// Token: 0x0601A763 RID: 108387 RVA: 0x0082C773 File Offset: 0x0082A973
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A764 RID: 108388 RVA: 0x0082C778 File Offset: 0x0082A978
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssAddRole, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.RefreshAbyssDevelopRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A765 RID: 108389 RVA: 0x0082C814 File Offset: 0x0082AA14
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssAddRole, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.RefreshAbyssDevelopRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A766 RID: 108390 RVA: 0x0082C8AD File Offset: 0x0082AAAD
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.GetDangoDevelopRedDot();
	}

	// Token: 0x0601A767 RID: 108391 RVA: 0x0082C8B9 File Offset: 0x0082AAB9
	private void OnEventTwoInt(int _1, int _2)
	{
		base.EventCheck();
	}
}
