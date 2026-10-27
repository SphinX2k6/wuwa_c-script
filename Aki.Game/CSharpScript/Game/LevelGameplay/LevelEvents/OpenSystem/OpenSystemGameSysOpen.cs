using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE7 RID: 27623
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemGameSysOpen : OpenSystemBase
	{
		// Token: 0x060443CA RID: 279498 RVA: 0x010D1393 File Offset: 0x010CF593
		public OpenSystemGameSysOpen(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443CB RID: 279499 RVA: 0x010D139C File Offset: 0x010CF59C
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

		// Token: 0x060443CC RID: 279500 RVA: 0x010D13DF File Offset: 0x010CF5DF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.FunctionOpenView);
		}
	}
}
