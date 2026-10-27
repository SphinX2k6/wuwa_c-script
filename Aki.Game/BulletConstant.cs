using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002DC1 RID: 11713
[NullableContext(1)]
[Nullable(0)]
public class BulletConstant : Singleton
{
	// Token: 0x170021B8 RID: 8632
	// (get) Token: 0x060189AD RID: 100781 RVA: 0x0064998B File Offset: 0x00647B8B
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

	// Token: 0x060189AE RID: 100782 RVA: 0x006499AE File Offset: 0x00647BAE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060189AF RID: 100783 RVA: 0x006499B0 File Offset: 0x00647BB0
	public static void ResetStaticDefaultValue()
	{
		BulletConstant instance = BulletConstant._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		BulletConstant._instance = null;
	}

	// Token: 0x060189B0 RID: 100784 RVA: 0x006499C9 File Offset: 0x00647BC9
	static BulletConstant()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletConstant.CreateStaticDefaultValue), new Action(BulletConstant.ResetStaticDefaultValue));
	}

	// Token: 0x0400B717 RID: 46871
	public readonly FName ProfileNameWater = new FName("水体");

	// Token: 0x0400B718 RID: 46872
	public readonly FName ProfileNameOnlyBullet = new FName("Bullet_OnlyBullet");

	// Token: 0x0400B719 RID: 46873
	public readonly Rotator RotateToRight = Rotator.Create(0f, -90f, 0f);

	// Token: 0x0400B71A RID: 46874
	public bool OpenCollisionLog;

	// Token: 0x0400B71B RID: 46875
	public bool OpenMoveLog;

	// Token: 0x0400B71C RID: 46876
	public bool OpenCreateLog;

	// Token: 0x0400B71D RID: 46877
	public bool OpenHitActorLog;

	// Token: 0x0400B71E RID: 46878
	public bool OpenDestroyLog;

	// Token: 0x0400B71F RID: 46879
	public bool OpenActionStat;

	// Token: 0x0400B720 RID: 46880
	public readonly bool OpenAllActionStat;

	// Token: 0x0400B721 RID: 46881
	public readonly bool OpenPoolCheck;

	// Token: 0x0400B722 RID: 46882
	public readonly bool OpenClearCheck;

	// Token: 0x0400B723 RID: 46883
	public readonly bool OpenActorRecycleCheck;

	// Token: 0x0400B724 RID: 46884
	public readonly bool CollisionCompVisibleInEditor = true;

	// Token: 0x0400B725 RID: 46885
	public readonly float SuperHighSpeed = 12000f;

	// Token: 0x0400B726 RID: 46886
	public readonly float HighSpeed = 5000f;

	// Token: 0x0400B727 RID: 46887
	public readonly int FactorBoxSix = 6;

	// Token: 0x0400B728 RID: 46888
	public readonly int FactorBoxTwelve = 12;

	// Token: 0x0400B729 RID: 46889
	public readonly FName HitCase = new FName("HitCase");

	// Token: 0x0400B72A RID: 46890
	public readonly string MoveCylinder = "CollisionCylinder";

	// Token: 0x0400B72B RID: 46891
	public readonly string RegionKey = "Region";

	// Token: 0x0400B72C RID: 46892
	[Nullable(2)]
	private static BulletConstant _instance;
}
