using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020047A0 RID: 18336
	[NullableContext(2)]
	public interface IMapSubViewListItemData
	{
		// Token: 0x17007801 RID: 30721
		// (get) Token: 0x0602FF2A RID: 196394
		// (set) Token: 0x0602FF2B RID: 196395
		[Nullable(1)]
		string LeftTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007802 RID: 30722
		// (get) Token: 0x0602FF2C RID: 196396
		// (set) Token: 0x0602FF2D RID: 196397
		string LeftText { get; set; }

		// Token: 0x17007803 RID: 30723
		// (get) Token: 0x0602FF2E RID: 196398
		// (set) Token: 0x0602FF2F RID: 196399
		string RightTextId { get; set; }

		// Token: 0x17007804 RID: 30724
		// (get) Token: 0x0602FF30 RID: 196400
		// (set) Token: 0x0602FF31 RID: 196401
		string RightText { get; set; }

		// Token: 0x17007805 RID: 30725
		// (get) Token: 0x0602FF32 RID: 196402
		// (set) Token: 0x0602FF33 RID: 196403
		bool ShowBtnHelp { get; set; }

		// Token: 0x17007806 RID: 30726
		// (get) Token: 0x0602FF34 RID: 196404
		// (set) Token: 0x0602FF35 RID: 196405
		Action OnBtnClickCb { get; set; }

		// Token: 0x17007807 RID: 30727
		// (get) Token: 0x0602FF36 RID: 196406
		// (set) Token: 0x0602FF37 RID: 196407
		bool ShowIcon { get; set; }

		// Token: 0x17007808 RID: 30728
		// (get) Token: 0x0602FF38 RID: 196408
		// (set) Token: 0x0602FF39 RID: 196409
		bool ShowSprite { get; set; }

		// Token: 0x17007809 RID: 30729
		// (get) Token: 0x0602FF3A RID: 196410
		// (set) Token: 0x0602FF3B RID: 196411
		bool ShowScaleIcon { get; set; }

		// Token: 0x1700780A RID: 30730
		// (get) Token: 0x0602FF3C RID: 196412
		// (set) Token: 0x0602FF3D RID: 196413
		string ScaleIconPath { get; set; }
	}
}
