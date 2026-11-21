using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675B RID: 26459
	public class IActorTurnToT
	{
		// Token: 0x1700C068 RID: 49256
		// (get) Token: 0x0602CD8A RID: 183690 RVA: 0x0062227B File Offset: 0x0062047B
		// (set) Token: 0x0602CD8B RID: 183691 RVA: 0x00622283 File Offset: 0x00620483
		public int ActorIndex { get; set; }

		// Token: 0x1700C069 RID: 49257
		// (get) Token: 0x0602CD8C RID: 183692 RVA: 0x0062228C File Offset: 0x0062048C
		// (set) Token: 0x0602CD8D RID: 183693 RVA: 0x00622294 File Offset: 0x00620494
		public TActorTurnToDataUnion Target { get; set; }

		// Token: 0x1700C06A RID: 49258
		// (get) Token: 0x0602CD8E RID: 183694 RVA: 0x0062229D File Offset: 0x0062049D
		// (set) Token: 0x0602CD8F RID: 183695 RVA: 0x006222A5 File Offset: 0x006204A5
		public float DelayTime { get; set; }

		// Token: 0x1700C06B RID: 49259
		// (get) Token: 0x0602CD90 RID: 183696 RVA: 0x006222AE File Offset: 0x006204AE
		// (set) Token: 0x0602CD91 RID: 183697 RVA: 0x006222B6 File Offset: 0x006204B6
		public bool UseLookAtForSmallAngle { get; set; }

		// Token: 0x1700C06C RID: 49260
		// (get) Token: 0x0602CD92 RID: 183698 RVA: 0x006222BF File Offset: 0x006204BF
		// (set) Token: 0x0602CD93 RID: 183699 RVA: 0x006222C7 File Offset: 0x006204C7
		public bool UpdatePosCache { get; set; }

		// Token: 0x1700C06D RID: 49261
		// (get) Token: 0x0602CD94 RID: 183700 RVA: 0x006222D0 File Offset: 0x006204D0
		// (set) Token: 0x0602CD95 RID: 183701 RVA: 0x006222D8 File Offset: 0x006204D8
		public byte NullMask { get; set; }

		// Token: 0x0602CD96 RID: 183702 RVA: 0x006222E1 File Offset: 0x006204E1
		public IActorTurnToT()
		{
			this.ActorIndex = 0;
			this.Target = null;
			this.DelayTime = 0f;
			this.UseLookAtForSmallAngle = false;
			this.UpdatePosCache = false;
			this.NullMask = 0;
		}
	}
}
