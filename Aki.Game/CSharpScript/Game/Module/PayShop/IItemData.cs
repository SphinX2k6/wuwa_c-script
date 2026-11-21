using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02004334 RID: 17204
	[NullableContext(1)]
	public interface IItemData
	{
		// Token: 0x17005705 RID: 22277
		// (get) Token: 0x0602B709 RID: 177929
		// (set) Token: 0x0602B70A RID: 177930
		int Quality { get; set; }

		// Token: 0x17005706 RID: 22278
		// (get) Token: 0x0602B70B RID: 177931
		// (set) Token: 0x0602B70C RID: 177932
		int ItemId { get; set; }

		// Token: 0x17005707 RID: 22279
		// (get) Token: 0x0602B70D RID: 177933
		// (set) Token: 0x0602B70E RID: 177934
		string Name { get; set; }

		// Token: 0x17005708 RID: 22280
		// (get) Token: 0x0602B70F RID: 177935
		// (set) Token: 0x0602B710 RID: 177936
		EItemQualityType QualityType { get; set; }
	}
}
