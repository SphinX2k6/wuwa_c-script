using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;

// Token: 0x020029AB RID: 10667
public class RedDotSpringManorAlbumReward : RedDotBase
{
	// Token: 0x0601AAF6 RID: 109302 RVA: 0x00833ED9 File Offset: 0x008320D9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBrochureBookItemStateUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AAF7 RID: 109303 RVA: 0x00833F13 File Offset: 0x00832113
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnBrochureBookItemStateUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AAF8 RID: 109304 RVA: 0x00833F4D File Offset: 0x0083214D
	protected override bool OnCheck(int uId = 0)
	{
		return SpringManorModel.Instance.CheckBookItemRedDot(EBrochureType.Character) || SpringManorModel.Instance.CheckBookItemRedDot(EBrochureType.EasterEggBook);
	}

	// Token: 0x0601AAF9 RID: 109305 RVA: 0x00833F69 File Offset: 0x00832169
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.SpringManorGameEntrance);
	}
}
