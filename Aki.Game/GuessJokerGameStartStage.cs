using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001044 RID: 4164
public class GuessJokerGameStartStage : GuessJokerStageBase
{
	// Token: 0x06006AD1 RID: 27345 RVA: 0x00157E5F File Offset: 0x0015605F
	[NullableContext(1)]
	public GuessJokerGameStartStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06006AD2 RID: 27346 RVA: 0x00157E68 File Offset: 0x00156068
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
