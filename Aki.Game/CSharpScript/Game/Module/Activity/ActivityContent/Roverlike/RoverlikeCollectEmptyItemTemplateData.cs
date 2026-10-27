using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200611F RID: 24863
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeCollectEmptyItemTemplateData : IMultiTemplateGridData<IRoverlikeCollectEmptyData, RoverlikeCollectEmptyItem>, IMultiTemplateGridData
	{
		// Token: 0x17009187 RID: 37255
		// (get) Token: 0x0603EDDA RID: 257498 RVA: 0x00F2F09B File Offset: 0x00F2D29B
		// (set) Token: 0x0603EDDB RID: 257499 RVA: 0x00F2F0A3 File Offset: 0x00F2D2A3
		public IRoverlikeCollectEmptyData Data { get; set; }

		// Token: 0x17009188 RID: 37256
		// (get) Token: 0x0603EDDC RID: 257500 RVA: 0x00F2F0AC File Offset: 0x00F2D2AC
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603EDDD RID: 257501 RVA: 0x00F2F0B4 File Offset: 0x00F2D2B4
		public int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x0603EDDE RID: 257502 RVA: 0x00F2F0B7 File Offset: 0x00F2D2B7
		public RoverlikeCollectEmptyItem CreateProxy()
		{
			return new RoverlikeCollectEmptyItem();
		}

		// Token: 0x0603EDDF RID: 257503 RVA: 0x00F2F0BE File Offset: 0x00F2D2BE
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x04020D33 RID: 134451
		private const int ROVERLIKE_COLLECT_EMPTY_TEMPLATE_INDEX = 2;
	}
}
