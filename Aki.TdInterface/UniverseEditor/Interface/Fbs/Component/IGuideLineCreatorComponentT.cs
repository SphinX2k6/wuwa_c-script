using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535A RID: 21338
	public class IGuideLineCreatorComponentT
	{
		// Token: 0x17009CC7 RID: 40135
		// (get) Token: 0x06022E88 RID: 142984 RVA: 0x004D5D35 File Offset: 0x004D3F35
		// (set) Token: 0x06022E89 RID: 142985 RVA: 0x004D5D3D File Offset: 0x004D3F3D
		public bool Disabled { get; set; }

		// Token: 0x17009CC8 RID: 40136
		// (get) Token: 0x06022E8A RID: 142986 RVA: 0x004D5D46 File Offset: 0x004D3F46
		// (set) Token: 0x06022E8B RID: 142987 RVA: 0x004D5D4E File Offset: 0x004D3F4E
		public IColorChangeStrategyOfRGBT ColorChangeOption { get; set; }

		// Token: 0x17009CC9 RID: 40137
		// (get) Token: 0x06022E8C RID: 142988 RVA: 0x004D5D57 File Offset: 0x004D3F57
		// (set) Token: 0x06022E8D RID: 142989 RVA: 0x004D5D5F File Offset: 0x004D3F5F
		public int SplineEntityId { get; set; }

		// Token: 0x17009CCA RID: 40138
		// (get) Token: 0x06022E8E RID: 142990 RVA: 0x004D5D68 File Offset: 0x004D3F68
		// (set) Token: 0x06022E8F RID: 142991 RVA: 0x004D5D70 File Offset: 0x004D3F70
		public IGuideLineCreatorScanOptionT ScanOption { get; set; }

		// Token: 0x17009CCB RID: 40139
		// (get) Token: 0x06022E90 RID: 142992 RVA: 0x004D5D79 File Offset: 0x004D3F79
		// (set) Token: 0x06022E91 RID: 142993 RVA: 0x004D5D81 File Offset: 0x004D3F81
		public byte NullMask { get; set; }

		// Token: 0x06022E92 RID: 142994 RVA: 0x004D5D8A File Offset: 0x004D3F8A
		public IGuideLineCreatorComponentT()
		{
			this.Disabled = false;
			this.ColorChangeOption = null;
			this.SplineEntityId = 0;
			this.ScanOption = null;
			this.NullMask = 0;
		}
	}
}
