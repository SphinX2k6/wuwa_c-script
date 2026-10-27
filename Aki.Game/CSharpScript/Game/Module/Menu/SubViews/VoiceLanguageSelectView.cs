using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005438 RID: 21560
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VoiceLanguageSelectView : LanguageSettingViewBase<VoiceLanguageSelectToggle>
	{
		// Token: 0x060370FB RID: 225531 RVA: 0x00D0CA7B File Offset: 0x00D0AC7B
		public VoiceLanguageSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060370FC RID: 225532 RVA: 0x00D0CA84 File Offset: 0x00D0AC84
		protected override void OnStart()
		{
			base.OnStart();
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("NeedShowRoleLangCustom");
			LguiUtil.Instance.SetLocalTextNew(this.CoverRoleTxt, "Override_VoiceDIY_CustomTip", Array.Empty<object>());
			if (boolConfig != null && boolConfig.Value)
			{
				if (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
				{
					LguiUtil.Instance.SetLocalTextNew(this.RoleLangDeleteHintTxt, "Notice_VoiceDIY_LanguageChange", Array.Empty<object>());
					return;
				}
				if (RoleLangCustomModel.Instance != null)
				{
					RoleLangCustomModel.Instance.NeedCoverAllPlayer = false;
					return;
				}
			}
			else
			{
				this.RoleLangDeleteHint.SetUIActive(false);
				this.CoverRoleLangToggle.RootUIComp.Get().SetUIActive(false);
			}
		}

		// Token: 0x060370FD RID: 225533 RVA: 0x00D0CB30 File Offset: 0x00D0AD30
		protected override void InitScrollViewData()
		{
			List<int> allLanguageTypeForAudio = LanguageUpdateManager.Instance.GetAllLanguageTypeForAudio();
			allLanguageTypeForAudio.Sort((int a, int b) => a - b);
			this.ScrollView.RefreshByData<int>(allLanguageTypeForAudio, null);
			this.CancelButton.SetFunction(new Action<int>(this.DoCloseBtn));
			this.ConfirmButton.SetFunction(new Action<int>(this.DoConfirmBtn));
			this.ConfirmButton.SetLocalText("PowerConfirm", Array.Empty<object>());
		}

		// Token: 0x060370FE RID: 225534 RVA: 0x00D0CBC5 File Offset: 0x00D0ADC5
		[return: Nullable(2)]
		protected override VoiceLanguageSelectToggle CreateToggle(UUIItem uiItem, int index, bool isToggled)
		{
			VoiceLanguageSelectToggle voiceLanguageSelectToggle = new VoiceLanguageSelectToggle();
			voiceLanguageSelectToggle.Initialize(uiItem, index, isToggled);
			return voiceLanguageSelectToggle;
		}

		// Token: 0x060370FF RID: 225535 RVA: 0x00D0CBD8 File Offset: 0x00D0ADD8
		protected override void OnRefreshView(VoiceLanguageSelectToggle newToggle)
		{
			base.OnRefreshView(newToggle);
			string mainText = this.MenuDataIns.OptionsNameList[newToggle.GetIndex()];
			newToggle.SetMainText(mainText);
			if (this.SelectedToggle != null)
			{
				this.RefreshCoverRoleLangToggleVisible(this.SelectedToggle);
				this.RefreshRoleCoverHint(this.SelectedToggle);
			}
		}

		// Token: 0x06037100 RID: 225536 RVA: 0x00D0CC2C File Offset: 0x00D0AE2C
		protected override void OnSelected(VoiceLanguageSelectToggle newToggle, EToggleState newToggleState)
		{
			if (newToggle.Updater.Status == ELanguageDownloadStatus.Done)
			{
				this.ConfirmButton.SetLocalText("PowerConfirm", Array.Empty<object>());
			}
			else
			{
				this.ConfirmButton.SetLocalText("GoToDownload", Array.Empty<object>());
			}
			this.RefreshCoverRoleLangToggleVisible(newToggle);
			this.RefreshRoleCoverHint(newToggle);
		}

		// Token: 0x06037101 RID: 225537 RVA: 0x00D0CC84 File Offset: 0x00D0AE84
		private void RefreshCoverRoleLangToggleVisible(VoiceLanguageSelectToggle newToggle)
		{
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("NeedShowRoleLangCustom");
			if (boolConfig == null || !boolConfig.Value)
			{
				this.CoverRoleLangToggle.RootUIComp.Get().SetUIActive(false);
				return;
			}
			if (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
			{
				this.CoverRoleLangToggle.RootUIComp.Get().SetUIActive(false);
				return;
			}
			if ((LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, null) ?? new HashSet<int>()).Count == 0)
			{
				this.CoverRoleLangToggle.RootUIComp.Get().SetUIActive(false);
				return;
			}
			bool uiactive = newToggle.Updater.Status == ELanguageDownloadStatus.Done;
			if (GameSettingsManager.Instance.GetAudioCodeById(newToggle.GetIndex()) == LanguageSystem.Instance.PackageAudio)
			{
				this.CoverRoleLangToggle.RootUIComp.Get().SetUIActive(false);
				return;
			}
			this.CoverRoleLangToggle.RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x06037102 RID: 225538 RVA: 0x00D0CD8C File Offset: 0x00D0AF8C
		private void RefreshRoleCoverHint(VoiceLanguageSelectToggle newToggle)
		{
			if (GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
			{
				this.RoleLangDeleteHint.SetUIActive(false);
				return;
			}
			if (GameSettingsManager.Instance.GetAudioCodeById(newToggle.GetIndex()) == LanguageSystem.Instance.PackageAudio)
			{
				this.RoleLangDeleteHint.SetUIActive(false);
				return;
			}
			bool uiactive = newToggle.Updater.Status == ELanguageDownloadStatus.Done;
			this.RoleLangDeleteHint.SetUIActive(uiactive);
		}

		// Token: 0x06037103 RID: 225539 RVA: 0x00D0CDFE File Offset: 0x00D0AFFE
		private void DoCloseBtn(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x06037104 RID: 225540 RVA: 0x00D0CE08 File Offset: 0x00D0B008
		private void DoConfirmBtn(int _)
		{
			if (this.SelectedToggle == null)
			{
				this.DoCloseBtn(0);
				return;
			}
			bool flag = !GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading;
			ELanguageDownloadStatus status = this.SelectedToggle.Updater.Status;
			if (status > ELanguageDownloadStatus.Half)
			{
				if (status == ELanguageDownloadStatus.Done)
				{
					bool flag2 = GameSettingsManager.Instance.GetAudioCodeById(this.SelectedToggle.GetIndex()) != LanguageSystem.Instance.PackageAudio;
					if (flag)
					{
						if (flag2)
						{
							LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.RoleLangCustomNeedCover, true);
						}
					}
					else
					{
						bool flag3 = this.CoverRoleLangToggle.GetToggleState() == EToggleState.ETT_Checked;
						if (RoleLangCustomModel.Instance != null && flag2)
						{
							RoleLangCustomModel.Instance.NeedCoverAllPlayer = !flag3;
						}
					}
					this.IsConfirm = true;
					this.DoCloseBtn(0);
					return;
				}
			}
			else
			{
				LanguageSettingViewBase.BackToPrevLangSettingViewName = new EUiViewName?(EUiViewName.VoiceLanguageSelectView);
				UiManager instance = UiManager.Instance;
				EUiViewName voiceLanguageDownloadView = EUiViewName.VoiceLanguageDownloadView;
				object[] array = new object[2];
				array[0] = MenuModel.Instance.GetMenuDataByFunctionId(53);
				instance.OpenView(voiceLanguageDownloadView, array, null);
				this.DoCloseBtn(0);
			}
		}
	}
}
