using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4E RID: 27726
	public class IDisableInRangeMotorRadioOperationT
	{
		// Token: 0x1700CB3E RID: 52030
		// (get) Token: 0x0602FBB1 RID: 195505 RVA: 0x00680149 File Offset: 0x0067E349
		// (set) Token: 0x0602FBB2 RID: 195506 RVA: 0x00680151 File Offset: 0x0067E351
		public EMotorRadioOperationType Type { get; set; }

		// Token: 0x1700CB3F RID: 52031
		// (get) Token: 0x0602FBB3 RID: 195507 RVA: 0x0068015A File Offset: 0x0067E35A
		// (set) Token: 0x0602FBB4 RID: 195508 RVA: 0x00680162 File Offset: 0x0067E362
		public string RangeKey { get; set; }

		// Token: 0x1700CB40 RID: 52032
		// (get) Token: 0x0602FBB5 RID: 195509 RVA: 0x0068016B File Offset: 0x0067E36B
		// (set) Token: 0x0602FBB6 RID: 195510 RVA: 0x00680173 File Offset: 0x0067E373
		public TMotorRadioDisableRangeUnion DisableRangeType { get; set; }

		// Token: 0x0602FBB7 RID: 195511 RVA: 0x0068017C File Offset: 0x0067E37C
		public IDisableInRangeMotorRadioOperationT()
		{
			this.Type = EMotorRadioOperationType.EnableAll;
			this.RangeKey = null;
			this.DisableRangeType = null;
		}
	}
}
