using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B10 RID: 6928
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUnlockToyData : FloroRanchUnlockDataBase
{
	// Token: 0x0600CD99 RID: 52633 RVA: 0x002ED3B7 File Offset: 0x002EB5B7
	public FloroRanchUnlockToyData(int id, bool isUnLock, int conditionId) : base(id, isUnLock, conditionId, EFloroRanchCardType.Toy)
	{
	}

	// Token: 0x0600CD9A RID: 52634 RVA: 0x002ED3C3 File Offset: 0x002EB5C3
	public void SetToyData(FloroRanchToyData toyData)
	{
		this.ToyData = toyData;
	}

	// Token: 0x0600CD9B RID: 52635 RVA: 0x002ED3CC File Offset: 0x002EB5CC
	public FloroRanchToyData GetToyData()
	{
		return this.ToyData;
	}

	// Token: 0x04005E4C RID: 24140
	private FloroRanchToyData ToyData;
}
