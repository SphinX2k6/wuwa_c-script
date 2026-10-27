using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EC3 RID: 24259
	[NullableContext(1)]
	public interface ISilentAreaDetectionDynamicData
	{
		// Token: 0x17008ED0 RID: 36560
		// (get) Token: 0x0603DB1E RID: 252702
		// (set) Token: 0x0603DB1F RID: 252703
		bool IsShow { get; set; }

		// Token: 0x17008ED1 RID: 36561
		// (get) Token: 0x0603DB20 RID: 252704
		// (set) Token: 0x0603DB21 RID: 252705
		int DangerType { get; set; }

		// Token: 0x17008ED2 RID: 36562
		// (get) Token: 0x0603DB22 RID: 252706
		// (set) Token: 0x0603DB23 RID: 252707
		SilentAreaDetectionRecord SilentAreaDetectionData { get; set; }

		// Token: 0x17008ED3 RID: 36563
		// (get) Token: 0x0603DB24 RID: 252708
		// (set) Token: 0x0603DB25 RID: 252709
		[Nullable(2)]
		ISilentAreaTitleData SilentAreaTitleData { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
