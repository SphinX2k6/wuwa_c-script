using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EAA RID: 20138
	[NullableContext(1)]
	public interface ISilentAreaTitleData
	{
		// Token: 0x170062AA RID: 25258
		// (get) Token: 0x06032ABF RID: 207551
		// (set) Token: 0x06032AC0 RID: 207552
		string TitleName { get; set; }

		// Token: 0x170062AB RID: 25259
		// (get) Token: 0x06032AC1 RID: 207553
		// (set) Token: 0x06032AC2 RID: 207554
		int TypeDescription { get; set; }
	}
}
