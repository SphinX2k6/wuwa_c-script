using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A36 RID: 23094
	[NullableContext(1)]
	public interface IFlagChallengeBuffAddItemData
	{
		// Token: 0x17008BE4 RID: 35812
		// (get) Token: 0x0603A95F RID: 239967
		// (set) Token: 0x0603A960 RID: 239968
		string IconPath { get; set; }

		// Token: 0x17008BE5 RID: 35813
		// (get) Token: 0x0603A961 RID: 239969
		// (set) Token: 0x0603A962 RID: 239970
		string NameKey { get; set; }

		// Token: 0x17008BE6 RID: 35814
		// (get) Token: 0x0603A963 RID: 239971
		// (set) Token: 0x0603A964 RID: 239972
		string Value { get; set; }
	}
}
