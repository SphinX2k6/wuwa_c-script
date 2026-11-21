using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005581 RID: 21889
	public class IContinuesVariableSpeedMovementSplineT
	{
		// Token: 0x17009CAF RID: 40111
		// (get) Token: 0x06022CA9 RID: 142505 RVA: 0x004CABF8 File Offset: 0x004C8DF8
		// (set) Token: 0x06022CAA RID: 142506 RVA: 0x004CAC00 File Offset: 0x004C8E00
		public ESplineType Type { get; set; }

		// Token: 0x17009CB0 RID: 40112
		// (get) Token: 0x06022CAB RID: 142507 RVA: 0x004CAC09 File Offset: 0x004C8E09
		// (set) Token: 0x06022CAC RID: 142508 RVA: 0x004CAC11 File Offset: 0x004C8E11
		public int TransitionSpeed { get; set; }

		// Token: 0x17009CB1 RID: 40113
		// (get) Token: 0x06022CAD RID: 142509 RVA: 0x004CAC1A File Offset: 0x004C8E1A
		// (set) Token: 0x06022CAE RID: 142510 RVA: 0x004CAC22 File Offset: 0x004C8E22
		public ITimePathConfigT EntireTimePathConfig { get; set; }

		// Token: 0x17009CB2 RID: 40114
		// (get) Token: 0x06022CAF RID: 142511 RVA: 0x004CAC2B File Offset: 0x004C8E2B
		// (set) Token: 0x06022CB0 RID: 142512 RVA: 0x004CAC33 File Offset: 0x004C8E33
		public EMoveCircleMode CircleMode { get; set; }

		// Token: 0x17009CB3 RID: 40115
		// (get) Token: 0x06022CB1 RID: 142513 RVA: 0x004CAC3C File Offset: 0x004C8E3C
		// (set) Token: 0x06022CB2 RID: 142514 RVA: 0x004CAC44 File Offset: 0x004C8E44
		public List<IContinuesVariableSpeedSplinePointT> Points { get; set; }

		// Token: 0x17009CB4 RID: 40116
		// (get) Token: 0x06022CB3 RID: 142515 RVA: 0x004CAC4D File Offset: 0x004C8E4D
		// (set) Token: 0x06022CB4 RID: 142516 RVA: 0x004CAC55 File Offset: 0x004C8E55
		public byte NullMask { get; set; }

		// Token: 0x06022CB5 RID: 142517 RVA: 0x004CAC5E File Offset: 0x004C8E5E
		public IContinuesVariableSpeedMovementSplineT()
		{
			this.Type = ESplineType.Common;
			this.TransitionSpeed = 0;
			this.EntireTimePathConfig = null;
			this.CircleMode = EMoveCircleMode.CloseLoop;
			this.Points = null;
			this.NullMask = 0;
		}
	}
}
