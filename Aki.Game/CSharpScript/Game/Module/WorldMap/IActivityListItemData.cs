using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200479C RID: 18332
	[NullableContext(1)]
	public interface IActivityListItemData
	{
		// Token: 0x170077EE RID: 30702
		// (get) Token: 0x0602FF01 RID: 196353
		// (set) Token: 0x0602FF02 RID: 196354
		EMapPeriodicActivityId Id { get; set; }

		// Token: 0x170077EF RID: 30703
		// (get) Token: 0x0602FF03 RID: 196355
		// (set) Token: 0x0602FF04 RID: 196356
		double LeftTime { get; set; }

		// Token: 0x170077F0 RID: 30704
		// (get) Token: 0x0602FF05 RID: 196357
		// (set) Token: 0x0602FF06 RID: 196358
		string LeftTimeText { get; set; }

		// Token: 0x170077F1 RID: 30705
		// (get) Token: 0x0602FF07 RID: 196359
		// (set) Token: 0x0602FF08 RID: 196360
		int CurrentNum { get; set; }

		// Token: 0x170077F2 RID: 30706
		// (get) Token: 0x0602FF09 RID: 196361
		// (set) Token: 0x0602FF0A RID: 196362
		int TotalNum { get; set; }

		// Token: 0x170077F3 RID: 30707
		// (get) Token: 0x0602FF0B RID: 196363
		// (set) Token: 0x0602FF0C RID: 196364
		bool IsFinish { get; set; }

		// Token: 0x170077F4 RID: 30708
		// (get) Token: 0x0602FF0D RID: 196365
		// (set) Token: 0x0602FF0E RID: 196366
		bool RedPoint { get; set; }

		// Token: 0x170077F5 RID: 30709
		// (get) Token: 0x0602FF0F RID: 196367
		// (set) Token: 0x0602FF10 RID: 196368
		Action OnClickCb { get; set; }

		// Token: 0x170077F6 RID: 30710
		// (get) Token: 0x0602FF11 RID: 196369
		// (set) Token: 0x0602FF12 RID: 196370
		Action<IActivityListItemData> OnLeftTimeRefreshCb { get; set; }
	}
}
