using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Utils;

// Token: 0x02002422 RID: 9250
[NullableContext(1)]
[Nullable(0)]
public class SkillActionData
{
	// Token: 0x0400C33E RID: 49982
	public ESkillAction Action;

	// Token: 0x0400C33F RID: 49983
	public string[] BulletRowNames = Array.Empty<string>();

	// Token: 0x0400C340 RID: 49984
	public bool[] SummonChild = Array.Empty<bool>();

	// Token: 0x0400C341 RID: 49985
	public long[] BuffId = Array.Empty<long>();

	// Token: 0x0400C342 RID: 49986
	public int[] StackCount = Array.Empty<int>();

	// Token: 0x0400C343 RID: 49987
	public int SkillId;

	// Token: 0x0400C344 RID: 49988
	public bool IsHardLock;

	// Token: 0x0400C345 RID: 49989
	public int LockOnConfigId;

	// Token: 0x0400C346 RID: 49990
	public ESkillTargetPriority SkillTargetPriority = ESkillTargetPriority.系统设置;

	// Token: 0x0400C347 RID: 49991
	public bool ShowTarget = true;

	// Token: 0x0400C348 RID: 49992
	public bool GlobalTarget;

	// Token: 0x0400C349 RID: 49993
	[Nullable(2)]
	public Formula Formula;

	// Token: 0x0400C34A RID: 49994
	public long[] ReduceSkillId = Array.Empty<long>();

	// Token: 0x0400C34B RID: 49995
	public ESkillCdReduceType[] CdResetType = Array.Empty<ESkillCdReduceType>();

	// Token: 0x0400C34C RID: 49996
	public float[] DecreaseRatio = Array.Empty<float>();

	// Token: 0x0400C34D RID: 49997
	public float[] DecreaseMagnitude = Array.Empty<float>();
}
