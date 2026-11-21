using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036D1 RID: 14033
	[NullableContext(2)]
	public interface IMapSubViewListItemData
	{
		// Token: 0x17004ABD RID: 19133
		// (get) Token: 0x060246F5 RID: 149237
		// (set) Token: 0x060246F6 RID: 149238
		[Nullable(1)]
		string LeftTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004ABE RID: 19134
		// (get) Token: 0x060246F7 RID: 149239
		// (set) Token: 0x060246F8 RID: 149240
		string LeftText { get; set; }

		// Token: 0x17004ABF RID: 19135
		// (get) Token: 0x060246F9 RID: 149241
		// (set) Token: 0x060246FA RID: 149242
		string RightTextId { get; set; }

		// Token: 0x17004AC0 RID: 19136
		// (get) Token: 0x060246FB RID: 149243
		// (set) Token: 0x060246FC RID: 149244
		string RightText { get; set; }

		// Token: 0x17004AC1 RID: 19137
		// (get) Token: 0x060246FD RID: 149245
		// (set) Token: 0x060246FE RID: 149246
		bool ShowBtnHelp { get; set; }

		// Token: 0x17004AC2 RID: 19138
		// (get) Token: 0x060246FF RID: 149247
		// (set) Token: 0x06024700 RID: 149248
		Action OnBtnClickCb { get; set; }

		// Token: 0x17004AC3 RID: 19139
		// (get) Token: 0x06024701 RID: 149249
		// (set) Token: 0x06024702 RID: 149250
		bool ShowIcon { get; set; }

		// Token: 0x17004AC4 RID: 19140
		// (get) Token: 0x06024703 RID: 149251
		// (set) Token: 0x06024704 RID: 149252
		bool ShowSprite { get; set; }

		// Token: 0x17004AC5 RID: 19141
		// (get) Token: 0x06024705 RID: 149253
		// (set) Token: 0x06024706 RID: 149254
		bool ShowScaleIcon { get; set; }

		// Token: 0x17004AC6 RID: 19142
		// (get) Token: 0x06024707 RID: 149255
		// (set) Token: 0x06024708 RID: 149256
		string ScaleIconPath { get; set; }
	}
}
