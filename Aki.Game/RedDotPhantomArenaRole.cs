using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x02002967 RID: 10599
public class RedDotPhantomArenaRole : RedDotBase
{
	// Token: 0x0601A9A5 RID: 108965 RVA: 0x00830D2C File Offset: 0x0082EF2C
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaActivity);
	}

	// Token: 0x0601A9A6 RID: 108966 RVA: 0x00830D38 File Offset: 0x0082EF38
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaRoleRewardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9A7 RID: 108967 RVA: 0x00830D56 File Offset: 0x0082EF56
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaRoleRewardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9A8 RID: 108968 RVA: 0x00830D74 File Offset: 0x0082EF74
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A9A9 RID: 108969 RVA: 0x00830D77 File Offset: 0x0082EF77
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetRoleRewardRedDot(uId);
	}
}
