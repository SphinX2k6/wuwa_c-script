using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073CB RID: 29643
	public class IPathLineFacingCurrentDirectionT
	{
		// Token: 0x1700D9C0 RID: 55744
		// (get) Token: 0x06033D9A RID: 212378 RVA: 0x006FE272 File Offset: 0x006FC472
		// (set) Token: 0x06033D9B RID: 212379 RVA: 0x006FE27A File Offset: 0x006FC47A
		public EPathLineFacingType Type { get; set; }

		// Token: 0x1700D9C1 RID: 55745
		// (get) Token: 0x06033D9C RID: 212380 RVA: 0x006FE283 File Offset: 0x006FC483
		// (set) Token: 0x06033D9D RID: 212381 RVA: 0x006FE28B File Offset: 0x006FC48B
		public float YawOffset { get; set; }

		// Token: 0x1700D9C2 RID: 55746
		// (get) Token: 0x06033D9E RID: 212382 RVA: 0x006FE294 File Offset: 0x006FC494
		// (set) Token: 0x06033D9F RID: 212383 RVA: 0x006FE29C File Offset: 0x006FC49C
		public byte NullMask { get; set; }

		// Token: 0x06033DA0 RID: 212384 RVA: 0x006FE2A5 File Offset: 0x006FC4A5
		public IPathLineFacingCurrentDirectionT()
		{
			this.Type = EPathLineFacingType.Current;
			this.YawOffset = 0f;
			this.NullMask = 0;
		}
	}
}
