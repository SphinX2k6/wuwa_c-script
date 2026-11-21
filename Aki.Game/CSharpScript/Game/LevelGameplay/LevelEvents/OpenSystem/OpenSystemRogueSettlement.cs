using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D8D RID: 23949
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueSettlement : OpenSystemBase
	{
		// Token: 0x0603A5A8 RID: 239016 RVA: 0x0107C52A File Offset: 0x0107A72A
		public OpenSystemRogueSettlement(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5A9 RID: 239017 RVA: 0x0107C534 File Offset: 0x0107A734
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueSettlement.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueSettlement.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5AA RID: 239018 RVA: 0x0107C570 File Offset: 0x0107A770
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
