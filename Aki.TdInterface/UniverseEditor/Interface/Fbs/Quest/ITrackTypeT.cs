using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421E RID: 16926
	public class ITrackTypeT
	{
		// Token: 0x17007843 RID: 30787
		// (get) Token: 0x06019064 RID: 102500 RVA: 0x00399F1F File Offset: 0x0039811F
		// (set) Token: 0x06019065 RID: 102501 RVA: 0x00399F27 File Offset: 0x00398127
		public ETrackType Type { get; set; }

		// Token: 0x17007844 RID: 30788
		// (get) Token: 0x06019066 RID: 102502 RVA: 0x00399F30 File Offset: 0x00398130
		// (set) Token: 0x06019067 RID: 102503 RVA: 0x00399F38 File Offset: 0x00398138
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x06019068 RID: 102504 RVA: 0x00399F41 File Offset: 0x00398141
		public ITrackTypeT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
		}
	}
}
