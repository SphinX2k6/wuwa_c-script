using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D74 RID: 23924
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemLordGymLordEntranceSelectView : OpenSystemBase
	{
		// Token: 0x0603A55D RID: 238941 RVA: 0x0107BB27 File Offset: 0x01079D27
		public OpenSystemLordGymLordEntranceSelectView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A55E RID: 238942 RVA: 0x0107BB30 File Offset: 0x01079D30
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemLordGymLordEntranceSelectView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemLordGymLordEntranceSelectView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A55F RID: 238943 RVA: 0x0107BB7B File Offset: 0x01079D7B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.LordGymLordEntranceSelectView);
		}
	}
}
