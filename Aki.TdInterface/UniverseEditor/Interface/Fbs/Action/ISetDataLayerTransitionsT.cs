using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD8 RID: 28632
	public class ISetDataLayerTransitionsT
	{
		// Token: 0x1700D492 RID: 54418
		// (get) Token: 0x060329CF RID: 207311 RVA: 0x006D4301 File Offset: 0x006D2501
		// (set) Token: 0x060329D0 RID: 207312 RVA: 0x006D4309 File Offset: 0x006D2509
		public IActorRefT VolumeActor { get; set; }

		// Token: 0x1700D493 RID: 54419
		// (get) Token: 0x060329D1 RID: 207313 RVA: 0x006D4312 File Offset: 0x006D2512
		// (set) Token: 0x060329D2 RID: 207314 RVA: 0x006D431A File Offset: 0x006D251A
		public string MaterialDataForEnable { get; set; }

		// Token: 0x1700D494 RID: 54420
		// (get) Token: 0x060329D3 RID: 207315 RVA: 0x006D4323 File Offset: 0x006D2523
		// (set) Token: 0x060329D4 RID: 207316 RVA: 0x006D432B File Offset: 0x006D252B
		public string MaterialDataForDisable { get; set; }

		// Token: 0x1700D495 RID: 54421
		// (get) Token: 0x060329D5 RID: 207317 RVA: 0x006D4334 File Offset: 0x006D2534
		// (set) Token: 0x060329D6 RID: 207318 RVA: 0x006D433C File Offset: 0x006D253C
		public string VolumeEnterSeq { get; set; }

		// Token: 0x1700D496 RID: 54422
		// (get) Token: 0x060329D7 RID: 207319 RVA: 0x006D4345 File Offset: 0x006D2545
		// (set) Token: 0x060329D8 RID: 207320 RVA: 0x006D434D File Offset: 0x006D254D
		public string VolumeOutSeq { get; set; }

		// Token: 0x060329D9 RID: 207321 RVA: 0x006D4356 File Offset: 0x006D2556
		public ISetDataLayerTransitionsT()
		{
			this.VolumeActor = null;
			this.MaterialDataForEnable = null;
			this.MaterialDataForDisable = null;
			this.VolumeEnterSeq = null;
			this.VolumeOutSeq = null;
		}
	}
}
