using System;

// Token: 0x02002C9A RID: 11418
public class UiDangoDataComponent : UiModelComponentBase
{
	// Token: 0x17002033 RID: 8243
	// (get) Token: 0x06017DD6 RID: 97750 RVA: 0x006117A6 File Offset: 0x0060F9A6
	// (set) Token: 0x06017DD7 RID: 97751 RVA: 0x006117AE File Offset: 0x0060F9AE
	public int DangoId
	{
		get
		{
			return this.DangoIdInternal;
		}
		set
		{
			this.DangoIdInternal = value;
		}
	}

	// Token: 0x0400B1EA RID: 45546
	private int DangoIdInternal;
}
