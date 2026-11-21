using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002DC7 RID: 11719
public class __TsAnimNotifyReSkillByTagCount_InheritProxy : TsAnimNotifyReSkillByTagCount
{
	// Token: 0x0601C613 RID: 116243 RVA: 0x008B8C4C File Offset: 0x008B6E4C
	[NullableContext(1)]
	public __TsAnimNotifyReSkillByTagCount_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillByTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C614 RID: 116244 RVA: 0x008B8C7F File Offset: 0x008B6E7F
	protected __TsAnimNotifyReSkillByTagCount_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C615 RID: 116245 RVA: 0x008B8C88 File Offset: 0x008B6E88
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
