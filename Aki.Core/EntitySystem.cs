using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200008A RID: 138
[NullableContext(1)]
[Nullable(0)]
public class EntitySystem : Singleton
{
	// Token: 0x06000455 RID: 1109 RVA: 0x00018E19 File Offset: 0x00017019
	public bool Initialize()
	{
		this.TickEntityManger.Clear();
		this.AfterTickEntityManger.Clear();
		return true;
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00018E32 File Offset: 0x00017032
	[NullableContext(2)]
	public void SetEntityDestroyHandle(TEntityDestroyHandle handle)
	{
		this.DestroyHandle = handle;
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00018E3C File Offset: 0x0001703C
	[NullableContext(2)]
	public Entity Create([Nullable(1)] Type typeOfEntity, int priority = 0, IEntityArgs args = null)
	{
		Entity entity = (Entity)ObjectSystem.Instance.Create(typeOfEntity);
		if (!entity.Create(args))
		{
			ObjectSystem.Instance.Destroy(entity);
			return null;
		}
		if (entity.TickComponentManager.NeedTick)
		{
			this.TickEntityManger.Add(entity, priority);
		}
		if (entity.TickComponentManager.NeedAfterTick)
		{
			this.AfterTickEntityManger.Add(entity, priority);
		}
		return entity;
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00018EA6 File Offset: 0x000170A6
	[NullableContext(2)]
	public T Create<[Nullable(0)] T>(int priority = 0, IEntityArgs args = null) where T : Entity
	{
		return this.Create(typeof(T), priority, args) as T;
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00018EC4 File Offset: 0x000170C4
	public bool CreateExternal(Entity entity, int priority = 0, [Nullable(2)] IEntityArgs args = null)
	{
		if (!ObjectSystem.Instance.CreateExternal(entity))
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

	// Token: 0x0600045A RID: 1114 RVA: 0x00018F2C File Offset: 0x0001712C
	public bool Respawn(Entity entity, bool createExternal = false, int priority = 0, [Nullable(2)] IEntityArgs args = null)
	{
		if (!createExternal && !ObjectSystem.Instance.CreateExternal(entity))
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

	// Token: 0x0600045B RID: 1115 RVA: 0x00018F8C File Offset: 0x0001718C
	public bool InitData(Entity entity, [Nullable(2)] IEntityArgs args = null)
	{
		return entity.InitData(args);
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00018F95 File Offset: 0x00017195
	public bool Init(Entity entity)
	{
		if (!entity.Init())
		{
			ObjectSystem.Instance.Destroy(entity);
			return false;
		}
		return true;
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00018FAE File Offset: 0x000171AE
	public bool Start(Entity entity)
	{
		if (!entity.Start())
		{
			ObjectSystem.Instance.Destroy(entity);
			return false;
		}
		return true;
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00018FC7 File Offset: 0x000171C7
	public void Activate(Entity entity)
	{
		entity.Activate();
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00018FCF File Offset: 0x000171CF
	public void PostActive(Entity entity)
	{
		entity.PostActivate();
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00018FD8 File Offset: 0x000171D8
	public bool Destroy(Entity entity)
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

	// Token: 0x06000461 RID: 1121 RVA: 0x00019064 File Offset: 0x00017264
	public bool DeSpawn(Entity entity)
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

	// Token: 0x06000462 RID: 1122 RVA: 0x000190F0 File Offset: 0x000172F0
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

	// Token: 0x06000463 RID: 1123 RVA: 0x00019137 File Offset: 0x00017337
	[NullableContext(0)]
	[return: Nullable(2)]
	public T Get<T>(int id) where T : Entity
	{
		return this.Get(id) as T;
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x0001914C File Offset: 0x0001734C
	[NullableContext(0)]
	[return: Nullable(2)]
	public T GetComponent<T>(int id) where T : EntityComponent
	{
		Entity entity = this.Get(id);
		if (entity == null)
		{
			return default(T);
		}
		return entity.GetComponent<T>();
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00019173 File Offset: 0x00017373
	public void ForceTick(float delta)
	{
		this.TickEntityManger.ForceTick(delta);
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00019181 File Offset: 0x00017381
	public void Tick(float delta)
	{
		this.TickEntityManger.Tick(delta);
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x0001918F File Offset: 0x0001738F
	public void ForceAfterTick(float delta)
	{
		this.TickEntityManger.ForceAfterTick(delta);
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x0001919D File Offset: 0x0001739D
	public void AfterTick(float delta)
	{
		this.AfterTickEntityManger.AfterTick(delta);
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000469 RID: 1129 RVA: 0x000191AB File Offset: 0x000173AB
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

	// Token: 0x0600046A RID: 1130 RVA: 0x000191CE File Offset: 0x000173CE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x000191D0 File Offset: 0x000173D0
	public static void ResetStaticDefaultValue()
	{
		EntitySystem instance = EntitySystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		EntitySystem._instance = null;
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x000191E9 File Offset: 0x000173E9
	static EntitySystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntitySystem.CreateStaticDefaultValue), new Action(EntitySystem.ResetStaticDefaultValue));
	}

	// Token: 0x040003EE RID: 1006
	private readonly TickEntityManager TickEntityManger = new TickEntityManager();

	// Token: 0x040003EF RID: 1007
	private readonly TickEntityManager AfterTickEntityManger = new TickEntityManager();

	// Token: 0x040003F0 RID: 1008
	[Nullable(2)]
	private TEntityDestroyHandle DestroyHandle;

	// Token: 0x040003F1 RID: 1009
	[Nullable(2)]
	private static EntitySystem _instance;
}
