using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E19 RID: 11801
[NullableContext(1)]
[Nullable(0)]
public class BulletPool : IStaticVariableResetter
{
	// Token: 0x06018D5D RID: 101725 RVA: 0x0065EDD9 File Offset: 0x0065CFD9
	static BulletPool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletPool.CreateStaticDefaultValue), new Action(BulletPool.ResetStaticDefaultValue));
	}

	// Token: 0x06018D5E RID: 101726 RVA: 0x0065EDF8 File Offset: 0x0065CFF8
	public static void Init()
	{
		for (int i = 0; i < 10; i++)
		{
			BulletEntity bulletEntity = BulletPool.BulletEntityPool.Create("bulletEntity");
			EntitySystem.Instance.Init(bulletEntity);
			EntitySystem.Instance.DeSpawn<BulletEntity>(bulletEntity);
			BulletPool.BulletEntityPool.Put(bulletEntity);
		}
		for (int j = 0; j < 10; j++)
		{
			BulletHitActorData value = BulletPool.BulletHitActorDataPool.Create();
			BulletPool.BulletHitActorDataPool.Put(value);
		}
		for (int k = 0; k < 10; k++)
		{
			BulletConditionResult value2 = BulletPool.BulletConditionResultPool.Create();
			BulletPool.BulletConditionResultPool.Put(value2);
		}
		for (int l = 0; l < 10; l++)
		{
			BulletPool.VectorPool.PreloadAdd(Vector.Create());
		}
		for (int m = 0; m < 10; m++)
		{
			BulletPool.RotatorPool.PreloadAdd(Rotator.Create());
		}
		for (int n = 0; n < 10; n++)
		{
			BulletPool.BulletHitTempResultPool.PreloadAdd(new BulletHitTempResult());
		}
	}

	// Token: 0x06018D5F RID: 101727 RVA: 0x0065EEF4 File Offset: 0x0065D0F4
	public static void Clear()
	{
		BulletPool.BulletEntityPool.Clear();
		BulletPool.BulletHitActorDataPool.Clear();
		BulletPool.BulletConditionResultPool.Clear();
		BulletPool.VectorPool.Clear();
		BulletPool.RotatorPool.Clear();
	}

	// Token: 0x17002275 RID: 8821
	// (get) Token: 0x06018D60 RID: 101728 RVA: 0x0065EF28 File Offset: 0x0065D128
	public static Lru<string, BulletEntity> BulletEntityPool
	{
		get
		{
			return BulletPool._bulletEntityPool;
		}
	}

	// Token: 0x06018D61 RID: 101729 RVA: 0x0065EF30 File Offset: 0x0065D130
	public static BulletEntity CreateBulletEntity()
	{
		BulletEntity bulletEntity = BulletPool.BulletEntityPool.Get("bulletEntity");
		if (bulletEntity != null)
		{
			EntitySystem.Instance.Respawn<BulletEntity>(bulletEntity, false, 0, null);
		}
		else
		{
			bulletEntity = BulletPool.BulletEntityPool.Create("bulletEntity");
			EntitySystem.Instance.Init(bulletEntity);
		}
		return bulletEntity;
	}

	// Token: 0x06018D62 RID: 101730 RVA: 0x0065EF7E File Offset: 0x0065D17E
	public static void RecycleBulletEntity(BulletEntity obj)
	{
		EntitySystem.Instance.DeSpawn<BulletEntity>(obj);
		BulletPool.BulletEntityPool.Put(obj);
	}

	// Token: 0x17002276 RID: 8822
	// (get) Token: 0x06018D63 RID: 101731 RVA: 0x0065EF98 File Offset: 0x0065D198
	public static Pool<BulletHitActorData> BulletHitActorDataPool
	{
		get
		{
			return BulletPool._bulletHitActorDataPool;
		}
	}

	// Token: 0x06018D64 RID: 101732 RVA: 0x0065EFA0 File Offset: 0x0065D1A0
	public static BulletHitActorData CreateBulletHitActorData()
	{
		BulletHitActorData bulletHitActorData = BulletPool.BulletHitActorDataPool.Get();
		if (bulletHitActorData == null)
		{
			bulletHitActorData = BulletPool.BulletHitActorDataPool.Create();
		}
		return bulletHitActorData;
	}

	// Token: 0x06018D65 RID: 101733 RVA: 0x0065EFC7 File Offset: 0x0065D1C7
	public static void RecycleBulletHitActorData(BulletHitActorData obj)
	{
		obj.Clear();
		BulletPool.BulletHitActorDataPool.Put(obj);
	}

	// Token: 0x17002277 RID: 8823
	// (get) Token: 0x06018D66 RID: 101734 RVA: 0x0065EFDB File Offset: 0x0065D1DB
	public static Pool<BulletConditionResult> BulletConditionResultPool
	{
		get
		{
			return BulletPool._bulletConditionResultPool;
		}
	}

	// Token: 0x06018D67 RID: 101735 RVA: 0x0065EFE4 File Offset: 0x0065D1E4
	public static BulletConditionResult CreateBulletConditionResult()
	{
		BulletConditionResult bulletConditionResult = BulletPool.BulletConditionResultPool.Get();
		if (bulletConditionResult == null)
		{
			bulletConditionResult = BulletPool.BulletConditionResultPool.Create();
		}
		return bulletConditionResult;
	}

	// Token: 0x06018D68 RID: 101736 RVA: 0x0065F00B File Offset: 0x0065D20B
	public static void RecycleBulletConditionResult(BulletConditionResult obj)
	{
		obj.Clear();
		BulletPool.BulletConditionResultPool.Put(obj);
	}

	// Token: 0x17002278 RID: 8824
	// (get) Token: 0x06018D69 RID: 101737 RVA: 0x0065F01F File Offset: 0x0065D21F
	public static SimplePool<Vector> VectorPool
	{
		get
		{
			return BulletPool._vectorPool;
		}
	}

	// Token: 0x06018D6A RID: 101738 RVA: 0x0065F028 File Offset: 0x0065D228
	public static Vector CreateVector(bool needReset = false)
	{
		Vector vector = BulletPool.VectorPool.Get();
		if (vector == null)
		{
			vector = Vector.Create();
		}
		else if (needReset)
		{
			vector.Reset();
		}
		BulletPool.VectorCount++;
		return vector;
	}

	// Token: 0x06018D6B RID: 101739 RVA: 0x0065F064 File Offset: 0x0065D264
	public static void RecycleVector(Vector obj)
	{
		BulletPool.VectorCount--;
		if (BulletConstant.Instance.OpenPoolCheck)
		{
			obj.Set(double.NaN, double.NaN, double.NaN);
			return;
		}
		BulletPool.VectorPool.Release(obj);
	}

	// Token: 0x17002279 RID: 8825
	// (get) Token: 0x06018D6C RID: 101740 RVA: 0x0065F0B6 File Offset: 0x0065D2B6
	public static SimplePool<Rotator> RotatorPool
	{
		get
		{
			return BulletPool._rotatorPool;
		}
	}

	// Token: 0x06018D6D RID: 101741 RVA: 0x0065F0C0 File Offset: 0x0065D2C0
	public static Rotator CreateRotator(bool needReset = false)
	{
		Rotator rotator = BulletPool.RotatorPool.Get();
		if (rotator == null)
		{
			rotator = Rotator.Create();
		}
		else if (needReset)
		{
			rotator.Reset();
		}
		BulletPool.RotatorCount++;
		return rotator;
	}

	// Token: 0x06018D6E RID: 101742 RVA: 0x0065F0F9 File Offset: 0x0065D2F9
	public static void RecycleRotator(Rotator obj)
	{
		BulletPool.RotatorCount--;
		if (BulletConstant.Instance.OpenPoolCheck)
		{
			obj.Set(float.NaN, float.NaN, float.NaN);
			return;
		}
		BulletPool.RotatorPool.Release(obj);
	}

	// Token: 0x1700227A RID: 8826
	// (get) Token: 0x06018D6F RID: 101743 RVA: 0x0065F134 File Offset: 0x0065D334
	public static SimplePool<BulletHitTempResult> BulletHitTempResultPool
	{
		get
		{
			return BulletPool._bulletHitTempResultPool;
		}
	}

	// Token: 0x06018D70 RID: 101744 RVA: 0x0065F13C File Offset: 0x0065D33C
	public static BulletHitTempResult CreateBulletHitTempResult()
	{
		BulletHitTempResult bulletHitTempResult = BulletPool.BulletHitTempResultPool.Get();
		if (bulletHitTempResult == null)
		{
			bulletHitTempResult = new BulletHitTempResult();
		}
		BulletPool.BulletHitTempResultCount++;
		return bulletHitTempResult;
	}

	// Token: 0x06018D71 RID: 101745 RVA: 0x0065F16A File Offset: 0x0065D36A
	public static void RecycleBulletHitTempResult(BulletHitTempResult obj)
	{
		BulletPool.BulletHitTempResultCount--;
		BulletPool.BulletHitTempResultPool.Release(obj);
	}

	// Token: 0x06018D72 RID: 101746 RVA: 0x0065F184 File Offset: 0x0065D384
	public static void CheckAtFrameEnd()
	{
		if (BulletPool.VectorCount != 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "当前帧子弹申请的Vector没有回收";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("VectorCount", BulletPool.VectorCount);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			BulletPool.VectorCount = 0;
		}
		if (BulletPool.RotatorCount != 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Bullet;
			ELogAuthor author2 = ELogAuthor.CFT;
			string message2 = "当前帧子弹申请的Rotator没有回收";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("RotatorCount", BulletPool.RotatorCount);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			BulletPool.RotatorCount = 0;
		}
		if (BulletPool.BulletHitTempResultCount != 0)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Bullet;
			ELogAuthor author3 = ELogAuthor.CFT;
			string message3 = "当前帧子弹申请的BulletHitTempResultCount没有回收";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("BulletHitTempResultCount", BulletPool.BulletHitTempResultCount);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			BulletPool.BulletHitTempResultCount = 0;
		}
	}

	// Token: 0x06018D73 RID: 101747 RVA: 0x0065F248 File Offset: 0x0065D448
	public static void CreateStaticDefaultValue()
	{
		BulletPool._bulletEntityPool = new Lru<string, BulletEntity>(10, (string key) => EntitySystem.Instance.Create<BulletEntity>(0, null), null);
		BulletPool._bulletHitActorDataPool = new Pool<BulletHitActorData>(20, () => new BulletHitActorData(), null);
		BulletPool._bulletConditionResultPool = new Pool<BulletConditionResult>(20, () => new BulletConditionResult(), null);
		BulletPool._vectorPool = new SimplePool<Vector>();
		BulletPool.VectorCount = 0;
		BulletPool._rotatorPool = new SimplePool<Rotator>();
		BulletPool.RotatorCount = 0;
		BulletPool._bulletHitTempResultPool = new SimplePool<BulletHitTempResult>();
		BulletPool.BulletHitTempResultCount = 0;
	}

	// Token: 0x06018D74 RID: 101748 RVA: 0x0065F309 File Offset: 0x0065D509
	public static void ResetStaticDefaultValue()
	{
		BulletPool._bulletEntityPool = null;
		BulletPool._bulletHitActorDataPool = null;
		BulletPool._bulletConditionResultPool = null;
		BulletPool._vectorPool = null;
		BulletPool.VectorCount = 0;
		BulletPool._rotatorPool = null;
		BulletPool.RotatorCount = 0;
		BulletPool._bulletHitTempResultPool = null;
		BulletPool.BulletHitTempResultCount = 0;
	}

	// Token: 0x0400BA56 RID: 47702
	private const string KEY_BULLET_ENTITY = "bulletEntity";

	// Token: 0x0400BA57 RID: 47703
	private const int PRE_ADD_COUNT = 10;

	// Token: 0x0400BA58 RID: 47704
	private const int CAPACITY = 20;

	// Token: 0x0400BA59 RID: 47705
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Lru<string, BulletEntity> _bulletEntityPool;

	// Token: 0x0400BA5A RID: 47706
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<BulletHitActorData> _bulletHitActorDataPool;

	// Token: 0x0400BA5B RID: 47707
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<BulletConditionResult> _bulletConditionResultPool;

	// Token: 0x0400BA5C RID: 47708
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static SimplePool<Vector> _vectorPool;

	// Token: 0x0400BA5D RID: 47709
	private static int VectorCount;

	// Token: 0x0400BA5E RID: 47710
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static SimplePool<Rotator> _rotatorPool;

	// Token: 0x0400BA5F RID: 47711
	private static int RotatorCount;

	// Token: 0x0400BA60 RID: 47712
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static SimplePool<BulletHitTempResult> _bulletHitTempResultPool;

	// Token: 0x0400BA61 RID: 47713
	private static int BulletHitTempResultCount;
}
