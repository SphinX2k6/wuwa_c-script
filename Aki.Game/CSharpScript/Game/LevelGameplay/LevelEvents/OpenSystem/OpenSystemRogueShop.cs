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
	// Token: 0x02006C15 RID: 27669
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueShop : OpenSystemBase
	{
		// Token: 0x06044453 RID: 279635 RVA: 0x010D2632 File Offset: 0x010D0832
		public OpenSystemRogueShop(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044454 RID: 279636 RVA: 0x010D263C File Offset: 0x010D083C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueShop.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueShop.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044455 RID: 279637 RVA: 0x010D2678 File Offset: 0x010D0878
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
