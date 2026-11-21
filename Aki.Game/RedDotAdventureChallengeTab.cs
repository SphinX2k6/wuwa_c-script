using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028C5 RID: 10437
public class RedDotAdventureChallengeTab : RedDotBase
{
	// Token: 0x0601A6BB RID: 108219 RVA: 0x0082B32E File Offset: 0x0082952E
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionAdventure);
	}

	// Token: 0x0601A6BC RID: 108220 RVA: 0x0082B337 File Offset: 0x00829537
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotAdventureChallengeTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6BD RID: 108221 RVA: 0x0082B355 File Offset: 0x00829555
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotAdventureChallengeTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6BE RID: 108222 RVA: 0x0082B373 File Offset: 0x00829573
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideModel.Instance.CheckRedDotChallengeTab();
	}
}
