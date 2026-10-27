using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F3C RID: 24380
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerRecordPopupViewData : IWheelTowerRecordPopupViewData
	{
		// Token: 0x17008F64 RID: 36708
		// (get) Token: 0x0603DEEF RID: 253679 RVA: 0x00EF58B4 File Offset: 0x00EF3AB4
		// (set) Token: 0x0603DEF0 RID: 253680 RVA: 0x00EF58BC File Offset: 0x00EF3ABC
		public IWheelTowerPopupData BeforeData { get; set; } = new WheelTowerPopupData();

		// Token: 0x17008F65 RID: 36709
		// (get) Token: 0x0603DEF1 RID: 253681 RVA: 0x00EF58C5 File Offset: 0x00EF3AC5
		// (set) Token: 0x0603DEF2 RID: 253682 RVA: 0x00EF58CD File Offset: 0x00EF3ACD
		public IWheelTowerPopupData AfterData { get; set; } = new WheelTowerPopupData();

		// Token: 0x17008F66 RID: 36710
		// (get) Token: 0x0603DEF3 RID: 253683 RVA: 0x00EF58D6 File Offset: 0x00EF3AD6
		// (set) Token: 0x0603DEF4 RID: 253684 RVA: 0x00EF58DE File Offset: 0x00EF3ADE
		public bool IsEndless { get; set; }

		// Token: 0x17008F67 RID: 36711
		// (get) Token: 0x0603DEF5 RID: 253685 RVA: 0x00EF58E7 File Offset: 0x00EF3AE7
		// (set) Token: 0x0603DEF6 RID: 253686 RVA: 0x00EF58EF File Offset: 0x00EF3AEF
		public int Round { get; set; }

		// Token: 0x17008F68 RID: 36712
		// (get) Token: 0x0603DEF7 RID: 253687 RVA: 0x00EF58F8 File Offset: 0x00EF3AF8
		// (set) Token: 0x0603DEF8 RID: 253688 RVA: 0x00EF5900 File Offset: 0x00EF3B00
		[Nullable(2)]
		public Action OnClickConfirm { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008F69 RID: 36713
		// (get) Token: 0x0603DEF9 RID: 253689 RVA: 0x00EF5909 File Offset: 0x00EF3B09
		// (set) Token: 0x0603DEFA RID: 253690 RVA: 0x00EF5911 File Offset: 0x00EF3B11
		[Nullable(2)]
		public Action OnClickCancel { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
