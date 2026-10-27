using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BC9 RID: 27593
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemBossRushBuff : OpenSystemBase
	{
		// Token: 0x06044370 RID: 279408 RVA: 0x010D077F File Offset: 0x010CE97F
		public OpenSystemBossRushBuff(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044371 RID: 279409 RVA: 0x010D0788 File Offset: 0x010CE988
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemBossRushBuff.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemBossRushBuff.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044372 RID: 279410 RVA: 0x010D07CB File Offset: 0x010CE9CB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SoundAreaPlayTips);
		}
	}
}
