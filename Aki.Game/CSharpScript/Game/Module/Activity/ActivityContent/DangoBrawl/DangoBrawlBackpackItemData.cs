using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200571A RID: 22298
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackpackItemData : DangoBrawlItemBase
	{
		// Token: 0x06036E0F RID: 224783 RVA: 0x00F4D734 File Offset: 0x00F4B934
		public DangoBrawlBackpackItemData(DangoBrawlBackPackItemServerData serverData) : base(serverData.Uid, serverData.ConfigId)
		{
			this.ServerData = serverData;
			this.Rotate = serverData.Rotate;
			this.LeftTopPos = serverData.GetPosInPanel();
			this.PanelPosList = DangoBrawlUtil.RotatePanelPosList(serverData.ConfigId, serverData.Rotate);
			this.StarPanelPosList = DangoBrawlUtil.RotateStarPanelPosList(serverData.ConfigId, serverData.Rotate);
		}

		// Token: 0x17006A02 RID: 27138
		// (get) Token: 0x06036E10 RID: 224784 RVA: 0x00F4D7A0 File Offset: 0x00F4B9A0
		public PanelPos[] MyPanelPosList
		{
			get
			{
				return this.PanelPosList;
			}
		}

		// Token: 0x17006A03 RID: 27139
		// (get) Token: 0x06036E11 RID: 224785 RVA: 0x00F4D7A8 File Offset: 0x00F4B9A8
		public PanelPos[] MyStarPanelPosList
		{
			get
			{
				return this.StarPanelPosList;
			}
		}

		// Token: 0x17006A04 RID: 27140
		// (get) Token: 0x06036E12 RID: 224786 RVA: 0x00F4D7B0 File Offset: 0x00F4B9B0
		// (set) Token: 0x06036E13 RID: 224787 RVA: 0x00F4D7B8 File Offset: 0x00F4B9B8
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

		// Token: 0x17006A05 RID: 27141
		// (get) Token: 0x06036E14 RID: 224788 RVA: 0x00F4D7C1 File Offset: 0x00F4B9C1
		// (set) Token: 0x06036E15 RID: 224789 RVA: 0x00F4D7C9 File Offset: 0x00F4B9C9
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

		// Token: 0x17006A06 RID: 27142
		// (get) Token: 0x06036E16 RID: 224790 RVA: 0x00F4D800 File Offset: 0x00F4BA00
		// (set) Token: 0x06036E17 RID: 224791 RVA: 0x00F4D808 File Offset: 0x00F4BA08
		[Nullable(2)]
		public ItemSucAnchor MyLastAnchor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0401D110 RID: 119056
		private DangoBrawlBackPackItemServerData ServerData;

		// Token: 0x0401D111 RID: 119057
		private PanelPos LeftTopPos;

		// Token: 0x0401D112 RID: 119058
		private PanelPos[] PanelPosList;

		// Token: 0x0401D113 RID: 119059
		private PanelPos[] StarPanelPosList;

		// Token: 0x0401D114 RID: 119060
		private EDangoBrawlRotate Rotate;
	}
}
