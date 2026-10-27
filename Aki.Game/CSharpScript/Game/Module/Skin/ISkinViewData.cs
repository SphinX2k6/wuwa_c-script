using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02004BE0 RID: 19424
	public interface ISkinViewData
	{
		// Token: 0x17007C4F RID: 31823
		// (get) Token: 0x06032377 RID: 205687
		// (set) Token: 0x06032378 RID: 205688
		int RoleId { get; set; }

		// Token: 0x17007C50 RID: 31824
		// (get) Token: 0x06032379 RID: 205689
		// (set) Token: 0x0603237A RID: 205690
		int WeaponId { get; set; }

		// Token: 0x17007C51 RID: 31825
		// (get) Token: 0x0603237B RID: 205691
		// (set) Token: 0x0603237C RID: 205692
		EUiTabViewName TabViewName { get; set; }

		// Token: 0x17007C52 RID: 31826
		// (get) Token: 0x0603237D RID: 205693
		// (set) Token: 0x0603237E RID: 205694
		bool NeedLoadRole { get; set; }

		// Token: 0x17007C53 RID: 31827
		// (get) Token: 0x0603237F RID: 205695
		// (set) Token: 0x06032380 RID: 205696
		int? FlySkinId { get; set; }

		// Token: 0x17007C54 RID: 31828
		// (get) Token: 0x06032381 RID: 205697
		// (set) Token: 0x06032382 RID: 205698
		EFlySkinTab? FlySkinTab { get; set; }

		// Token: 0x17007C55 RID: 31829
		// (get) Token: 0x06032383 RID: 205699
		// (set) Token: 0x06032384 RID: 205700
		int? CalabashSkinId { get; set; }

		// Token: 0x17007C56 RID: 31830
		// (get) Token: 0x06032385 RID: 205701
		// (set) Token: 0x06032386 RID: 205702
		int? SelectRoleSkinId { get; set; }

		// Token: 0x17007C57 RID: 31831
		// (get) Token: 0x06032387 RID: 205703
		// (set) Token: 0x06032388 RID: 205704
		int? OrnamentSkinId { get; set; }

		// Token: 0x17007C58 RID: 31832
		// (get) Token: 0x06032389 RID: 205705
		// (set) Token: 0x0603238A RID: 205706
		int? OrnamentId { get; set; }

		// Token: 0x17007C59 RID: 31833
		// (get) Token: 0x0603238B RID: 205707
		// (set) Token: 0x0603238C RID: 205708
		bool? SkipOrnamentCameraBlend { get; set; }
	}
}
