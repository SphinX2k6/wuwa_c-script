using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001026 RID: 4134
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerShowCardsAction : GuessJokerActionBase
{
	// Token: 0x06006A2D RID: 27181 RVA: 0x00154D2C File Offset: 0x00152F2C
	public GuessJokerShowCardsAction(int[] cardIdList, bool isShow, float duration = 0f)
	{
		this.CardIdList.AddRange(cardIdList);
		if (duration != 0f)
		{
			this.Duration = duration;
		}
		else
		{
			this.Duration = 1000f;
		}
		this.IsShow = isShow;
	}

	// Token: 0x06006A2E RID: 27182 RVA: 0x00154D7C File Offset: 0x00152F7C
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		gamePlayView.ShowCards(this.CardIdList.ToArray(), this.IsShow);
	}

	// Token: 0x040030ED RID: 12525
	private readonly List<int> CardIdList = new List<int>();

	// Token: 0x040030EE RID: 12526
	private readonly bool IsShow;
}
