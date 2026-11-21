using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D77 RID: 23927
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMoraleAreaSum : OpenSystemBase
	{
		// Token: 0x0603A566 RID: 238950 RVA: 0x0107BCDA File Offset: 0x01079EDA
		public OpenSystemMoraleAreaSum(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A567 RID: 238951 RVA: 0x0107BCE4 File Offset: 0x01079EE4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMoraleAreaSum.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMoraleAreaSum.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A568 RID: 238952 RVA: 0x0107BD27 File Offset: 0x01079F27
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MoraleAreaSumView);
		}
	}
}
