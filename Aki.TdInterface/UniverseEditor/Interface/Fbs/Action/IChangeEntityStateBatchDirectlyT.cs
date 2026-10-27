using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062EE RID: 25326
	public class IChangeEntityStateBatchDirectlyT
	{
		// Token: 0x1700BD00 RID: 48384
		// (get) Token: 0x0602BC75 RID: 179317 RVA: 0x00605ACB File Offset: 0x00603CCB
		// (set) Token: 0x0602BC76 RID: 179318 RVA: 0x00605AD3 File Offset: 0x00603CD3
		public EChangeEntityState Type { get; set; }

		// Token: 0x1700BD01 RID: 48385
		// (get) Token: 0x0602BC77 RID: 179319 RVA: 0x00605ADC File Offset: 0x00603CDC
		// (set) Token: 0x0602BC78 RID: 179320 RVA: 0x00605AE4 File Offset: 0x00603CE4
		public int EntityId { get; set; }

		// Token: 0x1700BD02 RID: 48386
		// (get) Token: 0x0602BC79 RID: 179321 RVA: 0x00605AED File Offset: 0x00603CED
		// (set) Token: 0x0602BC7A RID: 179322 RVA: 0x00605AF5 File Offset: 0x00603CF5
		public List<int> EntityIds { get; set; }

		// Token: 0x1700BD03 RID: 48387
		// (get) Token: 0x0602BC7B RID: 179323 RVA: 0x00605AFE File Offset: 0x00603CFE
		// (set) Token: 0x0602BC7C RID: 179324 RVA: 0x00605B06 File Offset: 0x00603D06
		public string State { get; set; }

		// Token: 0x1700BD04 RID: 48388
		// (get) Token: 0x0602BC7D RID: 179325 RVA: 0x00605B0F File Offset: 0x00603D0F
		// (set) Token: 0x0602BC7E RID: 179326 RVA: 0x00605B17 File Offset: 0x00603D17
		public bool DelayChange { get; set; }

		// Token: 0x1700BD05 RID: 48389
		// (get) Token: 0x0602BC7F RID: 179327 RVA: 0x00605B20 File Offset: 0x00603D20
		// (set) Token: 0x0602BC80 RID: 179328 RVA: 0x00605B28 File Offset: 0x00603D28
		public byte NullMask { get; set; }

		// Token: 0x0602BC81 RID: 179329 RVA: 0x00605B31 File Offset: 0x00603D31
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
