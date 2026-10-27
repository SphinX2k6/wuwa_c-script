using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005436 RID: 21558
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageDownloadTips : ResourceUpdateViewBase
	{
		// Token: 0x060370EF RID: 225519 RVA: 0x00D0C456 File Offset: 0x00D0A656
		public LanguageDownloadTips(LanguageUpdater updater, string languageTest)
		{
			this.Updater = updater;
			this.LanguageText = languageTest;
		}

		// Token: 0x060370F0 RID: 225520 RVA: 0x00D0C478 File Offset: 0x00D0A678
		public override void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			if (this.Updater == null)
			{
				Log.Instance.Error(ELogModule.HotPatch, ELogAuthor.WZ, "UpdatePatchProgress时，找不到对应的LanguageUpdater", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (curProgress == totalProgress)
			{
				this.Updater.CalculateDownloadStatus("LanguageDownloadTips UpdatePatchProgress");
				if (this.Updater.Status == ELanguageDownloadStatus.Done)
				{
					ScrollingTipsController.Instance.ShowTipsById("LanguageDownloadFinished", new object[]
					{
						this.LanguageText
					});
				}
			}
		}

		// Token: 0x0401D0CE RID: 118990
		[Nullable(2)]
		private readonly LanguageUpdater Updater;

		// Token: 0x0401D0CF RID: 118991
		private readonly string LanguageText = "";
	}
}
