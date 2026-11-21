using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5B RID: 23643
	public class IParkourSplinePointT
	{
		// Token: 0x1700ADC1 RID: 44481
		// (get) Token: 0x0602737B RID: 160635 RVA: 0x0055F607 File Offset: 0x0055D807
		// (set) Token: 0x0602737C RID: 160636 RVA: 0x0055F60F File Offset: 0x0055D80F
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700ADC2 RID: 44482
		// (get) Token: 0x0602737D RID: 160637 RVA: 0x0055F618 File Offset: 0x0055D818
		// (set) Token: 0x0602737E RID: 160638 RVA: 0x0055F620 File Offset: 0x0055D820
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700ADC3 RID: 44483
		// (get) Token: 0x0602737F RID: 160639 RVA: 0x0055F629 File Offset: 0x0055D829
		// (set) Token: 0x06027380 RID: 160640 RVA: 0x0055F631 File Offset: 0x0055D831
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700ADC4 RID: 44484
		// (get) Token: 0x06027381 RID: 160641 RVA: 0x0055F63A File Offset: 0x0055D83A
		// (set) Token: 0x06027382 RID: 160642 RVA: 0x0055F642 File Offset: 0x0055D842
		public ESplineLine LineType { get; set; }

		// Token: 0x1700ADC5 RID: 44485
		// (get) Token: 0x06027383 RID: 160643 RVA: 0x0055F64B File Offset: 0x0055D84B
		// (set) Token: 0x06027384 RID: 160644 RVA: 0x0055F653 File Offset: 0x0055D853
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700ADC6 RID: 44486
		// (get) Token: 0x06027385 RID: 160645 RVA: 0x0055F65C File Offset: 0x0055D85C
		// (set) Token: 0x06027386 RID: 160646 RVA: 0x0055F664 File Offset: 0x0055D864
		public int Radius { get; set; }

		// Token: 0x1700ADC7 RID: 44487
		// (get) Token: 0x06027387 RID: 160647 RVA: 0x0055F66D File Offset: 0x0055D86D
		// (set) Token: 0x06027388 RID: 160648 RVA: 0x0055F675 File Offset: 0x0055D875
		public float ModifiedTime { get; set; }

		// Token: 0x1700ADC8 RID: 44488
		// (get) Token: 0x06027389 RID: 160649 RVA: 0x0055F67E File Offset: 0x0055D87E
		// (set) Token: 0x0602738A RID: 160650 RVA: 0x0055F686 File Offset: 0x0055D886
		public long BuffId { get; set; }

		// Token: 0x1700ADC9 RID: 44489
		// (get) Token: 0x0602738B RID: 160651 RVA: 0x0055F68F File Offset: 0x0055D88F
		// (set) Token: 0x0602738C RID: 160652 RVA: 0x0055F697 File Offset: 0x0055D897
		public IPointGroupT PointGroup { get; set; }

		// Token: 0x1700ADCA RID: 44490
		// (get) Token: 0x0602738D RID: 160653 RVA: 0x0055F6A0 File Offset: 0x0055D8A0
		// (set) Token: 0x0602738E RID: 160654 RVA: 0x0055F6A8 File Offset: 0x0055D8A8
		public string PlayerTag { get; set; }

		// Token: 0x1700ADCB RID: 44491
		// (get) Token: 0x0602738F RID: 160655 RVA: 0x0055F6B1 File Offset: 0x0055D8B1
		// (set) Token: 0x06027390 RID: 160656 RVA: 0x0055F6B9 File Offset: 0x0055D8B9
		public byte NullMask { get; set; }

		// Token: 0x06027391 RID: 160657 RVA: 0x0055F6C4 File Offset: 0x0055D8C4
		public IParkourSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.Radius = 0;
			this.ModifiedTime = 0f;
			this.BuffId = 0L;
			this.PointGroup = null;
			this.PlayerTag = null;
			this.NullMask = 0;
		}
	}
}
