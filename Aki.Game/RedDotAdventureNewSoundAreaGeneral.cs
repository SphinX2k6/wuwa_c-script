using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200335B RID: 13147
public class RedDotAdventureNewSoundAreaGeneral : RedDotBase
{
	// Token: 0x0601C9E8 RID: 117224 RVA: 0x008052DC File Offset: 0x008034DC
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.AdventureNewSoundAreaTab);
	}

	// Token: 0x0601C9E9 RID: 117225 RVA: 0x008052E5 File Offset: 0x008034E5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotNewSoundAreaTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9EA RID: 117226 RVA: 0x0080531F File Offset: 0x0080351F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotNewSoundAreaTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9EB RID: 117227 RVA: 0x00805359 File Offset: 0x00803559
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideModel.Instance.CheckRedDotAdventureNewSoundAreaTab();
	}
}
