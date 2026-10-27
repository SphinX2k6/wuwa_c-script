using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200384E RID: 14414
public class __TsAnimNotifyReSkillByTagCount_InheritProxy : TsAnimNotifyReSkillByTagCount
{
	// Token: 0x0601E91A RID: 125210 RVA: 0x00892850 File Offset: 0x00890A50
	[NullableContext(1)]
	public __TsAnimNotifyReSkillByTagCount_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillByTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E91B RID: 125211 RVA: 0x00892883 File Offset: 0x00890A83
	protected __TsAnimNotifyReSkillByTagCount_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E91C RID: 125212 RVA: 0x0089288C File Offset: 0x00890A8C
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
