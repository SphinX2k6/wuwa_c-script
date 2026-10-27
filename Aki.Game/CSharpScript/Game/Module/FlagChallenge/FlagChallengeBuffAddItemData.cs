using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A37 RID: 23095
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffAddItemData : IFlagChallengeBuffAddItemData
	{
		// Token: 0x17008BE7 RID: 35815
		// (get) Token: 0x0603A965 RID: 239973 RVA: 0x00DF12E1 File Offset: 0x00DEF4E1
		// (set) Token: 0x0603A966 RID: 239974 RVA: 0x00DF12E9 File Offset: 0x00DEF4E9
		public string IconPath { get; set; }

		// Token: 0x17008BE8 RID: 35816
		// (get) Token: 0x0603A967 RID: 239975 RVA: 0x00DF12F2 File Offset: 0x00DEF4F2
		// (set) Token: 0x0603A968 RID: 239976 RVA: 0x00DF12FA File Offset: 0x00DEF4FA
		public string NameKey { get; set; }

		// Token: 0x17008BE9 RID: 35817
		// (get) Token: 0x0603A969 RID: 239977 RVA: 0x00DF1303 File Offset: 0x00DEF503
		// (set) Token: 0x0603A96A RID: 239978 RVA: 0x00DF130B File Offset: 0x00DEF50B
		public string Value { get; set; }
	}
}
