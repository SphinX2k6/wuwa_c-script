using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200297B RID: 10619
public class RedDotVersionCheck : RedDotBase
{
	// Token: 0x0601AA07 RID: 109063 RVA: 0x00831938 File Offset: 0x0082FB38
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionSetting);
	}

	// Token: 0x0601AA08 RID: 109064 RVA: 0x00831941 File Offset: 0x0082FB41
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.VersionCheckRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AA09 RID: 109065 RVA: 0x0083197B File Offset: 0x0082FB7B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.VersionCheckRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AA0A RID: 109066 RVA: 0x008319B8 File Offset: 0x0082FBB8
	protected override bool OnCheck(int uId = 0)
	{
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		return LocalStorage.GetPlayer<string>(ELocalStoragePlayerKey.VersionRedDotMap, null) != appVersion && ParallelPackageController.Instance.CheckParallelPackageWithCache();
	}
}
