using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C14 RID: 19476
	public class IEntityEventConditionT
	{
		// Token: 0x17008D78 RID: 36216
		// (get) Token: 0x0601ED95 RID: 126357 RVA: 0x00451A75 File Offset: 0x0044FC75
		// (set) Token: 0x0601ED96 RID: 126358 RVA: 0x00451A7D File Offset: 0x0044FC7D
		public int EntityId { get; set; }

		// Token: 0x17008D79 RID: 36217
		// (get) Token: 0x0601ED97 RID: 126359 RVA: 0x00451A86 File Offset: 0x0044FC86
		// (set) Token: 0x0601ED98 RID: 126360 RVA: 0x00451A8E File Offset: 0x0044FC8E
		public string State { get; set; }

		// Token: 0x17008D7A RID: 36218
		// (get) Token: 0x0601ED99 RID: 126361 RVA: 0x00451A97 File Offset: 0x0044FC97
		// (set) Token: 0x0601ED9A RID: 126362 RVA: 0x00451A9F File Offset: 0x0044FC9F
		public bool IsDead { get; set; }

		// Token: 0x17008D7B RID: 36219
		// (get) Token: 0x0601ED9B RID: 126363 RVA: 0x00451AA8 File Offset: 0x0044FCA8
		// (set) Token: 0x0601ED9C RID: 126364 RVA: 0x00451AB0 File Offset: 0x0044FCB0
		public bool IsLocked { get; set; }

		// Token: 0x17008D7C RID: 36220
		// (get) Token: 0x0601ED9D RID: 126365 RVA: 0x00451AB9 File Offset: 0x0044FCB9
		// (set) Token: 0x0601ED9E RID: 126366 RVA: 0x00451AC1 File Offset: 0x0044FCC1
		public byte NullMask { get; set; }

		// Token: 0x0601ED9F RID: 126367 RVA: 0x00451ACA File Offset: 0x0044FCCA
		public IEntityEventConditionT()
		{
			this.EntityId = 0;
			this.State = null;
			this.IsDead = false;
			this.IsLocked = false;
			this.NullMask = 0;
		}
	}
}
