using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA7 RID: 23975
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemWeeklyRogueToken : OpenSystemBase
	{
		// Token: 0x0603A5FB RID: 239099 RVA: 0x0107D037 File Offset: 0x0107B237
		public OpenSystemWeeklyRogueToken(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5FC RID: 239100 RVA: 0x0107D040 File Offset: 0x0107B240
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemWeeklyRogueToken.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemWeeklyRogueToken.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5FD RID: 239101 RVA: 0x0107D084 File Offset: 0x0107B284
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			WeeklyRogueModel instance = WeeklyRogueModel.Instance;
			RogueWeeklyOption rogueWeeklyOption = (instance != null) ? instance.GetOptionByBindId(inParams.BoardId) : null;
			return WeeklyRogueController.Instance.GetViewNameByType(rogueWeeklyOption.Type);
		}
	}
}
