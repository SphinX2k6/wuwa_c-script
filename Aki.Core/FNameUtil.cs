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
	// Token: 0x0600078A RID: 1930 RVA: 0x000284CC File Offset: 0x000266CC
	static FNameUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FNameUtil.CreateStaticDefaultValue), new Action(FNameUtil.ResetStaticDefaultValue));
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x0600078B RID: 1931 RVA: 0x00028504 File Offset: 0x00026704
	private static Dictionary<string, FName> CacheNameMap
	{
		get
		{
			return FNameUtil._cacheNameMap;
		}
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x0002850C File Offset: 0x0002670C
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

	// Token: 0x0600078D RID: 1933 RVA: 0x00028554 File Offset: 0x00026754
	public static FName GetCheckDynamicFName(string key)
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName(key);
		if (dynamicFName == null)
		{
			return FName.NAME_None;
		}
		return dynamicFName.Value;
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00028580 File Offset: 0x00026780
	public static bool IsEmpty(FName? content)
	{
		return content == null || content == FNameUtil.EMPTY;
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x000285B8 File Offset: 0x000267B8
	public static bool IsNothing(FName? content)
	{
		return FNameUtil.IsEmpty(content);
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x000285C0 File Offset: 0x000267C0
	public static bool IsNothing(FName content)
	{
		return content == FNameUtil.NONE;
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x000285CD File Offset: 0x000267CD
	public static void CreateStaticDefaultValue()
	{
		FNameUtil._cacheNameMap = new Dictionary<string, FName>();
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x000285D9 File Offset: 0x000267D9
	public static void ResetStaticDefaultValue()
	{
		FNameUtil._cacheNameMap = null;
	}

	// Token: 0x040005D4 RID: 1492
	[StaticVariableRuleIgnore]
	public static readonly FName EMPTY = new FName("");

	// Token: 0x040005D5 RID: 1493
	[StaticVariableRuleIgnore]
	public static readonly FName NONE = FName.NAME_None;

	// Token: 0x040005D6 RID: 1494
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<string, FName> _cacheNameMap;
}
