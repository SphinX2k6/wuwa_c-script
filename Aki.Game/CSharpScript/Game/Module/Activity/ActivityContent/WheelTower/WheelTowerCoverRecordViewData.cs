using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F38 RID: 24376
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerCoverRecordViewData : IWheelTowerCoverRecordViewData
	{
		// Token: 0x17008F4E RID: 36686
		// (get) Token: 0x0603DEC1 RID: 253633 RVA: 0x00EF57C8 File Offset: 0x00EF39C8
		// (set) Token: 0x0603DEC2 RID: 253634 RVA: 0x00EF57D0 File Offset: 0x00EF39D0
		public IWheelTowerCoverRecordData BeforeData { get; set; } = new WheelTowerCoverRecordData();

		// Token: 0x17008F4F RID: 36687
		// (get) Token: 0x0603DEC3 RID: 253635 RVA: 0x00EF57D9 File Offset: 0x00EF39D9
		// (set) Token: 0x0603DEC4 RID: 253636 RVA: 0x00EF57E1 File Offset: 0x00EF39E1
		public IWheelTowerCoverRecordData AfterData { get; set; } = new WheelTowerCoverRecordData();

		// Token: 0x17008F50 RID: 36688
		// (get) Token: 0x0603DEC5 RID: 253637 RVA: 0x00EF57EA File Offset: 0x00EF39EA
		// (set) Token: 0x0603DEC6 RID: 253638 RVA: 0x00EF57F2 File Offset: 0x00EF39F2
		public int TeamNum { get; set; }

		// Token: 0x17008F51 RID: 36689
		// (get) Token: 0x0603DEC7 RID: 253639 RVA: 0x00EF57FB File Offset: 0x00EF39FB
		// (set) Token: 0x0603DEC8 RID: 253640 RVA: 0x00EF5803 File Offset: 0x00EF3A03
		public bool IsEndless { get; set; }

		// Token: 0x17008F52 RID: 36690
		// (get) Token: 0x0603DEC9 RID: 253641 RVA: 0x00EF580C File Offset: 0x00EF3A0C
		// (set) Token: 0x0603DECA RID: 253642 RVA: 0x00EF5814 File Offset: 0x00EF3A14
		[Nullable(2)]
		public Action OnClickConfirm { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008F53 RID: 36691
		// (get) Token: 0x0603DECB RID: 253643 RVA: 0x00EF581D File Offset: 0x00EF3A1D
		// (set) Token: 0x0603DECC RID: 253644 RVA: 0x00EF5825 File Offset: 0x00EF3A25
		[Nullable(2)]
		public Action OnClickCancel { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
