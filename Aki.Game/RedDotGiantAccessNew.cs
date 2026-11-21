using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant;

// Token: 0x02002916 RID: 10518
public class RedDotGiantAccessNew : RedDotBase
{
	// Token: 0x0601A81E RID: 108574 RVA: 0x0082DE41 File Offset: 0x0082C041
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A81F RID: 108575 RVA: 0x0082DE44 File Offset: 0x0082C044
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A820 RID: 108576 RVA: 0x0082DE48 File Offset: 0x0082C048
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Add<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Add<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A821 RID: 108577 RVA: 0x0082DEE4 File Offset: 0x0082C0E4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Remove<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Remove<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A822 RID: 108578 RVA: 0x0082DF80 File Offset: 0x0082C180
	protected override bool OnCheck(int uId = 0)
	{
		return GiantConfig.HasNewAccessForEco((GiantEcoNetType)uId) && !GiantConfig.CanEcoLevelUp((GiantEcoNetType)uId);
	}

	// Token: 0x0601A823 RID: 108579 RVA: 0x0082DFA2 File Offset: 0x0082C1A2
	private void OnGiantStableValueChange(GiantEcoNetType? ecology, double oldVal, double newVal)
	{
		base.EventCheck();
	}

	// Token: 0x0601A824 RID: 108580 RVA: 0x0082DFAA File Offset: 0x0082C1AA
	private void OnGiantEcoStatusChange(GiantEcoNetType ecology, GiantEcoNetStatus oldStatus, GiantEcoNetStatus newStatus)
	{
		base.EventCheck();
	}

	// Token: 0x0601A825 RID: 108581 RVA: 0x0082DFB2 File Offset: 0x0082C1B2
	private void OnGiantAccessProgressChange(int accessId, int curCount, int totalCount)
	{
		base.EventCheck();
	}

	// Token: 0x0601A826 RID: 108582 RVA: 0x0082DFBA File Offset: 0x0082C1BA
	private void OnGetNewItem(int uniqueId)
	{
		base.EventCheck();
	}
}
