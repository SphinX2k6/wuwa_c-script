using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02000711 RID: 1809
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityDoubleRewardController : ActivityControllerBase
{
	// Token: 0x06005354 RID: 21332 RVA: 0x001B951D File Offset: 0x001B771D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06005355 RID: 21333 RVA: 0x001B9520 File Offset: 0x001B7720
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06005356 RID: 21334 RVA: 0x001B9522 File Offset: 0x001B7722
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return ((ActivityDoubleRewardData)data).Prefab;
	}

	// Token: 0x06005357 RID: 21335 RVA: 0x001B952F File Offset: 0x001B772F
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewDoubleReward();
	}

	// Token: 0x06005358 RID: 21336 RVA: 0x001B9536 File Offset: 0x001B7736
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.UniversalActivityIdSet.Add(data.Id);
		return new ActivityDoubleRewardData();
	}

	// Token: 0x06005359 RID: 21337 RVA: 0x001B954F File Offset: 0x001B774F
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600535A RID: 21338 RVA: 0x001B9552 File Offset: 0x001B7752
	protected override bool OnClear()
	{
		this.UniversalActivityIdSet.Clear();
		return true;
	}

	// Token: 0x0600535B RID: 21339 RVA: 0x001B9560 File Offset: 0x001B7760
	public bool IsAnyActivityHasLeftUpCount()
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetActivitiesByType(7))
		{
			if (activityBaseData.CheckIfInShowTime() && (activityBaseData as ActivityDoubleRewardData).LeftUpCount > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600535C RID: 21340 RVA: 0x001B95D0 File Offset: 0x001B77D0
	public ActivityDoubleRewardData GetAdventureUpActivity(EDungeonType type)
	{
		foreach (int id in this.UniversalActivityIdSet)
		{
			ActivityDoubleRewardData activityDoubleRewardData = ActivityModel.Instance.GetActivityById(id) as ActivityDoubleRewardData;
			if (activityDoubleRewardData != null && activityDoubleRewardData.CheckIfInOpenTime() && Array.IndexOf<EDungeonType>(activityDoubleRewardData.AdventureGuideUpList, type) >= 0)
			{
				return activityDoubleRewardData;
			}
		}
		return null;
	}

	// Token: 0x0600535D RID: 21341 RVA: 0x001B9650 File Offset: 0x001B7850
	[return: Nullable(2)]
	public ActivityDoubleRewardData GetDungeonUpActivity(IList<int> customTypes, bool isInstance = true)
	{
		foreach (int id in this.UniversalActivityIdSet)
		{
			ActivityDoubleRewardData activityDoubleRewardData = ActivityModel.Instance.GetActivityById(id) as ActivityDoubleRewardData;
			if (activityDoubleRewardData != null && activityDoubleRewardData.CheckIfInOpenTime())
			{
				foreach (int item in activityDoubleRewardData.GetDungeonUpList(isInstance))
				{
					if (customTypes.Contains(item))
					{
						return activityDoubleRewardData;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600535E RID: 21342 RVA: 0x001B96EC File Offset: 0x001B78EC
	public string GetDungeonUpActivityFullTip(List<int> customTypes, bool isInstance = true)
	{
		ActivityDoubleRewardData dungeonUpActivity = this.GetDungeonUpActivity(customTypes, isInstance);
		if (dungeonUpActivity == null)
		{
			return null;
		}
		return dungeonUpActivity.GetFullTip();
	}

	// Token: 0x0600535F RID: 21343 RVA: 0x001B9701 File Offset: 0x001B7901
	public bool HasAnyDoubleRewardActivityShowing()
	{
		return ActivityModel.Instance.GetIsActivityShowingByType(7);
	}

	// Token: 0x17000B00 RID: 2816
	// (get) Token: 0x06005360 RID: 21344 RVA: 0x001B970E File Offset: 0x001B790E
	public static ActivityDoubleRewardController Instance
	{
		get
		{
			return ActivityDoubleRewardController._Instance;
		}
	}

	// Token: 0x06005361 RID: 21345 RVA: 0x001B9715 File Offset: 0x001B7915
	public static ActivityDoubleRewardController GetOrCreateInstance()
	{
		if (ActivityDoubleRewardController._Instance == null)
		{
			ActivityDoubleRewardController.CreateInstance();
		}
		return ActivityDoubleRewardController._Instance;
	}

	// Token: 0x06005362 RID: 21346 RVA: 0x001B9729 File Offset: 0x001B7929
	public static bool CreateInstance()
	{
		if (ActivityDoubleRewardController._Instance != null)
		{
			return true;
		}
		ActivityDoubleRewardController._Instance = new ActivityDoubleRewardController();
		return true;
	}

	// Token: 0x06005363 RID: 21347 RVA: 0x001B973F File Offset: 0x001B793F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005364 RID: 21348 RVA: 0x001B9741 File Offset: 0x001B7941
	public static void ResetStaticDefaultValue()
	{
		ActivityDoubleRewardController._Instance = null;
	}

	// Token: 0x06005365 RID: 21349 RVA: 0x001B9749 File Offset: 0x001B7949
	static ActivityDoubleRewardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDoubleRewardController.CreateStaticDefaultValue), new Action(ActivityDoubleRewardController.ResetStaticDefaultValue));
	}

	// Token: 0x04003AB3 RID: 15027
	private readonly HashSet<int> UniversalActivityIdSet = new HashSet<int>();

	// Token: 0x04003AB4 RID: 15028
	[Nullable(2)]
	private static ActivityDoubleRewardController _Instance;
}
