using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E3F RID: 7743
[NullableContext(1)]
[Nullable(0)]
public class NounHandBookView : UiViewBase
{
	// Token: 0x0600EB53 RID: 60243 RVA: 0x0037CAEC File Offset: 0x0037ACEC
	public NounHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.NounHandBookItemList = new List<NounHandBookItem>();
	}

	// Token: 0x0600EB54 RID: 60244 RVA: 0x0037CB4C File Offset: 0x0037AD4C
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
	}

	// Token: 0x0600EB55 RID: 60245 RVA: 0x0037CD6C File Offset: 0x0037AF6C
	protected override void OnStart()
	{
		base.GetText(11).SetUIActive(false);
		base.GetText(10).SetUIActive(false);
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
		base.GetButton(14).RootUIComp.Get().SetUIActive(false);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
		this.InitCommonTabTitle();
		this.Refresh();
		this.RefreshLockText();
	}

	// Token: 0x0600EB56 RID: 60246 RVA: 0x0037CDF8 File Offset: 0x0037AFF8
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600EB57 RID: 60247 RVA: 0x0037CE00 File Offset: 0x0037B000
	protected void Refresh()
	{
		this.InitScrollView();
		this.RefreshCollectText();
	}

	// Token: 0x0600EB58 RID: 60248 RVA: 0x0037CE10 File Offset: 0x0037B010
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Noun)
		{
			return;
		}
		int count = this.NounHandBookItemList.Count;
		for (int i = 0; i < count; i++)
		{
			this.NounHandBookItemList[i].RefreshNewState();
		}
	}

	// Token: 0x0600EB59 RID: 60249 RVA: 0x0037CE4C File Offset: 0x0037B04C
	protected void RefreshLockState(bool isLock)
	{
		base.GetText(4).SetUIActive(!isLock);
		base.GetText(5).SetUIActive(!isLock);
		base.GetText(6).SetUIActive(!isLock);
		base.GetTexture(7).SetUIActive(!isLock);
		base.GetText(8).SetUIActive(!isLock);
		base.GetText(9).SetUIActive(!isLock);
		base.GetText(15).SetUIActive(isLock);
		base.GetItem(22).SetUIActive(isLock);
		base.GetItem(19).SetUIActive(!isLock);
		base.GetItem(20).SetUIActive(!isLock);
	}

	// Token: 0x0600EB5A RID: 60250 RVA: 0x0037CEF8 File Offset: 0x0037B0F8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EB5B RID: 60251 RVA: 0x0037CF5C File Offset: 0x0037B15C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EB5C RID: 60252 RVA: 0x0037CFC0 File Offset: 0x0037B1C0
	protected override UniTask OnBeforeStartAsync()
	{
		NounHandBookView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NounHandBookView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EB5D RID: 60253 RVA: 0x0037D004 File Offset: 0x0037B204
	public void InitScrollView()
	{
		List<NounType> list = ConfigCommon.ToList<NounType>(HandBookConfig.Instance.GetNounTypeConfigList());
		list.Sort(new Comparison<NounType>(this.SortIndex));
		int count = list.Count;
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		for (int i = 0; i < count; i++)
		{
			NounType nounType = list[i];
			HandBookCommonItemData handBookCommonItemData = new HandBookCommonItemData();
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Noun, nounType.Id);
			bool isLock = handBookInfo == null;
			bool isNew = handBookInfo != null && !handBookInfo.IsRead;
			handBookCommonItemData.Icon = nounType.Icon;
			handBookCommonItemData.Title = (ConfigMultiTextLang.GetLocalTextNew(nounType.TypeDescription, null) ?? "");
			handBookCommonItemData.Config = nounType;
			handBookCommonItemData.IsLock = isLock;
			handBookCommonItemData.IsNew = isNew;
			this.HandBookCommonItemDataList.Add(handBookCommonItemData);
		}
		HandBookNounDynamicData[] data = this.BuildContentData();
		DynamicScrollView<NounHandBookItem, HandBootNounDynamicItem, HandBookNounDynamicData> contentGenericLayout = this.ContentGenericLayout;
		if (contentGenericLayout == null)
		{
			return;
		}
		contentGenericLayout.RefreshByData(data, false, false);
	}

	// Token: 0x0600EB5E RID: 60254 RVA: 0x0037D108 File Offset: 0x0037B308
	private NounHandBookItem InitNounItem(object data, UUIItem uiItem, int index)
	{
		NounHandBookItem nounHandBookItem = new NounHandBookItem();
		nounHandBookItem.BindToggleCallback(new TNounToggleFunction(this.NounToggleFunction));
		nounHandBookItem.BindChildToggleCallback(new TChildNounToggleFunction(this.ChildNounToggleFunction));
		this.NounHandBookItemList.Add(nounHandBookItem);
		return nounHandBookItem;
	}

	// Token: 0x0600EB5F RID: 60255 RVA: 0x0037D14C File Offset: 0x0037B34C
	private void NounToggleFunction(int selectId)
	{
		this.CurrentSelectNoun = selectId;
		HandBookNounDynamicData[] data = this.BuildContentData();
		DynamicScrollView<NounHandBookItem, HandBootNounDynamicItem, HandBookNounDynamicData> contentGenericLayout = this.ContentGenericLayout;
		if (contentGenericLayout != null)
		{
			contentGenericLayout.RefreshByData(data, true, false);
		}
		DynamicScrollView<NounHandBookItem, HandBootNounDynamicItem, HandBookNounDynamicData> contentGenericLayout2 = this.ContentGenericLayout;
		if (contentGenericLayout2 == null)
		{
			return;
		}
		contentGenericLayout2.BindLateUpdate(delegate(float _)
		{
			DynamicScrollView<NounHandBookItem, HandBootNounDynamicItem, HandBookNounDynamicData> contentGenericLayout3 = this.ContentGenericLayout;
			if (contentGenericLayout3 != null)
			{
				contentGenericLayout3.ScrollToItemIndex(this.ScrollToIndex, true, false);
			}
			DynamicScrollView<NounHandBookItem, HandBootNounDynamicItem, HandBookNounDynamicData> contentGenericLayout4 = this.ContentGenericLayout;
			if (contentGenericLayout4 == null)
			{
				return;
			}
			contentGenericLayout4.UnBindLateUpdate();
		});
	}

	// Token: 0x0600EB60 RID: 60256 RVA: 0x0037D198 File Offset: 0x0037B398
	private void ChildNounToggleFunction(NounHandBook nounHandBook, UUIExtendToggle toggle)
	{
		this.CurSelectConfig = new NounHandBook?(nounHandBook);
		if (this.CurrentToggle != toggle)
		{
			UUIExtendToggle currentToggle = this.CurrentToggle;
			if (currentToggle != null)
			{
				currentToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentToggle = toggle;
		}
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Noun, this.CurSelectConfig.Value.Id);
		bool flag = handBookInfo == null;
		this.RefreshLockState(flag);
		if (flag)
		{
			return;
		}
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(this.CurSelectConfig.Value.Id);
		base.GetText(4).SetText(infoDisplayTitle, true);
		NounType? nounTypeConfig = HandBookConfig.Instance.GetNounTypeConfig(nounHandBook.Type);
		base.GetText(5).ShowTextNew(nounTypeConfig.Value.TypeDescription);
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
		string infoDisplayDesc = InfoDisplayModuleConfig.Instance.GetInfoDisplayDesc(this.CurSelectConfig.Value.Id);
		bool uiactive2 = infoDisplayDesc != null && infoDisplayDesc.Length > 0;
		base.GetItem(20).SetUIActive(uiactive2);
		base.GetText(21).SetText(infoDisplayDesc, true);
		base.GetItem(18).SetUIActive(false);
		if (handBookInfo != null && !handBookInfo.IsRead)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Noun, this.CurSelectConfig.Value.Id);
		}
		LguiUtil.Instance.SetLocalText(base.GetText(6), "DateOfAcquisition", new <>z__ReadOnlySingleElementList<object>(flag ? "" : handBookInfo.CreateTime));
	}

	// Token: 0x0600EB61 RID: 60257 RVA: 0x0037D3F4 File Offset: 0x0037B5F4
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("ChipHandBookLock");
		base.GetText(15).SetText(textById, true);
	}

	// Token: 0x0600EB62 RID: 60258 RVA: 0x0037D420 File Offset: 0x0037B620
	private int SortIndex(NounType a, NounType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600EB63 RID: 60259 RVA: 0x0037D434 File Offset: 0x0037B634
	protected void InitCommonTabTitle()
	{
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Noun);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(this.OnClickCloseButton);
		this.CaptionItem.SetTitleLocalText(handBookEntranceConfig.Value.Name);
		this.CaptionItem.SetTitleIcon(handBookEntranceConfig.Value.TitleIcon);
	}

	// Token: 0x0600EB64 RID: 60260 RVA: 0x0037D4A8 File Offset: 0x0037B6A8
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Noun);
		LguiUtil.Instance.SetLocalText(base.GetText(1), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600EB65 RID: 60261 RVA: 0x0037D4F9 File Offset: 0x0037B6F9
	protected override void OnBeforeDestroy()
	{
		if (this.ContentGenericLayout != null)
		{
			this.ContentGenericLayout.ClearChildren();
			this.ContentGenericLayout = null;
		}
		this.NounHandBookItemList = new List<NounHandBookItem>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.CurSelectConfig = null;
	}

	// Token: 0x0600EB66 RID: 60262 RVA: 0x0037D538 File Offset: 0x0037B738
	private HandBookNounDynamicData[] BuildContentData()
	{
		if (this.CurrentSelectNoun == -1)
		{
			this.CurrentSelectNoun = ((NounType)this.HandBookCommonItemDataList[0].Config).Id;
		}
		List<HandBookNounDynamicData> list = new List<HandBookNounDynamicData>();
		foreach (HandBookCommonItemData handBookCommonItemData in this.HandBookCommonItemDataList)
		{
			NounType nounType = (NounType)handBookCommonItemData.Config;
			bool flag = this.CurrentSelectNoun == nounType.Id;
			list.Add(new HandBookNounDynamicData
			{
				HandBookCommonItemData = handBookCommonItemData,
				IsShowContent = flag
			});
			if (flag)
			{
				this.ScrollToIndex = this.HandBookCommonItemDataList.IndexOf(handBookCommonItemData);
				IEnumerable<NounHandBook> nounHandBookConfigList = HandBookConfig.Instance.GetNounHandBookConfigList(nounType.Id);
				bool isShowContent = true;
				foreach (NounHandBook nounHandBook in nounHandBookConfigList)
				{
					list.Add(new HandBookNounDynamicData
					{
						HandBookNounConfigId = new int?(nounHandBook.Id),
						IsShowContent = isShowContent
					});
					isShowContent = false;
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x04006D36 RID: 27958
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<NounHandBookItem, HandBootNounDynamicItem, HandBookNounDynamicData> ContentGenericLayout;

	// Token: 0x04006D37 RID: 27959
	[Nullable(2)]
	private HandBootNounDynamicItem HandBootNounDynamicItem;

	// Token: 0x04006D38 RID: 27960
	private int CurrentSelectNoun = -1;

	// Token: 0x04006D39 RID: 27961
	private int ScrollToIndex = -1;

	// Token: 0x04006D3A RID: 27962
	protected List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006D3B RID: 27963
	private NounHandBook? CurSelectConfig;

	// Token: 0x04006D3C RID: 27964
	private List<NounHandBookItem> NounHandBookItemList;

	// Token: 0x04006D3D RID: 27965
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006D3E RID: 27966
	[Nullable(2)]
	private UUIExtendToggle CurrentToggle;

	// Token: 0x04006D3F RID: 27967
	private readonly Action OnClickCloseButton = delegate()
	{
		UiManager.Instance.CloseView(EUiViewName.NounHandBookView, null);
	};

	// Token: 0x020083EF RID: 33775
	[NullableContext(0)]
	private class ENounHandBookViewDefine
	{
		// Token: 0x0402AF28 RID: 175912
		public const int TitleItem = 0;

		// Token: 0x0402AF29 RID: 175913
		public const int CollectCountText = 1;

		// Token: 0x0402AF2A RID: 175914
		public const int Layout = 2;

		// Token: 0x0402AF2B RID: 175915
		public const int NounItem = 3;

		// Token: 0x0402AF2C RID: 175916
		public const int NameText = 4;

		// Token: 0x0402AF2D RID: 175917
		public const int TypeText = 5;

		// Token: 0x0402AF2E RID: 175918
		public const int DateText = 6;

		// Token: 0x0402AF2F RID: 175919
		public const int Texture = 7;

		// Token: 0x0402AF30 RID: 175920
		public const int ProgressText = 8;

		// Token: 0x0402AF31 RID: 175921
		public const int DescriptionText = 9;

		// Token: 0x0402AF32 RID: 175922
		public const int VoiceProgressText = 10;

		// Token: 0x0402AF33 RID: 175923
		public const int VoiceText = 11;

		// Token: 0x0402AF34 RID: 175924
		public const int StopButton = 12;

		// Token: 0x0402AF35 RID: 175925
		public const int PlayButton = 13;

		// Token: 0x0402AF36 RID: 175926
		public const int TextureButton = 14;

		// Token: 0x0402AF37 RID: 175927
		public const int LockText = 15;

		// Token: 0x0402AF38 RID: 175928
		public const int SoundItem = 16;

		// Token: 0x0402AF39 RID: 175929
		public const int PhotoItem = 17;

		// Token: 0x0402AF3A RID: 175930
		public const int WordItem = 18;

		// Token: 0x0402AF3B RID: 175931
		public const int NounTitleItem = 19;

		// Token: 0x0402AF3C RID: 175932
		public const int BigWordItem = 20;

		// Token: 0x0402AF3D RID: 175933
		public const int BigWordText = 21;

		// Token: 0x0402AF3E RID: 175934
		public const int UnlockItem = 22;
	}
}
