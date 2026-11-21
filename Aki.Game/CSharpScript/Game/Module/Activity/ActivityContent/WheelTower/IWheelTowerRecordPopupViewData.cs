using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F22 RID: 20258
	[NullableContext(1)]
	public interface IWheelTowerRecordPopupViewData
	{
		// Token: 0x17006330 RID: 25392
		// (get) Token: 0x06032E7E RID: 208510
		// (set) Token: 0x06032E7F RID: 208511
		IWheelTowerPopupData BeforeData { get; set; }

		// Token: 0x17006331 RID: 25393
		// (get) Token: 0x06032E80 RID: 208512
		// (set) Token: 0x06032E81 RID: 208513
		IWheelTowerPopupData AfterData { get; set; }

		// Token: 0x17006332 RID: 25394
		// (get) Token: 0x06032E82 RID: 208514
		// (set) Token: 0x06032E83 RID: 208515
		bool IsEndless { get; set; }

		// Token: 0x17006333 RID: 25395
		// (get) Token: 0x06032E84 RID: 208516
		// (set) Token: 0x06032E85 RID: 208517
		int Round { get; set; }

		// Token: 0x17006334 RID: 25396
		// (get) Token: 0x06032E86 RID: 208518
		// (set) Token: 0x06032E87 RID: 208519
		[Nullable(2)]
		Action OnClickConfirm { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006335 RID: 25397
		// (get) Token: 0x06032E88 RID: 208520
		// (set) Token: 0x06032E89 RID: 208521
		[Nullable(2)]
		Action OnClickCancel { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
