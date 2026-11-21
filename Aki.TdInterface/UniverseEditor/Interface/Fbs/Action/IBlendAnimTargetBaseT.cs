using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006878 RID: 26744
	public class IBlendAnimTargetBaseT
	{
		// Token: 0x1700C498 RID: 50328
		// (get) Token: 0x0602DB8C RID: 187276 RVA: 0x00640752 File Offset: 0x0063E952
		// (set) Token: 0x0602DB8D RID: 187277 RVA: 0x0064075A File Offset: 0x0063E95A
		public EBlendAnimTarget Type { get; set; }

		// Token: 0x0602DB8E RID: 187278 RVA: 0x00640763 File Offset: 0x0063E963
		public IBlendAnimTargetBaseT()
		{
			this.Type = EBlendAnimTarget.Player;
		}
	}
}
