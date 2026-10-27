using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003965 RID: 14693
[NullableContext(1)]
[Nullable(0)]
public class __AudioVisualizationInstanceBase_SubClassMissingExportProxy : __AudioVisualizationInstanceBase_InheritProxy
{
	// Token: 0x0601ECE7 RID: 126183 RVA: 0x0089BB34 File Offset: 0x00899D34
	protected __AudioVisualizationInstanceBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AudioVisualizationInstanceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ECE8 RID: 126184 RVA: 0x0089BB67 File Offset: 0x00899D67
	protected __AudioVisualizationInstanceBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ECE9 RID: 126185 RVA: 0x0089BB70 File Offset: 0x00899D70
	public unsafe override void StartInternal()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StartInternal"), out num);
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

	// Token: 0x0601ECEA RID: 126186 RVA: 0x0089BBE0 File Offset: 0x00899DE0
	public unsafe override void EndInternal()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EndInternal"), out num);
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

	// Token: 0x0601ECEB RID: 126187 RVA: 0x0089BC50 File Offset: 0x00899E50
	public unsafe override void CallBackInternal([Nullable(2)] UAkCallbackInfo callbackInfo, EAkCallbackType callbackType, string state)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("CallBackInternal"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->callbackInfo) = ((callbackInfo != null) ? callbackInfo.NativePtr : ((IntPtr)0));
			*(&ptr2->callbackType) = (byte)callbackType;
			FString.CopyFrom((void*)(&ptr2->state), state);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECEC RID: 126188 RVA: 0x0089BCEC File Offset: 0x00899EEC
	public unsafe override void MidiBpm()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiBpm"), out num);
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

	// Token: 0x0601ECED RID: 126189 RVA: 0x0089BD5C File Offset: 0x00899F5C
	public unsafe override void MidiC3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiC3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiC3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiC3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiC3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECEE RID: 126190 RVA: 0x0089BDD4 File Offset: 0x00899FD4
	public unsafe override void MidiCs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiCs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECEF RID: 126191 RVA: 0x0089BE4C File Offset: 0x0089A04C
	public unsafe override void MidiD3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiD3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiD3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiD3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiD3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF0 RID: 126192 RVA: 0x0089BEC4 File Offset: 0x0089A0C4
	public unsafe override void MidiDs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiDs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF1 RID: 126193 RVA: 0x0089BF3C File Offset: 0x0089A13C
	public unsafe override void MidiE3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiE3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiE3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiE3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiE3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF2 RID: 126194 RVA: 0x0089BFB4 File Offset: 0x0089A1B4
	public unsafe override void MidiF3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiF3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiF3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiF3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiF3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF3 RID: 126195 RVA: 0x0089C02C File Offset: 0x0089A22C
	public unsafe override void MidiFs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiFs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF4 RID: 126196 RVA: 0x0089C0A4 File Offset: 0x0089A2A4
	public unsafe override void MidiG3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiG3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiG3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiG3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiG3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF5 RID: 126197 RVA: 0x0089C11C File Offset: 0x0089A31C
	public unsafe override void MidiGs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiGs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF6 RID: 126198 RVA: 0x0089C194 File Offset: 0x0089A394
	public unsafe override void MidiA3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiA3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiA3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiA3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiA3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF7 RID: 126199 RVA: 0x0089C20C File Offset: 0x0089A40C
	public unsafe override void MidiAs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiAs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF8 RID: 126200 RVA: 0x0089C284 File Offset: 0x0089A484
	public unsafe override void MidiB3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiB3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiB3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiB3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiB3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECF9 RID: 126201 RVA: 0x0089C2FC File Offset: 0x0089A4FC
	public unsafe override void MidiC3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiC3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECFA RID: 126202 RVA: 0x0089C374 File Offset: 0x0089A574
	public unsafe override void MidiCs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiCs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECFB RID: 126203 RVA: 0x0089C3EC File Offset: 0x0089A5EC
	public unsafe override void MidiD3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiD3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECFC RID: 126204 RVA: 0x0089C464 File Offset: 0x0089A664
	public unsafe override void MidiDs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiDs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECFD RID: 126205 RVA: 0x0089C4DC File Offset: 0x0089A6DC
	public unsafe override void MidiE3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiE3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECFE RID: 126206 RVA: 0x0089C554 File Offset: 0x0089A754
	public unsafe override void MidiF3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiF3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ECFF RID: 126207 RVA: 0x0089C5CC File Offset: 0x0089A7CC
	public unsafe override void MidiFs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiFs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED00 RID: 126208 RVA: 0x0089C644 File Offset: 0x0089A844
	public unsafe override void MidiG3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiG3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED01 RID: 126209 RVA: 0x0089C6BC File Offset: 0x0089A8BC
	public unsafe override void MidiGs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiGs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED02 RID: 126210 RVA: 0x0089C734 File Offset: 0x0089A934
	public unsafe override void MidiA3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiA3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED03 RID: 126211 RVA: 0x0089C7AC File Offset: 0x0089A9AC
	public unsafe override void MidiAs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiAs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED04 RID: 126212 RVA: 0x0089C824 File Offset: 0x0089AA24
	public unsafe override void MidiB3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiB3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
