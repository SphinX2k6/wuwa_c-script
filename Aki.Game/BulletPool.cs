using System;
using System.Runtime.CompilerServices;

// Token: 0x02002375 RID: 9077
[NullableContext(1)]
[Nullable(0)]
public class BulletPool : IStaticVariableResetter
{
	// Token: 0x0601661F RID: 91679 RVA: 0x00684F61 File Offset: 0x00683161
	static BulletPool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletPool.CreateStaticDefaultValue), new Action(BulletPool.ResetStaticDefaultValue));
	}

	// Token: 0x06016620 RID: 91680 RVA: 0x00684F80 File Offset: 0x00683180
	public static void Init()
	{
		for (int i = 0; i < 10; i++)
		{
			BulletEntity bulletEntity = BulletPool.BulletEntityPool.Create("bulletEntity");
			EntitySystem.Instance.Init(bulletEntity);
			EntitySystem.Instance.DeSpawn(bulletEntity);
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

	// Token: 0x06016621 RID: 91681 RVA: 0x0068507C File Offset: 0x0068327C
	public static void Clear()
	{
		BulletPool.BulletEntityPool.Clear();
		BulletPool.BulletHitActorDataPool.Clear();
		BulletPool.BulletConditionResultPool.Clear();
		BulletPool.VectorPool.Clear();
		BulletPool.RotatorPool.Clear();
	}

	// Token: 0x170022DD RID: 8925
	// (get) Token: 0x06016622 RID: 91682 RVA: 0x006850B0 File Offset: 0x006832B0
	public static Lru<string, BulletEntity> BulletEntityPool
	{
		get
		{
			return BulletPool._bulletEntityPool;
		}
	}

	// Token: 0x06016623 RID: 91683 RVA: 0x006850B8 File Offset: 0x006832B8
	public static BulletEntity CreateBulletEntity()
	{
		BulletEntity bulletEntity = BulletPool.BulletEntityPool.Get("bulletEntity");
		if (bulletEntity != null)
		{
			EntitySystem.Instance.Respawn(bulletEntity, false, 0, null);
		}
		else
		{
			bulletEntity = BulletPool.BulletEntityPool.Create("bulletEntity");
			EntitySystem.Instance.Init(bulletEntity);
		}
		return bulletEntity;
	}

	// Token: 0x06016624 RID: 91684 RVA: 0x00685106 File Offset: 0x00683306
	public static void RecycleBulletEntity(BulletEntity obj)
	{
		EntitySystem.Instance.DeSpawn(obj);
		BulletPool.BulletEntityPool.Put(obj);
	}

	// Token: 0x170022DE RID: 8926
	// (get) Token: 0x06016625 RID: 91685 RVA: 0x00685120 File Offset: 0x00683320
	public static Pool<BulletHitActorData> BulletHitActorDataPool
	{
		get
		{
			return BulletPool._bulletHitActorDataPool;
		}
	}

	// Token: 0x06016626 RID: 91686 RVA: 0x00685128 File Offset: 0x00683328
	public static BulletHitActorData CreateBulletHitActorData()
	{
		BulletHitActorData bulletHitActorData = BulletPool.BulletHitActorDataPool.Get();
		if (bulletHitActorData == null)
		{
			bulletHitActorData = BulletPool.BulletHitActorDataPool.Create();
		}
		return bulletHitActorData;
	}

	// Token: 0x06016627 RID: 91687 RVA: 0x0068514F File Offset: 0x0068334F
	public static void RecycleBulletHitActorData(BulletHitActorData obj)
	{
		obj.Clear();
		BulletPool.BulletHitActorDataPool.Put(obj);
	}

	// Token: 0x170022DF RID: 8927
	// (get) Token: 0x06016628 RID: 91688 RVA: 0x00685163 File Offset: 0x00683363
	public static Pool<BulletConditionResult> BulletConditionResultPool
	{
		get
		{
			return BulletPool._bulletConditionResultPool;
		}
	}

	// Token: 0x06016629 RID: 91689 RVA: 0x0068516C File Offset: 0x0068336C
	public static BulletConditionResult CreateBulletConditionResult()
	{
		BulletConditionResult bulletConditionResult = BulletPool.BulletConditionResultPool.Get();
		if (bulletConditionResult == null)
		{
			bulletConditionResult = BulletPool.BulletConditionResultPool.Create();
		}
		return bulletConditionResult;
	}

	// Token: 0x0601662A RID: 91690 RVA: 0x00685193 File Offset: 0x00683393
	public static void RecycleBulletConditionResult(BulletConditionResult obj)
	{
		obj.Clear();
		BulletPool.BulletConditionResultPool.Put(obj);
	}

	// Token: 0x170022E0 RID: 8928
	// (get) Token: 0x0601662B RID: 91691 RVA: 0x006851A7 File Offset: 0x006833A7
	public static SimplePool<Vector> VectorPool
	{
		get
		{
			return BulletPool._vectorPool;
		}
	}

	// Token: 0x0601662C RID: 91692 RVA: 0x006851B0 File Offset: 0x006833B0
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

	// Token: 0x0601662D RID: 91693 RVA: 0x006851E9 File Offset: 0x006833E9
	public static void RecycleVector(Vector obj)
	{
		BulletPool.VectorCount--;
		BulletPool.VectorPool.Release(obj);
	}

	// Token: 0x170022E1 RID: 8929
	// (get) Token: 0x0601662E RID: 91694 RVA: 0x00685202 File Offset: 0x00683402
	public static SimplePool<Rotator> RotatorPool
	{
		get
		{
			return BulletPool._rotatorPool;
		}
	}

	// Token: 0x0601662F RID: 91695 RVA: 0x0068520C File Offset: 0x0068340C
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

	// Token: 0x06016630 RID: 91696 RVA: 0x00685245 File Offset: 0x00683445
	public static void RecycleRotator(Rotator obj)
	{
		BulletPool.RotatorCount--;
		BulletPool.RotatorPool.Release(obj);
	}

	// Token: 0x170022E2 RID: 8930
	// (get) Token: 0x06016631 RID: 91697 RVA: 0x0068525E File Offset: 0x0068345E
	public static SimplePool<BulletHitTempResult> BulletHitTempResultPool
	{
		get
		{
			return BulletPool._bulletHitTempResultPool;
		}
	}

	// Token: 0x06016632 RID: 91698 RVA: 0x00685268 File Offset: 0x00683468
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

	// Token: 0x06016633 RID: 91699 RVA: 0x00685296 File Offset: 0x00683496
	public static void RecycleBulletHitTempResult(BulletHitTempResult obj)
	{
		BulletPool.BulletHitTempResultCount--;
		BulletPool.BulletHitTempResultPool.Release(obj);
	}

	// Token: 0x06016634 RID: 91700 RVA: 0x006852B0 File Offset: 0x006834B0
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

	// Token: 0x06016635 RID: 91701 RVA: 0x00685374 File Offset: 0x00683574
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

	// Token: 0x06016636 RID: 91702 RVA: 0x00685435 File Offset: 0x00683635
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

	// Token: 0x0400BDE4 RID: 48612
	private const string KEY_BULLET_ENTITY = "bulletEntity";

	// Token: 0x0400BDE5 RID: 48613
	private const int PRE_ADD_COUNT = 10;

	// Token: 0x0400BDE6 RID: 48614
	private const int CAPACITY = 20;

	// Token: 0x0400BDE7 RID: 48615
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Lru<string, BulletEntity> _bulletEntityPool;

	// Token: 0x0400BDE8 RID: 48616
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<BulletHitActorData> _bulletHitActorDataPool;

	// Token: 0x0400BDE9 RID: 48617
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<BulletConditionResult> _bulletConditionResultPool;

	// Token: 0x0400BDEA RID: 48618
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static SimplePool<Vector> _vectorPool;

	// Token: 0x0400BDEB RID: 48619
	private static int VectorCount;

	// Token: 0x0400BDEC RID: 48620
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static SimplePool<Rotator> _rotatorPool;

	// Token: 0x0400BDED RID: 48621
	private static int RotatorCount;

	// Token: 0x0400BDEE RID: 48622
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static SimplePool<BulletHitTempResult> _bulletHitTempResultPool;

	// Token: 0x0400BDEF RID: 48623
	private static int BulletHitTempResultCount;
}
