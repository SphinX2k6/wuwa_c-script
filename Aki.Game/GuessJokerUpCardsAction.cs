using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004DC RID: 1244
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerUpCardsAction : GuessJokerActionBase
{
	// Token: 0x06003DC6 RID: 15814 RVA: 0x0015D7AA File Offset: 0x0015B9AA
	public GuessJokerUpCardsAction(int[] cardIdList, bool isUp = true)
	{
		this.CardIdList.AddRange(cardIdList);
		this.IsUp = isUp;
	}

	// Token: 0x06003DC7 RID: 15815 RVA: 0x0015D7D0 File Offset: 0x0015B9D0
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

	// Token: 0x04003189 RID: 12681
	private readonly List<int> CardIdList = new List<int>();

	// Token: 0x0400318A RID: 12682
	private readonly bool IsUp;
}
