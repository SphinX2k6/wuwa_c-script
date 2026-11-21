using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EA6 RID: 20134
	public class ICheckElementalWaterBoxStagnationSeqT
	{
		// Token: 0x17008FA3 RID: 36771
		// (get) Token: 0x0601F35B RID: 127835 RVA: 0x00459EF6 File Offset: 0x004580F6
		// (set) Token: 0x0601F35C RID: 127836 RVA: 0x00459EFE File Offset: 0x004580FE
		public ECondition Type { get; set; }

		// Token: 0x17008FA4 RID: 36772
		// (get) Token: 0x0601F35D RID: 127837 RVA: 0x00459F07 File Offset: 0x00458107
		// (set) Token: 0x0601F35E RID: 127838 RVA: 0x00459F0F File Offset: 0x0045810F
		public int EntityId { get; set; }

		// Token: 0x17008FA5 RID: 36773
		// (get) Token: 0x0601F35F RID: 127839 RVA: 0x00459F18 File Offset: 0x00458118
		// (set) Token: 0x0601F360 RID: 127840 RVA: 0x00459F20 File Offset: 0x00458120
		public string StartMark { get; set; }

		// Token: 0x17008FA6 RID: 36774
		// (get) Token: 0x0601F361 RID: 127841 RVA: 0x00459F29 File Offset: 0x00458129
		// (set) Token: 0x0601F362 RID: 127842 RVA: 0x00459F31 File Offset: 0x00458131
		public string EndMark { get; set; }

		// Token: 0x0601F363 RID: 127843 RVA: 0x00459F3A File Offset: 0x0045813A
		public ICheckElementalWaterBoxStagnationSeqT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.StartMark = null;
			this.EndMark = null;
		}
	}
}
