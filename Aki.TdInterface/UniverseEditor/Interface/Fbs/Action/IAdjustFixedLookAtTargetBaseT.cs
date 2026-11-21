using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BE RID: 26558
	public class IAdjustFixedLookAtTargetBaseT
	{
		// Token: 0x1700C280 RID: 49792
		// (get) Token: 0x0602D3EF RID: 185327 RVA: 0x00631162 File Offset: 0x0062F362
		// (set) Token: 0x0602D3F0 RID: 185328 RVA: 0x0063116A File Offset: 0x0062F36A
		public EFixedLookAtTargetType Type { get; set; }

		// Token: 0x0602D3F1 RID: 185329 RVA: 0x00631173 File Offset: 0x0062F373
		public IAdjustFixedLookAtTargetBaseT()
		{
			this.Type = EFixedLookAtTargetType.RangeEntity;
		}
	}
}
