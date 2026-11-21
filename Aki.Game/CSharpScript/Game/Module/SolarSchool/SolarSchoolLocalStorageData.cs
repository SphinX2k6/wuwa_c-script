using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005982 RID: 22914
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolLocalStorageData
	{
		// Token: 0x17006C1A RID: 27674
		// (get) Token: 0x060387D0 RID: 231376 RVA: 0x00FCD8A6 File Offset: 0x00FCBAA6
		// (set) Token: 0x060387D1 RID: 231377 RVA: 0x00FCD8AE File Offset: 0x00FCBAAE
		public Dictionary<int, SolarSchoolActivityLocalData> Activities { get; set; } = new Dictionary<int, SolarSchoolActivityLocalData>();

		// Token: 0x17006C1B RID: 27675
		// (get) Token: 0x060387D2 RID: 231378 RVA: 0x00FCD8B7 File Offset: 0x00FCBAB7
		// (set) Token: 0x060387D3 RID: 231379 RVA: 0x00FCD8BF File Offset: 0x00FCBABF
		public Dictionary<int, SolarSchoolRedDotLocalData> RedDots { get; set; } = new Dictionary<int, SolarSchoolRedDotLocalData>();
	}
}
