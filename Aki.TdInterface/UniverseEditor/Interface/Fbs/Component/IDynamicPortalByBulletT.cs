using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005650 RID: 22096
	public class IDynamicPortalByBulletT
	{
		// Token: 0x17009EC2 RID: 40642
		// (get) Token: 0x060234F7 RID: 144631 RVA: 0x004DBC07 File Offset: 0x004D9E07
		// (set) Token: 0x060234F8 RID: 144632 RVA: 0x004DBC0F File Offset: 0x004D9E0F
		public EDynamicPortalCreateType Type { get; set; }

		// Token: 0x17009EC3 RID: 40643
		// (get) Token: 0x060234F9 RID: 144633 RVA: 0x004DBC18 File Offset: 0x004D9E18
		// (set) Token: 0x060234FA RID: 144634 RVA: 0x004DBC20 File Offset: 0x004D9E20
		public IDynamicPortalConfigT PortalA { get; set; }

		// Token: 0x17009EC4 RID: 40644
		// (get) Token: 0x060234FB RID: 144635 RVA: 0x004DBC29 File Offset: 0x004D9E29
		// (set) Token: 0x060234FC RID: 144636 RVA: 0x004DBC31 File Offset: 0x004D9E31
		public IDynamicPortalConfigT PortalB { get; set; }

		// Token: 0x17009EC5 RID: 40645
		// (get) Token: 0x060234FD RID: 144637 RVA: 0x004DBC3A File Offset: 0x004D9E3A
		// (set) Token: 0x060234FE RID: 144638 RVA: 0x004DBC42 File Offset: 0x004D9E42
		public EPortalModel InitOpenPortal { get; set; }

		// Token: 0x17009EC6 RID: 40646
		// (get) Token: 0x060234FF RID: 144639 RVA: 0x004DBC4B File Offset: 0x004D9E4B
		// (set) Token: 0x06023500 RID: 144640 RVA: 0x004DBC53 File Offset: 0x004D9E53
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x17009EC7 RID: 40647
		// (get) Token: 0x06023501 RID: 144641 RVA: 0x004DBC5C File Offset: 0x004D9E5C
		// (set) Token: 0x06023502 RID: 144642 RVA: 0x004DBC64 File Offset: 0x004D9E64
		public IDynamicBulletConfigT TypeA { get; set; }

		// Token: 0x17009EC8 RID: 40648
		// (get) Token: 0x06023503 RID: 144643 RVA: 0x004DBC6D File Offset: 0x004D9E6D
		// (set) Token: 0x06023504 RID: 144644 RVA: 0x004DBC75 File Offset: 0x004D9E75
		public IDynamicBulletConfigT TypeB { get; set; }

		// Token: 0x17009EC9 RID: 40649
		// (get) Token: 0x06023505 RID: 144645 RVA: 0x004DBC7E File Offset: 0x004D9E7E
		// (set) Token: 0x06023506 RID: 144646 RVA: 0x004DBC86 File Offset: 0x004D9E86
		public byte NullMask { get; set; }

		// Token: 0x06023507 RID: 144647 RVA: 0x004DBC8F File Offset: 0x004D9E8F
		public IDynamicPortalByBulletT()
		{
			this.Type = EDynamicPortalCreateType.Bullet;
			this.PortalA = null;
			this.PortalB = null;
			this.InitOpenPortal = EPortalModel.A;
			this.RenderConfig = null;
			this.TypeA = null;
			this.TypeB = null;
			this.NullMask = 0;
		}
	}
}
