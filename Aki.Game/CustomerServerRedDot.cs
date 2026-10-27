using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003429 RID: 13353
public class CustomerServerRedDot : RedDotBase
{
	// Token: 0x0601CDAC RID: 118188 RVA: 0x0080CB59 File Offset: 0x0080AD59
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SdkCustomerRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CDAD RID: 118189 RVA: 0x0080CB77 File Offset: 0x0080AD77
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SdkCustomerRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CDAE RID: 118190 RVA: 0x0080CB95 File Offset: 0x0080AD95
	protected override bool OnCheck(int uId = 0)
	{
		return KuroSdkController.Instance.GetCustomerServiceRedPointState();
	}
}
