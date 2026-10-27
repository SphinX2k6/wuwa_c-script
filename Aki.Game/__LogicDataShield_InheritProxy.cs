using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200390A RID: 14602
public class __LogicDataShield_InheritProxy : LogicDataShield
{
	// Token: 0x0601EB8C RID: 125836 RVA: 0x00898550 File Offset: 0x00896750
	[NullableContext(1)]
	public __LogicDataShield_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShield.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB8D RID: 125837 RVA: 0x00898583 File Offset: 0x00896783
	protected __LogicDataShield_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
