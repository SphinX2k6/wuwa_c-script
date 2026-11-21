using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D98 RID: 28056
	public class IExecuteTagT
	{
		// Token: 0x1700CDC1 RID: 52673
		// (get) Token: 0x060306C9 RID: 198345 RVA: 0x0069458B File Offset: 0x0069278B
		// (set) Token: 0x060306CA RID: 198346 RVA: 0x00694593 File Offset: 0x00692793
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700CDC2 RID: 52674
		// (get) Token: 0x060306CB RID: 198347 RVA: 0x0069459C File Offset: 0x0069279C
		// (set) Token: 0x060306CC RID: 198348 RVA: 0x006945A4 File Offset: 0x006927A4
		public float DelayTime { get; set; }

		// Token: 0x1700CDC3 RID: 52675
		// (get) Token: 0x060306CD RID: 198349 RVA: 0x006945AD File Offset: 0x006927AD
		// (set) Token: 0x060306CE RID: 198350 RVA: 0x006945B5 File Offset: 0x006927B5
		public List<int> Tags { get; set; }

		// Token: 0x1700CDC4 RID: 52676
		// (get) Token: 0x060306CF RID: 198351 RVA: 0x006945BE File Offset: 0x006927BE
		// (set) Token: 0x060306D0 RID: 198352 RVA: 0x006945C6 File Offset: 0x006927C6
		public byte NullMask { get; set; }

		// Token: 0x060306D1 RID: 198353 RVA: 0x006945CF File Offset: 0x006927CF
		public IExecuteTagT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.Tags = null;
			this.NullMask = 0;
		}
	}
}
