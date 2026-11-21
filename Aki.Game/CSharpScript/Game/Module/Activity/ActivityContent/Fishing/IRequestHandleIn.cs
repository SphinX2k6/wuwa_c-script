using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200556F RID: 21871
	[NullableContext(1)]
	public interface IRequestHandleIn
	{
		// Token: 0x17006910 RID: 26896
		// (get) Token: 0x06036371 RID: 222065
		// (set) Token: 0x06036372 RID: 222066
		int InteractId { get; set; }

		// Token: 0x17006911 RID: 26897
		// (get) Token: 0x06036373 RID: 222067
		// (set) Token: 0x06036374 RID: 222068
		List<FishingItemInfo> LeftDataList { get; set; }

		// Token: 0x17006912 RID: 26898
		// (get) Token: 0x06036375 RID: 222069
		// (set) Token: 0x06036376 RID: 222070
		List<FishingItemInfo> RightDataList { get; set; }

		// Token: 0x17006913 RID: 26899
		// (get) Token: 0x06036377 RID: 222071
		// (set) Token: 0x06036378 RID: 222072
		int? RemoveIncId { get; set; }

		// Token: 0x17006914 RID: 26900
		// (get) Token: 0x06036379 RID: 222073
		// (set) Token: 0x0603637A RID: 222074
		int ActionIncId { get; set; }

		// Token: 0x17006915 RID: 26901
		// (get) Token: 0x0603637B RID: 222075
		// (set) Token: 0x0603637C RID: 222076
		[Nullable(2)]
		Action<bool, bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
