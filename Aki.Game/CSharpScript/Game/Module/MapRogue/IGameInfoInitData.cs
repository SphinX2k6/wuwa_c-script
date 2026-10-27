using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055AB RID: 21931
	[NullableContext(1)]
	public interface IGameInfoInitData
	{
		// Token: 0x17008694 RID: 34452
		// (get) Token: 0x06037E2B RID: 228907
		// (set) Token: 0x06037E2C RID: 228908
		int InstanceId { get; set; }

		// Token: 0x17008695 RID: 34453
		// (get) Token: 0x06037E2D RID: 228909
		// (set) Token: 0x06037E2E RID: 228910
		int RandomSeed { get; set; }

		// Token: 0x17008696 RID: 34454
		// (get) Token: 0x06037E2F RID: 228911
		// (set) Token: 0x06037E30 RID: 228912
		int MoodMin { get; set; }

		// Token: 0x17008697 RID: 34455
		// (get) Token: 0x06037E31 RID: 228913
		// (set) Token: 0x06037E32 RID: 228914
		int MoodMax { get; set; }

		// Token: 0x17008698 RID: 34456
		// (get) Token: 0x06037E33 RID: 228915
		// (set) Token: 0x06037E34 RID: 228916
		int InitMood { get; set; }

		// Token: 0x17008699 RID: 34457
		// (get) Token: 0x06037E35 RID: 228917
		// (set) Token: 0x06037E36 RID: 228918
		List<MapGridData> MapGrids { get; set; }

		// Token: 0x1700869A RID: 34458
		// (get) Token: 0x06037E37 RID: 228919
		// (set) Token: 0x06037E38 RID: 228920
		int MapWidth { get; set; }

		// Token: 0x1700869B RID: 34459
		// (get) Token: 0x06037E39 RID: 228921
		// (set) Token: 0x06037E3A RID: 228922
		int MapHeight { get; set; }

		// Token: 0x1700869C RID: 34460
		// (get) Token: 0x06037E3B RID: 228923
		// (set) Token: 0x06037E3C RID: 228924
		int PlayerGridIndex { get; set; }

		// Token: 0x1700869D RID: 34461
		// (get) Token: 0x06037E3D RID: 228925
		// (set) Token: 0x06037E3E RID: 228926
		int TeamLv { get; set; }

		// Token: 0x1700869E RID: 34462
		// (get) Token: 0x06037E3F RID: 228927
		// (set) Token: 0x06037E40 RID: 228928
		bool InBattle { get; set; }

		// Token: 0x1700869F RID: 34463
		// (get) Token: 0x06037E41 RID: 228929
		// (set) Token: 0x06037E42 RID: 228930
		int CurrencyItemId { get; set; }

		// Token: 0x170086A0 RID: 34464
		// (get) Token: 0x06037E43 RID: 228931
		// (set) Token: 0x06037E44 RID: 228932
		int MoodRuleId { get; set; }

		// Token: 0x170086A1 RID: 34465
		// (get) Token: 0x06037E45 RID: 228933
		// (set) Token: 0x06037E46 RID: 228934
		int RoleMaxStar { get; set; }

		// Token: 0x170086A2 RID: 34466
		// (get) Token: 0x06037E47 RID: 228935
		// (set) Token: 0x06037E48 RID: 228936
		int RoleLevel { get; set; }
	}
}
