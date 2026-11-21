using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D70 RID: 23920
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemInstanceFailure : OpenSystemBase
	{
		// Token: 0x0603A551 RID: 238929 RVA: 0x0107B9C2 File Offset: 0x01079BC2
		public OpenSystemInstanceFailure(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A552 RID: 238930 RVA: 0x0107B9CC File Offset: 0x01079BCC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemInstanceFailure.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemInstanceFailure.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A553 RID: 238931 RVA: 0x0107BA07 File Offset: 0x01079C07
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.InstanceDungeonFailView);
		}
	}
}
