using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C1B RID: 27675
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSheriffMainStoryError : OpenSystemBase
	{
		// Token: 0x06044465 RID: 279653 RVA: 0x010D2897 File Offset: 0x010D0A97
		public OpenSystemSheriffMainStoryError(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044466 RID: 279654 RVA: 0x010D28A0 File Offset: 0x010D0AA0
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

		// Token: 0x06044467 RID: 279655 RVA: 0x010D28E3 File Offset: 0x010D0AE3
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

		// Token: 0x06044468 RID: 279656 RVA: 0x010D28F9 File Offset: 0x010D0AF9
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SheriffErrorView);
		}

		// Token: 0x0402398B RID: 145803
		[Nullable(2)]
		private CustomPromise OpenMapPromise;
	}
}
