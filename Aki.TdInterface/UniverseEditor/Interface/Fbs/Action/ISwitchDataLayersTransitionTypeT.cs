using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007251 RID: 29265
	public class ISwitchDataLayersTransitionTypeT
	{
		// Token: 0x1700D928 RID: 55592
		// (get) Token: 0x06033EA2 RID: 212642 RVA: 0x006FBAC2 File Offset: 0x006F9CC2
		// (set) Token: 0x06033EA3 RID: 212643 RVA: 0x006FBACA File Offset: 0x006F9CCA
		public ESwitchDataLayersTransitionType Type { get; set; }

		// Token: 0x06033EA4 RID: 212644 RVA: 0x006FBAD3 File Offset: 0x006F9CD3
		public ISwitchDataLayersTransitionTypeT()
		{
			this.Type = ESwitchDataLayersTransitionType.Sequence;
		}
	}
}
