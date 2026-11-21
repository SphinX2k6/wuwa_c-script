using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D62 RID: 23906
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemGreatSwordSelectView : OpenSystemBase
	{
		// Token: 0x0603A527 RID: 238887 RVA: 0x0107B354 File Offset: 0x01079554
		public OpenSystemGreatSwordSelectView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A528 RID: 238888 RVA: 0x0107B35D File Offset: 0x0107955D
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.GreatSwordLevelSelectView);
		}

		// Token: 0x0603A529 RID: 238889 RVA: 0x0107B36C File Offset: 0x0107956C
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
