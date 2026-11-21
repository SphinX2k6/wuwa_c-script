using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020004F1 RID: 1265
public class GuessJokerUpdateHpTask : GuessJokerTaskBase
{
	// Token: 0x06003E46 RID: 15942 RVA: 0x0016023F File Offset: 0x0015E43F
	[NullableContext(1)]
	public GuessJokerUpdateHpTask(JokerGuessHpAction data)
	{
		this.PlayerType = GuessJokerUtils.ServerPlayerTransToClient(data.Actor);
		this.Hp = data.HealthHp;
	}

	// Token: 0x06003E47 RID: 15943 RVA: 0x0016026C File Offset: 0x0015E46C
	protected override void OnExecute()
	{
		GuessJokerGamePlayModel.Instance.UpdateHp(this.PlayerType, this.Hp);
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		list.Add(new GuessJokerUpdateHpAction(this.PlayerType, this.Hp));
		if (this.Hp == 0)
		{
			GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gamePlayView.ShowWinLoseReasonTip(this.PlayerType, "GuessJoker_HpZeroTipText", false, complete);
			}));
		}
		list.Add(new GuessJokerCallbackAction(new Action(base.FinishTask)));
		GuessJokerGamePlayModel.Instance.PushActions(list);
	}

	// Token: 0x040031C7 RID: 12743
	public EGuessJokerPlayerType PlayerType = EGuessJokerPlayerType.Ai;

	// Token: 0x040031C8 RID: 12744
	public int Hp;
}
