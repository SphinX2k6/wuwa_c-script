using System;
using System.Runtime.CompilerServices;

// Token: 0x020007F7 RID: 2039
[NullableContext(2)]
[Nullable(0)]
public class MemoryItemData : IMemoryItemData
{
	// Token: 0x17000BD0 RID: 3024
	// (get) Token: 0x06005CD4 RID: 23764 RVA: 0x001DE037 File Offset: 0x001DC237
	// (set) Token: 0x06005CD5 RID: 23765 RVA: 0x001DE03F File Offset: 0x001DC23F
	public EMemoryContentId Type { get; set; }

	// Token: 0x17000BD1 RID: 3025
	// (get) Token: 0x06005CD6 RID: 23766 RVA: 0x001DE048 File Offset: 0x001DC248
	// (set) Token: 0x06005CD7 RID: 23767 RVA: 0x001DE050 File Offset: 0x001DC250
	public EMemoryClassify Classify { get; set; }

	// Token: 0x17000BD2 RID: 3026
	// (get) Token: 0x06005CD8 RID: 23768 RVA: 0x001DE059 File Offset: 0x001DC259
	// (set) Token: 0x06005CD9 RID: 23769 RVA: 0x001DE061 File Offset: 0x001DC261
	[Nullable(1)]
	public string Title { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

	// Token: 0x17000BD3 RID: 3027
	// (get) Token: 0x06005CDA RID: 23770 RVA: 0x001DE06A File Offset: 0x001DC26A
	// (set) Token: 0x06005CDB RID: 23771 RVA: 0x001DE072 File Offset: 0x001DC272
	public bool HasData { get; set; }

	// Token: 0x17000BD4 RID: 3028
	// (get) Token: 0x06005CDC RID: 23772 RVA: 0x001DE07B File Offset: 0x001DC27B
	// (set) Token: 0x06005CDD RID: 23773 RVA: 0x001DE083 File Offset: 0x001DC283
	public bool IsDelegate { get; set; }

	// Token: 0x17000BD5 RID: 3029
	// (get) Token: 0x06005CDE RID: 23774 RVA: 0x001DE08C File Offset: 0x001DC28C
	// (set) Token: 0x06005CDF RID: 23775 RVA: 0x001DE094 File Offset: 0x001DC294
	public int Sort { get; set; }

	// Token: 0x17000BD6 RID: 3030
	// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x001DE09D File Offset: 0x001DC29D
	// (set) Token: 0x06005CE1 RID: 23777 RVA: 0x001DE0A5 File Offset: 0x001DC2A5
	public string Content { get; set; }

	// Token: 0x17000BD7 RID: 3031
	// (get) Token: 0x06005CE2 RID: 23778 RVA: 0x001DE0AE File Offset: 0x001DC2AE
	// (set) Token: 0x06005CE3 RID: 23779 RVA: 0x001DE0B6 File Offset: 0x001DC2B6
	public string SubContent { get; set; }

	// Token: 0x17000BD8 RID: 3032
	// (get) Token: 0x06005CE4 RID: 23780 RVA: 0x001DE0BF File Offset: 0x001DC2BF
	// (set) Token: 0x06005CE5 RID: 23781 RVA: 0x001DE0C7 File Offset: 0x001DC2C7
	public string IconPath { get; set; }
}
