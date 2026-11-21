using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A1 RID: 30625
	public class ISetDataLayerTransitionsT
	{
		// Token: 0x1700E066 RID: 57446
		// (get) Token: 0x06035C35 RID: 220213 RVA: 0x00733F45 File Offset: 0x00732145
		// (set) Token: 0x06035C36 RID: 220214 RVA: 0x00733F4D File Offset: 0x0073214D
		public IActorRefT VolumeActor { get; set; }

		// Token: 0x1700E067 RID: 57447
		// (get) Token: 0x06035C37 RID: 220215 RVA: 0x00733F56 File Offset: 0x00732156
		// (set) Token: 0x06035C38 RID: 220216 RVA: 0x00733F5E File Offset: 0x0073215E
		public string MaterialDataForEnable { get; set; }

		// Token: 0x1700E068 RID: 57448
		// (get) Token: 0x06035C39 RID: 220217 RVA: 0x00733F67 File Offset: 0x00732167
		// (set) Token: 0x06035C3A RID: 220218 RVA: 0x00733F6F File Offset: 0x0073216F
		public string MaterialDataForDisable { get; set; }

		// Token: 0x1700E069 RID: 57449
		// (get) Token: 0x06035C3B RID: 220219 RVA: 0x00733F78 File Offset: 0x00732178
		// (set) Token: 0x06035C3C RID: 220220 RVA: 0x00733F80 File Offset: 0x00732180
		public string VolumeEnterSeq { get; set; }

		// Token: 0x1700E06A RID: 57450
		// (get) Token: 0x06035C3D RID: 220221 RVA: 0x00733F89 File Offset: 0x00732189
		// (set) Token: 0x06035C3E RID: 220222 RVA: 0x00733F91 File Offset: 0x00732191
		public string VolumeOutSeq { get; set; }

		// Token: 0x06035C3F RID: 220223 RVA: 0x00733F9A File Offset: 0x0073219A
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
