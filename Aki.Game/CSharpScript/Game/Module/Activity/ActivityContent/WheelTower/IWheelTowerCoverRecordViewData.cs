using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F1E RID: 20254
	[NullableContext(1)]
	public interface IWheelTowerCoverRecordViewData
	{
		// Token: 0x1700631A RID: 25370
		// (get) Token: 0x06032E50 RID: 208464
		// (set) Token: 0x06032E51 RID: 208465
		IWheelTowerCoverRecordData BeforeData { get; set; }

		// Token: 0x1700631B RID: 25371
		// (get) Token: 0x06032E52 RID: 208466
		// (set) Token: 0x06032E53 RID: 208467
		IWheelTowerCoverRecordData AfterData { get; set; }

		// Token: 0x1700631C RID: 25372
		// (get) Token: 0x06032E54 RID: 208468
		// (set) Token: 0x06032E55 RID: 208469
		int TeamNum { get; set; }

		// Token: 0x1700631D RID: 25373
		// (get) Token: 0x06032E56 RID: 208470
		// (set) Token: 0x06032E57 RID: 208471
		bool IsEndless { get; set; }

		// Token: 0x1700631E RID: 25374
		// (get) Token: 0x06032E58 RID: 208472
		// (set) Token: 0x06032E59 RID: 208473
		[Nullable(2)]
		Action OnClickConfirm { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700631F RID: 25375
		// (get) Token: 0x06032E5A RID: 208474
		// (set) Token: 0x06032E5B RID: 208475
		[Nullable(2)]
		Action OnClickCancel { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
