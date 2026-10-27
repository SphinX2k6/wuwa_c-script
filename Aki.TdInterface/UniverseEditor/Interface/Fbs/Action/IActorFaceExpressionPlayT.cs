using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200609F RID: 24735
	public class IActorFaceExpressionPlayT
	{
		// Token: 0x1700B645 RID: 46661
		// (get) Token: 0x0602A390 RID: 172944 RVA: 0x005D23F4 File Offset: 0x005D05F4
		// (set) Token: 0x0602A391 RID: 172945 RVA: 0x005D23FC File Offset: 0x005D05FC
		public EActorFaceExpressionType Type { get; set; }

		// Token: 0x1700B646 RID: 46662
		// (get) Token: 0x0602A392 RID: 172946 RVA: 0x005D2405 File Offset: 0x005D0605
		// (set) Token: 0x0602A393 RID: 172947 RVA: 0x005D240D File Offset: 0x005D060D
		public int FaceExpressionId { get; set; }

		// Token: 0x1700B647 RID: 46663
		// (get) Token: 0x0602A394 RID: 172948 RVA: 0x005D2416 File Offset: 0x005D0616
		// (set) Token: 0x0602A395 RID: 172949 RVA: 0x005D241E File Offset: 0x005D061E
		public float DelayTime { get; set; }

		// Token: 0x1700B648 RID: 46664
		// (get) Token: 0x0602A396 RID: 172950 RVA: 0x005D2427 File Offset: 0x005D0627
		// (set) Token: 0x0602A397 RID: 172951 RVA: 0x005D242F File Offset: 0x005D062F
		public byte NullMask { get; set; }

		// Token: 0x0602A398 RID: 172952 RVA: 0x005D2438 File Offset: 0x005D0638
		public IActorFaceExpressionPlayT()
		{
			this.Type = EActorFaceExpressionType.Play;
			this.FaceExpressionId = 0;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
