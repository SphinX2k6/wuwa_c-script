using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D71 RID: 23921
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemInteractiveComic : OpenSystemBase
	{
		// Token: 0x0603A554 RID: 238932 RVA: 0x0107BA13 File Offset: 0x01079C13
		public OpenSystemInteractiveComic(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A555 RID: 238933 RVA: 0x0107BA1C File Offset: 0x01079C1C
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

		// Token: 0x0603A556 RID: 238934 RVA: 0x0107BA60 File Offset: 0x01079C60
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
