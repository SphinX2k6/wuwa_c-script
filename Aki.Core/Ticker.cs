using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000D1 RID: 209
[NullableContext(1)]
[Nullable(0)]
public class Ticker
{
	// Token: 0x060006B4 RID: 1716 RVA: 0x00022CA0 File Offset: 0x00020EA0
	public Ticker(int id, Action<float> handle, ETickingGroup group, int priority, string name, int tickIntervalMs = 0, bool tickEvenPaused = false, bool ignoreSelfCenterMode = false)
	{
		this.Id = id;
		this.Handle = handle;
		this.Group = group;
		this.Priority = priority;
		this.Name = name;
		this.TickIntervalMs = tickIntervalMs;
		this.TickEvenPaused = tickEvenPaused;
		this.IgnoreSelfCenterMode = ignoreSelfCenterMode;
		this.StatObj = Stat.CreateNoFlameGraph("In TickSystem." + this.Name, "", "");
	}

	// Token: 0x0400053D RID: 1341
	public int Count;

	// Token: 0x0400053E RID: 1342
	public float CoolDown;

	// Token: 0x0400053F RID: 1343
	public bool Pause;

	// Token: 0x04000540 RID: 1344
	[Nullable(2)]
	public readonly Stat StatObj;

	// Token: 0x04000541 RID: 1345
	public readonly int Id;

	// Token: 0x04000542 RID: 1346
	public readonly Action<float> Handle;

	// Token: 0x04000543 RID: 1347
	public readonly ETickingGroup Group;

	// Token: 0x04000544 RID: 1348
	public readonly int Priority;

	// Token: 0x04000545 RID: 1349
	public readonly string Name;

	// Token: 0x04000546 RID: 1350
	public int TickIntervalMs;

	// Token: 0x04000547 RID: 1351
	public bool TickEvenPaused;

	// Token: 0x04000548 RID: 1352
	public bool IgnoreSelfCenterMode;

	// Token: 0x04000549 RID: 1353
	public bool PendingRemove;
}
