using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FCF RID: 4047
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUnlockToyData : FloroRanchUnlockDataBase
{
	// Token: 0x0600A1AA RID: 41386 RVA: 0x002F84A3 File Offset: 0x002F66A3
	public FloroRanchUnlockToyData(int id, bool isUnLock, int conditionId) : base(id, isUnLock, conditionId, EFloroRanchCardType.Toy)
	{
	}

	// Token: 0x0600A1AB RID: 41387 RVA: 0x002F84AF File Offset: 0x002F66AF
	public void SetToyData(FloroRanchToyData toyData)
	{
		this.ToyData = toyData;
	}

	// Token: 0x0600A1AC RID: 41388 RVA: 0x002F84B8 File Offset: 0x002F66B8
	public FloroRanchToyData GetToyData()
	{
		return this.ToyData;
	}

	// Token: 0x04005F1B RID: 24347
	private FloroRanchToyData ToyData;
}
