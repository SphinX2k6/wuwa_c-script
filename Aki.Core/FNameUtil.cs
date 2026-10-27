using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Utils.StaticVariableReset;
using UnrealEngine;

// Token: 0x020000F0 RID: 240
[NullableContext(1)]
[Nullable(0)]
[StaticVariablePriority(100)]
public class FNameUtil : IStaticVariableResetter
{
	// Token: 0x06000750 RID: 1872 RVA: 0x00028198 File Offset: 0x00026398
	static FNameUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FNameUtil.CreateStaticDefaultValue), new Action(FNameUtil.ResetStaticDefaultValue));
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000751 RID: 1873 RVA: 0x000281D0 File Offset: 0x000263D0
	private static Dictionary<string, FName> CacheNameMap
	{
		get
		{
			return FNameUtil._cacheNameMap;
		}
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x000281D8 File Offset: 0x000263D8
	[NullableContext(2)]
	public static FName? GetDynamicFName(string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			return null;
		}
		FName value;
		if (!FNameUtil.CacheNameMap.TryGetValue(key, out value))
		{
			value = new FName(key);
			FNameUtil.CacheNameMap[key] = value;
		}
		return new FName?(value);
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00028220 File Offset: 0x00026420
	public static FName GetCheckDynamicFName(string key)
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName(key);
		if (dynamicFName == null)
		{
			return FName.NAME_None;
		}
		return dynamicFName.Value;
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0002824C File Offset: 0x0002644C
	public static bool IsEmpty(FName? content)
	{
		return content == null || content == FNameUtil.EMPTY;
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00028284 File Offset: 0x00026484
	public static bool IsNothing(FName? content)
	{
		return FNameUtil.IsEmpty(content);
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x0002828C File Offset: 0x0002648C
	public static bool IsNothing(FName content)
	{
		return content == FNameUtil.NONE;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00028299 File Offset: 0x00026499
	public static void CreateStaticDefaultValue()
	{
		FNameUtil._cacheNameMap = new Dictionary<string, FName>();
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x000282A5 File Offset: 0x000264A5
	public static void ResetStaticDefaultValue()
	{
		FNameUtil._cacheNameMap = null;
	}

	// Token: 0x040005C9 RID: 1481
	[StaticVariableRuleIgnore]
	public static readonly FName EMPTY = new FName("");

	// Token: 0x040005CA RID: 1482
	[StaticVariableRuleIgnore]
	public static readonly FName NONE = FName.NAME_None;

	// Token: 0x040005CB RID: 1483
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<string, FName> _cacheNameMap;
}
