using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BFA RID: 27642
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemLordGym : OpenSystemBase
	{
		// Token: 0x06044402 RID: 279554 RVA: 0x010D1B73 File Offset: 0x010CFD73
		public OpenSystemLordGym(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044403 RID: 279555 RVA: 0x010D1B7C File Offset: 0x010CFD7C
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

		// Token: 0x06044404 RID: 279556 RVA: 0x010D1BC7 File Offset: 0x010CFDC7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.LordGymEntranceView);
		}
	}
}
