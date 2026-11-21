using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200557F RID: 21887
	[NullableContext(1)]
	public interface IFishingHandBookDesData
	{
		// Token: 0x17006948 RID: 26952
		// (get) Token: 0x060363E9 RID: 222185
		// (set) Token: 0x060363EA RID: 222186
		string DesText { get; set; }

		// Token: 0x17006949 RID: 26953
		// (get) Token: 0x060363EB RID: 222187
		// (set) Token: 0x060363EC RID: 222188
		string DataText { get; set; }

		// Token: 0x1700694A RID: 26954
		// (get) Token: 0x060363ED RID: 222189
		// (set) Token: 0x060363EE RID: 222190
		bool? IsGolden { get; set; }

		// Token: 0x1700694B RID: 26955
		// (get) Token: 0x060363EF RID: 222191
		// (set) Token: 0x060363F0 RID: 222192
		bool? IsSliver { get; set; }
	}
}
