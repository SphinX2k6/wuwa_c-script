using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B8D RID: 15245
	public class SkinViewData : ISkinViewData
	{
		// Token: 0x17005004 RID: 20484
		// (get) Token: 0x0602711E RID: 160030 RVA: 0x00AEF293 File Offset: 0x00AED493
		// (set) Token: 0x0602711F RID: 160031 RVA: 0x00AEF29B File Offset: 0x00AED49B
		public int RoleId { get; set; }

		// Token: 0x17005005 RID: 20485
		// (get) Token: 0x06027120 RID: 160032 RVA: 0x00AEF2A4 File Offset: 0x00AED4A4
		// (set) Token: 0x06027121 RID: 160033 RVA: 0x00AEF2AC File Offset: 0x00AED4AC
		public int WeaponId { get; set; }

		// Token: 0x17005006 RID: 20486
		// (get) Token: 0x06027122 RID: 160034 RVA: 0x00AEF2B5 File Offset: 0x00AED4B5
		// (set) Token: 0x06027123 RID: 160035 RVA: 0x00AEF2BD File Offset: 0x00AED4BD
		public EUiTabViewName TabViewName { get; set; }

		// Token: 0x17005007 RID: 20487
		// (get) Token: 0x06027124 RID: 160036 RVA: 0x00AEF2C6 File Offset: 0x00AED4C6
		// (set) Token: 0x06027125 RID: 160037 RVA: 0x00AEF2CE File Offset: 0x00AED4CE
		public bool NeedLoadRole { get; set; }

		// Token: 0x17005008 RID: 20488
		// (get) Token: 0x06027126 RID: 160038 RVA: 0x00AEF2D7 File Offset: 0x00AED4D7
		// (set) Token: 0x06027127 RID: 160039 RVA: 0x00AEF2DF File Offset: 0x00AED4DF
		public int? FlySkinId { get; set; }

		// Token: 0x17005009 RID: 20489
		// (get) Token: 0x06027128 RID: 160040 RVA: 0x00AEF2E8 File Offset: 0x00AED4E8
		// (set) Token: 0x06027129 RID: 160041 RVA: 0x00AEF2F0 File Offset: 0x00AED4F0
		public EFlySkinTab? FlySkinTab { get; set; }

		// Token: 0x1700500A RID: 20490
		// (get) Token: 0x0602712A RID: 160042 RVA: 0x00AEF2F9 File Offset: 0x00AED4F9
		// (set) Token: 0x0602712B RID: 160043 RVA: 0x00AEF301 File Offset: 0x00AED501
		public int? CalabashSkinId { get; set; }

		// Token: 0x1700500B RID: 20491
		// (get) Token: 0x0602712C RID: 160044 RVA: 0x00AEF30A File Offset: 0x00AED50A
		// (set) Token: 0x0602712D RID: 160045 RVA: 0x00AEF312 File Offset: 0x00AED512
		public int? SelectRoleSkinId { get; set; }

		// Token: 0x1700500C RID: 20492
		// (get) Token: 0x0602712E RID: 160046 RVA: 0x00AEF31B File Offset: 0x00AED51B
		// (set) Token: 0x0602712F RID: 160047 RVA: 0x00AEF323 File Offset: 0x00AED523
		public int? OrnamentSkinId { get; set; }

		// Token: 0x1700500D RID: 20493
		// (get) Token: 0x06027130 RID: 160048 RVA: 0x00AEF32C File Offset: 0x00AED52C
		// (set) Token: 0x06027131 RID: 160049 RVA: 0x00AEF334 File Offset: 0x00AED534
		public int? OrnamentId { get; set; }

		// Token: 0x1700500E RID: 20494
		// (get) Token: 0x06027132 RID: 160050 RVA: 0x00AEF33D File Offset: 0x00AED53D
		// (set) Token: 0x06027133 RID: 160051 RVA: 0x00AEF345 File Offset: 0x00AED545
		public bool? SkipOrnamentCameraBlend { get; set; }
	}
}
