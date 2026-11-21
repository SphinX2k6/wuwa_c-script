using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B6 RID: 20662
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeEntryGridItemTemplateData : IMultiTemplateGridData<RoverlikeGainEntry, RoverlikeEntryGridItem>, IMultiTemplateGridData
	{
		// Token: 0x170064F8 RID: 25848
		// (get) Token: 0x06033B77 RID: 211831 RVA: 0x00E799AC File Offset: 0x00E77BAC
		// (set) Token: 0x06033B78 RID: 211832 RVA: 0x00E799B4 File Offset: 0x00E77BB4
		public RoverlikeGainEntry Data { get; set; }

		// Token: 0x170064F9 RID: 25849
		// (get) Token: 0x06033B79 RID: 211833 RVA: 0x00E799BD File Offset: 0x00E77BBD
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06033B7A RID: 211834 RVA: 0x00E799C5 File Offset: 0x00E77BC5
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06033B7B RID: 211835 RVA: 0x00E799C8 File Offset: 0x00E77BC8
		public RoverlikeEntryGridItem CreateProxy()
		{
			return new RoverlikeEntryGridItem
			{
				OnClickCb = this.OnClickCb,
				IsGridSelected = this.IsSelected,
				GetSlotId = this.GetSlotId
			};
		}

		// Token: 0x06033B7C RID: 211836 RVA: 0x00E799F3 File Offset: 0x00E77BF3
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x0401B6B9 RID: 112313
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeGainEntry, int> OnClickCb;

		// Token: 0x0401B6BA RID: 112314
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> IsSelected;

		// Token: 0x0401B6BB RID: 112315
		[Nullable(2)]
		public Func<int, int> GetSlotId;

		// Token: 0x0401B6BC RID: 112316
		private const int ROVERLIKE_COLLECT_GRID_TEMPLATE_INDEX = 1;
	}
}
