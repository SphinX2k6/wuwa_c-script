using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant;

// Token: 0x0200291A RID: 10522
public class RedDotGiantMindsetEntry : RedDotBase
{
	// Token: 0x0601A83A RID: 108602 RVA: 0x0082E1D4 File Offset: 0x0082C3D4
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A83B RID: 108603 RVA: 0x0082E1D7 File Offset: 0x0082C3D7
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A83C RID: 108604 RVA: 0x0082E1DC File Offset: 0x0082C3DC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Add<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Add<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A83D RID: 108605 RVA: 0x0082E278 File Offset: 0x0082C478
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Remove<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Remove<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A83E RID: 108606 RVA: 0x0082E311 File Offset: 0x0082C511
	protected override bool OnCheck(int uId = 0)
	{
		return GiantConfig.CanEcoLevelUp((GiantEcoNetType)uId);
	}

	// Token: 0x0601A83F RID: 108607 RVA: 0x0082E319 File Offset: 0x0082C519
	private void OnGiantStableValueChange(GiantEcoNetType? ecology, double oldVal, double newVal)
	{
		base.EventCheck();
	}

	// Token: 0x0601A840 RID: 108608 RVA: 0x0082E321 File Offset: 0x0082C521
	private void OnGiantEcoStatusChange(GiantEcoNetType ecology, GiantEcoNetStatus oldStatus, GiantEcoNetStatus newStatus)
	{
		base.EventCheck();
	}

	// Token: 0x0601A841 RID: 108609 RVA: 0x0082E329 File Offset: 0x0082C529
	private void OnGiantAccessProgressChange(int accessId, int curCount, int totalCount)
	{
		base.EventCheck();
	}

	// Token: 0x0601A842 RID: 108610 RVA: 0x0082E331 File Offset: 0x0082C531
	private void OnGetNewItem(int uniqueId)
	{
		base.EventCheck();
	}
}
