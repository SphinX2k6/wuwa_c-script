using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200441A RID: 17434
	[NullableContext(2)]
	[Nullable(0)]
	public class VoiceLanguageToggle : LanguageToggleBase, IResourceUpdateView
	{
		// Token: 0x0602C03A RID: 180282 RVA: 0x00C5B90C File Offset: 0x00C59B0C
		[NullableContext(0)]
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			VoiceLanguageToggle.<ShowNotEnoughSpaceConfirmation>d__1 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.totalSize = totalSize;
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<VoiceLanguageToggle.<ShowNotEnoughSpaceConfirmation>d__1>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x0602C03B RID: 180283 RVA: 0x00C5B950 File Offset: 0x00C59B50
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			if (this.Updater == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HotPatch;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "UpdatePatchProgress时，找不到对应的LanguageUpdater";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("languageCode", this.LanguageCode ?? "");
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (curProgress == totalProgress)
			{
				this.Updater.CalculateDownloadStatus("VoiceLanguageToggle UpdatePatchProgress");
				Action downloadStatusCallback = this.DownloadStatusCallback;
				if (downloadStatusCallback != null)
				{
					downloadStatusCallback();
				}
			}
			if (!this.Updater.IsDownloading)
			{
				return;
			}
			this.UpdateProgressUi(curProgress, totalProgress, downloadSpeed);
		}

		// Token: 0x0602C03C RID: 180284 RVA: 0x00C5B9D7 File Offset: 0x00C59BD7
		[NullableContext(1)]
		public void SetDownloadStatusCallback(Action callback)
		{
			this.DownloadStatusCallback = callback;
		}

		// Token: 0x0602C03D RID: 180285 RVA: 0x00C5B9E0 File Offset: 0x00C59BE0
		public unsafe void RefreshUi()
		{
			UUIText text = base.GetText(2);
			if (this.Updater == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HotPatch;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "RefreshUi时，找不到对应的LanguageUpdater";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("languageCode", this.LanguageCode ?? "");
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				text.SetUIActive(false);
				return;
			}
			text.SetUIActive(true);
			if (!this.Updater.IsDownloading)
			{
				string value = "";
				string text2 = LauncherTextLib.SpaceSizeFormat(this.Updater.TotalDiskSize);
				int targetConfig = MenuController.Instance.GetTargetConfig(EFunction.VOICELANGUAGE);
				bool flag = this.Index == targetConfig;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.GameSettings;
				ELogAuthor author2 = ELogAuthor.TZJ;
				string message2 = "[语音下载] VoiceLanguageToggle.RefreshUi";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("index", this.Index);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetIndex", targetConfig);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("languageCode", this.LanguageCode ?? "");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("updaterStatus", this.Updater.Status);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("isInUse", flag);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				if (flag)
				{
					value = TextConfig.Instance.GetTextById("InUse");
				}
				else if (this.Updater.Status == ELanguageDownloadStatus.Half)
				{
					value = TextConfig.Instance.GetTextById("Pausing");
					string value2 = LauncherTextLib.SpaceSizeFormat(this.Updater.LocalDiskSize);
					string value3 = text2;
					this.ProgressBuilder.Clear();
					this.ProgressBuilder.Append(value2);
					this.ProgressBuilder.Append("/");
					this.ProgressBuilder.Append(value3);
					text2 = this.ProgressBuilder.ToString();
				}
				else if (this.Updater.Status == ELanguageDownloadStatus.None)
				{
					value = TextConfig.Instance.GetTextById("NotDownloaded");
					text2 = "";
				}
				this.ProgressBuilder.Clear();
				this.ProgressBuilder.Append(value);
				this.ProgressBuilder.Append("\t");
				this.ProgressBuilder.Append(text2);
				text.SetText(this.ProgressBuilder.ToString(), true);
				return;
			}
			if (this.LastProgressText == "")
			{
				this.UpdateProgressUi(this.Updater.LocalDiskSize, this.Updater.TotalDiskSize, 0L);
				return;
			}
			text.SetText(this.LastProgressText, true);
		}

		// Token: 0x0602C03E RID: 180286 RVA: 0x00C5BC95 File Offset: 0x00C59E95
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
		}

		// Token: 0x0602C03F RID: 180287 RVA: 0x00C5BCA0 File Offset: 0x00C59EA0
		protected override void OnStart()
		{
			base.OnStart();
			this.LanguageCode = GameSettingsManager.Instance.GetAudioCodeById(this.Index);
			if (string.IsNullOrEmpty(this.LanguageCode))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HotPatch;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "创建VoiceLanguageToggle时，找不到对应的语言配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Index", this.Index);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Updater = LanguageUpdateManager.Instance.GetUpdater(this.LanguageCode);
			if (this.Updater == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.HotPatch;
				ELogAuthor author2 = ELogAuthor.WZ;
				string message2 = "创建VoiceLanguageToggle时，找不到对应的LanguageUpdater";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("languageCode", this.LanguageCode);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.Updater.UpdateView.SetImplement(this);
			this.RefreshUi();
		}

		// Token: 0x0602C040 RID: 180288 RVA: 0x00C5BD68 File Offset: 0x00C59F68
		public LanguageUpdater GetUpdater()
		{
			string audioCodeById = GameSettingsManager.Instance.GetAudioCodeById(this.Index);
			return LanguageUpdateManager.Instance.GetUpdater(audioCodeById);
		}

		// Token: 0x0602C041 RID: 180289 RVA: 0x00C5BD94 File Offset: 0x00C59F94
		private void UpdateProgressUi(long nowVal, long allVal, long downloadSpeed)
		{
			string value = LauncherTextLib.SpaceSizeFormat(nowVal);
			string value2 = LauncherTextLib.SpaceSizeFormat(allVal);
			this.ProgressBuilder.Clear();
			this.ProgressBuilder.Append(value);
			this.ProgressBuilder.Append("/");
			this.ProgressBuilder.Append(value2);
			this.LastProgressText = this.ProgressBuilder.ToString();
			base.GetText(2).SetText(this.LastProgressText, true);
		}

		// Token: 0x0602C042 RID: 180290 RVA: 0x00C5BE0C File Offset: 0x00C5A00C
		protected override void OnBeforeDestroy()
		{
			if (this.Updater == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HotPatch;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "销毁VoiceLanguageToggle时，找不到对应的LanguageUpdater";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("languageCode", this.LanguageCode ?? "");
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Updater.UpdateView.SetImplement(null);
			this.Updater.UpdateView.SetImplement(new LanguageDownloadTips(this.Updater, base.GetMainText()));
		}

		// Token: 0x04017B69 RID: 97129
		private string LanguageCode;

		// Token: 0x04017B6A RID: 97130
		public LanguageUpdater Updater;

		// Token: 0x04017B6B RID: 97131
		[Nullable(1)]
		private string LastProgressText = "";

		// Token: 0x04017B6C RID: 97132
		private Action DownloadStatusCallback;
	}
}
