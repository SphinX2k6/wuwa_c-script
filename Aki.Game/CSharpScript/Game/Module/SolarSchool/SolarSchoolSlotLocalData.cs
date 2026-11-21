using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005984 RID: 22916
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolSlotLocalData
	{
		// Token: 0x17006C1D RID: 27677
		// (get) Token: 0x060387D8 RID: 231384 RVA: 0x00FCD90A File Offset: 0x00FCBB0A
		// (set) Token: 0x060387D9 RID: 231385 RVA: 0x00FCD912 File Offset: 0x00FCBB12
		public Dictionary<ESolarSchoolLocalRecordType, HashSet<int>> Records { get; set; } = new Dictionary<ESolarSchoolLocalRecordType, HashSet<int>>();
	}
}
