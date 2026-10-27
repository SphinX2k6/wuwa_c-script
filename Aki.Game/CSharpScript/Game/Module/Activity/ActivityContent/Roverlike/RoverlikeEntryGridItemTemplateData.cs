using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006138 RID: 24888
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeEntryGridItemTemplateData : IMultiTemplateGridData<RoverlikeGainEntry, RoverlikeEntryGridItem>, IMultiTemplateGridData
	{
		// Token: 0x17009196 RID: 37270
		// (get) Token: 0x0603EEB7 RID: 257719 RVA: 0x00F32ACC File Offset: 0x00F30CCC
		// (set) Token: 0x0603EEB8 RID: 257720 RVA: 0x00F32AD4 File Offset: 0x00F30CD4
		public RoverlikeGainEntry Data { get; set; }

		// Token: 0x17009197 RID: 37271
		// (get) Token: 0x0603EEB9 RID: 257721 RVA: 0x00F32ADD File Offset: 0x00F30CDD
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603EEBA RID: 257722 RVA: 0x00F32AE5 File Offset: 0x00F30CE5
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603EEBB RID: 257723 RVA: 0x00F32AE8 File Offset: 0x00F30CE8
		public RoverlikeEntryGridItem CreateProxy()
		{
			return new RoverlikeEntryGridItem
			{
				OnClickCb = this.OnClickCb,
				IsGridSelected = this.IsSelected,
				GetSlotId = this.GetSlotId
			};
		}

		// Token: 0x0603EEBC RID: 257724 RVA: 0x00F32B13 File Offset: 0x00F30D13
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x04020D8C RID: 134540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeGainEntry, int> OnClickCb;

		// Token: 0x04020D8D RID: 134541
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> IsSelected;

		// Token: 0x04020D8E RID: 134542
		[Nullable(2)]
		public Func<int, int> GetSlotId;

		// Token: 0x04020D8F RID: 134543
		private const int ROVERLIKE_COLLECT_GRID_TEMPLATE_INDEX = 1;
	}
}
