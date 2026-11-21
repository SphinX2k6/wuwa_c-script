using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F0E RID: 24334
	public class ISequenceTrackControlPointT
	{
		// Token: 0x1700B3FD RID: 46077
		// (get) Token: 0x06028D84 RID: 167300 RVA: 0x00594FBD File Offset: 0x005931BD
		// (set) Token: 0x06028D85 RID: 167301 RVA: 0x00594FC5 File Offset: 0x005931C5
		public string Mark { get; set; }

		// Token: 0x06028D86 RID: 167302 RVA: 0x00594FCE File Offset: 0x005931CE
		public ISequenceTrackControlPointT()
		{
			this.Mark = null;
		}
	}
}
