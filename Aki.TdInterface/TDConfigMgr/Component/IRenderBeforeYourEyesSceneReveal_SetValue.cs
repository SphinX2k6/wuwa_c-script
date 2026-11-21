using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000714 RID: 1812
	public class IRenderBeforeYourEyesSceneReveal_SetValue
	{
		// Token: 0x04001A66 RID: 6758
		public ERenderSpecifiedRangeType Type;

		// Token: 0x04001A67 RID: 6759
		public ITargetEntityType CenterTarget;

		// Token: 0x04001A68 RID: 6760
		public List<IRenderStateRadiusConfig> StateRadiusConfigs;
	}
}
