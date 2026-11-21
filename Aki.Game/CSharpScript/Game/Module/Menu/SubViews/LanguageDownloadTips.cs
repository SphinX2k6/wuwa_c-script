using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004419 RID: 17433
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageDownloadTips : ResourceUpdateViewBase
	{
		// Token: 0x0602C038 RID: 180280 RVA: 0x00C5B876 File Offset: 0x00C59A76
		public LanguageDownloadTips(LanguageUpdater updater, string languageTest)
		{
			this.Updater = updater;
			this.LanguageText = languageTest;
		}

		// Token: 0x0602C039 RID: 180281 RVA: 0x00C5B898 File Offset: 0x00C59A98
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

		// Token: 0x04017B67 RID: 97127
		[Nullable(2)]
		private readonly LanguageUpdater Updater;

		// Token: 0x04017B68 RID: 97128
		private readonly string LanguageText = "";
	}
}
