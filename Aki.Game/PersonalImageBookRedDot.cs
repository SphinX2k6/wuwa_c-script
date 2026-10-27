using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x020033E8 RID: 13288
public class PersonalImageBookRedDot : RedDotBase
{
	// Token: 0x0601CC73 RID: 117875 RVA: 0x0080A153 File Offset: 0x00808353
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPersonalTipStateSet, new Action(base.EventCheck));
	}

	// Token: 0x0601CC74 RID: 117876 RVA: 0x0080A171 File Offset: 0x00808371
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPersonalTipStateSet, new Action(base.EventCheck));
	}

	// Token: 0x0601CC75 RID: 117877 RVA: 0x0080A18F File Offset: 0x0080838F
	protected override bool OnCheck(int uId = 0)
	{
		return PersonalModel.Instance.CheckCanShowPersonalTip();
	}
}
