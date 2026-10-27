using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038A0 RID: 14496
public class __KscBpDataBase_InheritProxy : KscBpDataBase
{
	// Token: 0x0601EA43 RID: 125507 RVA: 0x0089560C File Offset: 0x0089380C
	[NullableContext(1)]
	public __KscBpDataBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBpDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA44 RID: 125508 RVA: 0x0089563F File Offset: 0x0089383F
	protected __KscBpDataBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
