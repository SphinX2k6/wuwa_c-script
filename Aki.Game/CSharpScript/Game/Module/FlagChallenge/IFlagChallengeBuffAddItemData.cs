using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A12 RID: 18962
	[NullableContext(1)]
	public interface IFlagChallengeBuffAddItemData
	{
		// Token: 0x17005FB2 RID: 24498
		// (get) Token: 0x0602F8A8 RID: 194728
		// (set) Token: 0x0602F8A9 RID: 194729
		string IconPath { get; set; }

		// Token: 0x17005FB3 RID: 24499
		// (get) Token: 0x0602F8AA RID: 194730
		// (set) Token: 0x0602F8AB RID: 194731
		string NameKey { get; set; }

		// Token: 0x17005FB4 RID: 24500
		// (get) Token: 0x0602F8AC RID: 194732
		// (set) Token: 0x0602F8AD RID: 194733
		string Value { get; set; }
	}
}
