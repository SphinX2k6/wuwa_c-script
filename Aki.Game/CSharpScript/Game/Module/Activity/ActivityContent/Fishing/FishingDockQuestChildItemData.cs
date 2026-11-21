using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005586 RID: 21894
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingDockQuestChildItemData : IFishingDockQuestChildItemData
	{
		// Token: 0x1700695F RID: 26975
		// (get) Token: 0x06036427 RID: 222247 RVA: 0x00F213D9 File Offset: 0x00F1F5D9
		// (set) Token: 0x06036428 RID: 222248 RVA: 0x00F213E1 File Offset: 0x00F1F5E1
		public string DesText { get; set; }

		// Token: 0x17006960 RID: 26976
		// (get) Token: 0x06036429 RID: 222249 RVA: 0x00F213EA File Offset: 0x00F1F5EA
		// (set) Token: 0x0603642A RID: 222250 RVA: 0x00F213F2 File Offset: 0x00F1F5F2
		public int MaxCount { get; set; }

		// Token: 0x17006961 RID: 26977
		// (get) Token: 0x0603642B RID: 222251 RVA: 0x00F213FB File Offset: 0x00F1F5FB
		// (set) Token: 0x0603642C RID: 222252 RVA: 0x00F21403 File Offset: 0x00F1F603
		public int CurrentCount { get; set; }
	}
}
