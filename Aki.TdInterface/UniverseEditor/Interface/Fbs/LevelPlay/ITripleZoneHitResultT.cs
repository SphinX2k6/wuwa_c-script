using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A41 RID: 19009
	public class ITripleZoneHitResultT
	{
		// Token: 0x17008561 RID: 34145
		// (get) Token: 0x0601C8DE RID: 116958 RVA: 0x004079E1 File Offset: 0x00405BE1
		// (set) Token: 0x0601C8DF RID: 116959 RVA: 0x004079E9 File Offset: 0x00405BE9
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17008562 RID: 34146
		// (get) Token: 0x0601C8E0 RID: 116960 RVA: 0x004079F2 File Offset: 0x00405BF2
		// (set) Token: 0x0601C8E1 RID: 116961 RVA: 0x004079FA File Offset: 0x00405BFA
		public int Probability { get; set; }

		// Token: 0x17008563 RID: 34147
		// (get) Token: 0x0601C8E2 RID: 116962 RVA: 0x00407A03 File Offset: 0x00405C03
		// (set) Token: 0x0601C8E3 RID: 116963 RVA: 0x00407A0B File Offset: 0x00405C0B
		public List<TDartboardZoneUnion> Zones { get; set; }

		// Token: 0x0601C8E4 RID: 116964 RVA: 0x00407A14 File Offset: 0x00405C14
		public ITripleZoneHitResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.Probability = 0;
			this.Zones = null;
		}
	}
}
