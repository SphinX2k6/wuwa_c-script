using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001028 RID: 4136
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerUpCardsAction : GuessJokerActionBase
{
	// Token: 0x06006A31 RID: 27185 RVA: 0x00154E82 File Offset: 0x00153082
	public GuessJokerUpCardsAction(int[] cardIdList, bool isUp = true)
	{
		this.CardIdList.AddRange(cardIdList);
		this.IsUp = isUp;
	}

	// Token: 0x06006A32 RID: 27186 RVA: 0x00154EA8 File Offset: 0x001530A8
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		List<GuessJokerCardItem> list = new List<GuessJokerCardItem>();
		for (int i = 0; i < this.CardIdList.Count; i++)
		{
			int cardId = this.CardIdList[i];
			GuessJokerCardItem cardItemById = gamePlayView.GetCardItemById(cardId);
			if (cardItemById != null)
			{
				list.Add(cardItemById);
			}
		}
		if (list.Count == 0)
		{
			this.Done = true;
			return;
		}
		bool[] completedFlags = new bool[list.Count];
		for (int j = 0; j < completedFlags.Length; j++)
		{
			completedFlags[j] = false;
		}
		for (int k = 0; k < list.Count; k++)
		{
			GuessJokerCardItem guessJokerCardItem = list[k];
			int index = k;
			guessJokerCardItem.CardUp(this.IsUp, delegate
			{
				completedFlags[index] = true;
				bool flag = true;
				for (int l = 0; l < completedFlags.Length; l++)
				{
					if (!completedFlags[l])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					this.Done = true;
				}
			});
		}
	}

	// Token: 0x040030F0 RID: 12528
	private readonly List<int> CardIdList = new List<int>();

	// Token: 0x040030F1 RID: 12529
	private readonly bool IsUp;
}
