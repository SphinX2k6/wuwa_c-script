using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BBA RID: 15290
	public class IShowTimelineFrameT
	{
		// Token: 0x170068E0 RID: 26848
		// (get) Token: 0x06014FCD RID: 85965 RVA: 0x0030B3DF File Offset: 0x003095DF
		// (set) Token: 0x06014FCE RID: 85966 RVA: 0x0030B3E7 File Offset: 0x003095E7
		public int Frame { get; set; }

		// Token: 0x170068E1 RID: 26849
		// (get) Token: 0x06014FCF RID: 85967 RVA: 0x0030B3F0 File Offset: 0x003095F0
		// (set) Token: 0x06014FD0 RID: 85968 RVA: 0x0030B3F8 File Offset: 0x003095F8
		public int FrameInterval { get; set; }

		// Token: 0x170068E2 RID: 26850
		// (get) Token: 0x06014FD1 RID: 85969 RVA: 0x0030B401 File Offset: 0x00309601
		// (set) Token: 0x06014FD2 RID: 85970 RVA: 0x0030B409 File Offset: 0x00309609
		public List<TShowTimelineUnion> Entries { get; set; }

		// Token: 0x170068E3 RID: 26851
		// (get) Token: 0x06014FD3 RID: 85971 RVA: 0x0030B412 File Offset: 0x00309612
		// (set) Token: 0x06014FD4 RID: 85972 RVA: 0x0030B41A File Offset: 0x0030961A
		public byte NullMask { get; set; }

		// Token: 0x06014FD5 RID: 85973 RVA: 0x0030B423 File Offset: 0x00309623
		public IShowTimelineFrameT()
		{
			this.Frame = 0;
			this.FrameInterval = 0;
			this.Entries = null;
			this.NullMask = 0;
		}
	}
}
