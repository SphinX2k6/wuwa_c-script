using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BD0 RID: 19408
	[NullableContext(1)]
	public interface ICiacconaEndingViewParam
	{
		// Token: 0x1700613C RID: 24892
		// (get) Token: 0x0603070B RID: 198411
		// (set) Token: 0x0603070C RID: 198412
		CiacconaGalEndingData EndingData { get; set; }

		// Token: 0x1700613D RID: 24893
		// (get) Token: 0x0603070D RID: 198413
		// (set) Token: 0x0603070E RID: 198414
		[Nullable(2)]
		string LabelTextId { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
