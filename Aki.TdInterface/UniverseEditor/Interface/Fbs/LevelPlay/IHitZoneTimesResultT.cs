using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004942 RID: 18754
	public class IHitZoneTimesResultT
	{
		// Token: 0x170082A7 RID: 33447
		// (get) Token: 0x0601BD73 RID: 114035 RVA: 0x003EF1C9 File Offset: 0x003ED3C9
		// (set) Token: 0x0601BD74 RID: 114036 RVA: 0x003EF1D1 File Offset: 0x003ED3D1
		public EDartSkillResultType Type { get; set; }

		// Token: 0x170082A8 RID: 33448
		// (get) Token: 0x0601BD75 RID: 114037 RVA: 0x003EF1DA File Offset: 0x003ED3DA
		// (set) Token: 0x0601BD76 RID: 114038 RVA: 0x003EF1E2 File Offset: 0x003ED3E2
		public int HitTimes { get; set; }

		// Token: 0x170082A9 RID: 33449
		// (get) Token: 0x0601BD77 RID: 114039 RVA: 0x003EF1EB File Offset: 0x003ED3EB
		// (set) Token: 0x0601BD78 RID: 114040 RVA: 0x003EF1F3 File Offset: 0x003ED3F3
		public List<TDartboardZoneUnion> Zones { get; set; }

		// Token: 0x0601BD79 RID: 114041 RVA: 0x003EF1FC File Offset: 0x003ED3FC
		public IHitZoneTimesResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.HitTimes = 0;
			this.Zones = null;
		}
	}
}
