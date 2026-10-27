using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200125D RID: 4701
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityDoubleRewardController : ActivityControllerBase
{
	// Token: 0x06007FBD RID: 32701 RVA: 0x001B086D File Offset: 0x001AEA6D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06007FBE RID: 32702 RVA: 0x001B0870 File Offset: 0x001AEA70
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007FBF RID: 32703 RVA: 0x001B0872 File Offset: 0x001AEA72
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return ((ActivityDoubleRewardData)data).Prefab;
	}

	// Token: 0x06007FC0 RID: 32704 RVA: 0x001B087F File Offset: 0x001AEA7F
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewDoubleReward();
	}

	// Token: 0x06007FC1 RID: 32705 RVA: 0x001B0886 File Offset: 0x001AEA86
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.UniversalActivityIdSet.Add(data.Id);
		return new ActivityDoubleRewardData();
	}

	// Token: 0x06007FC2 RID: 32706 RVA: 0x001B089F File Offset: 0x001AEA9F
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06007FC3 RID: 32707 RVA: 0x001B08A2 File Offset: 0x001AEAA2
	protected override bool OnClear()
	{
		this.UniversalActivityIdSet.Clear();
		return true;
	}

	// Token: 0x06007FC4 RID: 32708 RVA: 0x001B08B0 File Offset: 0x001AEAB0
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

	// Token: 0x06007FC5 RID: 32709 RVA: 0x001B0920 File Offset: 0x001AEB20
	public ActivityDoubleRewardData GetAdventureUpActivity(EDungeonType type)
	{
		foreach (int id in this.UniversalActivityIdSet)
		{
			ActivityDoubleRewardData activityDoubleRewardData = ActivityModel.Instance.GetActivityById(id) as ActivityDoubleRewardData;
			if (activityDoubleRewardData != null && activityDoubleRewardData.CheckIfInOpenTime() && activityDoubleRewardData != null && activityDoubleRewardData.AdventureGuideUpList.Contains(type))
			{
				return activityDoubleRewardData;
			}
		}
		return null;
	}

	// Token: 0x06007FC6 RID: 32710 RVA: 0x001B09A0 File Offset: 0x001AEBA0
	[return: Nullable(2)]
	public ActivityDoubleRewardData GetDungeonUpActivity(IList<int> customTypes, bool isInstance = true)
	{
		foreach (int id in this.UniversalActivityIdSet)
		{
			ActivityDoubleRewardData activityDoubleRewardData = ActivityModel.Instance.GetActivityById(id) as ActivityDoubleRewardData;
			if (activityDoubleRewardData != null && activityDoubleRewardData.CheckIfInOpenTime() && activityDoubleRewardData.GetDungeonUpList(isInstance).ToList<int>().Any(new Func<int, bool>(customTypes.Contains)))
			{
				return activityDoubleRewardData;
			}
		}
		return null;
	}

	// Token: 0x06007FC7 RID: 32711 RVA: 0x001B0A30 File Offset: 0x001AEC30
	public string GetDungeonUpActivityFullTip(List<int> customTypes, bool isInstance = true)
	{
		ActivityDoubleRewardData dungeonUpActivity = this.GetDungeonUpActivity(customTypes, isInstance);
		if (dungeonUpActivity == null)
		{
			return null;
		}
		return dungeonUpActivity.GetFullTip();
	}

	// Token: 0x06007FC8 RID: 32712 RVA: 0x001B0A45 File Offset: 0x001AEC45
	public bool HasAnyDoubleRewardActivityShowing()
	{
		return ActivityModel.Instance.GetIsActivityShowingByType(7);
	}

	// Token: 0x17000AE0 RID: 2784
	// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x001B0A52 File Offset: 0x001AEC52
	public static ActivityDoubleRewardController Instance
	{
		get
		{
			return ActivityDoubleRewardController._Instance;
		}
	}

	// Token: 0x06007FCA RID: 32714 RVA: 0x001B0A59 File Offset: 0x001AEC59
	public static ActivityDoubleRewardController GetOrCreateInstance()
	{
		if (ActivityDoubleRewardController._Instance == null)
		{
			ActivityDoubleRewardController.CreateInstance();
		}
		return ActivityDoubleRewardController._Instance;
	}

	// Token: 0x06007FCB RID: 32715 RVA: 0x001B0A6D File Offset: 0x001AEC6D
	public static bool CreateInstance()
	{
		if (ActivityDoubleRewardController._Instance != null)
		{
			return true;
		}
		ActivityDoubleRewardController._Instance = new ActivityDoubleRewardController();
		return true;
	}

	// Token: 0x06007FCC RID: 32716 RVA: 0x001B0A83 File Offset: 0x001AEC83
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007FCD RID: 32717 RVA: 0x001B0A85 File Offset: 0x001AEC85
	public static void ResetStaticDefaultValue()
	{
		ActivityDoubleRewardController._Instance = null;
	}

	// Token: 0x06007FCE RID: 32718 RVA: 0x001B0A8D File Offset: 0x001AEC8D
	static ActivityDoubleRewardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDoubleRewardController.CreateStaticDefaultValue), new Action(ActivityDoubleRewardController.ResetStaticDefaultValue));
	}

	// Token: 0x04003A1B RID: 14875
	private readonly HashSet<int> UniversalActivityIdSet = new HashSet<int>();

	// Token: 0x04003A1C RID: 14876
	[Nullable(2)]
	private static ActivityDoubleRewardController _Instance;
}
