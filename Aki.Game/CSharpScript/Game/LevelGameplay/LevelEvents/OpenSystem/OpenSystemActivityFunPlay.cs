using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BC5 RID: 27589
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemActivityFunPlay : OpenSystemBase
	{
		// Token: 0x06044364 RID: 279396 RVA: 0x010D05F3 File Offset: 0x010CE7F3
		public OpenSystemActivityFunPlay(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044365 RID: 279397 RVA: 0x010D05FC File Offset: 0x010CE7FC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemActivityFunPlay.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemActivityFunPlay.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044366 RID: 279398 RVA: 0x010D0637 File Offset: 0x010CE837
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ActivityFunPlayView);
		}
	}
}
