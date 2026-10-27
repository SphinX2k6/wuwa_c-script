using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x020033A5 RID: 13221
public class RedDotGiantCommission : RedDotBase
{
	// Token: 0x0601CB30 RID: 117552 RVA: 0x00807A06 File Offset: 0x00805C06
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnGiantCommissionRead, new Action(base.EventCheck));
	}

	// Token: 0x0601CB31 RID: 117553 RVA: 0x00807A24 File Offset: 0x00805C24
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnGiantCommissionRead, new Action(base.EventCheck));
	}

	// Token: 0x0601CB32 RID: 117554 RVA: 0x00807A42 File Offset: 0x00805C42
	protected override bool OnCheck(int uId = 0)
	{
		return !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.GiantCommissionRedDotClicked, false);
	}
}
