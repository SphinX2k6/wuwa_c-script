using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D2F RID: 23855
	public class IPetalGrabRoleMotionInteractT
	{
		// Token: 0x1700AF5F RID: 44895
		// (get) Token: 0x06027A7C RID: 162428 RVA: 0x0056CE29 File Offset: 0x0056B029
		// (set) Token: 0x06027A7D RID: 162429 RVA: 0x0056CE31 File Offset: 0x0056B031
		public ERoleMotionInteractType Type { get; set; }

		// Token: 0x1700AF60 RID: 44896
		// (get) Token: 0x06027A7E RID: 162430 RVA: 0x0056CE3A File Offset: 0x0056B03A
		// (set) Token: 0x06027A7F RID: 162431 RVA: 0x0056CE42 File Offset: 0x0056B042
		public EPetalGrabHandType HandOption { get; set; }

		// Token: 0x1700AF61 RID: 44897
		// (get) Token: 0x06027A80 RID: 162432 RVA: 0x0056CE4B File Offset: 0x0056B04B
		// (set) Token: 0x06027A81 RID: 162433 RVA: 0x0056CE53 File Offset: 0x0056B053
		public IPosAndRotT GrabPointOffset { get; set; }

		// Token: 0x1700AF62 RID: 44898
		// (get) Token: 0x06027A82 RID: 162434 RVA: 0x0056CE5C File Offset: 0x0056B05C
		// (set) Token: 0x06027A83 RID: 162435 RVA: 0x0056CE64 File Offset: 0x0056B064
		public List<IPetalGrabEventT> GrabEvents { get; set; }

		// Token: 0x1700AF63 RID: 44899
		// (get) Token: 0x06027A84 RID: 162436 RVA: 0x0056CE6D File Offset: 0x0056B06D
		// (set) Token: 0x06027A85 RID: 162437 RVA: 0x0056CE75 File Offset: 0x0056B075
		public int NextPointEntityId { get; set; }

		// Token: 0x1700AF64 RID: 44900
		// (get) Token: 0x06027A86 RID: 162438 RVA: 0x0056CE7E File Offset: 0x0056B07E
		// (set) Token: 0x06027A87 RID: 162439 RVA: 0x0056CE86 File Offset: 0x0056B086
		public int FlightSplineId { get; set; }

		// Token: 0x1700AF65 RID: 44901
		// (get) Token: 0x06027A88 RID: 162440 RVA: 0x0056CE8F File Offset: 0x0056B08F
		// (set) Token: 0x06027A89 RID: 162441 RVA: 0x0056CE97 File Offset: 0x0056B097
		public TSplineMovePatternUnion FlightSplineMovePattern { get; set; }

		// Token: 0x1700AF66 RID: 44902
		// (get) Token: 0x06027A8A RID: 162442 RVA: 0x0056CEA0 File Offset: 0x0056B0A0
		// (set) Token: 0x06027A8B RID: 162443 RVA: 0x0056CEA8 File Offset: 0x0056B0A8
		public byte NullMask { get; set; }

		// Token: 0x06027A8C RID: 162444 RVA: 0x0056CEB1 File Offset: 0x0056B0B1
		public IPetalGrabRoleMotionInteractT()
		{
			this.Type = ERoleMotionInteractType.PetalGrab;
			this.HandOption = EPetalGrabHandType.LeftHand;
			this.GrabPointOffset = null;
			this.GrabEvents = null;
			this.NextPointEntityId = 0;
			this.FlightSplineId = 0;
			this.FlightSplineMovePattern = null;
			this.NullMask = 0;
		}
	}
}
