using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006127 RID: 24871
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideTitleTemplateData : IMultiTemplateGridData<RoverlikeOutsideTitleData, RoverlikeOutsideTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x1700918E RID: 37262
		// (get) Token: 0x0603EE08 RID: 257544 RVA: 0x00F2F817 File Offset: 0x00F2DA17
		// (set) Token: 0x0603EE09 RID: 257545 RVA: 0x00F2F81F File Offset: 0x00F2DA1F
		public RoverlikeOutsideTitleData Data { get; set; }

		// Token: 0x1700918F RID: 37263
		// (get) Token: 0x0603EE0A RID: 257546 RVA: 0x00F2F828 File Offset: 0x00F2DA28
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603EE0B RID: 257547 RVA: 0x00F2F830 File Offset: 0x00F2DA30
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603EE0C RID: 257548 RVA: 0x00F2F833 File Offset: 0x00F2DA33
		public RoverlikeOutsideTitleItem CreateProxy()
		{
			return new RoverlikeOutsideTitleItem();
		}

		// Token: 0x0603EE0D RID: 257549 RVA: 0x00F2F83A File Offset: 0x00F2DA3A
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}
	}
}
