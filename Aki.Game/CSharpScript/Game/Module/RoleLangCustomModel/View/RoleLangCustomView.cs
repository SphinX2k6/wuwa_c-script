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
	// Token: 0x02004D7B RID: 19835
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomView : UiTickViewBase
	{
		// Token: 0x06033441 RID: 209985 RVA: 0x00BF5079 File Offset: 0x00BF3279
		public RoleLangCustomView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033442 RID: 209986 RVA: 0x00BF50A8 File Offset: 0x00BF32A8
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

		// Token: 0x06033443 RID: 209987 RVA: 0x00BF52E2 File Offset: 0x00BF34E2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RoleLangCustomRefresh, new Action<int>(this.OnRoleLangCustomRefresh));
		}

		// Token: 0x06033444 RID: 209988 RVA: 0x00BF5300 File Offset: 0x00BF3500
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoleLangCustomRefresh, new Action<int>(this.OnRoleLangCustomRefresh));
		}

		// Token: 0x06033445 RID: 209989 RVA: 0x00BF5320 File Offset: 0x00BF3520
		protected override UniTask OnBeforeStartAsync()
		{
			RoleLangCustomView.<OnBeforeStartAsync>d__29 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleLangCustomView.<OnBeforeStartAsync>d__29>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033446 RID: 209990 RVA: 0x00BF5364 File Offset: 0x00BF3564
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

		// Token: 0x06033447 RID: 209991 RVA: 0x00BF550D File Offset: 0x00BF370D
		protected override void OnAfterShow()
		{
			RoleLangCustomModel.Instance.CheckServerVoiceDataSame(true);
		}

		// Token: 0x06033448 RID: 209992 RVA: 0x00BF551B File Offset: 0x00BF371B
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
			this.StopCurrentAudioEvent();
		}

		// Token: 0x06033449 RID: 209993 RVA: 0x00BF5554 File Offset: 0x00BF3754
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

		// Token: 0x0603344A RID: 209994 RVA: 0x00BF55C0 File Offset: 0x00BF37C0
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

		// Token: 0x0603344B RID: 209995 RVA: 0x00BF5654 File Offset: 0x00BF3854
		protected void RefreshVoiceItemButtonState()
		{
			foreach (RoleLangCustomLangSelectItem roleLangCustomLangSelectItem in this.VoiceScroll.GetScrollItemList())
			{
				roleLangCustomLangSelectItem.RefreshButtonState();
			}
		}

		// Token: 0x0603344C RID: 209996 RVA: 0x00BF56AC File Offset: 0x00BF38AC
		protected void StopCurrentAudioEvent()
		{
			if (!string.IsNullOrEmpty(this.OldAudioCode))
			{
				string roleLangStateGroup = RoleConfig.Instance.GetRoleLangStateGroup(this.OldCodeRoleId.Value);
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

		// Token: 0x0603344D RID: 209997 RVA: 0x00BF5748 File Offset: 0x00BF3948
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

		// Token: 0x0603344E RID: 209998 RVA: 0x00BF5874 File Offset: 0x00BF3A74
		private void OnClickedBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603344F RID: 209999 RVA: 0x00BF5880 File Offset: 0x00BF3A80
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

		// Token: 0x06033450 RID: 210000 RVA: 0x00BF58D8 File Offset: 0x00BF3AD8
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
				this.StopCurrentAudioEvent();
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
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06033451 RID: 210001 RVA: 0x00BF5A30 File Offset: 0x00BF3C30
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

		// Token: 0x06033452 RID: 210002 RVA: 0x00BF5ABC File Offset: 0x00BF3CBC
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

		// Token: 0x06033453 RID: 210003 RVA: 0x00BF5B30 File Offset: 0x00BF3D30
		private void OnCloseDelete()
		{
			base.GetScrollViewWithScrollbar(7).RootUIComp.Get().SetAlpha(1f);
		}

		// Token: 0x06033454 RID: 210004 RVA: 0x00BF5B5B File Offset: 0x00BF3D5B
		private RoleLangCustomElementTabItem CreateTopElementItem()
		{
			return new RoleLangCustomElementTabItem
			{
				OnToggleStateChangedCallback = new Action<int>(this.OnTopElementItemToggleStateChanged),
				OnToggleSelectedCheck = new Func<int, bool>(this.CheckTopElementItemSelectedCallback)
			};
		}

		// Token: 0x06033455 RID: 210005 RVA: 0x00BF5B88 File Offset: 0x00BF3D88
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

		// Token: 0x06033456 RID: 210006 RVA: 0x00BF5CC4 File Offset: 0x00BF3EC4
		private bool CheckTopElementItemSelectedCallback(int elementId)
		{
			return elementId == this.CurElement;
		}

		// Token: 0x06033457 RID: 210007 RVA: 0x00BF5CCF File Offset: 0x00BF3ECF
		private RoleLangCustomRoleItem CreateRoleItem()
		{
			return new RoleLangCustomRoleItem
			{
				OnToggleStateChangedCallback = new Action<int>(this.OnRoleItemToggleStateChanged),
				OnToggleSelectedCheck = new Func<int, bool>(this.CheckRoleSelectedCallback)
			};
		}

		// Token: 0x06033458 RID: 210008 RVA: 0x00BF5CFC File Offset: 0x00BF3EFC
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
			this.StopCurrentAudioEvent();
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

		// Token: 0x06033459 RID: 210009 RVA: 0x00BF5EA8 File Offset: 0x00BF40A8
		private bool CheckRoleSelectedCallback(int roleId)
		{
			return roleId == this.CurRoleId;
		}

		// Token: 0x0603345A RID: 210010 RVA: 0x00BF5EB4 File Offset: 0x00BF40B4
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

		// Token: 0x0603345B RID: 210011 RVA: 0x00BF5F10 File Offset: 0x00BF4110
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

		// Token: 0x0603345C RID: 210012 RVA: 0x00BF5F90 File Offset: 0x00BF4190
		private bool CheckVoiceCurrentIsPlayingCallback(IRoleLangCustomLangSelectInfo data)
		{
			return this.PlayAudioHandle != null && data == this.CurrentIsPlayingInfo;
		}

		// Token: 0x0603345D RID: 210013 RVA: 0x00BF5FAC File Offset: 0x00BF41AC
		private void OnPlayAudio(IRoleLangCustomLangSelectInfo data)
		{
			this.StopCurrentAudioEvent();
			if (data == this.CurrentIsPlayingInfo)
			{
				this.CurrentIsPlayingInfo = null;
				return;
			}
			if (this.CurrentIsPlayingInfo != null)
			{
				this.IsNormalEnd = false;
				this.StopCurrentAudioEvent();
				this.RefreshVoiceItemButtonState();
			}
			this.CurrentIsPlayingInfo = data;
			int roleLangType = RoleLangCustomModel.Instance.GetRoleLangType(data.RoleId);
			this.OldAudioCode = LanguageSystem.Instance.GetLanguageDefineByType(roleLangType).AudioCode;
			this.OldCodeRoleId = new int?(data.RoleId);
			int langIndex = data.LangIndex;
			global::LanguageDefine languageDefineByType = LanguageSystem.Instance.GetLanguageDefineByType(langIndex);
			string roleLangStateGroup = RoleConfig.Instance.GetRoleLangStateGroup(data.RoleId);
			AudioSystem.Instance.SetState(roleLangStateGroup, languageDefineByType.AudioCode, false);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(data.RoleId, true);
			RoleSkinAudio? roleConfig = AudioConfig.Instance.GetRoleConfig(roleDataById.GetRoleSkinId());
			this.PlayAudioHandle = new int?(AudioSystem.Instance.PostEvent(roleConfig.Value.JoinTeamEvent, null, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (callbackType == EAkCallbackType.EndOfEvent && this.IsNormalEnd)
					{
						this.PlayAudioHandle = null;
						this.StopCurrentAudioEvent();
						this.RefreshVoiceItemButtonState();
						this.CurrentIsPlayingInfo = null;
					}
					this.IsNormalEnd = true;
				}
			})));
		}

		// Token: 0x0603345E RID: 210014 RVA: 0x00BF60DD File Offset: 0x00BF42DD
		private bool CheckVoiceSelectedCallback(IRoleLangCustomLangSelectInfo data)
		{
			return this.CurVoiceIndex == data.LangIndex;
		}

		// Token: 0x0603345F RID: 210015 RVA: 0x00BF60ED File Offset: 0x00BF42ED
		private void OnRoleLangCustomRefresh(int roleId)
		{
			if (roleId != this.CurRoleId && roleId != -1)
			{
				return;
			}
			this.OnRoleItemToggleStateChanged(this.CurRoleId);
		}

		// Token: 0x06033460 RID: 210016 RVA: 0x00BF6109 File Offset: 0x00BF4309
		private void OnClickedBtnInfo()
		{
			HelpController.Instance.OpenHelpById(615);
		}

		// Token: 0x06033461 RID: 210017 RVA: 0x00BF611C File Offset: 0x00BF431C
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

		// Token: 0x0401B34E RID: 111438
		private const int HELP_ID = 615;

		// Token: 0x0401B34F RID: 111439
		private const int FILTER_RULE_ID = 1;

		// Token: 0x0401B350 RID: 111440
		private static readonly EFilterSortGroupId filterGroupId = EFilterSortGroupId.Role;

		// Token: 0x0401B351 RID: 111441
		private static readonly FilterDefine.EFilterType filterTypeId = FilterDefine.EFilterType.Element;

		// Token: 0x0401B352 RID: 111442
		private static readonly FilterDefine.EFilterType filterTypeLanguageId = FilterDefine.EFilterType.RoleLangCustomType;

		// Token: 0x0401B353 RID: 111443
		private const int FILTER_ALL_ID = 0;

		// Token: 0x0401B354 RID: 111444
		protected int CurElement = -1;

		// Token: 0x0401B355 RID: 111445
		protected int CurRoleId;

		// Token: 0x0401B356 RID: 111446
		protected int CurVoiceIndex;

		// Token: 0x0401B357 RID: 111447
		protected IRoleLangCustomLangSelectInfo CurStateData;

		// Token: 0x0401B358 RID: 111448
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401B359 RID: 111449
		protected RoleLangCustomLangFilter RoleCustomItem;

		// Token: 0x0401B35A RID: 111450
		protected GenericScrollViewNew<RoleLangCustomElementTabItem, int> TopElementScroll;

		// Token: 0x0401B35B RID: 111451
		protected GenericScrollViewNew<RoleLangCustomRoleItem, RoleInstance> RoleItemScroll;

		// Token: 0x0401B35C RID: 111452
		protected GenericScrollViewNew<RoleLangCustomLangSelectItem, IRoleLangCustomLangSelectInfo> VoiceScroll;

		// Token: 0x0401B35D RID: 111453
		protected List<RoleInstance> RoleList = new List<RoleInstance>();

		// Token: 0x0401B35E RID: 111454
		protected Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> FilterRuleMap = new Dictionary<FilterDefine.EFilterType, Dictionary<int, string>>();

		// Token: 0x0401B35F RID: 111455
		[Nullable(2)]
		protected IRoleLangCustomLangSelectInfo CurrentIsPlayingInfo;

		// Token: 0x0401B360 RID: 111456
		protected int? PlayAudioHandle;

		// Token: 0x0401B361 RID: 111457
		[Nullable(2)]
		protected string OldAudioCode;

		// Token: 0x0401B362 RID: 111458
		protected int? OldCodeRoleId;

		// Token: 0x0401B363 RID: 111459
		protected bool IsNormalEnd = true;

		// Token: 0x0401B364 RID: 111460
		[Nullable(2)]
		protected ButtonItem ConfirmBtn;

		// Token: 0x0401B365 RID: 111461
		protected bool FromRoleView;

		// Token: 0x0200AEEB RID: 44779
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x040351FD RID: 217597
			Caption,
			// Token: 0x040351FE RID: 217598
			BtnRoleVoiceActing,
			// Token: 0x040351FF RID: 217599
			PanelEmpty,
			// Token: 0x04035200 RID: 217600
			RoleItemScroll,
			// Token: 0x04035201 RID: 217601
			RoleVoiceActingCardItem,
			// Token: 0x04035202 RID: 217602
			PanelRight,
			// Token: 0x04035203 RID: 217603
			TxtTitle,
			// Token: 0x04035204 RID: 217604
			VoiceActingItemScroll,
			// Token: 0x04035205 RID: 217605
			VoiceActingItem,
			// Token: 0x04035206 RID: 217606
			RoleVoiceSort,
			// Token: 0x04035207 RID: 217607
			BtnConfirmB,
			// Token: 0x04035208 RID: 217608
			BtnFunctionDel,
			// Token: 0x04035209 RID: 217609
			TopMenuItemScroll
		}
	}
}
