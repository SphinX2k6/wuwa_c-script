using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200615F RID: 24927
	public class IAdjustFixedLookAtTargetRangeEntityT
	{
		// Token: 0x1700B919 RID: 47385
		// (get) Token: 0x0602AD1C RID: 175388 RVA: 0x005E74C2 File Offset: 0x005E56C2
		// (set) Token: 0x0602AD1D RID: 175389 RVA: 0x005E74CA File Offset: 0x005E56CA
		public EFixedLookAtTargetType Type { get; set; }

		// Token: 0x1700B91A RID: 47386
		// (get) Token: 0x0602AD1E RID: 175390 RVA: 0x005E74D3 File Offset: 0x005E56D3
		// (set) Token: 0x0602AD1F RID: 175391 RVA: 0x005E74DB File Offset: 0x005E56DB
		public int EntityId { get; set; }

		// Token: 0x1700B91B RID: 47387
		// (get) Token: 0x0602AD20 RID: 175392 RVA: 0x005E74E4 File Offset: 0x005E56E4
		// (set) Token: 0x0602AD21 RID: 175393 RVA: 0x005E74EC File Offset: 0x005E56EC
		public IMovingCameraTimeParamsT MovingTimeParams { get; set; }

		// Token: 0x1700B91C RID: 47388
		// (get) Token: 0x0602AD22 RID: 175394 RVA: 0x005E74F5 File Offset: 0x005E56F5
		// (set) Token: 0x0602AD23 RID: 175395 RVA: 0x005E74FD File Offset: 0x005E56FD
		public IPlayFlowT MovingFlow { get; set; }

		// Token: 0x1700B91D RID: 47389
		// (get) Token: 0x0602AD24 RID: 175396 RVA: 0x005E7506 File Offset: 0x005E5706
		// (set) Token: 0x0602AD25 RID: 175397 RVA: 0x005E750E File Offset: 0x005E570E
		public ICutCameraConfigT CutCameraConfig { get; set; }

		// Token: 0x0602AD26 RID: 175398 RVA: 0x005E7517 File Offset: 0x005E5717
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
