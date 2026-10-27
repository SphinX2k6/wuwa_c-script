using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002DA1 RID: 11681
[NullableContext(1)]
[Nullable(0)]
public class BulletSpecialActionRegistry : IStaticVariableResetter
{
	// Token: 0x06018870 RID: 100464 RVA: 0x00644144 File Offset: 0x00642344
	static BulletSpecialActionRegistry()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletSpecialActionRegistry.CreateStaticDefaultValue), new Action(BulletSpecialActionRegistry.ResetStaticDefaultValue));
	}

	// Token: 0x1700211F RID: 8479
	// (get) Token: 0x06018871 RID: 100465 RVA: 0x00644163 File Offset: 0x00642363
	private static Dictionary<int, object> SpecialBulletMap
	{
		get
		{
			return BulletSpecialActionRegistry.SpecialBulletMapInternal;
		}
	}

	// Token: 0x17002120 RID: 8480
	// (get) Token: 0x06018872 RID: 100466 RVA: 0x0064416A File Offset: 0x0064236A
	private static HashSet<List<BulletActionOverride>> CanonicalArrays
	{
		get
		{
			return BulletSpecialActionRegistry.CanonicalArraysInternal;
		}
	}

	// Token: 0x17002121 RID: 8481
	// (get) Token: 0x06018873 RID: 100467 RVA: 0x00644171 File Offset: 0x00642371
	private static List<List<BulletActionOverride>> CanonicalSets
	{
		get
		{
			return BulletSpecialActionRegistry.CanonicalSetsInternal;
		}
	}

	// Token: 0x06018874 RID: 100468 RVA: 0x00644178 File Offset: 0x00642378
	public static void CreateStaticDefaultValue()
	{
		BulletSpecialActionRegistry.SpecialBulletMapInternal = new Dictionary<int, object>();
		BulletSpecialActionRegistry.CanonicalArraysInternal = new HashSet<List<BulletActionOverride>>();
		BulletSpecialActionRegistry.CanonicalSetsInternal = new List<List<BulletActionOverride>>();
	}

	// Token: 0x06018875 RID: 100469 RVA: 0x00644198 File Offset: 0x00642398
	public static void ResetStaticDefaultValue()
	{
		BulletSpecialActionRegistry.SpecialBulletMapInternal = null;
		BulletSpecialActionRegistry.CanonicalArraysInternal = null;
		BulletSpecialActionRegistry.CanonicalSetsInternal = null;
	}

	// Token: 0x06018876 RID: 100470 RVA: 0x006441AC File Offset: 0x006423AC
	public unsafe static void Register<[Nullable(0)] T>(int modelId, EBulletAction type, bool isPersistentAction, params string[] bulletRowNames) where T : BulletActionBase
	{
		if (bulletRowNames.Length == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "特殊Action声明未指定子弹RowName（如需该发射者全部子弹生效请用RegisterForAllBullets）";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("modelId", modelId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("type", type);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		foreach (string bulletRowName in bulletRowNames)
		{
			BulletSpecialActionRegistry.AddSlot(modelId, bulletRowName, BulletSpecialActionRegistry.MakeSlot(type, typeof(T), isPersistentAction));
		}
	}

	// Token: 0x06018877 RID: 100471 RVA: 0x00644247 File Offset: 0x00642447
	[NullableContext(0)]
	public static void RegisterForAllBullets<T>(int modelId, EBulletAction type, bool isPersistentAction) where T : BulletActionBase
	{
		BulletSpecialActionRegistry.AddSlot(modelId, null, BulletSpecialActionRegistry.MakeSlot(type, typeof(T), isPersistentAction));
	}

	// Token: 0x06018878 RID: 100472 RVA: 0x00644261 File Offset: 0x00642461
	private static BulletActionOverride MakeSlot(EBulletAction type, Type actionClass, bool isPersistentAction)
	{
		return new BulletActionOverride
		{
			Type = type,
			ActionClass = actionClass,
			IsPersistentAction = isPersistentAction
		};
	}

	// Token: 0x06018879 RID: 100473 RVA: 0x00644280 File Offset: 0x00642480
	private unsafe static void AddSlot(int modelId, [Nullable(2)] string bulletRowName, BulletActionOverride slot)
	{
		object obj;
		BulletSpecialActionRegistry.SpecialBulletMap.TryGetValue(modelId, out obj);
		if (bulletRowName == null)
		{
			if (obj is Dictionary<string, List<BulletActionOverride>>)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Bullet;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "该发射者已按RowName注册特殊子弹，不能再注册全量";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("modelId", modelId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (obj == null)
			{
				BulletSpecialActionRegistry.SpecialBulletMap[modelId] = new List<BulletActionOverride>
				{
					slot
				};
				return;
			}
			BulletSpecialActionRegistry.AppendSlot((List<BulletActionOverride>)obj, slot, modelId, bulletRowName);
			return;
		}
		else
		{
			if (obj == null)
			{
				Dictionary<int, object> specialBulletMap = BulletSpecialActionRegistry.SpecialBulletMap;
				Dictionary<string, List<BulletActionOverride>> dictionary = new Dictionary<string, List<BulletActionOverride>>();
				dictionary[bulletRowName] = new List<BulletActionOverride>
				{
					slot
				};
				specialBulletMap[modelId] = dictionary;
				return;
			}
			Dictionary<string, List<BulletActionOverride>> dictionary2 = obj as Dictionary<string, List<BulletActionOverride>>;
			if (dictionary2 == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Bullet;
				ELogAuthor author2 = ELogAuthor.HCW;
				string message2 = "该发射者已注册全量特殊子弹，不能再按RowName注册";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("modelId", modelId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bulletRowName", bulletRowName);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			List<BulletActionOverride> overrides;
			if (!dictionary2.TryGetValue(bulletRowName, out overrides))
			{
				dictionary2[bulletRowName] = new List<BulletActionOverride>
				{
					slot
				};
				return;
			}
			BulletSpecialActionRegistry.AppendSlot(overrides, slot, modelId, bulletRowName);
			return;
		}
	}

	// Token: 0x0601887A RID: 100474 RVA: 0x006443B4 File Offset: 0x006425B4
	private unsafe static void AppendSlot(List<BulletActionOverride> overrides, BulletActionOverride slot, int modelId, [Nullable(2)] string bulletRowName)
	{
		if (BulletSpecialActionRegistry.CanonicalArrays.Contains(overrides))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "特殊Action声明过晚：该替换集已被子弹配置使用，新增槽位不会生效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("modelId", modelId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bulletRowName", bulletRowName ?? "");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("type", slot.Type);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		using (List<BulletActionOverride>.Enumerator enumerator = overrides.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Type == slot.Type)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Bullet;
					ELogAuthor author2 = ELogAuthor.HCW;
					string message2 = "特殊Action槽位重复声明";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("modelId", modelId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("bulletRowName", bulletRowName ?? "");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("type", slot.Type);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					return;
				}
			}
		}
		overrides.Add(slot);
	}

	// Token: 0x0601887B RID: 100475 RVA: 0x00644530 File Offset: 0x00642730
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static List<BulletActionOverride> GetOverrides(int modelId, string bulletRowName)
	{
		object obj;
		if (!BulletSpecialActionRegistry.SpecialBulletMap.TryGetValue(modelId, out obj))
		{
			return null;
		}
		Dictionary<string, List<BulletActionOverride>> dictionary = obj as Dictionary<string, List<BulletActionOverride>>;
		if (dictionary == null)
		{
			List<BulletActionOverride> list = (List<BulletActionOverride>)obj;
			List<BulletActionOverride> list2 = BulletSpecialActionRegistry.ToCanonical(list);
			if (list2 != list)
			{
				BulletSpecialActionRegistry.SpecialBulletMap[modelId] = list2;
			}
			return list2;
		}
		List<BulletActionOverride> list3;
		if (!dictionary.TryGetValue(bulletRowName, out list3))
		{
			return null;
		}
		List<BulletActionOverride> list4 = BulletSpecialActionRegistry.ToCanonical(list3);
		if (list4 != list3)
		{
			dictionary[bulletRowName] = list4;
		}
		return list4;
	}

	// Token: 0x0601887C RID: 100476 RVA: 0x006445A0 File Offset: 0x006427A0
	private static List<BulletActionOverride> ToCanonical(List<BulletActionOverride> overrides)
	{
		if (BulletSpecialActionRegistry.CanonicalArrays.Contains(overrides))
		{
			return overrides;
		}
		overrides.Sort((BulletActionOverride a, BulletActionOverride b) => a.Type - b.Type);
		foreach (List<BulletActionOverride> list in BulletSpecialActionRegistry.CanonicalSets)
		{
			if (BulletSpecialActionRegistry.ContentEquals(list, overrides))
			{
				return list;
			}
		}
		BulletSpecialActionRegistry.CanonicalSets.Add(overrides);
		BulletSpecialActionRegistry.CanonicalArrays.Add(overrides);
		return overrides;
	}

	// Token: 0x0601887D RID: 100477 RVA: 0x00644648 File Offset: 0x00642848
	private static bool ContentEquals(List<BulletActionOverride> a, List<BulletActionOverride> b)
	{
		if (a.Count != b.Count)
		{
			return false;
		}
		for (int i = 0; i < a.Count; i++)
		{
			BulletActionOverride bulletActionOverride = a[i];
			BulletActionOverride bulletActionOverride2 = b[i];
			if (bulletActionOverride.Type != bulletActionOverride2.Type || bulletActionOverride.ActionClass != bulletActionOverride2.ActionClass || bulletActionOverride.IsPersistentAction != bulletActionOverride2.IsPersistentAction)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400B5EA RID: 46570
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, object> SpecialBulletMapInternal;

	// Token: 0x0400B5EB RID: 46571
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static HashSet<List<BulletActionOverride>> CanonicalArraysInternal;

	// Token: 0x0400B5EC RID: 46572
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static List<List<BulletActionOverride>> CanonicalSetsInternal;
}
