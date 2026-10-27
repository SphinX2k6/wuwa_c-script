using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C2E RID: 27694
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemWeeklyRogueToken : OpenSystemBase
	{
		// Token: 0x060444A3 RID: 279715 RVA: 0x010D30E3 File Offset: 0x010D12E3
		public OpenSystemWeeklyRogueToken(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060444A4 RID: 279716 RVA: 0x010D30EC File Offset: 0x010D12EC
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

		// Token: 0x060444A5 RID: 279717 RVA: 0x010D3130 File Offset: 0x010D1330
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
