using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022FB RID: 8955
[NullableContext(1)]
[Nullable(0)]
public class BulletSpecialActionRegistry : IStaticVariableResetter
{
	// Token: 0x06016115 RID: 90389 RVA: 0x00669F80 File Offset: 0x00668180
	static BulletSpecialActionRegistry()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletSpecialActionRegistry.CreateStaticDefaultValue), new Action(BulletSpecialActionRegistry.ResetStaticDefaultValue));
	}

	// Token: 0x1700217A RID: 8570
	// (get) Token: 0x06016116 RID: 90390 RVA: 0x00669F9F File Offset: 0x0066819F
	private static Dictionary<int, object> SpecialBulletMap
	{
		get
		{
			return BulletSpecialActionRegistry.SpecialBulletMapInternal;
		}
	}

	// Token: 0x1700217B RID: 8571
	// (get) Token: 0x06016117 RID: 90391 RVA: 0x00669FA6 File Offset: 0x006681A6
	private static HashSet<List<BulletActionOverride>> CanonicalArrays
	{
		get
		{
			return BulletSpecialActionRegistry.CanonicalArraysInternal;
		}
	}

	// Token: 0x1700217C RID: 8572
	// (get) Token: 0x06016118 RID: 90392 RVA: 0x00669FAD File Offset: 0x006681AD
	private static List<List<BulletActionOverride>> CanonicalSets
	{
		get
		{
			return BulletSpecialActionRegistry.CanonicalSetsInternal;
		}
	}

	// Token: 0x06016119 RID: 90393 RVA: 0x00669FB4 File Offset: 0x006681B4
	public static void CreateStaticDefaultValue()
	{
		BulletSpecialActionRegistry.SpecialBulletMapInternal = new Dictionary<int, object>();
		BulletSpecialActionRegistry.CanonicalArraysInternal = new HashSet<List<BulletActionOverride>>();
		BulletSpecialActionRegistry.CanonicalSetsInternal = new List<List<BulletActionOverride>>();
	}

	// Token: 0x0601611A RID: 90394 RVA: 0x00669FD4 File Offset: 0x006681D4
	public static void ResetStaticDefaultValue()
	{
		BulletSpecialActionRegistry.SpecialBulletMapInternal = null;
		BulletSpecialActionRegistry.CanonicalArraysInternal = null;
		BulletSpecialActionRegistry.CanonicalSetsInternal = null;
	}

	// Token: 0x0601611B RID: 90395 RVA: 0x00669FE8 File Offset: 0x006681E8
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

	// Token: 0x0601611C RID: 90396 RVA: 0x0066A083 File Offset: 0x00668283
	[NullableContext(0)]
	public static void RegisterForAllBullets<T>(int modelId, EBulletAction type, bool isPersistentAction) where T : BulletActionBase
	{
		BulletSpecialActionRegistry.AddSlot(modelId, null, BulletSpecialActionRegistry.MakeSlot(type, typeof(T), isPersistentAction));
	}

	// Token: 0x0601611D RID: 90397 RVA: 0x0066A09D File Offset: 0x0066829D
	private static BulletActionOverride MakeSlot(EBulletAction type, Type actionClass, bool isPersistentAction)
	{
		return new BulletActionOverride
		{
			Type = type,
			ActionClass = actionClass,
			IsPersistentAction = isPersistentAction
		};
	}

	// Token: 0x0601611E RID: 90398 RVA: 0x0066A0BC File Offset: 0x006682BC
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

	// Token: 0x0601611F RID: 90399 RVA: 0x0066A1F0 File Offset: 0x006683F0
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

	// Token: 0x06016120 RID: 90400 RVA: 0x0066A36C File Offset: 0x0066856C
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

	// Token: 0x06016121 RID: 90401 RVA: 0x0066A3DC File Offset: 0x006685DC
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

	// Token: 0x06016122 RID: 90402 RVA: 0x0066A484 File Offset: 0x00668684
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

	// Token: 0x0400B960 RID: 47456
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, object> SpecialBulletMapInternal;

	// Token: 0x0400B961 RID: 47457
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static HashSet<List<BulletActionOverride>> CanonicalArraysInternal;

	// Token: 0x0400B962 RID: 47458
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static List<List<BulletActionOverride>> CanonicalSetsInternal;
}
