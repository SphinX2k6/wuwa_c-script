using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005983 RID: 22915
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolActivityLocalData
	{
		// Token: 0x17006C1C RID: 27676
		// (get) Token: 0x060387D5 RID: 231381 RVA: 0x00FCD8E6 File Offset: 0x00FCBAE6
		// (set) Token: 0x060387D6 RID: 231382 RVA: 0x00FCD8EE File Offset: 0x00FCBAEE
		public Dictionary<int, SolarSchoolSlotLocalData> Slots { get; set; } = new Dictionary<int, SolarSchoolSlotLocalData>();
	}
}
