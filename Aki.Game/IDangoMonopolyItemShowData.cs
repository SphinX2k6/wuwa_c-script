using System;

// Token: 0x02001234 RID: 4660
public interface IDangoMonopolyItemShowData
{
	// Token: 0x17000AB0 RID: 2736
	// (get) Token: 0x06007DF9 RID: 32249
	int Id { get; }

	// Token: 0x17000AB1 RID: 2737
	// (get) Token: 0x06007DFA RID: 32250
	int UniqueId { get; }

	// Token: 0x17000AB2 RID: 2738
	// (get) Token: 0x06007DFB RID: 32251
	// (set) Token: 0x06007DFC RID: 32252
	int Num { get; set; }

	// Token: 0x17000AB3 RID: 2739
	// (get) Token: 0x06007DFD RID: 32253
	bool IsDouble { get; }
}
