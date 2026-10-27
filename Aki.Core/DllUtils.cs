using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x020000EF RID: 239
[NullableContext(1)]
[Nullable(0)]
public class DllUtils
{
	// Token: 0x06000748 RID: 1864 RVA: 0x00027ECC File Offset: 0x000260CC
	public static void Initialize()
	{
		DllUtils._AssemblieDic.Clear();
		DllUtils._TypeDic.Clear();
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00027EE4 File Offset: 0x000260E4
	[NullableContext(2)]
	public static void Add(EDllType dllType, Assembly assembly)
	{
		if (assembly == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "assembly为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DllType", dllType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		DllUtils._AssemblieDic.Add(dllType, assembly);
		DllUtils._TypeDic.Add(dllType, assembly.GetTypes());
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00027F44 File Offset: 0x00026144
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static List<Type> GetImplementTypes(EDllType dllType, Type type)
	{
		if (type == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "type参数为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DllType", dllType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		IList<Type> list;
		if (!DllUtils._TypeDic.TryGetValue(dllType, out list))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Core;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "找不到dllType对应的types";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DllType", dllType);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		List<Type> list2 = new List<Type>();
		for (int i = 0; i < list.Count; i++)
		{
			Type type2 = list[i];
			if (type != type2 && type.IsAssignableFrom(type2))
			{
				list2.Add(type2);
			}
		}
		return list2;
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00028004 File Offset: 0x00026204
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static IList<Type> GetTypes(EDllType dllType)
	{
		IList<Type> result;
		if (!DllUtils._TypeDic.TryGetValue(dllType, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "DllType找不到对应的types";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DllType", dllType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00028050 File Offset: 0x00026250
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static List<Type> GetSubTypes(EDllType dllType, Type type)
	{
		if (type == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "type参数为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DllType", dllType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		IList<Type> list;
		if (!DllUtils._TypeDic.TryGetValue(dllType, out list))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Core;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "找不到dllType对应的types";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DllType", dllType);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		List<Type> list2 = new List<Type>();
		for (int i = 0; i < list.Count; i++)
		{
			Type type2 = list[i];
			if (type != type2 && type2.IsSubclassOf(type))
			{
				list2.Add(type2);
			}
		}
		return list2;
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00028110 File Offset: 0x00026310
	public static bool IsAutoProperty(PropertyInfo prop)
	{
		MethodInfo getMethod = prop.GetMethod;
		bool flag;
		if (getMethod == null || !getMethod.IsDefined(typeof(CompilerGeneratedAttribute)))
		{
			MethodInfo setMethod = prop.SetMethod;
			flag = (setMethod != null && setMethod.IsDefined(typeof(CompilerGeneratedAttribute)));
		}
		else
		{
			flag = true;
		}
		return flag && (prop.GetMethod != null || prop.SetMethod != null);
	}

	// Token: 0x040005C7 RID: 1479
	[StaticVariableRuleIgnore]
	private static Dictionary<EDllType, Assembly> _AssemblieDic = new Dictionary<EDllType, Assembly>();

	// Token: 0x040005C8 RID: 1480
	[StaticVariableRuleIgnore]
	private static Dictionary<EDllType, IList<Type>> _TypeDic = new Dictionary<EDllType, IList<Type>>();
}
