using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007763 RID: 30563
	public class ISetAnimSequenceBlendAnimTypeT
	{
		// Token: 0x1700E004 RID: 57348
		// (get) Token: 0x06035A49 RID: 219721 RVA: 0x00730807 File Offset: 0x0072EA07
		// (set) Token: 0x06035A4A RID: 219722 RVA: 0x0073080F File Offset: 0x0072EA0F
		public EBlendAnimType Type { get; set; }

		// Token: 0x1700E005 RID: 57349
		// (get) Token: 0x06035A4B RID: 219723 RVA: 0x00730818 File Offset: 0x0072EA18
		// (set) Token: 0x06035A4C RID: 219724 RVA: 0x00730820 File Offset: 0x0072EA20
		public string AnimSequence { get; set; }

		// Token: 0x1700E006 RID: 57350
		// (get) Token: 0x06035A4D RID: 219725 RVA: 0x00730829 File Offset: 0x0072EA29
		// (set) Token: 0x06035A4E RID: 219726 RVA: 0x00730831 File Offset: 0x0072EA31
		public float ProtectTime { get; set; }

		// Token: 0x1700E007 RID: 57351
		// (get) Token: 0x06035A4F RID: 219727 RVA: 0x0073083A File Offset: 0x0072EA3A
		// (set) Token: 0x06035A50 RID: 219728 RVA: 0x00730842 File Offset: 0x0072EA42
		public byte NullMask { get; set; }

		// Token: 0x06035A51 RID: 219729 RVA: 0x0073084B File Offset: 0x0072EA4B
		public ISetAnimSequenceBlendAnimTypeT()
		{
			this.Type = EBlendAnimType.StateMachine;
			this.AnimSequence = null;
			this.ProtectTime = 0f;
			this.NullMask = 0;
		}
	}
}
