using System;
using System.Runtime.CompilerServices;

// Token: 0x0200223B RID: 8763
[NullableContext(1)]
[Nullable(0)]
public abstract class MultiTemplateGridDataBase<[Nullable(2)] TData, [Nullable(0)] TProxy> : IMultiTemplateGridData<TData, TProxy>, IMultiTemplateGridData where TProxy : ISyncGridProxy<TData>
{
	// Token: 0x170020D2 RID: 8402
	// (get) Token: 0x06015A4E RID: 88654 RVA: 0x00647B63 File Offset: 0x00645D63
	// (set) Token: 0x06015A4F RID: 88655 RVA: 0x00647B6B File Offset: 0x00645D6B
	public TData Data { get; set; }

	// Token: 0x170020D3 RID: 8403
	// (get) Token: 0x06015A50 RID: 88656 RVA: 0x00647B74 File Offset: 0x00645D74
	object IMultiTemplateGridData.Data
	{
		get
		{
			return this.Data;
		}
	}

	// Token: 0x06015A51 RID: 88657
	public abstract int GetTemplateIndex();

	// Token: 0x06015A52 RID: 88658
	public abstract TProxy CreateProxy();

	// Token: 0x06015A53 RID: 88659 RVA: 0x00647B81 File Offset: 0x00645D81
	public virtual bool IsNavigable()
	{
		return true;
	}

	// Token: 0x06015A54 RID: 88660 RVA: 0x00647B84 File Offset: 0x00645D84
	ISyncGridProxy IMultiTemplateGridData.CreateProxy()
	{
		return this.CreateProxy();
	}
}
