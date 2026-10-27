using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BEC RID: 27628
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHiddenBossWindow : OpenSystemBase
	{
		// Token: 0x060443D8 RID: 279512 RVA: 0x010D151A File Offset: 0x010CF71A
		public OpenSystemHiddenBossWindow(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443D9 RID: 279513 RVA: 0x010D1524 File Offset: 0x010CF724
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHiddenBossWindow.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHiddenBossWindow.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443DA RID: 279514 RVA: 0x010D1567 File Offset: 0x010CF767
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HiddenBossWindow);
		}
	}
}
