using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006159 RID: 24921
	public class IAdjustFixedLookAtTargetBaseT
	{
		// Token: 0x1700B910 RID: 47376
		// (get) Token: 0x0602ACF6 RID: 175350 RVA: 0x005E6F86 File Offset: 0x005E5186
		// (set) Token: 0x0602ACF7 RID: 175351 RVA: 0x005E6F8E File Offset: 0x005E518E
		public EFixedLookAtTargetType Type { get; set; }

		// Token: 0x0602ACF8 RID: 175352 RVA: 0x005E6F97 File Offset: 0x005E5197
		public IAdjustFixedLookAtTargetBaseT()
		{
			this.Type = EFixedLookAtTargetType.RangeEntity;
		}
	}
}
