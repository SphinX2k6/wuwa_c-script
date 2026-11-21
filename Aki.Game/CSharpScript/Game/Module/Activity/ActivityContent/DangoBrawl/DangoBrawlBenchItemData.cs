using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200571C RID: 22300
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBenchItemData : DangoBrawlItemBase
	{
		// Token: 0x06036E23 RID: 224803 RVA: 0x00F4DA94 File Offset: 0x00F4BC94
		public DangoBrawlBenchItemData(DangoBrawlBenchItemServerData server, EDangoBrawlRotate bagRotation = EDangoBrawlRotate.Direction0) : base(server.Uid, server.ConfigId)
		{
			this.ServerData = server;
			this.Rotation = DangoBrawlUtil.GetBenchDisplayRotate(server.ConfigId, bagRotation);
		}

		// Token: 0x17006A08 RID: 27144
		// (get) Token: 0x06036E24 RID: 224804 RVA: 0x00F4DAC1 File Offset: 0x00F4BCC1
		public DangoBrawlBenchItemServerData MyServerData
		{
			get
			{
				return this.ServerData;
			}
		}

		// Token: 0x17006A09 RID: 27145
		// (get) Token: 0x06036E25 RID: 224805 RVA: 0x00F4DAC9 File Offset: 0x00F4BCC9
		// (set) Token: 0x06036E26 RID: 224806 RVA: 0x00F4DAD1 File Offset: 0x00F4BCD1
		[Nullable(2)]
		public ItemSucAnchor MyLastAnchor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006A0A RID: 27146
		// (get) Token: 0x06036E27 RID: 224807 RVA: 0x00F4DADA File Offset: 0x00F4BCDA
		// (set) Token: 0x06036E28 RID: 224808 RVA: 0x00F4DAE2 File Offset: 0x00F4BCE2
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

		// Token: 0x17006A0B RID: 27147
		// (get) Token: 0x06036E29 RID: 224809 RVA: 0x00F4DAEB File Offset: 0x00F4BCEB
		// (set) Token: 0x06036E2A RID: 224810 RVA: 0x00F4DAF3 File Offset: 0x00F4BCF3
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

		// Token: 0x0401D119 RID: 119065
		private readonly DangoBrawlBenchItemServerData ServerData;

		// Token: 0x0401D11A RID: 119066
		private FVector2D? DropLguiPos;

		// Token: 0x0401D11B RID: 119067
		private EDangoBrawlRotate Rotation;
	}
}
