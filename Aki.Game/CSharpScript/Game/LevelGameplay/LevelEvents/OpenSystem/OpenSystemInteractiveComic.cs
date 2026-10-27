using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BF8 RID: 27640
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemInteractiveComic : OpenSystemBase
	{
		// Token: 0x060443FC RID: 279548 RVA: 0x010D1ABF File Offset: 0x010CFCBF
		public OpenSystemInteractiveComic(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443FD RID: 279549 RVA: 0x010D1AC8 File Offset: 0x010CFCC8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemInteractiveComic.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemInteractiveComic.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443FE RID: 279550 RVA: 0x010D1B0C File Offset: 0x010CFD0C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
