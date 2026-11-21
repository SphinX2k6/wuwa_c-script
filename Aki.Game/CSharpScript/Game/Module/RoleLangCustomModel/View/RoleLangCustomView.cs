using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Module.RoleLangCustomModel.View.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View
{
	// Token: 0x02003D44 RID: 15684
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomView : UiTickViewBase
	{
		// Token: 0x060282AF RID: 164527 RVA: 0x00B3E299 File Offset: 0x00B3C499
		public RoleLangCustomView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060282B0 RID: 164528 RVA: 0x00B3E2C0 File Offset: 0x00B3C4C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedBtnRoleVoiceActing));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickedBtnFunctionDel));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060282B1 RID: 164529 RVA: 0x00B3E4FA File Offset: 0x00B3C6FA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RoleLangCustomRefresh, new Action<int>(this.OnRoleLangCustomRefresh));
		}

		// Token: 0x060282B2 RID: 164530 RVA: 0x00B3E518 File Offset: 0x00B3C718
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoleLangCustomRefresh, new Action<int>(this.OnRoleLangCustomRefresh));
		}

		// Token: 0x060282B3 RID: 164531 RVA: 0x00B3E538 File Offset: 0x00B3C738
		protected override UniTask OnBeforeStartAsync()
		{
			RoleLangCustomView.<OnBeforeStartAsync>d__30 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleLangCustomView.<OnBeforeStartAsync>d__30>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060282B4 RID: 164532 RVA: 0x00B3E57C File Offset: 0x00B3C77C
		protected override void OnStart()
		{
			this.FromRoleView = (MenuModel.Instance.GetMenuDataByFunctionId(53) == null);
			if (!this.FromRoleView)
			{
				ResourceManagerController.Instance.ChangeHttpTickFrequency();
			}
			this.CurRoleId = RoleLangCustomModel.Instance.RoleViewRoleId;
			RoleLangCustomModel.Instance.RoleViewRoleId = 0;
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedBtnClose));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickedBtnInfo));
			this.FilterRuleMap[RoleLangCustomView.filterTypeId] = new Dictionary<int, string>();
			this.FilterRuleMap[RoleLangCustomView.filterTypeLanguageId] = new Dictionary<int, string>();
			this.RoleList = RoleLangCustomModel.Instance.GetRoleList();
			this.TopElementScroll = new GenericScrollViewNew<RoleLangCustomElementTabItem, int>(base.GetScrollViewWithScrollbar(12), new Func<RoleLangCustomElementTabItem>(this.CreateTopElementItem), null, false, null);
			this.RoleItemScroll = new GenericScrollViewNew<RoleLangCustomRoleItem, RoleInstance>(base.GetScrollViewWithScrollbar(3), new Func<RoleLangCustomRoleItem>(this.CreateRoleItem), null, false, null);
			this.VoiceScroll = new GenericScrollViewNew<RoleLangCustomLangSelectItem, IRoleLangCustomLangSelectInfo>(base.GetScrollViewWithScrollbar(7), new Func<RoleLangCustomLangSelectItem>(this.CreateVoiceActingItem), null, false, null);
			this.ConfirmBtn = new ButtonItem(base.GetItem(10));
			this.ConfirmBtn.SetFunction(new Action<int>(this.OnClickedBtnConfirmB));
			bool uiactive = RoleLangCustomModel.Instance.NeedDeleteButton();
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive);
			}
			UUIButtonComponent button2 = base.GetButton(11);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(uiactive);
			}
			this.InitTab();
		}

		// Token: 0x060282B5 RID: 164533 RVA: 0x00B3E725 File Offset: 0x00B3C925
		protected override void OnAfterShow()
		{
			RoleLangCustomModel.Instance.CheckServerVoiceDataSame(true);
		}

		// Token: 0x060282B6 RID: 164534 RVA: 0x00B3E733 File Offset: 0x00B3C933
		protected override void OnBeforeDestroy()
		{
			if (this.FromRoleView)
			{
				if (MenuModel.Instance.GetMenuDataByFunctionId(53) != null)
				{
					MenuModel.Instance.ClearMenuDataMap();
				}
			}
			else
			{
				ResourceManagerController.Instance.RestoreHttpTickFrequency();
			}
			this.StopCurrentAudioEvent("OnBeforeDestroy");
		}

		// Token: 0x060282B7 RID: 164535 RVA: 0x00B3E770 File Offset: 0x00B3C970
		protected override void OnTick(float delta)
		{
			List<RoleLangCustomLangSelectItem> scrollItemList = this.VoiceScroll.GetScrollItemList();
			bool flag = false;
			foreach (RoleLangCustomLangSelectItem roleLangCustomLangSelectItem in scrollItemList)
			{
				flag = (roleLangCustomLangSelectItem.OnTick(delta) || flag);
			}
			if (flag)
			{
				this.OnVoiceItemToggleStateChanged(this.CurStateData);
			}
		}

		// Token: 0x060282B8 RID: 164536 RVA: 0x00B3E7DC File Offset: 0x00B3C9DC
		protected void InitTab()
		{
			this.CurElement = -1;
			FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(1);
			List<int> list = new List<int>
			{
				0
			};
			foreach (int item in filterRuleConfig.Value.IdListIter())
			{
				list.Add(item);
			}
			this.TopElementScroll.RefreshByData(list, delegate
			{
				this.TopElementScroll.GetScrollItemList()[0].SetSelected(true, true);
				if (this.CurRoleId != 0)
				{
					this.OnRoleItemToggleStateChanged(this.CurRoleId);
				}
			}, false);
		}

		// Token: 0x060282B9 RID: 164537 RVA: 0x00B3E870 File Offset: 0x00B3CA70
		protected void RefreshVoiceItemButtonState()
		{
			foreach (RoleLangCustomLangSelectItem roleLangCustomLangSelectItem in this.VoiceScroll.GetScrollItemList())
			{
				roleLangCustomLangSelectItem.RefreshButtonState();
			}
		}

		// Token: 0x060282BA RID: 164538 RVA: 0x00B3E8C8 File Offset: 0x00B3CAC8
		protected unsafe void StopCurrentAudioEvent(string debugReason)
		{
			int? currentAudioPlayId = this.CurrentAudioPlayId;
			this.CurrentAudioPlayId = null;
			this.CurrentIsPlayingInfo = null;
			if (!string.IsNullOrEmpty(this.OldAudioCode))
			{
				string roleLangStateGroup = RoleConfig.Instance.GetRoleLangStateGroup(this.OldCodeRoleId.Value);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Role;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[RoleLangCustomDebug] RestoreLanguage";
				<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", debugReason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentPlayId", currentAudioPlayId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("roleId", this.OldCodeRoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("stateGroup", roleLangStateGroup);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("state", this.OldAudioCode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("check", false);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("currentHandle", this.PlayAudioHandle);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
				AudioSystem.Instance.SetState(roleLangStateGroup, this.OldAudioCode, false);
			}
			if (this.PlayAudioHandle != null && this.PlayAudioHandle.Value != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlayAudioHandle.Value, EAudioActionType.Stop, null);
			}
			this.PlayAudioHandle = null;
			this.OldAudioCode = null;
			this.OldCodeRoleId = null;
		}

		// Token: 0x060282BB RID: 164539 RVA: 0x00B3EA70 File Offset: 0x00B3CC70
		protected void RefreshConfirmBtn()
		{
			IRoleLangCustomLangSelectInfo curStateData = this.CurStateData;
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = curStateData.RoleId,
				LangIndex = curStateData.LangIndex
			};
			switch (RoleLangCustomModel.Instance.GetDownloadStatus(info))
			{
			case ELanguageDownloadStatus.None:
			{
				ButtonItem confirmBtn = this.ConfirmBtn;
				if (confirmBtn != null)
				{
					confirmBtn.SetEnableClick(true);
				}
				ButtonItem confirmBtn2 = this.ConfirmBtn;
				if (confirmBtn2 == null)
				{
					return;
				}
				confirmBtn2.SetShowText("Btn_Download_VoiceDIY");
				return;
			}
			case ELanguageDownloadStatus.Half:
				if (RoleLangCustomModel.Instance.GetUpdateManager().IsDownloading(info))
				{
					ButtonItem confirmBtn3 = this.ConfirmBtn;
					if (confirmBtn3 != null)
					{
						confirmBtn3.SetEnableClick(false);
					}
					ButtonItem confirmBtn4 = this.ConfirmBtn;
					if (confirmBtn4 == null)
					{
						return;
					}
					confirmBtn4.SetShowText("Btn_Downloading_VoiceDIY");
					return;
				}
				else
				{
					ButtonItem confirmBtn5 = this.ConfirmBtn;
					if (confirmBtn5 != null)
					{
						confirmBtn5.SetEnableClick(true);
					}
					ButtonItem confirmBtn6 = this.ConfirmBtn;
					if (confirmBtn6 == null)
					{
						return;
					}
					confirmBtn6.SetShowText("Btn_Download_VoiceDIY");
					return;
				}
				break;
			case ELanguageDownloadStatus.Done:
			{
				bool flag = RoleLangCustomModel.Instance.GetRoleLangType(curStateData.RoleId) == curStateData.LangIndex;
				ButtonItem confirmBtn7 = this.ConfirmBtn;
				if (confirmBtn7 != null)
				{
					confirmBtn7.SetEnableClick(!flag);
				}
				string showText = flag ? "Btn_Applying_VoiceDIY" : "Btn_Apply_VoiceDIY";
				ButtonItem confirmBtn8 = this.ConfirmBtn;
				if (confirmBtn8 == null)
				{
					return;
				}
				confirmBtn8.SetShowText(showText);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x060282BC RID: 164540 RVA: 0x00B3EB9C File Offset: 0x00B3CD9C
		private void OnClickedBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060282BD RID: 164541 RVA: 0x00B3EBA8 File Offset: 0x00B3CDA8
		private void OnClickedBtnRoleVoiceActing()
		{
			if (this.FromRoleView && MenuModel.Instance.GetMenuDataByFunctionId(53) == null)
			{
				MenuModel.Instance.CreateConfigByBaseConfig();
			}
			UiManager instance = UiManager.Instance;
			EUiViewName voiceLanguageDownloadView = EUiViewName.VoiceLanguageDownloadView;
			object[] array = new object[2];
			array[0] = MenuModel.Instance.GetMenuDataByFunctionId(53);
			instance.OpenView(voiceLanguageDownloadView, array, null);
		}

		// Token: 0x060282BE RID: 164542 RVA: 0x00B3EC00 File Offset: 0x00B3CE00
		private void OnClickedBtnConfirmB(int id)
		{
			switch (RoleLangCustomModel.Instance.GetDownloadStatus(new RoleLangCustomLangPackageInfo
			{
				RoleId = this.CurRoleId,
				LangIndex = this.CurVoiceIndex
			}))
			{
			case ELanguageDownloadStatus.None:
			{
				if (RoleLangCustomModel.Instance.CheckPackageAudioDownloading(this.CurVoiceIndex))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("VoiceDIY_Tips_DownloadingEntireVoice", Array.Empty<object>());
					return;
				}
				RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
				{
					RoleId = this.CurRoleId,
					LangIndex = this.CurVoiceIndex
				};
				RoleLangCustomModel.Instance.StartDownloading(info);
				this.SetCurStateItemNeedTick();
				return;
			}
			case ELanguageDownloadStatus.Half:
			{
				RoleLangCustomLangPackageInfo info2 = new RoleLangCustomLangPackageInfo
				{
					RoleId = this.CurRoleId,
					LangIndex = this.CurVoiceIndex
				};
				if (RoleLangCustomModel.Instance.GetUpdateManager().IsDownloading(info2))
				{
					return;
				}
				this.SetCurStateItemNeedTick();
				RoleLangCustomModel.Instance.StartDownloading(info2);
				return;
			}
			case ELanguageDownloadStatus.Done:
			{
				this.StopCurrentAudioEvent("ApplyVoice");
				RoleLangSetVoiceParam playerVoice = new RoleLangSetVoiceParam
				{
					RoleId = this.CurRoleId,
					Lang = this.CurVoiceIndex,
					NeedRequest = true,
					IsCustom = true,
					IsCover = false
				};
				RoleLangCustomModel.Instance.SetPlayerVoice(playerVoice);
				ScrollingTipsController.Instance.ShowTipsByTextId("Notice_VoiceDIY_Setting_Success", Array.Empty<object>());
				this.PlayAudioHandle = new int?(RoleLangCustomModel.Instance.PlayVoiceOnSetVoice(this.CurRoleId));
				this.RefreshVoiceItemButtonState();
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x060282BF RID: 164543 RVA: 0x00B3ED60 File Offset: 0x00B3CF60
		private void SetCurStateItemNeedTick()
		{
			foreach (RoleLangCustomLangSelectItem roleLangCustomLangSelectItem in this.VoiceScroll.GetScrollItemList())
			{
				if (roleLangCustomLangSelectItem.ItemData.RoleId == this.CurStateData.RoleId && roleLangCustomLangSelectItem.ItemData.LangIndex == this.CurStateData.LangIndex)
				{
					roleLangCustomLangSelectItem.SetNeedTick(true);
					break;
				}
			}
		}

		// Token: 0x060282C0 RID: 164544 RVA: 0x00B3EDEC File Offset: 0x00B3CFEC
		private void OnClickedBtnFunctionDel()
		{
			RoleLangCustomDeleteInfo param = new RoleLangCustomDeleteInfo
			{
				RoleId = this.CurRoleId,
				RefreshCallback = delegate
				{
					this.OnRoleLangCustomRefresh(this.CurRoleId);
				},
				CloseCallback = new Action(this.OnCloseDelete)
			};
			UiManager.Instance.OpenView(EUiViewName.RoleLangRemoveView, param, null);
			base.GetScrollViewWithScrollbar(7).RootUIComp.Get().SetAlpha(0f);
		}

		// Token: 0x060282C1 RID: 164545 RVA: 0x00B3EE60 File Offset: 0x00B3D060
		private void OnCloseDelete()
		{
			base.GetScrollViewWithScrollbar(7).RootUIComp.Get().SetAlpha(1f);
		}

		// Token: 0x060282C2 RID: 164546 RVA: 0x00B3EE8B File Offset: 0x00B3D08B
		private RoleLangCustomElementTabItem CreateTopElementItem()
		{
			return new RoleLangCustomElementTabItem
			{
				OnToggleStateChangedCallback = new Action<int>(this.OnTopElementItemToggleStateChanged),
				OnToggleSelectedCheck = new Func<int, bool>(this.CheckTopElementItemSelectedCallback)
			};
		}

		// Token: 0x060282C3 RID: 164547 RVA: 0x00B3EEB8 File Offset: 0x00B3D0B8
		private void OnTopElementItemToggleStateChanged(int elementId)
		{
			this.CurElement = elementId;
			if (elementId == 0)
			{
				this.FilterRuleMap[RoleLangCustomView.filterTypeId].Clear();
			}
			else
			{
				this.FilterRuleMap[RoleLangCustomView.filterTypeId].Clear();
				this.FilterRuleMap[RoleLangCustomView.filterTypeId][elementId] = "";
			}
			List<RoleInstance> result = FilterModel.Instance.GetFilterList<RoleInstance>(this.RoleList, (int)RoleLangCustomView.filterGroupId, this.FilterRuleMap);
			bool flag = result.Count == 0;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			this.RoleItemScroll.SetActive(!flag);
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			foreach (RoleLangCustomElementTabItem roleLangCustomElementTabItem in this.TopElementScroll.GetScrollItemList())
			{
				roleLangCustomElementTabItem.RefreshSelected();
			}
			this.RoleItemScroll.RefreshByData(result, delegate
			{
				bool flag2 = false;
				int index = 0;
				for (int i = 0; i < result.Count; i++)
				{
					if (result[i].GetRoleId() == this.CurRoleId)
					{
						flag2 = true;
						index = i;
						break;
					}
				}
				if (!flag2 && result.Count > 0)
				{
					this.CurRoleId = result[0].GetRoleId();
					RoleLangCustomRoleItem scrollItemByIndex = this.RoleItemScroll.GetScrollItemByIndex(0);
					if (scrollItemByIndex != null)
					{
						scrollItemByIndex.SetSelected(true, true);
					}
				}
				UUIItem itemByIndex = this.RoleItemScroll.GetItemByIndex(index);
				this.GetScrollViewWithScrollbar(3).ScrollToTopLater(itemByIndex, false);
			}, true);
		}

		// Token: 0x060282C4 RID: 164548 RVA: 0x00B3EFF4 File Offset: 0x00B3D1F4
		private bool CheckTopElementItemSelectedCallback(int elementId)
		{
			return elementId == this.CurElement;
		}

		// Token: 0x060282C5 RID: 164549 RVA: 0x00B3EFFF File Offset: 0x00B3D1FF
		private RoleLangCustomRoleItem CreateRoleItem()
		{
			return new RoleLangCustomRoleItem
			{
				OnToggleStateChangedCallback = new Action<int>(this.OnRoleItemToggleStateChanged),
				OnToggleSelectedCheck = new Func<int, bool>(this.CheckRoleSelectedCallback)
			};
		}

		// Token: 0x060282C6 RID: 164550 RVA: 0x00B3F02C File Offset: 0x00B3D22C
		private void OnRoleItemToggleStateChanged(int roleId)
		{
			this.CurRoleId = roleId;
			this.CurVoiceIndex = RoleLangCustomModel.Instance.GetRoleLangType(roleId);
			List<int> allLanguageTypeForAudio = LanguageUpdateManager.Instance.GetAllLanguageTypeForAudio();
			allLanguageTypeForAudio.Sort((int a, int b) => a - b);
			List<IRoleLangCustomLangSelectInfo> list = new List<IRoleLangCustomLangSelectInfo>();
			foreach (int num in allLanguageTypeForAudio)
			{
				RoleLangCustomLangSelectInfo roleLangCustomLangSelectInfo = new RoleLangCustomLangSelectInfo
				{
					RoleId = roleId,
					LangIndex = num
				};
				if (num == this.CurVoiceIndex)
				{
					this.CurStateData = roleLangCustomLangSelectInfo;
				}
				list.Add(roleLangCustomLangSelectInfo);
			}
			this.StopCurrentAudioEvent("ChangeRole");
			this.CurrentIsPlayingInfo = null;
			this.VoiceScroll.RefreshByData(list, null, false);
			ButtonItem confirmBtn = this.ConfirmBtn;
			if (confirmBtn != null)
			{
				confirmBtn.SetEnableClick(false);
			}
			ButtonItem confirmBtn2 = this.ConfirmBtn;
			if (confirmBtn2 != null)
			{
				confirmBtn2.SetShowText("Btn_Applying_VoiceDIY");
			}
			foreach (RoleLangCustomRoleItem roleLangCustomRoleItem in this.RoleItemScroll.GetScrollItemList())
			{
				roleLangCustomRoleItem.RefreshByData();
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
			if (RoleModel.Instance.IsMainRole(roleId))
			{
				UUIText text = base.GetText(6);
				if (text == null)
				{
					return;
				}
				text.SetText(FunctionModel.Instance.GetPlayerName() ?? "", true);
				return;
			}
			else
			{
				UUIText text2 = base.GetText(6);
				if (text2 == null)
				{
					return;
				}
				text2.ShowTextNew(roleConfig.Value.Name);
				return;
			}
		}

		// Token: 0x060282C7 RID: 164551 RVA: 0x00B3F1DC File Offset: 0x00B3D3DC
		private bool CheckRoleSelectedCallback(int roleId)
		{
			return roleId == this.CurRoleId;
		}

		// Token: 0x060282C8 RID: 164552 RVA: 0x00B3F1E8 File Offset: 0x00B3D3E8
		private RoleLangCustomLangSelectItem CreateVoiceActingItem()
		{
			return new RoleLangCustomLangSelectItem
			{
				OnToggleStateChangedCallback = new Action<IRoleLangCustomLangSelectInfo>(this.OnVoiceItemToggleStateChanged),
				OnToggleSelectedCheck = new Func<IRoleLangCustomLangSelectInfo, bool>(this.CheckVoiceSelectedCallback),
				CheckCurrentIsPlayingCallback = new Func<IRoleLangCustomLangSelectInfo, bool>(this.CheckVoiceCurrentIsPlayingCallback),
				OnPlayAudioCallback = new Action<IRoleLangCustomLangSelectInfo>(this.OnPlayAudio)
			};
		}

		// Token: 0x060282C9 RID: 164553 RVA: 0x00B3F244 File Offset: 0x00B3D444
		private void OnVoiceItemToggleStateChanged(IRoleLangCustomLangSelectInfo data)
		{
			this.CurVoiceIndex = data.LangIndex;
			this.CurStateData = data;
			this.RefreshConfirmBtn();
			foreach (RoleLangCustomLangSelectItem roleLangCustomLangSelectItem in this.VoiceScroll.GetScrollItemList())
			{
				roleLangCustomLangSelectItem.SetSelected(this.CheckVoiceSelectedCallback(roleLangCustomLangSelectItem.ItemData), false);
			}
		}

		// Token: 0x060282CA RID: 164554 RVA: 0x00B3F2C4 File Offset: 0x00B3D4C4
		private bool CheckVoiceCurrentIsPlayingCallback(IRoleLangCustomLangSelectInfo data)
		{
			return this.PlayAudioHandle != null && data == this.CurrentIsPlayingInfo;
		}

		// Token: 0x060282CB RID: 164555 RVA: 0x00B3F2E0 File Offset: 0x00B3D4E0
		private unsafe void OnPlayAudio(IRoleLangCustomLangSelectInfo data)
		{
			RoleLangCustomView.<>c__DisplayClass54_0 CS$<>8__locals1 = new RoleLangCustomView.<>c__DisplayClass54_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			bool flag = CS$<>8__locals1.data == this.CurrentIsPlayingInfo;
			this.StopCurrentAudioEvent(flag ? "OnPlayAudio.Pause" : "OnPlayAudio.Play");
			this.RefreshVoiceItemButtonState();
			if (flag)
			{
				return;
			}
			this.CurrentIsPlayingInfo = CS$<>8__locals1.data;
			int roleLangType = RoleLangCustomModel.Instance.GetRoleLangType(CS$<>8__locals1.data.RoleId);
			this.OldAudioCode = LanguageSystem.Instance.GetLanguageDefineByType(roleLangType).AudioCode;
			this.OldCodeRoleId = new int?(CS$<>8__locals1.data.RoleId);
			int langIndex = CS$<>8__locals1.data.LangIndex;
			global::LanguageDefine languageDefineByType = LanguageSystem.Instance.GetLanguageDefineByType(langIndex);
			string roleLangStateGroup = RoleConfig.Instance.GetRoleLangStateGroup(CS$<>8__locals1.data.RoleId);
			RoleLangCustomView.<>c__DisplayClass54_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.AudioPlayId + 1;
			this.AudioPlayId = num;
			CS$<>8__locals2.playId = num;
			this.CurrentAudioPlayId = new int?(CS$<>8__locals1.playId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "[RoleLangCustomDebug] SetTemporaryLanguage";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("playId", CS$<>8__locals1.playId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleId", CS$<>8__locals1.data.RoleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("langIndex", CS$<>8__locals1.data.LangIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("stateGroup", roleLangStateGroup);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("state", languageDefineByType.AudioCode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("oldState", this.OldAudioCode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("check", false);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			AudioSystem.Instance.SetState(roleLangStateGroup, languageDefineByType.AudioCode, false);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(CS$<>8__locals1.data.RoleId, true);
			RoleSkinAudio? roleConfig = AudioConfig.Instance.GetRoleConfig(roleDataById.GetRoleSkinId());
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Role;
			ELogAuthor author2 = ELogAuthor.WHJ;
			string message2 = "[RoleLangCustomDebug] PostEvent.Request";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("playId", CS$<>8__locals1.playId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("roleId", CS$<>8__locals1.data.RoleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("langIndex", CS$<>8__locals1.data.LangIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("event", roleConfig.Value.JoinTeamEvent);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("stateGroup", roleLangStateGroup);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("requestedState", languageDefineByType.AudioCode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("callbackMask", ECallbackMask.EndOfEvent);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 7));
			this.PlayAudioHandle = new int?(AudioSystem.Instance.PostEvent(roleConfig.Value.JoinTeamEvent, null, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Role;
					ELogAuthor author4 = ELogAuthor.WHJ;
					string message4 = "[RoleLangCustomDebug] PostEvent.Callback";
					<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray8<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("callbackPlayId", CS$<>8__locals1.playId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("currentPlayId", CS$<>8__locals1.<>4__this.CurrentAudioPlayId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("callbackType", callbackType);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3);
					string item = "playingId";
					UAkEventCallbackInfo uakEventCallbackInfo = callbackInfo as UAkEventCallbackInfo;
					ptr = new ValueTuple<string, object>(item, (uakEventCallbackInfo != null) ? new int?(uakEventCallbackInfo.PlayingID) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("roleId", CS$<>8__locals1.data.RoleId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 5) = new ValueTuple<string, object>("langIndex", CS$<>8__locals1.data.LangIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 6) = new ValueTuple<string, object>("currentHandle", CS$<>8__locals1.<>4__this.PlayAudioHandle);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 7);
					string item2 = "ignored";
					int playId = CS$<>8__locals1.playId;
					int? currentAudioPlayId = CS$<>8__locals1.<>4__this.CurrentAudioPlayId;
					ptr2 = new ValueTuple<string, object>(item2, !(playId == currentAudioPlayId.GetValueOrDefault() & currentAudioPlayId != null));
					instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 8));
					int playId2 = CS$<>8__locals1.playId;
					currentAudioPlayId = CS$<>8__locals1.<>4__this.CurrentAudioPlayId;
					if (!(playId2 == currentAudioPlayId.GetValueOrDefault() & currentAudioPlayId != null))
					{
						return;
					}
					if (callbackType == EAkCallbackType.EndOfEvent)
					{
						CS$<>8__locals1.<>4__this.PlayAudioHandle = null;
						CS$<>8__locals1.<>4__this.StopCurrentAudioEvent("EndOfEvent");
						CS$<>8__locals1.<>4__this.RefreshVoiceItemButtonState();
					}
				}
			})));
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Role;
			ELogAuthor author3 = ELogAuthor.WHJ;
			string message3 = "[RoleLangCustomDebug] PostEvent.Return";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("playId", CS$<>8__locals1.playId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("handle", this.PlayAudioHandle);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
		}

		// Token: 0x060282CC RID: 164556 RVA: 0x00B3F6E9 File Offset: 0x00B3D8E9
		private bool CheckVoiceSelectedCallback(IRoleLangCustomLangSelectInfo data)
		{
			return this.CurVoiceIndex == data.LangIndex;
		}

		// Token: 0x060282CD RID: 164557 RVA: 0x00B3F6F9 File Offset: 0x00B3D8F9
		private void OnRoleLangCustomRefresh(int roleId)
		{
			if (roleId != this.CurRoleId && roleId != -1)
			{
				return;
			}
			this.OnRoleItemToggleStateChanged(this.CurRoleId);
		}

		// Token: 0x060282CE RID: 164558 RVA: 0x00B3F715 File Offset: 0x00B3D915
		private void OnClickedBtnInfo()
		{
			HelpController.Instance.OpenHelpById(615);
		}

		// Token: 0x060282CF RID: 164559 RVA: 0x00B3F728 File Offset: 0x00B3D928
		private void OnChangeLanguageFilter(int langType)
		{
			if (langType < 0)
			{
				this.FilterRuleMap[RoleLangCustomView.filterTypeLanguageId].Clear();
			}
			else
			{
				this.FilterRuleMap[RoleLangCustomView.filterTypeLanguageId].Clear();
				this.FilterRuleMap[RoleLangCustomView.filterTypeLanguageId][langType] = "";
			}
			List<RoleInstance> result = FilterModel.Instance.GetFilterList<RoleInstance>(this.RoleList, (int)RoleLangCustomView.filterGroupId, this.FilterRuleMap);
			bool flag = result.Count == 0;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			this.RoleItemScroll.SetActive(!flag);
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			foreach (RoleLangCustomElementTabItem roleLangCustomElementTabItem in this.TopElementScroll.GetScrollItemList())
			{
				roleLangCustomElementTabItem.RefreshSelected();
			}
			this.RoleItemScroll.RefreshByData(result, delegate
			{
				bool flag2 = false;
				using (List<RoleInstance>.Enumerator enumerator2 = result.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.GetRoleId() == this.CurRoleId)
						{
							flag2 = true;
							break;
						}
					}
				}
				if (!flag2 && result.Count > 0)
				{
					this.CurRoleId = result[0].GetRoleId();
					RoleLangCustomRoleItem scrollItemByIndex = this.RoleItemScroll.GetScrollItemByIndex(0);
					if (scrollItemByIndex == null)
					{
						return;
					}
					scrollItemByIndex.SetSelected(true, true);
				}
			}, true);
		}

		// Token: 0x04015D20 RID: 89376
		private const int HELP_ID = 615;

		// Token: 0x04015D21 RID: 89377
		private const int FILTER_RULE_ID = 1;

		// Token: 0x04015D22 RID: 89378
		private static readonly EFilterSortGroupId filterGroupId = EFilterSortGroupId.Role;

		// Token: 0x04015D23 RID: 89379
		private static readonly FilterDefine.EFilterType filterTypeId = FilterDefine.EFilterType.Element;

		// Token: 0x04015D24 RID: 89380
		private static readonly FilterDefine.EFilterType filterTypeLanguageId = FilterDefine.EFilterType.RoleLangCustomType;

		// Token: 0x04015D25 RID: 89381
		private const int FILTER_ALL_ID = 0;

		// Token: 0x04015D26 RID: 89382
		protected int CurElement = -1;

		// Token: 0x04015D27 RID: 89383
		protected int CurRoleId;

		// Token: 0x04015D28 RID: 89384
		protected int CurVoiceIndex;

		// Token: 0x04015D29 RID: 89385
		protected IRoleLangCustomLangSelectInfo CurStateData;

		// Token: 0x04015D2A RID: 89386
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04015D2B RID: 89387
		protected RoleLangCustomLangFilter RoleCustomItem;

		// Token: 0x04015D2C RID: 89388
		protected GenericScrollViewNew<RoleLangCustomElementTabItem, int> TopElementScroll;

		// Token: 0x04015D2D RID: 89389
		protected GenericScrollViewNew<RoleLangCustomRoleItem, RoleInstance> RoleItemScroll;

		// Token: 0x04015D2E RID: 89390
		protected GenericScrollViewNew<RoleLangCustomLangSelectItem, IRoleLangCustomLangSelectInfo> VoiceScroll;

		// Token: 0x04015D2F RID: 89391
		protected List<RoleInstance> RoleList = new List<RoleInstance>();

		// Token: 0x04015D30 RID: 89392
		protected Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> FilterRuleMap = new Dictionary<FilterDefine.EFilterType, Dictionary<int, string>>();

		// Token: 0x04015D31 RID: 89393
		[Nullable(2)]
		protected IRoleLangCustomLangSelectInfo CurrentIsPlayingInfo;

		// Token: 0x04015D32 RID: 89394
		protected int? PlayAudioHandle;

		// Token: 0x04015D33 RID: 89395
		[Nullable(2)]
		protected string OldAudioCode;

		// Token: 0x04015D34 RID: 89396
		protected int? OldCodeRoleId;

		// Token: 0x04015D35 RID: 89397
		private int AudioPlayId;

		// Token: 0x04015D36 RID: 89398
		private int? CurrentAudioPlayId;

		// Token: 0x04015D37 RID: 89399
		[Nullable(2)]
		protected ButtonItem ConfirmBtn;

		// Token: 0x04015D38 RID: 89400
		protected bool FromRoleView;

		// Token: 0x0200991E RID: 39198
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0402FC2E RID: 195630
			Caption,
			// Token: 0x0402FC2F RID: 195631
			BtnRoleVoiceActing,
			// Token: 0x0402FC30 RID: 195632
			PanelEmpty,
			// Token: 0x0402FC31 RID: 195633
			RoleItemScroll,
			// Token: 0x0402FC32 RID: 195634
			RoleVoiceActingCardItem,
			// Token: 0x0402FC33 RID: 195635
			PanelRight,
			// Token: 0x0402FC34 RID: 195636
			TxtTitle,
			// Token: 0x0402FC35 RID: 195637
			VoiceActingItemScroll,
			// Token: 0x0402FC36 RID: 195638
			VoiceActingItem,
			// Token: 0x0402FC37 RID: 195639
			RoleVoiceSort,
			// Token: 0x0402FC38 RID: 195640
			BtnConfirmB,
			// Token: 0x0402FC39 RID: 195641
			BtnFunctionDel,
			// Token: 0x0402FC3A RID: 195642
			TopMenuItemScroll
		}
	}
}
