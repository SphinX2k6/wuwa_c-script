using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200231B RID: 8987
[NullableContext(1)]
[Nullable(0)]
public class BulletConstant : Singleton
{
	// Token: 0x17002214 RID: 8724
	// (get) Token: 0x06016255 RID: 90709 RVA: 0x0066F793 File Offset: 0x0066D993
	public static BulletConstant Instance
	{
		get
		{
			if (BulletConstant._instance == null)
			{
				BulletConstant._instance = new BulletConstant();
				BulletConstant._instance.OnInit();
			}
			return BulletConstant._instance;
		}
	}

	// Token: 0x06016256 RID: 90710 RVA: 0x0066F7B6 File Offset: 0x0066D9B6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016257 RID: 90711 RVA: 0x0066F7B8 File Offset: 0x0066D9B8
	public static void ResetStaticDefaultValue()
	{
		BulletConstant instance = BulletConstant._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		BulletConstant._instance = null;
	}

	// Token: 0x06016258 RID: 90712 RVA: 0x0066F7D1 File Offset: 0x0066D9D1
	static BulletConstant()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletConstant.CreateStaticDefaultValue), new Action(BulletConstant.ResetStaticDefaultValue));
	}

	// Token: 0x0400BA92 RID: 47762
	public readonly FName ProfileNameWater = new FName("水体");

	// Token: 0x0400BA93 RID: 47763
	public readonly FName ProfileNameOnlyBullet = new FName("Bullet_OnlyBullet");

	// Token: 0x0400BA94 RID: 47764
	public readonly Rotator RotateToRight = Rotator.Create(0f, -90f, 0f);

	// Token: 0x0400BA95 RID: 47765
	public bool OpenCollisionLog;

	// Token: 0x0400BA96 RID: 47766
	public bool OpenMoveLog;

	// Token: 0x0400BA97 RID: 47767
	public bool OpenCreateLog;

	// Token: 0x0400BA98 RID: 47768
	public bool OpenHitActorLog;

	// Token: 0x0400BA99 RID: 47769
	public bool OpenDestroyLog;

	// Token: 0x0400BA9A RID: 47770
	public bool OpenActionStat;

	// Token: 0x0400BA9B RID: 47771
	public readonly bool OpenAllActionStat;

	// Token: 0x0400BA9C RID: 47772
	public const bool OpenPoolCheck = false;

	// Token: 0x0400BA9D RID: 47773
	public const bool OpenClearCheck = false;

	// Token: 0x0400BA9E RID: 47774
	public readonly bool OpenActorRecycleCheck;

	// Token: 0x0400BA9F RID: 47775
	public readonly bool CollisionCompVisibleInEditor = true;

	// Token: 0x0400BAA0 RID: 47776
	public readonly float SuperHighSpeed = 12000f;

	// Token: 0x0400BAA1 RID: 47777
	public readonly float HighSpeed = 5000f;

	// Token: 0x0400BAA2 RID: 47778
	public readonly int FactorBoxSix = 6;

	// Token: 0x0400BAA3 RID: 47779
	public readonly int FactorBoxTwelve = 12;

	// Token: 0x0400BAA4 RID: 47780
	public readonly FName HitCase = new FName("HitCase");

	// Token: 0x0400BAA5 RID: 47781
	public readonly string MoveCylinder = "CollisionCylinder";

	// Token: 0x0400BAA6 RID: 47782
	public readonly string RegionKey = "Region";

	// Token: 0x0400BAA7 RID: 47783
	[Nullable(2)]
	private static BulletConstant _instance;
}
