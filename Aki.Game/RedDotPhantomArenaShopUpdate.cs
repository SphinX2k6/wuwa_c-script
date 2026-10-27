using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033F6 RID: 13302
public class RedDotPhantomArenaShopUpdate : RedDotBase
{
	// Token: 0x0601CCB3 RID: 117939 RVA: 0x0080A7CD File Offset: 0x008089CD
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaLimitReward);
	}

	// Token: 0x0601CCB4 RID: 117940 RVA: 0x0080A7D9 File Offset: 0x008089D9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaShopOpen, new Action(base.EventCheck));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
	}

	// Token: 0x0601CCB5 RID: 117941 RVA: 0x0080A813 File Offset: 0x00808A13
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaShopOpen, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
	}

	// Token: 0x0601CCB6 RID: 117942 RVA: 0x0080A84D File Offset: 0x00808A4D
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCB7 RID: 117943 RVA: 0x0080A850 File Offset: 0x00808A50
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomArenaModel.Instance.CheckShopRedDot(uId);
	}

	// Token: 0x0601CCB8 RID: 117944 RVA: 0x0080A85D File Offset: 0x00808A5D
	[NullableContext(1)]
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}
}
