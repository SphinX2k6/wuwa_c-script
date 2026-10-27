using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006952 RID: 26962
	public class IInfrActivityRoadProcessT
	{
		// Token: 0x1700C801 RID: 51201
		// (get) Token: 0x0602F13E RID: 192830 RVA: 0x0066A7BC File Offset: 0x006689BC
		// (set) Token: 0x0602F13F RID: 192831 RVA: 0x0066A7C4 File Offset: 0x006689C4
		public EInfrActivityBuildStageType Type { get; set; }

		// Token: 0x1700C802 RID: 51202
		// (get) Token: 0x0602F140 RID: 192832 RVA: 0x0066A7CD File Offset: 0x006689CD
		// (set) Token: 0x0602F141 RID: 192833 RVA: 0x0066A7D5 File Offset: 0x006689D5
		public int Id { get; set; }

		// Token: 0x0602F142 RID: 192834 RVA: 0x0066A7DE File Offset: 0x006689DE
		public IInfrActivityRoadProcessT()
		{
			this.Type = EInfrActivityBuildStageType.Infrastructure;
			this.Id = 0;
		}
	}
}
