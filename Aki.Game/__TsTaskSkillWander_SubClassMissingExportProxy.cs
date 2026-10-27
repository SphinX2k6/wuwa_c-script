using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036BD RID: 14013
public class __TsTaskSkillWander_SubClassMissingExportProxy : __TsTaskSkillWander_InheritProxy
{
	// Token: 0x0601E389 RID: 123785 RVA: 0x00885310 File Offset: 0x00883510
	[NullableContext(1)]
	protected __TsTaskSkillWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSkillWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E38A RID: 123786 RVA: 0x00885343 File Offset: 0x00883543
	protected __TsTaskSkillWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
