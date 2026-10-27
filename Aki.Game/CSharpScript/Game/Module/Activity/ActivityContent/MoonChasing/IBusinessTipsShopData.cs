using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x0200647B RID: 25723
	[NullableContext(1)]
	public interface IBusinessTipsShopData
	{
		// Token: 0x170094A7 RID: 38055
		// (get) Token: 0x06040A2A RID: 264746
		// (set) Token: 0x06040A2B RID: 264747
		int RoleId { get; set; }

		// Token: 0x170094A8 RID: 38056
		// (get) Token: 0x06040A2C RID: 264748
		// (set) Token: 0x06040A2D RID: 264749
		bool IsMoreSuccessful { get; set; }

		// Token: 0x170094A9 RID: 38057
		// (get) Token: 0x06040A2E RID: 264750
		// (set) Token: 0x06040A2F RID: 264751
		int TrainType { get; set; }

		// Token: 0x170094AA RID: 38058
		// (get) Token: 0x06040A30 RID: 264752
		// (set) Token: 0x06040A31 RID: 264753
		EditTeamData LastData { get; set; }
	}
}
