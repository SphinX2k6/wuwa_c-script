using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C2A RID: 27690
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemVersionPreheat : OpenSystemBase
	{
		// Token: 0x06044496 RID: 279702 RVA: 0x010D2EE7 File Offset: 0x010D10E7
		public OpenSystemVersionPreheat(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044497 RID: 279703 RVA: 0x010D2EF0 File Offset: 0x010D10F0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemVersionPreheat.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemVersionPreheat.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044498 RID: 279704 RVA: 0x010D2F33 File Offset: 0x010D1133
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.VersionPreheatVoteView);
		}
	}
}
