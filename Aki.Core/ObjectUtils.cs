using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000100 RID: 256
[NullableContext(1)]
[Nullable(0)]
public static class ObjectUtils
{
	// Token: 0x060009E7 RID: 2535 RVA: 0x0003205D File Offset: 0x0003025D
	public static void CopyValue(object copyObj, object obj)
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x0003205F File Offset: 0x0003025F
	[NullableContext(2)]
	public static bool IsValid([NotNullWhen(true)] UObject obj)
	{
		return obj != null && obj.IsValid();
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x0003206C File Offset: 0x0003026C
	[NullableContext(2)]
	public static bool SoftObjectPathIsValid(FSoftObjectPath objPath)
	{
		return !(objPath == null) && !FNameUtil.IsNothing(objPath.AssetPathName);
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x00032088 File Offset: 0x00030288
	public static bool SoftObjectReferenceValid<[Nullable(0)] T>(TSoftObjectPtr<T> objRef) where T : UnrealUObject
	{
		string text = objRef.ToAssetPathName();
		return text != null && text.Length > 0 && text != "None";
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x000320B8 File Offset: 0x000302B8
	public static List<FGameplayTag> GetGameplayTags(IReadOnlyList<string> tagNames)
	{
		List<FGameplayTag> list = new List<FGameplayTag>();
		foreach (string tagName in tagNames)
		{
			FGameplayTag? gameplayTagByName = GameplayTagUtils.GetGameplayTagByName(tagName);
			if (gameplayTagByName != null)
			{
				list.Add(gameplayTagByName.Value);
			}
		}
		return list;
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x0003211C File Offset: 0x0003031C
	[NullableContext(2)]
	public static T GetRandomArrayItem<T>([Nullable(1)] IList<T> array)
	{
		int count = array.Count;
		if (count > 0)
		{
			int num = 0;
			if (count > 1)
			{
				num = (int)MathUtils.Instance.GetRandomRange(0.0, (double)count);
				if (num == count)
				{
					num--;
				}
			}
			return array[num];
		}
		return default(T);
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x0003216C File Offset: 0x0003036C
	[NullableContext(0)]
	public static T? GetRandomStructArrayItem<T>([Nullable(new byte[]
	{
		1,
		0
	})] IList<T> array) where T : struct
	{
		if (array.Count > 0)
		{
			return new T?(ObjectUtils.GetRandomArrayItem<T>(array));
		}
		return null;
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00032198 File Offset: 0x00030398
	public static IList<T> ueArrayToArray<[Nullable(2)] T>(TArray<T> array)
	{
		int num = array.Num();
		List<T> list = new List<T>();
		for (int i = 0; i < num; i++)
		{
			list.Add(array.Get(i));
		}
		return list;
	}
}
