using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AFF RID: 23295
	public interface ICookingData : ICookItemData
	{
		// Token: 0x17008C45 RID: 35909
		// (get) Token: 0x0603AFA8 RID: 241576
		// (set) Token: 0x0603AFA9 RID: 241577
		ESubCookDataType SubType { get; set; }

		// Token: 0x17008C46 RID: 35910
		// (get) Token: 0x0603AFAA RID: 241578
		// (set) Token: 0x0603AFAB RID: 241579
		int UniqueId { get; set; }

		// Token: 0x17008C47 RID: 35911
		// (get) Token: 0x0603AFAC RID: 241580
		// (set) Token: 0x0603AFAD RID: 241581
		int CookCount { get; set; }

		// Token: 0x17008C48 RID: 35912
		// (get) Token: 0x0603AFAE RID: 241582
		// (set) Token: 0x0603AFAF RID: 241583
		int? LastRoleId { get; set; }

		// Token: 0x17008C49 RID: 35913
		// (get) Token: 0x0603AFB0 RID: 241584
		// (set) Token: 0x0603AFB1 RID: 241585
		int IsCook { get; set; }

		// Token: 0x17008C4A RID: 35914
		// (get) Token: 0x0603AFB2 RID: 241586
		// (set) Token: 0x0603AFB3 RID: 241587
		int EffectType { get; set; }

		// Token: 0x17008C4B RID: 35915
		// (get) Token: 0x0603AFB4 RID: 241588
		// (set) Token: 0x0603AFB5 RID: 241589
		int DataId { get; set; }

		// Token: 0x17008C4C RID: 35916
		// (get) Token: 0x0603AFB6 RID: 241590
		// (set) Token: 0x0603AFB7 RID: 241591
		int LimitTotalCount { get; set; }

		// Token: 0x17008C4D RID: 35917
		// (get) Token: 0x0603AFB8 RID: 241592
		// (set) Token: 0x0603AFB9 RID: 241593
		int LimitedCount { get; set; }

		// Token: 0x17008C4E RID: 35918
		// (get) Token: 0x0603AFBA RID: 241594
		// (set) Token: 0x0603AFBB RID: 241595
		double ExistStartTime { get; set; }

		// Token: 0x17008C4F RID: 35919
		// (get) Token: 0x0603AFBC RID: 241596
		// (set) Token: 0x0603AFBD RID: 241597
		double ExistEndTime { get; set; }
	}
}
