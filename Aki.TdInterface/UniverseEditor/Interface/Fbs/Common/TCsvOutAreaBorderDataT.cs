using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B9 RID: 25785
	public class TCsvOutAreaBorderDataT
	{
		// Token: 0x1700BE31 RID: 48689
		// (get) Token: 0x0602BD70 RID: 179568 RVA: 0x005F64CB File Offset: 0x005F46CB
		// (set) Token: 0x0602BD71 RID: 179569 RVA: 0x005F64D3 File Offset: 0x005F46D3
		public int Id { get; set; }

		// Token: 0x1700BE32 RID: 48690
		// (get) Token: 0x0602BD72 RID: 179570 RVA: 0x005F64DC File Offset: 0x005F46DC
		// (set) Token: 0x0602BD73 RID: 179571 RVA: 0x005F64E4 File Offset: 0x005F46E4
		public IOutAreaBorderTimerConfigT Data { get; set; }

		// Token: 0x0602BD74 RID: 179572 RVA: 0x005F64ED File Offset: 0x005F46ED
		public TCsvOutAreaBorderDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
