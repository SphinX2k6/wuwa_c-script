using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C04 RID: 27652
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemPhantomArenaChallengeView : OpenSystemBase
	{
		// Token: 0x06044420 RID: 279584 RVA: 0x010D1F43 File Offset: 0x010D0143
		public OpenSystemPhantomArenaChallengeView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044421 RID: 279585 RVA: 0x010D1F4C File Offset: 0x010D014C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			int boardId = inParams.BoardId;
			if (PhantomArenaConfig.Instance.GetPhantomBattleChallengeConfig(boardId).CardGroupId > 0)
			{
				return null;
			}
			return new EUiViewName?(EUiViewName.PhantomArenaMainView);
		}

		// Token: 0x06044422 RID: 279586 RVA: 0x010D1F98 File Offset: 0x010D0198
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemPhantomArenaChallengeView.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemPhantomArenaChallengeView.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
