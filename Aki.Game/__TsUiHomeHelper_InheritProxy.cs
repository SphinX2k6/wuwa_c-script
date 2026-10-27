using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038D8 RID: 14552
public class __TsUiHomeHelper_InheritProxy : TsUiHomeHelper
{
	// Token: 0x0601EB0A RID: 125706 RVA: 0x0089781C File Offset: 0x00895A1C
	[NullableContext(1)]
	public __TsUiHomeHelper_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHomeHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB0B RID: 125707 RVA: 0x0089784F File Offset: 0x00895A4F
	protected __TsUiHomeHelper_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
