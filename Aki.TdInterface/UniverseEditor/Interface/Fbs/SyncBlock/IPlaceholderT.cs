using System;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B79 RID: 15225
	public class IPlaceholderT
	{
		// Token: 0x17006862 RID: 26722
		// (get) Token: 0x06014D95 RID: 85397 RVA: 0x00306F94 File Offset: 0x00305194
		// (set) Token: 0x06014D96 RID: 85398 RVA: 0x00306F9C File Offset: 0x0030519C
		public TPlaceholderType Type { get; set; }

		// Token: 0x17006863 RID: 26723
		// (get) Token: 0x06014D97 RID: 85399 RVA: 0x00306FA5 File Offset: 0x003051A5
		// (set) Token: 0x06014D98 RID: 85400 RVA: 0x00306FAD File Offset: 0x003051AD
		public string Name { get; set; }

		// Token: 0x17006864 RID: 26724
		// (get) Token: 0x06014D99 RID: 85401 RVA: 0x00306FB6 File Offset: 0x003051B6
		// (set) Token: 0x06014D9A RID: 85402 RVA: 0x00306FBE File Offset: 0x003051BE
		public int NodeId { get; set; }

		// Token: 0x17006865 RID: 26725
		// (get) Token: 0x06014D9B RID: 85403 RVA: 0x00306FC7 File Offset: 0x003051C7
		// (set) Token: 0x06014D9C RID: 85404 RVA: 0x00306FCF File Offset: 0x003051CF
		public int Segment { get; set; }

		// Token: 0x17006866 RID: 26726
		// (get) Token: 0x06014D9D RID: 85405 RVA: 0x00306FD8 File Offset: 0x003051D8
		// (set) Token: 0x06014D9E RID: 85406 RVA: 0x00306FE0 File Offset: 0x003051E0
		public string Data { get; set; }

		// Token: 0x17006867 RID: 26727
		// (get) Token: 0x06014D9F RID: 85407 RVA: 0x00306FE9 File Offset: 0x003051E9
		// (set) Token: 0x06014DA0 RID: 85408 RVA: 0x00306FF1 File Offset: 0x003051F1
		public string Path { get; set; }

		// Token: 0x06014DA1 RID: 85409 RVA: 0x00306FFA File Offset: 0x003051FA
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
