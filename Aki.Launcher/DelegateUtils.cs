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
	// (get) Token: 0x06000090 RID: 144 RVA: 0x00006CBF File Offset: 0x00004EBF
	private static Dictionary<Delegate, UnrealScriptDelegate> ManualReleaseDelegates
	{
		get
		{
			return DelegateUtils._manualReleaseDelegates;
		}
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00006CC8 File Offset: 0x00004EC8
	public static T ToManualReleaseDelegate<[Nullable(0)] T>(Delegate callback) where T : UnrealScriptDelegate, new()
	{
		T t = Activator.CreateInstance<T>();
		t.DynamicBind(callback);
		DelegateUtils.ManualReleaseDelegates.Add(callback, t);
		return t;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00006CF9 File Offset: 0x00004EF9
	public static void ReleaseManualReleaseDelegate(Delegate callBack)
	{
		DelegateUtils.ManualReleaseDelegates.Remove(callBack);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00006D07 File Offset: 0x00004F07
	public static void CreateStaticDefaultValue()
	{
		DelegateUtils._manualReleaseDelegates = new Dictionary<Delegate, UnrealScriptDelegate>();
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00006D13 File Offset: 0x00004F13
	public static void ResetStaticDefaultValue()
	{
		DelegateUtils._manualReleaseDelegates = null;
	}

	// Token: 0x04000050 RID: 80
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<Delegate, UnrealScriptDelegate> _manualReleaseDelegates;
}
