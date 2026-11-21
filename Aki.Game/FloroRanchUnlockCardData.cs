using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FCB RID: 4043
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUnlockCardData : FloroRanchUnlockDataBase
{
	// Token: 0x0600A19C RID: 41372 RVA: 0x002F83E0 File Offset: 0x002F65E0
	public FloroRanchUnlockCardData(int id, bool isUnLock, int conditionId) : base(id, isUnLock, conditionId, EFloroRanchCardType.Phantom)
	{
	}

	// Token: 0x0600A19D RID: 41373 RVA: 0x002F83EC File Offset: 0x002F65EC
	public void SetCardData(FloroRanchCardData cardData)
	{
		this.CardData = cardData;
	}

	// Token: 0x0600A19E RID: 41374 RVA: 0x002F83F5 File Offset: 0x002F65F5
	public FloroRanchCardData GetCardData()
	{
		return this.CardData;
	}

	// Token: 0x04005F14 RID: 24340
	private FloroRanchCardData CardData;
}
