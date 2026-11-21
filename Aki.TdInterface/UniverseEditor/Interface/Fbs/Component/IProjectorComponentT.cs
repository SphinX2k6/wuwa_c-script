using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB0 RID: 23984
	public class IProjectorComponentT
	{
		// Token: 0x1700B0A4 RID: 45220
		// (get) Token: 0x06027FA6 RID: 163750 RVA: 0x00577FBF File Offset: 0x005761BF
		// (set) Token: 0x06027FA7 RID: 163751 RVA: 0x00577FC7 File Offset: 0x005761C7
		public bool Disabled { get; set; }

		// Token: 0x1700B0A5 RID: 45221
		// (get) Token: 0x06027FA8 RID: 163752 RVA: 0x00577FD0 File Offset: 0x005761D0
		// (set) Token: 0x06027FA9 RID: 163753 RVA: 0x00577FD8 File Offset: 0x005761D8
		public int ProjectorPatternId { get; set; }

		// Token: 0x1700B0A6 RID: 45222
		// (get) Token: 0x06027FAA RID: 163754 RVA: 0x00577FE1 File Offset: 0x005761E1
		// (set) Token: 0x06027FAB RID: 163755 RVA: 0x00577FE9 File Offset: 0x005761E9
		public float RotationSpeed { get; set; }

		// Token: 0x1700B0A7 RID: 45223
		// (get) Token: 0x06027FAC RID: 163756 RVA: 0x00577FF2 File Offset: 0x005761F2
		// (set) Token: 0x06027FAD RID: 163757 RVA: 0x00577FFA File Offset: 0x005761FA
		public float DragRotationCoefficient { get; set; }

		// Token: 0x1700B0A8 RID: 45224
		// (get) Token: 0x06027FAE RID: 163758 RVA: 0x00578003 File Offset: 0x00576203
		// (set) Token: 0x06027FAF RID: 163759 RVA: 0x0057800B File Offset: 0x0057620B
		public List<IVectorInfoT> RotationTargetAngles { get; set; }

		// Token: 0x1700B0A9 RID: 45225
		// (get) Token: 0x06027FB0 RID: 163760 RVA: 0x00578014 File Offset: 0x00576214
		// (set) Token: 0x06027FB1 RID: 163761 RVA: 0x0057801C File Offset: 0x0057621C
		public float MatchTolerance { get; set; }

		// Token: 0x1700B0AA RID: 45226
		// (get) Token: 0x06027FB2 RID: 163762 RVA: 0x00578025 File Offset: 0x00576225
		// (set) Token: 0x06027FB3 RID: 163763 RVA: 0x0057802D File Offset: 0x0057622D
		public int BackgroundEntityId { get; set; }

		// Token: 0x1700B0AB RID: 45227
		// (get) Token: 0x06027FB4 RID: 163764 RVA: 0x00578036 File Offset: 0x00576236
		// (set) Token: 0x06027FB5 RID: 163765 RVA: 0x0057803E File Offset: 0x0057623E
		public byte NullMask { get; set; }

		// Token: 0x06027FB6 RID: 163766 RVA: 0x00578048 File Offset: 0x00576248
		public IProjectorComponentT()
		{
			this.Disabled = false;
			this.ProjectorPatternId = 0;
			this.RotationSpeed = 0f;
			this.DragRotationCoefficient = 0f;
			this.RotationTargetAngles = null;
			this.MatchTolerance = 0f;
			this.BackgroundEntityId = 0;
			this.NullMask = 0;
		}
	}
}
