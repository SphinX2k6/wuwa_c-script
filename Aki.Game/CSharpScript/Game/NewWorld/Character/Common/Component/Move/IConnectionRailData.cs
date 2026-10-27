using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070ED RID: 28909
	[NullableContext(1)]
	public interface IConnectionRailData
	{
		// Token: 0x17009CC6 RID: 40134
		// (get) Token: 0x06046943 RID: 289091
		// (set) Token: 0x06046944 RID: 289092
		Vector RotatorFixedDirection { get; set; }

		// Token: 0x17009CC7 RID: 40135
		// (get) Token: 0x06046945 RID: 289093
		// (set) Token: 0x06046946 RID: 289094
		int ConnectionNextRail { get; set; }

		// Token: 0x17009CC8 RID: 40136
		// (get) Token: 0x06046947 RID: 289095
		// (set) Token: 0x06046948 RID: 289096
		float ConnectionStartDistance { get; set; }
	}
}
