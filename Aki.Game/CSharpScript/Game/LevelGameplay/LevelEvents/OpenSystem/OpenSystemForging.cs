using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE3 RID: 27619
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemForging : OpenSystemBase
	{
		// Token: 0x060443BE RID: 279486 RVA: 0x010D124B File Offset: 0x010CF44B
		public OpenSystemForging(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443BF RID: 279487 RVA: 0x010D1254 File Offset: 0x010CF454
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemForging.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemForging.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443C0 RID: 279488 RVA: 0x010D128F File Offset: 0x010CF48F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ForgingRootView);
		}
	}
}
