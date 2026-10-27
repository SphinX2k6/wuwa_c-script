using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x02003331 RID: 13105
public class RedDotCyberPunkBoss : RedDotBase
{
	// Token: 0x0601C92A RID: 117034 RVA: 0x00803D04 File Offset: 0x00801F04
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnCyberPunkItemUnLock, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C92B RID: 117035 RVA: 0x00803D3E File Offset: 0x00801F3E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnCyberPunkItemUnLock, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C92C RID: 117036 RVA: 0x00803D78 File Offset: 0x00801F78
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.CommonActivityPage);
	}

	// Token: 0x0601C92D RID: 117037 RVA: 0x00803D81 File Offset: 0x00801F81
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601C92E RID: 117038 RVA: 0x00803D84 File Offset: 0x00801F84
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601C92F RID: 117039 RVA: 0x00803D88 File Offset: 0x00801F88
	protected override bool OnCheck(int uId = 0)
	{
		CyberPunkController instance = CyberPunkController.Instance;
		CyberPunkData cyberPunkData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return cyberPunkData != null && cyberPunkData.IsFunctionUnlocked(5) && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.CyberPunkBossEntranceFirstClicked, false);
	}
}
