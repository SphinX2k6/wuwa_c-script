using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F27 RID: 20263
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSettlementViewButtonData : IWheelTowerSettlementViewButtonData
	{
		// Token: 0x17006351 RID: 25425
		// (get) Token: 0x06032EC2 RID: 208578 RVA: 0x00E47705 File Offset: 0x00E45905
		// (set) Token: 0x06032EC3 RID: 208579 RVA: 0x00E4770D File Offset: 0x00E4590D
		public string Name { get; set; } = string.Empty;

		// Token: 0x17006352 RID: 25426
		// (get) Token: 0x06032EC4 RID: 208580 RVA: 0x00E47716 File Offset: 0x00E45916
		// (set) Token: 0x06032EC5 RID: 208581 RVA: 0x00E4771E File Offset: 0x00E4591E
		public Action OnClick { get; set; } = delegate()
		{
		};

		// Token: 0x17006353 RID: 25427
		// (get) Token: 0x06032EC6 RID: 208582 RVA: 0x00E47727 File Offset: 0x00E45927
		// (set) Token: 0x06032EC7 RID: 208583 RVA: 0x00E4772F File Offset: 0x00E4592F
		public EConfirmBoxConfigId? ConfirmBoxId { get; set; }
	}
}
