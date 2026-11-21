using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x02002968 RID: 10600
public class RedDotPhantomArenaShopUpdate : RedDotBase
{
	// Token: 0x0601A9AB RID: 108971 RVA: 0x00830D91 File Offset: 0x0082EF91
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaLimitReward);
	}

	// Token: 0x0601A9AC RID: 108972 RVA: 0x00830D9D File Offset: 0x0082EF9D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaShopOpen, new Action(base.EventCheck));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
	}

	// Token: 0x0601A9AD RID: 108973 RVA: 0x00830DD7 File Offset: 0x0082EFD7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaShopOpen, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
	}

	// Token: 0x0601A9AE RID: 108974 RVA: 0x00830E11 File Offset: 0x0082F011
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A9AF RID: 108975 RVA: 0x00830E14 File Offset: 0x0082F014
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomArenaModel.Instance.CheckShopRedDot(uId);
	}

	// Token: 0x0601A9B0 RID: 108976 RVA: 0x00830E21 File Offset: 0x0082F021
	[NullableContext(1)]
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}
}
