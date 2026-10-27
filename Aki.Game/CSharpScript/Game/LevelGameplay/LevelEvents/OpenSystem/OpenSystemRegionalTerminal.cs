using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C0C RID: 27660
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRegionalTerminal : OpenSystemBase
	{
		// Token: 0x06044439 RID: 279609 RVA: 0x010D22DB File Offset: 0x010D04DB
		public OpenSystemRegionalTerminal(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604443A RID: 279610 RVA: 0x010D22E4 File Offset: 0x010D04E4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRegionalTerminal.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRegionalTerminal.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604443B RID: 279611 RVA: 0x010D2328 File Offset: 0x010D0528
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
