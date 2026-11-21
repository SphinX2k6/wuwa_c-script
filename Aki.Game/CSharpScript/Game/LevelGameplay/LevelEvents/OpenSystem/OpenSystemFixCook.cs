using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D5B RID: 23899
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFixCook : OpenSystemBase
	{
		// Token: 0x0603A513 RID: 238867 RVA: 0x0107B13F File Offset: 0x0107933F
		public OpenSystemFixCook(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A514 RID: 238868 RVA: 0x0107B148 File Offset: 0x01079348
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFixCook.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFixCook.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A515 RID: 238869 RVA: 0x0107B193 File Offset: 0x01079393
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.CookPopFixView);
		}
	}
}
