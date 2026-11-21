using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005105 RID: 20741
	public class RoverlikeReinforcementItemData : IRoverlikeReinforcementItemData
	{
		// Token: 0x17006533 RID: 25907
		// (get) Token: 0x06033E47 RID: 212551 RVA: 0x00E85FDF File Offset: 0x00E841DF
		// (set) Token: 0x06033E48 RID: 212552 RVA: 0x00E85FE7 File Offset: 0x00E841E7
		public int ConfigId { get; set; }

		// Token: 0x17006534 RID: 25908
		// (get) Token: 0x06033E49 RID: 212553 RVA: 0x00E85FF0 File Offset: 0x00E841F0
		// (set) Token: 0x06033E4A RID: 212554 RVA: 0x00E85FF8 File Offset: 0x00E841F8
		public int? IncId { get; set; }

		// Token: 0x17006535 RID: 25909
		// (get) Token: 0x06033E4B RID: 212555 RVA: 0x00E86001 File Offset: 0x00E84201
		// (set) Token: 0x06033E4C RID: 212556 RVA: 0x00E86009 File Offset: 0x00E84209
		public bool? AllowToggleInteract { get; set; }
	}
}
