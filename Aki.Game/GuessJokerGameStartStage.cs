using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020004F8 RID: 1272
public class GuessJokerGameStartStage : GuessJokerStageBase
{
	// Token: 0x06003E66 RID: 15974 RVA: 0x00160787 File Offset: 0x0015E987
	[NullableContext(1)]
	public GuessJokerGameStartStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06003E67 RID: 15975 RVA: 0x00160790 File Offset: 0x0015E990
	protected override void OnEnter()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(levelId);
		if (jokerLevelById != null)
		{
			GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(jokerLevelById.Value.AiRole);
			if (jokerAiConfigByRoleId != null)
			{
				GuessJokerGamePlayModel.Instance.ShowOnlyGuessJokerNpc(jokerAiConfigByRoleId.Value.NpcId);
			}
		}
		GuessJokerGamePlayModel.Instance.OpenGamePlayView(delegate
		{
			GuessJokerGamePlayModel.Instance.ChangeState(EGuessJokerCardStateType.DealCards);
		});
	}
}
