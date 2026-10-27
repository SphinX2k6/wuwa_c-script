using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E7E RID: 20094
	public class IAiGearStrategyComponentT
	{
		// Token: 0x17008FF9 RID: 36857
		// (get) Token: 0x0601F97A RID: 129402 RVA: 0x00466949 File Offset: 0x00464B49
		// (set) Token: 0x0601F97B RID: 129403 RVA: 0x00466951 File Offset: 0x00464B51
		public bool Disabled { get; set; }

		// Token: 0x17008FFA RID: 36858
		// (get) Token: 0x0601F97C RID: 129404 RVA: 0x0046695A File Offset: 0x00464B5A
		// (set) Token: 0x0601F97D RID: 129405 RVA: 0x00466962 File Offset: 0x00464B62
		public TAiGearStrategyUnion StrategyType { get; set; }

		// Token: 0x17008FFB RID: 36859
		// (get) Token: 0x0601F97E RID: 129406 RVA: 0x0046696B File Offset: 0x00464B6B
		// (set) Token: 0x0601F97F RID: 129407 RVA: 0x00466973 File Offset: 0x00464B73
		public byte NullMask { get; set; }

		// Token: 0x0601F980 RID: 129408 RVA: 0x0046697C File Offset: 0x00464B7C
		public IAiGearStrategyComponentT()
		{
			this.Disabled = false;
			this.StrategyType = null;
			this.NullMask = 0;
		}
	}
}
