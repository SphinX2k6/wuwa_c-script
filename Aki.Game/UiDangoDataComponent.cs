using System;

// Token: 0x020021F3 RID: 8691
public class UiDangoDataComponent : UiModelComponentBase
{
	// Token: 0x17002084 RID: 8324
	// (get) Token: 0x0601564A RID: 87626 RVA: 0x00637328 File Offset: 0x00635528
	// (set) Token: 0x0601564B RID: 87627 RVA: 0x00637330 File Offset: 0x00635530
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

	// Token: 0x0400B555 RID: 46421
	private int DangoIdInternal;
}
