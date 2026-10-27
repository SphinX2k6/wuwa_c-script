using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007247 RID: 29255
	[NullableContext(1)]
	public interface IFlowListInfo
	{
		// Token: 0x17009E56 RID: 40534
		// (get) Token: 0x06047B8E RID: 293774
		// (set) Token: 0x06047B8F RID: 293775
		int FlowGenId { get; set; }

		// Token: 0x17009E57 RID: 40535
		// (get) Token: 0x06047B90 RID: 293776
		// (set) Token: 0x06047B91 RID: 293777
		Dictionary<int, ITextConfig> Texts { get; set; }

		// Token: 0x17009E58 RID: 40536
		// (get) Token: 0x06047B92 RID: 293778
		// (set) Token: 0x06047B93 RID: 293779
		IFlowInfo[] Flows { get; set; }
	}
}
