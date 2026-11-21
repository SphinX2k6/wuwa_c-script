using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B8 RID: 22968
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct SolarSchoolInfoAttrData
	{
		// Token: 0x17006C33 RID: 27699
		// (get) Token: 0x060389CA RID: 231882 RVA: 0x00FD73F3 File Offset: 0x00FD55F3
		public ESolarSchoolSecondAttr Attr { get; }

		// Token: 0x17006C34 RID: 27700
		// (get) Token: 0x060389CB RID: 231883 RVA: 0x00FD73FB File Offset: 0x00FD55FB
		public string NameTextId { get; }

		// Token: 0x17006C35 RID: 27701
		// (get) Token: 0x060389CC RID: 231884 RVA: 0x00FD7403 File Offset: 0x00FD5603
		public string IconPath { get; }

		// Token: 0x17006C36 RID: 27702
		// (get) Token: 0x060389CD RID: 231885 RVA: 0x00FD740B File Offset: 0x00FD560B
		public string RankIconPath { get; }

		// Token: 0x17006C37 RID: 27703
		// (get) Token: 0x060389CE RID: 231886 RVA: 0x00FD7413 File Offset: 0x00FD5613
		public int Value { get; }

		// Token: 0x17006C38 RID: 27704
		// (get) Token: 0x060389CF RID: 231887 RVA: 0x00FD741B File Offset: 0x00FD561B
		public float RankRatio { get; }

		// Token: 0x060389D0 RID: 231888 RVA: 0x00FD7423 File Offset: 0x00FD5623
		public SolarSchoolInfoAttrData(ESolarSchoolSecondAttr attr, string nameTextId, string iconPath, string rankIconPath, int value, float rankRatio)
		{
			this.Attr = attr;
			this.NameTextId = nameTextId;
			this.IconPath = iconPath;
			this.RankIconPath = rankIconPath;
			this.Value = value;
			this.RankRatio = rankRatio;
		}
	}
}
