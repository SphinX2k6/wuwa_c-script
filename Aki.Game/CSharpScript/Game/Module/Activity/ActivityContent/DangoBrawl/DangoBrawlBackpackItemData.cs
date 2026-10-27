using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067CA RID: 26570
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackpackItemData : DangoBrawlItemBase
	{
		// Token: 0x060422B9 RID: 271033 RVA: 0x0100C368 File Offset: 0x0100A568
		public DangoBrawlBackpackItemData(DangoBrawlBackPackItemServerData serverData) : base(serverData.Uid, serverData.ConfigId)
		{
			this.ServerData = serverData;
			this.Rotate = serverData.Rotate;
			this.LeftTopPos = serverData.GetPosInPanel();
			this.PanelPosList = DangoBrawlUtil.RotatePanelPosList(serverData.ConfigId, serverData.Rotate);
			this.StarPanelPosList = DangoBrawlUtil.RotateStarPanelPosList(serverData.ConfigId, serverData.Rotate);
		}

		// Token: 0x170096C1 RID: 38593
		// (get) Token: 0x060422BA RID: 271034 RVA: 0x0100C3D4 File Offset: 0x0100A5D4
		public PanelPos[] MyPanelPosList
		{
			get
			{
				return this.PanelPosList;
			}
		}

		// Token: 0x170096C2 RID: 38594
		// (get) Token: 0x060422BB RID: 271035 RVA: 0x0100C3DC File Offset: 0x0100A5DC
		public PanelPos[] MyStarPanelPosList
		{
			get
			{
				return this.StarPanelPosList;
			}
		}

		// Token: 0x170096C3 RID: 38595
		// (get) Token: 0x060422BC RID: 271036 RVA: 0x0100C3E4 File Offset: 0x0100A5E4
		// (set) Token: 0x060422BD RID: 271037 RVA: 0x0100C3EC File Offset: 0x0100A5EC
		public PanelPos MyLeftTopPos
		{
			get
			{
				return this.LeftTopPos;
			}
			set
			{
				this.LeftTopPos = value;
			}
		}

		// Token: 0x170096C4 RID: 38596
		// (get) Token: 0x060422BE RID: 271038 RVA: 0x0100C3F5 File Offset: 0x0100A5F5
		// (set) Token: 0x060422BF RID: 271039 RVA: 0x0100C3FD File Offset: 0x0100A5FD
		public EDangoBrawlRotate MyRotation
		{
			get
			{
				return this.Rotate;
			}
			set
			{
				this.Rotate = value;
				this.PanelPosList = DangoBrawlUtil.RotatePanelPosList(this.ServerData.ConfigId, value);
				this.StarPanelPosList = DangoBrawlUtil.RotateStarPanelPosList(this.ServerData.ConfigId, value);
			}
		}

		// Token: 0x170096C5 RID: 38597
		// (get) Token: 0x060422C0 RID: 271040 RVA: 0x0100C434 File Offset: 0x0100A634
		// (set) Token: 0x060422C1 RID: 271041 RVA: 0x0100C43C File Offset: 0x0100A63C
		[Nullable(2)]
		public ItemSucAnchor MyLastAnchor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x040228B3 RID: 141491
		private DangoBrawlBackPackItemServerData ServerData;

		// Token: 0x040228B4 RID: 141492
		private PanelPos LeftTopPos;

		// Token: 0x040228B5 RID: 141493
		private PanelPos[] PanelPosList;

		// Token: 0x040228B6 RID: 141494
		private PanelPos[] StarPanelPosList;

		// Token: 0x040228B7 RID: 141495
		private EDangoBrawlRotate Rotate;
	}
}
