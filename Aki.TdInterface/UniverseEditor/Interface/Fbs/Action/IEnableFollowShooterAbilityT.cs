using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCF RID: 27855
	public class IEnableFollowShooterAbilityT
	{
		// Token: 0x1700CC4F RID: 52303
		// (get) Token: 0x06030034 RID: 196660 RVA: 0x006889C9 File Offset: 0x00686BC9
		// (set) Token: 0x06030035 RID: 196661 RVA: 0x006889D1 File Offset: 0x00686BD1
		public bool Enable { get; set; }

		// Token: 0x1700CC50 RID: 52304
		// (get) Token: 0x06030036 RID: 196662 RVA: 0x006889DA File Offset: 0x00686BDA
		// (set) Token: 0x06030037 RID: 196663 RVA: 0x006889E2 File Offset: 0x00686BE2
		public int Id { get; set; }

		// Token: 0x1700CC51 RID: 52305
		// (get) Token: 0x06030038 RID: 196664 RVA: 0x006889EB File Offset: 0x00686BEB
		// (set) Token: 0x06030039 RID: 196665 RVA: 0x006889F3 File Offset: 0x00686BF3
		public IFollowShooterJellyFishAbilityT AbilityType { get; set; }

		// Token: 0x0603003A RID: 196666 RVA: 0x006889FC File Offset: 0x00686BFC
		public IEnableFollowShooterAbilityT()
		{
			this.Enable = false;
			this.Id = 0;
			this.AbilityType = null;
		}
	}
}
