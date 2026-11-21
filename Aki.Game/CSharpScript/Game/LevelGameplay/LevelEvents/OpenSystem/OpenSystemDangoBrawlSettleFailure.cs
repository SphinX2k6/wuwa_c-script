using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D4E RID: 23886
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDangoBrawlSettleFailure : OpenSystemBase
	{
		// Token: 0x0603A4EC RID: 238828 RVA: 0x0107AB97 File Offset: 0x01078D97
		public OpenSystemDangoBrawlSettleFailure(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4ED RID: 238829 RVA: 0x0107ABA0 File Offset: 0x01078DA0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDangoBrawlSettleFailure.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDangoBrawlSettleFailure.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4EE RID: 238830 RVA: 0x0107ABDB File Offset: 0x01078DDB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DangoBrawlFailSettleView);
		}
	}
}
