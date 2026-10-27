using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001C81 RID: 7297
[NullableContext(1)]
[Nullable(0)]
public class GachaMainView : UiTickViewBase
{
	// Token: 0x0600DBFF RID: 56319 RVA: 0x0033392F File Offset: 0x00331B2F
	public GachaMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DC00 RID: 56320 RVA: 0x00333968 File Offset: 0x00331B68
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

	// Token: 0x0600DC01 RID: 56321 RVA: 0x003339B4 File Offset: 0x00331BB4
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

	// Token: 0x170011E4 RID: 4580
	// (get) Token: 0x0600DC02 RID: 56322 RVA: 0x00333A07 File Offset: 0x00331C07
	private new int? OpenParam
	{
		get
		{
			return this.OpenParam as int?;
		}
	}

	// Token: 0x170011E5 RID: 4581
	// (get) Token: 0x0600DC03 RID: 56323 RVA: 0x00333A19 File Offset: 0x00331C19
	private ProtoGachaInfo CurGachaInfo
	{
		get
		{
			return this.CurGachaPoolData.GachaInfo;
		}
	}

	// Token: 0x170011E6 RID: 4582
	// (get) Token: 0x0600DC04 RID: 56324 RVA: 0x00333A26 File Offset: 0x00331C26
	private int CurShowPoolId
	{
		get
		{
			return this.CurGachaPoolData.PoolInfo.Id;
		}
	}

	// Token: 0x170011E7 RID: 4583
	// (get) Token: 0x0600DC05 RID: 56325 RVA: 0x00333A38 File Offset: 0x00331C38
	private ProtoGachaPoolInfo CurShowPoolInfo
	{
		get
		{
			return this.CurGachaPoolData.PoolInfo;
		}
	}

	// Token: 0x170011E8 RID: 4584
	// (get) Token: 0x0600DC06 RID: 56326 RVA: 0x00333A48 File Offset: 0x00331C48
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

	// Token: 0x170011E9 RID: 4585
	// (get) Token: 0x0600DC07 RID: 56327 RVA: 0x00333A87 File Offset: 0x00331C87
	private bool IsLock
	{
		get
		{
			return this.Operating;
		}
	}

	// Token: 0x0600DC08 RID: 56328 RVA: 0x00333A8F File Offset: 0x00331C8F
	private void Lock()
	{
		this.Operating = true;
	}

	// Token: 0x0600DC09 RID: 56329 RVA: 0x00333A98 File Offset: 0x00331C98
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

	// Token: 0x0600DC0A RID: 56330 RVA: 0x00333B0C File Offset: 0x00331D0C
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

	// Token: 0x0600DC0B RID: 56331 RVA: 0x00333BE0 File Offset: 0x00331DE0
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

	// Token: 0x0600DC0C RID: 56332 RVA: 0x00333CB4 File Offset: 0x00331EB4
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

	// Token: 0x0600DC0D RID: 56333 RVA: 0x00334243 File Offset: 0x00332443
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

	// Token: 0x0600DC0E RID: 56334 RVA: 0x00334284 File Offset: 0x00332484
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

	// Token: 0x0600DC0F RID: 56335 RVA: 0x003342F5 File Offset: 0x003324F5
	private void OnPlaySequenceEventByStringParam(string name)
	{
		if (name != "ListAni")
		{
			return;
		}
		base.GetUiInturnAnimController(30).Play("", -1, false);
	}

	// Token: 0x0600DC10 RID: 56336 RVA: 0x0033431C File Offset: 0x0033251C
	private void OnCrossDay()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.GachaRefresh);
		confirmBoxDataNew.FunctionMap.Add(0, delegate
		{
			GachaController.Instance.GachaInfoRequest(false, false);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600DC11 RID: 56337 RVA: 0x00334368 File Offset: 0x00332568
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

	// Token: 0x0600DC12 RID: 56338 RVA: 0x00334410 File Offset: 0x00332610
	private void OnShopBtnClick()
	{
		int gachaJumpShopTabId = CommonConfig.Instance.GetGachaJumpShopTabId();
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ExchangeEntry, gachaJumpShopTabId);
		OnClickGachaOperationLogEvent onClickGachaOperationLogEvent = new OnClickGachaOperationLogEvent();
		onClickGachaOperationLogEvent.i_gacha_id = this.CurGachaInfo.Id;
		onClickGachaOperationLogEvent.i_operation_type = 1;
		LogReportController.Instance.LogReport(onClickGachaOperationLogEvent);
	}

	// Token: 0x0600DC13 RID: 56339 RVA: 0x00334460 File Offset: 0x00332660
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

	// Token: 0x0600DC14 RID: 56340 RVA: 0x00334656 File Offset: 0x00332856
	private void OnBackBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600DC15 RID: 56341 RVA: 0x00334660 File Offset: 0x00332860
	private void OnPreviewBtnClick()
	{
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(this.CurShowPoolId);
		if (gachaViewInfo == null)
		{
			return;
		}
		int type = gachaViewInfo.Value.Type;
		int[] previewIdList = this.CurShowPoolInfo.PreviewIdList;
		if (GachaConfig.Instance.GetGachaRolePreviewTypeList().Contains(type))
		{
			List<int> list = new List<int>();
			foreach (int itemId in previewIdList)
			{
				list.Add(GachaConfig.Instance.GetGachaTextureInfo(itemId).Value.TrialId);
			}
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, list, null, null);
		}
		else if (GachaConfig.Instance.GetGachaWeaponPreviewTypeList().Contains(type))
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

	// Token: 0x0600DC16 RID: 56342 RVA: 0x003347E7 File Offset: 0x003329E7
	private void OnClickSelectPoolButton(int _)
	{
		this.OnChangeBtnClick();
	}

	// Token: 0x0600DC17 RID: 56343 RVA: 0x003347F0 File Offset: 0x003329F0
	private void OnChangeBtnClick()
	{
		ProtoGachaInfo curGachaInfo = this.CurGachaInfo;
		if (curGachaInfo != null)
		{
			GachaController.Instance.OpenGachaSelectionView(curGachaInfo);
			this.AfterOpenCommonWeaponSelectView();
		}
	}

	// Token: 0x0600DC18 RID: 56344 RVA: 0x00334818 File Offset: 0x00332A18
	protected override UniTask OnBeforeStartAsync()
	{
		GachaMainView.<OnBeforeStartAsync>d__55 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaMainView.<OnBeforeStartAsync>d__55>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC19 RID: 56345 RVA: 0x0033485C File Offset: 0x00332A5C
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

	// Token: 0x0600DC1A RID: 56346 RVA: 0x003348C6 File Offset: 0x00332AC6
	protected override void OnTick(float delta)
	{
		if (Time.Instance.ServerTimeStamp - this.LastRefreshTime >= 300000.0)
		{
			this.LastRefreshTime = Time.Instance.ServerTimeStamp;
			GachaController.Instance.GachaInfoRequest(false, false);
		}
	}

	// Token: 0x0600DC1B RID: 56347 RVA: 0x00334900 File Offset: 0x00332B00
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

	// Token: 0x0600DC1C RID: 56348 RVA: 0x003349D9 File Offset: 0x00332BD9
	private void RefreshGachaMainView()
	{
		this.RefreshGachaTag();
		this.RefreshGachaBtn();
	}

	// Token: 0x0600DC1D RID: 56349 RVA: 0x003349E7 File Offset: 0x00332BE7
	private void OnItemExChangeResponse(int i, int i1)
	{
		this.RefreshGachaInfo();
	}

	// Token: 0x0600DC1E RID: 56350 RVA: 0x003349F0 File Offset: 0x00332BF0
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

	// Token: 0x0600DC1F RID: 56351 RVA: 0x00334A40 File Offset: 0x00332C40
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

	// Token: 0x0600DC20 RID: 56352 RVA: 0x00334A8C File Offset: 0x00332C8C
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

	// Token: 0x0600DC21 RID: 56353 RVA: 0x00334AD8 File Offset: 0x00332CD8
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

	// Token: 0x0600DC22 RID: 56354 RVA: 0x00334B24 File Offset: 0x00332D24
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

	// Token: 0x0600DC23 RID: 56355 RVA: 0x00334BA4 File Offset: 0x00332DA4
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

	// Token: 0x0600DC24 RID: 56356 RVA: 0x00334C38 File Offset: 0x00332E38
	private UniTask RefreshCurrency()
	{
		GachaMainView.<RefreshCurrency>d__67 <RefreshCurrency>d__;
		<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrency>d__.<>4__this = this;
		<RefreshCurrency>d__.<>1__state = -1;
		<RefreshCurrency>d__.<>t__builder.Start<GachaMainView.<RefreshCurrency>d__67>(ref <RefreshCurrency>d__);
		return <RefreshCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC25 RID: 56357 RVA: 0x00334C7C File Offset: 0x00332E7C
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

	// Token: 0x0600DC26 RID: 56358 RVA: 0x00334E38 File Offset: 0x00333038
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

	// Token: 0x0600DC27 RID: 56359 RVA: 0x00334F24 File Offset: 0x00333124
	private UniTask RefreshDiscountList()
	{
		GachaMainView.<RefreshDiscountList>d__70 <RefreshDiscountList>d__;
		<RefreshDiscountList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshDiscountList>d__.<>4__this = this;
		<RefreshDiscountList>d__.<>1__state = -1;
		<RefreshDiscountList>d__.<>t__builder.Start<GachaMainView.<RefreshDiscountList>d__70>(ref <RefreshDiscountList>d__);
		return <RefreshDiscountList>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC28 RID: 56360 RVA: 0x00334F68 File Offset: 0x00333168
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

	// Token: 0x0600DC29 RID: 56361 RVA: 0x00334FB4 File Offset: 0x003331B4
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
		this.TimesTextLayout.RefreshByData(list.ToList<TableTextArgNew>(), null, false);
	}

	// Token: 0x0600DC2A RID: 56362 RVA: 0x003350E0 File Offset: 0x003332E0
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

	// Token: 0x0600DC2B RID: 56363 RVA: 0x00335168 File Offset: 0x00333368
	private UniTask InitBackGroundItem()
	{
		GachaMainView.<InitBackGroundItem>d__74 <InitBackGroundItem>d__;
		<InitBackGroundItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackGroundItem>d__.<>4__this = this;
		<InitBackGroundItem>d__.<>1__state = -1;
		<InitBackGroundItem>d__.<>t__builder.Start<GachaMainView.<InitBackGroundItem>d__74>(ref <InitBackGroundItem>d__);
		return <InitBackGroundItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC2C RID: 56364 RVA: 0x003351AC File Offset: 0x003333AC
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

	// Token: 0x0600DC2D RID: 56365 RVA: 0x003351F8 File Offset: 0x003333F8
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

	// Token: 0x0600DC2E RID: 56366 RVA: 0x00335268 File Offset: 0x00333468
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
				upItemLayout.RefreshByData(upList.ToList<int>(), null, false);
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

	// Token: 0x0600DC2F RID: 56367 RVA: 0x00335530 File Offset: 0x00333730
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

	// Token: 0x0600DC30 RID: 56368 RVA: 0x0033557C File Offset: 0x0033377C
	private UniTask RefreshGachaTagAsync()
	{
		GachaMainView.<RefreshGachaTagAsync>d__79 <RefreshGachaTagAsync>d__;
		<RefreshGachaTagAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshGachaTagAsync>d__.<>4__this = this;
		<RefreshGachaTagAsync>d__.<>1__state = -1;
		<RefreshGachaTagAsync>d__.<>t__builder.Start<GachaMainView.<RefreshGachaTagAsync>d__79>(ref <RefreshGachaTagAsync>d__);
		return <RefreshGachaTagAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC31 RID: 56369 RVA: 0x003355BF File Offset: 0x003337BF
	private GachaTagItem CreateGachaTagItem()
	{
		return new GachaTagItem
		{
			SelectCallback = new Action<int>(this.SelectGachaTagByIndex),
			CanExecuteChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x0600DC32 RID: 56370 RVA: 0x003355EA File Offset: 0x003337EA
	private CommonTextItem InitTimesTextItem()
	{
		return new CommonTextItem();
	}

	// Token: 0x0600DC33 RID: 56371 RVA: 0x003355F1 File Offset: 0x003337F1
	private GachaSmallItemGrid InitUpItem()
	{
		return new GachaSmallItemGrid();
	}

	// Token: 0x0600DC34 RID: 56372 RVA: 0x003355F8 File Offset: 0x003337F8
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

	// Token: 0x0600DC35 RID: 56373 RVA: 0x0033564C File Offset: 0x0033384C
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

	// Token: 0x0600DC36 RID: 56374 RVA: 0x00335698 File Offset: 0x00333898
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

	// Token: 0x0600DC37 RID: 56375 RVA: 0x003356F0 File Offset: 0x003338F0
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

	// Token: 0x0600DC38 RID: 56376 RVA: 0x00335765 File Offset: 0x00333965
	private void OnPrimaryCurrencyClick(int _)
	{
		PayShopController.Instance.OpenPayShopViewToRecharge();
	}

	// Token: 0x0600DC39 RID: 56377 RVA: 0x00335774 File Offset: 0x00333974
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

	// Token: 0x0600DC3A RID: 56378 RVA: 0x003357E2 File Offset: 0x003339E2
	protected override void OnAfterHide()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600DC3B RID: 56379 RVA: 0x00335804 File Offset: 0x00333A04
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

	// Token: 0x0600DC3C RID: 56380 RVA: 0x00335838 File Offset: 0x00333A38
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

	// Token: 0x0600DC3D RID: 56381 RVA: 0x00335884 File Offset: 0x00333A84
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

	// Token: 0x040064F6 RID: 25846
	[Nullable(2)]
	private GachaAccumulateTipsItem GachaAccumulateTipsItem;

	// Token: 0x040064F7 RID: 25847
	private readonly Dictionary<GachaDefine.EGachaViewType, GachaPoolItem> GachaPoolItemMap = new Dictionary<GachaDefine.EGachaViewType, GachaPoolItem>();

	// Token: 0x040064F8 RID: 25848
	private readonly Dictionary<int, GachaPoolItem> SpineGachaPoolItemMap = new Dictionary<int, GachaPoolItem>();

	// Token: 0x040064F9 RID: 25849
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<GachaTagItem, GachaPoolData> GachaTagScrollView;

	// Token: 0x040064FA RID: 25850
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GachaPoolData[] TagDataList;

	// Token: 0x040064FB RID: 25851
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CommonTextItem, TableTextArgNew> TimesTextLayout;

	// Token: 0x040064FC RID: 25852
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<GachaSmallItemGrid, int> UpItemLayout;

	// Token: 0x040064FD RID: 25853
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040064FE RID: 25854
	[Nullable(2)]
	private GachaButton GachaBtn1;

	// Token: 0x040064FF RID: 25855
	[Nullable(2)]
	private GachaButton GachaBtn10;

	// Token: 0x04006500 RID: 25856
	[Nullable(2)]
	private ButtonItem SelectPoolButton;

	// Token: 0x04006501 RID: 25857
	[Nullable(2)]
	private GachaDiscountTagItem SelectBtnTagItemA;

	// Token: 0x04006502 RID: 25858
	[Nullable(2)]
	private GachaDiscountTagItem SelectBtnTagItemB;

	// Token: 0x04006503 RID: 25859
	private readonly List<GachaDiscountTimesItem> DiscountItems = new List<GachaDiscountTimesItem>();

	// Token: 0x04006504 RID: 25860
	[Nullable(2)]
	private GachaPoolItem CurPoolItem;

	// Token: 0x04006505 RID: 25861
	private bool IsViewFirstShow;

	// Token: 0x04006506 RID: 25862
	private double LastRefreshTime;

	// Token: 0x04006507 RID: 25863
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04006508 RID: 25864
	[Nullable(2)]
	private TimerHandle CountDownTimerHandle;

	// Token: 0x04006509 RID: 25865
	private readonly Queue<GachaMainView.OperationParam> GachaOperationQueue = new Queue<GachaMainView.OperationParam>(4);

	// Token: 0x0400650A RID: 25866
	private bool Operating;

	// Token: 0x02008243 RID: 33347
	[NullableContext(0)]
	private enum EOperationType
	{
		// Token: 0x0402A7FD RID: 174077
		RefreshGachaTag,
		// Token: 0x0402A7FE RID: 174078
		RefreshGachaInfo,
		// Token: 0x0402A7FF RID: 174079
		SelectGachaTagByIndex
	}

	// Token: 0x02008244 RID: 33348
	[NullableContext(2)]
	[Nullable(0)]
	private class OperationParam
	{
		// Token: 0x0604A2A3 RID: 303779 RVA: 0x0134700A File Offset: 0x0134520A
		public OperationParam(GachaMainView.EOperationType operationType, object param = null)
		{
			this.OperationType = operationType;
			this.Param = param;
		}

		// Token: 0x0402A800 RID: 174080
		public GachaMainView.EOperationType OperationType;

		// Token: 0x0402A801 RID: 174081
		public object Param;
	}

	// Token: 0x02008245 RID: 33349
	[NullableContext(0)]
	private enum EGachaMainCom
	{
		// Token: 0x0402A803 RID: 174083
		CaptionItem,
		// Token: 0x0402A804 RID: 174084
		ShopBtn,
		// Token: 0x0402A805 RID: 174085
		PreviewBtn,
		// Token: 0x0402A806 RID: 174086
		HelpBtn,
		// Token: 0x0402A807 RID: 174087
		RecordBtn,
		// Token: 0x0402A808 RID: 174088
		GachaBtnItem1,
		// Token: 0x0402A809 RID: 174089
		GachaBtnItem10,
		// Token: 0x0402A80A RID: 174090
		GachaPoolParentItem,
		// Token: 0x0402A80B RID: 174091
		GachaPoolScrollView,
		// Token: 0x0402A80C RID: 174092
		TypeText,
		// Token: 0x0402A80D RID: 174093
		TitleText,
		// Token: 0x0402A80E RID: 174094
		DateItem,
		// Token: 0x0402A80F RID: 174095
		DateText,
		// Token: 0x0402A810 RID: 174096
		DetailText,
		// Token: 0x0402A811 RID: 174097
		TimesTextLayout,
		// Token: 0x0402A812 RID: 174098
		UpItemRootItem,
		// Token: 0x0402A813 RID: 174099
		UpItemTipText,
		// Token: 0x0402A814 RID: 174100
		UpItemLayout,
		// Token: 0x0402A815 RID: 174101
		ChangeBtn,
		// Token: 0x0402A816 RID: 174102
		BgTexture,
		// Token: 0x0402A817 RID: 174103
		ThemeTextMaskTexture,
		// Token: 0x0402A818 RID: 174104
		RoleBgTexture,
		// Token: 0x0402A819 RID: 174105
		SelectTipsItem,
		// Token: 0x0402A81A RID: 174106
		SelectPoolButton,
		// Token: 0x0402A81B RID: 174107
		TxtTips,
		// Token: 0x0402A81C RID: 174108
		GuaranteedItem,
		// Token: 0x0402A81D RID: 174109
		GuaranteedNumText,
		// Token: 0x0402A81E RID: 174110
		GuaranteedText,
		// Token: 0x0402A81F RID: 174111
		GachaComplianceText,
		// Token: 0x0402A820 RID: 174112
		TextScroller,
		// Token: 0x0402A821 RID: 174113
		LayoutTurnAniController,
		// Token: 0x0402A822 RID: 174114
		GachaAccumulateTipsItem,
		// Token: 0x0402A823 RID: 174115
		DiscountList,
		// Token: 0x0402A824 RID: 174116
		DiscountTemplate,
		// Token: 0x0402A825 RID: 174117
		SelectBtnTagRoot
	}
}
