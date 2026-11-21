using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004DA RID: 1242
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerShowCardsAction : GuessJokerActionBase
{
	// Token: 0x06003DC2 RID: 15810 RVA: 0x0015D654 File Offset: 0x0015B854
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

	// Token: 0x06003DC3 RID: 15811 RVA: 0x0015D6A4 File Offset: 0x0015B8A4
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

	// Token: 0x04003186 RID: 12678
	private readonly List<int> CardIdList = new List<int>();

	// Token: 0x04003187 RID: 12679
	private readonly bool IsShow;
}
