using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DD9 RID: 7641
[NullableContext(1)]
[Nullable(0)]
public class ChipHandBookView : UiViewBase
{
	// Token: 0x0600E887 RID: 59527 RVA: 0x00370528 File Offset: 0x0036E728
	public ChipHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.ChipHandBookItemList = new List<ChipHandBookItem>();
	}

	// Token: 0x0600E888 RID: 59528 RVA: 0x00370598 File Offset: 0x0036E798
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickStopButton)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnClickPlayButton)),
			new ValueTuple<int, Delegate>(14, new Action(this.OnClickTextureButton))
		};
	}

	// Token: 0x0600E889 RID: 59529 RVA: 0x0037080E File Offset: 0x0036EA0E
	protected override void OnStart()
	{
		this.InitCommonTabTitle();
		this.Refresh();
		this.RefreshLockText();
		this.VoiceProgressText = base.GetText(10);
	}

	// Token: 0x0600E88A RID: 59530 RVA: 0x00370830 File Offset: 0x0036EA30
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600E88B RID: 59531 RVA: 0x00370838 File Offset: 0x0036EA38
	protected void Refresh()
	{
		this.InitScrollView();
		this.RefreshCollectText();
	}

	// Token: 0x0600E88C RID: 59532 RVA: 0x00370848 File Offset: 0x0036EA48
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Chip)
		{
			return;
		}
		int count = this.ChipHandBookItemList.Count;
		for (int i = 0; i < count; i++)
		{
			this.ChipHandBookItemList[i].RefreshNewState();
		}
	}

	// Token: 0x0600E88D RID: 59533 RVA: 0x00370884 File Offset: 0x0036EA84
	protected void RefreshLockState(bool isLock)
	{
		base.GetText(4).SetUIActive(!isLock);
		base.GetText(5).SetUIActive(!isLock);
		base.GetText(6).SetUIActive(!isLock);
		base.GetTexture(7).SetUIActive(!isLock);
		base.GetText(8).SetUIActive(!isLock);
		base.GetText(9).SetUIActive(!isLock);
		base.GetText(10).SetUIActive(!isLock);
		base.GetText(11).SetUIActive(!isLock);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
		base.GetButton(13).RootUIComp.Get().SetUIActive(!isLock);
		base.GetButton(14).RootUIComp.Get().SetUIActive(!isLock);
		base.GetText(15).SetUIActive(isLock);
		base.GetItem(22).SetUIActive(isLock);
		base.GetItem(19).SetUIActive(!isLock);
		base.GetItem(20).SetUIActive(!isLock);
	}

	// Token: 0x0600E88E RID: 59534 RVA: 0x003709AC File Offset: 0x0036EBAC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600E88F RID: 59535 RVA: 0x00370A10 File Offset: 0x0036EC10
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600E890 RID: 59536 RVA: 0x00370A74 File Offset: 0x0036EC74
	protected override UniTask OnBeforeStartAsync()
	{
		ChipHandBookView.<OnBeforeStartAsync>d__29 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ChipHandBookView.<OnBeforeStartAsync>d__29>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E891 RID: 59537 RVA: 0x00370AB8 File Offset: 0x0036ECB8
	public void InitScrollView()
	{
		List<ChipType> list = ConfigCommon.ToList<ChipType>(HandBookConfig.Instance.GetChipTypeConfigList());
		list.Sort(new Comparison<ChipType>(this.SortIndex));
		int count = list.Count;
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		for (int i = 0; i < count; i++)
		{
			ChipType chipType = list[i];
			HandBookCommonItemData handBookCommonItemData = new HandBookCommonItemData();
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Chip, chipType.Id);
			bool isLock = handBookInfo == null;
			bool isNew = handBookInfo != null && !handBookInfo.IsRead;
			handBookCommonItemData.Icon = chipType.Icon;
			handBookCommonItemData.Title = ConfigMultiTextLang.GetLocalTextNew(chipType.TypeDescription, null);
			handBookCommonItemData.Config = chipType;
			handBookCommonItemData.IsLock = isLock;
			handBookCommonItemData.IsNew = isNew;
			this.HandBookCommonItemDataList.Add(handBookCommonItemData);
		}
		HandBookChipDynamicData[] data = this.BuildContentData();
		DynamicScrollView<ChipHandBookItem, HandBootChipDynamicItem, HandBookChipDynamicData> contentGenericLayout = this.ContentGenericLayout;
		if (contentGenericLayout == null)
		{
			return;
		}
		contentGenericLayout.RefreshByData(data, false, false);
	}

	// Token: 0x0600E892 RID: 59538 RVA: 0x00370BB4 File Offset: 0x0036EDB4
	private ChipHandBookItem InitChipItem(object data, UUIItem uiItem, int index)
	{
		ChipHandBookItem chipHandBookItem = new ChipHandBookItem();
		chipHandBookItem.BindToggleCallback(new TChipToggleFunction(this.ChipToggleFunction));
		chipHandBookItem.BindChildToggleCallback(new TChildChipToggleFunction(this.ChildChipToggleFunction));
		this.ChipHandBookItemList.Add(chipHandBookItem);
		return chipHandBookItem;
	}

	// Token: 0x0600E893 RID: 59539 RVA: 0x00370BF8 File Offset: 0x0036EDF8
	private void ChipToggleFunction(int selectId)
	{
		this.CurrentSelectChip = selectId;
		HandBookChipDynamicData[] data = this.BuildContentData();
		DynamicScrollView<ChipHandBookItem, HandBootChipDynamicItem, HandBookChipDynamicData> contentGenericLayout = this.ContentGenericLayout;
		if (contentGenericLayout != null)
		{
			contentGenericLayout.RefreshByData(data, true, false);
		}
		DynamicScrollView<ChipHandBookItem, HandBootChipDynamicItem, HandBookChipDynamicData> contentGenericLayout2 = this.ContentGenericLayout;
		if (contentGenericLayout2 == null)
		{
			return;
		}
		contentGenericLayout2.BindLateUpdate(delegate(float _)
		{
			DynamicScrollView<ChipHandBookItem, HandBootChipDynamicItem, HandBookChipDynamicData> contentGenericLayout3 = this.ContentGenericLayout;
			if (contentGenericLayout3 != null)
			{
				contentGenericLayout3.ScrollToItemIndex(this.ScrollToIndex, true, false).Forget();
			}
			DynamicScrollView<ChipHandBookItem, HandBootChipDynamicItem, HandBookChipDynamicData> contentGenericLayout4 = this.ContentGenericLayout;
			if (contentGenericLayout4 == null)
			{
				return;
			}
			contentGenericLayout4.UnBindLateUpdate();
		});
	}

	// Token: 0x0600E894 RID: 59540 RVA: 0x00370C44 File Offset: 0x0036EE44
	private void ChildChipToggleFunction(ChipHandBook chipHandBook, UUIExtendToggle toggle)
	{
		this.CurSelectConfig = new ChipHandBook?(chipHandBook);
		UUIExtendToggle currentToggle = this.CurrentToggle;
		if (currentToggle != null)
		{
			currentToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentToggle = toggle;
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Chip, this.CurSelectConfig.Value.Id);
		bool flag = handBookInfo == null;
		if (flag)
		{
			this.RefreshLockState(flag);
			return;
		}
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(this.CurSelectConfig.Value.Id);
		base.GetText(4).SetText(infoDisplayTitle, true);
		ChipType? chipTypeConfig = HandBookConfig.Instance.GetChipTypeConfig(chipHandBook.Type);
		base.GetText(5).ShowTextNew(chipTypeConfig.Value.TypeDescription);
		string[] infoDisplayPictures = InfoDisplayModuleConfig.Instance.GetInfoDisplayPictures(this.CurSelectConfig.Value.Id);
		bool flag2 = infoDisplayPictures.Length != 0;
		UUIItem item = base.GetItem(17);
		if (flag2)
		{
			item.SetUIActive(true);
			base.SetTextureByPath(infoDisplayPictures[0], base.GetTexture(7), null, null);
		}
		else
		{
			item.SetUIActive(false);
		}
		int num = 1;
		int num2 = infoDisplayPictures.Length;
		LguiUtil.Instance.SetLocalText(base.GetText(8), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			num2
		}));
		bool uiactive = InfoDisplayModuleConfig.Instance.GetInfoDisplayAudio(this.CurSelectConfig.Value.Id).Length > 0;
		base.GetItem(16).SetUIActive(uiactive);
		base.GetText(11).ShowTextNew(chipHandBook.VoiceDescrtption);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
		base.GetButton(13).RootUIComp.Get().SetUIActive(true);
		string infoDisplayDesc = InfoDisplayModuleConfig.Instance.GetInfoDisplayDesc(this.CurSelectConfig.Value.Id);
		bool uiactive2 = infoDisplayDesc != null && infoDisplayDesc.Length > 0;
		base.GetItem(20).SetUIActive(uiactive2);
		base.GetText(21).SetText(infoDisplayDesc, true);
		base.GetItem(18).SetUIActive(false);
		if (handBookInfo != null && !handBookInfo.IsRead)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Chip, this.CurSelectConfig.Value.Id);
		}
		LguiUtil.Instance.SetLocalText(base.GetText(6), "DateOfAcquisition", new <>z__ReadOnlySingleElementList<object>(flag ? "" : handBookInfo.CreateTime));
	}

	// Token: 0x0600E895 RID: 59541 RVA: 0x00370EE0 File Offset: 0x0036F0E0
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("ChipHandBookLock");
		base.GetText(15).SetText(textById, true);
	}

	// Token: 0x0600E896 RID: 59542 RVA: 0x00370F0C File Offset: 0x0036F10C
	private int SortIndex(ChipType a, ChipType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600E897 RID: 59543 RVA: 0x00370F20 File Offset: 0x0036F120
	protected void InitCommonTabTitle()
	{
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Chip);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseButton));
		this.CaptionItem.SetTitleLocalText(handBookEntranceConfig.Value.Name);
		this.CaptionItem.SetTitleIcon(handBookEntranceConfig.Value.TitleIcon);
	}

	// Token: 0x0600E898 RID: 59544 RVA: 0x00370F96 File Offset: 0x0036F196
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ChipHandBookView, null);
	}

	// Token: 0x0600E899 RID: 59545 RVA: 0x00370FA8 File Offset: 0x0036F1A8
	private void OnClickPlayButton()
	{
		base.GetButton(12).RootUIComp.Get().SetUIActive(true);
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
		if (this.AudioDelegate == null)
		{
			this.AudioDelegate = DelegateUtils.ToManualReleaseDelegate<FOnAkPostEventCallback>(new Action<EAkCallbackType, UAkCallbackInfo>(this.CallBackDuration));
		}
		string infoDisplayAudio = InfoDisplayModuleConfig.Instance.GetInfoDisplayAudio(this.CurSelectConfig.Value.Id);
		AudioController.Instance.PostEventByUi(infoDisplayAudio, this.AudioResult, new int?(this.PlayFlag), this.AudioDelegate);
	}

	// Token: 0x0600E89A RID: 59546 RVA: 0x0037104C File Offset: 0x0036F24C
	private void OnClickStopButton()
	{
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
		base.GetButton(13).RootUIComp.Get().SetUIActive(true);
		if (this.CurSelectConfig == null)
		{
			return;
		}
		this.ClearTimerId();
		this.CurTime = 0f;
		AudioController.Instance.StopEvent(this.AudioResult, true, null);
		this.VoiceProgressText.SetText("", true);
	}

	// Token: 0x0600E89B RID: 59547 RVA: 0x003710D9 File Offset: 0x0036F2D9
	private void ClearTimerId()
	{
		if (this.TimerId != null && this.TimerId.Valid())
		{
			this.TimerId.Remove();
		}
		this.TimerId = null;
	}

	// Token: 0x0600E89C RID: 59548 RVA: 0x00371104 File Offset: 0x0036F304
	private void OnClickTextureButton()
	{
		string[] infoDisplayPictures = InfoDisplayModuleConfig.Instance.GetInfoDisplayPictures(this.CurSelectConfig.Value.Id);
		int type = this.CurSelectConfig.Value.Type;
		ChipType? chipTypeConfig = HandBookConfig.Instance.GetChipTypeConfig(type);
		HandBookPhotoData handBookPhotoData = new HandBookPhotoData();
		string infoDisplayDesc = InfoDisplayModuleConfig.Instance.GetInfoDisplayDesc(this.CurSelectConfig.Value.Id);
		List<string> list = new List<string>();
		list.Add(infoDisplayDesc);
		List<string> list2 = new List<string>();
		list2.Add(ConfigMultiTextLang.GetLocalTextNew(chipTypeConfig.Value.TypeDescription, null));
		List<string> list3 = new List<string>();
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(this.CurSelectConfig.Value.Id);
		list3.Add(infoDisplayTitle);
		handBookPhotoData.DescrtptionText = list;
		handBookPhotoData.TypeText = list2;
		handBookPhotoData.NameText = list3;
		handBookPhotoData.HandBookType = EHandBookTabType.Chip;
		handBookPhotoData.Index = 0;
		handBookPhotoData.TextureList = infoDisplayPictures.ToList<string>();
		UiManager.Instance.OpenView(EUiViewName.HandBookPhotoView, handBookPhotoData, null);
	}

	// Token: 0x0600E89D RID: 59549 RVA: 0x00371220 File Offset: 0x0036F420
	[NullableContext(2)]
	private void CallBackDuration(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
	{
		if (callbackType == EAkCallbackType.Duration)
		{
			UAkDurationCallbackInfo uakDurationCallbackInfo = callbackInfo as UAkDurationCallbackInfo;
			this.TotalTime = (float)Math.Ceiling((double)(uakDurationCallbackInfo.Duration / (float)this.ChangeNum));
			this.TimerId = TimerSystem.Instance.Loop(delegate(float _)
			{
				this.CurTime += 1f;
				if (this.CurTime > this.TotalTime)
				{
					this.OnClickStopButton();
					return;
				}
				int curSecond = (int)(this.CurTime % (float)this.TimeHex);
				int curMinute = (int)Math.Floor((double)(this.CurTime / (float)this.TimeHex));
				int totalSecond = (int)(this.TotalTime % (float)this.TimeHex);
				int totalMinute = (int)Math.Floor((double)(this.TotalTime / (float)this.TimeHex));
				this.SetVoiceProgress(curSecond, curMinute, totalSecond, totalMinute);
			}, this.Interval, (int)(this.TotalTime + 1f), 1f, null, null, true);
		}
	}

	// Token: 0x0600E89E RID: 59550 RVA: 0x0037128C File Offset: 0x0036F48C
	protected void SetVoiceProgress(int curSecond, int curMinute, int totalSecond, int totalMinute)
	{
		LguiUtil.Instance.SetLocalText(this.VoiceProgressText, "VoiceProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.TimeFormat((float)curMinute),
			this.TimeFormat((float)curSecond),
			this.TimeFormat((float)totalMinute),
			this.TimeFormat((float)totalSecond)
		}));
	}

	// Token: 0x0600E89F RID: 59551 RVA: 0x003712E6 File Offset: 0x0036F4E6
	protected string TimeFormat(float time)
	{
		if (time >= (float)this.TimeMin)
		{
			return time.ToString();
		}
		return "0" + time.ToString();
	}

	// Token: 0x0600E8A0 RID: 59552 RVA: 0x0037130C File Offset: 0x0036F50C
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Chip);
		LguiUtil.Instance.SetLocalText(base.GetText(1), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600E8A1 RID: 59553 RVA: 0x0037135C File Offset: 0x0036F55C
	protected override void OnBeforeDestroy()
	{
		if (this.ContentGenericLayout != null)
		{
			this.ContentGenericLayout.ClearChildren();
			this.ContentGenericLayout = null;
		}
		if (this.AudioDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EAkCallbackType, UAkCallbackInfo>(this.CallBackDuration));
			this.AudioDelegate = null;
		}
		AudioController.Instance.StopEvent(this.AudioResult, true, null);
		this.CurTime = 0f;
		this.TotalTime = 0f;
		this.VoiceProgressText = null;
		this.ChipHandBookItemList = new List<ChipHandBookItem>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.CurSelectConfig = null;
	}

	// Token: 0x0600E8A2 RID: 59554 RVA: 0x003713FC File Offset: 0x0036F5FC
	private HandBookChipDynamicData[] BuildContentData()
	{
		if (this.CurrentSelectChip == -1)
		{
			this.CurrentSelectChip = ((ChipHandBook)this.HandBookCommonItemDataList[0].Config).Id;
		}
		List<HandBookChipDynamicData> list = new List<HandBookChipDynamicData>();
		foreach (HandBookCommonItemData handBookCommonItemData in this.HandBookCommonItemDataList)
		{
			bool flag = this.CurrentSelectChip == ((ChipHandBook)handBookCommonItemData.Config).Id;
			list.Add(new HandBookChipDynamicData
			{
				HandBookCommonItemData = handBookCommonItemData,
				IsShowContent = flag
			});
			if (flag)
			{
				this.ScrollToIndex = this.HandBookCommonItemDataList.IndexOf(handBookCommonItemData);
				IEnumerable<ChipHandBook> chipHandBookConfigList = HandBookConfig.Instance.GetChipHandBookConfigList(((ChipHandBook)handBookCommonItemData.Config).Id);
				bool isShowContent = true;
				foreach (ChipHandBook chipHandBook in chipHandBookConfigList)
				{
					list.Add(new HandBookChipDynamicData
					{
						HandBookChipConfigId = new int?(chipHandBook.Id),
						IsShowContent = isShowContent
					});
					isShowContent = false;
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x04006BAA RID: 27562
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ChipHandBookItem, HandBootChipDynamicItem, HandBookChipDynamicData> ContentGenericLayout;

	// Token: 0x04006BAB RID: 27563
	[Nullable(2)]
	private HandBootChipDynamicItem HandBootChipDynamicItem;

	// Token: 0x04006BAC RID: 27564
	private int CurrentSelectChip = -1;

	// Token: 0x04006BAD RID: 27565
	private int ScrollToIndex = -1;

	// Token: 0x04006BAE RID: 27566
	protected List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006BAF RID: 27567
	private ChipHandBook? CurSelectConfig;

	// Token: 0x04006BB0 RID: 27568
	private readonly PlayResult AudioResult = new PlayResult();

	// Token: 0x04006BB1 RID: 27569
	private readonly int PlayFlag = 8;

	// Token: 0x04006BB2 RID: 27570
	[Nullable(2)]
	private FOnAkPostEventCallback AudioDelegate;

	// Token: 0x04006BB3 RID: 27571
	private readonly int ChangeNum = 1000;

	// Token: 0x04006BB4 RID: 27572
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x04006BB5 RID: 27573
	private float CurTime;

	// Token: 0x04006BB6 RID: 27574
	private float TotalTime;

	// Token: 0x04006BB7 RID: 27575
	private readonly float Interval = 1000f;

	// Token: 0x04006BB8 RID: 27576
	[Nullable(2)]
	private UUIText VoiceProgressText;

	// Token: 0x04006BB9 RID: 27577
	private List<ChipHandBookItem> ChipHandBookItemList;

	// Token: 0x04006BBA RID: 27578
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006BBB RID: 27579
	private readonly int TimeHex = 60;

	// Token: 0x04006BBC RID: 27580
	private readonly int TimeMin = 10;

	// Token: 0x04006BBD RID: 27581
	[Nullable(2)]
	private UUIExtendToggle CurrentToggle;
}
