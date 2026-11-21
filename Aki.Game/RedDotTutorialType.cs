using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029BF RID: 10687
public class RedDotTutorialType : RedDotBase
{
	// Token: 0x0601AB43 RID: 109379 RVA: 0x00834635 File Offset: 0x00832835
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionTutorial);
	}

	// Token: 0x0601AB44 RID: 109380 RVA: 0x0083463E File Offset: 0x0083283E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<ETutorialType>(EEventName.RedDotNewTutorialType, new Action<ETutorialType>(this.OnRedDotNewTutorialType));
	}

	// Token: 0x0601AB45 RID: 109381 RVA: 0x0083465C File Offset: 0x0083285C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<ETutorialType>(EEventName.RedDotNewTutorialType, new Action<ETutorialType>(this.OnRedDotNewTutorialType));
	}

	// Token: 0x0601AB46 RID: 109382 RVA: 0x0083467A File Offset: 0x0083287A
	protected override bool OnCheck(int uId = 0)
	{
		return TutorialModel.Instance.RedDotCheckIsNewTutorialType((ETutorialType)uId);
	}

	// Token: 0x0601AB47 RID: 109383 RVA: 0x00834687 File Offset: 0x00832887
	private void OnRedDotNewTutorialType(ETutorialType tutorialType)
	{
		base.EventCheckWithUid((int)tutorialType);
	}
}
