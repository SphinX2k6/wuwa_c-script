using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033F9 RID: 13305
public class RedDotPhantomInteractRouletteGrid : RedDotBase
{
	// Token: 0x0601CCC5 RID: 117957 RVA: 0x0080A920 File Offset: 0x00808B20
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomInteractModel.Instance.CheckAnyPhantomInteractUnlockRedDot();
	}

	// Token: 0x0601CCC6 RID: 117958 RVA: 0x0080A92C File Offset: 0x00808B2C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCC7 RID: 117959 RVA: 0x0080A94A File Offset: 0x00808B4A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCC8 RID: 117960 RVA: 0x0080A968 File Offset: 0x00808B68
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
