using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DE RID: 21470
	public class IIconNearbyTrackingT
	{
		// Token: 0x17009E00 RID: 40448
		// (get) Token: 0x060233F7 RID: 144375 RVA: 0x004E1A45 File Offset: 0x004DFC45
		// (set) Token: 0x060233F8 RID: 144376 RVA: 0x004E1A4D File Offset: 0x004DFC4D
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x17009E01 RID: 40449
		// (get) Token: 0x060233F9 RID: 144377 RVA: 0x004E1A56 File Offset: 0x004DFC56
		// (set) Token: 0x060233FA RID: 144378 RVA: 0x004E1A5E File Offset: 0x004DFC5E
		public int ShowRange { get; set; }

		// Token: 0x17009E02 RID: 40450
		// (get) Token: 0x060233FB RID: 144379 RVA: 0x004E1A67 File Offset: 0x004DFC67
		// (set) Token: 0x060233FC RID: 144380 RVA: 0x004E1A6F File Offset: 0x004DFC6F
		public int HideRange { get; set; }

		// Token: 0x17009E03 RID: 40451
		// (get) Token: 0x060233FD RID: 144381 RVA: 0x004E1A78 File Offset: 0x004DFC78
		// (set) Token: 0x060233FE RID: 144382 RVA: 0x004E1A80 File Offset: 0x004DFC80
		public ENearbyTrackingTexture TexturePath { get; set; }

		// Token: 0x17009E04 RID: 40452
		// (get) Token: 0x060233FF RID: 144383 RVA: 0x004E1A89 File Offset: 0x004DFC89
		// (set) Token: 0x06023400 RID: 144384 RVA: 0x004E1A91 File Offset: 0x004DFC91
		public IVectorInfoT UiOffset { get; set; }

		// Token: 0x17009E05 RID: 40453
		// (get) Token: 0x06023401 RID: 144385 RVA: 0x004E1A9A File Offset: 0x004DFC9A
		// (set) Token: 0x06023402 RID: 144386 RVA: 0x004E1AA2 File Offset: 0x004DFCA2
		public float Duration { get; set; }

		// Token: 0x17009E06 RID: 40454
		// (get) Token: 0x06023403 RID: 144387 RVA: 0x004E1AAB File Offset: 0x004DFCAB
		// (set) Token: 0x06023404 RID: 144388 RVA: 0x004E1AB3 File Offset: 0x004DFCB3
		public byte NullMask { get; set; }

		// Token: 0x06023405 RID: 144389 RVA: 0x004E1ABC File Offset: 0x004DFCBC
		public IIconNearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.ShowRange = 0;
			this.HideRange = 0;
			this.TexturePath = ENearbyTrackingTexture.BigTeleporter;
			this.UiOffset = null;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
