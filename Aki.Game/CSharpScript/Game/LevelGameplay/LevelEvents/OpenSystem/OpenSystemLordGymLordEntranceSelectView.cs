using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BFB RID: 27643
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemLordGymLordEntranceSelectView : OpenSystemBase
	{
		// Token: 0x06044405 RID: 279557 RVA: 0x010D1BD3 File Offset: 0x010CFDD3
		public OpenSystemLordGymLordEntranceSelectView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044406 RID: 279558 RVA: 0x010D1BDC File Offset: 0x010CFDDC
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

		// Token: 0x06044407 RID: 279559 RVA: 0x010D1C27 File Offset: 0x010CFE27
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.LordGymLordEntranceSelectView);
		}
	}
}
