using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C4 RID: 26564
	public class IAdjustFixedLookAtTargetRangeEntityT
	{
		// Token: 0x1700C289 RID: 49801
		// (get) Token: 0x0602D415 RID: 185365 RVA: 0x0063169E File Offset: 0x0062F89E
		// (set) Token: 0x0602D416 RID: 185366 RVA: 0x006316A6 File Offset: 0x0062F8A6
		public EFixedLookAtTargetType Type { get; set; }

		// Token: 0x1700C28A RID: 49802
		// (get) Token: 0x0602D417 RID: 185367 RVA: 0x006316AF File Offset: 0x0062F8AF
		// (set) Token: 0x0602D418 RID: 185368 RVA: 0x006316B7 File Offset: 0x0062F8B7
		public int EntityId { get; set; }

		// Token: 0x1700C28B RID: 49803
		// (get) Token: 0x0602D419 RID: 185369 RVA: 0x006316C0 File Offset: 0x0062F8C0
		// (set) Token: 0x0602D41A RID: 185370 RVA: 0x006316C8 File Offset: 0x0062F8C8
		public IMovingCameraTimeParamsT MovingTimeParams { get; set; }

		// Token: 0x1700C28C RID: 49804
		// (get) Token: 0x0602D41B RID: 185371 RVA: 0x006316D1 File Offset: 0x0062F8D1
		// (set) Token: 0x0602D41C RID: 185372 RVA: 0x006316D9 File Offset: 0x0062F8D9
		public IPlayFlowT MovingFlow { get; set; }

		// Token: 0x1700C28D RID: 49805
		// (get) Token: 0x0602D41D RID: 185373 RVA: 0x006316E2 File Offset: 0x0062F8E2
		// (set) Token: 0x0602D41E RID: 185374 RVA: 0x006316EA File Offset: 0x0062F8EA
		public ICutCameraConfigT CutCameraConfig { get; set; }

		// Token: 0x0602D41F RID: 185375 RVA: 0x006316F3 File Offset: 0x0062F8F3
		public IAdjustFixedLookAtTargetRangeEntityT()
		{
			this.Type = EFixedLookAtTargetType.RangeEntity;
			this.EntityId = 0;
			this.MovingTimeParams = null;
			this.MovingFlow = null;
			this.CutCameraConfig = null;
		}
	}
}
