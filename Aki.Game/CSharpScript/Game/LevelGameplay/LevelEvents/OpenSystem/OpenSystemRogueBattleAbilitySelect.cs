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
	// Token: 0x02006C10 RID: 27664
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueBattleAbilitySelect : OpenSystemBase
	{
		// Token: 0x06044444 RID: 279620 RVA: 0x010D2433 File Offset: 0x010D0633
		public OpenSystemRogueBattleAbilitySelect(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044445 RID: 279621 RVA: 0x010D243C File Offset: 0x010D063C
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

		// Token: 0x06044446 RID: 279622 RVA: 0x010D2480 File Offset: 0x010D0680
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
