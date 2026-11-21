using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005104 RID: 20740
	public interface IRoverlikeReinforcementItemData
	{
		// Token: 0x17006530 RID: 25904
		// (get) Token: 0x06033E41 RID: 212545
		// (set) Token: 0x06033E42 RID: 212546
		int ConfigId { get; set; }

		// Token: 0x17006531 RID: 25905
		// (get) Token: 0x06033E43 RID: 212547
		// (set) Token: 0x06033E44 RID: 212548
		int? IncId { get; set; }

		// Token: 0x17006532 RID: 25906
		// (get) Token: 0x06033E45 RID: 212549
		// (set) Token: 0x06033E46 RID: 212550
		bool? AllowToggleInteract { get; set; }
	}
}
