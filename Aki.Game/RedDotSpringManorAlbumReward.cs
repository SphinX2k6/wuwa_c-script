using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;

// Token: 0x02003437 RID: 13367
public class RedDotSpringManorAlbumReward : RedDotBase
{
	// Token: 0x0601CDF6 RID: 118262 RVA: 0x0080D7F1 File Offset: 0x0080B9F1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBrochureBookItemStateUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CDF7 RID: 118263 RVA: 0x0080D82B File Offset: 0x0080BA2B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnBrochureBookItemStateUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CDF8 RID: 118264 RVA: 0x0080D865 File Offset: 0x0080BA65
	protected override bool OnCheck(int uId = 0)
	{
		return SpringManorModel.Instance.CheckBookItemRedDot(EBrochureType.Character) || SpringManorModel.Instance.CheckBookItemRedDot(EBrochureType.EasterEggBook);
	}

	// Token: 0x0601CDF9 RID: 118265 RVA: 0x0080D881 File Offset: 0x0080BA81
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.SpringManorGameEntrance);
	}
}
