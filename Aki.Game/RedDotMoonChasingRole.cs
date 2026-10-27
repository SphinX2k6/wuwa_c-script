using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033C6 RID: 13254
public class RedDotMoonChasingRole : RedDotBase
{
	// Token: 0x0601CBCC RID: 117708 RVA: 0x00808D6D File Offset: 0x00806F6D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingDelegation);
	}

	// Token: 0x0601CBCD RID: 117709 RVA: 0x00808D79 File Offset: 0x00806F79
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshRoleRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBCE RID: 117710 RVA: 0x00808D97 File Offset: 0x00806F97
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshRoleRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBCF RID: 117711 RVA: 0x00808DB5 File Offset: 0x00806FB5
	protected override bool OnCheck(int uId = 0)
	{
		return MoonChasingModel.Instance.CheckRoleRedDotState();
	}
}
