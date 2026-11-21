using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000082 RID: 130
[NullableContext(1)]
[Nullable(0)]
public class EntityComponentSystem : Singleton
{
	// Token: 0x0600042B RID: 1067 RVA: 0x0001843A File Offset: 0x0001663A
	public bool Initialize()
	{
		return true;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00018440 File Offset: 0x00016640
	[return: Nullable(2)]
	public EntityComponent Create(Type type, Entity entity, [Nullable(2)] IEntityArgs args = null)
	{
		if (entity.UsePool && !this.ComponentTemplates.ContainsKey(type))
		{
			EntityComponent value = Activator.CreateInstance(type) as EntityComponent;
			this.ComponentTemplates.Add(type, value);
		}
		EntityComponent entityComponent = Activator.CreateInstance(type) as EntityComponent;
		if (!entityComponent.Create(entity, args))
		{
			return null;
		}
		return entityComponent;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00018498 File Offset: 0x00016698
	[return: Nullable(2)]
	public T Create<[Nullable(0)] T>(Entity entity, [Nullable(2)] IEntityArgs args = null) where T : EntityComponent, new()
	{
		if (entity.UsePool && !this.ComponentTemplates.ContainsKey(typeof(T)))
		{
			T t = Activator.CreateInstance<T>();
			this.ComponentTemplates.Add(typeof(T), t);
		}
		T t2 = Activator.CreateInstance<T>();
		if (!t2.Create(entity, args))
		{
			return default(T);
		}
		return t2;
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00018508 File Offset: 0x00016708
	public bool Destroy(Entity entity, EntityComponent component)
	{
		bool flag = component.Clear();
		if (!flag)
		{
			return false;
		}
		if (!entity.UsePool)
		{
			return flag;
		}
		return this.ClearComponent(component);
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00018534 File Offset: 0x00016734
	private bool ClearComponent(EntityComponent component)
	{
		Type type = component.GetType();
		EntityComponent entityComponent;
		this.ComponentTemplates.TryGetValue(type, out entityComponent);
		if (entityComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "清理不存在的组件类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Component", type.Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return component.ClearComponent(entityComponent);
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00018590 File Offset: 0x00016790
	[NullableContext(2)]
	public static bool ClearObject(object obj)
	{
		bool flag = obj == null || obj is Stat || obj is Delegate;
		if (flag)
		{
			return true;
		}
		IList list = obj as IList;
		if (list != null)
		{
			list.Clear();
			return true;
		}
		IClearable clearable = obj as IClearable;
		if (clearable != null)
		{
			clearable.Clear();
			return true;
		}
		IDictionary dictionary = obj as IDictionary;
		if (dictionary == null)
		{
			IClear clear = obj as IClear;
			return clear != null && clear.ClearObject();
		}
		dictionary.Clear();
		return true;
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00018608 File Offset: 0x00016808
	[NullableContext(2)]
	public static bool ClearObject<TValue>([Nullable(new byte[]
	{
		2,
		1
	})] HashSet<TValue> obj)
	{
		if (obj != null)
		{
			obj.Clear();
		}
		return true;
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00018614 File Offset: 0x00016814
	[NullableContext(2)]
	public static bool ClearObject<TValue>([Nullable(new byte[]
	{
		2,
		1
	})] TArray<TValue> obj)
	{
		if (obj != null)
		{
			obj.Empty(true);
		}
		return true;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00018621 File Offset: 0x00016821
	[NullableContext(2)]
	public static bool ClearObject<TValue>([Nullable(new byte[]
	{
		2,
		1
	})] TSet<TValue> obj)
	{
		if (obj != null)
		{
			obj.Empty(0);
		}
		return true;
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x0001862E File Offset: 0x0001682E
	[NullableContext(2)]
	public static bool ClearObject<TKey, TValue>([Nullable(new byte[]
	{
		2,
		1,
		1
	})] TMap<TKey, TValue> obj)
	{
		if (obj != null)
		{
			obj.Empty(0);
		}
		return true;
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x0001863B File Offset: 0x0001683B
	public static bool ClearObject<TKey, TValue>([Nullable(new byte[]
	{
		2,
		1,
		1
	})] ConditionalWeakTable<TKey, TValue> obj) where TKey : class where TValue : class
	{
		return true;
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x0001863E File Offset: 0x0001683E
	public static bool ClearObject<T>([Nullable(new byte[]
	{
		2,
		1
	})] WeakSet<T> obj) where T : class
	{
		return true;
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00018641 File Offset: 0x00016841
	public static bool ClearObject<TKey, [Nullable(2)] TValue>([Nullable(new byte[]
	{
		2,
		1,
		1
	})] WeakMap<TKey, TValue> obj) where TKey : class
	{
		return true;
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000438 RID: 1080 RVA: 0x00018644 File Offset: 0x00016844
	public static EntityComponentSystem Instance
	{
		get
		{
			if (EntityComponentSystem._instance == null)
			{
				EntityComponentSystem._instance = new EntityComponentSystem();
				EntityComponentSystem._instance.OnInit();
			}
			return EntityComponentSystem._instance;
		}
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00018667 File Offset: 0x00016867
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00018669 File Offset: 0x00016869
	public static void ResetStaticDefaultValue()
	{
		EntityComponentSystem instance = EntityComponentSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		EntityComponentSystem._instance = null;
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00018682 File Offset: 0x00016882
	static EntityComponentSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntityComponentSystem.CreateStaticDefaultValue), new Action(EntityComponentSystem.ResetStaticDefaultValue));
	}

	// Token: 0x040003B7 RID: 951
	public readonly Dictionary<Type, EntityComponent> ComponentTemplates = new Dictionary<Type, EntityComponent>();

	// Token: 0x040003B8 RID: 952
	public readonly Stat PerformanceStateClearComponent = Stat.Create("PerformanceStateClearComponent", "", "");

	// Token: 0x040003B9 RID: 953
	[Nullable(2)]
	private static EntityComponentSystem _instance;
}
