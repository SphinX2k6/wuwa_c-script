using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050A5 RID: 20645
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideTitleTemplateData : IMultiTemplateGridData<RoverlikeOutsideTitleData, RoverlikeOutsideTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x170064F0 RID: 25840
		// (get) Token: 0x06033ACA RID: 211658 RVA: 0x00E7662B File Offset: 0x00E7482B
		// (set) Token: 0x06033ACB RID: 211659 RVA: 0x00E76633 File Offset: 0x00E74833
		public RoverlikeOutsideTitleData Data { get; set; }

		// Token: 0x170064F1 RID: 25841
		// (get) Token: 0x06033ACC RID: 211660 RVA: 0x00E7663C File Offset: 0x00E7483C
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06033ACD RID: 211661 RVA: 0x00E76644 File Offset: 0x00E74844
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06033ACE RID: 211662 RVA: 0x00E76647 File Offset: 0x00E74847
		public RoverlikeOutsideTitleItem CreateProxy()
		{
			return new RoverlikeOutsideTitleItem();
		}

		// Token: 0x06033ACF RID: 211663 RVA: 0x00E7664E File Offset: 0x00E7484E
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}
	}
}
