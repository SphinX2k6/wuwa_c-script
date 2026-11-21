using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E46 RID: 24134
	public class IRenderBeforeYourEyesSceneRevealT
	{
		// Token: 0x1700B1E8 RID: 45544
		// (get) Token: 0x0602853A RID: 165178 RVA: 0x005836A6 File Offset: 0x005818A6
		// (set) Token: 0x0602853B RID: 165179 RVA: 0x005836AE File Offset: 0x005818AE
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700B1E9 RID: 45545
		// (get) Token: 0x0602853C RID: 165180 RVA: 0x005836B7 File Offset: 0x005818B7
		// (set) Token: 0x0602853D RID: 165181 RVA: 0x005836BF File Offset: 0x005818BF
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700B1EA RID: 45546
		// (get) Token: 0x0602853E RID: 165182 RVA: 0x005836C8 File Offset: 0x005818C8
		// (set) Token: 0x0602853F RID: 165183 RVA: 0x005836D0 File Offset: 0x005818D0
		public List<IRenderStateRadiusConfigT> StateRadiusConfigs { get; set; }

		// Token: 0x06028540 RID: 165184 RVA: 0x005836D9 File Offset: 0x005818D9
		public IRenderBeforeYourEyesSceneRevealT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
			this.CenterTarget = null;
			this.StateRadiusConfigs = null;
		}
	}
}
