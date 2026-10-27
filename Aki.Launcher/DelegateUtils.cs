using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200000F RID: 15
[NullableContext(1)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class DelegateUtils
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000090 RID: 144 RVA: 0x00006C87 File Offset: 0x00004E87
	private static Dictionary<Delegate, UnrealScriptDelegate> ManualReleaseDelegates
	{
		get
		{
			return DelegateUtils._manualReleaseDelegates;
		}
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00006C90 File Offset: 0x00004E90
	public static T ToManualReleaseDelegate<[Nullable(0)] T>(Delegate callback) where T : UnrealScriptDelegate, new()
	{
		T t = Activator.CreateInstance<T>();
		t.DynamicBind(callback);
		DelegateUtils.ManualReleaseDelegates.Add(callback, t);
		return t;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00006CC1 File Offset: 0x00004EC1
	public static void ReleaseManualReleaseDelegate(Delegate callBack)
	{
		DelegateUtils.ManualReleaseDelegates.Remove(callBack);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00006CCF File Offset: 0x00004ECF
	public static void CreateStaticDefaultValue()
	{
		DelegateUtils._manualReleaseDelegates = new Dictionary<Delegate, UnrealScriptDelegate>();
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00006CDB File Offset: 0x00004EDB
	public static void ResetStaticDefaultValue()
	{
		DelegateUtils._manualReleaseDelegates = null;
	}

	// Token: 0x0400004F RID: 79
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<Delegate, UnrealScriptDelegate> _manualReleaseDelegates;
}
