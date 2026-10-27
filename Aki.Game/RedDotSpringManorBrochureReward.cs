using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;

// Token: 0x02003438 RID: 13368
public class RedDotSpringManorBrochureReward : RedDotBase
{
	// Token: 0x0601CDFB RID: 118267 RVA: 0x0080D895 File Offset: 0x0080BA95
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBrochureBookItemStateUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CDFC RID: 118268 RVA: 0x0080D8CF File Offset: 0x0080BACF
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnBrochureBookItemStateUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CDFD RID: 118269 RVA: 0x0080D909 File Offset: 0x0080BB09
	protected override bool OnCheck(int uId = 0)
	{
		return SpringManorModel.Instance.CheckBookItemRedDot(EBrochureType.Brochure);
	}

	// Token: 0x0601CDFE RID: 118270 RVA: 0x0080D916 File Offset: 0x0080BB16
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.SpringManorGameEntrance);
	}
}
