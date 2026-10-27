using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4D RID: 23117
	public class ITeleportComponentT
	{
		// Token: 0x1700ADE4 RID: 44516
		// (get) Token: 0x060274FA RID: 161018 RVA: 0x00568BF5 File Offset: 0x00566DF5
		// (set) Token: 0x060274FB RID: 161019 RVA: 0x00568BFD File Offset: 0x00566DFD
		public bool Disabled { get; set; }

		// Token: 0x1700ADE5 RID: 44517
		// (get) Token: 0x060274FC RID: 161020 RVA: 0x00568C06 File Offset: 0x00566E06
		// (set) Token: 0x060274FD RID: 161021 RVA: 0x00568C0E File Offset: 0x00566E0E
		public int TeleporterId { get; set; }

		// Token: 0x1700ADE6 RID: 44518
		// (get) Token: 0x060274FE RID: 161022 RVA: 0x00568C17 File Offset: 0x00566E17
		// (set) Token: 0x060274FF RID: 161023 RVA: 0x00568C1F File Offset: 0x00566E1F
		public IPosAT TeleportPos { get; set; }

		// Token: 0x1700ADE7 RID: 44519
		// (get) Token: 0x06027500 RID: 161024 RVA: 0x00568C28 File Offset: 0x00566E28
		// (set) Token: 0x06027501 RID: 161025 RVA: 0x00568C30 File Offset: 0x00566E30
		public IGravityFlipTeleportConfigT GravityConfig { get; set; }

		// Token: 0x1700ADE8 RID: 44520
		// (get) Token: 0x06027502 RID: 161026 RVA: 0x00568C39 File Offset: 0x00566E39
		// (set) Token: 0x06027503 RID: 161027 RVA: 0x00568C41 File Offset: 0x00566E41
		public byte NullMask { get; set; }

		// Token: 0x06027504 RID: 161028 RVA: 0x00568C4A File Offset: 0x00566E4A
		public ITeleportComponentT()
		{
			this.Disabled = false;
			this.TeleporterId = 0;
			this.TeleportPos = null;
			this.GravityConfig = null;
			this.NullMask = 0;
		}
	}
}
