using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C0 RID: 14528
public class __TsPhotographerSource_InheritProxy : TsPhotographerSource
{
	// Token: 0x0601EAC4 RID: 125636 RVA: 0x00896EF4 File Offset: 0x008950F4
	[NullableContext(1)]
	public __TsPhotographerSource_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographerSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAC5 RID: 125637 RVA: 0x00896F27 File Offset: 0x00895127
	protected __TsPhotographerSource_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
