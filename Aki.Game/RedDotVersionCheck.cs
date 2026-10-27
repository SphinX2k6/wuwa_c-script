using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003409 RID: 13321
public class RedDotVersionCheck : RedDotBase
{
	// Token: 0x0601CD0F RID: 118031 RVA: 0x0080B374 File Offset: 0x00809574
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionSetting);
	}

	// Token: 0x0601CD10 RID: 118032 RVA: 0x0080B37D File Offset: 0x0080957D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.VersionCheckRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CD11 RID: 118033 RVA: 0x0080B3B7 File Offset: 0x008095B7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.VersionCheckRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CD12 RID: 118034 RVA: 0x0080B3F4 File Offset: 0x008095F4
	protected override bool OnCheck(int uId = 0)
	{
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		return LocalStorage.GetPlayer<string>(ELocalStoragePlayerKey.VersionRedDotMap, null) != appVersion && ParallelPackageController.Instance.CheckParallelPackageWithCache();
	}
}
