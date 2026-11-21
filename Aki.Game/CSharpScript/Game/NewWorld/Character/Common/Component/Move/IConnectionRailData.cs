using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200639D RID: 25501
	[NullableContext(1)]
	public interface IConnectionRailData
	{
		// Token: 0x1700754F RID: 30031
		// (get) Token: 0x0603DD3C RID: 253244
		// (set) Token: 0x0603DD3D RID: 253245
		Vector RotatorFixedDirection { get; set; }

		// Token: 0x17007550 RID: 30032
		// (get) Token: 0x0603DD3E RID: 253246
		// (set) Token: 0x0603DD3F RID: 253247
		int ConnectionNextRail { get; set; }

		// Token: 0x17007551 RID: 30033
		// (get) Token: 0x0603DD40 RID: 253248
		// (set) Token: 0x0603DD41 RID: 253249
		float ConnectionStartDistance { get; set; }
	}
}
