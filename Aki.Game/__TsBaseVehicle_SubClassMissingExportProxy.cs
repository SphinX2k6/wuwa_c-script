using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003957 RID: 14679
public class __TsBaseVehicle_SubClassMissingExportProxy : __TsBaseVehicle_InheritProxy
{
	// Token: 0x0601EC8E RID: 126094 RVA: 0x0089AFD4 File Offset: 0x008991D4
	[NullableContext(1)]
	protected __TsBaseVehicle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC8F RID: 126095 RVA: 0x0089B007 File Offset: 0x00899207
	protected __TsBaseVehicle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC90 RID: 126096 RVA: 0x0089B010 File Offset: 0x00899210
	public unsafe override int GetEntityId()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetEntityId"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseVehicle.__GetEntityId_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseVehicle.__GetEntityId_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseVehicle.__GetEntityId_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EC91 RID: 126097 RVA: 0x0089B088 File Offset: 0x00899288
	public unsafe override void SetDitherEffect(float dither, ECharacterDitherType ditherType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDitherEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseVehicle.__SetDitherEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseVehicle.__SetDitherEffect_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseVehicle.__SetDitherEffect_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->dither = dither;
			*(&ptr2->ditherType) = (byte)ditherType;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
