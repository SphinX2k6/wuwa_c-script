using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050A1 RID: 20641
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideEntryGridItemTemplateData : IMultiTemplateGridData<RoverlikeGainEntry, RoverlikeOutsideEntryGridItem>, IMultiTemplateGridData
	{
		// Token: 0x170064EE RID: 25838
		// (get) Token: 0x06033AB9 RID: 211641 RVA: 0x00E7625C File Offset: 0x00E7445C
		// (set) Token: 0x06033ABA RID: 211642 RVA: 0x00E76264 File Offset: 0x00E74464
		public RoverlikeGainEntry Data { get; set; }

		// Token: 0x170064EF RID: 25839
		// (get) Token: 0x06033ABB RID: 211643 RVA: 0x00E7626D File Offset: 0x00E7446D
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06033ABC RID: 211644 RVA: 0x00E76275 File Offset: 0x00E74475
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06033ABD RID: 211645 RVA: 0x00E76278 File Offset: 0x00E74478
		public RoverlikeOutsideEntryGridItem CreateProxy()
		{
			return new RoverlikeOutsideEntryGridItem
			{
				OnClickCb = this.OnClickCb,
				IsGridSelected = this.IsSelected,
				GetLockState = this.GetLockState
			};
		}

		// Token: 0x06033ABE RID: 211646 RVA: 0x00E762A3 File Offset: 0x00E744A3
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x0401B669 RID: 112233
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeGainEntry, int> OnClickCb;

		// Token: 0x0401B66A RID: 112234
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> IsSelected;

		// Token: 0x0401B66B RID: 112235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> GetLockState;
	}
}
