using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE4 RID: 27620
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFoxFailureTips : OpenSystemBase
	{
		// Token: 0x060443C1 RID: 279489 RVA: 0x010D129B File Offset: 0x010CF49B
		public OpenSystemFoxFailureTips(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443C2 RID: 279490 RVA: 0x010D12A4 File Offset: 0x010CF4A4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFoxFailureTips.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFoxFailureTips.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443C3 RID: 279491 RVA: 0x010D12DF File Offset: 0x010CF4DF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.FoxFailureTipsView);
		}
	}
}
