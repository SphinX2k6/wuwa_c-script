using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;

// Token: 0x0200264A RID: 9802
public class SplineInfo
{
	// Token: 0x0400D3B5 RID: 54197
	public int SplineId;

	// Token: 0x0400D3B6 RID: 54198
	[Nullable(2)]
	public GameSplineComponent SplineComp;

	// Token: 0x0400D3B7 RID: 54199
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PatrolPoint> VirtualSplinePoints;

	// Token: 0x0400D3B8 RID: 54200
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<MoveCharacterConfig> SegmentsMoveConfig;

	// Token: 0x0400D3B9 RID: 54201
	public bool IsLoop;

	// Token: 0x0400D3BA RID: 54202
	public bool IsCircle;
}
