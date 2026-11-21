using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A03 RID: 6659
[NullableContext(1)]
[Nullable(0)]
public class PhoneMsgSettingView : UiViewBase
{
	// Token: 0x06010655 RID: 67157 RVA: 0x004CA1B8 File Offset: 0x004C83B8
	public PhoneMsgSettingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010656 RID: 67158 RVA: 0x004CA214 File Offset: 0x004C8414
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIMultiTemplateScrollViewComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUITexture)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUITexture)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(21, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUITexture)),
			new ValueTuple<int, Type>(27, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickDialogTab)),
			new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnClickBgTab)),
			new ValueTuple<int, Delegate>(20, new Action<EToggleState>(this.OnClickThemeTab)),
			new ValueTuple<int, Delegate>(21, new Action<EToggleState>(this.OnClickCharmTab))
		};
	}

	// Token: 0x06010657 RID: 67159 RVA: 0x004CA514 File Offset: 0x004C8714
	protected override UniTask OnBeforeStartAsync()
	{
		PhoneMsgSettingView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhoneMsgSettingView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010658 RID: 67160 RVA: 0x004CA557 File Offset: 0x004C8757
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.AfterDialogAndBgUpdate));
		this.RefreshRedDot();
	}

	// Token: 0x06010659 RID: 67161 RVA: 0x004CA57B File Offset: 0x004C877B
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.AfterDialogAndBgUpdate));
	}

	// Token: 0x0601065A RID: 67162 RVA: 0x004CA59C File Offset: 0x004C879C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.AfterChatShowChange));
		EventSystem.Instance.Add(EEventName.OnNameChange, new Action(this.OnNameChange));
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate, new Action(this.RefreshRedDot));
	}

	// Token: 0x0601065B RID: 67163 RVA: 0x004CA600 File Offset: 0x004C8800
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.AfterChatShowChange));
		EventSystem.Instance.Remove(EEventName.OnNameChange, new Action(this.OnNameChange));
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate, new Action(this.RefreshRedDot));
	}

	// Token: 0x0601065C RID: 67164 RVA: 0x004CA661 File Offset: 0x004C8861
	protected override void OnBeforeShow()
	{
		this.BuildDialogItemDataList();
		this.BuildBgItemDataList();
		this.BuildThemeItemDataList();
		this.BuildCharmItemDataList();
		this.RefreshDataAndScrollView(false);
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshRedDot();
	}

	// Token: 0x0601065D RID: 67165 RVA: 0x004CA68E File Offset: 0x004C888E
	private void OnNameChange()
	{
		this.RightChatItem.OnNameChange();
		this.TopicPanel.RightChatItem.OnNameChange();
	}

	// Token: 0x0601065E RID: 67166 RVA: 0x004CA6AB File Offset: 0x004C88AB
	private void AfterChatShowChange()
	{
		this.BuildDialogItemDataList();
		this.BuildBgItemDataList();
		this.BuildCharmItemDataList();
		this.BuildThemeItemDataList();
		this.RefreshDataAndScrollView(true);
		this.RefreshConfirmBtnOrGetLinkBtnShow();
	}

	// Token: 0x0601065F RID: 67167 RVA: 0x004CA6D2 File Offset: 0x004C88D2
	private void AfterDialogAndBgUpdate()
	{
		this.BuildDialogItemDataList();
		this.BuildBgItemDataList();
		this.BuildThemeItemDataList();
		this.BuildCharmItemDataList();
		this.RefreshDataAndScrollView(false);
		this.RefreshConfirmBtnOrGetLinkBtnShow();
	}

	// Token: 0x06010660 RID: 67168 RVA: 0x004CA6FC File Offset: 0x004C88FC
	private void RefreshRedDot()
	{
		List<IMultiTemplateGridData> dialogItemDataList = this.DialogItemDataList;
		bool uiactive = false;
		foreach (IMultiTemplateGridData multiTemplateGridData in dialogItemDataList)
		{
			SettingViewLeftDialogItemData settingViewLeftDialogItemData = multiTemplateGridData as SettingViewLeftDialogItemData;
			if (settingViewLeftDialogItemData != null && settingViewLeftDialogItemData.Data.IsHasRedDot())
			{
				uiactive = true;
				break;
			}
		}
		base.GetItem(18).SetUIActive(uiactive);
		List<IMultiTemplateGridData> bgItemDataList = this.BgItemDataList;
		bool uiactive2 = false;
		foreach (IMultiTemplateGridData multiTemplateGridData2 in bgItemDataList)
		{
			SettingViewLeftBgItemData settingViewLeftBgItemData = multiTemplateGridData2 as SettingViewLeftBgItemData;
			if (settingViewLeftBgItemData != null && settingViewLeftBgItemData.Data.IsHasRedDot())
			{
				uiactive2 = true;
				break;
			}
		}
		base.GetItem(19).SetUIActive(uiactive2);
		List<IMultiTemplateGridData> themeItemDataList = this.ThemeItemDataList;
		bool uiactive3 = false;
		foreach (IMultiTemplateGridData multiTemplateGridData3 in themeItemDataList)
		{
			SettingViewLeftThemeItemData settingViewLeftThemeItemData = multiTemplateGridData3 as SettingViewLeftThemeItemData;
			if (settingViewLeftThemeItemData != null && settingViewLeftThemeItemData.Data.IsHasRedDot())
			{
				uiactive3 = true;
				break;
			}
		}
		base.GetItem(22).SetUIActive(uiactive3);
		List<IMultiTemplateGridData> charmItemDataList = this.CharmItemDataList;
		bool uiactive4 = false;
		foreach (IMultiTemplateGridData multiTemplateGridData4 in charmItemDataList)
		{
			SettingViewLeftCharmItemData settingViewLeftCharmItemData = multiTemplateGridData4 as SettingViewLeftCharmItemData;
			if (settingViewLeftCharmItemData != null && settingViewLeftCharmItemData.Data.IsHasRedDot())
			{
				uiactive4 = true;
				break;
			}
		}
		base.GetItem(23).SetUIActive(uiactive4);
	}

	// Token: 0x06010661 RID: 67169 RVA: 0x004CA8B0 File Offset: 0x004C8AB0
	private void OnClickDialogTab(EToggleState toggleState)
	{
		PhoneMsgSettingView.ETarget? curTarget = this.CurTarget;
		PhoneMsgSettingView.ETarget etarget = PhoneMsgSettingView.ETarget.Dialog;
		if (!(curTarget.GetValueOrDefault() == etarget & curTarget != null))
		{
			this.SwitchTarget(PhoneMsgSettingView.ETarget.Dialog);
		}
	}

	// Token: 0x06010662 RID: 67170 RVA: 0x004CA8E1 File Offset: 0x004C8AE1
	private void OnClickBgTab(EToggleState toggleState)
	{
		if (this.CurTarget.GetValueOrDefault() != PhoneMsgSettingView.ETarget.Bg)
		{
			this.SwitchTarget(PhoneMsgSettingView.ETarget.Bg);
		}
	}

	// Token: 0x06010663 RID: 67171 RVA: 0x004CA8F8 File Offset: 0x004C8AF8
	private void OnClickThemeTab(EToggleState toggleState)
	{
		if (this.CurTarget.GetValueOrDefault() != PhoneMsgSettingView.ETarget.Theme)
		{
			this.SwitchTarget(PhoneMsgSettingView.ETarget.Theme);
		}
	}

	// Token: 0x06010664 RID: 67172 RVA: 0x004CA90F File Offset: 0x004C8B0F
	private void OnClickCharmTab(EToggleState toggleState)
	{
		if (this.CurTarget.GetValueOrDefault() != PhoneMsgSettingView.ETarget.Charm)
		{
			this.SwitchTarget(PhoneMsgSettingView.ETarget.Charm);
		}
	}

	// Token: 0x06010665 RID: 67173 RVA: 0x004CA928 File Offset: 0x004C8B28
	private void RefreshDataAndScrollView(bool isNeedRefreshSelect = true)
	{
		if (this.CurTarget == null)
		{
			return;
		}
		switch (this.CurTarget.Value)
		{
		case PhoneMsgSettingView.ETarget.Dialog:
		{
			if (this.DialogItemDataList.Count > 0)
			{
				for (int i = 0; i < this.DialogItemDataList.Count; i++)
				{
					((SettingViewLeftDialogItemData)this.DialogItemDataList[i]).Data.IsSelected = false;
				}
				if (isNeedRefreshSelect)
				{
					((SettingViewLeftDialogItemData)this.DialogItemDataList[0]).Data.IsSelected = true;
					this.CurSelectedDialogIndex = 0;
				}
				else
				{
					for (int j = 0; j < this.DialogItemDataList.Count; j++)
					{
						SettingViewLeftDialogItemData settingViewLeftDialogItemData = (SettingViewLeftDialogItemData)this.DialogItemDataList[j];
						if (settingViewLeftDialogItemData.GetDialogId() == this.CurPreviewDialogId)
						{
							settingViewLeftDialogItemData.Data.IsSelected = true;
							this.CurSelectedDialogIndex = j;
							break;
						}
					}
				}
			}
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(this.DialogItemDataList);
			this.LeftScrollView.RefreshByData(context);
			break;
		}
		case PhoneMsgSettingView.ETarget.Bg:
		{
			if (this.BgItemDataList.Count > 0)
			{
				for (int k = 0; k < this.BgItemDataList.Count; k++)
				{
					((SettingViewLeftBgItemData)this.BgItemDataList[k]).Data.IsSelected = false;
				}
				if (isNeedRefreshSelect)
				{
					((SettingViewLeftBgItemData)this.BgItemDataList[0]).Data.IsSelected = true;
					this.CurSelectedBgIndex = 0;
				}
				else
				{
					for (int l = 0; l < this.BgItemDataList.Count; l++)
					{
						SettingViewLeftBgItemData settingViewLeftBgItemData = (SettingViewLeftBgItemData)this.BgItemDataList[l];
						if (settingViewLeftBgItemData.GetBgId() == this.CurPreviewBgId)
						{
							settingViewLeftBgItemData.Data.IsSelected = true;
							this.CurSelectedBgIndex = l;
							break;
						}
					}
				}
			}
			MultiTemplateScrollViewRefreshContext context2 = new MultiTemplateScrollViewRefreshContext(this.BgItemDataList);
			this.LeftScrollView.RefreshByData(context2);
			break;
		}
		case PhoneMsgSettingView.ETarget.Theme:
		{
			if (this.ThemeItemDataList.Count > 0)
			{
				for (int m = 0; m < this.ThemeItemDataList.Count; m++)
				{
					((SettingViewLeftThemeItemData)this.ThemeItemDataList[m]).Data.IsSelected = false;
				}
				if (isNeedRefreshSelect)
				{
					((SettingViewLeftThemeItemData)this.ThemeItemDataList[0]).Data.IsSelected = true;
					this.CurSelectedThemeIndex = 0;
				}
				else
				{
					for (int n = 0; n < this.ThemeItemDataList.Count; n++)
					{
						SettingViewLeftThemeItemData settingViewLeftThemeItemData = (SettingViewLeftThemeItemData)this.ThemeItemDataList[n];
						if (settingViewLeftThemeItemData.GetThemeId() == this.CurPreviewThemeId)
						{
							settingViewLeftThemeItemData.Data.IsSelected = true;
							this.CurSelectedThemeIndex = n;
							break;
						}
					}
				}
			}
			MultiTemplateScrollViewRefreshContext context3 = new MultiTemplateScrollViewRefreshContext(this.ThemeItemDataList);
			this.LeftScrollView.RefreshByData(context3);
			break;
		}
		case PhoneMsgSettingView.ETarget.Charm:
		{
			if (this.CharmItemDataList.Count > 0)
			{
				for (int num = 0; num < this.CharmItemDataList.Count; num++)
				{
					((SettingViewLeftCharmItemData)this.CharmItemDataList[num]).Data.IsSelected = false;
				}
				if (isNeedRefreshSelect)
				{
					((SettingViewLeftCharmItemData)this.CharmItemDataList[0]).Data.IsSelected = true;
					this.CurSelectedCharmIndex = 0;
				}
				else
				{
					for (int num2 = 0; num2 < this.CharmItemDataList.Count; num2++)
					{
						SettingViewLeftCharmItemData settingViewLeftCharmItemData = (SettingViewLeftCharmItemData)this.CharmItemDataList[num2];
						if (settingViewLeftCharmItemData.GetCharmId() == this.CurPreviewCharmId)
						{
							settingViewLeftCharmItemData.Data.IsSelected = true;
							this.CurSelectedCharmIndex = num2;
							break;
						}
					}
				}
			}
			MultiTemplateScrollViewRefreshContext context4 = new MultiTemplateScrollViewRefreshContext(this.CharmItemDataList);
			this.LeftScrollView.RefreshByData(context4);
			break;
		}
		}
		this.LeftChatItem.RefreshSpeakerNameTextColor(this.CurPreviewBgId);
		this.RightChatItem.RefreshSpeakerNameTextColor(this.CurPreviewBgId);
		this.TopicPanel.LeftChatItem.RefreshSpeakerNameTextColor(this.CurPreviewBgId);
		this.TopicPanel.RightChatItem.RefreshSpeakerNameTextColor(this.CurPreviewBgId);
	}

	// Token: 0x06010666 RID: 67174 RVA: 0x004CAD34 File Offset: 0x004C8F34
	private void SwitchTarget(PhoneMsgSettingView.ETarget target)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(3);
		UUIExtendToggle extendToggle3 = base.GetExtendToggle(20);
		UUIExtendToggle extendToggle4 = base.GetExtendToggle(21);
		switch (target)
		{
		case PhoneMsgSettingView.ETarget.Dialog:
		{
			base.GetItem(24).SetUIActive(true);
			base.GetItem(25).SetUIActive(false);
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(this.DialogItemDataList);
			this.LeftScrollView.RefreshByData(context);
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			this.CurTarget = new PhoneMsgSettingView.ETarget?(PhoneMsgSettingView.ETarget.Dialog);
			extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle3.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle4.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshDialog();
			break;
		}
		case PhoneMsgSettingView.ETarget.Bg:
		{
			base.GetItem(24).SetUIActive(true);
			base.GetItem(25).SetUIActive(false);
			MultiTemplateScrollViewRefreshContext context2 = new MultiTemplateScrollViewRefreshContext(this.BgItemDataList);
			this.LeftScrollView.RefreshByData(context2);
			extendToggle2.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			this.CurTarget = new PhoneMsgSettingView.ETarget?(PhoneMsgSettingView.ETarget.Bg);
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle3.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle4.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshBg();
			break;
		}
		case PhoneMsgSettingView.ETarget.Theme:
		{
			base.GetItem(24).SetUIActive(false);
			base.GetItem(25).SetUIActive(true);
			MultiTemplateScrollViewRefreshContext context3 = new MultiTemplateScrollViewRefreshContext(this.ThemeItemDataList);
			this.LeftScrollView.RefreshByData(context3);
			extendToggle3.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			this.CurTarget = new PhoneMsgSettingView.ETarget?(PhoneMsgSettingView.ETarget.Theme);
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle4.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshTheme();
			break;
		}
		case PhoneMsgSettingView.ETarget.Charm:
		{
			base.GetItem(24).SetUIActive(false);
			base.GetItem(25).SetUIActive(true);
			MultiTemplateScrollViewRefreshContext context4 = new MultiTemplateScrollViewRefreshContext(this.CharmItemDataList);
			this.LeftScrollView.RefreshByData(context4);
			extendToggle4.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			this.CurTarget = new PhoneMsgSettingView.ETarget?(PhoneMsgSettingView.ETarget.Charm);
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle3.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshCharm();
			break;
		}
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
	}

	// Token: 0x06010667 RID: 67175 RVA: 0x004CAF60 File Offset: 0x004C9160
	private void BuildDialogItemDataList()
	{
		this.DialogItemDataList.Clear();
		IReadOnlyList<ChatDialog> allChatDialogConfigList = PhoneMsgConfig.Instance.GetAllChatDialogConfigList();
		if (allChatDialogConfigList == null)
		{
			return;
		}
		List<SettingViewLeftDialogItemData> list = new List<SettingViewLeftDialogItemData>();
		List<SettingViewLeftDialogItemData> list2 = new List<SettingViewLeftDialogItemData>();
		int count = allChatDialogConfigList.Count;
		for (int i = 0; i < count; i++)
		{
			ChatDialog chatDialog = allChatDialogConfigList[i];
			PhoneMsgDialogItemData phoneMsgDialogItemData = new PhoneMsgDialogItemData();
			phoneMsgDialogItemData.DialogId = chatDialog.Id;
			phoneMsgDialogItemData.IsUnlocked = PhoneMsgModel.Instance.IsChatDialogUnlocked(chatDialog.Id);
			phoneMsgDialogItemData.IsUsing = (PhoneMsgModel.Instance.CurrentUsingChatDialogId == chatDialog.Id);
			phoneMsgDialogItemData.IsSelected = (chatDialog.Id == this.CurPreviewDialogId);
			SettingViewLeftDialogItemData settingViewLeftDialogItemData = new SettingViewLeftDialogItemData(phoneMsgDialogItemData);
			settingViewLeftDialogItemData.OnToggleCallBack = new Action<int, PhoneMsgDialogItemData>(this.DialogItemToggleClick);
			if (phoneMsgDialogItemData.IsUsing)
			{
				this.DialogItemDataList.Add(settingViewLeftDialogItemData);
			}
			else if (phoneMsgDialogItemData.IsUnlocked)
			{
				list.Add(settingViewLeftDialogItemData);
			}
			else
			{
				list2.Add(settingViewLeftDialogItemData);
			}
		}
		this.SortItemDataListBySortId<SettingViewLeftDialogItemData>(list);
		this.SortItemDataListBySortId<SettingViewLeftDialogItemData>(list2);
		this.DialogItemDataList.AddRange(list);
		this.DialogItemDataList.AddRange(list2);
		this.CurSelectedDialogIndex = this.FindDialogIndexById(this.CurPreviewDialogId);
	}

	// Token: 0x06010668 RID: 67176 RVA: 0x004CB0A0 File Offset: 0x004C92A0
	private void BuildBgItemDataList()
	{
		this.BgItemDataList.Clear();
		IReadOnlyList<ChatBg> allChatBgConfigList = PhoneMsgConfig.Instance.GetAllChatBgConfigList();
		if (allChatBgConfigList == null)
		{
			return;
		}
		List<SettingViewLeftBgItemData> list = new List<SettingViewLeftBgItemData>();
		List<SettingViewLeftBgItemData> list2 = new List<SettingViewLeftBgItemData>();
		int count = allChatBgConfigList.Count;
		for (int i = 0; i < count; i++)
		{
			ChatBg chatBg = allChatBgConfigList[i];
			PhoneMsgBgItemData phoneMsgBgItemData = new PhoneMsgBgItemData();
			phoneMsgBgItemData.BgId = chatBg.Id;
			phoneMsgBgItemData.IsUnlocked = PhoneMsgModel.Instance.IsChatBgUnlocked(chatBg.Id);
			phoneMsgBgItemData.IsUsing = (PhoneMsgModel.Instance.CurrentUsingChatBgId == chatBg.Id);
			phoneMsgBgItemData.IsSelected = (chatBg.Id == this.CurPreviewBgId);
			SettingViewLeftBgItemData settingViewLeftBgItemData = new SettingViewLeftBgItemData(phoneMsgBgItemData);
			settingViewLeftBgItemData.OnToggleCallBack = new Action<int, PhoneMsgBgItemData>(this.BgItemToggleClick);
			if (phoneMsgBgItemData.IsUsing)
			{
				this.BgItemDataList.Add(settingViewLeftBgItemData);
			}
			else if (phoneMsgBgItemData.IsUnlocked)
			{
				list.Add(settingViewLeftBgItemData);
			}
			else
			{
				list2.Add(settingViewLeftBgItemData);
			}
		}
		this.SortItemDataListBySortId<SettingViewLeftBgItemData>(list);
		this.SortItemDataListBySortId<SettingViewLeftBgItemData>(list2);
		this.BgItemDataList.AddRange(list);
		this.BgItemDataList.AddRange(list2);
		this.CurSelectedBgIndex = this.FindBgIndexById(this.CurPreviewBgId);
	}

	// Token: 0x06010669 RID: 67177 RVA: 0x004CB1E0 File Offset: 0x004C93E0
	private void BuildThemeItemDataList()
	{
		this.ThemeItemDataList.Clear();
		IReadOnlyList<ChatTheme> allChatThemeConfigList = PhoneMsgConfig.Instance.GetAllChatThemeConfigList();
		if (allChatThemeConfigList == null)
		{
			return;
		}
		List<SettingViewLeftThemeItemData> list = new List<SettingViewLeftThemeItemData>();
		List<SettingViewLeftThemeItemData> list2 = new List<SettingViewLeftThemeItemData>();
		int count = allChatThemeConfigList.Count;
		for (int i = 0; i < count; i++)
		{
			ChatTheme chatTheme = allChatThemeConfigList[i];
			PhoneMsgThemeItemData phoneMsgThemeItemData = new PhoneMsgThemeItemData();
			phoneMsgThemeItemData.ThemeId = chatTheme.Id;
			phoneMsgThemeItemData.IsUnlocked = PhoneMsgModel.Instance.IsChatThemeUnlocked(chatTheme.Id);
			phoneMsgThemeItemData.IsUsing = (PhoneMsgModel.Instance.CurrentUsingChatThemeId == chatTheme.Id);
			phoneMsgThemeItemData.IsSelected = (chatTheme.Id == this.CurPreviewThemeId);
			SettingViewLeftThemeItemData settingViewLeftThemeItemData = new SettingViewLeftThemeItemData(phoneMsgThemeItemData);
			settingViewLeftThemeItemData.OnToggleCallBack = new Action<int, PhoneMsgThemeItemData>(this.ThemeItemToggleClick);
			if (phoneMsgThemeItemData.IsUsing)
			{
				this.ThemeItemDataList.Add(settingViewLeftThemeItemData);
			}
			else if (phoneMsgThemeItemData.IsUnlocked)
			{
				list.Add(settingViewLeftThemeItemData);
			}
			else
			{
				list2.Add(settingViewLeftThemeItemData);
			}
		}
		this.SortItemDataListBySortId<SettingViewLeftThemeItemData>(list);
		this.SortItemDataListBySortId<SettingViewLeftThemeItemData>(list2);
		this.ThemeItemDataList.AddRange(list);
		this.ThemeItemDataList.AddRange(list2);
		this.CurSelectedThemeIndex = this.FindThemeIndexById(this.CurPreviewThemeId);
	}

	// Token: 0x0601066A RID: 67178 RVA: 0x004CB320 File Offset: 0x004C9520
	private void BuildCharmItemDataList()
	{
		this.CharmItemDataList.Clear();
		IReadOnlyList<ChatCharm> allChatCharmConfigList = PhoneMsgConfig.Instance.GetAllChatCharmConfigList();
		if (allChatCharmConfigList == null)
		{
			return;
		}
		List<SettingViewLeftCharmItemData> list = new List<SettingViewLeftCharmItemData>();
		List<SettingViewLeftCharmItemData> list2 = new List<SettingViewLeftCharmItemData>();
		int count = allChatCharmConfigList.Count;
		for (int i = 0; i < count; i++)
		{
			ChatCharm chatCharm = allChatCharmConfigList[i];
			PhoneMsgCharmItemData phoneMsgCharmItemData = new PhoneMsgCharmItemData();
			phoneMsgCharmItemData.CharmId = chatCharm.Id;
			phoneMsgCharmItemData.IsUnlocked = PhoneMsgModel.Instance.IsChatCharmUnlocked(chatCharm.Id);
			phoneMsgCharmItemData.IsUsing = (PhoneMsgModel.Instance.CurrentUsingChatCharmId == chatCharm.Id);
			phoneMsgCharmItemData.IsSelected = (chatCharm.Id == this.CurPreviewCharmId);
			SettingViewLeftCharmItemData settingViewLeftCharmItemData = new SettingViewLeftCharmItemData(phoneMsgCharmItemData);
			settingViewLeftCharmItemData.OnToggleCallBack = new Action<int, PhoneMsgCharmItemData>(this.CharmItemToggleClick);
			if (phoneMsgCharmItemData.IsUsing)
			{
				this.CharmItemDataList.Add(settingViewLeftCharmItemData);
			}
			else if (phoneMsgCharmItemData.IsUnlocked)
			{
				list.Add(settingViewLeftCharmItemData);
			}
			else
			{
				list2.Add(settingViewLeftCharmItemData);
			}
		}
		this.SortItemDataListBySortId<SettingViewLeftCharmItemData>(list);
		this.SortItemDataListBySortId<SettingViewLeftCharmItemData>(list2);
		this.CharmItemDataList.AddRange(list);
		this.CharmItemDataList.AddRange(list2);
		this.CurSelectedCharmIndex = this.FindCharmIndexById(this.CurPreviewCharmId);
	}

	// Token: 0x0601066B RID: 67179 RVA: 0x004CB45E File Offset: 0x004C965E
	private void SortItemDataListBySortId<[Nullable(0)] T>(List<T> list) where T : IMultiTemplateGridData
	{
		list.Sort(delegate(T a, T b)
		{
			int num = 0;
			int num2 = 0;
			PhoneMsgDialogItemData phoneMsgDialogItemData = a.Data as PhoneMsgDialogItemData;
			if (phoneMsgDialogItemData != null)
			{
				ChatDialog? chatDialogConfig = PhoneMsgConfig.Instance.GetChatDialogConfig(phoneMsgDialogItemData.DialogId);
				num = ((chatDialogConfig != null) ? chatDialogConfig.GetValueOrDefault().SortId : 0);
			}
			else
			{
				PhoneMsgBgItemData phoneMsgBgItemData = a.Data as PhoneMsgBgItemData;
				if (phoneMsgBgItemData != null)
				{
					ChatBg? chatBgConfig = PhoneMsgConfig.Instance.GetChatBgConfig(phoneMsgBgItemData.BgId);
					num = ((chatBgConfig != null) ? chatBgConfig.GetValueOrDefault().SortId : 0);
				}
				else
				{
					PhoneMsgThemeItemData phoneMsgThemeItemData = a.Data as PhoneMsgThemeItemData;
					if (phoneMsgThemeItemData != null)
					{
						ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(phoneMsgThemeItemData.ThemeId);
						num = ((chatThemeConfig != null) ? chatThemeConfig.GetValueOrDefault().SortId : 0);
					}
					else
					{
						PhoneMsgCharmItemData phoneMsgCharmItemData = a.Data as PhoneMsgCharmItemData;
						if (phoneMsgCharmItemData != null)
						{
							ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(phoneMsgCharmItemData.CharmId);
							num = ((chatCharmConfig != null) ? chatCharmConfig.GetValueOrDefault().SortId : 0);
						}
					}
				}
			}
			PhoneMsgDialogItemData phoneMsgDialogItemData2 = b.Data as PhoneMsgDialogItemData;
			if (phoneMsgDialogItemData2 != null)
			{
				ChatDialog? chatDialogConfig2 = PhoneMsgConfig.Instance.GetChatDialogConfig(phoneMsgDialogItemData2.DialogId);
				num2 = ((chatDialogConfig2 != null) ? chatDialogConfig2.GetValueOrDefault().SortId : 0);
			}
			else
			{
				PhoneMsgBgItemData phoneMsgBgItemData2 = b.Data as PhoneMsgBgItemData;
				if (phoneMsgBgItemData2 != null)
				{
					ChatBg? chatBgConfig2 = PhoneMsgConfig.Instance.GetChatBgConfig(phoneMsgBgItemData2.BgId);
					num2 = ((chatBgConfig2 != null) ? chatBgConfig2.GetValueOrDefault().SortId : 0);
				}
				else
				{
					PhoneMsgThemeItemData phoneMsgThemeItemData2 = b.Data as PhoneMsgThemeItemData;
					if (phoneMsgThemeItemData2 != null)
					{
						ChatTheme? chatThemeConfig2 = PhoneMsgConfig.Instance.GetChatThemeConfig(phoneMsgThemeItemData2.ThemeId);
						num2 = ((chatThemeConfig2 != null) ? chatThemeConfig2.GetValueOrDefault().SortId : 0);
					}
					else
					{
						PhoneMsgCharmItemData phoneMsgCharmItemData2 = b.Data as PhoneMsgCharmItemData;
						if (phoneMsgCharmItemData2 != null)
						{
							ChatCharm? chatCharmConfig2 = PhoneMsgConfig.Instance.GetChatCharmConfig(phoneMsgCharmItemData2.CharmId);
							num2 = ((chatCharmConfig2 != null) ? chatCharmConfig2.GetValueOrDefault().SortId : 0);
						}
					}
				}
			}
			return num2 - num;
		});
	}

	// Token: 0x0601066C RID: 67180 RVA: 0x004CB488 File Offset: 0x004C9688
	private void RefreshDialog()
	{
		ChatDialog? chatDialogConfig = PhoneMsgConfig.Instance.GetChatDialogConfig(this.CurPreviewDialogId);
		if (chatDialogConfig == null)
		{
			return;
		}
		this.RightChatItem.RefreshDialog(this.CurPreviewDialogId);
		this.TopicPanel.RightChatItem.RefreshDialog(this.CurPreviewDialogId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), chatDialogConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), chatDialogConfig.Value.Desc, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), chatDialogConfig.Value.GetWay, Array.Empty<object>());
	}

	// Token: 0x0601066D RID: 67181 RVA: 0x004CB54C File Offset: 0x004C974C
	private void RefreshBg()
	{
		ChatBg? chatBgConfig = PhoneMsgConfig.Instance.GetChatBgConfig(this.CurPreviewBgId);
		if (chatBgConfig == null)
		{
			return;
		}
		UUITexture texture = base.GetTexture(10);
		base.SetTextureByPath(chatBgConfig.Value.ChatBgPathBig, texture, null, null);
		this.TopicPanel.SetChatBg(chatBgConfig.Value.ChatBgPathBig);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), chatBgConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), chatBgConfig.Value.Desc, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), chatBgConfig.Value.GetWay, Array.Empty<object>());
		this.LeftChatItem.RefreshSpeakerNameTextColor(this.CurPreviewBgId);
		this.RightChatItem.RefreshSpeakerNameTextColor(this.CurPreviewBgId);
		this.TopicPanel.LeftChatItem.RefreshSpeakerNameTextColor(this.CurPreviewBgId);
		this.TopicPanel.RightChatItem.RefreshSpeakerNameTextColor(this.CurPreviewBgId);
	}

	// Token: 0x0601066E RID: 67182 RVA: 0x004CB678 File Offset: 0x004C9878
	private void RefreshTheme()
	{
		ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(this.CurPreviewThemeId);
		if (chatThemeConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), chatThemeConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), chatThemeConfig.Value.Desc, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), chatThemeConfig.Value.GetWay, Array.Empty<object>());
		this.TopicPanel.RefreshThemeId(this.CurPreviewThemeId);
		bool flag = PhoneMsgModel.Instance.IsDefaultTheme(this.CurPreviewThemeId);
		UUITexture texture = base.GetTexture(26);
		if (texture != null)
		{
			texture.SetUIActive(flag);
		}
		UUITexture texture2 = base.GetTexture(27);
		if (texture2 == null)
		{
			return;
		}
		texture2.SetUIActive(!flag);
	}

	// Token: 0x0601066F RID: 67183 RVA: 0x004CB760 File Offset: 0x004C9960
	private void RefreshCharm()
	{
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(this.CurPreviewCharmId);
		if (chatCharmConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), chatCharmConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), chatCharmConfig.Value.Desc, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), chatCharmConfig.Value.GetWay, Array.Empty<object>());
		this.TopicPanel.SetSpineByCharmId(this.CurPreviewCharmId);
	}

	// Token: 0x06010670 RID: 67184 RVA: 0x004CB80C File Offset: 0x004C9A0C
	private void RefreshConfirmBtnOrGetLinkBtnShow()
	{
		bool flag = false;
		bool enableClick = false;
		bool flag2 = false;
		object obj = null;
		PhoneMsgModel instance = PhoneMsgModel.Instance;
		if (this.CurTarget == null)
		{
			return;
		}
		switch (this.CurTarget.Value)
		{
		case PhoneMsgSettingView.ETarget.Dialog:
			flag = instance.IsChatDialogUnlocked(this.CurPreviewDialogId);
			obj = PhoneMsgConfig.Instance.GetChatDialogConfig(this.CurPreviewDialogId);
			enableClick = (flag && instance.CurrentUsingChatDialogId != this.CurPreviewDialogId);
			flag2 = (instance.CurrentUsingChatDialogId == this.CurPreviewDialogId);
			break;
		case PhoneMsgSettingView.ETarget.Bg:
			flag = instance.IsChatBgUnlocked(this.CurPreviewBgId);
			obj = PhoneMsgConfig.Instance.GetChatBgConfig(this.CurPreviewBgId);
			enableClick = (flag && instance.CurrentUsingChatBgId != this.CurPreviewBgId);
			flag2 = (instance.CurrentUsingChatBgId == this.CurPreviewBgId);
			break;
		case PhoneMsgSettingView.ETarget.Theme:
			flag = instance.IsChatThemeUnlocked(this.CurPreviewThemeId);
			obj = PhoneMsgConfig.Instance.GetChatThemeConfig(this.CurPreviewThemeId);
			enableClick = (flag && instance.CurrentUsingChatThemeId != this.CurPreviewThemeId);
			flag2 = (instance.CurrentUsingChatThemeId == this.CurPreviewThemeId);
			break;
		case PhoneMsgSettingView.ETarget.Charm:
			flag = instance.IsChatCharmUnlocked(this.CurPreviewCharmId);
			obj = PhoneMsgConfig.Instance.GetChatCharmConfig(this.CurPreviewCharmId);
			enableClick = (flag && instance.CurrentUsingChatCharmId != this.CurPreviewCharmId);
			flag2 = (instance.CurrentUsingChatCharmId == this.CurPreviewCharmId);
			break;
		}
		if (obj == null)
		{
			return;
		}
		bool flag3 = false;
		if (obj is ChatDialog)
		{
			flag3 = (((ChatDialog)obj).ItemAccessLength > 0);
		}
		else if (obj is ChatBg)
		{
			flag3 = (((ChatBg)obj).ItemAccessLength > 0);
		}
		else if (obj is ChatTheme)
		{
			flag3 = (((ChatTheme)obj).ItemAccessLength > 0);
		}
		else if (obj is ChatCharm)
		{
			flag3 = (((ChatCharm)obj).ItemAccessLength > 0);
		}
		base.GetItem(8).SetUIActive(false);
		base.GetItem(15).SetUIActive(false);
		if (flag || !flag3)
		{
			base.GetItem(8).SetUIActive(true);
			this.ConfirmBtn.SetEnableClick(enableClick);
			string textId = flag2 ? "Text_InUse_Text" : "ChatBubble_SettingUse";
			this.ConfirmBtn.SetLocalTextNew(textId, Array.Empty<object>());
			return;
		}
		base.GetItem(15).SetUIActive(true);
		if (obj is ChatDialog)
		{
			ChatDialog chatDialog = (ChatDialog)obj;
			this.GetLinkBtn.RefreshByGetWayId(chatDialog.ItemAccess(0));
			return;
		}
		if (obj is ChatBg)
		{
			ChatBg chatBg = (ChatBg)obj;
			this.GetLinkBtn.RefreshByGetWayId(chatBg.ItemAccess(0));
			return;
		}
		if (obj is ChatTheme)
		{
			ChatTheme chatTheme = (ChatTheme)obj;
			this.GetLinkBtn.RefreshByGetWayId(chatTheme.ItemAccess(0));
			return;
		}
		if (obj is ChatCharm)
		{
			ChatCharm chatCharm = (ChatCharm)obj;
			this.GetLinkBtn.RefreshByGetWayId(chatCharm.ItemAccess(0));
		}
	}

	// Token: 0x06010671 RID: 67185 RVA: 0x004CBB18 File Offset: 0x004C9D18
	private void DialogItemToggleClick(int gridIndex, PhoneMsgDialogItemData newDialogData)
	{
		if (this.CurSelectedDialogIndex >= 0)
		{
			int curSelectedDialogIndex = this.CurSelectedDialogIndex;
			((PhoneMsgDialogItemData)this.DialogItemDataList[curSelectedDialogIndex].Data).IsSelected = false;
			PhoneMsgDialogItem phoneMsgDialogItem = this.LeftScrollView.GetProxyByGridIndex(curSelectedDialogIndex) as PhoneMsgDialogItem;
			if (phoneMsgDialogItem != null)
			{
				phoneMsgDialogItem.SetToggleState(false, false);
			}
		}
		this.CurSelectedDialogIndex = gridIndex;
		this.CurPreviewDialogId = newDialogData.DialogId;
		newDialogData.IsSelected = true;
		PhoneMsgDialogItem phoneMsgDialogItem2 = this.LeftScrollView.GetProxyByGridIndex(gridIndex) as PhoneMsgDialogItem;
		if (phoneMsgDialogItem2 != null)
		{
			phoneMsgDialogItem2.SetToggleState(true, false);
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshDialog();
	}

	// Token: 0x06010672 RID: 67186 RVA: 0x004CBBB4 File Offset: 0x004C9DB4
	private void BgItemToggleClick(int gridIndex, PhoneMsgBgItemData newBgData)
	{
		if (this.CurSelectedBgIndex >= 0)
		{
			int curSelectedBgIndex = this.CurSelectedBgIndex;
			((PhoneMsgBgItemData)this.BgItemDataList[curSelectedBgIndex].Data).IsSelected = false;
			PhoneMsgBgItem phoneMsgBgItem = this.LeftScrollView.GetProxyByGridIndex(curSelectedBgIndex) as PhoneMsgBgItem;
			if (phoneMsgBgItem != null)
			{
				phoneMsgBgItem.SetToggleState(false, false);
			}
		}
		this.CurSelectedBgIndex = gridIndex;
		this.CurPreviewBgId = newBgData.BgId;
		newBgData.IsSelected = true;
		PhoneMsgBgItem phoneMsgBgItem2 = this.LeftScrollView.GetProxyByGridIndex(gridIndex) as PhoneMsgBgItem;
		if (phoneMsgBgItem2 != null)
		{
			phoneMsgBgItem2.SetToggleState(true, false);
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshBg();
	}

	// Token: 0x06010673 RID: 67187 RVA: 0x004CBC50 File Offset: 0x004C9E50
	private void ThemeItemToggleClick(int gridIndex, PhoneMsgThemeItemData newThemeData)
	{
		if (this.CurSelectedThemeIndex >= 0)
		{
			int curSelectedThemeIndex = this.CurSelectedThemeIndex;
			((PhoneMsgThemeItemData)this.ThemeItemDataList[curSelectedThemeIndex].Data).IsSelected = false;
			PhoneMsgThemeItem phoneMsgThemeItem = this.LeftScrollView.GetProxyByGridIndex(curSelectedThemeIndex) as PhoneMsgThemeItem;
			if (phoneMsgThemeItem != null)
			{
				phoneMsgThemeItem.SetToggleState(false, false);
			}
		}
		this.CurSelectedThemeIndex = gridIndex;
		this.CurPreviewThemeId = newThemeData.ThemeId;
		newThemeData.IsSelected = true;
		PhoneMsgThemeItem phoneMsgThemeItem2 = this.LeftScrollView.GetProxyByGridIndex(gridIndex) as PhoneMsgThemeItem;
		if (phoneMsgThemeItem2 != null)
		{
			phoneMsgThemeItem2.SetToggleState(true, false);
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshTheme();
	}

	// Token: 0x06010674 RID: 67188 RVA: 0x004CBCEC File Offset: 0x004C9EEC
	private void CharmItemToggleClick(int gridIndex, PhoneMsgCharmItemData newCharmData)
	{
		if (this.CurSelectedCharmIndex >= 0)
		{
			int curSelectedCharmIndex = this.CurSelectedCharmIndex;
			((PhoneMsgCharmItemData)this.CharmItemDataList[curSelectedCharmIndex].Data).IsSelected = false;
			PhoneMsgCharmItem phoneMsgCharmItem = this.LeftScrollView.GetProxyByGridIndex(curSelectedCharmIndex) as PhoneMsgCharmItem;
			if (phoneMsgCharmItem != null)
			{
				phoneMsgCharmItem.SetToggleState(false, false);
			}
		}
		this.CurSelectedCharmIndex = gridIndex;
		this.CurPreviewCharmId = newCharmData.CharmId;
		newCharmData.IsSelected = true;
		PhoneMsgCharmItem phoneMsgCharmItem2 = this.LeftScrollView.GetProxyByGridIndex(gridIndex) as PhoneMsgCharmItem;
		if (phoneMsgCharmItem2 != null)
		{
			phoneMsgCharmItem2.SetToggleState(true, false);
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshCharm();
	}

	// Token: 0x06010675 RID: 67189 RVA: 0x004CBD88 File Offset: 0x004C9F88
	private void OnBtnConfirmClick(int _)
	{
		PhoneMsgModel instance = PhoneMsgModel.Instance;
		int chatDialogId = instance.CurrentUsingChatDialogId;
		int chatBgId = instance.CurrentUsingChatBgId;
		int chatThemeId = instance.CurrentUsingChatThemeId;
		int chatCharmId = instance.CurrentUsingChatCharmId;
		PhoneMsgSettingView.ETarget? curTarget = this.CurTarget;
		if (curTarget != null)
		{
			switch (curTarget.GetValueOrDefault())
			{
			case PhoneMsgSettingView.ETarget.Dialog:
			{
				chatDialogId = this.CurPreviewDialogId;
				instance.RemoveChatShowRedDotById(this.CurPreviewDialogId);
				PhoneMsgDialogItem phoneMsgDialogItem = this.LeftScrollView.GetProxyByGridIndex(this.CurSelectedDialogIndex) as PhoneMsgDialogItem;
				if (phoneMsgDialogItem != null)
				{
					phoneMsgDialogItem.HideRedDot();
				}
				break;
			}
			case PhoneMsgSettingView.ETarget.Bg:
			{
				chatBgId = this.CurPreviewBgId;
				instance.RemoveChatShowRedDotById(this.CurPreviewBgId);
				PhoneMsgBgItem phoneMsgBgItem = this.LeftScrollView.GetProxyByGridIndex(this.CurSelectedBgIndex) as PhoneMsgBgItem;
				if (phoneMsgBgItem != null)
				{
					phoneMsgBgItem.HideRedDot();
				}
				break;
			}
			case PhoneMsgSettingView.ETarget.Theme:
			{
				chatThemeId = this.CurPreviewThemeId;
				instance.RemoveChatShowRedDotById(this.CurPreviewThemeId);
				PhoneMsgThemeItem phoneMsgThemeItem = this.LeftScrollView.GetProxyByGridIndex(this.CurSelectedThemeIndex) as PhoneMsgThemeItem;
				if (phoneMsgThemeItem != null)
				{
					phoneMsgThemeItem.HideRedDot();
				}
				break;
			}
			case PhoneMsgSettingView.ETarget.Charm:
			{
				chatCharmId = this.CurPreviewCharmId;
				instance.RemoveChatShowRedDotById(this.CurPreviewCharmId);
				PhoneMsgCharmItem phoneMsgCharmItem = this.LeftScrollView.GetProxyByGridIndex(this.CurSelectedCharmIndex) as PhoneMsgCharmItem;
				if (phoneMsgCharmItem != null)
				{
					phoneMsgCharmItem.HideRedDot();
				}
				break;
			}
			}
		}
		curTarget = this.CurTarget;
		if (curTarget != null)
		{
			switch (curTarget.GetValueOrDefault())
			{
			case PhoneMsgSettingView.ETarget.Dialog:
			case PhoneMsgSettingView.ETarget.Bg:
				PhoneMsgController.Instance.SendChangeChatDialogAndBgRequest(chatDialogId, chatBgId);
				return;
			case PhoneMsgSettingView.ETarget.Theme:
				PhoneMsgController.Instance.SendChangeChatThemeRequest(chatThemeId);
				return;
			case PhoneMsgSettingView.ETarget.Charm:
				PhoneMsgController.Instance.SendChangeChatCharmRequest(chatCharmId);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06010676 RID: 67190 RVA: 0x004CBF25 File Offset: 0x004CA125
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010677 RID: 67191 RVA: 0x004CBF2E File Offset: 0x004CA12E
	private bool HandleOpenParamJump()
	{
		return this.OpenParam != null && this.JumpToTargetById(Convert.ToInt32(this.OpenParam));
	}

	// Token: 0x06010678 RID: 67192 RVA: 0x004CBF4C File Offset: 0x004CA14C
	public bool JumpToTargetById(int targetId)
	{
		if (targetId <= 0)
		{
			return false;
		}
		if (PhoneMsgConfig.Instance.GetChatDialogConfig(targetId) != null)
		{
			int num = this.FindDialogIndexById(targetId);
			if (num >= 0)
			{
				this.SwitchToDialogTabAndSelect(num);
				return true;
			}
		}
		if (PhoneMsgConfig.Instance.GetChatBgConfig(targetId) != null)
		{
			int num2 = this.FindBgIndexById(targetId);
			if (num2 >= 0)
			{
				this.SwitchToBgTabAndSelect(num2);
				return true;
			}
		}
		if (PhoneMsgConfig.Instance.GetChatThemeConfig(targetId) != null)
		{
			int num3 = this.FindThemeIndexById(targetId);
			if (num3 >= 0)
			{
				this.SwitchToThemeTabAndSelect(num3);
				return true;
			}
		}
		if (PhoneMsgConfig.Instance.GetChatCharmConfig(targetId) != null)
		{
			int num4 = this.FindCharmIndexById(targetId);
			if (num4 >= 0)
			{
				this.SwitchToCharmTabAndSelect(num4);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06010679 RID: 67193 RVA: 0x004CC014 File Offset: 0x004CA214
	private int FindDialogIndexById(int dialogId)
	{
		for (int i = 0; i < this.DialogItemDataList.Count; i++)
		{
			if (((SettingViewLeftDialogItemData)this.DialogItemDataList[i]).GetDialogId() == dialogId)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0601067A RID: 67194 RVA: 0x004CC054 File Offset: 0x004CA254
	private int FindBgIndexById(int bgId)
	{
		for (int i = 0; i < this.BgItemDataList.Count; i++)
		{
			if (((SettingViewLeftBgItemData)this.BgItemDataList[i]).GetBgId() == bgId)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0601067B RID: 67195 RVA: 0x004CC094 File Offset: 0x004CA294
	private int FindThemeIndexById(int themeId)
	{
		for (int i = 0; i < this.ThemeItemDataList.Count; i++)
		{
			if (((SettingViewLeftThemeItemData)this.ThemeItemDataList[i]).GetThemeId() == themeId)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0601067C RID: 67196 RVA: 0x004CC0D4 File Offset: 0x004CA2D4
	private int FindCharmIndexById(int charmId)
	{
		for (int i = 0; i < this.CharmItemDataList.Count; i++)
		{
			if (((SettingViewLeftCharmItemData)this.CharmItemDataList[i]).GetCharmId() == charmId)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0601067D RID: 67197 RVA: 0x004CC114 File Offset: 0x004CA314
	private void SwitchToDialogTabAndSelect(int index)
	{
		PhoneMsgSettingView.ETarget? curTarget = this.CurTarget;
		PhoneMsgSettingView.ETarget etarget = PhoneMsgSettingView.ETarget.Dialog;
		if (curTarget.GetValueOrDefault() == etarget & curTarget != null)
		{
			this.SelectDialogItemByIndex(index);
			return;
		}
		this.OnClickDialogTab(EToggleState.ETT_Checked);
		this.SelectDialogItemByIndex(index);
	}

	// Token: 0x0601067E RID: 67198 RVA: 0x004CC154 File Offset: 0x004CA354
	private void SwitchToBgTabAndSelect(int index)
	{
		if (this.CurTarget.GetValueOrDefault() != PhoneMsgSettingView.ETarget.Bg)
		{
			this.OnClickBgTab(EToggleState.ETT_Checked);
		}
		this.SelectBgItemByIndex(index);
	}

	// Token: 0x0601067F RID: 67199 RVA: 0x004CC172 File Offset: 0x004CA372
	private void SwitchToThemeTabAndSelect(int index)
	{
		if (this.CurTarget.GetValueOrDefault() != PhoneMsgSettingView.ETarget.Theme)
		{
			this.OnClickThemeTab(EToggleState.ETT_Checked);
		}
		this.SelectThemeItemByIndex(index);
	}

	// Token: 0x06010680 RID: 67200 RVA: 0x004CC190 File Offset: 0x004CA390
	private void SwitchToCharmTabAndSelect(int index)
	{
		if (this.CurTarget.GetValueOrDefault() != PhoneMsgSettingView.ETarget.Charm)
		{
			this.OnClickCharmTab(EToggleState.ETT_Checked);
		}
		this.SelectCharmItemByIndex(index);
	}

	// Token: 0x06010681 RID: 67201 RVA: 0x004CC1B0 File Offset: 0x004CA3B0
	private void SelectDialogItemByIndex(int index)
	{
		if (index < 0 || index >= this.DialogItemDataList.Count)
		{
			return;
		}
		if (this.CurSelectedDialogIndex >= 0 && this.CurSelectedDialogIndex < this.DialogItemDataList.Count)
		{
			((SettingViewLeftDialogItemData)this.DialogItemDataList[this.CurSelectedDialogIndex]).Data.IsSelected = false;
			PhoneMsgDialogItem phoneMsgDialogItem = this.LeftScrollView.GetProxyByGridIndex(this.CurSelectedDialogIndex) as PhoneMsgDialogItem;
			if (phoneMsgDialogItem != null)
			{
				phoneMsgDialogItem.SetToggleState(false, false);
			}
		}
		this.CurSelectedDialogIndex = index;
		this.CurPreviewDialogId = ((SettingViewLeftDialogItemData)this.DialogItemDataList[index]).GetDialogId();
		((SettingViewLeftDialogItemData)this.DialogItemDataList[index]).Data.IsSelected = true;
		PhoneMsgDialogItem phoneMsgDialogItem2 = this.LeftScrollView.GetProxyByGridIndex(index) as PhoneMsgDialogItem;
		if (phoneMsgDialogItem2 != null)
		{
			phoneMsgDialogItem2.SetToggleState(true, false);
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshDialog();
	}

	// Token: 0x06010682 RID: 67202 RVA: 0x004CC29C File Offset: 0x004CA49C
	private void SelectBgItemByIndex(int index)
	{
		if (index < 0 || index >= this.BgItemDataList.Count)
		{
			return;
		}
		if (this.CurSelectedBgIndex >= 0 && this.CurSelectedBgIndex < this.BgItemDataList.Count)
		{
			((SettingViewLeftBgItemData)this.BgItemDataList[this.CurSelectedBgIndex]).Data.IsSelected = false;
			PhoneMsgBgItem phoneMsgBgItem = this.LeftScrollView.GetProxyByGridIndex(this.CurSelectedBgIndex) as PhoneMsgBgItem;
			if (phoneMsgBgItem != null)
			{
				phoneMsgBgItem.SetToggleState(false, false);
			}
		}
		this.CurSelectedBgIndex = index;
		this.CurPreviewBgId = ((SettingViewLeftBgItemData)this.BgItemDataList[index]).GetBgId();
		((SettingViewLeftBgItemData)this.BgItemDataList[index]).Data.IsSelected = true;
		PhoneMsgBgItem phoneMsgBgItem2 = this.LeftScrollView.GetProxyByGridIndex(index) as PhoneMsgBgItem;
		if (phoneMsgBgItem2 != null)
		{
			phoneMsgBgItem2.SetToggleState(true, false);
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshBg();
	}

	// Token: 0x06010683 RID: 67203 RVA: 0x004CC388 File Offset: 0x004CA588
	private void SelectThemeItemByIndex(int index)
	{
		if (index < 0 || index >= this.ThemeItemDataList.Count)
		{
			return;
		}
		if (this.CurSelectedThemeIndex >= 0 && this.CurSelectedThemeIndex < this.ThemeItemDataList.Count)
		{
			((SettingViewLeftThemeItemData)this.ThemeItemDataList[this.CurSelectedThemeIndex]).Data.IsSelected = false;
			PhoneMsgThemeItem phoneMsgThemeItem = this.LeftScrollView.GetProxyByGridIndex(this.CurSelectedThemeIndex) as PhoneMsgThemeItem;
			if (phoneMsgThemeItem != null)
			{
				phoneMsgThemeItem.SetToggleState(false, false);
			}
		}
		this.CurSelectedThemeIndex = index;
		this.CurPreviewThemeId = ((SettingViewLeftThemeItemData)this.ThemeItemDataList[index]).GetThemeId();
		((SettingViewLeftThemeItemData)this.ThemeItemDataList[index]).Data.IsSelected = true;
		PhoneMsgThemeItem phoneMsgThemeItem2 = this.LeftScrollView.GetProxyByGridIndex(index) as PhoneMsgThemeItem;
		if (phoneMsgThemeItem2 != null)
		{
			phoneMsgThemeItem2.SetToggleState(true, false);
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshTheme();
	}

	// Token: 0x06010684 RID: 67204 RVA: 0x004CC474 File Offset: 0x004CA674
	private void SelectCharmItemByIndex(int index)
	{
		if (index < 0 || index >= this.CharmItemDataList.Count)
		{
			return;
		}
		if (this.CurSelectedCharmIndex >= 0 && this.CurSelectedCharmIndex < this.CharmItemDataList.Count)
		{
			((SettingViewLeftCharmItemData)this.CharmItemDataList[this.CurSelectedCharmIndex]).Data.IsSelected = false;
			PhoneMsgCharmItem phoneMsgCharmItem = this.LeftScrollView.GetProxyByGridIndex(this.CurSelectedCharmIndex) as PhoneMsgCharmItem;
			if (phoneMsgCharmItem != null)
			{
				phoneMsgCharmItem.SetToggleState(false, false);
			}
		}
		this.CurSelectedCharmIndex = index;
		this.CurPreviewCharmId = ((SettingViewLeftCharmItemData)this.CharmItemDataList[index]).GetCharmId();
		((SettingViewLeftCharmItemData)this.CharmItemDataList[index]).Data.IsSelected = true;
		PhoneMsgCharmItem phoneMsgCharmItem2 = this.LeftScrollView.GetProxyByGridIndex(index) as PhoneMsgCharmItem;
		if (phoneMsgCharmItem2 != null)
		{
			phoneMsgCharmItem2.SetToggleState(true, false);
		}
		this.RefreshConfirmBtnOrGetLinkBtnShow();
		this.RefreshCharm();
	}

	// Token: 0x04009188 RID: 37256
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009189 RID: 37257
	private PhoneMsgSettingView.ETarget? CurTarget;

	// Token: 0x0400918A RID: 37258
	[Nullable(2)]
	private MultiTemplateScrollView LeftScrollView;

	// Token: 0x0400918B RID: 37259
	[Nullable(2)]
	private ButtonItem ConfirmBtn;

	// Token: 0x0400918C RID: 37260
	[Nullable(2)]
	private GetLinkBtn GetLinkBtn;

	// Token: 0x0400918D RID: 37261
	[Nullable(2)]
	private SettingPanelChatItem LeftChatItem;

	// Token: 0x0400918E RID: 37262
	[Nullable(2)]
	private SettingPanelChatRightItem RightChatItem;

	// Token: 0x0400918F RID: 37263
	[Nullable(2)]
	private PhoneSystemTopic TopicPanel;

	// Token: 0x04009190 RID: 37264
	private readonly List<IMultiTemplateGridData> DialogItemDataList = new List<IMultiTemplateGridData>();

	// Token: 0x04009191 RID: 37265
	private readonly List<IMultiTemplateGridData> BgItemDataList = new List<IMultiTemplateGridData>();

	// Token: 0x04009192 RID: 37266
	private readonly List<IMultiTemplateGridData> ThemeItemDataList = new List<IMultiTemplateGridData>();

	// Token: 0x04009193 RID: 37267
	private readonly List<IMultiTemplateGridData> CharmItemDataList = new List<IMultiTemplateGridData>();

	// Token: 0x04009194 RID: 37268
	private int CurPreviewDialogId;

	// Token: 0x04009195 RID: 37269
	private int CurSelectedDialogIndex = -1;

	// Token: 0x04009196 RID: 37270
	private int CurPreviewBgId;

	// Token: 0x04009197 RID: 37271
	private int CurSelectedBgIndex = -1;

	// Token: 0x04009198 RID: 37272
	private int CurPreviewThemeId;

	// Token: 0x04009199 RID: 37273
	private int CurSelectedThemeIndex = -1;

	// Token: 0x0400919A RID: 37274
	private int CurPreviewCharmId;

	// Token: 0x0400919B RID: 37275
	private int CurSelectedCharmIndex = -1;

	// Token: 0x02007C32 RID: 31794
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028396 RID: 164758
		ItemCaption,
		// Token: 0x04028397 RID: 164759
		PanelHLayout,
		// Token: 0x04028398 RID: 164760
		TogDialogTab,
		// Token: 0x04028399 RID: 164761
		TogBgTab,
		// Token: 0x0402839A RID: 164762
		LeftScroll,
		// Token: 0x0402839B RID: 164763
		Content,
		// Token: 0x0402839C RID: 164764
		TogBgItem,
		// Token: 0x0402839D RID: 164765
		TogDialogItem,
		// Token: 0x0402839E RID: 164766
		BtnConfirm,
		// Token: 0x0402839F RID: 164767
		TxtTitle,
		// Token: 0x040283A0 RID: 164768
		TexBg,
		// Token: 0x040283A1 RID: 164769
		TxtDesc,
		// Token: 0x040283A2 RID: 164770
		TxtGetWay,
		// Token: 0x040283A3 RID: 164771
		PlayerChatItem,
		// Token: 0x040283A4 RID: 164772
		TexChatBgDefault,
		// Token: 0x040283A5 RID: 164773
		PanelGetLink,
		// Token: 0x040283A6 RID: 164774
		BtnGetLink,
		// Token: 0x040283A7 RID: 164775
		NpcChatItem,
		// Token: 0x040283A8 RID: 164776
		TogDialogTabRedDot,
		// Token: 0x040283A9 RID: 164777
		TogBgTabRedDot,
		// Token: 0x040283AA RID: 164778
		TogThemeTab,
		// Token: 0x040283AB RID: 164779
		TogCharmTab,
		// Token: 0x040283AC RID: 164780
		TogThemeTabRedDot,
		// Token: 0x040283AD RID: 164781
		TogCharmTabRedDot,
		// Token: 0x040283AE RID: 164782
		PnlWindow,
		// Token: 0x040283AF RID: 164783
		PnlPhoneSystemTopic,
		// Token: 0x040283B0 RID: 164784
		TexSkinBg,
		// Token: 0x040283B1 RID: 164785
		TexSkinBgTopic
	}

	// Token: 0x02007C33 RID: 31795
	[NullableContext(0)]
	private enum ETarget
	{
		// Token: 0x040283B3 RID: 164787
		Dialog,
		// Token: 0x040283B4 RID: 164788
		Bg,
		// Token: 0x040283B5 RID: 164789
		Theme,
		// Token: 0x040283B6 RID: 164790
		Charm
	}
}
