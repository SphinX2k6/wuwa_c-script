using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x0200634D RID: 25421
	[NullableContext(1)]
	public interface ICompositeExploreSkillConfig
	{
		// Token: 0x170074EF RID: 29935
		// (get) Token: 0x0603D9A9 RID: 252329
		// (set) Token: 0x0603D9AA RID: 252330
		string Name { get; set; }

		// Token: 0x170074F0 RID: 29936
		// (get) Token: 0x0603D9AB RID: 252331
		// (set) Token: 0x0603D9AC RID: 252332
		int EntrySkillId { get; set; }

		// Token: 0x170074F1 RID: 29937
		// (get) Token: 0x0603D9AD RID: 252333
		// (set) Token: 0x0603D9AE RID: 252334
		int ExitSkillId { get; set; }
	}
}
