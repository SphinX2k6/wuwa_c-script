using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D5E RID: 23902
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFragmentMemory : OpenSystemBase
	{
		// Token: 0x0603A51C RID: 238876 RVA: 0x0107B23F File Offset: 0x0107943F
		public OpenSystemFragmentMemory(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A51D RID: 238877 RVA: 0x0107B248 File Offset: 0x01079448
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFragmentMemory.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFragmentMemory.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A51E RID: 238878 RVA: 0x0107B28B File Offset: 0x0107948B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MemoryDetailView);
		}
	}
}
