using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050E3 RID: 20707
	public class ICustomJsonConditionT
	{
		// Token: 0x17009465 RID: 37989
		// (get) Token: 0x06020889 RID: 133257 RVA: 0x004838E8 File Offset: 0x00481AE8
		// (set) Token: 0x0602088A RID: 133258 RVA: 0x004838F0 File Offset: 0x00481AF0
		public ECondition Type { get; set; }

		// Token: 0x17009466 RID: 37990
		// (get) Token: 0x0602088B RID: 133259 RVA: 0x004838F9 File Offset: 0x00481AF9
		// (set) Token: 0x0602088C RID: 133260 RVA: 0x00483901 File Offset: 0x00481B01
		public string Name { get; set; }

		// Token: 0x17009467 RID: 37991
		// (get) Token: 0x0602088D RID: 133261 RVA: 0x0048390A File Offset: 0x00481B0A
		// (set) Token: 0x0602088E RID: 133262 RVA: 0x00483912 File Offset: 0x00481B12
		public string JsonString { get; set; }

		// Token: 0x0602088F RID: 133263 RVA: 0x0048391B File Offset: 0x00481B1B
		public ICustomJsonConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Name = null;
			this.JsonString = null;
		}
	}
}
