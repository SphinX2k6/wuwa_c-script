using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000CF RID: 207
[NullableContext(1)]
[Nullable(0)]
public class Ticker
{
	// Token: 0x06000673 RID: 1651 RVA: 0x000226D0 File Offset: 0x000208D0
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

	// Token: 0x0400052E RID: 1326
	public int Count;

	// Token: 0x0400052F RID: 1327
	public float CoolDown;

	// Token: 0x04000530 RID: 1328
	public bool Pause;

	// Token: 0x04000531 RID: 1329
	[Nullable(2)]
	public readonly Stat StatObj;

	// Token: 0x04000532 RID: 1330
	public readonly int Id;

	// Token: 0x04000533 RID: 1331
	public readonly Action<float> Handle;

	// Token: 0x04000534 RID: 1332
	public readonly ETickingGroup Group;

	// Token: 0x04000535 RID: 1333
	public readonly int Priority;

	// Token: 0x04000536 RID: 1334
	public readonly string Name;

	// Token: 0x04000537 RID: 1335
	public int TickIntervalMs;

	// Token: 0x04000538 RID: 1336
	public bool TickEvenPaused;

	// Token: 0x04000539 RID: 1337
	public bool IgnoreSelfCenterMode;

	// Token: 0x0400053A RID: 1338
	public bool PendingRemove;
}
