using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ED3 RID: 20179
	public class ICheckEntityPrefabPerformanceTypeT
	{
		// Token: 0x17009017 RID: 36887
		// (get) Token: 0x0601F52A RID: 128298 RVA: 0x0045D8AB File Offset: 0x0045BAAB
		// (set) Token: 0x0601F52B RID: 128299 RVA: 0x0045D8B3 File Offset: 0x0045BAB3
		public ECondition Type { get; set; }

		// Token: 0x17009018 RID: 36888
		// (get) Token: 0x0601F52C RID: 128300 RVA: 0x0045D8BC File Offset: 0x0045BABC
		// (set) Token: 0x0601F52D RID: 128301 RVA: 0x0045D8C4 File Offset: 0x0045BAC4
		public int EntityId { get; set; }

		// Token: 0x17009019 RID: 36889
		// (get) Token: 0x0601F52E RID: 128302 RVA: 0x0045D8CD File Offset: 0x0045BACD
		// (set) Token: 0x0601F52F RID: 128303 RVA: 0x0045D8D5 File Offset: 0x0045BAD5
		public string PerformanceTag { get; set; }

		// Token: 0x1700901A RID: 36890
		// (get) Token: 0x0601F530 RID: 128304 RVA: 0x0045D8DE File Offset: 0x0045BADE
		// (set) Token: 0x0601F531 RID: 128305 RVA: 0x0045D8E6 File Offset: 0x0045BAE6
		public ECompare Compare { get; set; }

		// Token: 0x0601F532 RID: 128306 RVA: 0x0045D8EF File Offset: 0x0045BAEF
		public ICheckEntityPrefabPerformanceTypeT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.PerformanceTag = null;
			this.Compare = ECompare.Eq;
		}
	}
}
