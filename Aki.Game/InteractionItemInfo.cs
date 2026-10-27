using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020016F2 RID: 5874
[NullableContext(1)]
[Nullable(0)]
public class InteractionItemInfo
{
	// Token: 0x17000DF3 RID: 3571
	// (get) Token: 0x0600A865 RID: 43109 RVA: 0x0025D9BC File Offset: 0x0025BBBC
	// (set) Token: 0x0600A866 RID: 43110 RVA: 0x0025D9C4 File Offset: 0x0025BBC4
	public IReadOnlySet<string> Foliages { get; set; }

	// Token: 0x17000DF4 RID: 3572
	// (get) Token: 0x0600A867 RID: 43111 RVA: 0x0025D9CD File Offset: 0x0025BBCD
	// (set) Token: 0x0600A868 RID: 43112 RVA: 0x0025D9D5 File Offset: 0x0025BBD5
	public IReadOnlySet<string> StaticMeshes { get; set; }

	// Token: 0x17000DF5 RID: 3573
	// (get) Token: 0x0600A869 RID: 43113 RVA: 0x0025D9DE File Offset: 0x0025BBDE
	// (set) Token: 0x0600A86A RID: 43114 RVA: 0x0025D9E6 File Offset: 0x0025BBE6
	public string AudioKey { get; set; }

	// Token: 0x0600A86B RID: 43115 RVA: 0x0025D9EF File Offset: 0x0025BBEF
	public InteractionItemInfo(IReadOnlySet<string> foliages, IReadOnlySet<string> staticMeshes, string audioKey)
	{
		this.Foliages = foliages;
		this.StaticMeshes = staticMeshes;
		this.AudioKey = audioKey;
	}
}
