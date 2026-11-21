using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB9 RID: 11961
public class __TsBaseItem_InheritProxy : TsBaseItem
{
	// Token: 0x0601C8CA RID: 116938 RVA: 0x008BD7D8 File Offset: 0x008BB9D8
	[NullableContext(1)]
	public __TsBaseItem_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8CB RID: 116939 RVA: 0x008BD80B File Offset: 0x008BBA0B
	protected __TsBaseItem_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C8CC RID: 116940 RVA: 0x008BD814 File Offset: 0x008BBA14
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C8CD RID: 116941 RVA: 0x008BD81C File Offset: 0x008BBA1C
	protected unsafe override void __CPPCALL_GetTagDebugStrings_Implementation(TsBaseItem.__GetTagDebugStrings_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetTagDebugStrings_Implementation());
	}
}
