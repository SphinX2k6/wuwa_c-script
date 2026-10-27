using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006123 RID: 24867
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideEntryGridItemTemplateData : IMultiTemplateGridData<RoverlikeGainEntry, RoverlikeOutsideEntryGridItem>, IMultiTemplateGridData
	{
		// Token: 0x1700918C RID: 37260
		// (get) Token: 0x0603EDF7 RID: 257527 RVA: 0x00F2F448 File Offset: 0x00F2D648
		// (set) Token: 0x0603EDF8 RID: 257528 RVA: 0x00F2F450 File Offset: 0x00F2D650
		public RoverlikeGainEntry Data { get; set; }

		// Token: 0x1700918D RID: 37261
		// (get) Token: 0x0603EDF9 RID: 257529 RVA: 0x00F2F459 File Offset: 0x00F2D659
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603EDFA RID: 257530 RVA: 0x00F2F461 File Offset: 0x00F2D661
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603EDFB RID: 257531 RVA: 0x00F2F464 File Offset: 0x00F2D664
		public RoverlikeOutsideEntryGridItem CreateProxy()
		{
			return new RoverlikeOutsideEntryGridItem
			{
				OnClickCb = this.OnClickCb,
				IsGridSelected = this.IsSelected,
				GetLockState = this.GetLockState
			};
		}

		// Token: 0x0603EDFC RID: 257532 RVA: 0x00F2F48F File Offset: 0x00F2D68F
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x04020D3C RID: 134460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeGainEntry, int> OnClickCb;

		// Token: 0x04020D3D RID: 134461
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> IsSelected;

		// Token: 0x04020D3E RID: 134462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> GetLockState;
	}
}
