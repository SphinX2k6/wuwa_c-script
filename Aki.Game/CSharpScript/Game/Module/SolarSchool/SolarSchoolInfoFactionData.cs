using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059BA RID: 22970
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct SolarSchoolInfoFactionData
	{
		// Token: 0x17006C39 RID: 27705
		// (get) Token: 0x060389D3 RID: 231891 RVA: 0x00FD7520 File Offset: 0x00FD5720
		public ESolarSchoolInfluence Influence { get; }

		// Token: 0x17006C3A RID: 27706
		// (get) Token: 0x060389D4 RID: 231892 RVA: 0x00FD7528 File Offset: 0x00FD5728
		public int Level { get; }

		// Token: 0x17006C3B RID: 27707
		// (get) Token: 0x060389D5 RID: 231893 RVA: 0x00FD7530 File Offset: 0x00FD5730
		public string IconPath { get; }

		// Token: 0x060389D6 RID: 231894 RVA: 0x00FD7538 File Offset: 0x00FD5738
		public SolarSchoolInfoFactionData(ESolarSchoolInfluence influence, int level, string iconPath)
		{
			this.Influence = influence;
			this.Level = level;
			this.IconPath = iconPath;
		}
	}
}
