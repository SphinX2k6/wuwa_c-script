using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065F2 RID: 26098
	[NullableContext(1)]
	[Nullable(0)]
	public class RequestHandleIn : IRequestHandleIn
	{
		// Token: 0x170095B4 RID: 38324
		// (get) Token: 0x060416B8 RID: 267960 RVA: 0x00FD9939 File Offset: 0x00FD7B39
		// (set) Token: 0x060416B9 RID: 267961 RVA: 0x00FD9941 File Offset: 0x00FD7B41
		public int InteractId { get; set; }

		// Token: 0x170095B5 RID: 38325
		// (get) Token: 0x060416BA RID: 267962 RVA: 0x00FD994A File Offset: 0x00FD7B4A
		// (set) Token: 0x060416BB RID: 267963 RVA: 0x00FD9952 File Offset: 0x00FD7B52
		public List<FishingItemInfo> LeftDataList { get; set; }

		// Token: 0x170095B6 RID: 38326
		// (get) Token: 0x060416BC RID: 267964 RVA: 0x00FD995B File Offset: 0x00FD7B5B
		// (set) Token: 0x060416BD RID: 267965 RVA: 0x00FD9963 File Offset: 0x00FD7B63
		public List<FishingItemInfo> RightDataList { get; set; }

		// Token: 0x170095B7 RID: 38327
		// (get) Token: 0x060416BE RID: 267966 RVA: 0x00FD996C File Offset: 0x00FD7B6C
		// (set) Token: 0x060416BF RID: 267967 RVA: 0x00FD9974 File Offset: 0x00FD7B74
		public int? RemoveIncId { get; set; }

		// Token: 0x170095B8 RID: 38328
		// (get) Token: 0x060416C0 RID: 267968 RVA: 0x00FD997D File Offset: 0x00FD7B7D
		// (set) Token: 0x060416C1 RID: 267969 RVA: 0x00FD9985 File Offset: 0x00FD7B85
		public int ActionIncId { get; set; }

		// Token: 0x170095B9 RID: 38329
		// (get) Token: 0x060416C2 RID: 267970 RVA: 0x00FD998E File Offset: 0x00FD7B8E
		// (set) Token: 0x060416C3 RID: 267971 RVA: 0x00FD9996 File Offset: 0x00FD7B96
		[Nullable(2)]
		public Action<bool, bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x060416C4 RID: 267972 RVA: 0x00FD999F File Offset: 0x00FD7B9F
		public RequestHandleIn()
		{
			this.LeftDataList = new List<FishingItemInfo>();
			this.RightDataList = new List<FishingItemInfo>();
		}
	}
}
