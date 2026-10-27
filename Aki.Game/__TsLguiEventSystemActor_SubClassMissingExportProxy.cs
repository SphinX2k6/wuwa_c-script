using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039C5 RID: 14789
[NullableContext(1)]
[Nullable(0)]
public class __TsLguiEventSystemActor_SubClassMissingExportProxy : __TsLguiEventSystemActor_InheritProxy
{
	// Token: 0x0601EEFF RID: 126719 RVA: 0x008A2F48 File Offset: 0x008A1148
	protected __TsLguiEventSystemActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLguiEventSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF00 RID: 126720 RVA: 0x008A2F7B File Offset: 0x008A117B
	protected __TsLguiEventSystemActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EF01 RID: 126721 RVA: 0x008A2F84 File Offset: 0x008A1184
	public unsafe override void InputTrigger(bool triggerPress, EMouseButtonType mouseButtonType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputTrigger"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputTrigger_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputTrigger_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTrigger_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->triggerPress = triggerPress;
			*(&ptr2->mouseButtonType) = (byte)mouseButtonType;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EF02 RID: 126722 RVA: 0x008A3004 File Offset: 0x008A1204
	public unsafe override void InputNavigation(ELGUINavigationDirection direction, bool pressOrRelease, bool forceNavigation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputNavigation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputNavigation_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputNavigation_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputNavigation_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->direction) = (byte)direction;
			ptr2->pressOrRelease = pressOrRelease;
			ptr2->forceNavigation = forceNavigation;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EF03 RID: 126723 RVA: 0x008A308C File Offset: 0x008A128C
	public unsafe override void InputTriggerForNavigation(bool triggerPress)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputTriggerForNavigation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->triggerPress = triggerPress;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EF04 RID: 126724 RVA: 0x008A3104 File Offset: 0x008A1304
	public unsafe override void InputScroll(float axisValue)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputScroll"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputScroll_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputScroll_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputScroll_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->axisValue = axisValue;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EF05 RID: 126725 RVA: 0x008A317C File Offset: 0x008A137C
	public unsafe override void InputTouchTrigger(bool touchPress, int touchId, FVector touchPointPosition)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputTouchTrigger"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->touchPress = touchPress;
			ptr2->touchId = touchId;
			ptr2->touchPointPosition = touchPointPosition;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EF06 RID: 126726 RVA: 0x008A3204 File Offset: 0x008A1404
	public unsafe override void InputTouchMove(int touchId, FVector touchPointPosition)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputTouchMove"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputTouchMove_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputTouchMove_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTouchMove_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->touchId = touchId;
			ptr2->touchPointPosition = touchPointPosition;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EF07 RID: 126727 RVA: 0x008A3284 File Offset: 0x008A1484
	[NullableContext(2)]
	public unsafe override UUIItem GetNowHitComponent()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNowHitComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		UUIItem orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601EF08 RID: 126728 RVA: 0x008A3300 File Offset: 0x008A1500
	[NullableContext(2)]
	public unsafe override ULGUIPointerEventData GetPointerEventData(float pointerId, bool createIfNotExist)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetPointerEventData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__GetPointerEventData_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__GetPointerEventData_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__GetPointerEventData_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->pointerId = pointerId;
			ptr2->createIfNotExist = createIfNotExist;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601EF09 RID: 126729 RVA: 0x008A338C File Offset: 0x008A158C
	public unsafe override bool IsPointerEventDataLineTrace(ULGUIPointerEventData pointerEventData)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("IsPointerEventDataLineTrace"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->pointerEventData) = ((pointerEventData != null) ? pointerEventData.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EF0A RID: 126730 RVA: 0x008A3418 File Offset: 0x008A1618
	protected unsafe override void SetClickThresholdWithInputKeyType(EInputKeyType inputKeyType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetClickThresholdWithInputKeyType"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->inputKeyType) = (byte)inputKeyType;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
