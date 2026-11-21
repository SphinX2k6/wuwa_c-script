using System;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F81 RID: 16257
	public class IPlaceholderT
	{
		// Token: 0x17006E01 RID: 28161
		// (get) Token: 0x0601625F RID: 90719 RVA: 0x0032D52C File Offset: 0x0032B72C
		// (set) Token: 0x06016260 RID: 90720 RVA: 0x0032D534 File Offset: 0x0032B734
		public TPlaceholderType Type { get; set; }

		// Token: 0x17006E02 RID: 28162
		// (get) Token: 0x06016261 RID: 90721 RVA: 0x0032D53D File Offset: 0x0032B73D
		// (set) Token: 0x06016262 RID: 90722 RVA: 0x0032D545 File Offset: 0x0032B745
		public string Name { get; set; }

		// Token: 0x17006E03 RID: 28163
		// (get) Token: 0x06016263 RID: 90723 RVA: 0x0032D54E File Offset: 0x0032B74E
		// (set) Token: 0x06016264 RID: 90724 RVA: 0x0032D556 File Offset: 0x0032B756
		public int NodeId { get; set; }

		// Token: 0x17006E04 RID: 28164
		// (get) Token: 0x06016265 RID: 90725 RVA: 0x0032D55F File Offset: 0x0032B75F
		// (set) Token: 0x06016266 RID: 90726 RVA: 0x0032D567 File Offset: 0x0032B767
		public int Segment { get; set; }

		// Token: 0x17006E05 RID: 28165
		// (get) Token: 0x06016267 RID: 90727 RVA: 0x0032D570 File Offset: 0x0032B770
		// (set) Token: 0x06016268 RID: 90728 RVA: 0x0032D578 File Offset: 0x0032B778
		public string Data { get; set; }

		// Token: 0x17006E06 RID: 28166
		// (get) Token: 0x06016269 RID: 90729 RVA: 0x0032D581 File Offset: 0x0032B781
		// (set) Token: 0x0601626A RID: 90730 RVA: 0x0032D589 File Offset: 0x0032B789
		public string Path { get; set; }

		// Token: 0x0601626B RID: 90731 RVA: 0x0032D592 File Offset: 0x0032B792
		public IPlaceholderT()
		{
			this.Type = TPlaceholderType.BuffIdList;
			this.Name = null;
			this.NodeId = 0;
			this.Segment = 0;
			this.Data = null;
			this.Path = null;
		}
	}
}
