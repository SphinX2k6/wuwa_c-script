using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006121 RID: 24865
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeCollectTitleTemplateData : IMultiTemplateGridData<IRoverlikeCollectTitleData, RoverlikeCollectTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x17009189 RID: 37257
		// (get) Token: 0x0603EDE4 RID: 257508 RVA: 0x00F2F14B File Offset: 0x00F2D34B
		// (set) Token: 0x0603EDE5 RID: 257509 RVA: 0x00F2F153 File Offset: 0x00F2D353
		public IRoverlikeCollectTitleData Data { get; set; }

		// Token: 0x1700918A RID: 37258
		// (get) Token: 0x0603EDE6 RID: 257510 RVA: 0x00F2F15C File Offset: 0x00F2D35C
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603EDE7 RID: 257511 RVA: 0x00F2F164 File Offset: 0x00F2D364
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603EDE8 RID: 257512 RVA: 0x00F2F167 File Offset: 0x00F2D367
		public RoverlikeCollectTitleItem CreateProxy()
		{
			return new RoverlikeCollectTitleItem();
		}

		// Token: 0x0603EDE9 RID: 257513 RVA: 0x00F2F16E File Offset: 0x00F2D36E
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x04020D35 RID: 134453
		private const int ROVERLIKE_COLLECT_TITLE_TEMPLATE_INDEX = 0;
	}
}
