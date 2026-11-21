using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020000F4 RID: 244
[NullableContext(1)]
[Nullable(0)]
public abstract class IAiPerception
{
	// Token: 0x06000DCD RID: 3533
	public abstract void SetAiSenseEnable(int index, bool enable);

	// Token: 0x06000DCE RID: 3534
	public abstract void AddOrRemoveAiSense(int aiSenseId, bool add);

	// Token: 0x06000DCF RID: 3535
	public abstract void EnableAiSenseByType(int type, bool enable);

	// Token: 0x06000DD0 RID: 3536
	public abstract string GetEnableAiSenseDebug();

	// Token: 0x06000DD1 RID: 3537
	public abstract void Tick();

	// Token: 0x06000DD2 RID: 3538
	public abstract void Clear(bool allClear = true, bool collectEvent = false);

	// Token: 0x06000DD3 RID: 3539
	public abstract void OnEntityCampModified(Entity entity, ECamp oldCamp, ECamp newCamp);

	// Token: 0x06000DD4 RID: 3540
	public abstract void SetAiSenseEnableWithoutForbidAllSense(bool enable);

	// Token: 0x06000DD5 RID: 3541
	public abstract void SetAllAiSenseEnable(bool enable);

	// Token: 0x04000B2E RID: 2862
	public HashSet<int> Allies = new HashSet<int>();

	// Token: 0x04000B2F RID: 2863
	public HashSet<int> Enemies = new HashSet<int>();

	// Token: 0x04000B30 RID: 2864
	public HashSet<int> Neutrals = new HashSet<int>();

	// Token: 0x04000B31 RID: 2865
	public HashSet<int> AllEnemies = new HashSet<int>();

	// Token: 0x04000B32 RID: 2866
	public HashSet<int> ShareAllyLink = new HashSet<int>();

	// Token: 0x04000B33 RID: 2867
	public float MaxSenseRange;
}
