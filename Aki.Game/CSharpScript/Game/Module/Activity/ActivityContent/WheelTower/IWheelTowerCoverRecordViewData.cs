using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F37 RID: 24375
	[NullableContext(1)]
	public interface IWheelTowerCoverRecordViewData
	{
		// Token: 0x17008F48 RID: 36680
		// (get) Token: 0x0603DEB5 RID: 253621
		// (set) Token: 0x0603DEB6 RID: 253622
		IWheelTowerCoverRecordData BeforeData { get; set; }

		// Token: 0x17008F49 RID: 36681
		// (get) Token: 0x0603DEB7 RID: 253623
		// (set) Token: 0x0603DEB8 RID: 253624
		IWheelTowerCoverRecordData AfterData { get; set; }

		// Token: 0x17008F4A RID: 36682
		// (get) Token: 0x0603DEB9 RID: 253625
		// (set) Token: 0x0603DEBA RID: 253626
		int TeamNum { get; set; }

		// Token: 0x17008F4B RID: 36683
		// (get) Token: 0x0603DEBB RID: 253627
		// (set) Token: 0x0603DEBC RID: 253628
		bool IsEndless { get; set; }

		// Token: 0x17008F4C RID: 36684
		// (get) Token: 0x0603DEBD RID: 253629
		// (set) Token: 0x0603DEBE RID: 253630
		[Nullable(2)]
		Action OnClickConfirm { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008F4D RID: 36685
		// (get) Token: 0x0603DEBF RID: 253631
		// (set) Token: 0x0603DEC0 RID: 253632
		[Nullable(2)]
		Action OnClickCancel { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
