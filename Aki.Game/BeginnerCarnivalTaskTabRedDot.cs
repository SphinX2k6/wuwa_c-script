using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200336A RID: 13162
public class BeginnerCarnivalTaskTabRedDot : RedDotBase
{
	// Token: 0x0601CA30 RID: 117296 RVA: 0x00805B2E File Offset: 0x00803D2E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshBeginnerCarnivalTask, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA31 RID: 117297 RVA: 0x00805B4C File Offset: 0x00803D4C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshBeginnerCarnivalTask, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA32 RID: 117298 RVA: 0x00805B6C File Offset: 0x00803D6C
	protected override bool OnCheck(int uId = 0)
	{
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		return beginnerCarnivalData != null && beginnerCarnivalData.GetTabRedDotShow(uId);
	}
}
