using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065EF RID: 26095
	[NullableContext(1)]
	public interface IRequestCabinPut
	{
		// Token: 0x170095A2 RID: 38306
		// (get) Token: 0x06041693 RID: 267923
		// (set) Token: 0x06041694 RID: 267924
		CabinType Type { get; set; }

		// Token: 0x170095A3 RID: 38307
		// (get) Token: 0x06041695 RID: 267925
		// (set) Token: 0x06041696 RID: 267926
		int? RequestId { get; set; }

		// Token: 0x170095A4 RID: 38308
		// (get) Token: 0x06041697 RID: 267927
		// (set) Token: 0x06041698 RID: 267928
		List<FishingItemInfo> LeftDataList { get; set; }

		// Token: 0x170095A5 RID: 38309
		// (get) Token: 0x06041699 RID: 267929
		// (set) Token: 0x0604169A RID: 267930
		List<FishingItemInfo> RightDataList { get; set; }

		// Token: 0x170095A6 RID: 38310
		// (get) Token: 0x0604169B RID: 267931
		// (set) Token: 0x0604169C RID: 267932
		int? RemoveIncId { get; set; }

		// Token: 0x170095A7 RID: 38311
		// (get) Token: 0x0604169D RID: 267933
		// (set) Token: 0x0604169E RID: 267934
		[Nullable(2)]
		Action<bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
