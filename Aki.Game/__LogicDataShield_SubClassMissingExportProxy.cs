using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200390B RID: 14603
public class __LogicDataShield_SubClassMissingExportProxy : __LogicDataShield_InheritProxy
{
	// Token: 0x0601EB8E RID: 125838 RVA: 0x0089858C File Offset: 0x0089678C
	[NullableContext(1)]
	protected __LogicDataShield_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShield.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB8F RID: 125839 RVA: 0x008985BF File Offset: 0x008967BF
	protected __LogicDataShield_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
