using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F3B RID: 24379
	[NullableContext(1)]
	public interface IWheelTowerRecordPopupViewData
	{
		// Token: 0x17008F5E RID: 36702
		// (get) Token: 0x0603DEE3 RID: 253667
		// (set) Token: 0x0603DEE4 RID: 253668
		IWheelTowerPopupData BeforeData { get; set; }

		// Token: 0x17008F5F RID: 36703
		// (get) Token: 0x0603DEE5 RID: 253669
		// (set) Token: 0x0603DEE6 RID: 253670
		IWheelTowerPopupData AfterData { get; set; }

		// Token: 0x17008F60 RID: 36704
		// (get) Token: 0x0603DEE7 RID: 253671
		// (set) Token: 0x0603DEE8 RID: 253672
		bool IsEndless { get; set; }

		// Token: 0x17008F61 RID: 36705
		// (get) Token: 0x0603DEE9 RID: 253673
		// (set) Token: 0x0603DEEA RID: 253674
		int Round { get; set; }

		// Token: 0x17008F62 RID: 36706
		// (get) Token: 0x0603DEEB RID: 253675
		// (set) Token: 0x0603DEEC RID: 253676
		[Nullable(2)]
		Action OnClickConfirm { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008F63 RID: 36707
		// (get) Token: 0x0603DEED RID: 253677
		// (set) Token: 0x0603DEEE RID: 253678
		[Nullable(2)]
		Action OnClickCancel { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
