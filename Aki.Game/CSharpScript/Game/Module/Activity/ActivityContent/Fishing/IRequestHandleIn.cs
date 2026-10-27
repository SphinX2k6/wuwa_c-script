using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065F1 RID: 26097
	[NullableContext(1)]
	public interface IRequestHandleIn
	{
		// Token: 0x170095AE RID: 38318
		// (get) Token: 0x060416AC RID: 267948
		// (set) Token: 0x060416AD RID: 267949
		int InteractId { get; set; }

		// Token: 0x170095AF RID: 38319
		// (get) Token: 0x060416AE RID: 267950
		// (set) Token: 0x060416AF RID: 267951
		List<FishingItemInfo> LeftDataList { get; set; }

		// Token: 0x170095B0 RID: 38320
		// (get) Token: 0x060416B0 RID: 267952
		// (set) Token: 0x060416B1 RID: 267953
		List<FishingItemInfo> RightDataList { get; set; }

		// Token: 0x170095B1 RID: 38321
		// (get) Token: 0x060416B2 RID: 267954
		// (set) Token: 0x060416B3 RID: 267955
		int? RemoveIncId { get; set; }

		// Token: 0x170095B2 RID: 38322
		// (get) Token: 0x060416B4 RID: 267956
		// (set) Token: 0x060416B5 RID: 267957
		int ActionIncId { get; set; }

		// Token: 0x170095B3 RID: 38323
		// (get) Token: 0x060416B6 RID: 267958
		// (set) Token: 0x060416B7 RID: 267959
		[Nullable(2)]
		Action<bool, bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
