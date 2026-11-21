using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop.MotorSkinTab
{
	// Token: 0x0200433E RID: 17214
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardItemGridData : IRewardItemGridData
	{
		// Token: 0x1700570F RID: 22287
		// (get) Token: 0x0602B78C RID: 178060 RVA: 0x00C37C95 File Offset: 0x00C35E95
		// (set) Token: 0x0602B78D RID: 178061 RVA: 0x00C37C9D File Offset: 0x00C35E9D
		public string IconPath { get; set; } = string.Empty;

		// Token: 0x17005710 RID: 22288
		// (get) Token: 0x0602B78E RID: 178062 RVA: 0x00C37CA6 File Offset: 0x00C35EA6
		// (set) Token: 0x0602B78F RID: 178063 RVA: 0x00C37CAE File Offset: 0x00C35EAE
		public int Count { get; set; }
	}
}
