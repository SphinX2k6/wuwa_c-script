using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200344B RID: 13387
public class RedDotTutorialType : RedDotBase
{
	// Token: 0x0601CE43 RID: 118339 RVA: 0x0080DF4D File Offset: 0x0080C14D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionTutorial);
	}

	// Token: 0x0601CE44 RID: 118340 RVA: 0x0080DF56 File Offset: 0x0080C156
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<ETutorialType>(EEventName.RedDotNewTutorialType, new Action<ETutorialType>(this.OnRedDotNewTutorialType));
	}

	// Token: 0x0601CE45 RID: 118341 RVA: 0x0080DF74 File Offset: 0x0080C174
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<ETutorialType>(EEventName.RedDotNewTutorialType, new Action<ETutorialType>(this.OnRedDotNewTutorialType));
	}

	// Token: 0x0601CE46 RID: 118342 RVA: 0x0080DF92 File Offset: 0x0080C192
	protected override bool OnCheck(int uId = 0)
	{
		return TutorialModel.Instance.RedDotCheckIsNewTutorialType((ETutorialType)uId);
	}

	// Token: 0x0601CE47 RID: 118343 RVA: 0x0080DF9F File Offset: 0x0080C19F
	private void OnRedDotNewTutorialType(ETutorialType tutorialType)
	{
		base.EventCheckWithUid((int)tutorialType);
	}
}
