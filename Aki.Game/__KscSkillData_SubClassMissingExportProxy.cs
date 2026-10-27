using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038A5 RID: 14501
public class __KscSkillData_SubClassMissingExportProxy : __KscSkillData_InheritProxy
{
	// Token: 0x0601EA4D RID: 125517 RVA: 0x00895738 File Offset: 0x00893938
	[NullableContext(1)]
	protected __KscSkillData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscSkillData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA4E RID: 125518 RVA: 0x0089576B File Offset: 0x0089396B
	protected __KscSkillData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
