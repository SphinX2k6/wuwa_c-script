using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02000579 RID: 1401
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AdvanceNoticeController : ActivityControllerBase
{
	// Token: 0x06004385 RID: 17285 RVA: 0x001754CE File Offset: 0x001736CE
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004386 RID: 17286 RVA: 0x001754D0 File Offset: 0x001736D0
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityPreviewGuide";
	}

	// Token: 0x06004387 RID: 17287 RVA: 0x001754D7 File Offset: 0x001736D7
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new AdvanceNoticeSubView();
	}

	// Token: 0x06004388 RID: 17288 RVA: 0x001754DE File Offset: 0x001736DE
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new AdvanceNoticeData();
	}

	// Token: 0x06004389 RID: 17289 RVA: 0x001754E5 File Offset: 0x001736E5
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600438A RID: 17290 RVA: 0x001754E8 File Offset: 0x001736E8
	public void OpenAdvanceNoticeView(int advertisingPageInfoId, int selectedTabId)
	{
		AdvanceNoticeViewModel advanceNoticeViewModel = new AdvanceNoticeViewModel();
		advanceNoticeViewModel.DefaultSelectedTabId = selectedTabId;
		AdvertisingPageInfo advertisingPageInfoById = AdvanceNoticeConfig.Instance.GetAdvertisingPageInfoById(advertisingPageInfoId);
		advanceNoticeViewModel.TabList = new List<int>(advertisingPageInfoById.GetTabIdArrayArray());
		advanceNoticeViewModel.ActivityId = advertisingPageInfoById.ActivityId;
		UiManager.Instance.OpenView(EUiViewName.AdvanceNoticeRootView, advanceNoticeViewModel, null);
	}

	// Token: 0x1700099D RID: 2461
	// (get) Token: 0x0600438B RID: 17291 RVA: 0x0017553E File Offset: 0x0017373E
	public static AdvanceNoticeController Instance
	{
		get
		{
			return AdvanceNoticeController._Instance;
		}
	}

	// Token: 0x0600438C RID: 17292 RVA: 0x00175545 File Offset: 0x00173745
	public static AdvanceNoticeController GetOrCreateInstance()
	{
		if (AdvanceNoticeController._Instance == null)
		{
			AdvanceNoticeController.CreateInstance();
		}
		return AdvanceNoticeController._Instance;
	}

	// Token: 0x0600438D RID: 17293 RVA: 0x00175559 File Offset: 0x00173759
	public static bool CreateInstance()
	{
		if (AdvanceNoticeController._Instance != null)
		{
			return true;
		}
		AdvanceNoticeController._Instance = new AdvanceNoticeController();
		return true;
	}

	// Token: 0x0600438E RID: 17294 RVA: 0x0017556F File Offset: 0x0017376F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600438F RID: 17295 RVA: 0x00175571 File Offset: 0x00173771
	public static void ResetStaticDefaultValue()
	{
		AdvanceNoticeController._Instance = null;
	}

	// Token: 0x06004390 RID: 17296 RVA: 0x00175579 File Offset: 0x00173779
	static AdvanceNoticeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdvanceNoticeController.CreateStaticDefaultValue), new Action(AdvanceNoticeController.ResetStaticDefaultValue));
	}

	// Token: 0x04003489 RID: 13449
	[Nullable(2)]
	private static AdvanceNoticeController _Instance;
}
