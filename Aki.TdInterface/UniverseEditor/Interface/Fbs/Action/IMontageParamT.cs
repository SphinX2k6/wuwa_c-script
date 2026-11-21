using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007238 RID: 29240
	public class IMontageParamT
	{
		// Token: 0x1700D62E RID: 54830
		// (get) Token: 0x06032E80 RID: 208512 RVA: 0x006DF8AD File Offset: 0x006DDAAD
		// (set) Token: 0x06032E81 RID: 208513 RVA: 0x006DF8B5 File Offset: 0x006DDAB5
		public IMontageIdT MontageId { get; set; }

		// Token: 0x1700D62F RID: 54831
		// (get) Token: 0x06032E82 RID: 208514 RVA: 0x006DF8BE File Offset: 0x006DDABE
		// (set) Token: 0x06032E83 RID: 208515 RVA: 0x006DF8C6 File Offset: 0x006DDAC6
		public bool IsLoop { get; set; }

		// Token: 0x1700D630 RID: 54832
		// (get) Token: 0x06032E84 RID: 208516 RVA: 0x006DF8CF File Offset: 0x006DDACF
		// (set) Token: 0x06032E85 RID: 208517 RVA: 0x006DF8D7 File Offset: 0x006DDAD7
		public bool KeepPose { get; set; }

		// Token: 0x1700D631 RID: 54833
		// (get) Token: 0x06032E86 RID: 208518 RVA: 0x006DF8E0 File Offset: 0x006DDAE0
		// (set) Token: 0x06032E87 RID: 208519 RVA: 0x006DF8E8 File Offset: 0x006DDAE8
		public float DelayTime { get; set; }

		// Token: 0x1700D632 RID: 54834
		// (get) Token: 0x06032E88 RID: 208520 RVA: 0x006DF8F1 File Offset: 0x006DDAF1
		// (set) Token: 0x06032E89 RID: 208521 RVA: 0x006DF8F9 File Offset: 0x006DDAF9
		public byte NullMask { get; set; }

		// Token: 0x06032E8A RID: 208522 RVA: 0x006DF902 File Offset: 0x006DDB02
		public IMontageParamT()
		{
			this.MontageId = null;
			this.IsLoop = false;
			this.KeepPose = false;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
