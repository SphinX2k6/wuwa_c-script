using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200339F RID: 13215
public class RedDotFunctionPhantomExploreSet : RedDotBase
{
	// Token: 0x0601CB15 RID: 117525 RVA: 0x00807621 File Offset: 0x00805821
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601CB16 RID: 117526 RVA: 0x00807629 File Offset: 0x00805829
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RouletteRefreshNew, new Action(base.EventCheck));
	}

	// Token: 0x0601CB17 RID: 117527 RVA: 0x00807647 File Offset: 0x00805847
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RouletteRefreshNew, new Action(base.EventCheck));
	}

	// Token: 0x0601CB18 RID: 117528 RVA: 0x00807668 File Offset: 0x00805868
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = RouletteModel.Instance.CheckHasAnyNewItem();
		bool flag2 = PhantomInteractModel.Instance.CheckAnyPhantomInteractUnlockRedDot();
		return flag || flag2;
	}
}
