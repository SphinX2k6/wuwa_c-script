using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000BB0 RID: 2992
[NullableContext(1)]
[Nullable(0)]
public class GmDataLayerInfo
{
	// Token: 0x06007C65 RID: 31845 RVA: 0x00268AB8 File Offset: 0x00266CB8
	public GmDataLayerInfo(HashSet<string> loadDataLayers, HashSet<string> unloadDataLayers)
	{
	}

	// Token: 0x17000E19 RID: 3609
	// (get) Token: 0x06007C66 RID: 31846 RVA: 0x00268ACE File Offset: 0x00266CCE
	// (set) Token: 0x06007C67 RID: 31847 RVA: 0x00268AD6 File Offset: 0x00266CD6
	public HashSet<string> LoadDataLayers { get; set; } = loadDataLayers;

	// Token: 0x17000E1A RID: 3610
	// (get) Token: 0x06007C68 RID: 31848 RVA: 0x00268ADF File Offset: 0x00266CDF
	// (set) Token: 0x06007C69 RID: 31849 RVA: 0x00268AE7 File Offset: 0x00266CE7
	public HashSet<string> UnloadDataLayers { get; set; } = unloadDataLayers;
}
