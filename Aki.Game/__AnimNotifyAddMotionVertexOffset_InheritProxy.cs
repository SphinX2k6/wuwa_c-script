using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EEB RID: 12011
public class __AnimNotifyAddMotionVertexOffset_InheritProxy : AnimNotifyAddMotionVertexOffset
{
	// Token: 0x0601C999 RID: 117145 RVA: 0x008BEC34 File Offset: 0x008BCE34
	[NullableContext(1)]
	public __AnimNotifyAddMotionVertexOffset_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMotionVertexOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C99A RID: 117146 RVA: 0x008BEC67 File Offset: 0x008BCE67
	protected __AnimNotifyAddMotionVertexOffset_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C99B RID: 117147 RVA: 0x008BEC70 File Offset: 0x008BCE70
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
