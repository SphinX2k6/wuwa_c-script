using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028CD RID: 10445
public class RedDotAdventureNewSoundAreaGeneral : RedDotBase
{
	// Token: 0x0601A6E0 RID: 108256 RVA: 0x0082B8A0 File Offset: 0x00829AA0
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.AdventureNewSoundAreaTab);
	}

	// Token: 0x0601A6E1 RID: 108257 RVA: 0x0082B8A9 File Offset: 0x00829AA9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotNewSoundAreaTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6E2 RID: 108258 RVA: 0x0082B8E3 File Offset: 0x00829AE3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotNewSoundAreaTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6E3 RID: 108259 RVA: 0x0082B91D File Offset: 0x00829B1D
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideModel.Instance.CheckRedDotAdventureNewSoundAreaTab();
	}
}
