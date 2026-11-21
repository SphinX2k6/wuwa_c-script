using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D89 RID: 23945
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueBattleAbilitySelect : OpenSystemBase
	{
		// Token: 0x0603A59C RID: 239004 RVA: 0x0107C387 File Offset: 0x0107A587
		public OpenSystemRogueBattleAbilitySelect(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A59D RID: 239005 RVA: 0x0107C390 File Offset: 0x0107A590
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueBattleAbilitySelect.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueBattleAbilitySelect.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A59E RID: 239006 RVA: 0x0107C3D4 File Offset: 0x0107A5D4
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			RogueResOption optionDataById = RogueBattleModel.Instance.GetOptionDataById(inParams.BoardId);
			return RogueBattleController.Instance.GetViewNameByGainType(optionDataById.RogueResDataType);
		}
	}
}
