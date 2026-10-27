using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000B6 RID: 182
[NullableContext(1)]
[Nullable(0)]
public class ObjectSystem : Singleton
{
	// Token: 0x060005BD RID: 1469 RVA: 0x0001EAEE File Offset: 0x0001CCEE
	public bool Initialize()
	{
		this.Objects.Clear();
		this.Versions.Clear();
		this.Indexes.Clear();
		return true;
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0001EB14 File Offset: 0x0001CD14
	[NullableContext(2)]
	public bool IsValid(ObjectBase obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj.Index < 0 || obj.Index > 32767 || obj.Id < 0)
		{
			return false;
		}
		ObjectBase objectBase = this.Objects[obj.Index];
		if (objectBase == null)
		{
			return false;
		}
		int? num = (objectBase != null) ? new int?(objectBase.Id) : null;
		int id = obj.Id;
		return num.GetValueOrDefault() == id & num != null;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x0001EB94 File Offset: 0x0001CD94
	[NullableContext(0)]
	[return: Nullable(2)]
	public unsafe T Create<T>() where T : ObjectBase
	{
		Stat value = null;
		if (Stat.Enable && !this.StatWeakMap.TryGetValue(typeof(T), out value))
		{
			value = null;
			this.StatWeakMap[typeof(T)] = value;
		}
		T t = default(T);
		int num;
		int num2;
		if (this.Objects.Count <= 32767)
		{
			num = this.Objects.Count;
			t = (T)((object)Activator.CreateInstance(typeof(T), new object[]
			{
				0,
				num
			}));
			this.Objects.Add(t);
			this.Versions.Add(1);
			num2 = 1;
		}
		else
		{
			if (this.Indexes.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "无法分配Object的Id，超出设计最大数量";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MaxIndex", 32767);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Effects.length", this.Objects.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return default(T);
			}
			num = this.Indexes[this.Indexes.Count - 1];
			this.Indexes.RemoveAt(this.Indexes.Count - 1);
			t = (T)((object)Activator.CreateInstance(typeof(T), new object[]
			{
				0,
				num
			}));
			this.Objects[num] = t;
			List<int> versions = this.Versions;
			int index = num;
			int num3 = versions[index] + 1;
			versions[index] = num3;
			num2 = num3;
			if (num2 > 65535)
			{
				num2 = 1;
				this.Versions[num] = num2;
			}
		}
		int id = num << 16 | num2;
		t.Id = id;
		return t;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
	public unsafe bool CreateExternal<[Nullable(0)] T>(T obj) where T : ObjectBase
	{
		int num;
		int num2;
		if (this.Objects.Count < 32767)
		{
			num = this.Objects.Count;
			this.Objects.Add(obj);
			this.Versions.Add(1);
			num2 = 1;
		}
		else
		{
			if (this.Indexes.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "无法分配Object的Id，超出设计最大数量";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MaxIndex", 32767);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Effects.length", this.Objects.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			num = this.Indexes[this.Indexes.Count - 1];
			this.Indexes.RemoveAt(this.Indexes.Count - 1);
			this.Objects[num] = obj;
			List<int> versions = this.Versions;
			int index = num;
			int num3 = versions[index] + 1;
			versions[index] = num3;
			num2 = num3;
			if (num2 > 65535)
			{
				num2 = 1;
				this.Versions[num] = num2;
			}
		}
		int id = num << 16 | num2;
		obj.Id = id;
		obj.Index = num;
		return true;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0001EF0C File Offset: 0x0001D10C
	public bool Destroy(ObjectBase obj)
	{
		if (!this.IsValid(obj))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Object;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "对象重复销毁";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("class", obj.GetType().Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.Objects[obj.Index] = null;
		this.Indexes.Add(obj.Index);
		return true;
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001EF78 File Offset: 0x0001D178
	public static ObjectSystem Instance
	{
		get
		{
			if (ObjectSystem._instance == null)
			{
				ObjectSystem._instance = new ObjectSystem();
				ObjectSystem._instance.OnInit();
			}
			return ObjectSystem._instance;
		}
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0001EF9B File Offset: 0x0001D19B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x0001EF9D File Offset: 0x0001D19D
	public static void ResetStaticDefaultValue()
	{
		ObjectSystem instance = ObjectSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ObjectSystem._instance = null;
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x0001EFB6 File Offset: 0x0001D1B6
	static ObjectSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ObjectSystem.CreateStaticDefaultValue), new Action(ObjectSystem.ResetStaticDefaultValue));
	}

	// Token: 0x040004A0 RID: 1184
	private readonly Dictionary<Type, Stat> StatWeakMap = new Dictionary<Type, Stat>();

	// Token: 0x040004A1 RID: 1185
	private const int Digit = 32;

	// Token: 0x040004A2 RID: 1186
	private const int IndexDigit = 16;

	// Token: 0x040004A3 RID: 1187
	public const int VersionDigit = 16;

	// Token: 0x040004A4 RID: 1188
	private const int MaxIndex = 32767;

	// Token: 0x040004A5 RID: 1189
	private const int MaxVersion = 65535;

	// Token: 0x040004A6 RID: 1190
	public readonly List<ObjectBase> Objects = new List<ObjectBase>();

	// Token: 0x040004A7 RID: 1191
	private readonly List<int> Versions = new List<int>();

	// Token: 0x040004A8 RID: 1192
	private readonly List<int> Indexes = new List<int>();

	// Token: 0x040004A9 RID: 1193
	[Nullable(2)]
	private static ObjectSystem _instance;
}
