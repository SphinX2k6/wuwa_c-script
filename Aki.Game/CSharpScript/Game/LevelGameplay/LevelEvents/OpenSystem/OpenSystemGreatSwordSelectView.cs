using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE9 RID: 27625
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemGreatSwordSelectView : OpenSystemBase
	{
		// Token: 0x060443CF RID: 279503 RVA: 0x010D1400 File Offset: 0x010CF600
		public OpenSystemGreatSwordSelectView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443D0 RID: 279504 RVA: 0x010D1409 File Offset: 0x010CF609
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.GreatSwordLevelSelectView);
		}

		// Token: 0x060443D1 RID: 279505 RVA: 0x010D1418 File Offset: 0x010CF618
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemGreatSwordSelectView.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemGreatSwordSelectView.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
