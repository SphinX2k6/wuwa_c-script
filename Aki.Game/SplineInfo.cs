using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;

// Token: 0x020030F2 RID: 12530
public class SplineInfo
{
	// Token: 0x0400CFC4 RID: 53188
	public int SplineId;

	// Token: 0x0400CFC5 RID: 53189
	[Nullable(2)]
	public GameSplineComponent SplineComp;

	// Token: 0x0400CFC6 RID: 53190
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PatrolPoint> VirtualSplinePoints;

	// Token: 0x0400CFC7 RID: 53191
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<MoveCharacterConfig> SegmentsMoveConfig;

	// Token: 0x0400CFC8 RID: 53192
	public bool IsLoop;

	// Token: 0x0400CFC9 RID: 53193
	public bool IsCircle;
}
