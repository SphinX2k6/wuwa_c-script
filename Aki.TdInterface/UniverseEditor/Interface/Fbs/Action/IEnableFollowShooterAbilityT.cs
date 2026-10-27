using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200665E RID: 26206
	public class IEnableFollowShooterAbilityT
	{
		// Token: 0x1700C2B1 RID: 49841
		// (get) Token: 0x0602D863 RID: 186467 RVA: 0x0063BE61 File Offset: 0x0063A061
		// (set) Token: 0x0602D864 RID: 186468 RVA: 0x0063BE69 File Offset: 0x0063A069
		public bool Enable { get; set; }

		// Token: 0x1700C2B2 RID: 49842
		// (get) Token: 0x0602D865 RID: 186469 RVA: 0x0063BE72 File Offset: 0x0063A072
		// (set) Token: 0x0602D866 RID: 186470 RVA: 0x0063BE7A File Offset: 0x0063A07A
		public int Id { get; set; }

		// Token: 0x1700C2B3 RID: 49843
		// (get) Token: 0x0602D867 RID: 186471 RVA: 0x0063BE83 File Offset: 0x0063A083
		// (set) Token: 0x0602D868 RID: 186472 RVA: 0x0063BE8B File Offset: 0x0063A08B
		public IFollowShooterJellyFishAbilityT AbilityType { get; set; }

		// Token: 0x0602D869 RID: 186473 RVA: 0x0063BE94 File Offset: 0x0063A094
		public IEnableFollowShooterAbilityT()
		{
			this.Enable = false;
			this.Id = 0;
			this.AbilityType = null;
		}
	}
}
