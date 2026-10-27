using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADC RID: 23260
	public class ITreasureBoxComponentT
	{
		// Token: 0x1700AF4D RID: 44877
		// (get) Token: 0x06027AC0 RID: 162496 RVA: 0x00574F08 File Offset: 0x00573108
		// (set) Token: 0x06027AC1 RID: 162497 RVA: 0x00574F10 File Offset: 0x00573110
		public bool Disabled { get; set; }

		// Token: 0x1700AF4E RID: 44878
		// (get) Token: 0x06027AC2 RID: 162498 RVA: 0x00574F19 File Offset: 0x00573119
		// (set) Token: 0x06027AC3 RID: 162499 RVA: 0x00574F21 File Offset: 0x00573121
		public int TypeId { get; set; }

		// Token: 0x1700AF4F RID: 44879
		// (get) Token: 0x06027AC4 RID: 162500 RVA: 0x00574F2A File Offset: 0x0057312A
		// (set) Token: 0x06027AC5 RID: 162501 RVA: 0x00574F32 File Offset: 0x00573132
		public bool IsSupportDiscoverDevice { get; set; }

		// Token: 0x1700AF50 RID: 44880
		// (get) Token: 0x06027AC6 RID: 162502 RVA: 0x00574F3B File Offset: 0x0057313B
		// (set) Token: 0x06027AC7 RID: 162503 RVA: 0x00574F43 File Offset: 0x00573143
		public byte NullMask { get; set; }

		// Token: 0x06027AC8 RID: 162504 RVA: 0x00574F4C File Offset: 0x0057314C
		public ITreasureBoxComponentT()
		{
			this.Disabled = false;
			this.TypeId = 0;
			this.IsSupportDiscoverDevice = false;
			this.NullMask = 0;
		}
	}
}
