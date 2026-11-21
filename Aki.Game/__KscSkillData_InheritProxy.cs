using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E1D RID: 11805
public class __KscSkillData_InheritProxy : KscSkillData
{
	// Token: 0x0601C726 RID: 116518 RVA: 0x008BAC74 File Offset: 0x008B8E74
	[NullableContext(1)]
	public __KscSkillData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscSkillData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C727 RID: 116519 RVA: 0x008BACA7 File Offset: 0x008B8EA7
	protected __KscSkillData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
