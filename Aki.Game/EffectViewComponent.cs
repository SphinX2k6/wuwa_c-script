using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003482 RID: 13442
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/EffectViewComponent.EffectViewComponent_C")]
public class EffectViewComponent : USceneComponent, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D240 RID: 119360 RVA: 0x0081EF8C File Offset: 0x0081D18C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void EditorTick(float deltaSecond)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EditorTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		EffectViewComponent.__EditorTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((EffectViewComponent.__EditorTick_FunctionParams*)ptr + 15L / (long)sizeof(EffectViewComponent.__EditorTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->deltaSecond = deltaSecond;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D241 RID: 119361 RVA: 0x0081F002 File Offset: 0x0081D202
	protected void EditorTick_Implementation(float deltaSecond)
	{
	}

	// Token: 0x0601D242 RID: 119362 RVA: 0x0081F004 File Offset: 0x0081D204
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAutoPlay(bool autoPlay)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetAutoPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		EffectViewComponent.__SetAutoPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((EffectViewComponent.__SetAutoPlay_FunctionParams*)ptr + 15L / (long)sizeof(EffectViewComponent.__SetAutoPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->autoPlay = autoPlay;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D243 RID: 119363 RVA: 0x0081F07A File Offset: 0x0081D27A
	protected void SetAutoPlay_Implementation(bool autoPlay)
	{
	}

	// Token: 0x0601D244 RID: 119364 RVA: 0x0081F07C File Offset: 0x0081D27C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Play()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Play"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D245 RID: 119365 RVA: 0x0081F0EC File Offset: 0x0081D2EC
	protected void Play_Implementation()
	{
	}

	// Token: 0x0601D246 RID: 119366 RVA: 0x0081F0F0 File Offset: 0x0081D2F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Stop(bool immediately = false)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Stop"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		EffectViewComponent.__Stop_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((EffectViewComponent.__Stop_FunctionParams*)ptr + 15L / (long)sizeof(EffectViewComponent.__Stop_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->immediately = immediately;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D247 RID: 119367 RVA: 0x0081F166 File Offset: 0x0081D366
	protected void Stop_Implementation(bool immediately = false)
	{
	}

	// Token: 0x0601D248 RID: 119368 RVA: 0x0081F168 File Offset: 0x0081D368
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectViewComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/EffectViewComponent.EffectViewComponent_C");
		}
		return EffectViewComponent._ClassPtr;
	}

	// Token: 0x0601D249 RID: 119369 RVA: 0x0081F18C File Offset: 0x0081D38C
	public EffectViewComponent() : this(BuiltinUtils.AllocNativeUObject(EffectViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D24A RID: 119370 RVA: 0x0081F1B4 File Offset: 0x0081D3B4
	[NullableContext(1)]
	public EffectViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D24B RID: 119371 RVA: 0x0081F1E7 File Offset: 0x0081D3E7
	protected EffectViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D24C RID: 119372 RVA: 0x0081F1F0 File Offset: 0x0081D3F0
	protected unsafe virtual void __CPPCALL_EditorTick_Implementation(EffectViewComponent.__EditorTick_FunctionParams* __Params)
	{
		this.EditorTick_Implementation(__Params->deltaSecond);
	}

	// Token: 0x0601D24D RID: 119373 RVA: 0x0081F1FE File Offset: 0x0081D3FE
	protected unsafe virtual void __CPPCALL_SetAutoPlay_Implementation(EffectViewComponent.__SetAutoPlay_FunctionParams* __Params)
	{
		this.SetAutoPlay_Implementation(__Params->autoPlay);
	}

	// Token: 0x0601D24E RID: 119374 RVA: 0x0081F20C File Offset: 0x0081D40C
	protected virtual void __CPPCALL_Play_Implementation()
	{
		this.Play_Implementation();
	}

	// Token: 0x0601D24F RID: 119375 RVA: 0x0081F214 File Offset: 0x0081D414
	protected unsafe virtual void __CPPCALL_Stop_Implementation(EffectViewComponent.__Stop_FunctionParams* __Params)
	{
		this.Stop_Implementation(__Params->immediately);
	}

	// Token: 0x0400E575 RID: 58741
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/EffectViewComponent.EffectViewComponent_C";

	// Token: 0x0400E576 RID: 58742
	private static IntPtr _ClassPtr;

	// Token: 0x0400E577 RID: 58743
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200980B RID: 38923
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __EditorTick_FunctionParams
	{
		// Token: 0x04030817 RID: 198679
		[FieldOffset(0)]
		public float deltaSecond;
	}

	// Token: 0x0200980C RID: 38924
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetAutoPlay_FunctionParams
	{
		// Token: 0x04030818 RID: 198680
		[FieldOffset(0)]
		public bool autoPlay;
	}

	// Token: 0x0200980D RID: 38925
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __Stop_FunctionParams
	{
		// Token: 0x04030819 RID: 198681
		[FieldOffset(0)]
		public bool immediately;
	}
}
