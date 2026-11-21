using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005985 RID: 22917
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolRedDotLocalData
	{
		// Token: 0x17006C1E RID: 27678
		// (get) Token: 0x060387DB RID: 231387 RVA: 0x00FCD92E File Offset: 0x00FCBB2E
		// (set) Token: 0x060387DC RID: 231388 RVA: 0x00FCD936 File Offset: 0x00FCBB36
		public bool GoEntranceRedDotConsumed { get; set; }

		// Token: 0x17006C1F RID: 27679
		// (get) Token: 0x060387DD RID: 231389 RVA: 0x00FCD93F File Offset: 0x00FCBB3F
		// (set) Token: 0x060387DE RID: 231390 RVA: 0x00FCD947 File Offset: 0x00FCBB47
		public HashSet<int> ViewedGalleryIds { get; set; } = new HashSet<int>();

		// Token: 0x17006C20 RID: 27680
		// (get) Token: 0x060387DF RID: 231391 RVA: 0x00FCD950 File Offset: 0x00FCBB50
		// (set) Token: 0x060387E0 RID: 231392 RVA: 0x00FCD958 File Offset: 0x00FCBB58
		public HashSet<int> TabAckedGalleryIds { get; set; } = new HashSet<int>();
	}
}
