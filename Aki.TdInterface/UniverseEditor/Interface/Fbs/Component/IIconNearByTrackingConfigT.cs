using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E1 RID: 21473
	public class IIconNearByTrackingConfigT
	{
		// Token: 0x17009E0E RID: 40462
		// (get) Token: 0x0602341F RID: 144415 RVA: 0x004E1F3B File Offset: 0x004E013B
		// (set) Token: 0x06023420 RID: 144416 RVA: 0x004E1F43 File Offset: 0x004E0143
		public int ShowRange { get; set; }

		// Token: 0x17009E0F RID: 40463
		// (get) Token: 0x06023421 RID: 144417 RVA: 0x004E1F4C File Offset: 0x004E014C
		// (set) Token: 0x06023422 RID: 144418 RVA: 0x004E1F54 File Offset: 0x004E0154
		public int HideRange { get; set; }

		// Token: 0x17009E10 RID: 40464
		// (get) Token: 0x06023423 RID: 144419 RVA: 0x004E1F5D File Offset: 0x004E015D
		// (set) Token: 0x06023424 RID: 144420 RVA: 0x004E1F65 File Offset: 0x004E0165
		public ENearbyTrackingTexture TexturePath { get; set; }

		// Token: 0x17009E11 RID: 40465
		// (get) Token: 0x06023425 RID: 144421 RVA: 0x004E1F6E File Offset: 0x004E016E
		// (set) Token: 0x06023426 RID: 144422 RVA: 0x004E1F76 File Offset: 0x004E0176
		public IVectorInfoT UiOffset { get; set; }

		// Token: 0x17009E12 RID: 40466
		// (get) Token: 0x06023427 RID: 144423 RVA: 0x004E1F7F File Offset: 0x004E017F
		// (set) Token: 0x06023428 RID: 144424 RVA: 0x004E1F87 File Offset: 0x004E0187
		public float Duration { get; set; }

		// Token: 0x17009E13 RID: 40467
		// (get) Token: 0x06023429 RID: 144425 RVA: 0x004E1F90 File Offset: 0x004E0190
		// (set) Token: 0x0602342A RID: 144426 RVA: 0x004E1F98 File Offset: 0x004E0198
		public byte NullMask { get; set; }

		// Token: 0x0602342B RID: 144427 RVA: 0x004E1FA1 File Offset: 0x004E01A1
		public IIconNearByTrackingConfigT()
		{
			this.ShowRange = 0;
			this.HideRange = 0;
			this.TexturePath = ENearbyTrackingTexture.BigTeleporter;
			this.UiOffset = null;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
