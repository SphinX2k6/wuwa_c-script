using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x020053FA RID: 21498
	[NullableContext(1)]
	[Nullable(0)]
	public class BusinessTipsShopData : IBusinessTipsShopData
	{
		// Token: 0x1700680D RID: 26637
		// (get) Token: 0x060356F6 RID: 218870 RVA: 0x00EEC77A File Offset: 0x00EEA97A
		// (set) Token: 0x060356F7 RID: 218871 RVA: 0x00EEC782 File Offset: 0x00EEA982
		public int RoleId { get; set; }

		// Token: 0x1700680E RID: 26638
		// (get) Token: 0x060356F8 RID: 218872 RVA: 0x00EEC78B File Offset: 0x00EEA98B
		// (set) Token: 0x060356F9 RID: 218873 RVA: 0x00EEC793 File Offset: 0x00EEA993
		public bool IsMoreSuccessful { get; set; }

		// Token: 0x1700680F RID: 26639
		// (get) Token: 0x060356FA RID: 218874 RVA: 0x00EEC79C File Offset: 0x00EEA99C
		// (set) Token: 0x060356FB RID: 218875 RVA: 0x00EEC7A4 File Offset: 0x00EEA9A4
		public int TrainType { get; set; }

		// Token: 0x17006810 RID: 26640
		// (get) Token: 0x060356FC RID: 218876 RVA: 0x00EEC7AD File Offset: 0x00EEA9AD
		// (set) Token: 0x060356FD RID: 218877 RVA: 0x00EEC7B5 File Offset: 0x00EEA9B5
		public EditTeamData LastData { get; set; }
	}
}
