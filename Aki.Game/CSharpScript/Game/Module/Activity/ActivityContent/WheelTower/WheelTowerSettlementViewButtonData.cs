using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F40 RID: 24384
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSettlementViewButtonData : IWheelTowerSettlementViewButtonData
	{
		// Token: 0x17008F7F RID: 36735
		// (get) Token: 0x0603DF27 RID: 253735 RVA: 0x00EF59D9 File Offset: 0x00EF3BD9
		// (set) Token: 0x0603DF28 RID: 253736 RVA: 0x00EF59E1 File Offset: 0x00EF3BE1
		public string Name { get; set; } = string.Empty;

		// Token: 0x17008F80 RID: 36736
		// (get) Token: 0x0603DF29 RID: 253737 RVA: 0x00EF59EA File Offset: 0x00EF3BEA
		// (set) Token: 0x0603DF2A RID: 253738 RVA: 0x00EF59F2 File Offset: 0x00EF3BF2
		public Action OnClick { get; set; } = delegate()
		{
		};

		// Token: 0x17008F81 RID: 36737
		// (get) Token: 0x0603DF2B RID: 253739 RVA: 0x00EF59FB File Offset: 0x00EF3BFB
		// (set) Token: 0x0603DF2C RID: 253740 RVA: 0x00EF5A03 File Offset: 0x00EF3C03
		public EConfirmBoxConfigId? ConfirmBoxId { get; set; }
	}
}
