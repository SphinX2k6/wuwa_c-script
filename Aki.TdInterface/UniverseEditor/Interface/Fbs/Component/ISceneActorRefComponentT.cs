using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589E RID: 22686
	public class ISceneActorRefComponentT
	{
		// Token: 0x1700A9D2 RID: 43474
		// (get) Token: 0x06026436 RID: 156726 RVA: 0x0054658A File Offset: 0x0054478A
		// (set) Token: 0x06026437 RID: 156727 RVA: 0x00546592 File Offset: 0x00544792
		public bool Disabled { get; set; }

		// Token: 0x1700A9D3 RID: 43475
		// (get) Token: 0x06026438 RID: 156728 RVA: 0x0054659B File Offset: 0x0054479B
		// (set) Token: 0x06026439 RID: 156729 RVA: 0x005465A3 File Offset: 0x005447A3
		public List<ISceneActorRefGroupT> ActorRefGroups { get; set; }

		// Token: 0x1700A9D4 RID: 43476
		// (get) Token: 0x0602643A RID: 156730 RVA: 0x005465AC File Offset: 0x005447AC
		// (set) Token: 0x0602643B RID: 156731 RVA: 0x005465B4 File Offset: 0x005447B4
		public List<IActorRefT> VolumesRef { get; set; }

		// Token: 0x1700A9D5 RID: 43477
		// (get) Token: 0x0602643C RID: 156732 RVA: 0x005465BD File Offset: 0x005447BD
		// (set) Token: 0x0602643D RID: 156733 RVA: 0x005465C5 File Offset: 0x005447C5
		public ILiftFloorSeqMarkConfigT LiftFloorSeqMarks { get; set; }

		// Token: 0x1700A9D6 RID: 43478
		// (get) Token: 0x0602643E RID: 156734 RVA: 0x005465CE File Offset: 0x005447CE
		// (set) Token: 0x0602643F RID: 156735 RVA: 0x005465D6 File Offset: 0x005447D6
		public List<IActorRefT> ZoneFollowCameraControllerRef { get; set; }

		// Token: 0x1700A9D7 RID: 43479
		// (get) Token: 0x06026440 RID: 156736 RVA: 0x005465DF File Offset: 0x005447DF
		// (set) Token: 0x06026441 RID: 156737 RVA: 0x005465E7 File Offset: 0x005447E7
		public List<IRefactorActorRef2EntitiesT> RefactorActorRef2Entities { get; set; }

		// Token: 0x1700A9D8 RID: 43480
		// (get) Token: 0x06026442 RID: 156738 RVA: 0x005465F0 File Offset: 0x005447F0
		// (set) Token: 0x06026443 RID: 156739 RVA: 0x005465F8 File Offset: 0x005447F8
		public List<IActorRefT> NoiseWallRefs { get; set; }

		// Token: 0x1700A9D9 RID: 43481
		// (get) Token: 0x06026444 RID: 156740 RVA: 0x00546601 File Offset: 0x00544801
		// (set) Token: 0x06026445 RID: 156741 RVA: 0x00546609 File Offset: 0x00544809
		public byte NullMask { get; set; }

		// Token: 0x06026446 RID: 156742 RVA: 0x00546612 File Offset: 0x00544812
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
