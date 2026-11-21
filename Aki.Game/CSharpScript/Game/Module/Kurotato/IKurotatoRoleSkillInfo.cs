using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046BE RID: 18110
	public interface IKurotatoRoleSkillInfo
	{
		// Token: 0x17005B82 RID: 23426
		// (get) Token: 0x0602D862 RID: 186466
		// (set) Token: 0x0602D863 RID: 186467
		int AttrId { get; set; }

		// Token: 0x17005B83 RID: 23427
		// (get) Token: 0x0602D864 RID: 186468
		// (set) Token: 0x0602D865 RID: 186469
		int Value { get; set; }

		// Token: 0x17005B84 RID: 23428
		// (get) Token: 0x0602D866 RID: 186470
		// (set) Token: 0x0602D867 RID: 186471
		bool IsRecommend { get; set; }

		// Token: 0x17005B85 RID: 23429
		// (get) Token: 0x0602D868 RID: 186472
		// (set) Token: 0x0602D869 RID: 186473
		bool? IsAddition { get; set; }

		// Token: 0x17005B86 RID: 23430
		// (get) Token: 0x0602D86A RID: 186474
		// (set) Token: 0x0602D86B RID: 186475
		int? BaseValue { get; set; }

		// Token: 0x17005B87 RID: 23431
		// (get) Token: 0x0602D86C RID: 186476
		// (set) Token: 0x0602D86D RID: 186477
		bool? IsLocked { get; set; }

		// Token: 0x17005B88 RID: 23432
		// (get) Token: 0x0602D86E RID: 186478
		// (set) Token: 0x0602D86F RID: 186479
		int? LockedValue { get; set; }
	}
}
