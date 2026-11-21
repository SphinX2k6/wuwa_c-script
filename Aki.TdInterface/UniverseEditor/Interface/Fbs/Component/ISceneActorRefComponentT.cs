using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EAB RID: 24235
	public class ISceneActorRefComponentT
	{
		// Token: 0x1700B302 RID: 45826
		// (get) Token: 0x06028998 RID: 166296 RVA: 0x0058D0D6 File Offset: 0x0058B2D6
		// (set) Token: 0x06028999 RID: 166297 RVA: 0x0058D0DE File Offset: 0x0058B2DE
		public bool Disabled { get; set; }

		// Token: 0x1700B303 RID: 45827
		// (get) Token: 0x0602899A RID: 166298 RVA: 0x0058D0E7 File Offset: 0x0058B2E7
		// (set) Token: 0x0602899B RID: 166299 RVA: 0x0058D0EF File Offset: 0x0058B2EF
		public List<ISceneActorRefGroupT> ActorRefGroups { get; set; }

		// Token: 0x1700B304 RID: 45828
		// (get) Token: 0x0602899C RID: 166300 RVA: 0x0058D0F8 File Offset: 0x0058B2F8
		// (set) Token: 0x0602899D RID: 166301 RVA: 0x0058D100 File Offset: 0x0058B300
		public List<IActorRefT> VolumesRef { get; set; }

		// Token: 0x1700B305 RID: 45829
		// (get) Token: 0x0602899E RID: 166302 RVA: 0x0058D109 File Offset: 0x0058B309
		// (set) Token: 0x0602899F RID: 166303 RVA: 0x0058D111 File Offset: 0x0058B311
		public ILiftFloorSeqMarkConfigT LiftFloorSeqMarks { get; set; }

		// Token: 0x1700B306 RID: 45830
		// (get) Token: 0x060289A0 RID: 166304 RVA: 0x0058D11A File Offset: 0x0058B31A
		// (set) Token: 0x060289A1 RID: 166305 RVA: 0x0058D122 File Offset: 0x0058B322
		public List<IActorRefT> ZoneFollowCameraControllerRef { get; set; }

		// Token: 0x1700B307 RID: 45831
		// (get) Token: 0x060289A2 RID: 166306 RVA: 0x0058D12B File Offset: 0x0058B32B
		// (set) Token: 0x060289A3 RID: 166307 RVA: 0x0058D133 File Offset: 0x0058B333
		public List<IRefactorActorRef2EntitiesT> RefactorActorRef2Entities { get; set; }

		// Token: 0x1700B308 RID: 45832
		// (get) Token: 0x060289A4 RID: 166308 RVA: 0x0058D13C File Offset: 0x0058B33C
		// (set) Token: 0x060289A5 RID: 166309 RVA: 0x0058D144 File Offset: 0x0058B344
		public List<IActorRefT> NoiseWallRefs { get; set; }

		// Token: 0x1700B309 RID: 45833
		// (get) Token: 0x060289A6 RID: 166310 RVA: 0x0058D14D File Offset: 0x0058B34D
		// (set) Token: 0x060289A7 RID: 166311 RVA: 0x0058D155 File Offset: 0x0058B355
		public byte NullMask { get; set; }

		// Token: 0x060289A8 RID: 166312 RVA: 0x0058D15E File Offset: 0x0058B35E
		public ISceneActorRefComponentT()
		{
			this.Disabled = false;
			this.ActorRefGroups = null;
			this.VolumesRef = null;
			this.LiftFloorSeqMarks = null;
			this.ZoneFollowCameraControllerRef = null;
			this.RefactorActorRef2Entities = null;
			this.NoiseWallRefs = null;
			this.NullMask = 0;
		}
	}
}
