using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200337B RID: 13179
public class RedDotDangoFormationRole : RedDotBase
{
	// Token: 0x0601CA76 RID: 117366 RVA: 0x00806358 File Offset: 0x00804558
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotDangoFormation);
	}

	// Token: 0x0601CA77 RID: 117367 RVA: 0x00806364 File Offset: 0x00804564
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CA78 RID: 117368 RVA: 0x00806367 File Offset: 0x00804567
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshAbyssDangoRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA79 RID: 117369 RVA: 0x00806385 File Offset: 0x00804585
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshAbyssDangoRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA7A RID: 117370 RVA: 0x008063A3 File Offset: 0x008045A3
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.GetDangoFormationNewRoleRedDot(uId);
	}
}
