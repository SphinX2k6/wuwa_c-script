using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Utils;

// Token: 0x02002ECF RID: 11983
[NullableContext(1)]
[Nullable(0)]
public class SkillActionData
{
	// Token: 0x0400BFA3 RID: 49059
	public ESkillAction Action;

	// Token: 0x0400BFA4 RID: 49060
	public string[] BulletRowNames = Array.Empty<string>();

	// Token: 0x0400BFA5 RID: 49061
	public bool[] SummonChild = Array.Empty<bool>();

	// Token: 0x0400BFA6 RID: 49062
	public long[] BuffId = Array.Empty<long>();

	// Token: 0x0400BFA7 RID: 49063
	public int[] StackCount = Array.Empty<int>();

	// Token: 0x0400BFA8 RID: 49064
	public int SkillId;

	// Token: 0x0400BFA9 RID: 49065
	public bool IsHardLock;

	// Token: 0x0400BFAA RID: 49066
	public int LockOnConfigId;

	// Token: 0x0400BFAB RID: 49067
	public ESkillTargetPriority SkillTargetPriority = ESkillTargetPriority.系统设置;

	// Token: 0x0400BFAC RID: 49068
	public bool ShowTarget = true;

	// Token: 0x0400BFAD RID: 49069
	public bool GlobalTarget;

	// Token: 0x0400BFAE RID: 49070
	[Nullable(2)]
	public Formula Formula;

	// Token: 0x0400BFAF RID: 49071
	public long[] ReduceSkillId = Array.Empty<long>();

	// Token: 0x0400BFB0 RID: 49072
	public ESkillCdReduceType[] CdResetType = Array.Empty<ESkillCdReduceType>();

	// Token: 0x0400BFB1 RID: 49073
	public float[] DecreaseRatio = Array.Empty<float>();

	// Token: 0x0400BFB2 RID: 49074
	public float[] DecreaseMagnitude = Array.Empty<float>();
}
