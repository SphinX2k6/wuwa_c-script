using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200663D RID: 26173
	public class IEnableActorT
	{
		// Token: 0x1700C273 RID: 49779
		// (get) Token: 0x0602D74D RID: 186189 RVA: 0x0063A055 File Offset: 0x00638255
		// (set) Token: 0x0602D74E RID: 186190 RVA: 0x0063A05D File Offset: 0x0063825D
		public EActorType ActorType { get; set; }

		// Token: 0x1700C274 RID: 49780
		// (get) Token: 0x0602D74F RID: 186191 RVA: 0x0063A066 File Offset: 0x00638266
		// (set) Token: 0x0602D750 RID: 186192 RVA: 0x0063A06E File Offset: 0x0063826E
		public List<IActorRefT> Targets { get; set; }

		// Token: 0x1700C275 RID: 49781
		// (get) Token: 0x0602D751 RID: 186193 RVA: 0x0063A077 File Offset: 0x00638277
		// (set) Token: 0x0602D752 RID: 186194 RVA: 0x0063A07F File Offset: 0x0063827F
		public bool Enable { get; set; }

		// Token: 0x1700C276 RID: 49782
		// (get) Token: 0x0602D753 RID: 186195 RVA: 0x0063A088 File Offset: 0x00638288
		// (set) Token: 0x0602D754 RID: 186196 RVA: 0x0063A090 File Offset: 0x00638290
		public bool SyncChildActor { get; set; }

		// Token: 0x1700C277 RID: 49783
		// (get) Token: 0x0602D755 RID: 186197 RVA: 0x0063A099 File Offset: 0x00638299
		// (set) Token: 0x0602D756 RID: 186198 RVA: 0x0063A0A1 File Offset: 0x006382A1
		public bool CollisionEnabled { get; set; }

		// Token: 0x1700C278 RID: 49784
		// (get) Token: 0x0602D757 RID: 186199 RVA: 0x0063A0AA File Offset: 0x006382AA
		// (set) Token: 0x0602D758 RID: 186200 RVA: 0x0063A0B2 File Offset: 0x006382B2
		public bool CollisionPreserve { get; set; }

		// Token: 0x1700C279 RID: 49785
		// (get) Token: 0x0602D759 RID: 186201 RVA: 0x0063A0BB File Offset: 0x006382BB
		// (set) Token: 0x0602D75A RID: 186202 RVA: 0x0063A0C3 File Offset: 0x006382C3
		public byte NullMask { get; set; }

		// Token: 0x0602D75B RID: 186203 RVA: 0x0063A0CC File Offset: 0x006382CC
		public IEnableActorT()
		{
			this.ActorType = EActorType.MeshActor;
			this.Targets = null;
			this.Enable = false;
			this.SyncChildActor = false;
			this.CollisionEnabled = false;
			this.CollisionPreserve = false;
			this.NullMask = 0;
		}
	}
}
