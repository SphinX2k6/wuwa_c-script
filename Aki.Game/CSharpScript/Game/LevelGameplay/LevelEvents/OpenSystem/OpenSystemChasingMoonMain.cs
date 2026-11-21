using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D45 RID: 23877
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemChasingMoonMain : OpenSystemBase
	{
		// Token: 0x0603A4D1 RID: 238801 RVA: 0x0107A7DB File Offset: 0x010789DB
		public OpenSystemChasingMoonMain(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4D2 RID: 238802 RVA: 0x0107A7E4 File Offset: 0x010789E4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemChasingMoonMain.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemChasingMoonMain.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4D3 RID: 238803 RVA: 0x0107A81F File Offset: 0x01078A1F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MoonChasingMainView);
		}
	}
}
