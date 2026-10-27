using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003891 RID: 14481
[NullableContext(1)]
[Nullable(0)]
public class __TsBasePlayerController_SubClassMissingExportProxy : __TsBasePlayerController_InheritProxy
{
	// Token: 0x0601EA02 RID: 125442 RVA: 0x00894720 File Offset: 0x00892920
	protected __TsBasePlayerController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBasePlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA03 RID: 125443 RVA: 0x00894753 File Offset: 0x00892953
	protected __TsBasePlayerController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA04 RID: 125444 RVA: 0x0089475C File Offset: 0x0089295C
	public unsafe override void InitInputHandle()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitInputHandle"), out num);
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

	// Token: 0x0601EA05 RID: 125445 RVA: 0x008947CC File Offset: 0x008929CC
	public unsafe override void AddInputBinding()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddInputBinding"), out num);
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

	// Token: 0x0601EA06 RID: 125446 RVA: 0x0089483C File Offset: 0x00892A3C
	public unsafe override void ClearInputBinding()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ClearInputBinding"), out num);
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

	// Token: 0x0601EA07 RID: 125447 RVA: 0x008948AC File Offset: 0x00892AAC
	protected unsafe override void OnSetupInputComponent()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnSetupInputComponent"), out num);
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

	// Token: 0x0601EA08 RID: 125448 RVA: 0x0089491C File Offset: 0x00892B1C
	protected unsafe override void BindTouchHandle()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("BindTouchHandle"), out num);
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

	// Token: 0x0601EA09 RID: 125449 RVA: 0x0089498C File Offset: 0x00892B8C
	protected unsafe override void OnTouchBegin(ETouchIndex touchIndex, FVector position)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnTouchBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnTouchBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnTouchBegin_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnTouchBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->touchIndex) = (byte)touchIndex;
			ptr2->position = position;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA0A RID: 125450 RVA: 0x00894A10 File Offset: 0x00892C10
	protected unsafe override void OnTouchEnd(ETouchIndex touchIndex, FVector position)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnTouchEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnTouchEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnTouchEnd_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnTouchEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->touchIndex) = (byte)touchIndex;
			ptr2->position = position;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA0B RID: 125451 RVA: 0x00894A94 File Offset: 0x00892C94
	protected unsafe override void OnTouchMove(ETouchIndex touchIndex, FVector position)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnTouchMove"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnTouchMove_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnTouchMove_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnTouchMove_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->touchIndex) = (byte)touchIndex;
			ptr2->position = position;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA0C RID: 125452 RVA: 0x00894B18 File Offset: 0x00892D18
	public unsafe override void OnPressAnyKey(FKey key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPressAnyKey"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnPressAnyKey_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnPressAnyKey_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnPressAnyKey_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr2->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA0D RID: 125453 RVA: 0x00894BA8 File Offset: 0x00892DA8
	public unsafe override void OnReleaseAnyKey(FKey key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnReleaseAnyKey"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnReleaseAnyKey_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnReleaseAnyKey_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnReleaseAnyKey_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr2->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA0E RID: 125454 RVA: 0x00894C38 File Offset: 0x00892E38
	protected unsafe override void RemoveActionHandle(string actionName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveActionHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__RemoveActionHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__RemoveActionHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__RemoveActionHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->actionName), actionName);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA0F RID: 125455 RVA: 0x00894CB8 File Offset: 0x00892EB8
	[return: Nullable(2)]
	protected unsafe override TsActionHandle GetActionHandle(string actionName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetActionHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__GetActionHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__GetActionHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__GetActionHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->actionName), actionName);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		TsActionHandle orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsActionHandle>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601EA10 RID: 125456 RVA: 0x00894D40 File Offset: 0x00892F40
	protected unsafe override void RemoveAxisHandle(string axisName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveAxisHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__RemoveAxisHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__RemoveAxisHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__RemoveAxisHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->axisName), axisName);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA11 RID: 125457 RVA: 0x00894DC0 File Offset: 0x00892FC0
	[return: Nullable(2)]
	protected unsafe override TsAxisHandle GetAxisHandle(string actionName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetAxisHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__GetAxisHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__GetAxisHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__GetAxisHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->actionName), actionName);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		TsAxisHandle orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsAxisHandle>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601EA12 RID: 125458 RVA: 0x00894E48 File Offset: 0x00893048
	public unsafe override bool IsInTouch(float touchId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("IsInTouch"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__IsInTouch_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__IsInTouch_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__IsInTouch_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->touchId = touchId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EA13 RID: 125459 RVA: 0x00894EC8 File Offset: 0x008930C8
	public unsafe override void SetIsPrintKeyName(bool bPrintKeyName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetIsPrintKeyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__SetIsPrintKeyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__SetIsPrintKeyName_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__SetIsPrintKeyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->bPrintKeyName = bPrintKeyName;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
