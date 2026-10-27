using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200103D RID: 4157
public class GuessJokerUpdateHpTask : GuessJokerTaskBase
{
	// Token: 0x06006AB1 RID: 27313 RVA: 0x00157917 File Offset: 0x00155B17
	[NullableContext(1)]
	public GuessJokerUpdateHpTask(JokerGuessHpAction data)
	{
		this.PlayerType = GuessJokerUtils.ServerPlayerTransToClient(data.Actor);
		this.Hp = data.HealthHp;
	}

	// Token: 0x06006AB2 RID: 27314 RVA: 0x00157944 File Offset: 0x00155B44
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

	// Token: 0x0400312E RID: 12590
	public EGuessJokerPlayerType PlayerType = EGuessJokerPlayerType.Ai;

	// Token: 0x0400312F RID: 12591
	public int Hp;
}
