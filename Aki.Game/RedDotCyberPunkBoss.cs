using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x020028A3 RID: 10403
public class RedDotCyberPunkBoss : RedDotBase
{
	// Token: 0x0601A622 RID: 108066 RVA: 0x0082A2C8 File Offset: 0x008284C8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnCyberPunkItemUnLock, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A623 RID: 108067 RVA: 0x0082A302 File Offset: 0x00828502
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnCyberPunkItemUnLock, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A624 RID: 108068 RVA: 0x0082A33C File Offset: 0x0082853C
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.CommonActivityPage);
	}

	// Token: 0x0601A625 RID: 108069 RVA: 0x0082A345 File Offset: 0x00828545
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A626 RID: 108070 RVA: 0x0082A348 File Offset: 0x00828548
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A627 RID: 108071 RVA: 0x0082A34C File Offset: 0x0082854C
	protected override bool OnCheck(int uId = 0)
	{
		CyberPunkController instance = CyberPunkController.Instance;
		CyberPunkData cyberPunkData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return cyberPunkData != null && cyberPunkData.IsFunctionUnlocked(5) && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.CyberPunkBossEntranceFirstClicked, false);
	}
}
