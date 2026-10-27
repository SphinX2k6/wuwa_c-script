using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant;

// Token: 0x020033A8 RID: 13224
public class RedDotGiantMindsetEntry : RedDotBase
{
	// Token: 0x0601CB42 RID: 117570 RVA: 0x00807C10 File Offset: 0x00805E10
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CB43 RID: 117571 RVA: 0x00807C13 File Offset: 0x00805E13
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CB44 RID: 117572 RVA: 0x00807C18 File Offset: 0x00805E18
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Add<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Add<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB45 RID: 117573 RVA: 0x00807CB4 File Offset: 0x00805EB4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Remove<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Remove<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB46 RID: 117574 RVA: 0x00807D4D File Offset: 0x00805F4D
	protected override bool OnCheck(int uId = 0)
	{
		return GiantConfig.CanEcoLevelUp((GiantEcoNetType)uId);
	}

	// Token: 0x0601CB47 RID: 117575 RVA: 0x00807D55 File Offset: 0x00805F55
	private void OnGiantStableValueChange(GiantEcoNetType? ecology, double oldVal, double newVal)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB48 RID: 117576 RVA: 0x00807D5D File Offset: 0x00805F5D
	private void OnGiantEcoStatusChange(GiantEcoNetType ecology, GiantEcoNetStatus oldStatus, GiantEcoNetStatus newStatus)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB49 RID: 117577 RVA: 0x00807D65 File Offset: 0x00805F65
	private void OnGiantAccessProgressChange(int accessId, int curCount, int totalCount)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB4A RID: 117578 RVA: 0x00807D6D File Offset: 0x00805F6D
	private void OnGetNewItem(int uniqueId)
	{
		base.EventCheck();
	}
}
