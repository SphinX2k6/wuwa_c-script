using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200299B RID: 10651
public class CustomerServerRedDot : RedDotBase
{
	// Token: 0x0601AAA4 RID: 109220 RVA: 0x0083311D File Offset: 0x0083131D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SdkCustomerRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AAA5 RID: 109221 RVA: 0x0083313B File Offset: 0x0083133B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SdkCustomerRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AAA6 RID: 109222 RVA: 0x00833159 File Offset: 0x00831359
	protected override bool OnCheck(int uId = 0)
	{
		return KuroSdkController.Instance.GetCustomerServiceRedPointState();
	}
}
