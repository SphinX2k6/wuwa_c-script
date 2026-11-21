using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063C6 RID: 25542
	[NullableContext(1)]
	public interface IFlowListInfo
	{
		// Token: 0x170075AE RID: 30126
		// (get) Token: 0x0603DF46 RID: 253766
		// (set) Token: 0x0603DF47 RID: 253767
		int FlowGenId { get; set; }

		// Token: 0x170075AF RID: 30127
		// (get) Token: 0x0603DF48 RID: 253768
		// (set) Token: 0x0603DF49 RID: 253769
		Dictionary<int, ITextConfig> Texts { get; set; }

		// Token: 0x170075B0 RID: 30128
		// (get) Token: 0x0603DF4A RID: 253770
		// (set) Token: 0x0603DF4B RID: 253771
		IFlowInfo[] Flows { get; set; }
	}
}
