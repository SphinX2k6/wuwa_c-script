using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200337A RID: 13178
public class RedDotDangoFormation : RedDotBase
{
	// Token: 0x0601CA71 RID: 117361 RVA: 0x00806305 File Offset: 0x00804505
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CA72 RID: 117362 RVA: 0x00806308 File Offset: 0x00804508
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshAbyssDangoRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA73 RID: 117363 RVA: 0x00806326 File Offset: 0x00804526
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshAbyssDangoRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA74 RID: 117364 RVA: 0x00806344 File Offset: 0x00804544
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.GetDangoFormationNewRedDot();
	}
}
