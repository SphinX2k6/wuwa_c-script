using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B0C RID: 6924
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUnlockCardData : FloroRanchUnlockDataBase
{
	// Token: 0x0600CD8B RID: 52619 RVA: 0x002ED2F4 File Offset: 0x002EB4F4
	public FloroRanchUnlockCardData(int id, bool isUnLock, int conditionId) : base(id, isUnLock, conditionId, EFloroRanchCardType.Phantom)
	{
	}

	// Token: 0x0600CD8C RID: 52620 RVA: 0x002ED300 File Offset: 0x002EB500
	public void SetCardData(FloroRanchCardData cardData)
	{
		this.CardData = cardData;
	}

	// Token: 0x0600CD8D RID: 52621 RVA: 0x002ED309 File Offset: 0x002EB509
	public FloroRanchCardData GetCardData()
	{
		return this.CardData;
	}

	// Token: 0x04005E45 RID: 24133
	private FloroRanchCardData CardData;
}
