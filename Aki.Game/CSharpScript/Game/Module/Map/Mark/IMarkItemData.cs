using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x02004491 RID: 17553
	[NullableContext(2)]
	public interface IMarkItemData
	{
		// Token: 0x17005893 RID: 22675
		// (get) Token: 0x0602C589 RID: 181641
		// (set) Token: 0x0602C58A RID: 181642
		int[] ShowRange { get; set; }

		// Token: 0x17005894 RID: 22676
		// (get) Token: 0x0602C58B RID: 181643
		// (set) Token: 0x0602C58C RID: 181644
		string MarkPic { get; set; }

		// Token: 0x17005895 RID: 22677
		// (get) Token: 0x0602C58D RID: 181645
		// (set) Token: 0x0602C58E RID: 181646
		int? ShowPriority { get; set; }

		// Token: 0x17005896 RID: 22678
		// (get) Token: 0x0602C58F RID: 181647
		// (set) Token: 0x0602C590 RID: 181648
		float? Scale { get; set; }

		// Token: 0x17005897 RID: 22679
		// (get) Token: 0x0602C591 RID: 181649
		// (set) Token: 0x0602C592 RID: 181650
		float? CornerScale { get; set; }
	}
}
