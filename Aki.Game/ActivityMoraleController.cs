using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02000820 RID: 2080
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMoraleController : ActivityControllerBase
{
	// Token: 0x06005E3C RID: 24124 RVA: 0x001E2E7D File Offset: 0x001E107D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06005E3D RID: 24125 RVA: 0x001E2E80 File Offset: 0x001E1080
	protected override void OnOpenView(ActivityBaseData data)
	{
		if (!data.GetPreGuideQuestFinishState())
		{
			int unFinishPreGuideQuestId = data.GetUnFinishPreGuideQuestId();
			UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.MoraleAreaSumView, null, null);
	}

	// Token: 0x06005E3E RID: 24126 RVA: 0x001E2EC4 File Offset: 0x001E10C4
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_MoraleMain";
	}

	// Token: 0x06005E3F RID: 24127 RVA: 0x001E2ECB File Offset: 0x001E10CB
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewMorale();
	}

	// Token: 0x06005E40 RID: 24128 RVA: 0x001E2ED2 File Offset: 0x001E10D2
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityMoraleData();
		return this.Data;
	}

	// Token: 0x06005E41 RID: 24129 RVA: 0x001E2EE5 File Offset: 0x001E10E5
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06005E42 RID: 24130 RVA: 0x001E2EE7 File Offset: 0x001E10E7
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06005E43 RID: 24131 RVA: 0x001E2EE9 File Offset: 0x001E10E9
	[NullableContext(2)]
	private ActivityMoraleController GetController()
	{
		return ActivityManager.GetActivityController(ActivityType.MoraleActivity) as ActivityMoraleController;
	}

	// Token: 0x06005E44 RID: 24132 RVA: 0x001E2EF7 File Offset: 0x001E10F7
	[NullableContext(2)]
	public ActivityMoraleData GetData()
	{
		ActivityMoraleController controller = this.GetController();
		if (controller == null)
		{
			return null;
		}
		return controller.Data;
	}

	// Token: 0x06005E45 RID: 24133 RVA: 0x001E2F0C File Offset: 0x001E110C
	public void RefreshActivityRedDot()
	{
		ActivityMoraleData data = this.GetData();
		int? num = (data != null) ? new int?(data.Id) : null;
		if (num != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, num.Value);
		}
	}

	// Token: 0x17000BE2 RID: 3042
	// (get) Token: 0x06005E46 RID: 24134 RVA: 0x001E2F59 File Offset: 0x001E1159
	public static ActivityMoraleController Instance
	{
		get
		{
			return ActivityMoraleController._Instance;
		}
	}

	// Token: 0x06005E47 RID: 24135 RVA: 0x001E2F60 File Offset: 0x001E1160
	public static ActivityMoraleController GetOrCreateInstance()
	{
		if (ActivityMoraleController._Instance == null)
		{
			ActivityMoraleController.CreateInstance();
		}
		return ActivityMoraleController._Instance;
	}

	// Token: 0x06005E48 RID: 24136 RVA: 0x001E2F74 File Offset: 0x001E1174
	public static bool CreateInstance()
	{
		if (ActivityMoraleController._Instance != null)
		{
			return true;
		}
		ActivityMoraleController._Instance = new ActivityMoraleController();
		return true;
	}

	// Token: 0x06005E49 RID: 24137 RVA: 0x001E2F8A File Offset: 0x001E118A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005E4A RID: 24138 RVA: 0x001E2F8C File Offset: 0x001E118C
	public static void ResetStaticDefaultValue()
	{
		ActivityMoraleController._Instance = null;
	}

	// Token: 0x06005E4B RID: 24139 RVA: 0x001E2F94 File Offset: 0x001E1194
	static ActivityMoraleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMoraleController.CreateStaticDefaultValue), new Action(ActivityMoraleController.ResetStaticDefaultValue));
	}

	// Token: 0x04003E57 RID: 15959
	[Nullable(2)]
	public ActivityMoraleData Data;

	// Token: 0x04003E58 RID: 15960
	[Nullable(2)]
	private static ActivityMoraleController _Instance;
}
