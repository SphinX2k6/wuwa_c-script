using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006704 RID: 26372
	public class IActorFaceExpressionStopT
	{
		// Token: 0x1700BFB8 RID: 49080
		// (get) Token: 0x0602CA8D RID: 182925 RVA: 0x0061C662 File Offset: 0x0061A862
		// (set) Token: 0x0602CA8E RID: 182926 RVA: 0x0061C66A File Offset: 0x0061A86A
		public EActorFaceExpressionType Type { get; set; }

		// Token: 0x1700BFB9 RID: 49081
		// (get) Token: 0x0602CA8F RID: 182927 RVA: 0x0061C673 File Offset: 0x0061A873
		// (set) Token: 0x0602CA90 RID: 182928 RVA: 0x0061C67B File Offset: 0x0061A87B
		public float DelayTime { get; set; }

		// Token: 0x1700BFBA RID: 49082
		// (get) Token: 0x0602CA91 RID: 182929 RVA: 0x0061C684 File Offset: 0x0061A884
		// (set) Token: 0x0602CA92 RID: 182930 RVA: 0x0061C68C File Offset: 0x0061A88C
		public byte NullMask { get; set; }

		// Token: 0x0602CA93 RID: 182931 RVA: 0x0061C695 File Offset: 0x0061A895
		public IActorFaceExpressionStopT()
		{
			this.Type = EActorFaceExpressionType.Play;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
