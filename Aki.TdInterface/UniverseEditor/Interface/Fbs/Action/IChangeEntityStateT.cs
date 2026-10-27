using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062EB RID: 25323
	public class IChangeEntityStateT
	{
		// Token: 0x1700BCF7 RID: 48375
		// (get) Token: 0x0602BC4D RID: 179277 RVA: 0x006055D8 File Offset: 0x006037D8
		// (set) Token: 0x0602BC4E RID: 179278 RVA: 0x006055E0 File Offset: 0x006037E0
		public EChangeEntityState Type { get; set; }

		// Token: 0x1700BCF8 RID: 48376
		// (get) Token: 0x0602BC4F RID: 179279 RVA: 0x006055E9 File Offset: 0x006037E9
		// (set) Token: 0x0602BC50 RID: 179280 RVA: 0x006055F1 File Offset: 0x006037F1
		public int EntityId { get; set; }

		// Token: 0x0602BC51 RID: 179281 RVA: 0x006055FA File Offset: 0x006037FA
		public IChangeEntityStateT()
		{
			this.Type = EChangeEntityState.Directly;
			this.EntityId = 0;
		}
	}
}
