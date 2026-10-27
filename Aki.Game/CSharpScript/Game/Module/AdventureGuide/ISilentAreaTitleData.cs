using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EC5 RID: 24261
	[NullableContext(1)]
	public interface ISilentAreaTitleData
	{
		// Token: 0x17008ED8 RID: 36568
		// (get) Token: 0x0603DB2F RID: 252719
		// (set) Token: 0x0603DB30 RID: 252720
		string TitleName { get; set; }

		// Token: 0x17008ED9 RID: 36569
		// (get) Token: 0x0603DB31 RID: 252721
		// (set) Token: 0x0603DB32 RID: 252722
		int TypeDescription { get; set; }
	}
}
