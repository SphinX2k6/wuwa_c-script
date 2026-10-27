using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003955 RID: 14677
public class __TsTriggerVolume_SubClassMissingExportProxy : __TsTriggerVolume_InheritProxy
{
	// Token: 0x0601EC85 RID: 126085 RVA: 0x0089AE38 File Offset: 0x00899038
	[NullableContext(1)]
	protected __TsTriggerVolume_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC86 RID: 126086 RVA: 0x0089AE6B File Offset: 0x0089906B
	protected __TsTriggerVolume_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC87 RID: 126087 RVA: 0x0089AE74 File Offset: 0x00899074
	protected unsafe override void AddBuffInner(long buffId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddBuffInner"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTriggerVolume.__AddBuffInner_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTriggerVolume.__AddBuffInner_FunctionParams*)ptr + 15L / (long)sizeof(TsTriggerVolume.__AddBuffInner_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->buffId = buffId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC88 RID: 126088 RVA: 0x0089AEEC File Offset: 0x008990EC
	protected unsafe override void TryReportSelfBuffDamageLog()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TryReportSelfBuffDamageLog"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
