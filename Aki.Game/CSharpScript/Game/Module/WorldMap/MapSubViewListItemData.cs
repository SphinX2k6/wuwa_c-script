using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036D2 RID: 14034
	[NullableContext(2)]
	[Nullable(0)]
	public class MapSubViewListItemData : IMapSubViewListItemData
	{
		// Token: 0x17004AC7 RID: 19143
		// (get) Token: 0x06024709 RID: 149257 RVA: 0x00A49CCB File Offset: 0x00A47ECB
		// (set) Token: 0x0602470A RID: 149258 RVA: 0x00A49CD3 File Offset: 0x00A47ED3
		[Nullable(1)]
		public string LeftTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004AC8 RID: 19144
		// (get) Token: 0x0602470B RID: 149259 RVA: 0x00A49CDC File Offset: 0x00A47EDC
		// (set) Token: 0x0602470C RID: 149260 RVA: 0x00A49CE4 File Offset: 0x00A47EE4
		public string LeftText { get; set; }

		// Token: 0x17004AC9 RID: 19145
		// (get) Token: 0x0602470D RID: 149261 RVA: 0x00A49CED File Offset: 0x00A47EED
		// (set) Token: 0x0602470E RID: 149262 RVA: 0x00A49CF5 File Offset: 0x00A47EF5
		public string RightTextId { get; set; }

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x0602470F RID: 149263 RVA: 0x00A49CFE File Offset: 0x00A47EFE
		// (set) Token: 0x06024710 RID: 149264 RVA: 0x00A49D06 File Offset: 0x00A47F06
		public string RightText { get; set; }

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x06024711 RID: 149265 RVA: 0x00A49D0F File Offset: 0x00A47F0F
		// (set) Token: 0x06024712 RID: 149266 RVA: 0x00A49D17 File Offset: 0x00A47F17
		public bool ShowBtnHelp { get; set; }

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x06024713 RID: 149267 RVA: 0x00A49D20 File Offset: 0x00A47F20
		// (set) Token: 0x06024714 RID: 149268 RVA: 0x00A49D28 File Offset: 0x00A47F28
		public Action OnBtnClickCb { get; set; }

		// Token: 0x17004ACD RID: 19149
		// (get) Token: 0x06024715 RID: 149269 RVA: 0x00A49D31 File Offset: 0x00A47F31
		// (set) Token: 0x06024716 RID: 149270 RVA: 0x00A49D39 File Offset: 0x00A47F39
		public bool ShowIcon { get; set; }

		// Token: 0x17004ACE RID: 19150
		// (get) Token: 0x06024717 RID: 149271 RVA: 0x00A49D42 File Offset: 0x00A47F42
		// (set) Token: 0x06024718 RID: 149272 RVA: 0x00A49D4A File Offset: 0x00A47F4A
		public bool ShowSprite { get; set; }

		// Token: 0x17004ACF RID: 19151
		// (get) Token: 0x06024719 RID: 149273 RVA: 0x00A49D53 File Offset: 0x00A47F53
		// (set) Token: 0x0602471A RID: 149274 RVA: 0x00A49D5B File Offset: 0x00A47F5B
		public bool ShowScaleIcon { get; set; }

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x0602471B RID: 149275 RVA: 0x00A49D64 File Offset: 0x00A47F64
		// (set) Token: 0x0602471C RID: 149276 RVA: 0x00A49D6C File Offset: 0x00A47F6C
		public string ScaleIconPath { get; set; }
	}
}
