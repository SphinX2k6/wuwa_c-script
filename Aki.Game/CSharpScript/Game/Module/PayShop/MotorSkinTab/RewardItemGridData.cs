using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop.MotorSkinTab
{
	// Token: 0x0200535B RID: 21339
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardItemGridData : IRewardItemGridData
	{
		// Token: 0x17008343 RID: 33603
		// (get) Token: 0x06036846 RID: 223302 RVA: 0x00CE8E0D File Offset: 0x00CE700D
		// (set) Token: 0x06036847 RID: 223303 RVA: 0x00CE8E15 File Offset: 0x00CE7015
		public string IconPath { get; set; } = string.Empty;

		// Token: 0x17008344 RID: 33604
		// (get) Token: 0x06036848 RID: 223304 RVA: 0x00CE8E1E File Offset: 0x00CE701E
		// (set) Token: 0x06036849 RID: 223305 RVA: 0x00CE8E26 File Offset: 0x00CE7026
		public int Count { get; set; }
	}
}
