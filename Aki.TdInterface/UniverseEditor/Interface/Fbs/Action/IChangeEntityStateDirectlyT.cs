using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062F1 RID: 25329
	public class IChangeEntityStateDirectlyT
	{
		// Token: 0x1700BD0C RID: 48396
		// (get) Token: 0x0602BC9B RID: 179355 RVA: 0x00605ECD File Offset: 0x006040CD
		// (set) Token: 0x0602BC9C RID: 179356 RVA: 0x00605ED5 File Offset: 0x006040D5
		public EChangeEntityState Type { get; set; }

		// Token: 0x1700BD0D RID: 48397
		// (get) Token: 0x0602BC9D RID: 179357 RVA: 0x00605EDE File Offset: 0x006040DE
		// (set) Token: 0x0602BC9E RID: 179358 RVA: 0x00605EE6 File Offset: 0x006040E6
		public int EntityId { get; set; }

		// Token: 0x1700BD0E RID: 48398
		// (get) Token: 0x0602BC9F RID: 179359 RVA: 0x00605EEF File Offset: 0x006040EF
		// (set) Token: 0x0602BCA0 RID: 179360 RVA: 0x00605EF7 File Offset: 0x006040F7
		public string State { get; set; }

		// Token: 0x1700BD0F RID: 48399
		// (get) Token: 0x0602BCA1 RID: 179361 RVA: 0x00605F00 File Offset: 0x00604100
		// (set) Token: 0x0602BCA2 RID: 179362 RVA: 0x00605F08 File Offset: 0x00604108
		public bool DelayChange { get; set; }

		// Token: 0x1700BD10 RID: 48400
		// (get) Token: 0x0602BCA3 RID: 179363 RVA: 0x00605F11 File Offset: 0x00604111
		// (set) Token: 0x0602BCA4 RID: 179364 RVA: 0x00605F19 File Offset: 0x00604119
		public byte NullMask { get; set; }

		// Token: 0x0602BCA5 RID: 179365 RVA: 0x00605F22 File Offset: 0x00604122
		public IChangeEntityStateDirectlyT()
		{
			this.Type = EChangeEntityState.Directly;
			this.EntityId = 0;
			this.State = null;
			this.DelayChange = false;
			this.NullMask = 0;
		}
	}
}
