using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200007F RID: 127
[NullableContext(1)]
[Nullable(0)]
public class EntityComponentSystem : Singleton
{
	// Token: 0x060003EA RID: 1002 RVA: 0x00017B1A File Offset: 0x00015D1A
	public bool Initialize()
	{
		return true;
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00017B20 File Offset: 0x00015D20
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

	// Token: 0x060003EC RID: 1004 RVA: 0x00017B78 File Offset: 0x00015D78
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

	// Token: 0x060003ED RID: 1005 RVA: 0x00017BE8 File Offset: 0x00015DE8
	public bool Destroy<[Nullable(0)] T>(Entity entity, T component) where T : EntityComponent
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
		return this.ClearComponent<T>(component);
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00017C1C File Offset: 0x00015E1C
	private bool ClearComponent<[Nullable(0)] T>(T component) where T : EntityComponent
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

	// Token: 0x060003EF RID: 1007 RVA: 0x00017C84 File Offset: 0x00015E84
	public static bool ClearObject<[Nullable(2)] T>(T obj)
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

	// Token: 0x060003F0 RID: 1008 RVA: 0x00017D1F File Offset: 0x00015F1F
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

	// Token: 0x060003F1 RID: 1009 RVA: 0x00017D2B File Offset: 0x00015F2B
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

	// Token: 0x060003F2 RID: 1010 RVA: 0x00017D38 File Offset: 0x00015F38
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

	// Token: 0x060003F3 RID: 1011 RVA: 0x00017D45 File Offset: 0x00015F45
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

	// Token: 0x060003F4 RID: 1012 RVA: 0x00017D52 File Offset: 0x00015F52
	public static bool ClearObject<TKey, TValue>([Nullable(new byte[]
	{
		2,
		1,
		1
	})] ConditionalWeakTable<TKey, TValue> obj) where TKey : class where TValue : class
	{
		return true;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00017D55 File Offset: 0x00015F55
	public static bool ClearObject<T>([Nullable(new byte[]
	{
		2,
		1
	})] WeakSet<T> obj) where T : class
	{
		return true;
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00017D58 File Offset: 0x00015F58
	public static bool ClearObject<TKey, [Nullable(2)] TValue>([Nullable(new byte[]
	{
		2,
		1,
		1
	})] WeakMap<TKey, TValue> obj) where TKey : class
	{
		return true;
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00017D5B File Offset: 0x00015F5B
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

	// Token: 0x060003F8 RID: 1016 RVA: 0x00017D7E File Offset: 0x00015F7E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00017D80 File Offset: 0x00015F80
	public static void ResetStaticDefaultValue()
	{
		EntityComponentSystem instance = EntityComponentSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		EntityComponentSystem._instance = null;
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00017D99 File Offset: 0x00015F99
	static EntityComponentSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntityComponentSystem.CreateStaticDefaultValue), new Action(EntityComponentSystem.ResetStaticDefaultValue));
	}

	// Token: 0x040003A9 RID: 937
	public readonly Dictionary<Type, EntityComponent> ComponentTemplates = new Dictionary<Type, EntityComponent>();

	// Token: 0x040003AA RID: 938
	public readonly Stat PerformanceStateClearComponent = Stat.Create("PerformanceStateClearComponent", "", "");

	// Token: 0x040003AB RID: 939
	[Nullable(2)]
	private static EntityComponentSystem _instance;
}
