using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001140 RID: 4416
[NullableContext(1)]
[Nullable(0)]
public class GachaMainView : UiTickViewBase
{
	// Token: 0x0600B015 RID: 45077 RVA: 0x0033ED8F File Offset: 0x0033CF8F
	public GachaMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B016 RID: 45078 RVA: 0x0033EDC8 File Offset: 0x0033CFC8
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<GachaPoolItem> GetActorByPoolType(UUIItem parent, GachaDefine.EGachaViewType type)
	{
		GachaMainView.<GetActorByPoolType>d__4 <GetActorByPoolType>d__;
		<GetActorByPoolType>d__.<>t__builder = AsyncUniTaskMethodBuilder<GachaPoolItem>.Create();
		<GetActorByPoolType>d__.parent = parent;
		<GetActorByPoolType>d__.type = type;
		<GetActorByPoolType>d__.<>1__state = -1;
		<GetActorByPoolType>d__.<>t__builder.Start<GachaMainView.<GetActorByPoolType>d__4>(ref <GetActorByPoolType>d__);
		return <GetActorByPoolType>d__.<>t__builder.Task;
	}

	// Token: 0x0600B017 RID: 45079 RVA: 0x0033EE14 File Offset: 0x0033D014
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<GachaPoolItem> GetSpineActorByResourceId(UUIItem parent, string resourceId, GachaDefine.EGachaViewType type)
	{
		GachaMainView.<GetSpineActorByResourceId>d__5 <GetSpineActorByResourceId>d__;
		<GetSpineActorByResourceId>d__.<>t__builder = AsyncUniTaskMethodBuilder<GachaPoolItem>.Create();
		<GetSpineActorByResourceId>d__.parent = parent;
		<GetSpineActorByResourceId>d__.resourceId = resourceId;
		<GetSpineActorByResourceId>d__.type = type;
		<GetSpineActorByResourceId>d__.<>1__state = -1;
		<GetSpineActorByResourceId>d__.<>t__builder.Start<GachaMainView.<GetSpineActorByResourceId>d__5>(ref <GetSpineActorByResourceId>d__);
		return <GetSpineActorByResourceId>d__.<>t__builder.Task;
	}

	// Token: 0x1700120A RID: 4618
	// (get) Token: 0x0600B018 RID: 45080 RVA: 0x0033EE67 File Offset: 0x0033D067
	private new int? OpenParam
	{
		get
		{
			return this.OpenParam as int?;
		}
	}

	// Token: 0x1700120B RID: 4619
	// (get) Token: 0x0600B019 RID: 45081 RVA: 0x0033EE79 File Offset: 0x0033D079
	private ProtoGachaInfo CurGachaInfo
	{
		get
		{
			return this.CurGachaPoolData.GachaInfo;
		}
	}

	// Token: 0x1700120C RID: 4620
	// (get) Token: 0x0600B01A RID: 45082 RVA: 0x0033EE86 File Offset: 0x0033D086
	private int CurShowPoolId
	{
		get
		{
			return this.CurGachaPoolData.PoolInfo.Id;
		}
	}

	// Token: 0x1700120D RID: 4621
	// (get) Token: 0x0600B01B RID: 45083 RVA: 0x0033EE98 File Offset: 0x0033D098
	private ProtoGachaPoolInfo CurShowPoolInfo
	{
		get
		{
			return this.CurGachaPoolData.PoolInfo;
		}
	}

	// Token: 0x1700120E RID: 4622
	// (get) Token: 0x0600B01C RID: 45084 RVA: 0x0033EEA8 File Offset: 0x0033D0A8
	[Nullable(2)]
	private GachaPoolData CurGachaPoolData
	{
		[NullableContext(2)]
		get
		{
			int selectedGridIndex = this.GachaTagScrollView.GetGenericLayout().GetSelectedGridIndex();
			if (this.TagDataList == null || selectedGridIndex < 0 || selectedGridIndex >= this.TagDataList.Length)
			{
				return null;
			}
			return this.TagDataList[selectedGridIndex];
		}
	}

	// Token: 0x1700120F RID: 4623
	// (get) Token: 0x0600B01D RID: 45085 RVA: 0x0033EEE7 File Offset: 0x0033D0E7
	private bool IsLock
	{
		get
		{
			return this.Operating;
		}
	}

	// Token: 0x0600B01E RID: 45086 RVA: 0x0033EEEF File Offset: 0x0033D0EF
	private void Lock()
	{
		this.Operating = true;
	}

	// Token: 0x0600B01F RID: 45087 RVA: 0x0033EEF8 File Offset: 0x0033D0F8
	private void Unlock()
	{
		this.Operating = false;
		if (this.GachaOperationQueue.Size == 0)
		{
			return;
		}
		GachaMainView.OperationParam operationParam = this.GachaOperationQueue.Pop();
		if (operationParam == null)
		{
			return;
		}
		switch (operationParam.OperationType)
		{
		case GachaMainView.EOperationType.RefreshGachaTag:
			this.RefreshGachaTag();
			return;
		case GachaMainView.EOperationType.RefreshGachaInfo:
			this.RefreshGachaInfo();
			return;
		case GachaMainView.EOperationType.SelectGachaTagByIndex:
			this.SelectGachaTagByIndex((int)((operationParam != null) ? operationParam.Param : null));
			return;
		default:
			return;
		}
	}

	// Token: 0x0600B020 RID: 45088 RVA: 0x0033EF6C File Offset: 0x0033D16C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.ItemExChangeResponse, new Action<int, int>(this.OnItemExChangeResponse));
		EventSystem.Instance.Add(EEventName.RefreshGachaMainView, new Action(this.RefreshGachaMainView));
		EventSystem.Instance.Add<int, int>(EEventName.GachaPoolSelectResponse, new Action<int, int>(this.OnGachaPoolSelectResponse));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
		EventSystem.Instance.Add(EEventName.GachaNewNotify, new Action(this.OnCrossDay));
		EventSystem.Instance.Add<string>(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnPlaySequenceEventByStringParam));
		EventSystem.Instance.Add<int>(EEventName.GachaAccumulateRewardClaimed, new Action<int>(this.OnGachaAccumulateRewardClaimed));
	}

	// Token: 0x0600B021 RID: 45089 RVA: 0x0033F040 File Offset: 0x0033D240
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ItemExChangeResponse, new Action<int, int>(this.OnItemExChangeResponse));
		EventSystem.Instance.Remove(EEventName.RefreshGachaMainView, new Action(this.RefreshGachaMainView));
		EventSystem.Instance.Remove(EEventName.GachaPoolSelectResponse, new Action<int, int>(this.OnGachaPoolSelectResponse));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
		EventSystem.Instance.Remove(EEventName.GachaNewNotify, new Action(this.OnCrossDay));
		EventSystem.Instance.Remove(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnPlaySequenceEventByStringParam));
		EventSystem.Instance.Remove(EEventName.GachaAccumulateRewardClaimed, new Action<int>(this.OnGachaAccumulateRewardClaimed));
	}

	// Token: 0x0600B022 RID: 45090 RVA: 0x0033F114 File Offset: 0x0033D314
	protected unsafe override void OnRegisterComponent()
	{
		int num = 35;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIInturnAnimController));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 5;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnHelpBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnShopBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnRecordBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnPreviewBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnChangeBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B023 RID: 45091 RVA: 0x0033F6A3 File Offset: 0x0033D8A3
	protected override void OnStart()
	{
		this.CountDownTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnCountDown), 1000f, 1f, null, null, true);
		UUIItem item = base.GetItem(33);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600B024 RID: 45092 RVA: 0x0033F6E4 File Offset: 0x0033D8E4
	private void OnCountDown(float delta)
	{
		ProtoGachaInfo curGachaInfo = this.CurGachaInfo;
		if (curGachaInfo == null)
		{
			return;
		}
		double poolEndTimeByPoolInfo = curGachaInfo.GetPoolEndTimeByPoolInfo(this.CurShowPoolInfo);
		if (poolEndTimeByPoolInfo == 0.0)
		{
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = poolEndTimeByPoolInfo - serverTime;
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat9(remainTime);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "Text_GachaRemainingTime_Text", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
	}

	// Token: 0x0600B025 RID: 45093 RVA: 0x0033F755 File Offset: 0x0033D955
	private void OnPlaySequenceEventByStringParam(string name)
	{
		if (name != "ListAni")
		{
			return;
		}
		base.GetUiInturnAnimController(30).Play("", -1, false);
	}

	// Token: 0x0600B026 RID: 45094 RVA: 0x0033F77C File Offset: 0x0033D97C
	private void OnCrossDay()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.GachaRefresh);
		confirmBoxDataNew.FunctionMap.Add(0, delegate
		{
			GachaController.Instance.GachaInfoRequest(false, false);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600B027 RID: 45095 RVA: 0x0033F7C8 File Offset: 0x0033D9C8
	private void OnHelpBtnClick()
	{
		if (this.CurGachaInfo == null)
		{
			Log.Instance.Error(ELogModule.Gacha, ELogAuthor.LPH, "OnHelpBtnClick CurGachaInfo is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CurGachaInfo.UsePoolId == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SelfGacha_NoDetail_Tips", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.GachaPoolDetailView, this.CurGachaInfo.GetPoolInfo(this.CurGachaInfo.UsePoolId), null);
		OnClickGachaOperationLogEvent onClickGachaOperationLogEvent = new OnClickGachaOperationLogEvent();
		onClickGachaOperationLogEvent.i_gacha_id = this.CurGachaInfo.Id;
		onClickGachaOperationLogEvent.i_operation_type = 3;
		LogReportController.Instance.LogReport(onClickGachaOperationLogEvent);
	}

	// Token: 0x0600B028 RID: 45096 RVA: 0x0033F870 File Offset: 0x0033DA70
	private void OnShopBtnClick()
	{
		int gachaJumpShopTabId = CommonConfig.Instance.GetGachaJumpShopTabId();
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ExchangeEntry, gachaJumpShopTabId);
		OnClickGachaOperationLogEvent onClickGachaOperationLogEvent = new OnClickGachaOperationLogEvent();
		onClickGachaOperationLogEvent.i_gacha_id = this.CurGachaInfo.Id;
		onClickGachaOperationLogEvent.i_operation_type = 1;
		LogReportController.Instance.LogReport(onClickGachaOperationLogEvent);
	}

	// Token: 0x0600B029 RID: 45097 RVA: 0x0033F8C0 File Offset: 0x0033DAC0
	private void OnRecordBtnClick()
	{
		GachaRecordClickLogEvent logData = new GachaRecordClickLogEvent();
		LogReportController.Instance.LogReport(logData);
		ProtoGachaInfo curGachaInfo = this.CurGachaInfo;
		if (curGachaInfo == null)
		{
			return;
		}
		int groupId = this.CurGachaInfo.GroupId;
		string gachaRecordUrlPrefix = GachaModel.Instance.GetGachaRecordUrlPrefix();
		string serverArea = GachaModel.Instance.GetServerArea();
		string platformStr = KuroSdkModel.Instance.GetPlatformStr();
		string[] array = new string[6];
		array[0] = "{0}/aki/gacha/index.html#/record?";
		int num = 1;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(70, 6);
		defaultInterpolatedStringHandler.AppendLiteral("svr_id={1}&player_id=");
		int? num2 = PlayerInfoModel.Instance.GetId();
		defaultInterpolatedStringHandler.AppendFormatted((num2 != null) ? num2.GetValueOrDefault().ToString() : null);
		defaultInterpolatedStringHandler.AppendLiteral("&lang=");
		defaultInterpolatedStringHandler.AppendFormatted(LanguageSystem.Instance.PackageLanguage);
		defaultInterpolatedStringHandler.AppendLiteral("&gacha_id=");
		ProtoGachaInfo curGachaInfo2 = this.CurGachaInfo;
		int? value;
		if (curGachaInfo2 == null)
		{
			num2 = null;
			value = num2;
		}
		else
		{
			value = new int?(curGachaInfo2.Id);
		}
		defaultInterpolatedStringHandler.AppendFormatted<int?>(value);
		defaultInterpolatedStringHandler.AppendLiteral("&gacha_type=");
		defaultInterpolatedStringHandler.AppendFormatted(groupId.ToString());
		defaultInterpolatedStringHandler.AppendLiteral("&svr_area=");
		defaultInterpolatedStringHandler.AppendFormatted(serverArea);
		defaultInterpolatedStringHandler.AppendLiteral("&record_id=");
		defaultInterpolatedStringHandler.AppendFormatted(GachaModel.Instance.RecordId);
		array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
		array[2] = "&resources_id=";
		int num3 = 3;
		ProtoGachaInfo curGachaInfo3 = this.CurGachaInfo;
		array[num3] = ((curGachaInfo3 != null) ? curGachaInfo3.ResourcesId : null);
		array[4] = "&platform=";
		array[5] = platformStr;
		string urlPattern = string.Concat(array);
		string url = CdnServerDebugConfig.Instance.TryGetGachaRecordDebugUrl(urlPattern, gachaRecordUrlPrefix, LoginModel.Instance.GetServerId());
		if (KuroSdkController.Instance.CanUseSdk())
		{
			KuroSdkController.Instance.OpenWebView("", url, true, true, true, "Default");
		}
		else
		{
			MailModel.Instance.OpenWebBrowser(url);
		}
		OnClickGachaOperationLogEvent onClickGachaOperationLogEvent = new OnClickGachaOperationLogEvent();
		onClickGachaOperationLogEvent.i_gacha_id = curGachaInfo.Id;
		onClickGachaOperationLogEvent.i_operation_type = 4;
		LogReportController.Instance.LogReport(onClickGachaOperationLogEvent);
	}

	// Token: 0x0600B02A RID: 45098 RVA: 0x0033FAB6 File Offset: 0x0033DCB6
	private void OnBackBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600B02B RID: 45099 RVA: 0x0033FAC0 File Offset: 0x0033DCC0
	private void OnPreviewBtnClick()
	{
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(this.CurShowPoolId);
		if (gachaViewInfo == null)
		{
			return;
		}
		int type = gachaViewInfo.Value.Type;
		int[] previewIdList = this.CurShowPoolInfo.PreviewIdList;
		IReadOnlyList<int> gachaRolePreviewTypeList = GachaConfig.Instance.GetGachaRolePreviewTypeList();
		bool flag = false;
		for (int i = 0; i < gachaRolePreviewTypeList.Count; i++)
		{
			if (gachaRolePreviewTypeList[i] == type)
			{
				flag = true;
				break;
			}
		}
		IReadOnlyList<int> gachaWeaponPreviewTypeList = GachaConfig.Instance.GetGachaWeaponPreviewTypeList();
		bool flag2 = false;
		for (int j = 0; j < gachaWeaponPreviewTypeList.Count; j++)
		{
			if (gachaWeaponPreviewTypeList[j] == type)
			{
				flag2 = true;
				break;
			}
		}
		if (flag)
		{
			List<int> list = new List<int>();
			foreach (int itemId in previewIdList)
			{
				list.Add(GachaConfig.Instance.GetGachaTextureInfo(itemId).Value.TrialId);
			}
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, list, null, null);
		}
		else if (flag2)
		{
			List<WeaponTrialData> list2 = new List<WeaponTrialData>();
			foreach (int itemId2 in previewIdList)
			{
				GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(itemId2);
				WeaponTrialData weaponTrialData = new WeaponTrialData();
				weaponTrialData.SetTrialId(gachaTextureInfo.Value.TrialId, true);
				list2.Add(weaponTrialData);
			}
			WeaponPreviewViewParam weaponPreviewViewParam = new WeaponPreviewViewParam();
			WeaponDataBase[] weaponDataList = list2.ToArray();
			weaponPreviewViewParam.WeaponDataList = weaponDataList;
			weaponPreviewViewParam.SelectedIndex = 0;
			WeaponPreviewViewParam param = weaponPreviewViewParam;
			UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
		}
		OnClickGachaOperationLogEvent onClickGachaOperationLogEvent = new OnClickGachaOperationLogEvent();
		onClickGachaOperationLogEvent.i_gacha_id = this.CurGachaInfo.Id;
		onClickGachaOperationLogEvent.i_operation_type = 2;
		LogReportController.Instance.LogReport(onClickGachaOperationLogEvent);
	}

	// Token: 0x0600B02C RID: 45100 RVA: 0x0033FC98 File Offset: 0x0033DE98
	private void OnClickSelectPoolButton(int _)
	{
		this.OnChangeBtnClick();
	}

	// Token: 0x0600B02D RID: 45101 RVA: 0x0033FCA0 File Offset: 0x0033DEA0
	private void OnChangeBtnClick()
	{
		ProtoGachaInfo curGachaInfo = this.CurGachaInfo;
		if (curGachaInfo != null)
		{
			GachaController.Instance.OpenGachaSelectionView(curGachaInfo);
			this.AfterOpenCommonWeaponSelectView();
		}
	}

	// Token: 0x0600B02E RID: 45102 RVA: 0x0033FCC8 File Offset: 0x0033DEC8
	protected override UniTask OnBeforeStartAsync()
	{
		GachaMainView.<OnBeforeStartAsync>d__55 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaMainView.<OnBeforeStartAsync>d__55>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B02F RID: 45103 RVA: 0x0033FD0C File Offset: 0x0033DF0C
	protected override void OnBeforeShow()
	{
		if (!this.IsViewFirstShow)
		{
			GachaController.Instance.GachaInfoRequest(false, false);
		}
		this.IsViewFirstShow = false;
		GachaModel instance = GachaModel.Instance;
		if (instance != null && instance.IsCacheShowNewNotify)
		{
			GachaModel.Instance.IsCacheShowNewNotify = false;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.GachaRefresh);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
		GachaPoolItem curPoolItem = this.CurPoolItem;
		if (curPoolItem == null)
		{
			return;
		}
		curPoolItem.PlayStartSeq();
	}

	// Token: 0x0600B030 RID: 45104 RVA: 0x0033FD76 File Offset: 0x0033DF76
	protected override void OnTick(float delta)
	{
		if (Time.Instance.ServerTimeStamp - this.LastRefreshTime >= 300000.0)
		{
			this.LastRefreshTime = Time.Instance.ServerTimeStamp;
			GachaController.Instance.GachaInfoRequest(false, false);
		}
	}

	// Token: 0x0600B031 RID: 45105 RVA: 0x0033FDB0 File Offset: 0x0033DFB0
	public void RefreshLeftTime()
	{
		ProtoGachaInfo curGachaInfo = this.CurGachaInfo;
		if (curGachaInfo == null)
		{
			return;
		}
		double poolEndTimeByPoolInfo = curGachaInfo.GetPoolEndTimeByPoolInfo(this.CurShowPoolInfo);
		if (poolEndTimeByPoolInfo == 0.0)
		{
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = poolEndTimeByPoolInfo - serverTime;
		if (num <= 0.0)
		{
			GachaController.Instance.GachaInfoRequest(false, false);
			return;
		}
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat9(num);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "Text_GachaRemainingTime_Text", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
		double remainingTime = remainTimeDataFormat.RemainingTime;
		if (remainingTime > 0.0)
		{
			double num2 = remainingTime;
			this.TimerHandle = TimerSystem.RealTimeInstance.Delay(delegate(float _)
			{
				this.RefreshLeftTime();
			}, (float)(num2 * 1000.0), null, "GachaMainView.RefreshLeftTime", false, 1f);
		}
	}

	// Token: 0x0600B032 RID: 45106 RVA: 0x0033FE89 File Offset: 0x0033E089
	private void RefreshGachaMainView()
	{
		this.RefreshGachaTag();
		this.RefreshGachaBtn();
	}

	// Token: 0x0600B033 RID: 45107 RVA: 0x0033FE97 File Offset: 0x0033E097
	private void OnItemExChangeResponse(int i, int i1)
	{
		this.RefreshGachaInfo();
	}

	// Token: 0x0600B034 RID: 45108 RVA: 0x0033FEA0 File Offset: 0x0033E0A0
	private void RefreshGachaInfo()
	{
		if (this.IsLock)
		{
			GachaMainView.OperationParam element = new GachaMainView.OperationParam(GachaMainView.EOperationType.RefreshGachaInfo, null);
			this.GachaOperationQueue.Push(element);
			return;
		}
		this.Lock();
		this.RefreshGachaInfoAsync(false).ContinueWith(new Action(this.Unlock)).Forget();
	}

	// Token: 0x0600B035 RID: 45109 RVA: 0x0033FEF0 File Offset: 0x0033E0F0
	private UniTask RefreshGachaInfoAsync(bool gachaAccumulateAnimate = true)
	{
		GachaMainView.<RefreshGachaInfoAsync>d__62 <RefreshGachaInfoAsync>d__;
		<RefreshGachaInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshGachaInfoAsync>d__.<>4__this = this;
		<RefreshGachaInfoAsync>d__.gachaAccumulateAnimate = gachaAccumulateAnimate;
		<RefreshGachaInfoAsync>d__.<>1__state = -1;
		<RefreshGachaInfoAsync>d__.<>t__builder.Start<GachaMainView.<RefreshGachaInfoAsync>d__62>(ref <RefreshGachaInfoAsync>d__);
		return <RefreshGachaInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B036 RID: 45110 RVA: 0x0033FF3C File Offset: 0x0033E13C
	private UniTask RefreshGachaAccumulateBtn(bool needAnimate = true)
	{
		GachaMainView.<RefreshGachaAccumulateBtn>d__63 <RefreshGachaAccumulateBtn>d__;
		<RefreshGachaAccumulateBtn>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshGachaAccumulateBtn>d__.<>4__this = this;
		<RefreshGachaAccumulateBtn>d__.needAnimate = needAnimate;
		<RefreshGachaAccumulateBtn>d__.<>1__state = -1;
		<RefreshGachaAccumulateBtn>d__.<>t__builder.Start<GachaMainView.<RefreshGachaAccumulateBtn>d__63>(ref <RefreshGachaAccumulateBtn>d__);
		return <RefreshGachaAccumulateBtn>d__.<>t__builder.Task;
	}

	// Token: 0x0600B037 RID: 45111 RVA: 0x0033FF88 File Offset: 0x0033E188
	private void AutoOpenGachaAccumulateTips()
	{
		int gachaAccumulateId = this.CurGachaInfo.GachaAccumulateId;
		if (gachaAccumulateId == 0)
		{
			return;
		}
		if (GachaAccumulateModel.Instance.IfGachaAccumulateNeedAutoOpenTips(gachaAccumulateId))
		{
			UiManager.Instance.OpenView(EUiViewName.GachaAccumulateBonusView, gachaAccumulateId, null);
			GachaAccumulateModel.Instance.SaveGachaAccumulateAutoOpenTips(gachaAccumulateId);
		}
	}

	// Token: 0x0600B038 RID: 45112 RVA: 0x0033FFD4 File Offset: 0x0033E1D4
	private void OnGachaAccumulateRewardClaimed(int accumulateId)
	{
		this.RefreshGachaAccumulateBtn(false).Forget();
		this.GachaTagScrollView.GetGenericLayout().GetSelectedGridIndex();
		GenericScrollViewNew<GachaTagItem, GachaPoolData> gachaTagScrollView = this.GachaTagScrollView;
		List<GachaTagItem> list = (gachaTagScrollView != null) ? gachaTagScrollView.GetScrollItemList() : null;
		if (list != null)
		{
			foreach (GachaTagItem gachaTagItem in list)
			{
				gachaTagItem.RefreshRedDot();
			}
		}
	}

	// Token: 0x0600B039 RID: 45113 RVA: 0x00340054 File Offset: 0x0033E254
	private void OnGachaPoolSelectResponse(int _1, int _2)
	{
		int selectedGridIndex = this.GachaTagScrollView.GetGenericLayout().GetSelectedGridIndex();
		if (this.TagDataList == null || selectedGridIndex < 0 || selectedGridIndex >= this.TagDataList.Length)
		{
			return;
		}
		GachaPoolData gachaPoolData = this.TagDataList[selectedGridIndex];
		GenericScrollViewNew<GachaTagItem, GachaPoolData> gachaTagScrollView = this.GachaTagScrollView;
		GachaTagItem gachaTagItem = (gachaTagScrollView != null) ? gachaTagScrollView.GetScrollItemByIndex(selectedGridIndex) : null;
		if (gachaPoolData == null || gachaTagItem == null)
		{
			return;
		}
		ProtoGachaInfo gachaInfo = gachaPoolData.GachaInfo;
		int usePoolId = gachaInfo.UsePoolId;
		ProtoGachaPoolInfo poolInfo = gachaInfo.GetPoolInfo(usePoolId);
		if (poolInfo == null)
		{
			return;
		}
		gachaPoolData.PoolInfo = poolInfo;
		gachaTagItem.Refresh(gachaPoolData, true, selectedGridIndex);
		this.RefreshGachaInfo();
		this.PlaySwitchAnim();
	}

	// Token: 0x0600B03A RID: 45114 RVA: 0x003400E8 File Offset: 0x0033E2E8
	private UniTask RefreshCurrency()
	{
		GachaMainView.<RefreshCurrency>d__67 <RefreshCurrency>d__;
		<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrency>d__.<>4__this = this;
		<RefreshCurrency>d__.<>1__state = -1;
		<RefreshCurrency>d__.<>t__builder.Start<GachaMainView.<RefreshCurrency>d__67>(ref <RefreshCurrency>d__);
		return <RefreshCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x0600B03B RID: 45115 RVA: 0x0034012C File Offset: 0x0033E32C
	private void RefreshGachaBtn()
	{
		if (this.CurGachaPoolData == null)
		{
			return;
		}
		EffectiveGachaButtonInfo[] effectiveGachaButtons = GachaModel.Instance.GetEffectiveGachaButtons(this.CurGachaInfo);
		EffectiveGachaButtonInfo effectiveGachaButtonInfo = Array.Find<EffectiveGachaButtonInfo>(effectiveGachaButtons, (EffectiveGachaButtonInfo button) => button.Times == this.GachaBtn1.Times);
		EffectiveGachaButtonInfo effectiveGachaButtonInfo2 = Array.Find<EffectiveGachaButtonInfo>(effectiveGachaButtons, (EffectiveGachaButtonInfo button) => button.Times == this.GachaBtn10.Times);
		bool flag = this.CurGachaInfo.UsePoolId != 0;
		this.GachaBtn1.GetRootItem().SetUIActive(effectiveGachaButtonInfo != null && flag);
		this.GachaBtn10.GetRootItem().SetUIActive(effectiveGachaButtonInfo2 != null && flag);
		if (effectiveGachaButtonInfo != null)
		{
			this.GachaBtn1.Refresh(this.CurGachaPoolData, effectiveGachaButtonInfo);
		}
		if (effectiveGachaButtonInfo2 != null)
		{
			this.GachaBtn10.Refresh(this.CurGachaPoolData, effectiveGachaButtonInfo2);
		}
		ProtoGachaInfo curGachaInfo = this.CurGachaInfo;
		bool flag2 = curGachaInfo != null && curGachaInfo.UsePoolId == 0;
		ButtonItem selectPoolButton = this.SelectPoolButton;
		if (selectPoolButton != null)
		{
			selectPoolButton.SetActive(flag2);
		}
		this.RefreshSelectBtnTag(flag2);
		ProtoGachaPoolInfo curShowPoolInfo = this.CurShowPoolInfo;
		bool flag3 = curShowPoolInfo != null && curShowPoolInfo.UiType == 5 && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.FirstOpenCommonWeaponSelect, false);
		ButtonItem selectPoolButton2 = this.SelectPoolButton;
		if (selectPoolButton2 != null)
		{
			selectPoolButton2.SetRedDotVisible(flag2 && flag3);
		}
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(this.CurShowPoolId);
		if (gachaViewInfo == null)
		{
			return;
		}
		int type = gachaViewInfo.Value.Type;
		GachaViewTypeInfo? gachaViewTypeConfig = GachaConfig.Instance.GetGachaViewTypeConfig(type);
		if (gachaViewTypeConfig == null)
		{
			return;
		}
		string gachaButtonTip = gachaViewTypeConfig.Value.GachaButtonTip;
		bool flag4 = StringUtils.IsBlank(gachaButtonTip);
		base.GetText(24).SetUIActive(!flag4);
		if (!flag4)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(24), gachaButtonTip, Array.Empty<object>());
		}
		this.RefreshDiscountList().Forget();
	}

	// Token: 0x0600B03C RID: 45116 RVA: 0x003402E8 File Offset: 0x0033E4E8
	private void RefreshSelectBtnTag(bool isShowSelectPoolButton)
	{
		UUIItem item = base.GetItem(34);
		GachaTagInfo gachaTagInfo = isShowSelectPoolButton ? GachaModel.Instance.GetSelectPoolButtonTag(this.CurGachaInfo) : null;
		if (gachaTagInfo == null)
		{
			this.SelectBtnTagItemA.SetUiActive(false);
			this.SelectBtnTagItemB.SetUiActive(false);
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		if (gachaTagInfo.Kind == EGachaTagKind.Custom)
		{
			this.SelectBtnTagItemA.SetUiActive(false);
			this.SelectBtnTagItemB.SetUiActive(true);
			this.SelectBtnTagItemB.SetContent(gachaTagInfo.Text);
			return;
		}
		this.SelectBtnTagItemB.SetUiActive(false);
		this.SelectBtnTagItemA.SetUiActive(true);
		if (gachaTagInfo.Kind == EGachaTagKind.Free)
		{
			this.SelectBtnTagItemA.SetLocalText("SaleTag_1", Array.Empty<object>());
			return;
		}
		this.SelectBtnTagItemA.SetLocalText("SaleTag_2", new object[]
		{
			gachaTagInfo.DiscountPct.Value
		});
	}

	// Token: 0x0600B03D RID: 45117 RVA: 0x003403D4 File Offset: 0x0033E5D4
	private UniTask RefreshDiscountList()
	{
		GachaMainView.<RefreshDiscountList>d__70 <RefreshDiscountList>d__;
		<RefreshDiscountList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshDiscountList>d__.<>4__this = this;
		<RefreshDiscountList>d__.<>1__state = -1;
		<RefreshDiscountList>d__.<>t__builder.Start<GachaMainView.<RefreshDiscountList>d__70>(ref <RefreshDiscountList>d__);
		return <RefreshDiscountList>d__.<>t__builder.Task;
	}

	// Token: 0x0600B03E RID: 45118 RVA: 0x00340418 File Offset: 0x0033E618
	private UniTask EnsureDiscountItems(int count)
	{
		GachaMainView.<EnsureDiscountItems>d__71 <EnsureDiscountItems>d__;
		<EnsureDiscountItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnsureDiscountItems>d__.<>4__this = this;
		<EnsureDiscountItems>d__.count = count;
		<EnsureDiscountItems>d__.<>1__state = -1;
		<EnsureDiscountItems>d__.<>t__builder.Start<GachaMainView.<EnsureDiscountItems>d__71>(ref <EnsureDiscountItems>d__);
		return <EnsureDiscountItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600B03F RID: 45119 RVA: 0x00340464 File Offset: 0x0033E664
	private void RefreshTimesText()
	{
		List<TableTextArgNew> list = new List<TableTextArgNew>();
		int todayResultCount = GachaModel.Instance.TodayResultCount;
		if (todayResultCount >= 0)
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("gacha_daily_total_limit_times");
			TableTextArgNew item = new TableTextArgNew("GachaTotalRestCount", new <>z__ReadOnlyArray<object>(new object[]
			{
				todayResultCount,
				intConfig
			}));
			list.Add(item);
		}
		if (this.CurGachaInfo.DailyLimitTimes > 0)
		{
			int dailyLimitTimes = this.CurGachaInfo.DailyLimitTimes;
			int todayTimes = this.CurGachaInfo.TodayTimes;
			TableTextArgNew item2 = new TableTextArgNew("GachaPoolTodayRestCount", new <>z__ReadOnlyArray<object>(new object[]
			{
				dailyLimitTimes - todayTimes,
				dailyLimitTimes
			}));
			list.Add(item2);
		}
		if (this.CurGachaInfo.TotalLimitTimes > 0)
		{
			int totalLimitTimes = this.CurGachaInfo.TotalLimitTimes;
			int totalTimes = this.CurGachaInfo.TotalTimes;
			TableTextArgNew item3 = new TableTextArgNew("GachaPoolTotalRestCount", new <>z__ReadOnlyArray<object>(new object[]
			{
				totalLimitTimes - totalTimes,
				totalLimitTimes
			}));
			list.Add(item3);
		}
		this.TimesTextLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600B040 RID: 45120 RVA: 0x0034058C File Offset: 0x0033E78C
	private void AfterOpenCommonWeaponSelectView()
	{
		ProtoGachaPoolInfo curShowPoolInfo = this.CurShowPoolInfo;
		if (curShowPoolInfo == null || curShowPoolInfo.UiType != 5)
		{
			return;
		}
		if (!LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.FirstOpenCommonWeaponSelect, false))
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.FirstOpenCommonWeaponSelect, true);
			EventSystem.Instance.Emit(EEventName.OnOpenCommonWeaponSelect);
			this.RefreshGachaBtn();
			int selectedGridIndex = this.GachaTagScrollView.GetGenericLayout().GetSelectedGridIndex();
			GenericScrollViewNew<GachaTagItem, GachaPoolData> gachaTagScrollView = this.GachaTagScrollView;
			GachaTagItem gachaTagItem = (gachaTagScrollView != null) ? gachaTagScrollView.GetScrollItemByIndex(selectedGridIndex) : null;
			if (gachaTagItem != null)
			{
				gachaTagItem.RefreshRedDot();
			}
		}
	}

	// Token: 0x0600B041 RID: 45121 RVA: 0x00340614 File Offset: 0x0033E814
	private UniTask InitBackGroundItem()
	{
		GachaMainView.<InitBackGroundItem>d__74 <InitBackGroundItem>d__;
		<InitBackGroundItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackGroundItem>d__.<>4__this = this;
		<InitBackGroundItem>d__.<>1__state = -1;
		<InitBackGroundItem>d__.<>t__builder.Start<GachaMainView.<InitBackGroundItem>d__74>(ref <InitBackGroundItem>d__);
		return <InitBackGroundItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600B042 RID: 45122 RVA: 0x00340658 File Offset: 0x0033E858
	private UniTask InitSpineBackgroundItem(string resourceId)
	{
		GachaMainView.<InitSpineBackgroundItem>d__75 <InitSpineBackgroundItem>d__;
		<InitSpineBackgroundItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSpineBackgroundItem>d__.<>4__this = this;
		<InitSpineBackgroundItem>d__.resourceId = resourceId;
		<InitSpineBackgroundItem>d__.<>1__state = -1;
		<InitSpineBackgroundItem>d__.<>t__builder.Start<GachaMainView.<InitSpineBackgroundItem>d__75>(ref <InitSpineBackgroundItem>d__);
		return <InitSpineBackgroundItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600B043 RID: 45123 RVA: 0x003406A4 File Offset: 0x0033E8A4
	private void PlaySwitchAnim()
	{
		GachaPoolItem curPoolItem = this.CurPoolItem;
		if (curPoolItem != null)
		{
			curPoolItem.SetActive(true);
		}
		if (this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
		{
			this.UiViewSequence.ReplaySequence("Switch");
		}
		else
		{
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}
		GachaPoolItem curPoolItem2 = this.CurPoolItem;
		if (curPoolItem2 == null)
		{
			return;
		}
		curPoolItem2.PlaySwitchSeq();
	}

	// Token: 0x0600B044 RID: 45124 RVA: 0x00340714 File Offset: 0x0033E914
	private void RefreshDetail()
	{
		ProtoGachaInfo curGachaInfo = this.CurGachaInfo;
		if (curGachaInfo == null)
		{
			return;
		}
		if (this.CurShowPoolInfo == null)
		{
			return;
		}
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(this.CurShowPoolId);
		if (gachaViewInfo == null)
		{
			return;
		}
		int uiType = this.CurShowPoolInfo.UiType;
		GachaViewTypeInfo? gachaViewTypeConfig = GachaConfig.Instance.GetGachaViewTypeConfig(uiType);
		if (gachaViewTypeConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), gachaViewTypeConfig.Value.TypeText, Array.Empty<object>());
		double poolEndTimeByPoolInfo = curGachaInfo.GetPoolEndTimeByPoolInfo(this.CurShowPoolInfo);
		base.GetItem(11).SetUIActive(poolEndTimeByPoolInfo > 0.0);
		if (poolEndTimeByPoolInfo > 0.0)
		{
			this.RefreshLeftTime();
		}
		else if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		int[] upList = this.CurShowPoolInfo.UpList;
		bool flag = GachaModel.Instance.IsRolePool((GachaDefine.EGachaViewType)uiType);
		if (upList != null && upList.Length != 0)
		{
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			GenericLayout<GachaSmallItemGrid, int> upItemLayout = this.UpItemLayout;
			if (upItemLayout != null)
			{
				upItemLayout.RefreshByData(upList, null, false);
			}
			string textStringId = flag ? "Text_GachaUpList1_Text" : "Text_GachaUpList2_Text";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), textStringId, Array.Empty<object>());
		}
		else
		{
			UUIItem item2 = base.GetItem(15);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		ProtoGachaPoolInfo[] validPoolList = curGachaInfo.GetValidPoolList();
		if (validPoolList != null && validPoolList.Length > 1 && curGachaInfo.UsePoolId != 0)
		{
			UUIButtonComponent button = base.GetButton(18);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(true);
			}
		}
		else
		{
			UUIButtonComponent button2 = base.GetButton(18);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(false);
			}
		}
		base.SetTextureByPath(gachaViewInfo.Value.UnderBgTexturePath, base.GetTexture(19), null, null);
		FColor color = FColor.FromHex(this.CurShowPoolInfo.ThemeColor);
		UUITexture texture = base.GetTexture(20);
		if (texture != null)
		{
			texture.SetColor(color);
		}
		UUITexture texture2 = base.GetTexture(21);
		texture2.SetUIActive(flag);
		if (flag)
		{
			texture2.SetColor(color);
		}
		base.GetText(10).SetText(this.CurShowPoolInfo.Title, true);
		base.GetText(13).SetText(this.CurShowPoolInfo.Description, true);
		base.GetText(28).SetText(this.CurShowPoolInfo.ComplianceDetail, true);
		base.GetText(28).SetUIActive(!StringUtils.IsEmpty(this.CurShowPoolInfo.ComplianceDetail));
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(29);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		scrollViewWithScrollbar.SetScrollProgress(0f);
	}

	// Token: 0x0600B045 RID: 45125 RVA: 0x003409D8 File Offset: 0x0033EBD8
	private void RefreshGachaTag()
	{
		if (this.IsLock)
		{
			GachaMainView.OperationParam element = new GachaMainView.OperationParam(GachaMainView.EOperationType.RefreshGachaTag, null);
			this.GachaOperationQueue.Push(element);
			return;
		}
		this.Lock();
		this.RefreshGachaTagAsync().ContinueWith(new Action(this.Unlock)).Forget();
	}

	// Token: 0x0600B046 RID: 45126 RVA: 0x00340A24 File Offset: 0x0033EC24
	private UniTask RefreshGachaTagAsync()
	{
		GachaMainView.<RefreshGachaTagAsync>d__79 <RefreshGachaTagAsync>d__;
		<RefreshGachaTagAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshGachaTagAsync>d__.<>4__this = this;
		<RefreshGachaTagAsync>d__.<>1__state = -1;
		<RefreshGachaTagAsync>d__.<>t__builder.Start<GachaMainView.<RefreshGachaTagAsync>d__79>(ref <RefreshGachaTagAsync>d__);
		return <RefreshGachaTagAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B047 RID: 45127 RVA: 0x00340A67 File Offset: 0x0033EC67
	private GachaTagItem CreateGachaTagItem()
	{
		return new GachaTagItem
		{
			SelectCallback = new Action<int>(this.SelectGachaTagByIndex),
			CanExecuteChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x0600B048 RID: 45128 RVA: 0x00340A92 File Offset: 0x0033EC92
	private CommonTextItem InitTimesTextItem()
	{
		return new CommonTextItem();
	}

	// Token: 0x0600B049 RID: 45129 RVA: 0x00340A99 File Offset: 0x0033EC99
	private GachaSmallItemGrid InitUpItem()
	{
		return new GachaSmallItemGrid();
	}

	// Token: 0x0600B04A RID: 45130 RVA: 0x00340AA0 File Offset: 0x0033ECA0
	private void SelectGachaTagByIndex(int gridIndex)
	{
		if (this.IsLock)
		{
			GachaMainView.OperationParam element = new GachaMainView.OperationParam(GachaMainView.EOperationType.SelectGachaTagByIndex, gridIndex);
			this.GachaOperationQueue.Push(element);
			return;
		}
		this.Lock();
		this.SelectGachaTagByIndexAsync(gridIndex).ContinueWith(new Action(this.Unlock)).Forget();
	}

	// Token: 0x0600B04B RID: 45131 RVA: 0x00340AF4 File Offset: 0x0033ECF4
	private UniTask SelectGachaTagByIndexAsync(int gridIndex)
	{
		GachaMainView.<SelectGachaTagByIndexAsync>d__84 <SelectGachaTagByIndexAsync>d__;
		<SelectGachaTagByIndexAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SelectGachaTagByIndexAsync>d__.<>4__this = this;
		<SelectGachaTagByIndexAsync>d__.gridIndex = gridIndex;
		<SelectGachaTagByIndexAsync>d__.<>1__state = -1;
		<SelectGachaTagByIndexAsync>d__.<>t__builder.Start<GachaMainView.<SelectGachaTagByIndexAsync>d__84>(ref <SelectGachaTagByIndexAsync>d__);
		return <SelectGachaTagByIndexAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B04C RID: 45132 RVA: 0x00340B40 File Offset: 0x0033ED40
	private bool CanToggleChange(int gridIndex)
	{
		GenericScrollViewNew<GachaTagItem, GachaPoolData> gachaTagScrollView = this.GachaTagScrollView;
		int? num;
		if (gachaTagScrollView == null)
		{
			num = null;
		}
		else
		{
			GenericLayout<GachaTagItem, GachaPoolData> genericLayout = gachaTagScrollView.GetGenericLayout();
			num = ((genericLayout != null) ? new int?(genericLayout.GetSelectedGridIndex()) : null);
		}
		int? num2 = num;
		return !(gridIndex == num2.GetValueOrDefault() & num2 != null);
	}

	// Token: 0x0600B04D RID: 45133 RVA: 0x00340B98 File Offset: 0x0033ED98
	private void OpenExChangeTokenView(int _)
	{
		ProtoGachaInfo curGachaInfo = this.CurGachaInfo;
		int? num = (curGachaInfo != null) ? new int?(curGachaInfo.ItemId) : null;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() <= num3 & num2 != null))
			{
				int shopIdByGachaItemId = GachaConfig.Instance.GetShopIdByGachaItemId(num.Value);
				if (shopIdByGachaItemId <= 0)
				{
					return;
				}
				PayShopController.Instance.OpenExchangePopView(shopIdByGachaItemId, null);
				return;
			}
		}
	}

	// Token: 0x0600B04E RID: 45134 RVA: 0x00340C0D File Offset: 0x0033EE0D
	private void OnPrimaryCurrencyClick(int _)
	{
		PayShopController.Instance.OpenPayShopViewToRecharge();
	}

	// Token: 0x0600B04F RID: 45135 RVA: 0x00340C1C File Offset: 0x0033EE1C
	private void OpenExChangeSecondCurrencyView(int _)
	{
		int? num = GachaConfig.Instance.SecondCurrency();
		CommonExchangeData exchangeData = new CommonExchangeData();
		exchangeData.InitByItemId(num.Value);
		exchangeData.ConfirmNoClose = true;
		exchangeData.ConfirmCallBack = delegate(int itemId, int exChangeTime)
		{
			ExchangeSimulation exchangeSimulation = ItemExchangeModel.Instance.CalculateConsume(itemId, 0, exChangeTime, false);
			if (exchangeSimulation == null || exChangeTime == 0)
			{
				UiManager.Instance.CloseView(EUiViewName.CommonExchangeView, null);
				return;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(exchangeData.GetSrcItemId(), 0);
			int num2 = exchangeSimulation.ConsumeCount - itemCountByConfigId;
			if (num2 <= 0)
			{
				ItemExchangeController.Instance.ItemExchangeRequest(itemId, exChangeTime, true, null);
				UiManager.Instance.CloseView(EUiViewName.CommonExchangeView, null);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ExchangeNoEnough);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				num2.ToString(),
				exchangeData.GetSrcName()
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				UiManager.Instance.CloseView(EUiViewName.CommonExchangeView, null);
				PayShopController.Instance.OpenPayShopViewToRecharge();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		};
		ItemExchangeController.Instance.OpenExchangeViewByData(exchangeData);
	}

	// Token: 0x0600B050 RID: 45136 RVA: 0x00340C8A File Offset: 0x0033EE8A
	protected override void OnAfterHide()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600B051 RID: 45137 RVA: 0x00340CAC File Offset: 0x0033EEAC
	protected override void OnBeforeDestroy()
	{
		if (this.CountDownTimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.CountDownTimerHandle);
			this.CountDownTimerHandle = null;
		}
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.Destroy(null);
	}

	// Token: 0x0600B052 RID: 45138 RVA: 0x00340CE0 File Offset: 0x0033EEE0
	public bool SelectGachaTagById(int gachaId)
	{
		int num = Array.FindIndex<GachaPoolData>(this.TagDataList, (GachaPoolData data) => data.GachaInfo.Id == gachaId);
		if (num >= 0 && num < this.TagDataList.Length)
		{
			this.SelectGachaTagByIndex(num);
			return true;
		}
		return false;
	}

	// Token: 0x0600B053 RID: 45139 RVA: 0x00340D2C File Offset: 0x0033EF2C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int num = int.Parse(configParams[0]);
		if (num != 0 && this.SelectGachaTagById(num) && this.GachaBtn1 != null)
		{
			UUIItem rootItem = this.GachaBtn1.GetRootItem();
			return new UUIItem[]
			{
				rootItem,
				rootItem
			};
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Guide;
		ELogAuthor author = ELogAuthor.JT;
		string message = "聚焦引导extraParam项配置有误";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x040065C8 RID: 26056
	[Nullable(2)]
	private GachaAccumulateTipsItem GachaAccumulateTipsItem;

	// Token: 0x040065C9 RID: 26057
	private readonly Dictionary<GachaDefine.EGachaViewType, GachaPoolItem> GachaPoolItemMap = new Dictionary<GachaDefine.EGachaViewType, GachaPoolItem>();

	// Token: 0x040065CA RID: 26058
	private readonly Dictionary<int, GachaPoolItem> SpineGachaPoolItemMap = new Dictionary<int, GachaPoolItem>();

	// Token: 0x040065CB RID: 26059
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<GachaTagItem, GachaPoolData> GachaTagScrollView;

	// Token: 0x040065CC RID: 26060
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GachaPoolData[] TagDataList;

	// Token: 0x040065CD RID: 26061
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CommonTextItem, TableTextArgNew> TimesTextLayout;

	// Token: 0x040065CE RID: 26062
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<GachaSmallItemGrid, int> UpItemLayout;

	// Token: 0x040065CF RID: 26063
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040065D0 RID: 26064
	[Nullable(2)]
	private GachaButton GachaBtn1;

	// Token: 0x040065D1 RID: 26065
	[Nullable(2)]
	private GachaButton GachaBtn10;

	// Token: 0x040065D2 RID: 26066
	[Nullable(2)]
	private ButtonItem SelectPoolButton;

	// Token: 0x040065D3 RID: 26067
	[Nullable(2)]
	private GachaDiscountTagItem SelectBtnTagItemA;

	// Token: 0x040065D4 RID: 26068
	[Nullable(2)]
	private GachaDiscountTagItem SelectBtnTagItemB;

	// Token: 0x040065D5 RID: 26069
	private readonly List<GachaDiscountTimesItem> DiscountItems = new List<GachaDiscountTimesItem>();

	// Token: 0x040065D6 RID: 26070
	[Nullable(2)]
	private GachaPoolItem CurPoolItem;

	// Token: 0x040065D7 RID: 26071
	private bool IsViewFirstShow;

	// Token: 0x040065D8 RID: 26072
	private double LastRefreshTime;

	// Token: 0x040065D9 RID: 26073
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040065DA RID: 26074
	[Nullable(2)]
	private TimerHandle CountDownTimerHandle;

	// Token: 0x040065DB RID: 26075
	private readonly Queue<GachaMainView.OperationParam> GachaOperationQueue = new Queue<GachaMainView.OperationParam>(4);

	// Token: 0x040065DC RID: 26076
	private bool Operating;

	// Token: 0x020073CC RID: 29644
	[NullableContext(0)]
	private enum EOperationType
	{
		// Token: 0x04025B23 RID: 154403
		RefreshGachaTag,
		// Token: 0x04025B24 RID: 154404
		RefreshGachaInfo,
		// Token: 0x04025B25 RID: 154405
		SelectGachaTagByIndex
	}

	// Token: 0x020073CD RID: 29645
	[NullableContext(2)]
	[Nullable(0)]
	private class OperationParam
	{
		// Token: 0x060406A6 RID: 263846 RVA: 0x012EA48E File Offset: 0x012E868E
		public OperationParam(GachaMainView.EOperationType operationType, object param = null)
		{
			this.OperationType = operationType;
			this.Param = param;
		}

		// Token: 0x04025B26 RID: 154406
		public GachaMainView.EOperationType OperationType;

		// Token: 0x04025B27 RID: 154407
		public object Param;
	}

	// Token: 0x020073CE RID: 29646
	[NullableContext(0)]
	private enum EGachaMainCom
	{
		// Token: 0x04025B29 RID: 154409
		CaptionItem,
		// Token: 0x04025B2A RID: 154410
		ShopBtn,
		// Token: 0x04025B2B RID: 154411
		PreviewBtn,
		// Token: 0x04025B2C RID: 154412
		HelpBtn,
		// Token: 0x04025B2D RID: 154413
		RecordBtn,
		// Token: 0x04025B2E RID: 154414
		GachaBtnItem1,
		// Token: 0x04025B2F RID: 154415
		GachaBtnItem10,
		// Token: 0x04025B30 RID: 154416
		GachaPoolParentItem,
		// Token: 0x04025B31 RID: 154417
		GachaPoolScrollView,
		// Token: 0x04025B32 RID: 154418
		TypeText,
		// Token: 0x04025B33 RID: 154419
		TitleText,
		// Token: 0x04025B34 RID: 154420
		DateItem,
		// Token: 0x04025B35 RID: 154421
		DateText,
		// Token: 0x04025B36 RID: 154422
		DetailText,
		// Token: 0x04025B37 RID: 154423
		TimesTextLayout,
		// Token: 0x04025B38 RID: 154424
		UpItemRootItem,
		// Token: 0x04025B39 RID: 154425
		UpItemTipText,
		// Token: 0x04025B3A RID: 154426
		UpItemLayout,
		// Token: 0x04025B3B RID: 154427
		ChangeBtn,
		// Token: 0x04025B3C RID: 154428
		BgTexture,
		// Token: 0x04025B3D RID: 154429
		ThemeTextMaskTexture,
		// Token: 0x04025B3E RID: 154430
		RoleBgTexture,
		// Token: 0x04025B3F RID: 154431
		SelectTipsItem,
		// Token: 0x04025B40 RID: 154432
		SelectPoolButton,
		// Token: 0x04025B41 RID: 154433
		TxtTips,
		// Token: 0x04025B42 RID: 154434
		GuaranteedItem,
		// Token: 0x04025B43 RID: 154435
		GuaranteedNumText,
		// Token: 0x04025B44 RID: 154436
		GuaranteedText,
		// Token: 0x04025B45 RID: 154437
		GachaComplianceText,
		// Token: 0x04025B46 RID: 154438
		TextScroller,
		// Token: 0x04025B47 RID: 154439
		LayoutTurnAniController,
		// Token: 0x04025B48 RID: 154440
		GachaAccumulateTipsItem,
		// Token: 0x04025B49 RID: 154441
		DiscountList,
		// Token: 0x04025B4A RID: 154442
		DiscountTemplate,
		// Token: 0x04025B4B RID: 154443
		SelectBtnTagRoot
	}
}
