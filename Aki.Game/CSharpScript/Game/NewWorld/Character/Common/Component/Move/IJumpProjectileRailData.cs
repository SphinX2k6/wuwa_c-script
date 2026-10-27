using System;
using CSharpScript.Game.NewWorld.Character.Common.Controller;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070F3 RID: 28915
	public interface IJumpProjectileRailData : IRailParam, IConnectionRailData, IJumpProjectileParams
	{
		// Token: 0x17009CD5 RID: 40149
		// (get) Token: 0x06046964 RID: 289124
		// (set) Token: 0x06046965 RID: 289125
		float LastRate { get; set; }

		// Token: 0x17009CD6 RID: 40150
		// (get) Token: 0x06046966 RID: 289126
		// (set) Token: 0x06046967 RID: 289127
		float JumpTime { get; set; }
	}
}
