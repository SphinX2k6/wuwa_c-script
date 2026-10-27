using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F7 RID: 16887
	public class ITrackEffectTypeT
	{
		// Token: 0x170077DD RID: 30685
		// (get) Token: 0x06018EAA RID: 102058 RVA: 0x00395CB2 File Offset: 0x00393EB2
		// (set) Token: 0x06018EAB RID: 102059 RVA: 0x00395CBA File Offset: 0x00393EBA
		public ETrackEffectType Type { get; set; }

		// Token: 0x06018EAC RID: 102060 RVA: 0x00395CC3 File Offset: 0x00393EC3
		public ITrackEffectTypeT()
		{
			this.Type = ETrackEffectType.AutoChange;
		}
	}
}
