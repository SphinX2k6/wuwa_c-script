using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200493C RID: 18748
	public class IHitPlayerLastZoneResultT
	{
		// Token: 0x1700829B RID: 33435
		// (get) Token: 0x0601BD35 RID: 113973 RVA: 0x003EE8EC File Offset: 0x003ECAEC
		// (set) Token: 0x0601BD36 RID: 113974 RVA: 0x003EE8F4 File Offset: 0x003ECAF4
		public EDartSkillResultType Type { get; set; }

		// Token: 0x1700829C RID: 33436
		// (get) Token: 0x0601BD37 RID: 113975 RVA: 0x003EE8FD File Offset: 0x003ECAFD
		// (set) Token: 0x0601BD38 RID: 113976 RVA: 0x003EE905 File Offset: 0x003ECB05
		public int HitTimes { get; set; }

		// Token: 0x0601BD39 RID: 113977 RVA: 0x003EE90E File Offset: 0x003ECB0E
		public IHitPlayerLastZoneResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.HitTimes = 0;
		}
	}
}
