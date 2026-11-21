using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004389 RID: 17289
	[NullableContext(1)]
	public interface IMoraleBuffAddItemData
	{
		// Token: 0x17005778 RID: 22392
		// (get) Token: 0x0602BAD7 RID: 178903
		string IconPath { get; }

		// Token: 0x17005779 RID: 22393
		// (get) Token: 0x0602BAD8 RID: 178904
		string NameKey { get; }

		// Token: 0x1700577A RID: 22394
		// (get) Token: 0x0602BAD9 RID: 178905
		string Value { get; }
	}
}
