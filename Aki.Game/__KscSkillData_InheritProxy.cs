using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038A4 RID: 14500
public class __KscSkillData_InheritProxy : KscSkillData
{
	// Token: 0x0601EA4B RID: 125515 RVA: 0x008956FC File Offset: 0x008938FC
	[NullableContext(1)]
	public __KscSkillData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscSkillData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA4C RID: 125516 RVA: 0x0089572F File Offset: 0x0089392F
	protected __KscSkillData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
