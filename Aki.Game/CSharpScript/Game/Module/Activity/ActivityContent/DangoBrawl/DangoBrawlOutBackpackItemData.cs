using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067D0 RID: 26576
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackItemData : DangoBrawlItemBase
	{
		// Token: 0x060422FF RID: 271103 RVA: 0x0100CE71 File Offset: 0x0100B071
		public DangoBrawlOutBackpackItemData(int configId) : this(0, configId, EDangoBrawlRotate.Direction0)
		{
		}

		// Token: 0x06042300 RID: 271104 RVA: 0x0100CE7C File Offset: 0x0100B07C
		public DangoBrawlOutBackpackItemData(int uid, int configId, EDangoBrawlRotate rotate = EDangoBrawlRotate.Direction0) : base(uid, configId)
		{
			this.RotateInternal = rotate;
			this.PanelPosListInternal = DangoBrawlUtil.RotatePanelPosList(configId, rotate);
			this.StarPanelPosListInternal = DangoBrawlUtil.RotateStarPanelPosList(configId, rotate);
		}

		// Token: 0x170096EE RID: 38638
		// (get) Token: 0x06042301 RID: 271105 RVA: 0x0100CEB4 File Offset: 0x0100B0B4
		// (set) Token: 0x06042302 RID: 271106 RVA: 0x0100CEBC File Offset: 0x0100B0BC
		public PanelPos LeftTopPos
		{
			get
			{
				return this.LeftTopPosInternal;
			}
			set
			{
				this.LeftTopPosInternal = value;
			}
		}

		// Token: 0x170096EF RID: 38639
		// (get) Token: 0x06042303 RID: 271107 RVA: 0x0100CEC5 File Offset: 0x0100B0C5
		public PanelPos[] PanelPosList
		{
			get
			{
				return this.PanelPosListInternal;
			}
		}

		// Token: 0x170096F0 RID: 38640
		// (get) Token: 0x06042304 RID: 271108 RVA: 0x0100CECD File Offset: 0x0100B0CD
		public PanelPos[] StarPanelPosList
		{
			get
			{
				return this.StarPanelPosListInternal;
			}
		}

		// Token: 0x170096F1 RID: 38641
		// (get) Token: 0x06042305 RID: 271109 RVA: 0x0100CED5 File Offset: 0x0100B0D5
		// (set) Token: 0x06042306 RID: 271110 RVA: 0x0100CEDD File Offset: 0x0100B0DD
		public EDangoBrawlRotate Rotate
		{
			get
			{
				return this.RotateInternal;
			}
			set
			{
				this.RotateInternal = value;
				this.PanelPosListInternal = DangoBrawlUtil.RotatePanelPosList(base.MyConfigId, value);
				this.StarPanelPosListInternal = DangoBrawlUtil.RotateStarPanelPosList(base.MyConfigId, value);
			}
		}

		// Token: 0x040228CE RID: 141518
		private PanelPos LeftTopPosInternal = new PanelPos(0, 0);

		// Token: 0x040228CF RID: 141519
		private PanelPos[] PanelPosListInternal;

		// Token: 0x040228D0 RID: 141520
		private PanelPos[] StarPanelPosListInternal;

		// Token: 0x040228D1 RID: 141521
		private EDangoBrawlRotate RotateInternal;
	}
}
