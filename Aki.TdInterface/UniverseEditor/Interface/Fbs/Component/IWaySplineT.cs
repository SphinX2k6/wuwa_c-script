using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B57 RID: 23383
	public class IWaySplineT
	{
		// Token: 0x1700B0A2 RID: 45218
		// (get) Token: 0x06028019 RID: 163865 RVA: 0x0058038E File Offset: 0x0057E58E
		// (set) Token: 0x0602801A RID: 163866 RVA: 0x00580396 File Offset: 0x0057E596
		public ESplineType Type { get; set; }

		// Token: 0x1700B0A3 RID: 45219
		// (get) Token: 0x0602801B RID: 163867 RVA: 0x0058039F File Offset: 0x0057E59F
		// (set) Token: 0x0602801C RID: 163868 RVA: 0x005803A7 File Offset: 0x0057E5A7
		public int RoadZoneId { get; set; }

		// Token: 0x1700B0A4 RID: 45220
		// (get) Token: 0x0602801D RID: 163869 RVA: 0x005803B0 File Offset: 0x0057E5B0
		// (set) Token: 0x0602801E RID: 163870 RVA: 0x005803B8 File Offset: 0x0057E5B8
		public string PcgRoadPathName { get; set; }

		// Token: 0x1700B0A5 RID: 45221
		// (get) Token: 0x0602801F RID: 163871 RVA: 0x005803C1 File Offset: 0x0057E5C1
		// (set) Token: 0x06028020 RID: 163872 RVA: 0x005803C9 File Offset: 0x0057E5C9
		public bool NoEntry { get; set; }

		// Token: 0x1700B0A6 RID: 45222
		// (get) Token: 0x06028021 RID: 163873 RVA: 0x005803D2 File Offset: 0x0057E5D2
		// (set) Token: 0x06028022 RID: 163874 RVA: 0x005803DA File Offset: 0x0057E5DA
		public IPavedWayConfigT PavedWayConfig { get; set; }

		// Token: 0x1700B0A7 RID: 45223
		// (get) Token: 0x06028023 RID: 163875 RVA: 0x005803E3 File Offset: 0x0057E5E3
		// (set) Token: 0x06028024 RID: 163876 RVA: 0x005803EB File Offset: 0x0057E5EB
		public List<IWaySplinePointT> Points { get; set; }

		// Token: 0x1700B0A8 RID: 45224
		// (get) Token: 0x06028025 RID: 163877 RVA: 0x005803F4 File Offset: 0x0057E5F4
		// (set) Token: 0x06028026 RID: 163878 RVA: 0x005803FC File Offset: 0x0057E5FC
		public List<int> Last { get; set; }

		// Token: 0x1700B0A9 RID: 45225
		// (get) Token: 0x06028027 RID: 163879 RVA: 0x00580405 File Offset: 0x0057E605
		// (set) Token: 0x06028028 RID: 163880 RVA: 0x0058040D File Offset: 0x0057E60D
		public List<int> Next { get; set; }

		// Token: 0x1700B0AA RID: 45226
		// (get) Token: 0x06028029 RID: 163881 RVA: 0x00580416 File Offset: 0x0057E616
		// (set) Token: 0x0602802A RID: 163882 RVA: 0x0058041E File Offset: 0x0057E61E
		public int Opposite { get; set; }

		// Token: 0x1700B0AB RID: 45227
		// (get) Token: 0x0602802B RID: 163883 RVA: 0x00580427 File Offset: 0x0057E627
		// (set) Token: 0x0602802C RID: 163884 RVA: 0x0058042F File Offset: 0x0057E62F
		public float Width { get; set; }

		// Token: 0x1700B0AC RID: 45228
		// (get) Token: 0x0602802D RID: 163885 RVA: 0x00580438 File Offset: 0x0057E638
		// (set) Token: 0x0602802E RID: 163886 RVA: 0x00580440 File Offset: 0x0057E640
		public byte NullMask { get; set; }

		// Token: 0x0602802F RID: 163887 RVA: 0x0058044C File Offset: 0x0057E64C
		public IWaySplineT()
		{
			this.Type = ESplineType.Common;
			this.RoadZoneId = 0;
			this.PcgRoadPathName = null;
			this.NoEntry = false;
			this.PavedWayConfig = new IPavedWayConfigT();
			this.Points = null;
			this.Last = null;
			this.Next = null;
			this.Opposite = 0;
			this.Width = 0f;
			this.NullMask = 0;
		}
	}
}
