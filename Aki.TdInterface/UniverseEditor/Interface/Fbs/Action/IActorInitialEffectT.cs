using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C9 RID: 24777
	public class IActorInitialEffectT
	{
		// Token: 0x1700B691 RID: 46737
		// (get) Token: 0x0602A4EA RID: 173290 RVA: 0x005D4B0E File Offset: 0x005D2D0E
		// (set) Token: 0x0602A4EB RID: 173291 RVA: 0x005D4B16 File Offset: 0x005D2D16
		public List<int> EffectIds { get; set; }

		// Token: 0x1700B692 RID: 46738
		// (get) Token: 0x0602A4EC RID: 173292 RVA: 0x005D4B1F File Offset: 0x005D2D1F
		// (set) Token: 0x0602A4ED RID: 173293 RVA: 0x005D4B27 File Offset: 0x005D2D27
		public List<int> EffectIdsMaleVariant { get; set; }

		// Token: 0x1700B693 RID: 46739
		// (get) Token: 0x0602A4EE RID: 173294 RVA: 0x005D4B30 File Offset: 0x005D2D30
		// (set) Token: 0x0602A4EF RID: 173295 RVA: 0x005D4B38 File Offset: 0x005D2D38
		public byte NullMask { get; set; }

		// Token: 0x0602A4F0 RID: 173296 RVA: 0x005D4B41 File Offset: 0x005D2D41
		public IActorInitialEffectT()
		{
			this.EffectIds = null;
			this.EffectIdsMaleVariant = null;
			this.NullMask = 0;
		}
	}
}
