using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant;

// Token: 0x02002918 RID: 10520
public class RedDotGiantDeliverable : RedDotBase
{
	// Token: 0x0601A82C RID: 108588 RVA: 0x0082E01E File Offset: 0x0082C21E
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A82D RID: 108589 RVA: 0x0082E021 File Offset: 0x0082C221
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A82E RID: 108590 RVA: 0x0082E024 File Offset: 0x0082C224
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Add<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Add<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A82F RID: 108591 RVA: 0x0082E0C0 File Offset: 0x0082C2C0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Remove<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Remove<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A830 RID: 108592 RVA: 0x0082E159 File Offset: 0x0082C359
	protected override bool OnCheck(int uId = 0)
	{
		return GiantConfig.CanEcoLevelUp((GiantEcoNetType)uId);
	}

	// Token: 0x0601A831 RID: 108593 RVA: 0x0082E161 File Offset: 0x0082C361
	private void OnGiantStableValueChange(GiantEcoNetType? ecology, double oldVal, double newVal)
	{
		base.EventCheck();
	}

	// Token: 0x0601A832 RID: 108594 RVA: 0x0082E169 File Offset: 0x0082C369
	private void OnGiantEcoStatusChange(GiantEcoNetType ecology, GiantEcoNetStatus oldStatus, GiantEcoNetStatus newStatus)
	{
		base.EventCheck();
	}

	// Token: 0x0601A833 RID: 108595 RVA: 0x0082E171 File Offset: 0x0082C371
	private void OnGiantAccessProgressChange(int accessId, int curCount, int totalCount)
	{
		base.EventCheck();
	}

	// Token: 0x0601A834 RID: 108596 RVA: 0x0082E179 File Offset: 0x0082C379
	private void OnGetNewItem(int uniqueId)
	{
		base.EventCheck();
	}
}
