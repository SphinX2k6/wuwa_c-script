using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E1E RID: 11806
public class __KscSkillData_SubClassMissingExportProxy : __KscSkillData_InheritProxy
{
	// Token: 0x0601C728 RID: 116520 RVA: 0x008BACB0 File Offset: 0x008B8EB0
	[NullableContext(1)]
	protected __KscSkillData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscSkillData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C729 RID: 116521 RVA: 0x008BACE3 File Offset: 0x008B8EE3
	protected __KscSkillData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
