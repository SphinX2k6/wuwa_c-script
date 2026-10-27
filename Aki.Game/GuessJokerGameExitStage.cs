using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;

// Token: 0x02001043 RID: 4163
public class GuessJokerGameExitStage : GuessJokerStageBase
{
	// Token: 0x06006ACF RID: 27343 RVA: 0x00157DBF File Offset: 0x00155FBF
	[NullableContext(1)]
	public GuessJokerGameExitStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06006AD0 RID: 27344 RVA: 0x00157DC8 File Offset: 0x00155FC8
	protected override void OnEnter()
	{
		GuessJokerGamePlayModel.Instance.CloseGamePlayViewAsync().Forget(delegate(Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJoker关闭游戏界面失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}, true);
		int roleId = GuessJokerGamePlayModel.Instance.GetRoleId();
		GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(roleId);
		int? num = (jokerAiConfigByRoleId != null) ? new int?(jokerAiConfigByRoleId.GetValueOrDefault().NpcId) : null;
		if (num != null)
		{
			GuessJokerGamePlayModel.Instance.ShowOnlyGuessJokerNpc(num.Value);
		}
	}
}
