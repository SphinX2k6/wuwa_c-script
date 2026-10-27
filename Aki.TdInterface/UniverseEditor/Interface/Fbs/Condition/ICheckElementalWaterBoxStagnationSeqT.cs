using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049E6 RID: 18918
	public class ICheckElementalWaterBoxStagnationSeqT
	{
		// Token: 0x170088D3 RID: 35027
		// (get) Token: 0x0601D8E8 RID: 121064 RVA: 0x0042928A File Offset: 0x0042748A
		// (set) Token: 0x0601D8E9 RID: 121065 RVA: 0x00429292 File Offset: 0x00427492
		public ECondition Type { get; set; }

		// Token: 0x170088D4 RID: 35028
		// (get) Token: 0x0601D8EA RID: 121066 RVA: 0x0042929B File Offset: 0x0042749B
		// (set) Token: 0x0601D8EB RID: 121067 RVA: 0x004292A3 File Offset: 0x004274A3
		public int EntityId { get; set; }

		// Token: 0x170088D5 RID: 35029
		// (get) Token: 0x0601D8EC RID: 121068 RVA: 0x004292AC File Offset: 0x004274AC
		// (set) Token: 0x0601D8ED RID: 121069 RVA: 0x004292B4 File Offset: 0x004274B4
		public string StartMark { get; set; }

		// Token: 0x170088D6 RID: 35030
		// (get) Token: 0x0601D8EE RID: 121070 RVA: 0x004292BD File Offset: 0x004274BD
		// (set) Token: 0x0601D8EF RID: 121071 RVA: 0x004292C5 File Offset: 0x004274C5
		public string EndMark { get; set; }

		// Token: 0x0601D8F0 RID: 121072 RVA: 0x004292CE File Offset: 0x004274CE
		public ICheckElementalWaterBoxStagnationSeqT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.StartMark = null;
			this.EndMark = null;
		}
	}
}
