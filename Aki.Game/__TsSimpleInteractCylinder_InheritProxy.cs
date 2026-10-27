using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003944 RID: 14660
public class __TsSimpleInteractCylinder_InheritProxy : TsSimpleInteractCylinder
{
	// Token: 0x0601EC3D RID: 126013 RVA: 0x0089A008 File Offset: 0x00898208
	[NullableContext(1)]
	public __TsSimpleInteractCylinder_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractCylinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC3E RID: 126014 RVA: 0x0089A03B File Offset: 0x0089823B
	protected __TsSimpleInteractCylinder_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
