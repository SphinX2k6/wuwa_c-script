using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C0E RID: 27662
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueAbilitySelect : OpenSystemBase
	{
		// Token: 0x0604443E RID: 279614 RVA: 0x010D2353 File Offset: 0x010D0553
		public OpenSystemRogueAbilitySelect(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604443F RID: 279615 RVA: 0x010D235C File Offset: 0x010D055C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueAbilitySelect.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueAbilitySelect.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044440 RID: 279616 RVA: 0x010D23A0 File Offset: 0x010D05A0
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			RoguelikeChooseData roguelikeChooseDataById = RoguelikeModel.Instance.GetRoguelikeChooseDataById(inParams.BoardId);
			return RoguelikeController.Instance.GetViewNameByGainType(roguelikeChooseDataById.RoguelikeGainDataType.Value);
		}
	}
}
