using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056E9 RID: 22249
	public class OpSnapshotItem
	{
		// Token: 0x0401D07D RID: 118909
		[Nullable(1)]
		public DangoBrawlBackpackItemData Item;

		// Token: 0x0401D07E RID: 118910
		public ERestoreZone RestoreTo;

		// Token: 0x0401D07F RID: 118911
		public PanelPos Pos;

		// Token: 0x0401D080 RID: 118912
		public EDangoBrawlRotate Rot;

		// Token: 0x0401D081 RID: 118913
		public FVector2D? BenchDropPos;
	}
}
