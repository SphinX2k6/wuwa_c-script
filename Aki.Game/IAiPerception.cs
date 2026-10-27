using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020000F4 RID: 244
[NullableContext(1)]
[Nullable(0)]
public abstract class IAiPerception
{
	// Token: 0x06000DC7 RID: 3527
	public abstract void SetAiSenseEnable(int index, bool enable);

	// Token: 0x06000DC8 RID: 3528
	public abstract void AddOrRemoveAiSense(int aiSenseId, bool add);

	// Token: 0x06000DC9 RID: 3529
	public abstract void EnableAiSenseByType(int type, bool enable);

	// Token: 0x06000DCA RID: 3530
	public abstract string GetEnableAiSenseDebug();

	// Token: 0x06000DCB RID: 3531
	public abstract void Tick();

	// Token: 0x06000DCC RID: 3532
	public abstract void Clear(bool allClear = true, bool collectEvent = false);

	// Token: 0x06000DCD RID: 3533
	public abstract void OnEntityCampModified(Entity entity, ECamp oldCamp, ECamp newCamp);

	// Token: 0x06000DCE RID: 3534
	public abstract void SetAiSenseEnableWithoutForbidAllSense(bool enable);

	// Token: 0x06000DCF RID: 3535
	public abstract void SetAllAiSenseEnable(bool enable);

	// Token: 0x04000B26 RID: 2854
	public HashSet<int> Allies = new HashSet<int>();

	// Token: 0x04000B27 RID: 2855
	public HashSet<int> Enemies = new HashSet<int>();

	// Token: 0x04000B28 RID: 2856
	public HashSet<int> Neutrals = new HashSet<int>();

	// Token: 0x04000B29 RID: 2857
	public HashSet<int> AllEnemies = new HashSet<int>();

	// Token: 0x04000B2A RID: 2858
	public HashSet<int> ShareAllyLink = new HashSet<int>();

	// Token: 0x04000B2B RID: 2859
	public float MaxSenseRange;
}
