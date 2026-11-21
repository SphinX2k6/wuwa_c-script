using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028ED RID: 10477
public class RedDotDangoFormationRole : RedDotBase
{
	// Token: 0x0601A76E RID: 108398 RVA: 0x0082C91C File Offset: 0x0082AB1C
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotDangoFormation);
	}

	// Token: 0x0601A76F RID: 108399 RVA: 0x0082C928 File Offset: 0x0082AB28
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A770 RID: 108400 RVA: 0x0082C92B File Offset: 0x0082AB2B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshAbyssDangoRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A771 RID: 108401 RVA: 0x0082C949 File Offset: 0x0082AB49
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshAbyssDangoRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A772 RID: 108402 RVA: 0x0082C967 File Offset: 0x0082AB67
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.GetDangoFormationNewRoleRedDot(uId);
	}
}
