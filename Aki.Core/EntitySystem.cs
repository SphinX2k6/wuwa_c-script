using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000088 RID: 136
[NullableContext(1)]
[Nullable(0)]
public class EntitySystem : Singleton
{
	// Token: 0x06000415 RID: 1045 RVA: 0x00018531 File Offset: 0x00016731
	public bool Initialize()
	{
		this.TickEntityManger.Clear();
		this.AfterTickEntityManger.Clear();
		return true;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x0001854A File Offset: 0x0001674A
	[NullableContext(2)]
	public void SetEntityDestroyHandle(TEntityDestroyHandle handle)
	{
		EntitySystem.Instance.DestroyHandle = handle;
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00018558 File Offset: 0x00016758
	[NullableContext(2)]
	public T Create<[Nullable(0)] T>(int priority = 0, IEntityArgs args = null) where T : Entity
	{
		T t = ObjectSystem.Instance.Create<T>();
		if (!t.Create(args))
		{
			ObjectSystem.Instance.Destroy(t);
			return default(T);
		}
		if (t.TickComponentManager.NeedTick)
		{
			this.TickEntityManger.Add(t, priority);
		}
		if (t.TickComponentManager.NeedAfterTick)
		{
			this.AfterTickEntityManger.Add(t, priority);
		}
		return t;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x000185E4 File Offset: 0x000167E4
	public bool CreateExternal<[Nullable(0)] T>(T entity, int priority = 0, [Nullable(2)] IEntityArgs args = null) where T : Entity
	{
		if (!ObjectSystem.Instance.CreateExternal<T>(entity))
		{
			return false;
		}
		if (!entity.Create(args))
		{
			ObjectSystem.Instance.Destroy(entity);
			return false;
		}
		if (entity.TickComponentManager.NeedTick)
		{
			this.TickEntityManger.Add(entity, priority);
		}
		if (entity.TickComponentManager.NeedAfterTick)
		{
			this.AfterTickEntityManger.Add(entity, priority);
		}
		return true;
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x0001866C File Offset: 0x0001686C
	public bool Respawn<[Nullable(0)] T>(T entity, bool createExternal = false, int priority = 0, [Nullable(2)] IEntityArgs args = null) where T : Entity
	{
		if (!createExternal && !ObjectSystem.Instance.CreateExternal<T>(entity))
		{
			return false;
		}
		if (!entity.Respawn(args))
		{
			return false;
		}
		if (entity.TickComponentManager.NeedTick)
		{
			this.TickEntityManger.Add(entity, priority);
		}
		if (entity.TickComponentManager.NeedAfterTick)
		{
			this.AfterTickEntityManger.Add(entity, priority);
		}
		return true;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x000186E5 File Offset: 0x000168E5
	public bool InitData<[Nullable(0)] T>(T entity, [Nullable(2)] IEntityArgs args = null) where T : Entity
	{
		return entity.InitData(args);
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x000186F3 File Offset: 0x000168F3
	public bool Init(Entity entity)
	{
		if (!entity.Init())
		{
			ObjectSystem.Instance.Destroy(entity);
			return false;
		}
		return true;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x0001870C File Offset: 0x0001690C
	public bool Start(Entity entity)
	{
		if (!entity.Start())
		{
			ObjectSystem.Instance.Destroy(entity);
			return false;
		}
		return true;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00018725 File Offset: 0x00016925
	public void Activate(Entity entity)
	{
		entity.Activate();
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x0001872D File Offset: 0x0001692D
	public void PostActive(Entity entity)
	{
		entity.PostActivate();
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00018738 File Offset: 0x00016938
	public bool Destroy<[Nullable(0)] T>(T entity) where T : Entity
	{
		if (!ObjectSystem.Instance.Destroy(entity))
		{
			return false;
		}
		if (GameBudgetInterfaceController.IsOpen)
		{
			entity.UnregisterFromGameBudgetController();
		}
		if (entity.TickComponentManager.NeedTick)
		{
			this.TickEntityManger.Delete(entity.Id);
		}
		if (entity.TickComponentManager.NeedAfterTick)
		{
			this.AfterTickEntityManger.Delete(entity.Id);
		}
		if (!entity.End() || !entity.Clear())
		{
			return false;
		}
		TEntityDestroyHandle destroyHandle = this.DestroyHandle;
		if (destroyHandle != null)
		{
			destroyHandle(entity);
		}
		return true;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x000187F0 File Offset: 0x000169F0
	public bool DeSpawn<[Nullable(0)] T>(T entity) where T : Entity
	{
		if (!ObjectSystem.Instance.Destroy(entity))
		{
			return false;
		}
		if (GameBudgetInterfaceController.IsOpen)
		{
			entity.UnregisterFromGameBudgetController();
		}
		if (entity.TickComponentManager.NeedTick)
		{
			this.TickEntityManger.Delete(entity.Id);
		}
		if (entity.TickComponentManager.NeedAfterTick)
		{
			this.AfterTickEntityManger.Delete(entity.Id);
		}
		if (!entity.End() || !entity.Clear())
		{
			return false;
		}
		TEntityDestroyHandle destroyHandle = this.DestroyHandle;
		if (destroyHandle != null)
		{
			destroyHandle(entity);
		}
		return true;
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x000188A8 File Offset: 0x00016AA8
	[NullableContext(2)]
	public Entity Get(int id)
	{
		List<ObjectBase> objects = ObjectSystem.Instance.Objects;
		int num = (int)((uint)id >> 16);
		Entity entity = (num >= objects.Count) ? null : (objects[num] as Entity);
		if (entity == null)
		{
			return null;
		}
		if (entity.Id != id)
		{
			return null;
		}
		return entity;
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x000188F0 File Offset: 0x00016AF0
	[NullableContext(0)]
	[return: Nullable(2)]
	public T Get<T>(int id) where T : Entity
	{
		List<ObjectBase> objects = ObjectSystem.Instance.Objects;
		int num = (int)((uint)id >> 16);
		Entity entity = (num >= objects.Count) ? null : (objects[num] as Entity);
		if (entity == null)
		{
			return default(T);
		}
		if (entity.Id != id)
		{
			return default(T);
		}
		return entity as T;
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00018954 File Offset: 0x00016B54
	[NullableContext(0)]
	[return: Nullable(2)]
	public T GetComponent<T>(int id) where T : EntityComponent
	{
		Entity entity = this.Get<Entity>(id);
		if (entity == null)
		{
			return default(T);
		}
		return entity.GetComponent<T>();
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x0001897B File Offset: 0x00016B7B
	public void ForceTick(float delta)
	{
		this.TickEntityManger.ForceTick(delta);
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00018989 File Offset: 0x00016B89
	public void Tick(float delta)
	{
		this.TickEntityManger.Tick(delta);
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00018997 File Offset: 0x00016B97
	public void ForceAfterTick(float delta)
	{
		this.TickEntityManger.ForceAfterTick(delta);
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x000189A5 File Offset: 0x00016BA5
	public void AfterTick(float delta)
	{
		this.AfterTickEntityManger.AfterTick(delta);
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000428 RID: 1064 RVA: 0x000189B3 File Offset: 0x00016BB3
	public static EntitySystem Instance
	{
		get
		{
			if (EntitySystem._instance == null)
			{
				EntitySystem._instance = new EntitySystem();
				EntitySystem._instance.OnInit();
			}
			return EntitySystem._instance;
		}
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x000189D6 File Offset: 0x00016BD6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x000189D8 File Offset: 0x00016BD8
	public static void ResetStaticDefaultValue()
	{
		EntitySystem instance = EntitySystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		EntitySystem._instance = null;
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x000189F1 File Offset: 0x00016BF1
	static EntitySystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntitySystem.CreateStaticDefaultValue), new Action(EntitySystem.ResetStaticDefaultValue));
	}

	// Token: 0x040003E0 RID: 992
	private readonly TickEntityManager TickEntityManger = new TickEntityManager();

	// Token: 0x040003E1 RID: 993
	private readonly TickEntityManager AfterTickEntityManger = new TickEntityManager();

	// Token: 0x040003E2 RID: 994
	[Nullable(2)]
	private TEntityDestroyHandle DestroyHandle;

	// Token: 0x040003E3 RID: 995
	[Nullable(2)]
	private static EntitySystem _instance;
}
