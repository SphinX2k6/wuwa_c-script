using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D5D RID: 7517
[NullableContext(1)]
[Nullable(0)]
public class TEntityIdOrPos_Int : TEntityIdOrPos
{
	// Token: 0x0600E48A RID: 58506 RVA: 0x0035B4CD File Offset: 0x003596CD
	public TEntityIdOrPos_Int(int value)
	{
	}

	// Token: 0x0600E48B RID: 58507 RVA: 0x0035B4DC File Offset: 0x003596DC
	public static implicit operator int(TEntityIdOrPos_Int target)
	{
		return target.Value;
	}

	// Token: 0x0600E48C RID: 58508 RVA: 0x0035B4E4 File Offset: 0x003596E4
	public new static implicit operator TEntityIdOrPos_Int(int value)
	{
		return new TEntityIdOrPos_Int(value);
	}

	// Token: 0x0400695D RID: 26973
	public int Value = value;
}
