using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Infrastructure;

// Token: 0x0200291D RID: 10525
public class RedDotInfrArchive : RedDotBase
{
	// Token: 0x0601A84C RID: 108620 RVA: 0x0082E3E6 File Offset: 0x0082C5E6
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Infrastructure);
	}

	// Token: 0x0601A84D RID: 108621 RVA: 0x0082E3F2 File Offset: 0x0082C5F2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.InfrastructureArchiveTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.InfrastructurePhoneTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A84E RID: 108622 RVA: 0x0082E42C File Offset: 0x0082C62C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.InfrastructureArchiveTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.InfrastructurePhoneTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A84F RID: 108623 RVA: 0x0082E466 File Offset: 0x0082C666
	protected override bool OnCheck(int uId = 0)
	{
		return InfrastructureModel.Instance.GetArchiveRedDot();
	}
}
