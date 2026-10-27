using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003897 RID: 14487
public class __CounterAttackCameraData_SubClassMissingExportProxy : __CounterAttackCameraData_InheritProxy
{
	// Token: 0x0601EA2A RID: 125482 RVA: 0x0089524C File Offset: 0x0089344C
	[NullableContext(1)]
	protected __CounterAttackCameraData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackCameraData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA2B RID: 125483 RVA: 0x0089527F File Offset: 0x0089347F
	protected __CounterAttackCameraData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
