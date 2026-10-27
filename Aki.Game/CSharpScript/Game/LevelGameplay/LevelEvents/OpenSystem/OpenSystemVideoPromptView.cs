using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C2B RID: 27691
	public class OpenSystemVideoPromptView : OpenSystemBase
	{
		// Token: 0x06044499 RID: 279705 RVA: 0x010D2F3F File Offset: 0x010D113F
		[NullableContext(1)]
		public OpenSystemVideoPromptView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604449A RID: 279706 RVA: 0x010D2F48 File Offset: 0x010D1148
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

		// Token: 0x0604449B RID: 279707 RVA: 0x010D2F94 File Offset: 0x010D1194
		private UniTask<bool> OpenLegacyView([Nullable(1)] IPictureCaptionConfig config)
		{
			OpenSystemVideoPromptView.<OpenLegacyView>d__2 <OpenLegacyView>d__;
			<OpenLegacyView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLegacyView>d__.config = config;
			<OpenLegacyView>d__.<>1__state = -1;
			<OpenLegacyView>d__.<>t__builder.Start<OpenSystemVideoPromptView.<OpenLegacyView>d__2>(ref <OpenLegacyView>d__);
			return <OpenLegacyView>d__.<>t__builder.Task;
		}

		// Token: 0x0604449C RID: 279708 RVA: 0x010D2FD7 File Offset: 0x010D11D7
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
