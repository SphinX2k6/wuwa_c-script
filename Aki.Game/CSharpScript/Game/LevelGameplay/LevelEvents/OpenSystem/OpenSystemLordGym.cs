using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D73 RID: 23923
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemLordGym : OpenSystemBase
	{
		// Token: 0x0603A55A RID: 238938 RVA: 0x0107BAC7 File Offset: 0x01079CC7
		public OpenSystemLordGym(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A55B RID: 238939 RVA: 0x0107BAD0 File Offset: 0x01079CD0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemLordGym.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemLordGym.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A55C RID: 238940 RVA: 0x0107BB1B File Offset: 0x01079D1B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.LordGymEntranceView);
		}
	}
}
