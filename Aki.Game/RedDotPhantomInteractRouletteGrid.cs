using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200296B RID: 10603
public class RedDotPhantomInteractRouletteGrid : RedDotBase
{
	// Token: 0x0601A9BD RID: 108989 RVA: 0x00830EE4 File Offset: 0x0082F0E4
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomInteractModel.Instance.CheckAnyPhantomInteractUnlockRedDot();
	}

	// Token: 0x0601A9BE RID: 108990 RVA: 0x00830EF0 File Offset: 0x0082F0F0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9BF RID: 108991 RVA: 0x00830F0E File Offset: 0x0082F10E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomInteractNewUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9C0 RID: 108992 RVA: 0x00830F2C File Offset: 0x0082F12C
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
