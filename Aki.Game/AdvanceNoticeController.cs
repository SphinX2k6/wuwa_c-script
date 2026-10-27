using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x020010C5 RID: 4293
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AdvanceNoticeController : ActivityControllerBase
{
	// Token: 0x06006FEF RID: 28655 RVA: 0x0016CB12 File Offset: 0x0016AD12
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006FF0 RID: 28656 RVA: 0x0016CB14 File Offset: 0x0016AD14
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityPreviewGuide";
	}

	// Token: 0x06006FF1 RID: 28657 RVA: 0x0016CB1B File Offset: 0x0016AD1B
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new AdvanceNoticeSubView();
	}

	// Token: 0x06006FF2 RID: 28658 RVA: 0x0016CB22 File Offset: 0x0016AD22
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new AdvanceNoticeData();
	}

	// Token: 0x06006FF3 RID: 28659 RVA: 0x0016CB29 File Offset: 0x0016AD29
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006FF4 RID: 28660 RVA: 0x0016CB2C File Offset: 0x0016AD2C
	public void OpenAdvanceNoticeView(int advertisingPageInfoId, int selectedTabId)
	{
		AdvanceNoticeViewModel advanceNoticeViewModel = new AdvanceNoticeViewModel();
		advanceNoticeViewModel.DefaultSelectedTabId = selectedTabId;
		AdvertisingPageInfo advertisingPageInfoById = AdvanceNoticeConfig.Instance.GetAdvertisingPageInfoById(advertisingPageInfoId);
		advanceNoticeViewModel.TabList = advertisingPageInfoById.GetTabIdArrayArray().ToList<int>();
		advanceNoticeViewModel.ActivityId = advertisingPageInfoById.ActivityId;
		UiManager.Instance.OpenView(EUiViewName.AdvanceNoticeRootView, advanceNoticeViewModel, null);
	}

	// Token: 0x1700097D RID: 2429
	// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x0016CB82 File Offset: 0x0016AD82
	public static AdvanceNoticeController Instance
	{
		get
		{
			return AdvanceNoticeController._Instance;
		}
	}

	// Token: 0x06006FF6 RID: 28662 RVA: 0x0016CB89 File Offset: 0x0016AD89
	public static AdvanceNoticeController GetOrCreateInstance()
	{
		if (AdvanceNoticeController._Instance == null)
		{
			AdvanceNoticeController.CreateInstance();
		}
		return AdvanceNoticeController._Instance;
	}

	// Token: 0x06006FF7 RID: 28663 RVA: 0x0016CB9D File Offset: 0x0016AD9D
	public static bool CreateInstance()
	{
		if (AdvanceNoticeController._Instance != null)
		{
			return true;
		}
		AdvanceNoticeController._Instance = new AdvanceNoticeController();
		return true;
	}

	// Token: 0x06006FF8 RID: 28664 RVA: 0x0016CBB3 File Offset: 0x0016ADB3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006FF9 RID: 28665 RVA: 0x0016CBB5 File Offset: 0x0016ADB5
	public static void ResetStaticDefaultValue()
	{
		AdvanceNoticeController._Instance = null;
	}

	// Token: 0x06006FFA RID: 28666 RVA: 0x0016CBBD File Offset: 0x0016ADBD
	static AdvanceNoticeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdvanceNoticeController.CreateStaticDefaultValue), new Action(AdvanceNoticeController.ResetStaticDefaultValue));
	}

	// Token: 0x040033F0 RID: 13296
	[Nullable(2)]
	private static AdvanceNoticeController _Instance;
}
