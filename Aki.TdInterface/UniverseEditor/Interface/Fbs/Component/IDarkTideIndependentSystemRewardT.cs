using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D8 RID: 21976
	public class IDarkTideIndependentSystemRewardT
	{
		// Token: 0x17009D57 RID: 40279
		// (get) Token: 0x06022F8F RID: 143247 RVA: 0x004D028B File Offset: 0x004CE48B
		// (set) Token: 0x06022F90 RID: 143248 RVA: 0x004D0293 File Offset: 0x004CE493
		public EIndependentSystemRewardType Type { get; set; }

		// Token: 0x17009D58 RID: 40280
		// (get) Token: 0x06022F91 RID: 143249 RVA: 0x004D029C File Offset: 0x004CE49C
		// (set) Token: 0x06022F92 RID: 143250 RVA: 0x004D02A4 File Offset: 0x004CE4A4
		public int RewardId { get; set; }

		// Token: 0x17009D59 RID: 40281
		// (get) Token: 0x06022F93 RID: 143251 RVA: 0x004D02AD File Offset: 0x004CE4AD
		// (set) Token: 0x06022F94 RID: 143252 RVA: 0x004D02B5 File Offset: 0x004CE4B5
		public List<int> RewardIdList { get; set; }

		// Token: 0x17009D5A RID: 40282
		// (get) Token: 0x06022F95 RID: 143253 RVA: 0x004D02BE File Offset: 0x004CE4BE
		// (set) Token: 0x06022F96 RID: 143254 RVA: 0x004D02C6 File Offset: 0x004CE4C6
		public byte NullMask { get; set; }

		// Token: 0x06022F97 RID: 143255 RVA: 0x004D02CF File Offset: 0x004CE4CF
		public IDarkTideIndependentSystemRewardT()
		{
			this.Type = EIndependentSystemRewardType.DarkTide;
			this.RewardId = 0;
			this.RewardIdList = null;
			this.NullMask = 0;
		}
	}
}
