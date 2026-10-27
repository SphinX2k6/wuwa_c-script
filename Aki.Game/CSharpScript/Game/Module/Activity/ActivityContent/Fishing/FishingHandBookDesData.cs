using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006602 RID: 26114
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingHandBookDesData : IFishingHandBookDesData
	{
		// Token: 0x170095EA RID: 38378
		// (get) Token: 0x0604172C RID: 268076 RVA: 0x00FD9B6B File Offset: 0x00FD7D6B
		// (set) Token: 0x0604172D RID: 268077 RVA: 0x00FD9B73 File Offset: 0x00FD7D73
		public string DesText { get; set; }

		// Token: 0x170095EB RID: 38379
		// (get) Token: 0x0604172E RID: 268078 RVA: 0x00FD9B7C File Offset: 0x00FD7D7C
		// (set) Token: 0x0604172F RID: 268079 RVA: 0x00FD9B84 File Offset: 0x00FD7D84
		public string DataText { get; set; }

		// Token: 0x170095EC RID: 38380
		// (get) Token: 0x06041730 RID: 268080 RVA: 0x00FD9B8D File Offset: 0x00FD7D8D
		// (set) Token: 0x06041731 RID: 268081 RVA: 0x00FD9B95 File Offset: 0x00FD7D95
		public bool? IsGolden { get; set; }

		// Token: 0x170095ED RID: 38381
		// (get) Token: 0x06041732 RID: 268082 RVA: 0x00FD9B9E File Offset: 0x00FD7D9E
		// (set) Token: 0x06041733 RID: 268083 RVA: 0x00FD9BA6 File Offset: 0x00FD7DA6
		public bool? IsSliver { get; set; }

		// Token: 0x06041734 RID: 268084 RVA: 0x00FD9BAF File Offset: 0x00FD7DAF
		public FishingHandBookDesData()
		{
			this.DesText = "";
			this.DataText = "";
		}
	}
}
