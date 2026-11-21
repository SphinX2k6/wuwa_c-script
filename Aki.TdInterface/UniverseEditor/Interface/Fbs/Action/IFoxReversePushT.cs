using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFA RID: 28410
	public class IFoxReversePushT
	{
		// Token: 0x1700D05A RID: 53338
		// (get) Token: 0x06031297 RID: 201367 RVA: 0x006A9E1D File Offset: 0x006A801D
		// (set) Token: 0x06031298 RID: 201368 RVA: 0x006A9E25 File Offset: 0x006A8025
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D05B RID: 53339
		// (get) Token: 0x06031299 RID: 201369 RVA: 0x006A9E2E File Offset: 0x006A802E
		// (set) Token: 0x0603129A RID: 201370 RVA: 0x006A9E36 File Offset: 0x006A8036
		public int SplineEntityId { get; set; }

		// Token: 0x1700D05C RID: 53340
		// (get) Token: 0x0603129B RID: 201371 RVA: 0x006A9E3F File Offset: 0x006A803F
		// (set) Token: 0x0603129C RID: 201372 RVA: 0x006A9E47 File Offset: 0x006A8047
		public int SeqEntityId { get; set; }

		// Token: 0x1700D05D RID: 53341
		// (get) Token: 0x0603129D RID: 201373 RVA: 0x006A9E50 File Offset: 0x006A8050
		// (set) Token: 0x0603129E RID: 201374 RVA: 0x006A9E58 File Offset: 0x006A8058
		public string SliderTag { get; set; }

		// Token: 0x1700D05E RID: 53342
		// (get) Token: 0x0603129F RID: 201375 RVA: 0x006A9E61 File Offset: 0x006A8061
		// (set) Token: 0x060312A0 RID: 201376 RVA: 0x006A9E69 File Offset: 0x006A8069
		public float Radius { get; set; }

		// Token: 0x060312A1 RID: 201377 RVA: 0x006A9E72 File Offset: 0x006A8072
		public IFoxReversePushT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.SplineEntityId = 0;
			this.SeqEntityId = 0;
			this.SliderTag = null;
			this.Radius = 0f;
		}
	}
}
