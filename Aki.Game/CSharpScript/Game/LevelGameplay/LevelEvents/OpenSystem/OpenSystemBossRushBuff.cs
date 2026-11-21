using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D42 RID: 23874
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemBossRushBuff : OpenSystemBase
	{
		// Token: 0x0603A4C8 RID: 238792 RVA: 0x0107A6D3 File Offset: 0x010788D3
		public OpenSystemBossRushBuff(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4C9 RID: 238793 RVA: 0x0107A6DC File Offset: 0x010788DC
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

		// Token: 0x0603A4CA RID: 238794 RVA: 0x0107A71F File Offset: 0x0107891F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SoundAreaPlayTips);
		}
	}
}
