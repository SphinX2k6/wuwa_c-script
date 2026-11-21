using System;

// Token: 0x020006E8 RID: 1768
public interface IDangoMonopolyItemShowData
{
	// Token: 0x17000AD0 RID: 2768
	// (get) Token: 0x06005190 RID: 20880
	int Id { get; }

	// Token: 0x17000AD1 RID: 2769
	// (get) Token: 0x06005191 RID: 20881
	int UniqueId { get; }

	// Token: 0x17000AD2 RID: 2770
	// (get) Token: 0x06005192 RID: 20882
	// (set) Token: 0x06005193 RID: 20883
	int Num { get; set; }

	// Token: 0x17000AD3 RID: 2771
	// (get) Token: 0x06005194 RID: 20884
	bool IsDouble { get; }
}
