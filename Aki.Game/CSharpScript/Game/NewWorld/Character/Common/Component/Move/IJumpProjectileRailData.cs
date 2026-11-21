using System;
using CSharpScript.Game.NewWorld.Character.Common.Controller;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063A3 RID: 25507
	public interface IJumpProjectileRailData : IRailParam, IConnectionRailData, IJumpProjectileParams
	{
		// Token: 0x1700755E RID: 30046
		// (get) Token: 0x0603DD5D RID: 253277
		// (set) Token: 0x0603DD5E RID: 253278
		float LastRate { get; set; }

		// Token: 0x1700755F RID: 30047
		// (get) Token: 0x0603DD5F RID: 253279
		// (set) Token: 0x0603DD60 RID: 253280
		float JumpTime { get; set; }
	}
}
