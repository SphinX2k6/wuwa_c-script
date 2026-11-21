using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200556E RID: 21870
	[NullableContext(1)]
	[Nullable(0)]
	public class RequestCabinPut : IRequestCabinPut
	{
		// Token: 0x1700690A RID: 26890
		// (get) Token: 0x06036364 RID: 222052 RVA: 0x00F20935 File Offset: 0x00F1EB35
		// (set) Token: 0x06036365 RID: 222053 RVA: 0x00F2093D File Offset: 0x00F1EB3D
		public CabinType Type { get; set; }

		// Token: 0x1700690B RID: 26891
		// (get) Token: 0x06036366 RID: 222054 RVA: 0x00F20946 File Offset: 0x00F1EB46
		// (set) Token: 0x06036367 RID: 222055 RVA: 0x00F2094E File Offset: 0x00F1EB4E
		public int? RequestId { get; set; }

		// Token: 0x1700690C RID: 26892
		// (get) Token: 0x06036368 RID: 222056 RVA: 0x00F20957 File Offset: 0x00F1EB57
		// (set) Token: 0x06036369 RID: 222057 RVA: 0x00F2095F File Offset: 0x00F1EB5F
		public List<FishingItemInfo> LeftDataList { get; set; }

		// Token: 0x1700690D RID: 26893
		// (get) Token: 0x0603636A RID: 222058 RVA: 0x00F20968 File Offset: 0x00F1EB68
		// (set) Token: 0x0603636B RID: 222059 RVA: 0x00F20970 File Offset: 0x00F1EB70
		public List<FishingItemInfo> RightDataList { get; set; }

		// Token: 0x1700690E RID: 26894
		// (get) Token: 0x0603636C RID: 222060 RVA: 0x00F20979 File Offset: 0x00F1EB79
		// (set) Token: 0x0603636D RID: 222061 RVA: 0x00F20981 File Offset: 0x00F1EB81
		public int? RemoveIncId { get; set; }

		// Token: 0x1700690F RID: 26895
		// (get) Token: 0x0603636E RID: 222062 RVA: 0x00F2098A File Offset: 0x00F1EB8A
		// (set) Token: 0x0603636F RID: 222063 RVA: 0x00F20992 File Offset: 0x00F1EB92
		[Nullable(2)]
		public Action<bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06036370 RID: 222064 RVA: 0x00F2099B File Offset: 0x00F1EB9B
		public RequestCabinPut()
		{
			this.LeftDataList = new List<FishingItemInfo>();
			this.RightDataList = new List<FishingItemInfo>();
		}
	}
}
