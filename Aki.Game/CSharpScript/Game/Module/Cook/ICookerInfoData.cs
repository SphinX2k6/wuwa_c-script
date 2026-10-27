using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B05 RID: 23301
	public interface ICookerInfoData
	{
		// Token: 0x17008C6F RID: 35951
		// (get) Token: 0x0603AFFF RID: 241663
		// (set) Token: 0x0603B000 RID: 241664
		int CookingLevel { get; set; }

		// Token: 0x17008C70 RID: 35952
		// (get) Token: 0x0603B001 RID: 241665
		// (set) Token: 0x0603B002 RID: 241666
		int TotalProficiencys { get; set; }

		// Token: 0x17008C71 RID: 35953
		// (get) Token: 0x0603B003 RID: 241667
		// (set) Token: 0x0603B004 RID: 241668
		int AddExp { get; set; }
	}
}
