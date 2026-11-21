using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA4 RID: 23972
	public class OpenSystemVideoPromptView : OpenSystemBase
	{
		// Token: 0x0603A5F1 RID: 239089 RVA: 0x0107CE93 File Offset: 0x0107B093
		[NullableContext(1)]
		public OpenSystemVideoPromptView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5F2 RID: 239090 RVA: 0x0107CE9C File Offset: 0x0107B09C
		[NullableContext(1)]
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemVideoPromptView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>4__this = this;
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemVideoPromptView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5F3 RID: 239091 RVA: 0x0107CEE8 File Offset: 0x0107B0E8
		private UniTask<bool> OpenLegacyView([Nullable(1)] IPictureCaptionConfig config)
		{
			OpenSystemVideoPromptView.<OpenLegacyView>d__2 <OpenLegacyView>d__;
			<OpenLegacyView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLegacyView>d__.config = config;
			<OpenLegacyView>d__.<>1__state = -1;
			<OpenLegacyView>d__.<>t__builder.Start<OpenSystemVideoPromptView.<OpenLegacyView>d__2>(ref <OpenLegacyView>d__);
			return <OpenLegacyView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5F4 RID: 239092 RVA: 0x0107CF2B File Offset: 0x0107B12B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			string value;
			if (inParams == null)
			{
				value = null;
			}
			else
			{
				IPictureCaptionConfig pictureCaptionConfig = inParams.PictureCaptionConfig;
				value = ((pictureCaptionConfig != null) ? pictureCaptionConfig.UiPrefabId : null);
			}
			if (!string.IsNullOrEmpty(value))
			{
				return new EUiViewName?(EUiViewName.PlotCaptionImageView);
			}
			return new EUiViewName?(EUiViewName.VideoPromptView);
		}
	}
}
