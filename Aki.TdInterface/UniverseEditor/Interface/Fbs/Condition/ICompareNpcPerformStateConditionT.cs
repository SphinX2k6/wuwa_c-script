using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BBA RID: 19386
	public class ICompareNpcPerformStateConditionT
	{
		// Token: 0x17008CC1 RID: 36033
		// (get) Token: 0x0601E94E RID: 125262 RVA: 0x00446F3B File Offset: 0x0044513B
		// (set) Token: 0x0601E94F RID: 125263 RVA: 0x00446F43 File Offset: 0x00445143
		public ECondition Type { get; set; }

		// Token: 0x17008CC2 RID: 36034
		// (get) Token: 0x0601E950 RID: 125264 RVA: 0x00446F4C File Offset: 0x0044514C
		// (set) Token: 0x0601E951 RID: 125265 RVA: 0x00446F54 File Offset: 0x00445154
		public int EntityId { get; set; }

		// Token: 0x17008CC3 RID: 36035
		// (get) Token: 0x0601E952 RID: 125266 RVA: 0x00446F5D File Offset: 0x0044515D
		// (set) Token: 0x0601E953 RID: 125267 RVA: 0x00446F65 File Offset: 0x00445165
		public ECompare Compare { get; set; }

		// Token: 0x17008CC4 RID: 36036
		// (get) Token: 0x0601E954 RID: 125268 RVA: 0x00446F6E File Offset: 0x0044516E
		// (set) Token: 0x0601E955 RID: 125269 RVA: 0x00446F76 File Offset: 0x00445176
		public string State { get; set; }

		// Token: 0x0601E956 RID: 125270 RVA: 0x00446F7F File Offset: 0x0044517F
		public ICompareNpcPerformStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.Compare = ECompare.Eq;
			this.State = null;
		}
	}
}
