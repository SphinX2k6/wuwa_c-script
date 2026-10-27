using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant;

// Token: 0x020033A4 RID: 13220
public class RedDotGiantAccessNew : RedDotBase
{
	// Token: 0x0601CB26 RID: 117542 RVA: 0x0080787D File Offset: 0x00805A7D
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CB27 RID: 117543 RVA: 0x00807880 File Offset: 0x00805A80
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CB28 RID: 117544 RVA: 0x00807884 File Offset: 0x00805A84
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Add<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Add<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB29 RID: 117545 RVA: 0x00807920 File Offset: 0x00805B20
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, new Action<GiantEcoNetType?, double, double>(this.OnGiantStableValueChange));
		EventSystem.Instance.Remove<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, new Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this.OnGiantEcoStatusChange));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGiantAccessProgressChange, new Action<int, int, int>(this.OnGiantAccessProgressChange));
		EventSystem.Instance.Remove<int>(EEventName.OnGetNewItem, new Action<int>(this.OnGetNewItem));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB2A RID: 117546 RVA: 0x008079BC File Offset: 0x00805BBC
	protected override bool OnCheck(int uId = 0)
	{
		return GiantConfig.HasNewAccessForEco((GiantEcoNetType)uId) && !GiantConfig.CanEcoLevelUp((GiantEcoNetType)uId);
	}

	// Token: 0x0601CB2B RID: 117547 RVA: 0x008079DE File Offset: 0x00805BDE
	private void OnGiantStableValueChange(GiantEcoNetType? ecology, double oldVal, double newVal)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB2C RID: 117548 RVA: 0x008079E6 File Offset: 0x00805BE6
	private void OnGiantEcoStatusChange(GiantEcoNetType ecology, GiantEcoNetStatus oldStatus, GiantEcoNetStatus newStatus)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB2D RID: 117549 RVA: 0x008079EE File Offset: 0x00805BEE
	private void OnGiantAccessProgressChange(int accessId, int curCount, int totalCount)
	{
		base.EventCheck();
	}

	// Token: 0x0601CB2E RID: 117550 RVA: 0x008079F6 File Offset: 0x00805BF6
	private void OnGetNewItem(int uniqueId)
	{
		base.EventCheck();
	}
}
