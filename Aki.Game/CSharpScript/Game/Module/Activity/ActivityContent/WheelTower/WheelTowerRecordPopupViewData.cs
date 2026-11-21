using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F23 RID: 20259
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerRecordPopupViewData : IWheelTowerRecordPopupViewData
	{
		// Token: 0x17006336 RID: 25398
		// (get) Token: 0x06032E8A RID: 208522 RVA: 0x00E475E0 File Offset: 0x00E457E0
		// (set) Token: 0x06032E8B RID: 208523 RVA: 0x00E475E8 File Offset: 0x00E457E8
		public IWheelTowerPopupData BeforeData { get; set; } = new WheelTowerPopupData();

		// Token: 0x17006337 RID: 25399
		// (get) Token: 0x06032E8C RID: 208524 RVA: 0x00E475F1 File Offset: 0x00E457F1
		// (set) Token: 0x06032E8D RID: 208525 RVA: 0x00E475F9 File Offset: 0x00E457F9
		public IWheelTowerPopupData AfterData { get; set; } = new WheelTowerPopupData();

		// Token: 0x17006338 RID: 25400
		// (get) Token: 0x06032E8E RID: 208526 RVA: 0x00E47602 File Offset: 0x00E45802
		// (set) Token: 0x06032E8F RID: 208527 RVA: 0x00E4760A File Offset: 0x00E4580A
		public bool IsEndless { get; set; }

		// Token: 0x17006339 RID: 25401
		// (get) Token: 0x06032E90 RID: 208528 RVA: 0x00E47613 File Offset: 0x00E45813
		// (set) Token: 0x06032E91 RID: 208529 RVA: 0x00E4761B File Offset: 0x00E4581B
		public int Round { get; set; }

		// Token: 0x1700633A RID: 25402
		// (get) Token: 0x06032E92 RID: 208530 RVA: 0x00E47624 File Offset: 0x00E45824
		// (set) Token: 0x06032E93 RID: 208531 RVA: 0x00E4762C File Offset: 0x00E4582C
		[Nullable(2)]
		public Action OnClickConfirm { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700633B RID: 25403
		// (get) Token: 0x06032E94 RID: 208532 RVA: 0x00E47635 File Offset: 0x00E45835
		// (set) Token: 0x06032E95 RID: 208533 RVA: 0x00E4763D File Offset: 0x00E4583D
		[Nullable(2)]
		public Action OnClickCancel { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
