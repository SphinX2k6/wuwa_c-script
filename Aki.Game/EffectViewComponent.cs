using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029F6 RID: 10742
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/EffectViewComponent.EffectViewComponent_C")]
public class EffectViewComponent : USceneComponent, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AF48 RID: 110408 RVA: 0x0084628C File Offset: 0x0084448C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void EditorTick(float deltaSecond)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(EffectViewComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("EditorTick"), EffectViewComponent.StaticClass(), out intPtr, out num))
		{
			this.EditorTick_Implementation(deltaSecond);
			return;
		}
		EffectViewComponent.__EditorTick_FunctionParams* ptr = stackalloc EffectViewComponent.__EditorTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(EffectViewComponent.__EditorTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->deltaSecond = deltaSecond;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AF49 RID: 110409 RVA: 0x00846318 File Offset: 0x00844518
	protected void EditorTick_Implementation(float deltaSecond)
	{
	}

	// Token: 0x0601AF4A RID: 110410 RVA: 0x0084631C File Offset: 0x0084451C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAutoPlay(bool autoPlay)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(EffectViewComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetAutoPlay"), EffectViewComponent.StaticClass(), out intPtr, out num))
		{
			this.SetAutoPlay_Implementation(autoPlay);
			return;
		}
		EffectViewComponent.__SetAutoPlay_FunctionParams* ptr = stackalloc EffectViewComponent.__SetAutoPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(EffectViewComponent.__SetAutoPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->autoPlay = autoPlay;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AF4B RID: 110411 RVA: 0x008463A8 File Offset: 0x008445A8
	protected void SetAutoPlay_Implementation(bool autoPlay)
	{
	}

	// Token: 0x0601AF4C RID: 110412 RVA: 0x008463AC File Offset: 0x008445AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Play()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(EffectViewComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Play"), EffectViewComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Play_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AF4D RID: 110413 RVA: 0x00846405 File Offset: 0x00844605
	protected void Play_Implementation()
	{
	}

	// Token: 0x0601AF4E RID: 110414 RVA: 0x00846408 File Offset: 0x00844608
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Stop(bool immediately = false)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(EffectViewComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Stop"), EffectViewComponent.StaticClass(), out intPtr, out num))
		{
			this.Stop_Implementation(immediately);
			return;
		}
		EffectViewComponent.__Stop_FunctionParams* ptr = stackalloc EffectViewComponent.__Stop_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(EffectViewComponent.__Stop_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->immediately = immediately;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AF4F RID: 110415 RVA: 0x00846494 File Offset: 0x00844694
	protected void Stop_Implementation(bool immediately = false)
	{
	}

	// Token: 0x0601AF50 RID: 110416 RVA: 0x00846496 File Offset: 0x00844696
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectViewComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/EffectViewComponent.EffectViewComponent_C");
		}
		return EffectViewComponent._ClassPtr;
	}

	// Token: 0x0601AF51 RID: 110417 RVA: 0x008464BC File Offset: 0x008446BC
	public EffectViewComponent() : this(BuiltinUtils.AllocNativeUObject(EffectViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AF52 RID: 110418 RVA: 0x008464E4 File Offset: 0x008446E4
	[NullableContext(1)]
	public EffectViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF53 RID: 110419 RVA: 0x00846517 File Offset: 0x00844717
	protected EffectViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AF54 RID: 110420 RVA: 0x00846520 File Offset: 0x00844720
	protected unsafe virtual void __CPPCALL_EditorTick_Implementation(EffectViewComponent.__EditorTick_FunctionParams* __Params)
	{
		this.EditorTick_Implementation(__Params->deltaSecond);
	}

	// Token: 0x0601AF55 RID: 110421 RVA: 0x0084652E File Offset: 0x0084472E
	protected unsafe virtual void __CPPCALL_SetAutoPlay_Implementation(EffectViewComponent.__SetAutoPlay_FunctionParams* __Params)
	{
		this.SetAutoPlay_Implementation(__Params->autoPlay);
	}

	// Token: 0x0601AF56 RID: 110422 RVA: 0x0084653C File Offset: 0x0084473C
	protected virtual void __CPPCALL_Play_Implementation()
	{
		this.Play_Implementation();
	}

	// Token: 0x0601AF57 RID: 110423 RVA: 0x00846544 File Offset: 0x00844744
	protected unsafe virtual void __CPPCALL_Stop_Implementation(EffectViewComponent.__Stop_FunctionParams* __Params)
	{
		this.Stop_Implementation(__Params->immediately);
	}

	// Token: 0x0400EA2D RID: 59949
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/EffectViewComponent.EffectViewComponent_C";

	// Token: 0x0400EA2E RID: 59950
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA2F RID: 59951
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008A2E RID: 35374
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __EditorTick_FunctionParams
	{
		// Token: 0x0402BEA4 RID: 179876
		[FieldOffset(0)]
		public float deltaSecond;
	}

	// Token: 0x02008A2F RID: 35375
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetAutoPlay_FunctionParams
	{
		// Token: 0x0402BEA5 RID: 179877
		[FieldOffset(0)]
		public bool autoPlay;
	}

	// Token: 0x02008A30 RID: 35376
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __Stop_FunctionParams
	{
		// Token: 0x0402BEA6 RID: 179878
		[FieldOffset(0)]
		public bool immediately;
	}
}
