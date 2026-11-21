using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x020053F9 RID: 21497
	[NullableContext(1)]
	public interface IBusinessTipsShopData
	{
		// Token: 0x17006809 RID: 26633
		// (get) Token: 0x060356EE RID: 218862
		// (set) Token: 0x060356EF RID: 218863
		int RoleId { get; set; }

		// Token: 0x1700680A RID: 26634
		// (get) Token: 0x060356F0 RID: 218864
		// (set) Token: 0x060356F1 RID: 218865
		bool IsMoreSuccessful { get; set; }

		// Token: 0x1700680B RID: 26635
		// (get) Token: 0x060356F2 RID: 218866
		// (set) Token: 0x060356F3 RID: 218867
		int TrainType { get; set; }

		// Token: 0x1700680C RID: 26636
		// (get) Token: 0x060356F4 RID: 218868
		// (set) Token: 0x060356F5 RID: 218869
		EditTeamData LastData { get; set; }
	}
}
