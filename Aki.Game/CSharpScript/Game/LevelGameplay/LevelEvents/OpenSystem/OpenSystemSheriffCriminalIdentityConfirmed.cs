using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C1A RID: 27674
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSheriffCriminalIdentityConfirmed : OpenSystemBase
	{
		// Token: 0x06044462 RID: 279650 RVA: 0x010D283F File Offset: 0x010D0A3F
		public OpenSystemSheriffCriminalIdentityConfirmed(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044463 RID: 279651 RVA: 0x010D2848 File Offset: 0x010D0A48
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSheriffCriminalIdentityConfirmed.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSheriffCriminalIdentityConfirmed.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044464 RID: 279652 RVA: 0x010D288B File Offset: 0x010D0A8B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SheriffCriminalIdentityConfirmedView);
		}
	}
}
