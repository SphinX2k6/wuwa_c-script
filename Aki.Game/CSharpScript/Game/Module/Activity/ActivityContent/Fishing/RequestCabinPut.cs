using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065F0 RID: 26096
	[NullableContext(1)]
	[Nullable(0)]
	public class RequestCabinPut : IRequestCabinPut
	{
		// Token: 0x170095A8 RID: 38312
		// (get) Token: 0x0604169F RID: 267935 RVA: 0x00FD98B5 File Offset: 0x00FD7AB5
		// (set) Token: 0x060416A0 RID: 267936 RVA: 0x00FD98BD File Offset: 0x00FD7ABD
		public CabinType Type { get; set; }

		// Token: 0x170095A9 RID: 38313
		// (get) Token: 0x060416A1 RID: 267937 RVA: 0x00FD98C6 File Offset: 0x00FD7AC6
		// (set) Token: 0x060416A2 RID: 267938 RVA: 0x00FD98CE File Offset: 0x00FD7ACE
		public int? RequestId { get; set; }

		// Token: 0x170095AA RID: 38314
		// (get) Token: 0x060416A3 RID: 267939 RVA: 0x00FD98D7 File Offset: 0x00FD7AD7
		// (set) Token: 0x060416A4 RID: 267940 RVA: 0x00FD98DF File Offset: 0x00FD7ADF
		public List<FishingItemInfo> LeftDataList { get; set; }

		// Token: 0x170095AB RID: 38315
		// (get) Token: 0x060416A5 RID: 267941 RVA: 0x00FD98E8 File Offset: 0x00FD7AE8
		// (set) Token: 0x060416A6 RID: 267942 RVA: 0x00FD98F0 File Offset: 0x00FD7AF0
		public List<FishingItemInfo> RightDataList { get; set; }

		// Token: 0x170095AC RID: 38316
		// (get) Token: 0x060416A7 RID: 267943 RVA: 0x00FD98F9 File Offset: 0x00FD7AF9
		// (set) Token: 0x060416A8 RID: 267944 RVA: 0x00FD9901 File Offset: 0x00FD7B01
		public int? RemoveIncId { get; set; }

		// Token: 0x170095AD RID: 38317
		// (get) Token: 0x060416A9 RID: 267945 RVA: 0x00FD990A File Offset: 0x00FD7B0A
		// (set) Token: 0x060416AA RID: 267946 RVA: 0x00FD9912 File Offset: 0x00FD7B12
		[Nullable(2)]
		public Action<bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x060416AB RID: 267947 RVA: 0x00FD991B File Offset: 0x00FD7B1B
		public RequestCabinPut()
		{
			this.LeftDataList = new List<FishingItemInfo>();
			this.RightDataList = new List<FishingItemInfo>();
		}
	}
}
