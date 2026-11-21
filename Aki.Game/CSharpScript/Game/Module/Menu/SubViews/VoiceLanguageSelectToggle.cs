using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200441C RID: 17436
	public class VoiceLanguageSelectToggle : LanguageToggleBase
	{
		// Token: 0x0602C04E RID: 180302 RVA: 0x00C5C31B File Offset: 0x00C5A51B
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
		}

		// Token: 0x0602C04F RID: 180303 RVA: 0x00C5C324 File Offset: 0x00C5A524
		protected override void OnStart()
		{
			base.OnStart();
			string audioCodeById = GameSettingsManager.Instance.GetAudioCodeById(this.Index);
			this.Updater = LanguageUpdateManager.Instance.GetUpdater(audioCodeById);
			UUIText text = base.GetText(2);
			text.SetUIActive(true);
			if (this.PreToggled)
			{
				LguiUtil.Instance.SetLocalText(text, "InUse", Array.Empty<object>());
				return;
			}
			if (this.Updater.Status != ELanguageDownloadStatus.Done)
			{
				LguiUtil.Instance.SetLocalText(text, "NotDownloaded", Array.Empty<object>());
				return;
			}
			text.SetText("", true);
		}

		// Token: 0x04017B6D RID: 97133
		[Nullable(2)]
		public LanguageUpdater Updater;
	}
}
