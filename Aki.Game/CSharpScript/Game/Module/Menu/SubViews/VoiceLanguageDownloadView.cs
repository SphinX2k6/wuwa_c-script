using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005435 RID: 21557
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VoiceLanguageDownloadView : LanguageSettingViewBase<VoiceLanguageToggle>
	{
		// Token: 0x060370DA RID: 225498 RVA: 0x00D0BC6E File Offset: 0x00D09E6E
		public VoiceLanguageDownloadView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060370DB RID: 225499 RVA: 0x00D0BC77 File Offset: 0x00D09E77
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
		}

		// Token: 0x060370DC RID: 225500 RVA: 0x00D0BC80 File Offset: 0x00D09E80
		protected override void OnStart()
		{
			base.OnStart();
			this.CoverRoleLangToggle.RootUIComp.Get().SetUIActive(false);
			ResourceManagerController.Instance.ChangeHttpTickFrequency();
			this.CancelButton.SetFunction(delegate(int _)
			{
				this.DoCloseBtn();
			});
			this.ConfirmButton.SetFunction(new Action<int>(this.DoConfirmBtn));
			if (CloudGameManager.Instance.IsCloudGame)
			{
				this.ConfirmButton.SetUiActive(false);
			}
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				CommonPopViewBase popItem = childPopView.PopItem;
				if (popItem != null)
				{
					popItem.OverrideBackBtnCallBack(new Action(this.DoCloseBtn));
				}
			}
			this.RoleLangDeleteHint.SetUIActive(false);
			string textStringId = (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading) ? "VoiceDIY_DeleteResource_Login" : "DeleteResource_VoiceDIY_Tip";
			LguiUtil.Instance.SetLocalTextNew(this.RoleLangDeleteHintTxt, textStringId, Array.Empty<object>());
		}

		// Token: 0x060370DD RID: 225501 RVA: 0x00D0BD62 File Offset: 0x00D09F62
		protected override void OnBeforeDestroy()
		{
			this.IsDestroyed = true;
			ResourceManagerController.Instance.RestoreHttpTickFrequency();
		}

		// Token: 0x060370DE RID: 225502 RVA: 0x00D0BD75 File Offset: 0x00D09F75
		[return: Nullable(2)]
		protected override VoiceLanguageToggle CreateToggle(UUIItem uiItem, int index, bool isToggled)
		{
			VoiceLanguageToggle voiceLanguageToggle = new VoiceLanguageToggle();
			voiceLanguageToggle.Initialize(uiItem, index, isToggled);
			return voiceLanguageToggle;
		}

		// Token: 0x060370DF RID: 225503 RVA: 0x00D0BD88 File Offset: 0x00D09F88
		protected override void OnRefreshView(VoiceLanguageToggle newToggle)
		{
			base.OnRefreshView(newToggle);
			string mainText = this.MenuDataIns.OptionsNameList[newToggle.GetIndex()];
			newToggle.SetMainText(mainText);
			newToggle.SetDownloadStatusCallback(new Action(this.OnDownloadStatusCallback));
		}

		// Token: 0x060370E0 RID: 225504 RVA: 0x00D0BDCC File Offset: 0x00D09FCC
		protected override void InitScrollViewData()
		{
			List<int> allLanguageTypeForAudio = LanguageUpdateManager.Instance.GetAllLanguageTypeForAudio();
			allLanguageTypeForAudio.Sort((int a, int b) => a - b);
			this.ScrollView.RefreshByData<int>(allLanguageTypeForAudio, null);
		}

		// Token: 0x060370E1 RID: 225505 RVA: 0x00D0BE1E File Offset: 0x00D0A01E
		protected override void OnAfterShow()
		{
			if (this.SelectedToggle != null)
			{
				this.ChangeButtonByToggleState(this.SelectedToggle);
			}
		}

		// Token: 0x060370E2 RID: 225506 RVA: 0x00D0BE34 File Offset: 0x00D0A034
		private unsafe void ChangeButtonByToggleState(VoiceLanguageToggle toggle)
		{
			LanguageUpdater updater = toggle.GetUpdater();
			if (updater == null)
			{
				return;
			}
			int targetConfig = MenuController.Instance.GetTargetConfig(EFunction.VOICELANGUAGE);
			bool flag = updater.Status == ELanguageDownloadStatus.Done && toggle.GetIndex() == targetConfig;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "[语音下载] ChangeButtonByToggleState";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("toggleIndex", toggle.GetIndex());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetIndex", targetConfig);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("updaterStatus", updater.Status);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("isDownloading", updater.IsDownloading);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("isInUse", flag);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if (updater.IsDownloading)
			{
				this.ConfirmButton.SetLocalText("PauseDownload", Array.Empty<object>());
			}
			else if (updater.Status != ELanguageDownloadStatus.Done)
			{
				this.ConfirmButton.SetLocalText("DownloadLanguage", Array.Empty<object>());
			}
			if (updater.Status == ELanguageDownloadStatus.Done)
			{
				this.ConfirmButton.SetLocalText("DeleteLanguage", Array.Empty<object>());
			}
			if (flag)
			{
				this.ConfirmButton.SetFunction(new Action<int>(this.DoDisBtn));
				return;
			}
			this.ConfirmButton.SetFunction(new Action<int>(this.DoConfirmBtn));
		}

		// Token: 0x060370E3 RID: 225507 RVA: 0x00D0BFC2 File Offset: 0x00D0A1C2
		protected override void OnSelected(VoiceLanguageToggle newToggle, EToggleState newToggleState)
		{
			this.RefreshRoleHint(newToggle);
			this.RefreshUiBySelect(newToggle);
		}

		// Token: 0x060370E4 RID: 225508 RVA: 0x00D0BFD2 File Offset: 0x00D0A1D2
		private void OnDownloadStatusCallback()
		{
			this.RefreshUiBySelect(this.SelectedToggle);
		}

		// Token: 0x060370E5 RID: 225509 RVA: 0x00D0BFE0 File Offset: 0x00D0A1E0
		protected void RefreshRoleHint(VoiceLanguageToggle selectedToggle)
		{
			if (!this.CheckRoleLangCustom())
			{
				this.RoleLangDeleteHint.SetUIActive(false);
				return;
			}
			int index = selectedToggle.GetIndex();
			int languageTypeByAudioCode = LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
			if (index == languageTypeByAudioCode)
			{
				this.RoleLangDeleteHint.SetUIActive(false);
				return;
			}
			if (GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
			{
				Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null) ?? new Dictionary<int, int>();
				bool uiactive = false;
				using (Dictionary<int, int>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == index)
						{
							uiactive = true;
							break;
						}
					}
				}
				this.RoleLangDeleteHint.SetUIActive(uiactive);
				return;
			}
			this.RoleLangDeleteHint.SetUIActive(true);
		}

		// Token: 0x060370E6 RID: 225510 RVA: 0x00D0C0B4 File Offset: 0x00D0A2B4
		protected void RefreshUiBySelect(VoiceLanguageToggle selectedToggle)
		{
			if (this.IsDestroyed)
			{
				return;
			}
			this.ChangeButtonByToggleState(selectedToggle);
			selectedToggle.RefreshUi();
		}

		// Token: 0x060370E7 RID: 225511 RVA: 0x00D0C0CC File Offset: 0x00D0A2CC
		protected bool CheckRoleLangCustom()
		{
			if (CloudGameManager.Instance.IsCloudGame)
			{
				return false;
			}
			VoiceLanguageToggle selectedToggle = this.SelectedToggle;
			if (((selectedToggle != null) ? selectedToggle.Updater.Status : ELanguageDownloadStatus.None) != ELanguageDownloadStatus.Done)
			{
				return false;
			}
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("NeedShowRoleLangCustom");
			return boolConfig != null && boolConfig.Value && (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading || (LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, null) ?? new HashSet<int>()).Count > 0);
		}

		// Token: 0x060370E8 RID: 225512 RVA: 0x00D0C150 File Offset: 0x00D0A350
		private void DoCloseBtn()
		{
			EUiViewName? backToPrevLangSettingViewName = LanguageSettingViewBase.BackToPrevLangSettingViewName;
			if (backToPrevLangSettingViewName != null)
			{
				base.CloseMe(delegate(bool success)
				{
					if (success)
					{
						UiManager instance = UiManager.Instance;
						EUiViewName value = backToPrevLangSettingViewName.Value;
						object[] array = new object[2];
						array[0] = MenuModel.Instance.GetMenuDataByFunctionId(52);
						instance.OpenView(value, array, null);
						LanguageSettingViewBase.BackToPrevLangSettingViewName = null;
					}
				});
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x060370E9 RID: 225513 RVA: 0x00D0C195 File Offset: 0x00D0A395
		private void DoDisBtn(int _)
		{
			ScrollingTipsController.Instance.ShowTipsById("InUseCanNotDelete", Array.Empty<object>());
		}

		// Token: 0x060370EA RID: 225514 RVA: 0x00D0C1AC File Offset: 0x00D0A3AC
		private void DoConfirmBtn(int _)
		{
			ConfirmBoxDataNew confirmBoxDataNew = null;
			if (this.SelectedToggle == null)
			{
				return;
			}
			ELanguageDownloadStatus status = this.SelectedToggle.Updater.Status;
			if (status > ELanguageDownloadStatus.Half)
			{
				if (status == ELanguageDownloadStatus.Done)
				{
					confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VoiceDelete);
					bool flag = this.RoleLangDeleteHint.IsUIActiveSelf();
					if (this.CheckRoleLangCustom() && flag)
					{
						string key = (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading) ? "VoiceDIY_DeleteResourceResetDefault_Login" : "VoiceDIY_DeleteResourceResetDefaultTip";
						confirmBoxDataNew.Tip = PublicUtil.Instance.GetConfigTextByKey(key);
						confirmBoxDataNew.SetTipsBgRed = true;
					}
					Action value = delegate()
					{
						this.SelectedToggle.Updater.Delete(GlobalData.World);
						this.RefreshUiBySelect(this.SelectedToggle);
						RoleLangCustomModel.Instance.CheckAndApplyPlayerVoiceAll();
						this.RefreshRoleHint(this.SelectedToggle);
					};
					confirmBoxDataNew.SetTextArgs(new string[]
					{
						this.SelectedToggle.GetMainText()
					});
					confirmBoxDataNew.FunctionMap[2] = value;
				}
			}
			else if (this.SelectedToggle.Updater.IsDownloading)
			{
				this.SelectedToggle.Updater.Pause();
				this.RefreshUiBySelect(this.SelectedToggle);
			}
			else
			{
				VoiceLanguageDownloadView.<>c__DisplayClass17_0 CS$<>8__locals1 = new VoiceLanguageDownloadView.<>c__DisplayClass17_0();
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.isInLogin = !GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading;
				bool flag2 = UKuroLauncherLibrary.GetNetworkConnectionType() == 3;
				EConfirmBoxConfigId configId;
				if (CS$<>8__locals1.isInLogin)
				{
					configId = (flag2 ? EConfirmBoxConfigId.VoiceDownloadLoginConfirmCell : EConfirmBoxConfigId.VoiceDownloadLoginConfirm);
				}
				else
				{
					configId = (flag2 ? EConfirmBoxConfigId.VoiceDownloadCell : EConfirmBoxConfigId.VoiceDownload);
				}
				confirmBoxDataNew = new ConfirmBoxDataNew(configId);
				string text = LauncherTextLib.SpaceSizeFormat(this.SelectedToggle.Updater.TotalDiskSize - this.SelectedToggle.Updater.LocalDiskSize);
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					this.SelectedToggle.GetMainText(),
					text
				});
				confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<DoConfirmBtn>g__ConfirmCallback|1);
			}
			if (confirmBoxDataNew != null)
			{
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
		}

		// Token: 0x0401D0CD RID: 118989
		private bool IsDestroyed;
	}
}
