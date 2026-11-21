using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACF RID: 23247
	public class IMechHookInteractConfigT
	{
		// Token: 0x1700A97F RID: 43391
		// (get) Token: 0x06026250 RID: 156240 RVA: 0x0053A004 File Offset: 0x00538204
		// (set) Token: 0x06026251 RID: 156241 RVA: 0x0053A00C File Offset: 0x0053820C
		public TMechHookInteractTypeUnion InteractType { get; set; }

		// Token: 0x1700A980 RID: 43392
		// (get) Token: 0x06026252 RID: 156242 RVA: 0x0053A015 File Offset: 0x00538215
		// (set) Token: 0x06026253 RID: 156243 RVA: 0x0053A01D File Offset: 0x0053821D
		public IMechHookAccelerationT MechHookAcceleration { get; set; }

		// Token: 0x1700A981 RID: 43393
		// (get) Token: 0x06026254 RID: 156244 RVA: 0x0053A026 File Offset: 0x00538226
		// (set) Token: 0x06026255 RID: 156245 RVA: 0x0053A02E File Offset: 0x0053822E
		public IInteractSectorRangeT SectorRange { get; set; }

		// Token: 0x1700A982 RID: 43394
		// (get) Token: 0x06026256 RID: 156246 RVA: 0x0053A037 File Offset: 0x00538237
		// (set) Token: 0x06026257 RID: 156247 RVA: 0x0053A03F File Offset: 0x0053823F
		public float Radius { get; set; }

		// Token: 0x1700A983 RID: 43395
		// (get) Token: 0x06026258 RID: 156248 RVA: 0x0053A048 File Offset: 0x00538248
		// (set) Token: 0x06026259 RID: 156249 RVA: 0x0053A050 File Offset: 0x00538250
		public float NonInteractiveInnerRadius { get; set; }

		// Token: 0x1700A984 RID: 43396
		// (get) Token: 0x0602625A RID: 156250 RVA: 0x0053A059 File Offset: 0x00538259
		// (set) Token: 0x0602625B RID: 156251 RVA: 0x0053A061 File Offset: 0x00538261
		public byte NullMask { get; set; }

		// Token: 0x0602625C RID: 156252 RVA: 0x0053A06A File Offset: 0x0053826A
		public IMechHookInteractConfigT()
		{
			this.InteractType = null;
			this.MechHookAcceleration = null;
			this.SectorRange = null;
			this.Radius = 0f;
			this.NonInteractiveInnerRadius = 0f;
			this.NullMask = 0;
		}
	}
}
