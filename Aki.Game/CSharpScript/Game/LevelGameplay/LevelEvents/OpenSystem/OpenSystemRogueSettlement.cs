using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C14 RID: 27668
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueSettlement : OpenSystemBase
	{
		// Token: 0x06044450 RID: 279632 RVA: 0x010D25D6 File Offset: 0x010D07D6
		public OpenSystemRogueSettlement(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044451 RID: 279633 RVA: 0x010D25E0 File Offset: 0x010D07E0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueSettlement.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueSettlement.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044452 RID: 279634 RVA: 0x010D261C File Offset: 0x010D081C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
