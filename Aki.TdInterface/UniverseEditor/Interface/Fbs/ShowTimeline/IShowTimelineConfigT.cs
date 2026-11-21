using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FBF RID: 16319
	public class IShowTimelineConfigT
	{
		// Token: 0x17006E7A RID: 28282
		// (get) Token: 0x06016479 RID: 91257 RVA: 0x003314BA File Offset: 0x0032F6BA
		// (set) Token: 0x0601647A RID: 91258 RVA: 0x003314C2 File Offset: 0x0032F6C2
		public string Id { get; set; }

		// Token: 0x17006E7B RID: 28283
		// (get) Token: 0x0601647B RID: 91259 RVA: 0x003314CB File Offset: 0x0032F6CB
		// (set) Token: 0x0601647C RID: 91260 RVA: 0x003314D3 File Offset: 0x0032F6D3
		public string Name { get; set; }

		// Token: 0x17006E7C RID: 28284
		// (get) Token: 0x0601647D RID: 91261 RVA: 0x003314DC File Offset: 0x0032F6DC
		// (set) Token: 0x0601647E RID: 91262 RVA: 0x003314E4 File Offset: 0x0032F6E4
		public IShowTimelineTrackT Track { get; set; }

		// Token: 0x0601647F RID: 91263 RVA: 0x003314ED File Offset: 0x0032F6ED
		public IShowTimelineConfigT()
		{
			this.Id = null;
			this.Name = null;
			this.Track = null;
		}
	}
}
