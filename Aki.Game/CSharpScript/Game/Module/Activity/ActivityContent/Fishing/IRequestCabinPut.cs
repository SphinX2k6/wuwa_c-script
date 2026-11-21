using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200556D RID: 21869
	[NullableContext(1)]
	public interface IRequestCabinPut
	{
		// Token: 0x17006904 RID: 26884
		// (get) Token: 0x06036358 RID: 222040
		// (set) Token: 0x06036359 RID: 222041
		CabinType Type { get; set; }

		// Token: 0x17006905 RID: 26885
		// (get) Token: 0x0603635A RID: 222042
		// (set) Token: 0x0603635B RID: 222043
		int? RequestId { get; set; }

		// Token: 0x17006906 RID: 26886
		// (get) Token: 0x0603635C RID: 222044
		// (set) Token: 0x0603635D RID: 222045
		List<FishingItemInfo> LeftDataList { get; set; }

		// Token: 0x17006907 RID: 26887
		// (get) Token: 0x0603635E RID: 222046
		// (set) Token: 0x0603635F RID: 222047
		List<FishingItemInfo> RightDataList { get; set; }

		// Token: 0x17006908 RID: 26888
		// (get) Token: 0x06036360 RID: 222048
		// (set) Token: 0x06036361 RID: 222049
		int? RemoveIncId { get; set; }

		// Token: 0x17006909 RID: 26889
		// (get) Token: 0x06036362 RID: 222050
		// (set) Token: 0x06036363 RID: 222051
		[Nullable(2)]
		Action<bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
