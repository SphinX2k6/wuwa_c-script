using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02000075 RID: 117
[NullableContext(2)]
[Nullable(0)]
public abstract class Entity : ObjectBase, IGameBudgetManagedObject, IStaticVariableResetter
{
	// Token: 0x06000334 RID: 820 RVA: 0x0001369C File Offset: 0x0001189C
	static Entity()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Entity.CreateStaticDefaultValue), new Action(Entity.ResetStaticDefaultValue));
	}

	// Token: 0x06000335 RID: 821 RVA: 0x000136BB File Offset: 0x000118BB
	public static void CreateStaticDefaultValue()
	{
		Entity._statMap = new Dictionary<string, Stat[]>();
	}

	// Token: 0x06000336 RID: 822 RVA: 0x000136C7 File Offset: 0x000118C7
	public static void ResetStaticDefaultValue()
	{
		Entity._staticGameBudgetConfigInternal = null;
		Entity._statMap = null;
		Entity.GetCreatureIdsHook = null;
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000337 RID: 823 RVA: 0x000136DB File Offset: 0x000118DB
	public virtual bool UsePool { get; }

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000338 RID: 824 RVA: 0x000136E3 File Offset: 0x000118E3
	// (set) Token: 0x06000339 RID: 825 RVA: 0x000136EB File Offset: 0x000118EB
	public bool IsEncloseSpace
	{
		get
		{
			return this.IsEncloseSpaceInternal;
		}
		set
		{
			this.IsEncloseSpaceInternal = value;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x0600033A RID: 826 RVA: 0x000136F4 File Offset: 0x000118F4
	[Nullable(1)]
	protected static TsGameBudgetGroupConfig StaticGameBudgetConfigInternal
	{
		[NullableContext(1)]
		get
		{
			return Entity._staticGameBudgetConfigInternal;
		}
	}

	// Token: 0x0600033B RID: 827 RVA: 0x000136FC File Offset: 0x000118FC
	[NullableContext(1)]
	protected virtual TsGameBudgetGroupConfig StaticGameBudgetConfig()
	{
		if (Entity._staticGameBudgetConfigInternal == null)
		{
			Entity._staticGameBudgetConfigInternal = new TsGameBudgetGroupConfig(FNameUtil.GetDynamicFName("NormalEntity").Value, ESignificanceGroup.Low);
		}
		return Entity.StaticGameBudgetConfigInternal;
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x0600033C RID: 828 RVA: 0x00013732 File Offset: 0x00011932
	public uint GameBudgetManagedToken
	{
		get
		{
			return this.GameBudgetManagedTokenInternal;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600033D RID: 829 RVA: 0x0001373A File Offset: 0x0001193A
	public EExecutedFlag Flag
	{
		get
		{
			return this.FlagInternal;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600033E RID: 830 RVA: 0x00013742 File Offset: 0x00011942
	public TsGameBudgetGroupConfig GameBudgetConfig
	{
		get
		{
			return this.GameBudgetConfigInternal;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x0600033F RID: 831 RVA: 0x0001374A File Offset: 0x0001194A
	public float DistanceWithCamera
	{
		get
		{
			return this.DistanceWithCameraInternal;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000340 RID: 832 RVA: 0x00013752 File Offset: 0x00011952
	[Nullable(new byte[]
	{
		1,
		1,
		1,
		2
	})]
	private static Dictionary<string, Stat[]> StatMap
	{
		[return: Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})]
		get
		{
			return Entity._statMap;
		}
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0001375C File Offset: 0x0001195C
	public Entity(int id, int index) : base(id, index)
	{
	}

	// Token: 0x06000342 RID: 834 RVA: 0x000137C0 File Offset: 0x000119C0
	[return: Nullable(new byte[]
	{
		1,
		2
	})]
	private Stat[] GetStats()
	{
		string name = base.GetType().Name;
		Stat[] array;
		if (!Entity.StatMap.TryGetValue(name, out array))
		{
			array = new Stat[10];
			Stat stat = null;
			array[0] = stat;
			array[1] = stat;
			array[2] = stat;
			array[3] = stat;
			array[4] = stat;
			array[5] = stat;
			array[6] = stat;
			array[7] = stat;
			array[8] = stat;
			array[9] = stat;
			Entity.StatMap[name] = array;
		}
		return array;
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000343 RID: 835 RVA: 0x00013828 File Offset: 0x00011A28
	public bool Active
	{
		get
		{
			return this.DisableHandlesMap.Count == 0 && this.DisableKeysMap.Count == 0;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000344 RID: 836 RVA: 0x00013847 File Offset: 0x00011A47
	public float TimeDilation
	{
		get
		{
			return this.TimeDilationInternal;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000345 RID: 837 RVA: 0x0001384F File Offset: 0x00011A4F
	public bool IsCreate
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.Create) > EExecutedFlag.None;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000346 RID: 838 RVA: 0x0001385C File Offset: 0x00011A5C
	public bool IsStart
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.Start) > EExecutedFlag.None;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000347 RID: 839 RVA: 0x00013869 File Offset: 0x00011A69
	public bool IsInit
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.Activate) > EExecutedFlag.None;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000348 RID: 840 RVA: 0x00013877 File Offset: 0x00011A77
	public bool IsEnd
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.End) > EExecutedFlag.None;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000349 RID: 841 RVA: 0x00013885 File Offset: 0x00011A85
	public bool IsClear
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.Clear) > EExecutedFlag.None;
		}
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00013896 File Offset: 0x00011A96
	public void ResetFlag()
	{
		this.FlagInternal = EExecutedFlag.None;
	}

	// Token: 0x0600034B RID: 843 RVA: 0x000138A0 File Offset: 0x00011AA0
	[NullableContext(0)]
	[return: Nullable(2)]
	public T GetComponent<T>() where T : EntityComponent
	{
		int num = ComponentIndexGetter.IndexOf<T>();
		if (num >= this.ComponentsRegistry.Count || num < 0)
		{
			return default(T);
		}
		return this.ComponentsRegistry[num] as T;
	}

	// Token: 0x0600034C RID: 844 RVA: 0x000138E8 File Offset: 0x00011AE8
	[NullableContext(1)]
	[return: Nullable(2)]
	public EntityComponent GetComponent(Type componentType)
	{
		int byType = ComponentIndexGetter.GetByType(componentType.Name, false);
		if (byType >= this.ComponentsRegistry.Count || byType < 0)
		{
			return null;
		}
		return this.ComponentsRegistry[byType];
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00013924 File Offset: 0x00011B24
	[NullableContext(0)]
	[return: Nullable(2)]
	public unsafe T CheckGetComponent<T>() where T : EntityComponent
	{
		T component = this.GetComponent<T>();
		if (component == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "获取组件失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", typeof(T).Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return component;
	}

	// Token: 0x0600034E RID: 846 RVA: 0x000139D0 File Offset: 0x00011BD0
	[NullableContext(1)]
	[return: Nullable(2)]
	protected unsafe T AddComponent<[Nullable(0)] T>(int? priority = null, [Nullable(2)] IEntityArgs args = null) where T : EntityComponent, IComponentDependency, new()
	{
		if ((this.FlagInternal & EExecutedFlag.Create) != EExecutedFlag.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "实体已创建完成不能再添加组件";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", typeof(T).Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return default(T);
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Entity;
		ELogAuthor author2 = ELogAuthor.LCC;
		string message2 = "添加组件";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", this.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("component", typeof(T).Name);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		if (ComponentIndexGetter.IndexOf<T>() < 0)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "组件没有在EComponent定义";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("component", typeof(T).Name);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return default(T);
		}
		Type[] dependencies = IComponentDependency.Dependencies;
		if (dependencies != null)
		{
			foreach (Type type in dependencies)
			{
				int byType = ComponentIndexGetter.GetByType(type.Name, false);
				if (byType < 0)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Entity;
					ELogAuthor author4 = ELogAuthor.LFJW;
					string message4 = "依赖组件没有在EComponent定义";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("component", type.Name);
					instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
					return default(T);
				}
				if (this.ComponentsRegistry[byType] == null)
				{
					Log instance5 = Log.Instance;
					ELogModule module5 = ELogModule.Entity;
					ELogAuthor author5 = ELogAuthor.LCC;
					string message5 = "添加组件检查依赖失败";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("Id", this.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("component", typeof(T).Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("dependence", type.Name);
					instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 4));
					return default(T);
				}
			}
		}
		Entity entity = EntitySystem.Instance.Get<Entity>(this.Id);
		T t = EntityComponentSystem.Instance.Create<T>(entity, args);
		if (t == null)
		{
			return default(T);
		}
		Type typeFromHandle = typeof(EntityComponent);
		Type type2 = typeof(T);
		while (type2 != null && !(type2 == typeFromHandle) && type2.IsSubclassOf(typeFromHandle))
		{
			int byType2 = ComponentIndexGetter.GetByType(type2.Name, false);
			if (byType2 < 0)
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.Entity;
				ELogAuthor author6 = ELogAuthor.LFJW;
				string message6 = "组件没有在EComponent定义";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("component", type2.Name);
				instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 2));
				return default(T);
			}
			EntityComponent entityComponent = (byType2 < this.ComponentsRegistry.Count) ? this.ComponentsRegistry[byType2] : null;
			if (entityComponent != null)
			{
				Log instance7 = Log.Instance;
				ELogModule module7 = ELogModule.Entity;
				ELogAuthor author7 = ELogAuthor.LCC;
				string message7 = "添加组件失败：组件已存在，请勿重复添加！";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray7 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 1) = new ValueTuple<string, object>("Id", this.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 2) = new ValueTuple<string, object>("AddComponent", type2.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 3) = new ValueTuple<string, object>("ExistComponent", entityComponent.GetType().Name);
				instance7.Error(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray7, 4));
				return default(T);
			}
			while (this.ComponentsRegistry.Count <= byType2)
			{
				this.ComponentsRegistry.Add(null);
			}
			this.ComponentsRegistry[byType2] = t;
			type2 = type2.BaseType;
		}
		this.Components.Add(t);
		this.TickComponentManager.Add(t, priority);
		return t;
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00013F34 File Offset: 0x00012134
	protected unsafe EntityComponent AddComponent([Nullable(1)] Type componentType, int? priority = null, IEntityArgs args = null)
	{
		if ((this.FlagInternal & EExecutedFlag.Create) != EExecutedFlag.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "实体已创建完成不能再添加组件";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", componentType.Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return null;
		}
		if (ComponentIndexGetter.GetByType(componentType.Name, false) < 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "组件没有在EComponent定义";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("component", componentType.Name);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return null;
		}
		PropertyInfo property = componentType.GetProperty("Dependencies", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if (property != null)
		{
			Type[] array = (Type[])property.GetValue(null);
			if (array != null)
			{
				foreach (Type type in array)
				{
					int byType = ComponentIndexGetter.GetByType(type.Name, false);
					if (byType < 0)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.Entity;
						ELogAuthor author3 = ELogAuthor.LFJW;
						string message3 = "依赖组件没有在EComponent定义";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("component", type.Name);
						instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
						return null;
					}
					if (this.ComponentsRegistry[byType] == null)
					{
						Log instance4 = Log.Instance;
						ELogModule module4 = ELogModule.Entity;
						ELogAuthor author4 = ELogAuthor.LCC;
						string message4 = "添加组件检查依赖失败";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Id", this.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("component", componentType.Name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("dependence", type.Name);
						instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 4));
						return null;
					}
				}
			}
		}
		Entity entity = EntitySystem.Instance.Get<Entity>(this.Id);
		EntityComponent entityComponent = EntityComponentSystem.Instance.Create(componentType, entity, args);
		if (entityComponent == null)
		{
			return null;
		}
		Type typeFromHandle = typeof(EntityComponent);
		Type type2 = componentType;
		while (type2 != null && !(type2 == typeFromHandle) && type2.IsSubclassOf(typeFromHandle))
		{
			int byType2 = ComponentIndexGetter.GetByType(type2.Name, false);
			if (byType2 < 0)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.Entity;
				ELogAuthor author5 = ELogAuthor.LFJW;
				string message5 = "组件没有在EComponent定义";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("component", type2.Name);
				instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
				return null;
			}
			EntityComponent entityComponent2 = (byType2 < this.ComponentsRegistry.Count) ? this.ComponentsRegistry[byType2] : null;
			if (entityComponent2 != null)
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.Entity;
				ELogAuthor author6 = ELogAuthor.LCC;
				string message6 = "添加组件失败：组件已存在，请勿重复添加！";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("Id", this.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 2) = new ValueTuple<string, object>("AddComponent", type2.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 3) = new ValueTuple<string, object>("ExistComponent", entityComponent2.GetType().Name);
				instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 4));
				return null;
			}
			while (this.ComponentsRegistry.Count <= byType2)
			{
				this.ComponentsRegistry.Add(null);
			}
			this.ComponentsRegistry[byType2] = entityComponent;
			type2 = type2.BaseType;
		}
		this.Components.Add(entityComponent);
		this.TickComponentManager.Add(entityComponent, priority);
		return entityComponent;
	}

	// Token: 0x06000350 RID: 848 RVA: 0x000143B8 File Offset: 0x000125B8
	public void SetTimeDilation(float timeDilation)
	{
		this.TimeDilationInternal = timeDilation;
		foreach (EntityComponent entityComponent in this.Components)
		{
			entityComponent.SetTimeDilation(timeDilation);
		}
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00014410 File Offset: 0x00012610
	public void ChangeTickInterval(int interval)
	{
		this.TickInterval = interval;
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00014419 File Offset: 0x00012619
	public int GetTickInterval()
	{
		return this.TickInterval;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00014421 File Offset: 0x00012621
	public float GetDeltaSeconds()
	{
		return this.DeltaSeconds;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x0001442C File Offset: 0x0001262C
	public unsafe void RegisterToGameBudgetController(AActor actor)
	{
		if (!GameBudgetInterfaceController.IsOpen)
		{
			return;
		}
		if (this.GameBudgetConfigInternal == null)
		{
			this.GameBudgetConfigInternal = this.StaticGameBudgetConfig();
			bool afterTick = false;
			foreach (EntityComponent entityComponent in this.Components)
			{
				if (new Action<bool>(entityComponent.OnEntityWasRecentlyRenderedOnScreenChange) != null)
				{
					if (this.OnWasRecentlyRenderComponents == null)
					{
						this.OnWasRecentlyRenderComponents = new List<EntityComponent>();
					}
					this.OnWasRecentlyRenderComponents.Add(entityComponent);
				}
				if (new Action<bool>(entityComponent.OnEntityBudgetTickEnableChange) != null)
				{
					if (this.OnBudgetTickEnableChangeComponents == null)
					{
						this.OnBudgetTickEnableChangeComponents = new List<EntityComponent>();
					}
					this.OnBudgetTickEnableChangeComponents.Add(entityComponent);
				}
				if (entityComponent.NeedAfterTick)
				{
					afterTick = true;
				}
			}
			if (!this.GameBudgetGCHandle.IsAllocated)
			{
				this.GameBudgetGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);
			}
			this.GameBudgetManagedTokenInternal = GameBudgetInterfaceController.Instance.RegisterTick(this.GameBudgetConfigInternal.GroupName, this.GameBudgetConfigInternal.SignificanceGroup, this, actor, afterTick, this.OnBudgetTickEnableChangeComponents != null, this.OnWasRecentlyRenderComponents != null, true);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Entity;
		ELogAuthor author = ELogAuthor.WY;
		string message = "Entity注册到时间预算管理器中失败，Token已经存在";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GameBudgetManagedToken", this.GameBudgetManagedTokenInternal);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06000355 RID: 853 RVA: 0x000145C0 File Offset: 0x000127C0
	public void UnregisterFromGameBudgetController()
	{
		if (!GameBudgetInterfaceController.IsOpen)
		{
			return;
		}
		if (this.GameBudgetManagedTokenInternal != 0U)
		{
			this.GameBudgetManagedTokenInternal = 0U;
			this.GameBudgetConfigInternal = null;
			GameBudgetInterfaceController.Instance.UnregisterTick(this);
		}
		if (this.GameBudgetGCHandle.IsAllocated)
		{
			this.GameBudgetGCHandle.Free();
		}
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00014610 File Offset: 0x00012810
	public unsafe bool Create(IEntityArgs args = null)
	{
		if (Stat.Enable)
		{
			Stat[] stats = this.GetStats();
			this.CreateStat = stats[0];
			this.InitDataStat = stats[1];
			this.InitStat = stats[2];
			this.ClearStat = stats[3];
			this.StartStat = stats[4];
			this.EndStat = stats[5];
			this.ActivateStat = stats[6];
			this.PostActivateStat = stats[7];
			this.TickStat = stats[8];
			this.AfterTickStat = stats[9];
		}
		try
		{
			if (!this.OnCreate(args))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "Entity创建失败，请检查前面组件的报错";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", base.GetType().Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
		}
		catch (Exception ex) when (1)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "Entity创建执行异常";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		this.FlagInternal = EExecutedFlag.Create;
		this.TickComponentManager.Sort();
		return true;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00014790 File Offset: 0x00012990
	public unsafe virtual bool Respawn(IEntityArgs args = null)
	{
		try
		{
			this.OnRespawn(args);
		}
		catch (Exception ex) when (1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "Entity执行Respawn异常";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		using (List<EntityComponent>.Enumerator enumerator = this.Components.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.Respawn(this, args))
				{
					return false;
				}
			}
		}
		this.FlagInternal = EExecutedFlag.Create;
		return true;
	}

	// Token: 0x06000358 RID: 856 RVA: 0x000148A8 File Offset: 0x00012AA8
	protected virtual bool OnRespawn(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x000148AC File Offset: 0x00012AAC
	public unsafe bool InitData(IEntityArgs args = null)
	{
		if ((this.FlagInternal & EExecutedFlag.InitData) != EExecutedFlag.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "Entity重复执行InitData";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		try
		{
			using (List<EntityComponent>.Enumerator enumerator = this.Components.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.InitData(args))
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Entity;
						ELogAuthor author2 = ELogAuthor.LCC;
						string message2 = "Entity初始化失败，请检查前面组件的报错";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", base.GetType().Name);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return false;
					}
				}
			}
			if (!this.OnInitData(args))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Entity;
				ELogAuthor author3 = ELogAuthor.LCC;
				string message3 = "Entity初始化失败，请检查前面的报错";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entity", base.GetType().Name);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
		}
		catch (Exception ex) when (1)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.LCC;
			string message4 = "Entity执行InitData异常";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance4.ErrorWithStack(module4, author4, message4, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		this.FlagInternal |= EExecutedFlag.InitData;
		return true;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00014AB0 File Offset: 0x00012CB0
	protected virtual bool OnInitData(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00014AB4 File Offset: 0x00012CB4
	public unsafe bool Init()
	{
		if ((this.FlagInternal & EExecutedFlag.Init) != EExecutedFlag.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "Entity重复执行Init";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		UKuroJsModelFunctionLibrary.AddEntity(this.Id);
		try
		{
			if (!this.OnInit())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author2 = ELogAuthor.LCC;
				string message2 = "Entity初始化失败，请检查前面组件的报错";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", base.GetType().Name);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
		}
		catch (Exception ex) when (1)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LCC;
			string message3 = "Entity初始化执行异常";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance3.ErrorWithStack(module3, author3, message3, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		using (List<EntityComponent>.Enumerator enumerator = this.Components.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.Init())
				{
					return false;
				}
			}
		}
		this.FlagInternal |= EExecutedFlag.Init;
		return true;
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00014C88 File Offset: 0x00012E88
	public unsafe bool Clear()
	{
		bool flag = false;
		for (int i = this.Components.Count - 1; i >= 0; i--)
		{
			if (!EntityComponentSystem.Instance.Destroy<EntityComponent>(this, this.Components[i]))
			{
				flag = true;
			}
		}
		if (flag)
		{
			return false;
		}
		try
		{
			if (!this.OnClear())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "清理失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", base.GetType().Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
		}
		catch (Exception ex) when (1)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "Entity清理执行异常";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		this.ClearInternal();
		this.FlagInternal |= EExecutedFlag.Clear;
		return true;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00014DE0 File Offset: 0x00012FE0
	private void ClearInternal()
	{
		this.DisableCount = 0;
		this.TickInterval = 0;
		this.TimeDilationInternal = 1f;
		this.IsEncloseSpaceInternal = false;
		this.TickComponentManager.Clear();
		this.DisableHandlesMap.Clear();
		this.DisableKeysMap.Clear();
		this.PendingEnable = null;
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00014E38 File Offset: 0x00013038
	public unsafe bool Start()
	{
		if ((this.FlagInternal & EExecutedFlag.Start) != EExecutedFlag.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "Entity重复执行Start";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		try
		{
			if (!this.OnStart())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author2 = ELogAuthor.LCC;
				string message2 = "Entity开始失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", base.GetType().Name);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
		}
		catch (Exception ex) when (1)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LCC;
			string message3 = "Entity开始执行异常";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance3.ErrorWithStack(module3, author3, message3, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		using (List<EntityComponent>.Enumerator enumerator = this.Components.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.Start())
				{
					return false;
				}
			}
		}
		this.FlagInternal |= EExecutedFlag.Start;
		return true;
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00015004 File Offset: 0x00013204
	public void Activate()
	{
		foreach (EntityComponent entityComponent in this.Components)
		{
			entityComponent.Activate();
		}
		this.FlagInternal |= EExecutedFlag.Activate;
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00015064 File Offset: 0x00013264
	public unsafe void PostActivate()
	{
		if ((this.FlagInternal & EExecutedFlag.Activate) == EExecutedFlag.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "Entity未执行Activate就执行PostActivate";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		Func<Entity, ValueTuple<long?, int?>> getCreatureIdsHook = Entity.GetCreatureIdsHook;
		ValueTuple<long?, int?>? valueTuple = (getCreatureIdsHook != null) ? new ValueTuple<long?, int?>?(getCreatureIdsHook(this)) : null;
		if (valueTuple != null)
		{
			bool flag = valueTuple.GetValueOrDefault().Item1 != null;
		}
		foreach (EntityComponent entityComponent in this.Components)
		{
			entityComponent.PostActivate();
		}
		this.FlagInternal |= EExecutedFlag.PostActivate;
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00015178 File Offset: 0x00013378
	public unsafe bool End()
	{
		if ((this.FlagInternal & EExecutedFlag.Start) == EExecutedFlag.None)
		{
			return true;
		}
		bool flag = false;
		for (int i = this.Components.Count - 1; i >= 0; i--)
		{
			if (!this.Components[i].End())
			{
				flag = true;
			}
		}
		if (flag)
		{
			return false;
		}
		try
		{
			if (!this.OnEnd())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "Entity结束失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", base.GetType().Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
		}
		catch (Exception ex) when (1)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "Entity结束执行异常";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		this.FlagInternal |= EExecutedFlag.End;
		UKuroJsModelFunctionLibrary.RemoveEntity(this.Id);
		return true;
	}

	// Token: 0x06000362 RID: 866 RVA: 0x000152D8 File Offset: 0x000134D8
	[NullableContext(1)]
	public unsafe bool Enable(int handle, string reason)
	{
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "Entity.Enable";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		if (!this.DisableHandlesMap.ContainsKey(handle))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "Entity实体激活失败句柄不存在";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Handle", handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Reason", reason);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			return false;
		}
		this.DisableHandlesMap.Remove(handle);
		this.RefreshComponentsEnable(reason);
		return true;
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00015454 File Offset: 0x00013654
	[NullableContext(1)]
	public unsafe int Disable(string reason)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "Disable的Reason不能使用undefined";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", base.GetType().Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		else if (reason.Length < 4)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "Disable的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Entity", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		int num = this.DisableCount + 1;
		this.DisableCount = num;
		int num2 = num;
		this.DisableHandlesMap[num2] = reason;
		this.RefreshComponentsEnable(reason);
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "Entity.Disable";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Handle", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Reason", reason);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		}
		return num2;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x0001561C File Offset: 0x0001381C
	public unsafe void EnableByKey(EEntityDisableKey key, bool removeAll = true)
	{
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "Entity.EnableByKey";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("RemoveAll", removeAll);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		if (key != EEntityDisableKey.SetEntityEnable)
		{
			this.EnableByKey(EEntityDisableKey.SetEntityEnable, true);
		}
		int num;
		if (!this.DisableKeysMap.TryGetValue(key, out num) || num <= 0)
		{
			if (num != 0)
			{
				this.DisableKeysMap.Remove(key);
			}
			return;
		}
		if (!removeAll && num > 1)
		{
			this.DisableKeysMap[key] = num - 1;
		}
		else
		{
			this.DisableKeysMap.Remove(key);
		}
		this.RefreshComponentsEnable(key);
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0001573B File Offset: 0x0001393B
	public bool HasDisableKey(EEntityDisableKey key)
	{
		return this.DisableKeysMap.ContainsKey(key);
	}

	// Token: 0x06000366 RID: 870 RVA: 0x0001574C File Offset: 0x0001394C
	public unsafe void DisableByKey(EEntityDisableKey key, bool noDuplicate = true)
	{
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "Entity.DisableByKey";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("NoDuplicate", noDuplicate);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		int num;
		this.DisableKeysMap.TryGetValue(key, out num);
		num = Math.Max(0, num);
		if (noDuplicate && num > 0)
		{
			return;
		}
		this.DisableKeysMap[key] = num + 1;
		this.RefreshComponentsEnable(key);
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00015844 File Offset: 0x00013A44
	[NullableContext(1)]
	private void RefreshComponentsEnable(object reason)
	{
		if (!this.IsStart)
		{
			this.PendingEnable = reason;
			return;
		}
		for (int i = this.Components.Count - 1; i >= 0; i--)
		{
			this.Components[i].RefreshEnable(reason.ToString());
		}
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00015890 File Offset: 0x00013A90
	public void ExecutePendingEnableProcess()
	{
		if (!this.IsStart || this.PendingEnable == null)
		{
			return;
		}
		for (int i = this.Components.Count - 1; i >= 0; i--)
		{
			this.Components[i].RefreshEnable(this.PendingEnable.ToString());
		}
		this.PendingEnable = null;
	}

	// Token: 0x06000369 RID: 873 RVA: 0x000158E9 File Offset: 0x00013AE9
	public void ForceTick(float delta)
	{
		if (!this.Active)
		{
			return;
		}
		this.TickComponentManager.ForceTick(delta * this.TimeDilationInternal);
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00015908 File Offset: 0x00013B08
	public void ScheduledTick(float deltaSeconds, int deltaFrames, float distance)
	{
		this.DeltaSeconds = deltaSeconds;
		this.TickInterval = deltaFrames;
		this.LastTickFrame = Time.Instance.Frame;
		if (!MathUtils.Instance.IsNearlyEqual((double)this.DistanceWithCameraInternal, (double)distance, null))
		{
			this.DistanceWithCameraInternal = distance;
			if (!EntitySystemHelper.Instance.IsSortDirty)
			{
				EntitySystemHelper.Instance.IsSortDirty = true;
			}
		}
		if (base.Valid && this.IsInit)
		{
			this.Tick(deltaSeconds * 1000f);
		}
	}

	// Token: 0x0600036B RID: 875 RVA: 0x0001598C File Offset: 0x00013B8C
	public virtual void Tick(float delta)
	{
		if (!this.Active)
		{
			this.TickComponentManager.ClearDelta();
			return;
		}
		this.TickComponentManager.Tick(this.TickInterval, delta * this.TimeDilationInternal);
	}

	// Token: 0x0600036C RID: 876 RVA: 0x000159BB File Offset: 0x00013BBB
	public void ForceAfterTick(float delta)
	{
		if (!this.Active)
		{
			return;
		}
		this.TickComponentManager.ForceAfterTick(delta * this.TimeDilationInternal);
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x0600036D RID: 877 RVA: 0x000159D9 File Offset: 0x00013BD9
	public bool HasScheduledAfterTick
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600036E RID: 878 RVA: 0x000159DC File Offset: 0x00013BDC
	public void ScheduledAfterTick(float deltaSeconds, int deltaFrames, float distance)
	{
		if (base.Valid && this.IsInit)
		{
			this.AfterTick(deltaSeconds * 1000f);
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600036F RID: 879 RVA: 0x000159FB File Offset: 0x00013BFB
	public bool HasOnEnabledChange
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00015A00 File Offset: 0x00013C00
	public void OnEnabledChange(bool enable, float distance)
	{
		if (this.OnBudgetTickEnableChangeComponents != null)
		{
			foreach (EntityComponent entityComponent in this.OnBudgetTickEnableChangeComponents)
			{
				entityComponent.OnEntityBudgetTickEnableChange(enable);
			}
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000371 RID: 881 RVA: 0x00015A5C File Offset: 0x00013C5C
	public bool HasOnWasRecentlyRenderedOnScreenChange
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00015A60 File Offset: 0x00013C60
	public void OnWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
		if (this.OnWasRecentlyRenderComponents != null)
		{
			foreach (EntityComponent entityComponent in this.OnWasRecentlyRenderComponents)
			{
				entityComponent.OnEntityWasRecentlyRenderedOnScreenChange(wasRecentlyRenderedOnScreen);
			}
		}
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00015ABC File Offset: 0x00013CBC
	public GCHandle GetGCHandle()
	{
		return this.GameBudgetGCHandle;
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00015AC4 File Offset: 0x00013CC4
	public void AfterTick(float delta)
	{
		if (!this.Active)
		{
			this.TickComponentManager.ClearDelta();
			return;
		}
		this.TickComponentManager.AfterTick(this.TickInterval, delta * this.TimeDilationInternal);
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00015AF3 File Offset: 0x00013CF3
	protected virtual bool OnCreate(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00015AF6 File Offset: 0x00013CF6
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00015AF9 File Offset: 0x00013CF9
	protected virtual bool OnDeinit()
	{
		return true;
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00015AFC File Offset: 0x00013CFC
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00015AFF File Offset: 0x00013CFF
	protected virtual bool OnStart()
	{
		return true;
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00015B02 File Offset: 0x00013D02
	protected virtual bool OnEnd()
	{
		return true;
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00015B08 File Offset: 0x00013D08
	[NullableContext(1)]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 3);
		defaultInterpolatedStringHandler.AppendLiteral("[object ");
		defaultInterpolatedStringHandler.AppendFormatted(base.GetType().Name);
		defaultInterpolatedStringHandler.AppendLiteral("(Id=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Id);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		defaultInterpolatedStringHandler.AppendFormatted(base.Valid ? "" : "(D)");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00015B84 File Offset: 0x00013D84
	[NullableContext(1)]
	public string DumpDisableInfo()
	{
		List<string> list = new List<string>();
		string value = "";
		foreach (KeyValuePair<int, string> keyValuePair in this.DisableHandlesMap)
		{
			List<string> list2 = list;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("{Handle:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Key);
			defaultInterpolatedStringHandler.AppendLiteral(",Reason:");
			defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Value);
			defaultInterpolatedStringHandler.AppendLiteral("}");
			list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			value = " ";
		}
		return string.Join("", list);
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00015C4C File Offset: 0x00013E4C
	[NullableContext(1)]
	public string DumpComponentsDisableInfo()
	{
		List<string> list = new List<string>();
		string str = "";
		foreach (EntityComponent entityComponent in this.Components)
		{
			string text = entityComponent.DumpDisableInfo();
			if (!string.IsNullOrEmpty(text))
			{
				list.Add(str + text);
				str = " ";
			}
		}
		return string.Join("", list);
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00015CD0 File Offset: 0x00013ED0
	public static bool operator !(Entity entity)
	{
		return entity == null || !entity.Valid;
	}

	// Token: 0x04000355 RID: 853
	[TupleElementNames(new string[]
	{
		"CreatureDataId",
		"PbDataId"
	})]
	[Nullable(new byte[]
	{
		1,
		1,
		0
	})]
	public static Func<Entity, ValueTuple<long?, int?>> GetCreatureIdsHook;

	// Token: 0x04000356 RID: 854
	public const int DISABLE_REASON_LENGTH_LIMIT = 4;

	// Token: 0x04000357 RID: 855
	public const int MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x04000359 RID: 857
	private Stat CreateStat;

	// Token: 0x0400035A RID: 858
	private Stat InitDataStat;

	// Token: 0x0400035B RID: 859
	private Stat InitStat;

	// Token: 0x0400035C RID: 860
	protected Stat InitStatTdType;

	// Token: 0x0400035D RID: 861
	private Stat ClearStat;

	// Token: 0x0400035E RID: 862
	protected Stat ClearStatTdType;

	// Token: 0x0400035F RID: 863
	private Stat StartStat;

	// Token: 0x04000360 RID: 864
	protected Stat StartStatTdType;

	// Token: 0x04000361 RID: 865
	private Stat EndStat;

	// Token: 0x04000362 RID: 866
	protected Stat EndStatTdType;

	// Token: 0x04000363 RID: 867
	private Stat ActivateStat;

	// Token: 0x04000364 RID: 868
	private Stat PostActivateStat;

	// Token: 0x04000365 RID: 869
	protected Stat ActivateStatTdType;

	// Token: 0x04000366 RID: 870
	private Stat TickStat;

	// Token: 0x04000367 RID: 871
	protected Stat TickStatTdType;

	// Token: 0x04000368 RID: 872
	private Stat AfterTickStat;

	// Token: 0x04000369 RID: 873
	protected Stat AfterTickStatTdType;

	// Token: 0x0400036A RID: 874
	private EExecutedFlag FlagInternal;

	// Token: 0x0400036B RID: 875
	[Nullable(1)]
	public List<EntityComponent> Components = new List<EntityComponent>();

	// Token: 0x0400036C RID: 876
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<EntityComponent> OnWasRecentlyRenderComponents;

	// Token: 0x0400036D RID: 877
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<EntityComponent> OnBudgetTickEnableChangeComponents;

	// Token: 0x0400036E RID: 878
	[Nullable(1)]
	public TickComponentManager TickComponentManager = new TickComponentManager();

	// Token: 0x0400036F RID: 879
	private int DisableCount;

	// Token: 0x04000370 RID: 880
	private float DeltaSeconds;

	// Token: 0x04000371 RID: 881
	private int TickInterval;

	// Token: 0x04000372 RID: 882
	public int LastTickFrame;

	// Token: 0x04000373 RID: 883
	private bool IsEncloseSpaceInternal;

	// Token: 0x04000374 RID: 884
	private float TimeDilationInternal = 1f;

	// Token: 0x04000375 RID: 885
	private static TsGameBudgetGroupConfig _staticGameBudgetConfigInternal;

	// Token: 0x04000376 RID: 886
	private uint GameBudgetManagedTokenInternal;

	// Token: 0x04000377 RID: 887
	private TsGameBudgetGroupConfig GameBudgetConfigInternal;

	// Token: 0x04000378 RID: 888
	private float DistanceWithCameraInternal = -1f;

	// Token: 0x04000379 RID: 889
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly List<EntityComponent> ComponentsRegistry = new List<EntityComponent>();

	// Token: 0x0400037A RID: 890
	[Nullable(1)]
	private readonly Dictionary<int, string> DisableHandlesMap = new Dictionary<int, string>();

	// Token: 0x0400037B RID: 891
	[Nullable(1)]
	private readonly Dictionary<EEntityDisableKey, int> DisableKeysMap = new Dictionary<EEntityDisableKey, int>();

	// Token: 0x0400037C RID: 892
	[Nullable(1)]
	private object PendingEnable;

	// Token: 0x0400037D RID: 893
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		2
	})]
	private static Dictionary<string, Stat[]> _statMap;

	// Token: 0x0400037E RID: 894
	private GCHandle GameBudgetGCHandle;
}
