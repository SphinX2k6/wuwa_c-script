using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000DDD RID: 3549
[NullableContext(1)]
[Nullable(0)]
public class GameUtils : IStaticVariableResetter
{
	// Token: 0x0600551A RID: 21786 RVA: 0x000F56B2 File Offset: 0x000F38B2
	static GameUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameUtils.CreateStaticDefaultValue), new Action(GameUtils.ResetStaticDefaultValue));
	}

	// Token: 0x170005EF RID: 1519
	// (get) Token: 0x0600551B RID: 21787 RVA: 0x000F56D7 File Offset: 0x000F38D7
	private static ImmutableArray<object> EmptyArray
	{
		get
		{
			return GameUtils._emptyArray;
		}
	}

	// Token: 0x170005F0 RID: 1520
	// (get) Token: 0x0600551C RID: 21788 RVA: 0x000F56DE File Offset: 0x000F38DE
	private static ImmutableMap<object, object> EmptyMap
	{
		get
		{
			return GameUtils._emptyMap;
		}
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x000F56E8 File Offset: 0x000F38E8
	public static UniTask WaitFrame()
	{
		GameUtils.<WaitFrame>d__9 <WaitFrame>d__;
		<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitFrame>d__.<>1__state = -1;
		<WaitFrame>d__.<>t__builder.Start<GameUtils.<WaitFrame>d__9>(ref <WaitFrame>d__);
		return <WaitFrame>d__.<>t__builder.Task;
	}

	// Token: 0x0600551E RID: 21790 RVA: 0x000F5724 File Offset: 0x000F3924
	public static T[] ConvertToArray<[Nullable(2)] T>(int length, Func<int, T> getItemFunc)
	{
		if (length <= 0)
		{
			return Array.Empty<T>();
		}
		T[] array = new T[length];
		for (int i = 0; i < length; i++)
		{
			array[i] = getItemFunc(i);
		}
		return array;
	}

	// Token: 0x0600551F RID: 21791 RVA: 0x000F5760 File Offset: 0x000F3960
	[NullableContext(2)]
	[return: Nullable(1)]
	public static Dictionary<TKey, TValue> ConvertToMap<TKey, TValue, TPair>(int length, [Nullable(1)] Func<int, TPair> getPairFunc)
	{
		if (length <= 0)
		{
			return new Dictionary<TKey, TValue>();
		}
		Type type = typeof(TPair);
		if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			type = type.GenericTypeArguments[0];
		}
		PropertyInfo property = type.GetProperty("Key", BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo property2 = type.GetProperty("Value", BindingFlags.Instance | BindingFlags.Public);
		Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
		for (int i = 0; i < length; i++)
		{
			TPair tpair = getPairFunc(i);
			if (tpair != null)
			{
				dictionary[(TKey)((object)property.GetValue(tpair))] = (TValue)((object)property2.GetValue(tpair));
			}
		}
		return dictionary;
	}

	// Token: 0x06005520 RID: 21792 RVA: 0x000F581A File Offset: 0x000F3A1A
	public static void InternalizedString(string str)
	{
		string.Intern(str);
	}

	// Token: 0x06005521 RID: 21793 RVA: 0x000F5824 File Offset: 0x000F3A24
	[NullableContext(0)]
	public static void SetNullableValue<T>(ref T? value, [Nullable(new byte[]
	{
		1,
		0
	})] GameUtils.ActionRef<T> callback) where T : struct
	{
		if (value == null)
		{
			value = new T?(default(T));
		}
		callback(Unsafe.AsRef<T>(Nullable.GetValueRefOrDefaultRef<T>(ref value)));
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x000F585E File Offset: 0x000F3A5E
	public static void CreateStaticDefaultValue()
	{
		GameUtils._emptyArray = new ImmutableArray<object>();
		GameUtils._emptyMap = new ImmutableMap<object, object>();
	}

	// Token: 0x06005523 RID: 21795 RVA: 0x000F5874 File Offset: 0x000F3A74
	public static void ResetStaticDefaultValue()
	{
		GameUtils._emptyArray = null;
		GameUtils._emptyMap = null;
	}

	// Token: 0x040026B3 RID: 9907
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static ImmutableArray<object> _emptyArray;

	// Token: 0x040026B4 RID: 9908
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static ImmutableMap<object, object> _emptyMap;

	// Token: 0x040026B5 RID: 9909
	public static readonly bool IsOptimizeDbString = true;

	// Token: 0x0200747C RID: 29820
	// (Invoke) Token: 0x060489D0 RID: 297424
	[NullableContext(0)]
	public delegate void ActionRef<[Nullable(2)] T>(ref T value);
}
