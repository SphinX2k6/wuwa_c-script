using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D60 RID: 23904
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemGameSysOpen : OpenSystemBase
	{
		// Token: 0x0603A522 RID: 238882 RVA: 0x0107B2E7 File Offset: 0x010794E7
		public OpenSystemGameSysOpen(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A523 RID: 238883 RVA: 0x0107B2F0 File Offset: 0x010794F0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemGameSysOpen.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemGameSysOpen.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A524 RID: 238884 RVA: 0x0107B333 File Offset: 0x01079533
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.FunctionOpenView);
		}
	}
}
