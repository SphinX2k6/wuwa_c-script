using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033F5 RID: 13301
public class RedDotPhantomArenaRole : RedDotBase
{
	// Token: 0x0601CCAD RID: 117933 RVA: 0x0080A768 File Offset: 0x00808968
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaActivity);
	}

	// Token: 0x0601CCAE RID: 117934 RVA: 0x0080A774 File Offset: 0x00808974
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaRoleRewardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCAF RID: 117935 RVA: 0x0080A792 File Offset: 0x00808992
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaRoleRewardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCB0 RID: 117936 RVA: 0x0080A7B0 File Offset: 0x008089B0
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCB1 RID: 117937 RVA: 0x0080A7B3 File Offset: 0x008089B3
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetRoleRewardRedDot(uId);
	}
}
