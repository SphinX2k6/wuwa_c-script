using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044D4 RID: 17620
	public class IHitPlayerLastZoneResultT
	{
		// Token: 0x17007C5C RID: 31836
		// (get) Token: 0x0601A564 RID: 107876 RVA: 0x003C26E0 File Offset: 0x003C08E0
		// (set) Token: 0x0601A565 RID: 107877 RVA: 0x003C26E8 File Offset: 0x003C08E8
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17007C5D RID: 31837
		// (get) Token: 0x0601A566 RID: 107878 RVA: 0x003C26F1 File Offset: 0x003C08F1
		// (set) Token: 0x0601A567 RID: 107879 RVA: 0x003C26F9 File Offset: 0x003C08F9
		public int HitTimes { get; set; }

		// Token: 0x0601A568 RID: 107880 RVA: 0x003C2702 File Offset: 0x003C0902
		public IHitPlayerLastZoneResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.HitTimes = 0;
		}
	}
}
