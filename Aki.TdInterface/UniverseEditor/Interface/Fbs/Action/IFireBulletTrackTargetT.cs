using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BD RID: 26557
	public class IFireBulletTrackTargetT
	{
		// Token: 0x1700C527 RID: 50471
		// (get) Token: 0x0602E3AF RID: 189359 RVA: 0x006506E3 File Offset: 0x0064E8E3
		// (set) Token: 0x0602E3B0 RID: 189360 RVA: 0x006506EB File Offset: 0x0064E8EB
		public EFireBulletType Type { get; set; }

		// Token: 0x1700C528 RID: 50472
		// (get) Token: 0x0602E3B1 RID: 189361 RVA: 0x006506F4 File Offset: 0x0064E8F4
		// (set) Token: 0x0602E3B2 RID: 189362 RVA: 0x006506FC File Offset: 0x0064E8FC
		public long BulletId { get; set; }

		// Token: 0x1700C529 RID: 50473
		// (get) Token: 0x0602E3B3 RID: 189363 RVA: 0x00650705 File Offset: 0x0064E905
		// (set) Token: 0x0602E3B4 RID: 189364 RVA: 0x0065070D File Offset: 0x0064E90D
		public TTargetEntityUnion Launcher { get; set; }

		// Token: 0x1700C52A RID: 50474
		// (get) Token: 0x0602E3B5 RID: 189365 RVA: 0x00650716 File Offset: 0x0064E916
		// (set) Token: 0x0602E3B6 RID: 189366 RVA: 0x0065071E File Offset: 0x0064E91E
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700C52B RID: 50475
		// (get) Token: 0x0602E3B7 RID: 189367 RVA: 0x00650727 File Offset: 0x0064E927
		// (set) Token: 0x0602E3B8 RID: 189368 RVA: 0x0065072F File Offset: 0x0064E92F
		public bool WaitDestroy { get; set; }

		// Token: 0x1700C52C RID: 50476
		// (get) Token: 0x0602E3B9 RID: 189369 RVA: 0x00650738 File Offset: 0x0064E938
		// (set) Token: 0x0602E3BA RID: 189370 RVA: 0x00650740 File Offset: 0x0064E940
		public byte NullMask { get; set; }

		// Token: 0x0602E3BB RID: 189371 RVA: 0x00650749 File Offset: 0x0064E949
		public IFireBulletTrackTargetT()
		{
			this.Type = EFireBulletType.TrackTarget;
			this.BulletId = 0L;
			this.Launcher = null;
			this.Target = null;
			this.WaitDestroy = false;
			this.NullMask = 0;
		}
	}
}
