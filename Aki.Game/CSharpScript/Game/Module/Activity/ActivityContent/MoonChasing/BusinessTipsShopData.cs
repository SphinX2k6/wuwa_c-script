using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x0200647C RID: 25724
	[NullableContext(1)]
	[Nullable(0)]
	public class BusinessTipsShopData : IBusinessTipsShopData
	{
		// Token: 0x170094AB RID: 38059
		// (get) Token: 0x06040A32 RID: 264754 RVA: 0x00FA5732 File Offset: 0x00FA3932
		// (set) Token: 0x06040A33 RID: 264755 RVA: 0x00FA573A File Offset: 0x00FA393A
		public int RoleId { get; set; }

		// Token: 0x170094AC RID: 38060
		// (get) Token: 0x06040A34 RID: 264756 RVA: 0x00FA5743 File Offset: 0x00FA3943
		// (set) Token: 0x06040A35 RID: 264757 RVA: 0x00FA574B File Offset: 0x00FA394B
		public bool IsMoreSuccessful { get; set; }

		// Token: 0x170094AD RID: 38061
		// (get) Token: 0x06040A36 RID: 264758 RVA: 0x00FA5754 File Offset: 0x00FA3954
		// (set) Token: 0x06040A37 RID: 264759 RVA: 0x00FA575C File Offset: 0x00FA395C
		public int TrainType { get; set; }

		// Token: 0x170094AE RID: 38062
		// (get) Token: 0x06040A38 RID: 264760 RVA: 0x00FA5765 File Offset: 0x00FA3965
		// (set) Token: 0x06040A39 RID: 264761 RVA: 0x00FA576D File Offset: 0x00FA396D
		public EditTeamData LastData { get; set; }
	}
}
