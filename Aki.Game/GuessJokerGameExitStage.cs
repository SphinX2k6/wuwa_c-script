using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;

// Token: 0x020004F7 RID: 1271
public class GuessJokerGameExitStage : GuessJokerStageBase
{
	// Token: 0x06003E64 RID: 15972 RVA: 0x001606E7 File Offset: 0x0015E8E7
	[NullableContext(1)]
	public GuessJokerGameExitStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06003E65 RID: 15973 RVA: 0x001606F0 File Offset: 0x0015E8F0
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
