using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE2 RID: 27618
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFixCook : OpenSystemBase
	{
		// Token: 0x060443BB RID: 279483 RVA: 0x010D11EB File Offset: 0x010CF3EB
		public OpenSystemFixCook(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443BC RID: 279484 RVA: 0x010D11F4 File Offset: 0x010CF3F4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFixCook.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFixCook.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443BD RID: 279485 RVA: 0x010D123F File Offset: 0x010CF43F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.CookPopFixView);
		}
	}
}
