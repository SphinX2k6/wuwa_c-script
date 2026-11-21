using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000B8 RID: 184
[NullableContext(1)]
[Nullable(0)]
public class ObjectSystem : Singleton
{
	// Token: 0x060005FE RID: 1534 RVA: 0x0001F192 File Offset: 0x0001D392
	public bool Initialize()
	{
		this.Objects.Clear();
		this.Versions.Clear();
		this.Indexes.Clear();
		return true;
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
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
		return objectBase != null && objectBase.Id == obj.Id;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x0001F210 File Offset: 0x0001D410
	[return: Nullable(2)]
	public unsafe ObjectBase Create(Type type)
	{
		int num;
		ObjectBase objectBase;
		int num2;
		if (this.Objects.Count <= 32767)
		{
			num = this.Objects.Count;
			objectBase = (ObjectBase)Activator.CreateInstance(type, new object[]
			{
				0,
				num
			});
			this.Objects.Add(objectBase);
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
				return null;
			}
			num = this.Indexes[this.Indexes.Count - 1];
			this.Indexes.RemoveAt(this.Indexes.Count - 1);
			objectBase = (ObjectBase)Activator.CreateInstance(type, new object[]
			{
				0,
				num
			});
			this.Objects[num] = objectBase;
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
		objectBase.Id = id;
		return objectBase;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0001F3AC File Offset: 0x0001D5AC
	public unsafe bool CreateExternal(ObjectBase obj)
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

	// Token: 0x06000602 RID: 1538 RVA: 0x0001F500 File Offset: 0x0001D700
	[NullableContext(2)]
	public bool Destroy(ObjectBase obj)
	{
		if (!this.IsValid(obj))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Object;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "对象重复销毁";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("class", (obj != null) ? obj.GetType() : null);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.Objects[obj.Index] = null;
		this.Indexes.Add(obj.Index);
		return true;
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001F56D File Offset: 0x0001D76D
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

	// Token: 0x06000604 RID: 1540 RVA: 0x0001F590 File Offset: 0x0001D790
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0001F592 File Offset: 0x0001D792
	public static void ResetStaticDefaultValue()
	{
		ObjectSystem instance = ObjectSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ObjectSystem._instance = null;
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x0001F5AB File Offset: 0x0001D7AB
	static ObjectSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ObjectSystem.CreateStaticDefaultValue), new Action(ObjectSystem.ResetStaticDefaultValue));
	}

	// Token: 0x040004AE RID: 1198
	private readonly Dictionary<Type, Stat> StatWeakMap = new Dictionary<Type, Stat>();

	// Token: 0x040004AF RID: 1199
	private const int Digit = 32;

	// Token: 0x040004B0 RID: 1200
	private const int IndexDigit = 16;

	// Token: 0x040004B1 RID: 1201
	public const int VersionDigit = 16;

	// Token: 0x040004B2 RID: 1202
	private const int MaxIndex = 32767;

	// Token: 0x040004B3 RID: 1203
	private const int MaxVersion = 65535;

	// Token: 0x040004B4 RID: 1204
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public readonly List<ObjectBase> Objects = new List<ObjectBase>();

	// Token: 0x040004B5 RID: 1205
	private readonly List<int> Versions = new List<int>();

	// Token: 0x040004B6 RID: 1206
	private readonly List<int> Indexes = new List<int>();

	// Token: 0x040004B7 RID: 1207
	[Nullable(2)]
	private static ObjectSystem _instance;
}
