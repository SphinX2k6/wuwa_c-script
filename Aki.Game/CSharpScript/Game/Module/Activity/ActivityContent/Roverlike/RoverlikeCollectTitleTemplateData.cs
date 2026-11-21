using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200509F RID: 20639
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeCollectTitleTemplateData : IMultiTemplateGridData<IRoverlikeCollectTitleData, RoverlikeCollectTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x170064EB RID: 25835
		// (get) Token: 0x06033AA6 RID: 211622 RVA: 0x00E75F5F File Offset: 0x00E7415F
		// (set) Token: 0x06033AA7 RID: 211623 RVA: 0x00E75F67 File Offset: 0x00E74167
		public IRoverlikeCollectTitleData Data { get; set; }

		// Token: 0x170064EC RID: 25836
		// (get) Token: 0x06033AA8 RID: 211624 RVA: 0x00E75F70 File Offset: 0x00E74170
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06033AA9 RID: 211625 RVA: 0x00E75F78 File Offset: 0x00E74178
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06033AAA RID: 211626 RVA: 0x00E75F7B File Offset: 0x00E7417B
		public RoverlikeCollectTitleItem CreateProxy()
		{
			return new RoverlikeCollectTitleItem();
		}

		// Token: 0x06033AAB RID: 211627 RVA: 0x00E75F82 File Offset: 0x00E74182
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x0401B662 RID: 112226
		private const int ROVERLIKE_COLLECT_TITLE_TEMPLATE_INDEX = 0;
	}
}
