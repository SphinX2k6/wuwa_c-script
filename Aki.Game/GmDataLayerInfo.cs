using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020016F8 RID: 5880
[NullableContext(1)]
[Nullable(0)]
public class GmDataLayerInfo
{
	// Token: 0x0600A885 RID: 43141 RVA: 0x0025E69C File Offset: 0x0025C89C
	public GmDataLayerInfo(HashSet<string> loadDataLayers, HashSet<string> unloadDataLayers)
	{
	}

	// Token: 0x17000DF8 RID: 3576
	// (get) Token: 0x0600A886 RID: 43142 RVA: 0x0025E6B2 File Offset: 0x0025C8B2
	// (set) Token: 0x0600A887 RID: 43143 RVA: 0x0025E6BA File Offset: 0x0025C8BA
	public HashSet<string> LoadDataLayers { get; set; } = loadDataLayers;

	// Token: 0x17000DF9 RID: 3577
	// (get) Token: 0x0600A888 RID: 43144 RVA: 0x0025E6C3 File Offset: 0x0025C8C3
	// (set) Token: 0x0600A889 RID: 43145 RVA: 0x0025E6CB File Offset: 0x0025C8CB
	public HashSet<string> UnloadDataLayers { get; set; } = unloadDataLayers;
}
