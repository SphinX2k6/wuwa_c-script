using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C1E RID: 31774
	public class ITraceTracingT
	{
		// Token: 0x1700EDEA RID: 60906
		// (get) Token: 0x0603944F RID: 234575 RVA: 0x007BC20E File Offset: 0x007BA40E
		// (set) Token: 0x06039450 RID: 234576 RVA: 0x007BC216 File Offset: 0x007BA416
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700EDEB RID: 60907
		// (get) Token: 0x06039451 RID: 234577 RVA: 0x007BC21F File Offset: 0x007BA41F
		// (set) Token: 0x06039452 RID: 234578 RVA: 0x007BC227 File Offset: 0x007BA427
		public ETraceTracingImageType ImageResourceType { get; set; }

		// Token: 0x1700EDEC RID: 60908
		// (get) Token: 0x06039453 RID: 234579 RVA: 0x007BC230 File Offset: 0x007BA430
		// (set) Token: 0x06039454 RID: 234580 RVA: 0x007BC238 File Offset: 0x007BA438
		public ITraceTracingGridBoardT BoardConfig { get; set; }

		// Token: 0x1700EDED RID: 60909
		// (get) Token: 0x06039455 RID: 234581 RVA: 0x007BC241 File Offset: 0x007BA441
		// (set) Token: 0x06039456 RID: 234582 RVA: 0x007BC249 File Offset: 0x007BA449
		public int StepLimit { get; set; }

		// Token: 0x1700EDEE RID: 60910
		// (get) Token: 0x06039457 RID: 234583 RVA: 0x007BC252 File Offset: 0x007BA452
		// (set) Token: 0x06039458 RID: 234584 RVA: 0x007BC25A File Offset: 0x007BA45A
		public List<ITraceTracingMaxStepRewardRuleItemT> MaxStepRewardRule { get; set; }

		// Token: 0x1700EDEF RID: 60911
		// (get) Token: 0x06039459 RID: 234585 RVA: 0x007BC263 File Offset: 0x007BA463
		// (set) Token: 0x0603945A RID: 234586 RVA: 0x007BC26B File Offset: 0x007BA46B
		public bool RemainUiAfterCompletion { get; set; }

		// Token: 0x1700EDF0 RID: 60912
		// (get) Token: 0x0603945B RID: 234587 RVA: 0x007BC274 File Offset: 0x007BA474
		// (set) Token: 0x0603945C RID: 234588 RVA: 0x007BC27C File Offset: 0x007BA47C
		public byte NullMask { get; set; }

		// Token: 0x0603945D RID: 234589 RVA: 0x007BC285 File Offset: 0x007BA485
		public ITraceTracingT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.ImageResourceType = ETraceTracingImageType.None;
			this.BoardConfig = null;
			this.StepLimit = 0;
			this.MaxStepRewardRule = null;
			this.RemainUiAfterCompletion = false;
			this.NullMask = 0;
		}
	}
}
