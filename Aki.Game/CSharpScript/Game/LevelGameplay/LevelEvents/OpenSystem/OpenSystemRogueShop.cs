using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D8E RID: 23950
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueShop : OpenSystemBase
	{
		// Token: 0x0603A5AB RID: 239019 RVA: 0x0107C586 File Offset: 0x0107A786
		public OpenSystemRogueShop(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5AC RID: 239020 RVA: 0x0107C590 File Offset: 0x0107A790
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueShop.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueShop.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5AD RID: 239021 RVA: 0x0107C5CC File Offset: 0x0107A7CC
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			if (WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
			{
				WeeklyRogueModel instance = WeeklyRogueModel.Instance;
				RogueWeeklyOption rogueWeeklyOption = (instance != null) ? instance.GetOptionByBindId(-1) : null;
				return WeeklyRogueController.Instance.GetViewNameByType(rogueWeeklyOption.Type);
			}
			CSharpScript.Game.Module.Roguelike.RoguelikeChooseData roguelikeChooseDataById = RoguelikeModel.Instance.GetRoguelikeChooseDataById(-1);
			return RoguelikeController.Instance.GetViewNameByGainType(roguelikeChooseDataById.RoguelikeGainDataType.Value);
		}
	}
}
