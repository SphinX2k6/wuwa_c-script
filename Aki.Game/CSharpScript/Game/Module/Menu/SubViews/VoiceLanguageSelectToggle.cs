using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005439 RID: 21561
	public class VoiceLanguageSelectToggle : LanguageToggleBase
	{
		// Token: 0x06037105 RID: 225541 RVA: 0x00D0CEFB File Offset: 0x00D0B0FB
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
		}

		// Token: 0x06037106 RID: 225542 RVA: 0x00D0CF04 File Offset: 0x00D0B104
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

		// Token: 0x0401D0D4 RID: 118996
		[Nullable(2)]
		public LanguageUpdater Updater;
	}
}
