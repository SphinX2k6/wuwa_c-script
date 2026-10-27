using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200501F RID: 20511
	public class IConnectorRangeT
	{
		// Token: 0x170094BD RID: 38077
		// (get) Token: 0x06020D55 RID: 134485 RVA: 0x00490A7F File Offset: 0x0048EC7F
		// (set) Token: 0x06020D56 RID: 134486 RVA: 0x00490A87 File Offset: 0x0048EC87
		public EConnectorLogicType Type { get; set; }

		// Token: 0x170094BE RID: 38078
		// (get) Token: 0x06020D57 RID: 134487 RVA: 0x00490A90 File Offset: 0x0048EC90
		// (set) Token: 0x06020D58 RID: 134488 RVA: 0x00490A98 File Offset: 0x0048EC98
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x170094BF RID: 38079
		// (get) Token: 0x06020D59 RID: 134489 RVA: 0x00490AA1 File Offset: 0x0048ECA1
		// (set) Token: 0x06020D5A RID: 134490 RVA: 0x00490AA9 File Offset: 0x0048ECA9
		public string ActiveState { get; set; }

		// Token: 0x170094C0 RID: 38080
		// (get) Token: 0x06020D5B RID: 134491 RVA: 0x00490AB2 File Offset: 0x0048ECB2
		// (set) Token: 0x06020D5C RID: 134492 RVA: 0x00490ABA File Offset: 0x0048ECBA
		public int EnterRange { get; set; }

		// Token: 0x170094C1 RID: 38081
		// (get) Token: 0x06020D5D RID: 134493 RVA: 0x00490AC3 File Offset: 0x0048ECC3
		// (set) Token: 0x06020D5E RID: 134494 RVA: 0x00490ACB File Offset: 0x0048ECCB
		public int LeaveRange { get; set; }

		// Token: 0x170094C2 RID: 38082
		// (get) Token: 0x06020D5F RID: 134495 RVA: 0x00490AD4 File Offset: 0x0048ECD4
		// (set) Token: 0x06020D60 RID: 134496 RVA: 0x00490ADC File Offset: 0x0048ECDC
		public List<IDynamicEntityMatchT> MatchConditions { get; set; }

		// Token: 0x170094C3 RID: 38083
		// (get) Token: 0x06020D61 RID: 134497 RVA: 0x00490AE5 File Offset: 0x0048ECE5
		// (set) Token: 0x06020D62 RID: 134498 RVA: 0x00490AED File Offset: 0x0048ECED
		public List<IDynamicEntityMatchT> KeepConditions { get; set; }

		// Token: 0x170094C4 RID: 38084
		// (get) Token: 0x06020D63 RID: 134499 RVA: 0x00490AF6 File Offset: 0x0048ECF6
		// (set) Token: 0x06020D64 RID: 134500 RVA: 0x00490AFE File Offset: 0x0048ECFE
		public string ConnectedState { get; set; }

		// Token: 0x170094C5 RID: 38085
		// (get) Token: 0x06020D65 RID: 134501 RVA: 0x00490B07 File Offset: 0x0048ED07
		// (set) Token: 0x06020D66 RID: 134502 RVA: 0x00490B0F File Offset: 0x0048ED0F
		public string DisconnectedState { get; set; }

		// Token: 0x170094C6 RID: 38086
		// (get) Token: 0x06020D67 RID: 134503 RVA: 0x00490B18 File Offset: 0x0048ED18
		// (set) Token: 0x06020D68 RID: 134504 RVA: 0x00490B20 File Offset: 0x0048ED20
		public byte NullMask { get; set; }

		// Token: 0x06020D69 RID: 134505 RVA: 0x00490B2C File Offset: 0x0048ED2C
		public IConnectorRangeT()
		{
			this.Type = EConnectorLogicType.Range;
			this.EffectConfig = null;
			this.ActiveState = null;
			this.EnterRange = 0;
			this.LeaveRange = 0;
			this.MatchConditions = null;
			this.KeepConditions = null;
			this.ConnectedState = null;
			this.DisconnectedState = null;
			this.NullMask = 0;
		}
	}
}
