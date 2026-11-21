using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006716 RID: 26390
	public class IActorFxEmoteStopT
	{
		// Token: 0x1700BFE2 RID: 49122
		// (get) Token: 0x0602CB31 RID: 183089 RVA: 0x0061DB3F File Offset: 0x0061BD3F
		// (set) Token: 0x0602CB32 RID: 183090 RVA: 0x0061DB47 File Offset: 0x0061BD47
		public EActorFxEmoteType Type { get; set; }

		// Token: 0x1700BFE3 RID: 49123
		// (get) Token: 0x0602CB33 RID: 183091 RVA: 0x0061DB50 File Offset: 0x0061BD50
		// (set) Token: 0x0602CB34 RID: 183092 RVA: 0x0061DB58 File Offset: 0x0061BD58
		public TActorFxEmoteStopSubTypeUnion StopType { get; set; }

		// Token: 0x1700BFE4 RID: 49124
		// (get) Token: 0x0602CB35 RID: 183093 RVA: 0x0061DB61 File Offset: 0x0061BD61
		// (set) Token: 0x0602CB36 RID: 183094 RVA: 0x0061DB69 File Offset: 0x0061BD69
		public float DelayTime { get; set; }

		// Token: 0x1700BFE5 RID: 49125
		// (get) Token: 0x0602CB37 RID: 183095 RVA: 0x0061DB72 File Offset: 0x0061BD72
		// (set) Token: 0x0602CB38 RID: 183096 RVA: 0x0061DB7A File Offset: 0x0061BD7A
		public byte NullMask { get; set; }

		// Token: 0x0602CB39 RID: 183097 RVA: 0x0061DB83 File Offset: 0x0061BD83
		public IActorFxEmoteStopT()
		{
			this.Type = EActorFxEmoteType.Play;
			this.StopType = null;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
