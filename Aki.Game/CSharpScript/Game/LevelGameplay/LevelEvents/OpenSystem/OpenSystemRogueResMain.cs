using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C12 RID: 27666
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueResMain : OpenSystemBase
	{
		// Token: 0x0604444A RID: 279626 RVA: 0x010D250B File Offset: 0x010D070B
		public OpenSystemRogueResMain(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604444B RID: 279627 RVA: 0x010D2514 File Offset: 0x010D0714
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueResMain.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueResMain.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604444C RID: 279628 RVA: 0x010D254F File Offset: 0x010D074F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RogueSeasonEntranceView);
		}
	}
}
