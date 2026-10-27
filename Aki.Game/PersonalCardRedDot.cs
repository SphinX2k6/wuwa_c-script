using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x020033E7 RID: 13287
public class PersonalCardRedDot : RedDotBase
{
	// Token: 0x0601CC6F RID: 117871 RVA: 0x0080A103 File Offset: 0x00808303
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPersonalCardRefreshRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CC70 RID: 117872 RVA: 0x0080A121 File Offset: 0x00808321
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPersonalCardRefreshRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CC71 RID: 117873 RVA: 0x0080A13F File Offset: 0x0080833F
	protected override bool OnCheck(int uId = 0)
	{
		return PersonalModel.Instance.GetPersonalCardRedDotState();
	}
}
