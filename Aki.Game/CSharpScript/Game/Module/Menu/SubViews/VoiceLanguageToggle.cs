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
	// Token: 0x02005437 RID: 21559
	[NullableContext(2)]
	[Nullable(0)]
	public class VoiceLanguageToggle : LanguageToggleBase, IResourceUpdateView
	{
		// Token: 0x060370F1 RID: 225521 RVA: 0x00D0C4EC File Offset: 0x00D0A6EC
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

		// Token: 0x060370F2 RID: 225522 RVA: 0x00D0C530 File Offset: 0x00D0A730
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

		// Token: 0x060370F3 RID: 225523 RVA: 0x00D0C5B7 File Offset: 0x00D0A7B7
		[NullableContext(1)]
		public void SetDownloadStatusCallback(Action callback)
		{
			this.DownloadStatusCallback = callback;
		}

		// Token: 0x060370F4 RID: 225524 RVA: 0x00D0C5C0 File Offset: 0x00D0A7C0
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

		// Token: 0x060370F5 RID: 225525 RVA: 0x00D0C875 File Offset: 0x00D0AA75
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
		}

		// Token: 0x060370F6 RID: 225526 RVA: 0x00D0C880 File Offset: 0x00D0AA80
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

		// Token: 0x060370F7 RID: 225527 RVA: 0x00D0C948 File Offset: 0x00D0AB48
		public LanguageUpdater GetUpdater()
		{
			string audioCodeById = GameSettingsManager.Instance.GetAudioCodeById(this.Index);
			return LanguageUpdateManager.Instance.GetUpdater(audioCodeById);
		}

		// Token: 0x060370F8 RID: 225528 RVA: 0x00D0C974 File Offset: 0x00D0AB74
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

		// Token: 0x060370F9 RID: 225529 RVA: 0x00D0C9EC File Offset: 0x00D0ABEC
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

		// Token: 0x0401D0D0 RID: 118992
		private string LanguageCode;

		// Token: 0x0401D0D1 RID: 118993
		public LanguageUpdater Updater;

		// Token: 0x0401D0D2 RID: 118994
		[Nullable(1)]
		private string LastProgressText = "";

		// Token: 0x0401D0D3 RID: 118995
		private Action DownloadStatusCallback;
	}
}
