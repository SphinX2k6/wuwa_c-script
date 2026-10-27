using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200393D RID: 14653
[NullableContext(1)]
[Nullable(0)]
public class __TsSimpleNpc_SubClassMissingExportProxy : __TsSimpleNpc_InheritProxy
{
	// Token: 0x0601EC17 RID: 125975 RVA: 0x00899768 File Offset: 0x00897968
	protected __TsSimpleNpc_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleNpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC18 RID: 125976 RVA: 0x0089979B File Offset: 0x0089799B
	protected __TsSimpleNpc_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC19 RID: 125977 RVA: 0x008997A4 File Offset: 0x008979A4
	[NullableContext(0)]
	public unsafe override void ReceiveEndPlay(TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleNpc.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleNpc.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleNpc.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->endPlayReason = endPlayReason;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC1A RID: 125978 RVA: 0x0089981C File Offset: 0x00897A1C
	public unsafe override void LoadModel()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("LoadModel"), out num);
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

	// Token: 0x0601EC1B RID: 125979 RVA: 0x0089988C File Offset: 0x00897A8C
	public unsafe override void DebugSetNpcDitherValue(float value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DebugSetNpcDitherValue"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC1C RID: 125980 RVA: 0x00899904 File Offset: 0x00897B04
	public unsafe override void SetDefaultCollision()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDefaultCollision"), out num);
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

	// Token: 0x0601EC1D RID: 125981 RVA: 0x00899974 File Offset: 0x00897B74
	public unsafe override void ResetMeshLocation()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ResetMeshLocation"), out num);
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

	// Token: 0x0601EC1E RID: 125982 RVA: 0x008999E4 File Offset: 0x00897BE4
	public unsafe override void FindFloor()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FindFloor"), out num);
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

	// Token: 0x0601EC1F RID: 125983 RVA: 0x00899A54 File Offset: 0x00897C54
	public unsafe override void ShowDialog(string text, float removeSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ShowDialog"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleNpc.__ShowDialog_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleNpc.__ShowDialog_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleNpc.__ShowDialog_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->text), text);
			ptr2->removeSeconds = removeSeconds;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC20 RID: 125984 RVA: 0x00899AD8 File Offset: 0x00897CD8
	public unsafe override void HideDialog()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("HideDialog"), out num);
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

	// Token: 0x0601EC21 RID: 125985 RVA: 0x00899B48 File Offset: 0x00897D48
	public unsafe override bool TryPlayMontage(string montagePath)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TryPlayMontage"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleNpc.__TryPlayMontage_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleNpc.__TryPlayMontage_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleNpc.__TryPlayMontage_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->montagePath), montagePath);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EC22 RID: 125986 RVA: 0x00899BCC File Offset: 0x00897DCC
	public unsafe override void StopMontage()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StopMontage"), out num);
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
