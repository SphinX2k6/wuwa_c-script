using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F9 RID: 24825
	public class IActorTurnToT
	{
		// Token: 0x1700B6FD RID: 46845
		// (get) Token: 0x0602A6A9 RID: 173737 RVA: 0x005D82D3 File Offset: 0x005D64D3
		// (set) Token: 0x0602A6AA RID: 173738 RVA: 0x005D82DB File Offset: 0x005D64DB
		public int ActorIndex { get; set; }

		// Token: 0x1700B6FE RID: 46846
		// (get) Token: 0x0602A6AB RID: 173739 RVA: 0x005D82E4 File Offset: 0x005D64E4
		// (set) Token: 0x0602A6AC RID: 173740 RVA: 0x005D82EC File Offset: 0x005D64EC
		public TActorTurnToDataUnion Target { get; set; }

		// Token: 0x1700B6FF RID: 46847
		// (get) Token: 0x0602A6AD RID: 173741 RVA: 0x005D82F5 File Offset: 0x005D64F5
		// (set) Token: 0x0602A6AE RID: 173742 RVA: 0x005D82FD File Offset: 0x005D64FD
		public float DelayTime { get; set; }

		// Token: 0x1700B700 RID: 46848
		// (get) Token: 0x0602A6AF RID: 173743 RVA: 0x005D8306 File Offset: 0x005D6506
		// (set) Token: 0x0602A6B0 RID: 173744 RVA: 0x005D830E File Offset: 0x005D650E
		public bool UseLookAtForSmallAngle { get; set; }

		// Token: 0x1700B701 RID: 46849
		// (get) Token: 0x0602A6B1 RID: 173745 RVA: 0x005D8317 File Offset: 0x005D6517
		// (set) Token: 0x0602A6B2 RID: 173746 RVA: 0x005D831F File Offset: 0x005D651F
		public bool UpdatePosCache { get; set; }

		// Token: 0x1700B702 RID: 46850
		// (get) Token: 0x0602A6B3 RID: 173747 RVA: 0x005D8328 File Offset: 0x005D6528
		// (set) Token: 0x0602A6B4 RID: 173748 RVA: 0x005D8330 File Offset: 0x005D6530
		public byte NullMask { get; set; }

		// Token: 0x0602A6B5 RID: 173749 RVA: 0x005D8339 File Offset: 0x005D6539
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
