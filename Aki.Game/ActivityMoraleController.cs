using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x0200136C RID: 4972
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMoraleController : ActivityControllerBase
{
	// Token: 0x06008AA1 RID: 35489 RVA: 0x001DA021 File Offset: 0x001D8221
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008AA2 RID: 35490 RVA: 0x001DA024 File Offset: 0x001D8224
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

	// Token: 0x06008AA3 RID: 35491 RVA: 0x001DA068 File Offset: 0x001D8268
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_MoraleMain";
	}

	// Token: 0x06008AA4 RID: 35492 RVA: 0x001DA06F File Offset: 0x001D826F
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewMorale();
	}

	// Token: 0x06008AA5 RID: 35493 RVA: 0x001DA076 File Offset: 0x001D8276
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityMoraleData();
		return this.Data;
	}

	// Token: 0x06008AA6 RID: 35494 RVA: 0x001DA089 File Offset: 0x001D8289
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06008AA7 RID: 35495 RVA: 0x001DA08B File Offset: 0x001D828B
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06008AA8 RID: 35496 RVA: 0x001DA08D File Offset: 0x001D828D
	[NullableContext(2)]
	private ActivityMoraleController GetController()
	{
		return ActivityManager.GetActivityController(ActivityType.MoraleActivity) as ActivityMoraleController;
	}

	// Token: 0x06008AA9 RID: 35497 RVA: 0x001DA09B File Offset: 0x001D829B
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

	// Token: 0x06008AAA RID: 35498 RVA: 0x001DA0B0 File Offset: 0x001D82B0
	public void RefreshActivityRedDot()
	{
		ActivityMoraleData data = this.GetData();
		int? num = (data != null) ? new int?(data.Id) : null;
		if (num != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, num.Value);
		}
	}

	// Token: 0x17000BC2 RID: 3010
	// (get) Token: 0x06008AAB RID: 35499 RVA: 0x001DA0FD File Offset: 0x001D82FD
	public static ActivityMoraleController Instance
	{
		get
		{
			return ActivityMoraleController._Instance;
		}
	}

	// Token: 0x06008AAC RID: 35500 RVA: 0x001DA104 File Offset: 0x001D8304
	public static ActivityMoraleController GetOrCreateInstance()
	{
		if (ActivityMoraleController._Instance == null)
		{
			ActivityMoraleController.CreateInstance();
		}
		return ActivityMoraleController._Instance;
	}

	// Token: 0x06008AAD RID: 35501 RVA: 0x001DA118 File Offset: 0x001D8318
	public static bool CreateInstance()
	{
		if (ActivityMoraleController._Instance != null)
		{
			return true;
		}
		ActivityMoraleController._Instance = new ActivityMoraleController();
		return true;
	}

	// Token: 0x06008AAE RID: 35502 RVA: 0x001DA12E File Offset: 0x001D832E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008AAF RID: 35503 RVA: 0x001DA130 File Offset: 0x001D8330
	public static void ResetStaticDefaultValue()
	{
		ActivityMoraleController._Instance = null;
	}

	// Token: 0x06008AB0 RID: 35504 RVA: 0x001DA138 File Offset: 0x001D8338
	static ActivityMoraleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMoraleController.CreateStaticDefaultValue), new Action(ActivityMoraleController.ResetStaticDefaultValue));
	}

	// Token: 0x04003DBF RID: 15807
	[Nullable(2)]
	public ActivityMoraleData Data;

	// Token: 0x04003DC0 RID: 15808
	[Nullable(2)]
	private static ActivityMoraleController _Instance;
}
