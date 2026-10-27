using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054AE RID: 21678
	[NullableContext(2)]
	public interface IMarkItemData
	{
		// Token: 0x170084C7 RID: 33991
		// (get) Token: 0x06037633 RID: 226867
		// (set) Token: 0x06037634 RID: 226868
		int[] ShowRange { get; set; }

		// Token: 0x170084C8 RID: 33992
		// (get) Token: 0x06037635 RID: 226869
		// (set) Token: 0x06037636 RID: 226870
		string MarkPic { get; set; }

		// Token: 0x170084C9 RID: 33993
		// (get) Token: 0x06037637 RID: 226871
		// (set) Token: 0x06037638 RID: 226872
		int? ShowPriority { get; set; }

		// Token: 0x170084CA RID: 33994
		// (get) Token: 0x06037639 RID: 226873
		// (set) Token: 0x0603763A RID: 226874
		float? Scale { get; set; }

		// Token: 0x170084CB RID: 33995
		// (get) Token: 0x0603763B RID: 226875
		// (set) Token: 0x0603763C RID: 226876
		float? CornerScale { get; set; }
	}
}
