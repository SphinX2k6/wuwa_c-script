using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAE RID: 27822
	public class IEnableActorT
	{
		// Token: 0x1700CC11 RID: 52241
		// (get) Token: 0x0602FF1E RID: 196382 RVA: 0x00686BBD File Offset: 0x00684DBD
		// (set) Token: 0x0602FF1F RID: 196383 RVA: 0x00686BC5 File Offset: 0x00684DC5
		public EActorType ActorType { get; set; }

		// Token: 0x1700CC12 RID: 52242
		// (get) Token: 0x0602FF20 RID: 196384 RVA: 0x00686BCE File Offset: 0x00684DCE
		// (set) Token: 0x0602FF21 RID: 196385 RVA: 0x00686BD6 File Offset: 0x00684DD6
		public List<IActorRefT> Targets { get; set; }

		// Token: 0x1700CC13 RID: 52243
		// (get) Token: 0x0602FF22 RID: 196386 RVA: 0x00686BDF File Offset: 0x00684DDF
		// (set) Token: 0x0602FF23 RID: 196387 RVA: 0x00686BE7 File Offset: 0x00684DE7
		public bool Enable { get; set; }

		// Token: 0x1700CC14 RID: 52244
		// (get) Token: 0x0602FF24 RID: 196388 RVA: 0x00686BF0 File Offset: 0x00684DF0
		// (set) Token: 0x0602FF25 RID: 196389 RVA: 0x00686BF8 File Offset: 0x00684DF8
		public bool SyncChildActor { get; set; }

		// Token: 0x1700CC15 RID: 52245
		// (get) Token: 0x0602FF26 RID: 196390 RVA: 0x00686C01 File Offset: 0x00684E01
		// (set) Token: 0x0602FF27 RID: 196391 RVA: 0x00686C09 File Offset: 0x00684E09
		public bool CollisionEnabled { get; set; }

		// Token: 0x1700CC16 RID: 52246
		// (get) Token: 0x0602FF28 RID: 196392 RVA: 0x00686C12 File Offset: 0x00684E12
		// (set) Token: 0x0602FF29 RID: 196393 RVA: 0x00686C1A File Offset: 0x00684E1A
		public bool CollisionPreserve { get; set; }

		// Token: 0x1700CC17 RID: 52247
		// (get) Token: 0x0602FF2A RID: 196394 RVA: 0x00686C23 File Offset: 0x00684E23
		// (set) Token: 0x0602FF2B RID: 196395 RVA: 0x00686C2B File Offset: 0x00684E2B
		public byte NullMask { get; set; }

		// Token: 0x0602FF2C RID: 196396 RVA: 0x00686C34 File Offset: 0x00684E34
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
