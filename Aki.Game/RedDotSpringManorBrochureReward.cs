using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;

// Token: 0x020029AC RID: 10668
public class RedDotSpringManorBrochureReward : RedDotBase
{
	// Token: 0x0601AAFB RID: 109307 RVA: 0x00833F7D File Offset: 0x0083217D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBrochureBookItemStateUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AAFC RID: 109308 RVA: 0x00833FB7 File Offset: 0x008321B7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnBrochureBookItemStateUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AAFD RID: 109309 RVA: 0x00833FF1 File Offset: 0x008321F1
	protected override bool OnCheck(int uId = 0)
	{
		return SpringManorModel.Instance.CheckBookItemRedDot(EBrochureType.Brochure);
	}

	// Token: 0x0601AAFE RID: 109310 RVA: 0x00833FFE File Offset: 0x008321FE
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.SpringManorGameEntrance);
	}
}
