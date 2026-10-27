using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB7 RID: 15287
	public class IShowTimelineConfigT
	{
		// Token: 0x170068D7 RID: 26839
		// (get) Token: 0x06014FA1 RID: 85921 RVA: 0x0030AC5E File Offset: 0x00308E5E
		// (set) Token: 0x06014FA2 RID: 85922 RVA: 0x0030AC66 File Offset: 0x00308E66
		public string Id { get; set; }

		// Token: 0x170068D8 RID: 26840
		// (get) Token: 0x06014FA3 RID: 85923 RVA: 0x0030AC6F File Offset: 0x00308E6F
		// (set) Token: 0x06014FA4 RID: 85924 RVA: 0x0030AC77 File Offset: 0x00308E77
		public string Name { get; set; }

		// Token: 0x170068D9 RID: 26841
		// (get) Token: 0x06014FA5 RID: 85925 RVA: 0x0030AC80 File Offset: 0x00308E80
		// (set) Token: 0x06014FA6 RID: 85926 RVA: 0x0030AC88 File Offset: 0x00308E88
		public IShowTimelineTrackT Track { get; set; }

		// Token: 0x06014FA7 RID: 85927 RVA: 0x0030AC91 File Offset: 0x00308E91
		public IShowTimelineConfigT()
		{
			this.Id = null;
			this.Name = null;
			this.Track = null;
		}
	}
}
