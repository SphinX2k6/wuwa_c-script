using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AFE RID: 23294
	public interface ICookItemData
	{
		// Token: 0x17008C40 RID: 35904
		// (get) Token: 0x0603AF9E RID: 241566
		// (set) Token: 0x0603AF9F RID: 241567
		ECookListType MainType { get; set; }

		// Token: 0x17008C41 RID: 35905
		// (get) Token: 0x0603AFA0 RID: 241568
		// (set) Token: 0x0603AFA1 RID: 241569
		int ItemId { get; set; }

		// Token: 0x17008C42 RID: 35906
		// (get) Token: 0x0603AFA2 RID: 241570
		// (set) Token: 0x0603AFA3 RID: 241571
		bool IsNew { get; set; }

		// Token: 0x17008C43 RID: 35907
		// (get) Token: 0x0603AFA4 RID: 241572
		// (set) Token: 0x0603AFA5 RID: 241573
		int Quality { get; set; }

		// Token: 0x17008C44 RID: 35908
		// (get) Token: 0x0603AFA6 RID: 241574
		// (set) Token: 0x0603AFA7 RID: 241575
		bool IsUnLock { get; set; }
	}
}
