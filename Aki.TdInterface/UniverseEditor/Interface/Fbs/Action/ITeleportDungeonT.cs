using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B64 RID: 31588
	public class ITeleportDungeonT
	{
		// Token: 0x1700EC82 RID: 60546
		// (get) Token: 0x06038E34 RID: 233012 RVA: 0x007B0EFD File Offset: 0x007AF0FD
		// (set) Token: 0x06038E35 RID: 233013 RVA: 0x007B0F05 File Offset: 0x007AF105
		public int DungeonId { get; set; }

		// Token: 0x1700EC83 RID: 60547
		// (get) Token: 0x06038E36 RID: 233014 RVA: 0x007B0F0E File Offset: 0x007AF10E
		// (set) Token: 0x06038E37 RID: 233015 RVA: 0x007B0F16 File Offset: 0x007AF116
		public bool IsRegroup { get; set; }

		// Token: 0x1700EC84 RID: 60548
		// (get) Token: 0x06038E38 RID: 233016 RVA: 0x007B0F1F File Offset: 0x007AF11F
		// (set) Token: 0x06038E39 RID: 233017 RVA: 0x007B0F27 File Offset: 0x007AF127
		public int LocationEntityId { get; set; }

		// Token: 0x1700EC85 RID: 60549
		// (get) Token: 0x06038E3A RID: 233018 RVA: 0x007B0F30 File Offset: 0x007AF130
		// (set) Token: 0x06038E3B RID: 233019 RVA: 0x007B0F38 File Offset: 0x007AF138
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x1700EC86 RID: 60550
		// (get) Token: 0x06038E3C RID: 233020 RVA: 0x007B0F41 File Offset: 0x007AF141
		// (set) Token: 0x06038E3D RID: 233021 RVA: 0x007B0F49 File Offset: 0x007AF149
		public bool IsNeedSecondaryConfirmation { get; set; }

		// Token: 0x1700EC87 RID: 60551
		// (get) Token: 0x06038E3E RID: 233022 RVA: 0x007B0F52 File Offset: 0x007AF152
		// (set) Token: 0x06038E3F RID: 233023 RVA: 0x007B0F5A File Offset: 0x007AF15A
		public bool UseLocationEntityGravity { get; set; }

		// Token: 0x1700EC88 RID: 60552
		// (get) Token: 0x06038E40 RID: 233024 RVA: 0x007B0F63 File Offset: 0x007AF163
		// (set) Token: 0x06038E41 RID: 233025 RVA: 0x007B0F6B File Offset: 0x007AF16B
		public bool ContinueSave { get; set; }

		// Token: 0x1700EC89 RID: 60553
		// (get) Token: 0x06038E42 RID: 233026 RVA: 0x007B0F74 File Offset: 0x007AF174
		// (set) Token: 0x06038E43 RID: 233027 RVA: 0x007B0F7C File Offset: 0x007AF17C
		public bool IsBanMapSound { get; set; }

		// Token: 0x1700EC8A RID: 60554
		// (get) Token: 0x06038E44 RID: 233028 RVA: 0x007B0F85 File Offset: 0x007AF185
		// (set) Token: 0x06038E45 RID: 233029 RVA: 0x007B0F8D File Offset: 0x007AF18D
		public byte NullMask { get; set; }

		// Token: 0x06038E46 RID: 233030 RVA: 0x007B0F98 File Offset: 0x007AF198
		public ITeleportDungeonT()
		{
			this.DungeonId = 0;
			this.IsRegroup = false;
			this.LocationEntityId = 0;
			this.TransitionOption = null;
			this.IsNeedSecondaryConfirmation = false;
			this.UseLocationEntityGravity = false;
			this.ContinueSave = false;
			this.IsBanMapSound = false;
			this.NullMask = 0;
		}
	}
}
