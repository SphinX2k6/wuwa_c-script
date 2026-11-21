using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200509D RID: 20637
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeCollectEmptyItemTemplateData : IMultiTemplateGridData<IRoverlikeCollectEmptyData, RoverlikeCollectEmptyItem>, IMultiTemplateGridData
	{
		// Token: 0x170064E9 RID: 25833
		// (get) Token: 0x06033A9C RID: 211612 RVA: 0x00E75EAF File Offset: 0x00E740AF
		// (set) Token: 0x06033A9D RID: 211613 RVA: 0x00E75EB7 File Offset: 0x00E740B7
		public IRoverlikeCollectEmptyData Data { get; set; }

		// Token: 0x170064EA RID: 25834
		// (get) Token: 0x06033A9E RID: 211614 RVA: 0x00E75EC0 File Offset: 0x00E740C0
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06033A9F RID: 211615 RVA: 0x00E75EC8 File Offset: 0x00E740C8
		public int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x06033AA0 RID: 211616 RVA: 0x00E75ECB File Offset: 0x00E740CB
		public RoverlikeCollectEmptyItem CreateProxy()
		{
			return new RoverlikeCollectEmptyItem();
		}

		// Token: 0x06033AA1 RID: 211617 RVA: 0x00E75ED2 File Offset: 0x00E740D2
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x0401B660 RID: 112224
		private const int ROVERLIKE_COLLECT_EMPTY_TEMPLATE_INDEX = 2;
	}
}
