using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006186 RID: 24966
	public interface IRoverlikeReinforcementItemData
	{
		// Token: 0x170091CE RID: 37326
		// (get) Token: 0x0603F181 RID: 258433
		// (set) Token: 0x0603F182 RID: 258434
		int ConfigId { get; set; }

		// Token: 0x170091CF RID: 37327
		// (get) Token: 0x0603F183 RID: 258435
		// (set) Token: 0x0603F184 RID: 258436
		int? IncId { get; set; }

		// Token: 0x170091D0 RID: 37328
		// (get) Token: 0x0603F185 RID: 258437
		// (set) Token: 0x0603F186 RID: 258438
		bool? AllowToggleInteract { get; set; }
	}
}
