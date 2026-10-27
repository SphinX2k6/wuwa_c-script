using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044DA RID: 17626
	public class IHitZoneTimesResultT
	{
		// Token: 0x17007C68 RID: 31848
		// (get) Token: 0x0601A5A2 RID: 107938 RVA: 0x003C2FBD File Offset: 0x003C11BD
		// (set) Token: 0x0601A5A3 RID: 107939 RVA: 0x003C2FC5 File Offset: 0x003C11C5
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17007C69 RID: 31849
		// (get) Token: 0x0601A5A4 RID: 107940 RVA: 0x003C2FCE File Offset: 0x003C11CE
		// (set) Token: 0x0601A5A5 RID: 107941 RVA: 0x003C2FD6 File Offset: 0x003C11D6
		public int HitTimes { get; set; }

		// Token: 0x17007C6A RID: 31850
		// (get) Token: 0x0601A5A6 RID: 107942 RVA: 0x003C2FDF File Offset: 0x003C11DF
		// (set) Token: 0x0601A5A7 RID: 107943 RVA: 0x003C2FE7 File Offset: 0x003C11E7
		public List<TDartboardZoneUnion> Zones { get; set; }

		// Token: 0x0601A5A8 RID: 107944 RVA: 0x003C2FF0 File Offset: 0x003C11F0
		public IHitZoneTimesResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.HitTimes = 0;
			this.Zones = null;
		}
	}
}
