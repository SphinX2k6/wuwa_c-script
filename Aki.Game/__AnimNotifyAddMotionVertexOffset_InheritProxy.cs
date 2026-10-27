using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003970 RID: 14704
public class __AnimNotifyAddMotionVertexOffset_InheritProxy : AnimNotifyAddMotionVertexOffset
{
	// Token: 0x0601ED33 RID: 126259 RVA: 0x0089CFFC File Offset: 0x0089B1FC
	[NullableContext(1)]
	public __AnimNotifyAddMotionVertexOffset_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMotionVertexOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED34 RID: 126260 RVA: 0x0089D02F File Offset: 0x0089B22F
	protected __AnimNotifyAddMotionVertexOffset_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ED35 RID: 126261 RVA: 0x0089D038 File Offset: 0x0089B238
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
