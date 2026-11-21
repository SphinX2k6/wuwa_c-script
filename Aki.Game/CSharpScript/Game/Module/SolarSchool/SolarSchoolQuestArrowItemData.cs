using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A46 RID: 23110
	public class SolarSchoolQuestArrowItemData
	{
		// Token: 0x17006C85 RID: 27781
		// (get) Token: 0x06038F6B RID: 233323 RVA: 0x00FF5E8C File Offset: 0x00FF408C
		public bool HasAnyLine
		{
			get
			{
				return this.HasTopLine || this.HasMiddleLine || this.HasBottomLine;
			}
		}

		// Token: 0x0401DFB3 RID: 122803
		public int QuestId;

		// Token: 0x0401DFB4 RID: 122804
		public bool HasTopLine;

		// Token: 0x0401DFB5 RID: 122805
		public bool HasMiddleLine;

		// Token: 0x0401DFB6 RID: 122806
		public bool HasBottomLine;

		// Token: 0x0401DFB7 RID: 122807
		[Nullable(1)]
		public List<SolarSchoolQuestEdgeData> Edges = new List<SolarSchoolQuestEdgeData>();
	}
}
