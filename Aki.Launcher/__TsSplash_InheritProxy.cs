using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02000017 RID: 23
public class __TsSplash_InheritProxy : TsSplash
{
	// Token: 0x060000BE RID: 190 RVA: 0x0000752C File Offset: 0x0000572C
	[NullableContext(1)]
	public __TsSplash_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSplash.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0000755F File Offset: 0x0000575F
	protected __TsSplash_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
