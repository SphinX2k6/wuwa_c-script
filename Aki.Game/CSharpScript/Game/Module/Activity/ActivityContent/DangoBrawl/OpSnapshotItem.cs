using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006799 RID: 26521
	public class OpSnapshotItem
	{
		// Token: 0x04022820 RID: 141344
		[Nullable(1)]
		public DangoBrawlBackpackItemData Item;

		// Token: 0x04022821 RID: 141345
		public ERestoreZone RestoreTo;

		// Token: 0x04022822 RID: 141346
		public PanelPos Pos;

		// Token: 0x04022823 RID: 141347
		public EDangoBrawlRotate Rot;

		// Token: 0x04022824 RID: 141348
		public FVector2D? BenchDropPos;
	}
}
