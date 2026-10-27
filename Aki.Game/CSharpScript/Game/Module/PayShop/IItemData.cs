using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02005351 RID: 21329
	[NullableContext(1)]
	public interface IItemData
	{
		// Token: 0x17008339 RID: 33593
		// (get) Token: 0x060367C8 RID: 223176
		// (set) Token: 0x060367C9 RID: 223177
		int Quality { get; set; }

		// Token: 0x1700833A RID: 33594
		// (get) Token: 0x060367CA RID: 223178
		// (set) Token: 0x060367CB RID: 223179
		int ItemId { get; set; }

		// Token: 0x1700833B RID: 33595
		// (get) Token: 0x060367CC RID: 223180
		// (set) Token: 0x060367CD RID: 223181
		string Name { get; set; }

		// Token: 0x1700833C RID: 33596
		// (get) Token: 0x060367CE RID: 223182
		// (set) Token: 0x060367CF RID: 223183
		EItemQualityType QualityType { get; set; }
	}
}
