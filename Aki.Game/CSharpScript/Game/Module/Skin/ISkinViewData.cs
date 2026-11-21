using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B8C RID: 15244
	public interface ISkinViewData
	{
		// Token: 0x17004FF9 RID: 20473
		// (get) Token: 0x06027108 RID: 160008
		// (set) Token: 0x06027109 RID: 160009
		int RoleId { get; set; }

		// Token: 0x17004FFA RID: 20474
		// (get) Token: 0x0602710A RID: 160010
		// (set) Token: 0x0602710B RID: 160011
		int WeaponId { get; set; }

		// Token: 0x17004FFB RID: 20475
		// (get) Token: 0x0602710C RID: 160012
		// (set) Token: 0x0602710D RID: 160013
		EUiTabViewName TabViewName { get; set; }

		// Token: 0x17004FFC RID: 20476
		// (get) Token: 0x0602710E RID: 160014
		// (set) Token: 0x0602710F RID: 160015
		bool NeedLoadRole { get; set; }

		// Token: 0x17004FFD RID: 20477
		// (get) Token: 0x06027110 RID: 160016
		// (set) Token: 0x06027111 RID: 160017
		int? FlySkinId { get; set; }

		// Token: 0x17004FFE RID: 20478
		// (get) Token: 0x06027112 RID: 160018
		// (set) Token: 0x06027113 RID: 160019
		EFlySkinTab? FlySkinTab { get; set; }

		// Token: 0x17004FFF RID: 20479
		// (get) Token: 0x06027114 RID: 160020
		// (set) Token: 0x06027115 RID: 160021
		int? CalabashSkinId { get; set; }

		// Token: 0x17005000 RID: 20480
		// (get) Token: 0x06027116 RID: 160022
		// (set) Token: 0x06027117 RID: 160023
		int? SelectRoleSkinId { get; set; }

		// Token: 0x17005001 RID: 20481
		// (get) Token: 0x06027118 RID: 160024
		// (set) Token: 0x06027119 RID: 160025
		int? OrnamentSkinId { get; set; }

		// Token: 0x17005002 RID: 20482
		// (get) Token: 0x0602711A RID: 160026
		// (set) Token: 0x0602711B RID: 160027
		int? OrnamentId { get; set; }

		// Token: 0x17005003 RID: 20483
		// (get) Token: 0x0602711C RID: 160028
		// (set) Token: 0x0602711D RID: 160029
		bool? SkipOrnamentCameraBlend { get; set; }
	}
}
