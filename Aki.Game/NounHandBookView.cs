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

// Token: 0x02001301 RID: 4865
[NullableContext(1)]
[Nullable(0)]
public class NounHandBookView : UiViewBase
{
	// Token: 0x0600BF72 RID: 49010 RVA: 0x0038878C File Offset: 0x0038698C
	public NounHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.NounHandBookItemList = new List<NounHandBookItem>();
	}

	// Token: 0x0600BF73 RID: 49011 RVA: 0x003887EC File Offset: 0x003869EC
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

	// Token: 0x0600BF74 RID: 49012 RVA: 0x00388A0C File Offset: 0x00386C0C
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

	// Token: 0x0600BF75 RID: 49013 RVA: 0x00388A98 File Offset: 0x00386C98
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600BF76 RID: 49014 RVA: 0x00388AA0 File Offset: 0x00386CA0
	protected void Refresh()
	{
		this.InitScrollView();
		this.RefreshCollectText();
	}

	// Token: 0x0600BF77 RID: 49015 RVA: 0x00388AB0 File Offset: 0x00386CB0
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

	// Token: 0x0600BF78 RID: 49016 RVA: 0x00388AEC File Offset: 0x00386CEC
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

	// Token: 0x0600BF79 RID: 49017 RVA: 0x00388B98 File Offset: 0x00386D98
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BF7A RID: 49018 RVA: 0x00388BFC File Offset: 0x00386DFC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BF7B RID: 49019 RVA: 0x00388C60 File Offset: 0x00386E60
	protected override UniTask OnBeforeStartAsync()
	{
		NounHandBookView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NounHandBookView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BF7C RID: 49020 RVA: 0x00388CA4 File Offset: 0x00386EA4
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

	// Token: 0x0600BF7D RID: 49021 RVA: 0x00388DA8 File Offset: 0x00386FA8
	private NounHandBookItem InitNounItem(object data, UUIItem uiItem, int index)
	{
		NounHandBookItem nounHandBookItem = new NounHandBookItem();
		nounHandBookItem.BindToggleCallback(new TNounToggleFunction(this.NounToggleFunction));
		nounHandBookItem.BindChildToggleCallback(new TChildNounToggleFunction(this.ChildNounToggleFunction));
		this.NounHandBookItemList.Add(nounHandBookItem);
		return nounHandBookItem;
	}

	// Token: 0x0600BF7E RID: 49022 RVA: 0x00388DEC File Offset: 0x00386FEC
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

	// Token: 0x0600BF7F RID: 49023 RVA: 0x00388E38 File Offset: 0x00387038
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

	// Token: 0x0600BF80 RID: 49024 RVA: 0x00389094 File Offset: 0x00387294
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("ChipHandBookLock");
		base.GetText(15).SetText(textById, true);
	}

	// Token: 0x0600BF81 RID: 49025 RVA: 0x003890C0 File Offset: 0x003872C0
	private int SortIndex(NounType a, NounType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600BF82 RID: 49026 RVA: 0x003890D4 File Offset: 0x003872D4
	protected void InitCommonTabTitle()
	{
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Noun);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(this.OnClickCloseButton);
		this.CaptionItem.SetTitleLocalText(handBookEntranceConfig.Value.Name);
		this.CaptionItem.SetTitleIcon(handBookEntranceConfig.Value.TitleIcon);
	}

	// Token: 0x0600BF83 RID: 49027 RVA: 0x00389148 File Offset: 0x00387348
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Noun);
		LguiUtil.Instance.SetLocalText(base.GetText(1), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600BF84 RID: 49028 RVA: 0x00389199 File Offset: 0x00387399
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

	// Token: 0x0600BF85 RID: 49029 RVA: 0x003891D8 File Offset: 0x003873D8
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

	// Token: 0x04006E17 RID: 28183
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<NounHandBookItem, HandBootNounDynamicItem, HandBookNounDynamicData> ContentGenericLayout;

	// Token: 0x04006E18 RID: 28184
	[Nullable(2)]
	private HandBootNounDynamicItem HandBootNounDynamicItem;

	// Token: 0x04006E19 RID: 28185
	private int CurrentSelectNoun = -1;

	// Token: 0x04006E1A RID: 28186
	private int ScrollToIndex = -1;

	// Token: 0x04006E1B RID: 28187
	protected List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006E1C RID: 28188
	private NounHandBook? CurSelectConfig;

	// Token: 0x04006E1D RID: 28189
	private List<NounHandBookItem> NounHandBookItemList;

	// Token: 0x04006E1E RID: 28190
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006E1F RID: 28191
	[Nullable(2)]
	private UUIExtendToggle CurrentToggle;

	// Token: 0x04006E20 RID: 28192
	private readonly Action OnClickCloseButton = delegate()
	{
		UiManager.Instance.CloseView(EUiViewName.NounHandBookView, null);
	};

	// Token: 0x02007574 RID: 30068
	[NullableContext(0)]
	private class ENounHandBookViewDefine
	{
		// Token: 0x0402624C RID: 156236
		public const int TitleItem = 0;

		// Token: 0x0402624D RID: 156237
		public const int CollectCountText = 1;

		// Token: 0x0402624E RID: 156238
		public const int Layout = 2;

		// Token: 0x0402624F RID: 156239
		public const int NounItem = 3;

		// Token: 0x04026250 RID: 156240
		public const int NameText = 4;

		// Token: 0x04026251 RID: 156241
		public const int TypeText = 5;

		// Token: 0x04026252 RID: 156242
		public const int DateText = 6;

		// Token: 0x04026253 RID: 156243
		public const int Texture = 7;

		// Token: 0x04026254 RID: 156244
		public const int ProgressText = 8;

		// Token: 0x04026255 RID: 156245
		public const int DescriptionText = 9;

		// Token: 0x04026256 RID: 156246
		public const int VoiceProgressText = 10;

		// Token: 0x04026257 RID: 156247
		public const int VoiceText = 11;

		// Token: 0x04026258 RID: 156248
		public const int StopButton = 12;

		// Token: 0x04026259 RID: 156249
		public const int PlayButton = 13;

		// Token: 0x0402625A RID: 156250
		public const int TextureButton = 14;

		// Token: 0x0402625B RID: 156251
		public const int LockText = 15;

		// Token: 0x0402625C RID: 156252
		public const int SoundItem = 16;

		// Token: 0x0402625D RID: 156253
		public const int PhotoItem = 17;

		// Token: 0x0402625E RID: 156254
		public const int WordItem = 18;

		// Token: 0x0402625F RID: 156255
		public const int NounTitleItem = 19;

		// Token: 0x04026260 RID: 156256
		public const int BigWordItem = 20;

		// Token: 0x04026261 RID: 156257
		public const int BigWordText = 21;

		// Token: 0x04026262 RID: 156258
		public const int UnlockItem = 22;
	}
}
