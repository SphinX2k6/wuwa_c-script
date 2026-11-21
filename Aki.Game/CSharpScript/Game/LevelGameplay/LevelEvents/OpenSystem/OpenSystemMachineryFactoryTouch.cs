using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D75 RID: 23925
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMachineryFactoryTouch : OpenSystemBase
	{
		// Token: 0x0603A560 RID: 238944 RVA: 0x0107BB87 File Offset: 0x01079D87
		public OpenSystemMachineryFactoryTouch(LevelEventOpenSystem levelEventOpenSystem) : base(levelEventOpenSystem)
		{
		}

		// Token: 0x0603A561 RID: 238945 RVA: 0x0107BB90 File Offset: 0x01079D90
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMachineryFactoryTouch.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMachineryFactoryTouch.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A562 RID: 238946 RVA: 0x0107BBD3 File Offset: 0x01079DD3
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MachineryFactoryTouchMoveView);
		}
	}
}
