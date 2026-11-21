using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005106 RID: 20742
	public interface IRoverlikePropItemData
	{
		// Token: 0x17006536 RID: 25910
		// (get) Token: 0x06033E4E RID: 212558
		// (set) Token: 0x06033E4F RID: 212559
		int ConfigId { get; set; }

		// Token: 0x17006537 RID: 25911
		// (get) Token: 0x06033E50 RID: 212560
		// (set) Token: 0x06033E51 RID: 212561
		bool IsInGame { get; set; }

		// Token: 0x17006538 RID: 25912
		// (get) Token: 0x06033E52 RID: 212562
		// (set) Token: 0x06033E53 RID: 212563
		int? IncId { get; set; }
	}
}
