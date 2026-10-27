using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067CC RID: 26572
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBenchItemData : DangoBrawlItemBase
	{
		// Token: 0x060422CD RID: 271053 RVA: 0x0100C6C8 File Offset: 0x0100A8C8
		public DangoBrawlBenchItemData(DangoBrawlBenchItemServerData server, EDangoBrawlRotate bagRotation = EDangoBrawlRotate.Direction0) : base(server.Uid, server.ConfigId)
		{
			this.ServerData = server;
			this.Rotation = DangoBrawlUtil.GetBenchDisplayRotate(server.ConfigId, bagRotation);
		}

		// Token: 0x170096C7 RID: 38599
		// (get) Token: 0x060422CE RID: 271054 RVA: 0x0100C6F5 File Offset: 0x0100A8F5
		public DangoBrawlBenchItemServerData MyServerData
		{
			get
			{
				return this.ServerData;
			}
		}

		// Token: 0x170096C8 RID: 38600
		// (get) Token: 0x060422CF RID: 271055 RVA: 0x0100C6FD File Offset: 0x0100A8FD
		// (set) Token: 0x060422D0 RID: 271056 RVA: 0x0100C705 File Offset: 0x0100A905
		[Nullable(2)]
		public ItemSucAnchor MyLastAnchor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170096C9 RID: 38601
		// (get) Token: 0x060422D1 RID: 271057 RVA: 0x0100C70E File Offset: 0x0100A90E
		// (set) Token: 0x060422D2 RID: 271058 RVA: 0x0100C716 File Offset: 0x0100A916
		public FVector2D? MyDropLguiPos
		{
			get
			{
				return this.DropLguiPos;
			}
			set
			{
				this.DropLguiPos = value;
			}
		}

		// Token: 0x170096CA RID: 38602
		// (get) Token: 0x060422D3 RID: 271059 RVA: 0x0100C71F File Offset: 0x0100A91F
		// (set) Token: 0x060422D4 RID: 271060 RVA: 0x0100C727 File Offset: 0x0100A927
		public EDangoBrawlRotate MyRotation
		{
			get
			{
				return this.Rotation;
			}
			set
			{
				this.Rotation = value;
			}
		}

		// Token: 0x040228BC RID: 141500
		private readonly DangoBrawlBenchItemServerData ServerData;

		// Token: 0x040228BD RID: 141501
		private FVector2D? DropLguiPos;

		// Token: 0x040228BE RID: 141502
		private EDangoBrawlRotate Rotation;
	}
}
