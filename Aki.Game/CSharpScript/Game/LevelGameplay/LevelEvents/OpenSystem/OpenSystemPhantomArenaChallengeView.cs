using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D7D RID: 23933
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemPhantomArenaChallengeView : OpenSystemBase
	{
		// Token: 0x0603A578 RID: 238968 RVA: 0x0107BE97 File Offset: 0x0107A097
		public OpenSystemPhantomArenaChallengeView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A579 RID: 238969 RVA: 0x0107BEA0 File Offset: 0x0107A0A0
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

		// Token: 0x0603A57A RID: 238970 RVA: 0x0107BEEC File Offset: 0x0107A0EC
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
