using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x02002917 RID: 10519
public class RedDotGiantCommission : RedDotBase
{
	// Token: 0x0601A828 RID: 108584 RVA: 0x0082DFCA File Offset: 0x0082C1CA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnGiantCommissionRead, new Action(base.EventCheck));
	}

	// Token: 0x0601A829 RID: 108585 RVA: 0x0082DFE8 File Offset: 0x0082C1E8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnGiantCommissionRead, new Action(base.EventCheck));
	}

	// Token: 0x0601A82A RID: 108586 RVA: 0x0082E006 File Offset: 0x0082C206
	protected override bool OnCheck(int uId = 0)
	{
		return !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.GiantCommissionRedDotClicked, false);
	}
}
