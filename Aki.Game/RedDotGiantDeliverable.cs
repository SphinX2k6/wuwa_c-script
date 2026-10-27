using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant;

// Token: 0x020033A6 RID: 13222
public class RedDotGiantDeliverable : RedDotBase
{
	// Token: 0x0601CB34 RID: 117556 RVA: 0x00807A5A File Offset: 0x00805C5A
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CB35 RID: 117557 RVA: 0x00807A5D File Offset: 0x00805C5D
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CB36 RID: 117558 RVA: 0x00807A60 File Offset: 0x00805C60
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Add<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Add<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB37 RID: 117559 RVA: 0x00807AFC File Offset: 0x00805CFC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Remove<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Remove<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB38 RID: 117560 RVA: 0x00807B95 File Offset: 0x00805D95
	protected override bool OnCheck(int uId = 0)
	{
		return GiantConfig.CanEcoLevelUp((GiantEcoNetType)uId);
	}

	// Token: 0x0601CB39 RID: 117561 RVA: 0x00807B9D File Offset: 0x00805D9D
	private void OnGiantStableValueChange(GiantEcoNetType? ecology, double oldVal, double newVal)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB3A RID: 117562 RVA: 0x00807BA5 File Offset: 0x00805DA5
	private void OnGiantEcoStatusChange(GiantEcoNetType ecology, GiantEcoNetStatus oldStatus, GiantEcoNetStatus newStatus)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB3B RID: 117563 RVA: 0x00807BAD File Offset: 0x00805DAD
	private void OnGiantAccessProgressChange(int accessId, int curCount, int totalCount)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB3C RID: 117564 RVA: 0x00807BB5 File Offset: 0x00805DB5
	private void OnGetNewItem(int uniqueId)
	{
		base.EventCheck();
	}
}
