using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Infrastructure;

// Token: 0x020033AB RID: 13227
public class RedDotInfrArchive : RedDotBase
{
	// Token: 0x0601CB54 RID: 117588 RVA: 0x00807E22 File Offset: 0x00806022
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Infrastructure);
	}

	// Token: 0x0601CB55 RID: 117589 RVA: 0x00807E2E File Offset: 0x0080602E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.InfrastructureArchiveTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.InfrastructurePhoneTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CB56 RID: 117590 RVA: 0x00807E68 File Offset: 0x00806068
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.InfrastructureArchiveTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.InfrastructurePhoneTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CB57 RID: 117591 RVA: 0x00807EA2 File Offset: 0x008060A2
	protected override bool OnCheck(int uId = 0)
	{
		return InfrastructureModel.Instance.GetArchiveRedDot();
	}
}
