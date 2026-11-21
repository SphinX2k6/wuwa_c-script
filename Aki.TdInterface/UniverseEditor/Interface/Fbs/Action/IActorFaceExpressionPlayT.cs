using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006701 RID: 26369
	public class IActorFaceExpressionPlayT
	{
		// Token: 0x1700BFB0 RID: 49072
		// (get) Token: 0x0602CA71 RID: 182897 RVA: 0x0061C39C File Offset: 0x0061A59C
		// (set) Token: 0x0602CA72 RID: 182898 RVA: 0x0061C3A4 File Offset: 0x0061A5A4
		public EActorFaceExpressionType Type { get; set; }

		// Token: 0x1700BFB1 RID: 49073
		// (get) Token: 0x0602CA73 RID: 182899 RVA: 0x0061C3AD File Offset: 0x0061A5AD
		// (set) Token: 0x0602CA74 RID: 182900 RVA: 0x0061C3B5 File Offset: 0x0061A5B5
		public int FaceExpressionId { get; set; }

		// Token: 0x1700BFB2 RID: 49074
		// (get) Token: 0x0602CA75 RID: 182901 RVA: 0x0061C3BE File Offset: 0x0061A5BE
		// (set) Token: 0x0602CA76 RID: 182902 RVA: 0x0061C3C6 File Offset: 0x0061A5C6
		public float DelayTime { get; set; }

		// Token: 0x1700BFB3 RID: 49075
		// (get) Token: 0x0602CA77 RID: 182903 RVA: 0x0061C3CF File Offset: 0x0061A5CF
		// (set) Token: 0x0602CA78 RID: 182904 RVA: 0x0061C3D7 File Offset: 0x0061A5D7
		public byte NullMask { get; set; }

		// Token: 0x0602CA79 RID: 182905 RVA: 0x0061C3E0 File Offset: 0x0061A5E0
		public IActorFaceExpressionPlayT()
		{
			this.Type = EActorFaceExpressionType.Play;
			this.FaceExpressionId = 0;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
