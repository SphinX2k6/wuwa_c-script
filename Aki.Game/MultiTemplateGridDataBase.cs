using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CE2 RID: 11490
[NullableContext(1)]
[Nullable(0)]
public abstract class MultiTemplateGridDataBase<[Nullable(2)] TData, [Nullable(0)] TProxy> : IMultiTemplateGridData<TData, TProxy>, IMultiTemplateGridData where TProxy : ISyncGridProxy<TData>
{
	// Token: 0x1700207F RID: 8319
	// (get) Token: 0x060181CF RID: 98767 RVA: 0x00621EEF File Offset: 0x006200EF
	// (set) Token: 0x060181D0 RID: 98768 RVA: 0x00621EF7 File Offset: 0x006200F7
	public TData Data { get; set; }

	// Token: 0x17002080 RID: 8320
	// (get) Token: 0x060181D1 RID: 98769 RVA: 0x00621F00 File Offset: 0x00620100
	object IMultiTemplateGridData.Data
	{
		get
		{
			return this.Data;
		}
	}

	// Token: 0x060181D2 RID: 98770
	public abstract int GetTemplateIndex();

	// Token: 0x060181D3 RID: 98771
	public abstract TProxy CreateProxy();

	// Token: 0x060181D4 RID: 98772 RVA: 0x00621F0D File Offset: 0x0062010D
	public virtual bool IsNavigable()
	{
		return true;
	}

	// Token: 0x060181D5 RID: 98773 RVA: 0x00621F10 File Offset: 0x00620110
	ISyncGridProxy IMultiTemplateGridData.CreateProxy()
	{
		return this.CreateProxy();
	}
}
