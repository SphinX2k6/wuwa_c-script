using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000076 RID: 118
[NullableContext(2)]
[Nullable(0)]
public abstract class Entity : ObjectBase, IGameBudgetManagedObject, IStaticVariableResetter
{
	// Token: 0x0600036D RID: 877 RVA: 0x000143F8 File Offset: 0x000125F8
	static Entity()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Entity.CreateStaticDefaultValue), new Action(Entity.ResetStaticDefaultValue));
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00014417 File Offset: 0x00012617
	public static void CreateStaticDefaultValue()
	{
		Entity._statMap = new Dictionary<string, Stat[]>();
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00014423 File Offset: 0x00012623
	public static void ResetStaticDefaultValue()
	{
		Entity._staticGameBudgetConfigInternal = null;
		Entity._statMap = null;
		Entity.GetCreatureIdsHook = null;
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000370 RID: 880 RVA: 0x00014437 File Offset: 0x00012637
	public virtual bool UsePool { get; }

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000371 RID: 881 RVA: 0x0001443F File Offset: 0x0001263F
	// (set) Token: 0x06000372 RID: 882 RVA: 0x00014447 File Offset: 0x00012647
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

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000373 RID: 883 RVA: 0x00014450 File Offset: 0x00012650
	[Nullable(1)]
	protected static TsGameBudgetGroupConfig StaticGameBudgetConfigInternal
	{
		[NullableContext(1)]
		get
		{
			return Entity._staticGameBudgetConfigInternal;
		}
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00014458 File Offset: 0x00012658
	[NullableContext(1)]
	protected virtual TsGameBudgetGroupConfig StaticGameBudgetConfig()
	{
		if (Entity._staticGameBudgetConfigInternal == null)
		{
			Entity._staticGameBudgetConfigInternal = new TsGameBudgetGroupConfig(FNameUtil.GetDynamicFName("NormalEntity").Value, ESignificanceGroup.Low);
		}
		return Entity.StaticGameBudgetConfigInternal;
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000375 RID: 885 RVA: 0x0001448E File Offset: 0x0001268E
	public uint GameBudgetManagedToken
	{
		get
		{
			return this.GameBudgetManagedTokenInternal;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000376 RID: 886 RVA: 0x00014496 File Offset: 0x00012696
	public EExecutedFlag Flag
	{
		get
		{
			return this.FlagInternal;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000377 RID: 887 RVA: 0x0001449E File Offset: 0x0001269E
	public TsGameBudgetGroupConfig GameBudgetConfig
	{
		get
		{
			return this.GameBudgetConfigInternal;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000378 RID: 888 RVA: 0x000144A6 File Offset: 0x000126A6
	public float DistanceWithCamera
	{
		get
		{
			return this.DistanceWithCameraInternal;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000379 RID: 889 RVA: 0x000144AE File Offset: 0x000126AE
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

	// Token: 0x0600037A RID: 890 RVA: 0x000144B8 File Offset: 0x000126B8
	public Entity(int id, int index) : base(id, index)
	{
	}

	// Token: 0x0600037B RID: 891 RVA: 0x0001451C File Offset: 0x0001271C
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

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x0600037C RID: 892 RVA: 0x00014584 File Offset: 0x00012784
	public bool Active
	{
		get
		{
			return this.DisableHandlesMap.Count == 0 && this.DisableKeysMap.Count == 0;
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600037D RID: 893 RVA: 0x000145A3 File Offset: 0x000127A3
	public float TimeDilation
	{
		get
		{
			return this.TimeDilationInternal;
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600037E RID: 894 RVA: 0x000145AB File Offset: 0x000127AB
	public bool IsCreate
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.Create) > EExecutedFlag.None;
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x0600037F RID: 895 RVA: 0x000145B8 File Offset: 0x000127B8
	public bool IsStart
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.Start) > EExecutedFlag.None;
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000380 RID: 896 RVA: 0x000145C5 File Offset: 0x000127C5
	public bool IsInit
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.Activate) > EExecutedFlag.None;
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x06000381 RID: 897 RVA: 0x000145D3 File Offset: 0x000127D3
	public bool IsEnd
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.End) > EExecutedFlag.None;
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x06000382 RID: 898 RVA: 0x000145E1 File Offset: 0x000127E1
	public bool IsClear
	{
		get
		{
			return (this.FlagInternal & EExecutedFlag.Clear) > EExecutedFlag.None;
		}
	}

	// Token: 0x06000383 RID: 899 RVA: 0x000145F2 File Offset: 0x000127F2
	public void ResetFlag()
	{
		this.FlagInternal = EExecutedFlag.None;
	}

	// Token: 0x06000384 RID: 900 RVA: 0x000145FC File Offset: 0x000127FC
	[NullableContext(0)]
	[return: Nullable(2)]
	public T GetComponent<T>() where T : EntityComponent
	{
		int index = ComponentIndexGetter<T>.Index;
		if (index >= this.ComponentsRegistry.Count || index < 0)
		{
			return default(T);
		}
		return this.ComponentsRegistry[index] as T;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00014644 File Offset: 0x00012844
	[NullableContext(1)]
	[return: Nullable(2)]
	public EntityComponent GetComponent(Type componentType)
	{
		int componentIndex = EntityComponentConstant.GetComponentIndex(componentType);
		if (componentIndex >= this.ComponentsRegistry.Count || componentIndex < 0)
		{
			return null;
		}
		return this.ComponentsRegistry[componentIndex];
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00014678 File Offset: 0x00012878
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

	// Token: 0x06000387 RID: 903 RVA: 0x00014724 File Offset: 0x00012924
	protected unsafe T AddComponent<[Nullable(0)] T>(int? priority = null, IEntityArgs args = null) where T : EntityComponent, new()
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
		if (ComponentIndexGetter<T>.Index < 0)
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
		Type[] componentDependencies = EntityComponentConstant.GetComponentDependencies(typeof(T));
		if (componentDependencies != null)
		{
			foreach (Type type in componentDependencies)
			{
				int componentIndex = EntityComponentConstant.GetComponentIndex(type);
				if (componentIndex < 0)
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
				if (this.ComponentsRegistry[componentIndex] == null)
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
		Entity entity = EntitySystem.Instance.Get(this.Id);
		T t = EntityComponentSystem.Instance.Create<T>(entity, args);
		if (t == null)
		{
			return default(T);
		}
		Type typeFromHandle = typeof(EntityComponent);
		Type type2 = typeof(T);
		while (type2 != null && !(type2 == typeFromHandle) && type2.IsSubclassOf(typeFromHandle))
		{
			int componentIndex2 = EntityComponentConstant.GetComponentIndex(type2);
			if (componentIndex2 < 0)
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
			EntityComponent entityComponent = (componentIndex2 < this.ComponentsRegistry.Count) ? this.ComponentsRegistry[componentIndex2] : null;
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
			while (this.ComponentsRegistry.Count <= componentIndex2)
			{
				this.ComponentsRegistry.Add(null);
			}
			this.ComponentsRegistry[componentIndex2] = t;
			type2 = type2.BaseType;
		}
		this.Components.Add(t);
		this.TickComponentManager.Add(t, priority);
		return t;
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00014C80 File Offset: 0x00012E80
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
		if (EntityComponentConstant.GetComponentIndex(componentType) < 0)
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
		Type[] componentDependencies = EntityComponentConstant.GetComponentDependencies(componentType);
		if (componentDependencies != null)
		{
			foreach (Type type in componentDependencies)
			{
				int componentIndex = EntityComponentConstant.GetComponentIndex(type);
				if (componentIndex < 0)
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
				if (this.ComponentsRegistry[componentIndex] == null)
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
		Entity entity = EntitySystem.Instance.Get(this.Id);
		EntityComponent entityComponent = EntityComponentSystem.Instance.Create(componentType, entity, args);
		if (entityComponent == null)
		{
			return null;
		}
		Type typeFromHandle = typeof(EntityComponent);
		Type type2 = componentType;
		while (type2 != null && !(type2 == typeFromHandle) && type2.IsSubclassOf(typeFromHandle))
		{
			int componentIndex2 = EntityComponentConstant.GetComponentIndex(type2);
			if (componentIndex2 < 0)
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
			EntityComponent entityComponent2 = (componentIndex2 < this.ComponentsRegistry.Count) ? this.ComponentsRegistry[componentIndex2] : null;
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
			while (this.ComponentsRegistry.Count <= componentIndex2)
			{
				this.ComponentsRegistry.Add(null);
			}
			this.ComponentsRegistry[componentIndex2] = entityComponent;
			type2 = type2.BaseType;
		}
		this.Components.Add(entityComponent);
		this.TickComponentManager.Add(entityComponent, priority);
		return entityComponent;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000150D0 File Offset: 0x000132D0
	public void SetTimeDilation(float timeDilation)
	{
		this.TimeDilationInternal = timeDilation;
		foreach (EntityComponent entityComponent in this.Components)
		{
			entityComponent.SetTimeDilation(timeDilation);
		}
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00015128 File Offset: 0x00013328
	public void ChangeTickInterval(int interval)
	{
		this.TickInterval = interval;
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00015131 File Offset: 0x00013331
	public int GetTickInterval()
	{
		return this.TickInterval;
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00015139 File Offset: 0x00013339
	public float GetDeltaSeconds()
	{
		return this.DeltaSeconds;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00015144 File Offset: 0x00013344
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
				if (entityComponent.NeedEntityWasRecentlyRenderedOnScreenChangeInternal)
				{
					if (this.OnWasRecentlyRenderComponents == null)
					{
						this.OnWasRecentlyRenderComponents = new List<EntityComponent>();
					}
					this.OnWasRecentlyRenderComponents.Add(entityComponent);
				}
				if (entityComponent.NeedEntityBudgetTickEnableChangeInternal)
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

	// Token: 0x0600038E RID: 910 RVA: 0x000152C8 File Offset: 0x000134C8
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

	// Token: 0x0600038F RID: 911 RVA: 0x00015318 File Offset: 0x00013518
	public unsafe bool Create(IEntityArgs args = null)
	{
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

	// Token: 0x06000390 RID: 912 RVA: 0x00015430 File Offset: 0x00013630
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

	// Token: 0x06000391 RID: 913 RVA: 0x00015548 File Offset: 0x00013748
	protected virtual bool OnRespawn(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0001554C File Offset: 0x0001374C
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

	// Token: 0x06000393 RID: 915 RVA: 0x00015750 File Offset: 0x00013950
	protected virtual bool OnInitData(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00015754 File Offset: 0x00013954
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

	// Token: 0x06000395 RID: 917 RVA: 0x00015928 File Offset: 0x00013B28
	public unsafe bool Clear()
	{
		bool flag = false;
		for (int i = this.Components.Count - 1; i >= 0; i--)
		{
			if (!EntityComponentSystem.Instance.Destroy(this, this.Components[i]))
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

	// Token: 0x06000396 RID: 918 RVA: 0x00015A80 File Offset: 0x00013C80
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

	// Token: 0x06000397 RID: 919 RVA: 0x00015AD8 File Offset: 0x00013CD8
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

	// Token: 0x06000398 RID: 920 RVA: 0x00015CA4 File Offset: 0x00013EA4
	public void Activate()
	{
		foreach (EntityComponent entityComponent in this.Components)
		{
			entityComponent.Activate();
		}
		this.FlagInternal |= EExecutedFlag.Activate;
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00015D04 File Offset: 0x00013F04
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

	// Token: 0x0600039A RID: 922 RVA: 0x00015E18 File Offset: 0x00014018
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

	// Token: 0x0600039B RID: 923 RVA: 0x00015F78 File Offset: 0x00014178
	[NullableContext(1)]
	public unsafe bool Enable(int handle, string reason)
	{
		if (!this.DisableHandlesMap.Remove(handle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "Entity实体激活失败句柄不存在";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return false;
		}
		this.RefreshComponentsEnable(reason);
		return true;
	}

	// Token: 0x0600039C RID: 924 RVA: 0x0001603C File Offset: 0x0001423C
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
		return num2;
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00016158 File Offset: 0x00014358
	public void EnableByKey(EEntityDisableKey key, bool removeAll = true)
	{
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

	// Token: 0x0600039E RID: 926 RVA: 0x000161C7 File Offset: 0x000143C7
	public bool HasDisableKey(EEntityDisableKey key)
	{
		return this.DisableKeysMap.ContainsKey(key);
	}

	// Token: 0x0600039F RID: 927 RVA: 0x000161D8 File Offset: 0x000143D8
	public void DisableByKey(EEntityDisableKey key, bool noDuplicate = true)
	{
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

	// Token: 0x060003A0 RID: 928 RVA: 0x00016220 File Offset: 0x00014420
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

	// Token: 0x060003A1 RID: 929 RVA: 0x0001626C File Offset: 0x0001446C
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

	// Token: 0x060003A2 RID: 930 RVA: 0x000162C5 File Offset: 0x000144C5
	public void ForceTick(float delta)
	{
		if (!this.Active)
		{
			return;
		}
		this.TickComponentManager.ForceTick(delta * this.TimeDilationInternal);
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x000162E4 File Offset: 0x000144E4
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

	// Token: 0x060003A4 RID: 932 RVA: 0x00016368 File Offset: 0x00014568
	public virtual void Tick(float delta)
	{
		if (!this.Active)
		{
			this.TickComponentManager.ClearDelta();
			return;
		}
		this.TickComponentManager.Tick(this.TickInterval, delta * this.TimeDilationInternal);
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00016397 File Offset: 0x00014597
	public void ForceAfterTick(float delta)
	{
		if (!this.Active)
		{
			return;
		}
		this.TickComponentManager.ForceAfterTick(delta * this.TimeDilationInternal);
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060003A6 RID: 934 RVA: 0x000163B5 File Offset: 0x000145B5
	public bool HasScheduledAfterTick
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x000163B8 File Offset: 0x000145B8
	public void ScheduledAfterTick(float deltaSeconds, int deltaFrames, float distance)
	{
		if (base.Valid && this.IsInit)
		{
			this.AfterTick(deltaSeconds * 1000f);
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060003A8 RID: 936 RVA: 0x000163D7 File Offset: 0x000145D7
	public bool HasOnEnabledChange
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x000163DC File Offset: 0x000145DC
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

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060003AA RID: 938 RVA: 0x00016438 File Offset: 0x00014638
	public bool HasOnWasRecentlyRenderedOnScreenChange
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060003AB RID: 939 RVA: 0x0001643C File Offset: 0x0001463C
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

	// Token: 0x060003AC RID: 940 RVA: 0x00016498 File Offset: 0x00014698
	public GCHandle GetGCHandle()
	{
		return this.GameBudgetGCHandle;
	}

	// Token: 0x060003AD RID: 941 RVA: 0x000164A0 File Offset: 0x000146A0
	public void AfterTick(float delta)
	{
		if (!this.Active)
		{
			this.TickComponentManager.ClearDelta();
			return;
		}
		this.TickComponentManager.AfterTick(this.TickInterval, delta * this.TimeDilationInternal);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x000164CF File Offset: 0x000146CF
	protected virtual bool OnCreate(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x000164D2 File Offset: 0x000146D2
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x000164D5 File Offset: 0x000146D5
	protected virtual bool OnDeinit()
	{
		return true;
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x000164D8 File Offset: 0x000146D8
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x000164DB File Offset: 0x000146DB
	protected virtual bool OnStart()
	{
		return true;
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x000164DE File Offset: 0x000146DE
	protected virtual bool OnEnd()
	{
		return true;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x000164E4 File Offset: 0x000146E4
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

	// Token: 0x060003B5 RID: 949 RVA: 0x00016560 File Offset: 0x00014760
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

	// Token: 0x060003B6 RID: 950 RVA: 0x00016628 File Offset: 0x00014828
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

	// Token: 0x060003B7 RID: 951 RVA: 0x000166AC File Offset: 0x000148AC
	public static bool operator !(Entity entity)
	{
		return entity == null || !entity.Valid;
	}

	// Token: 0x0400036D RID: 877
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

	// Token: 0x0400036E RID: 878
	public const int DISABLE_REASON_LENGTH_LIMIT = 4;

	// Token: 0x0400036F RID: 879
	public const int MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x04000371 RID: 881
	private Stat CreateStat;

	// Token: 0x04000372 RID: 882
	private Stat InitDataStat;

	// Token: 0x04000373 RID: 883
	private Stat InitStat;

	// Token: 0x04000374 RID: 884
	protected Stat InitStatTdType;

	// Token: 0x04000375 RID: 885
	private Stat ClearStat;

	// Token: 0x04000376 RID: 886
	protected Stat ClearStatTdType;

	// Token: 0x04000377 RID: 887
	private Stat StartStat;

	// Token: 0x04000378 RID: 888
	protected Stat StartStatTdType;

	// Token: 0x04000379 RID: 889
	private Stat EndStat;

	// Token: 0x0400037A RID: 890
	protected Stat EndStatTdType;

	// Token: 0x0400037B RID: 891
	private Stat ActivateStat;

	// Token: 0x0400037C RID: 892
	private Stat PostActivateStat;

	// Token: 0x0400037D RID: 893
	protected Stat ActivateStatTdType;

	// Token: 0x0400037E RID: 894
	private Stat TickStat;

	// Token: 0x0400037F RID: 895
	protected Stat TickStatTdType;

	// Token: 0x04000380 RID: 896
	private Stat AfterTickStat;

	// Token: 0x04000381 RID: 897
	protected Stat AfterTickStatTdType;

	// Token: 0x04000382 RID: 898
	private EExecutedFlag FlagInternal;

	// Token: 0x04000383 RID: 899
	[Nullable(1)]
	public List<EntityComponent> Components = new List<EntityComponent>();

	// Token: 0x04000384 RID: 900
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<EntityComponent> OnWasRecentlyRenderComponents;

	// Token: 0x04000385 RID: 901
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<EntityComponent> OnBudgetTickEnableChangeComponents;

	// Token: 0x04000386 RID: 902
	[Nullable(1)]
	public TickComponentManager TickComponentManager = new TickComponentManager();

	// Token: 0x04000387 RID: 903
	private int DisableCount;

	// Token: 0x04000388 RID: 904
	private float DeltaSeconds;

	// Token: 0x04000389 RID: 905
	private int TickInterval;

	// Token: 0x0400038A RID: 906
	public int LastTickFrame;

	// Token: 0x0400038B RID: 907
	private bool IsEncloseSpaceInternal;

	// Token: 0x0400038C RID: 908
	private float TimeDilationInternal = 1f;

	// Token: 0x0400038D RID: 909
	private static TsGameBudgetGroupConfig _staticGameBudgetConfigInternal;

	// Token: 0x0400038E RID: 910
	private uint GameBudgetManagedTokenInternal;

	// Token: 0x0400038F RID: 911
	private TsGameBudgetGroupConfig GameBudgetConfigInternal;

	// Token: 0x04000390 RID: 912
	private float DistanceWithCameraInternal = -1f;

	// Token: 0x04000391 RID: 913
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly List<EntityComponent> ComponentsRegistry = new List<EntityComponent>();

	// Token: 0x04000392 RID: 914
	[Nullable(1)]
	private readonly Dictionary<int, string> DisableHandlesMap = new Dictionary<int, string>();

	// Token: 0x04000393 RID: 915
	[Nullable(1)]
	private readonly Dictionary<EEntityDisableKey, int> DisableKeysMap = new Dictionary<EEntityDisableKey, int>();

	// Token: 0x04000394 RID: 916
	[Nullable(1)]
	private object PendingEnable;

	// Token: 0x04000395 RID: 917
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		2
	})]
	private static Dictionary<string, Stat[]> _statMap;

	// Token: 0x04000396 RID: 918
	private GCHandle GameBudgetGCHandle;
}
