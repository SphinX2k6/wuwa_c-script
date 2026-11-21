using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695F RID: 26975
	public class IChangeEntityStateBatchDirectlyT
	{
		// Token: 0x1700C68A RID: 50826
		// (get) Token: 0x0602E3DE RID: 189406 RVA: 0x00650AD7 File Offset: 0x0064ECD7
		// (set) Token: 0x0602E3DF RID: 189407 RVA: 0x00650ADF File Offset: 0x0064ECDF
		public EChangeEntityState Type { get; set; }

		// Token: 0x1700C68B RID: 50827
		// (get) Token: 0x0602E3E0 RID: 189408 RVA: 0x00650AE8 File Offset: 0x0064ECE8
		// (set) Token: 0x0602E3E1 RID: 189409 RVA: 0x00650AF0 File Offset: 0x0064ECF0
		public int EntityId { get; set; }

		// Token: 0x1700C68C RID: 50828
		// (get) Token: 0x0602E3E2 RID: 189410 RVA: 0x00650AF9 File Offset: 0x0064ECF9
		// (set) Token: 0x0602E3E3 RID: 189411 RVA: 0x00650B01 File Offset: 0x0064ED01
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C68D RID: 50829
		// (get) Token: 0x0602E3E4 RID: 189412 RVA: 0x00650B0A File Offset: 0x0064ED0A
		// (set) Token: 0x0602E3E5 RID: 189413 RVA: 0x00650B12 File Offset: 0x0064ED12
		public string State { get; set; }

		// Token: 0x1700C68E RID: 50830
		// (get) Token: 0x0602E3E6 RID: 189414 RVA: 0x00650B1B File Offset: 0x0064ED1B
		// (set) Token: 0x0602E3E7 RID: 189415 RVA: 0x00650B23 File Offset: 0x0064ED23
		public bool DelayChange { get; set; }

		// Token: 0x1700C68F RID: 50831
		// (get) Token: 0x0602E3E8 RID: 189416 RVA: 0x00650B2C File Offset: 0x0064ED2C
		// (set) Token: 0x0602E3E9 RID: 189417 RVA: 0x00650B34 File Offset: 0x0064ED34
		public byte NullMask { get; set; }

		// Token: 0x0602E3EA RID: 189418 RVA: 0x00650B3D File Offset: 0x0064ED3D
		public IChangeEntityStateBatchDirectlyT()
		{
			this.Type = EChangeEntityState.Directly;
			this.EntityId = 0;
			this.EntityIds = null;
			this.State = null;
			this.DelayChange = false;
			this.NullMask = 0;
		}
	}
}
