using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Config;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x02000034 RID: 52
	public class SubPackageDownLoadMobileClearInfoItem : LaunchComponentsAction, IHotFixLayoutItem
	{
		// Token: 0x060001EC RID: 492 RVA: 0x0000AC4C File Offset: 0x00008E4C
		[NullableContext(1)]
		public void SetRootActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000AC58 File Offset: 0x00008E58
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnClickToggle));
			HotFixManager.SetLocalText(base.GetText(4), "HotFixSubPackageHaveNoQuestSpaceClear", Array.Empty<string>());
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000ACA8 File Offset: 0x00008EA8
		[NullableContext(1)]
		public void Refresh(IHotFixLayoutData data)
		{
			ISubPackageDownLoadMobileClearInfoItemData subPackageDownLoadMobileClearInfoItemData = (ISubPackageDownLoadMobileClearInfoItemData)data;
			this.SceneId = null;
			this.IsVideo = false;
			this.VoiceCode = null;
			if (subPackageDownLoadMobileClearInfoItemData.Type == ESubPackageDownLoadPackageType.OptionalPlot)
			{
				this.RefreshItemByPlot(subPackageDownLoadMobileClearInfoItemData.HaveVideoCanClear.GetValueOrDefault());
			}
			if (subPackageDownLoadMobileClearInfoItemData.Type == ESubPackageDownLoadPackageType.OptionalScene)
			{
				this.RefreshItemByScene(subPackageDownLoadMobileClearInfoItemData.SceneId.GetValueOrDefault());
			}
			if (subPackageDownLoadMobileClearInfoItemData.Type == ESubPackageDownLoadPackageType.Voice)
			{
				this.RefreshItemByVoice(subPackageDownLoadMobileClearInfoItemData.VoiceLanguageCode ?? "");
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000AD30 File Offset: 0x00008F30
		public void RefreshItemByScene(int sceneId)
		{
			this.SceneId = new int?(sceneId);
			int? sceneId2 = this.SceneId;
			int num = 0;
			if (sceneId2.GetValueOrDefault() <= num & sceneId2 != null)
			{
				base.GetItem(2).SetUIActive(true);
				base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(false);
				return;
			}
			base.GetItem(2).SetUIActive(false);
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(true);
			DownLoadSubPackageRow byId = PackSelectionTables.DownLoadSubPackageTableInstance.GetById(sceneId);
			HotFixManager.SetLocalText(base.GetText(1), byId.Title, Array.Empty<string>());
			long subPackageSpace = HotFixManager.GetSubPackageSpace(sceneId);
			base.GetText(3).SetText(HotFixManager.ByteConverter(subPackageSpace), true);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000AE10 File Offset: 0x00009010
		public void RefreshItemByPlot(bool haveVideo)
		{
			this.IsVideo = true;
			if (!haveVideo)
			{
				base.GetItem(2).SetUIActive(true);
				base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(false);
				return;
			}
			base.GetItem(2).SetUIActive(false);
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(true);
			HotFixManager.SetLocalText(base.GetText(1), "HotFixSubPackageClearTips_Plot_Item_Info", Array.Empty<string>());
			long canCleanVideoSpace = HotFixManager.GetCanCleanVideoSpace();
			base.GetText(3).SetText(HotFixManager.ByteConverter(canCleanVideoSpace), true);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000AEBC File Offset: 0x000090BC
		[NullableContext(1)]
		public void RefreshItemByVoice(string audioCode)
		{
			this.VoiceCode = audioCode;
			if (string.IsNullOrEmpty(audioCode))
			{
				base.GetItem(2).SetUIActive(true);
				base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(false);
				return;
			}
			base.GetItem(2).SetUIActive(false);
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(true);
			IEnumerable<LaunchLangDefine> allLanguageDefines = LauncherLanguageLib.Instance.GetAllLanguageDefines();
			LaunchLangDefine launchLangDefine = null;
			foreach (LaunchLangDefine launchLangDefine2 in allLanguageDefines)
			{
				if (launchLangDefine2.AudioCode == audioCode)
				{
					launchLangDefine = launchLangDefine2;
					break;
				}
			}
			RoleVoiceLanguageTableRow roleVoiceLanguageTableRow = (launchLangDefine != null) ? PackSelectionTables.RoleVoiceLanguageTableInstance.GetById(launchLangDefine.LanguageType) : null;
			if (roleVoiceLanguageTableRow != null)
			{
				HotFixManager.SetLocalText(base.GetText(1), roleVoiceLanguageTableRow.Text, Array.Empty<string>());
			}
			else
			{
				base.GetText(1).SetText(audioCode, true);
			}
			long localSizeByAudioCode = ResourceDiffUpdaterManager.Instance.VoiceModule.GetLocalSizeByAudioCode(audioCode);
			base.GetText(3).SetText(HotFixManager.ByteConverter(localSizeByAudioCode), true);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000AFFC File Offset: 0x000091FC
		private void OnClickToggle(EToggleState state)
		{
			Action<int?, bool, EToggleState, string> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack != null)
			{
				onClickToggleCallBack(this.SceneId, this.IsVideo, state, this.VoiceCode);
			}
			this.IsClicked = (state == EToggleState.ETT_Checked);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000B02C File Offset: 0x0000922C
		public unsafe void SelectItem()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "SubPackageDownLoadMobileClearInfoItem SelectItem";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SceneId", this.SceneId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsVideo", this.IsVideo);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.GetItem(5).SetUIActive(true);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000B0AC File Offset: 0x000092AC
		public unsafe void UnSelectItem()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "SubPackageDownLoadMobileClearInfoItem UnSelectItem";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SceneId", this.SceneId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsVideo", this.IsVideo);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000B12C File Offset: 0x0000932C
		public void ClickItemOnGamePad()
		{
			EToggleState etoggleState = this.IsClicked ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
			base.GetExtendToggle(0).SetToggleState(etoggleState, false, false, false);
			Action<int?, bool, EToggleState, string> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack != null)
			{
				onClickToggleCallBack(this.SceneId, this.IsVideo, etoggleState, this.VoiceCode);
			}
			this.IsClicked = (etoggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x040000E4 RID: 228
		[Nullable(2)]
		public Action<int?, bool, EToggleState, string> OnClickToggleCallBack;

		// Token: 0x040000E5 RID: 229
		private int? SceneId;

		// Token: 0x040000E6 RID: 230
		private bool IsVideo;

		// Token: 0x040000E7 RID: 231
		[Nullable(2)]
		private string VoiceCode;

		// Token: 0x040000E8 RID: 232
		private bool IsClicked;

		// Token: 0x020002B8 RID: 696
		private class ESubPackageDownLoadMobileClearInfoItem
		{
			// Token: 0x04000ADC RID: 2780
			public const int Toggle = 0;

			// Token: 0x04000ADD RID: 2781
			public const int Text = 1;

			// Token: 0x04000ADE RID: 2782
			public const int EmptyItem = 2;

			// Token: 0x04000ADF RID: 2783
			public const int SpaceText = 3;

			// Token: 0x04000AE0 RID: 2784
			public const int EmptyText = 4;

			// Token: 0x04000AE1 RID: 2785
			public const int SelectItem = 5;
		}
	}
}
