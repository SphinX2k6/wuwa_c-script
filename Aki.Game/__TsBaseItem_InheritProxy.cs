using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200393E RID: 14654
public class __TsBaseItem_InheritProxy : TsBaseItem
{
	// Token: 0x0601EC23 RID: 125987 RVA: 0x00899C3C File Offset: 0x00897E3C
	[NullableContext(1)]
	public __TsBaseItem_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC24 RID: 125988 RVA: 0x00899C6F File Offset: 0x00897E6F
	protected __TsBaseItem_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC25 RID: 125989 RVA: 0x00899C78 File Offset: 0x00897E78
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EC26 RID: 125990 RVA: 0x00899C80 File Offset: 0x00897E80
	protected unsafe override void __CPPCALL_GetTagDebugStrings_Implementation(TsBaseItem.__GetTagDebugStrings_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetTagDebugStrings_Implementation());
	}
}
