using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005720 RID: 22304
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackItemData : DangoBrawlItemBase
	{
		// Token: 0x06036E55 RID: 224853 RVA: 0x00F4E23D File Offset: 0x00F4C43D
		public DangoBrawlOutBackpackItemData(int configId) : this(0, configId, EDangoBrawlRotate.Direction0)
		{
		}

		// Token: 0x06036E56 RID: 224854 RVA: 0x00F4E248 File Offset: 0x00F4C448
		public DangoBrawlOutBackpackItemData(int uid, int configId, EDangoBrawlRotate rotate = EDangoBrawlRotate.Direction0) : base(uid, configId)
		{
			this.RotateInternal = rotate;
			this.PanelPosListInternal = DangoBrawlUtil.RotatePanelPosList(configId, rotate);
			this.StarPanelPosListInternal = DangoBrawlUtil.RotateStarPanelPosList(configId, rotate);
		}

		// Token: 0x17006A2F RID: 27183
		// (get) Token: 0x06036E57 RID: 224855 RVA: 0x00F4E280 File Offset: 0x00F4C480
		// (set) Token: 0x06036E58 RID: 224856 RVA: 0x00F4E288 File Offset: 0x00F4C488
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

		// Token: 0x17006A30 RID: 27184
		// (get) Token: 0x06036E59 RID: 224857 RVA: 0x00F4E291 File Offset: 0x00F4C491
		public PanelPos[] PanelPosList
		{
			get
			{
				return this.PanelPosListInternal;
			}
		}

		// Token: 0x17006A31 RID: 27185
		// (get) Token: 0x06036E5A RID: 224858 RVA: 0x00F4E299 File Offset: 0x00F4C499
		public PanelPos[] StarPanelPosList
		{
			get
			{
				return this.StarPanelPosListInternal;
			}
		}

		// Token: 0x17006A32 RID: 27186
		// (get) Token: 0x06036E5B RID: 224859 RVA: 0x00F4E2A1 File Offset: 0x00F4C4A1
		// (set) Token: 0x06036E5C RID: 224860 RVA: 0x00F4E2A9 File Offset: 0x00F4C4A9
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

		// Token: 0x0401D12B RID: 119083
		private PanelPos LeftTopPosInternal = new PanelPos(0, 0);

		// Token: 0x0401D12C RID: 119084
		private PanelPos[] PanelPosListInternal;

		// Token: 0x0401D12D RID: 119085
		private PanelPos[] StarPanelPosListInternal;

		// Token: 0x0401D12E RID: 119086
		private EDangoBrawlRotate RotateInternal;
	}
}
