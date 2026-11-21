using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D94 RID: 23956
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSheriffMainStoryError : OpenSystemBase
	{
		// Token: 0x0603A5BD RID: 239037 RVA: 0x0107C7EB File Offset: 0x0107A9EB
		public OpenSystemSheriffMainStoryError(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5BE RID: 239038 RVA: 0x0107C7F4 File Offset: 0x0107A9F4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSheriffMainStoryError.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>4__this = this;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSheriffMainStoryError.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5BF RID: 239039 RVA: 0x0107C837 File Offset: 0x0107AA37
		private void OnWorldMapExtraUiOpen(EWorldMapExtraUiPanelName panelName)
		{
			if (panelName == EWorldMapExtraUiPanelName.SheriffMapPanel)
			{
				CustomPromise openMapPromise = this.OpenMapPromise;
				if (openMapPromise == null)
				{
					return;
				}
				openMapPromise.SetResult();
			}
		}

		// Token: 0x0603A5C0 RID: 239040 RVA: 0x0107C84D File Offset: 0x0107AA4D
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SheriffErrorView);
		}

		// Token: 0x0401EC2D RID: 125997
		[Nullable(2)]
		private CustomPromise OpenMapPromise;
	}
}
