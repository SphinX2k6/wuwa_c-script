using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002911 RID: 10513
public class RedDotFunctionPhantomExploreSet : RedDotBase
{
	// Token: 0x0601A80D RID: 108557 RVA: 0x0082DBE5 File Offset: 0x0082BDE5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601A80E RID: 108558 RVA: 0x0082DBED File Offset: 0x0082BDED
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RouletteRefreshNew, new Action(base.EventCheck));
	}

	// Token: 0x0601A80F RID: 108559 RVA: 0x0082DC0B File Offset: 0x0082BE0B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RouletteRefreshNew, new Action(base.EventCheck));
	}

	// Token: 0x0601A810 RID: 108560 RVA: 0x0082DC2C File Offset: 0x0082BE2C
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = RouletteModel.Instance.CheckHasAnyNewItem();
		bool flag2 = PhantomInteractModel.Instance.CheckAnyPhantomInteractUnlockRedDot();
		return flag || flag2;
	}
}
