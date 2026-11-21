using System;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200639B RID: 25499
	public interface ISplineRailData : IRailParam
	{
		// Token: 0x17007547 RID: 30023
		// (get) Token: 0x0603DD2B RID: 253227
		// (set) Token: 0x0603DD2C RID: 253228
		int DefaultNextRailId { get; set; }

		// Token: 0x17007548 RID: 30024
		// (get) Token: 0x0603DD2D RID: 253229
		// (set) Token: 0x0603DD2E RID: 253230
		ETriggerKey DefaultTriggerKey { get; set; }

		// Token: 0x17007549 RID: 30025
		// (get) Token: 0x0603DD2F RID: 253231
		// (set) Token: 0x0603DD30 RID: 253232
		int RailId { get; set; }
	}
}
