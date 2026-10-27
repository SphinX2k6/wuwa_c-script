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
	// Token: 0x06000996 RID: 2454 RVA: 0x00031701 File Offset: 0x0002F901
	public static void CopyValue(object copyObj, object obj)
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00031703 File Offset: 0x0002F903
	[NullableContext(2)]
	public static bool IsValid([NotNullWhen(true)] UObject obj)
	{
		return obj != null && obj.IsValid();
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00031710 File Offset: 0x0002F910
	[NullableContext(2)]
	public static bool SoftObjectPathIsValid(FSoftObjectPath objPath)
	{
		return !(objPath == null) && !FNameUtil.IsNothing(objPath.AssetPathName);
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x0003172C File Offset: 0x0002F92C
	public static bool SoftObjectReferenceValid<[Nullable(0)] T>(TSoftObjectPtr<T> objRef) where T : UnrealUObject
	{
		string text = objRef.ToAssetPathName();
		return text != null && text.Length > 0 && text != "None";
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x0003175C File Offset: 0x0002F95C
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

	// Token: 0x0600099B RID: 2459 RVA: 0x000317C0 File Offset: 0x0002F9C0
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

	// Token: 0x0600099C RID: 2460 RVA: 0x00031810 File Offset: 0x0002FA10
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

	// Token: 0x0600099D RID: 2461 RVA: 0x0003183C File Offset: 0x0002FA3C
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
