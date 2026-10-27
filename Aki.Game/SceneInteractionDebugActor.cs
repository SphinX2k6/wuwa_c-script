using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003492 RID: 13458
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionDebugActor.SceneInteractionDebugActor_C")]
public class SceneInteractionDebugActor : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002898 RID: 10392
	// (get) Token: 0x0601D450 RID: 119888 RVA: 0x00828E34 File Offset: 0x00827034
	// (set) Token: 0x0601D451 RID: 119889 RVA: 0x00828E44 File Offset: 0x00827044
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int HandleId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_HandleId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_HandleId) = value;
		}
	}

	// Token: 0x17002899 RID: 10393
	// (get) Token: 0x0601D452 RID: 119890 RVA: 0x00828E55 File Offset: 0x00827055
	// (set) Token: 0x0601D453 RID: 119891 RVA: 0x00828E69 File Offset: 0x00827069
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor DebugActorRef
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionDebugActor.__PropertyOffset_DebugActorRef);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionDebugActor.__PropertyOffset_DebugActorRef, value);
		}
	}

	// Token: 0x1700289A RID: 10394
	// (get) Token: 0x0601D454 RID: 119892 RVA: 0x00828E7E File Offset: 0x0082707E
	// (set) Token: 0x0601D455 RID: 119893 RVA: 0x00828E92 File Offset: 0x00827092
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string DebugActorKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SceneInteractionDebugActor.__PropertyOffset_DebugActorKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SceneInteractionDebugActor.__PropertyOffset_DebugActorKey)), value);
		}
	}

	// Token: 0x1700289B RID: 10395
	// (get) Token: 0x0601D456 RID: 119894 RVA: 0x00828EA7 File Offset: 0x008270A7
	// (set) Token: 0x0601D457 RID: 119895 RVA: 0x00828EB7 File Offset: 0x008270B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedTransition
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_NeedTransition) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_NeedTransition) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700289C RID: 10396
	// (get) Token: 0x0601D458 RID: 119896 RVA: 0x00828EC8 File Offset: 0x008270C8
	// (set) Token: 0x0601D459 RID: 119897 RVA: 0x00828ED8 File Offset: 0x008270D8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Force
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_Force) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_Force) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700289D RID: 10397
	// (get) Token: 0x0601D45A RID: 119898 RVA: 0x00828EE9 File Offset: 0x008270E9
	// (set) Token: 0x0601D45B RID: 119899 RVA: 0x00828EFD File Offset: 0x008270FD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string LevelName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SceneInteractionDebugActor.__PropertyOffset_LevelName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SceneInteractionDebugActor.__PropertyOffset_LevelName)), value);
		}
	}

	// Token: 0x1700289E RID: 10398
	// (get) Token: 0x0601D45C RID: 119900 RVA: 0x00828F12 File Offset: 0x00827112
	// (set) Token: 0x0601D45D RID: 119901 RVA: 0x00828F22 File Offset: 0x00827122
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CountNumber
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_CountNumber);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_CountNumber) = value;
		}
	}

	// Token: 0x1700289F RID: 10399
	// (get) Token: 0x0601D45E RID: 119902 RVA: 0x00828F33 File Offset: 0x00827133
	// (set) Token: 0x0601D45F RID: 119903 RVA: 0x00828F43 File Offset: 0x00827143
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BaseForce
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_BaseForce);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_BaseForce) = value;
		}
	}

	// Token: 0x170028A0 RID: 10400
	// (get) Token: 0x0601D460 RID: 119904 RVA: 0x00828F54 File Offset: 0x00827154
	// (set) Token: 0x0601D461 RID: 119905 RVA: 0x00828F68 File Offset: 0x00827168
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector OriginOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_OriginOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_OriginOffset) = value;
		}
	}

	// Token: 0x170028A1 RID: 10401
	// (get) Token: 0x0601D462 RID: 119906 RVA: 0x00828F7D File Offset: 0x0082717D
	// (set) Token: 0x0601D463 RID: 119907 RVA: 0x00828F8D File Offset: 0x0082718D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DamageRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_DamageRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_DamageRadius) = value;
		}
	}

	// Token: 0x170028A2 RID: 10402
	// (get) Token: 0x0601D464 RID: 119908 RVA: 0x00828F9E File Offset: 0x0082719E
	// (set) Token: 0x0601D465 RID: 119909 RVA: 0x00828FAE File Offset: 0x008271AE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ImpluseFactor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_ImpluseFactor);
		}
		set
		{
			*(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_ImpluseFactor) = value;
		}
	}

	// Token: 0x0601D466 RID: 119910 RVA: 0x00828FC0 File Offset: 0x008271C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
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

	// Token: 0x0601D467 RID: 119911 RVA: 0x00829030 File Offset: 0x00827230
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.HandleId = -1;
	}

	// Token: 0x0601D468 RID: 119912 RVA: 0x0082903C File Offset: 0x0082723C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState1()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState1"), out num);
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

	// Token: 0x0601D469 RID: 119913 RVA: 0x008290AC File Offset: 0x008272AC
	protected void ChangeState1_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "change state1", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.HandleId, EKuroSceneInteractionState.State1, this.NeedTransition, this.Force, false);
		}
	}

	// Token: 0x0601D46A RID: 119914 RVA: 0x0082910C File Offset: 0x0082730C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState2()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState2"), out num);
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

	// Token: 0x0601D46B RID: 119915 RVA: 0x0082917C File Offset: 0x0082737C
	protected void ChangeState2_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "change state2", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.HandleId, EKuroSceneInteractionState.State2, this.NeedTransition, this.Force, false);
		}
	}

	// Token: 0x0601D46C RID: 119916 RVA: 0x008291DC File Offset: 0x008273DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState3()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState3"), out num);
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

	// Token: 0x0601D46D RID: 119917 RVA: 0x0082924C File Offset: 0x0082744C
	protected void ChangeState3_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "change state3", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.HandleId, EKuroSceneInteractionState.State3, this.NeedTransition, this.Force, false);
		}
	}

	// Token: 0x0601D46E RID: 119918 RVA: 0x008292AC File Offset: 0x008274AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState4()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState4"), out num);
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

	// Token: 0x0601D46F RID: 119919 RVA: 0x0082931C File Offset: 0x0082751C
	protected void ChangeState4_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "change state4", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.HandleId, EKuroSceneInteractionState.State4, this.NeedTransition, this.Force, false);
		}
	}

	// Token: 0x0601D470 RID: 119920 RVA: 0x0082937C File Offset: 0x0082757C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState5()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState5"), out num);
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

	// Token: 0x0601D471 RID: 119921 RVA: 0x008293EC File Offset: 0x008275EC
	protected void ChangeState5_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "change state5", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.HandleId, EKuroSceneInteractionState.State5, this.NeedTransition, this.Force, false);
		}
	}

	// Token: 0x0601D472 RID: 119922 RVA: 0x0082944C File Offset: 0x0082764C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState6()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState6"), out num);
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

	// Token: 0x0601D473 RID: 119923 RVA: 0x008294BC File Offset: 0x008276BC
	protected void ChangeState6_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "change state6", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.HandleId, EKuroSceneInteractionState.State6, this.NeedTransition, this.Force, false);
		}
	}

	// Token: 0x0601D474 RID: 119924 RVA: 0x0082951C File Offset: 0x0082771C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState7()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState7"), out num);
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

	// Token: 0x0601D475 RID: 119925 RVA: 0x0082958C File Offset: 0x0082778C
	protected void ChangeState7_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "change state7", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.HandleId, EKuroSceneInteractionState.State7, this.NeedTransition, this.Force, false);
		}
	}

	// Token: 0x0601D476 RID: 119926 RVA: 0x008295EC File Offset: 0x008277EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeState8()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeState8"), out num);
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

	// Token: 0x0601D477 RID: 119927 RVA: 0x0082965C File Offset: 0x0082785C
	protected void ChangeState8_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "change state8", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().SwitchSceneInteractionToState(this.HandleId, EKuroSceneInteractionState.State8, this.NeedTransition, this.Force, false);
		}
	}

	// Token: 0x0601D478 RID: 119928 RVA: 0x008296BC File Offset: 0x008278BC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Create()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Create"), out num);
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

	// Token: 0x0601D479 RID: 119929 RVA: 0x0082972C File Offset: 0x0082792C
	protected void Create_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "create", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			this.Remove();
		}
		string text = this.LevelName;
		if (text.StartsWith("World'"))
		{
			text = this.LevelName.Replace("World'", "");
			text = text.Split('.', StringSplitOptions.None)[0];
		}
		this.HandleId = SceneInteractionManager.Get().CreateSceneInteractionLevel(text, this.InitState, base.D_K2_GetActorLocation(), base.K2_GetActorRotation(), delegate
		{
			Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "level streaming complete", default(ReadOnlySpan<ValueTuple<string, object>>));
		}, true, false, 0, 0, null);
	}

	// Token: 0x0601D47A RID: 119930 RVA: 0x008297F0 File Offset: 0x008279F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Remove()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Remove"), out num);
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

	// Token: 0x0601D47B RID: 119931 RVA: 0x00829860 File Offset: 0x00827A60
	protected void Remove_Implementation()
	{
		if (!RenderModuleController.Instance.IsRuntime())
		{
			return;
		}
		Log.Instance.Info(ELogModule.RenderScene, ELogAuthor.HCS, "remove", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().DestroySceneInteraction(this.HandleId);
			this.HandleId = -1;
			this.DebugActorRef = null;
		}
	}

	// Token: 0x0601D47C RID: 119932 RVA: 0x008298C0 File Offset: 0x00827AC0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void PrintState()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PrintState"), out num);
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

	// Token: 0x0601D47D RID: 119933 RVA: 0x00829930 File Offset: 0x00827B30
	protected void PrintState_Implementation()
	{
		int handleId = this.HandleId;
	}

	// Token: 0x0601D47E RID: 119934 RVA: 0x0082993C File Offset: 0x00827B3C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void PlaySceneEffect()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PlaySceneEffect"), out num);
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

	// Token: 0x0601D47F RID: 119935 RVA: 0x008299AC File Offset: 0x00827BAC
	protected void PlaySceneEffect_Implementation()
	{
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().PlaySceneInteractionEffect(this.HandleId, this.EffectKey.Value);
		}
	}

	// Token: 0x0601D480 RID: 119936 RVA: 0x008299D4 File Offset: 0x00827BD4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeDirection()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeDirection"), out num);
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

	// Token: 0x0601D481 RID: 119937 RVA: 0x00829A44 File Offset: 0x00827C44
	protected void ChangeDirection_Implementation()
	{
		if (this.HandleId >= 0)
		{
			this.CountNumber += 1f;
			SceneInteractionManager.Get().ChangeSceneInteractionPlayDirection(this.HandleId, this.CountNumber % 2f == 0f);
		}
	}

	// Token: 0x0601D482 RID: 119938 RVA: 0x00829A84 File Offset: 0x00827C84
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GetDebugActorRefByKey()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDebugActorRefByKey"), out num);
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

	// Token: 0x0601D483 RID: 119939 RVA: 0x00829AF4 File Offset: 0x00827CF4
	protected void GetDebugActorRefByKey_Implementation()
	{
		if (this.HandleId >= 0)
		{
			AActor sceneInteractionActorByKey = SceneInteractionManager.Get().GetSceneInteractionActorByKey(this.HandleId, this.DebugActorKey);
			this.HandleId = -1;
			this.DebugActorRef = sceneInteractionActorByKey;
		}
	}

	// Token: 0x0601D484 RID: 119940 RVA: 0x00829B2F File Offset: 0x00827D2F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SceneInteractionDebugActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionDebugActor.SceneInteractionDebugActor_C");
		}
		return SceneInteractionDebugActor._ClassPtr;
	}

	// Token: 0x0601D485 RID: 119941 RVA: 0x00829B54 File Offset: 0x00827D54
	public SceneInteractionDebugActor() : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D486 RID: 119942 RVA: 0x00829B7C File Offset: 0x00827D7C
	public SceneInteractionDebugActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D487 RID: 119943 RVA: 0x00829BAF File Offset: 0x00827DAF
	protected SceneInteractionDebugActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x170028A3 RID: 10403
	// (get) Token: 0x0601D488 RID: 119944 RVA: 0x00829BB8 File Offset: 0x00827DB8
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugActor.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x170028A4 RID: 10404
	// (get) Token: 0x0601D489 RID: 119945 RVA: 0x00829BC8 File Offset: 0x00827DC8
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionDebugActor.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601D48A RID: 119946 RVA: 0x00829BDC File Offset: 0x00827DDC
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601D48B RID: 119947 RVA: 0x00829BE4 File Offset: 0x00827DE4
	protected virtual void __CPPCALL_ChangeState1_Implementation()
	{
		this.ChangeState1_Implementation();
	}

	// Token: 0x0601D48C RID: 119948 RVA: 0x00829BEC File Offset: 0x00827DEC
	protected virtual void __CPPCALL_ChangeState2_Implementation()
	{
		this.ChangeState2_Implementation();
	}

	// Token: 0x0601D48D RID: 119949 RVA: 0x00829BF4 File Offset: 0x00827DF4
	protected virtual void __CPPCALL_ChangeState3_Implementation()
	{
		this.ChangeState3_Implementation();
	}

	// Token: 0x0601D48E RID: 119950 RVA: 0x00829BFC File Offset: 0x00827DFC
	protected virtual void __CPPCALL_ChangeState4_Implementation()
	{
		this.ChangeState4_Implementation();
	}

	// Token: 0x0601D48F RID: 119951 RVA: 0x00829C04 File Offset: 0x00827E04
	protected virtual void __CPPCALL_ChangeState5_Implementation()
	{
		this.ChangeState5_Implementation();
	}

	// Token: 0x0601D490 RID: 119952 RVA: 0x00829C0C File Offset: 0x00827E0C
	protected virtual void __CPPCALL_ChangeState6_Implementation()
	{
		this.ChangeState6_Implementation();
	}

	// Token: 0x0601D491 RID: 119953 RVA: 0x00829C14 File Offset: 0x00827E14
	protected virtual void __CPPCALL_ChangeState7_Implementation()
	{
		this.ChangeState7_Implementation();
	}

	// Token: 0x0601D492 RID: 119954 RVA: 0x00829C1C File Offset: 0x00827E1C
	protected virtual void __CPPCALL_ChangeState8_Implementation()
	{
		this.ChangeState8_Implementation();
	}

	// Token: 0x0601D493 RID: 119955 RVA: 0x00829C24 File Offset: 0x00827E24
	protected virtual void __CPPCALL_Create_Implementation()
	{
		this.Create_Implementation();
	}

	// Token: 0x0601D494 RID: 119956 RVA: 0x00829C2C File Offset: 0x00827E2C
	protected virtual void __CPPCALL_Remove_Implementation()
	{
		this.Remove_Implementation();
	}

	// Token: 0x0601D495 RID: 119957 RVA: 0x00829C34 File Offset: 0x00827E34
	protected virtual void __CPPCALL_PrintState_Implementation()
	{
		this.PrintState_Implementation();
	}

	// Token: 0x0601D496 RID: 119958 RVA: 0x00829C3C File Offset: 0x00827E3C
	protected virtual void __CPPCALL_PlaySceneEffect_Implementation()
	{
		this.PlaySceneEffect_Implementation();
	}

	// Token: 0x0601D497 RID: 119959 RVA: 0x00829C44 File Offset: 0x00827E44
	protected virtual void __CPPCALL_ChangeDirection_Implementation()
	{
		this.ChangeDirection_Implementation();
	}

	// Token: 0x0601D498 RID: 119960 RVA: 0x00829C4C File Offset: 0x00827E4C
	protected virtual void __CPPCALL_GetDebugActorRefByKey_Implementation()
	{
		this.GetDebugActorRefByKey_Implementation();
	}

	// Token: 0x0400E6BC RID: 59068
	public ESceneInteractionEffect? EffectKey;

	// Token: 0x0400E6BD RID: 59069
	public EKuroSceneInteractionState? InitState;

	// Token: 0x0400E6BE RID: 59070
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionDebugActor.SceneInteractionDebugActor_C";

	// Token: 0x0400E6BF RID: 59071
	private static IntPtr _ClassPtr;

	// Token: 0x0400E6C0 RID: 59072
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E6C1 RID: 59073
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400E6C2 RID: 59074
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400E6C3 RID: 59075
	private static int __PropertyOffset_HandleId;

	// Token: 0x0400E6C4 RID: 59076
	private static int __PropertyOffset_DebugActorRef;

	// Token: 0x0400E6C5 RID: 59077
	private static int __PropertyOffset_DebugActorKey;

	// Token: 0x0400E6C6 RID: 59078
	private static int __PropertyOffset_NeedTransition;

	// Token: 0x0400E6C7 RID: 59079
	private static int __PropertyOffset_Force;

	// Token: 0x0400E6C8 RID: 59080
	private static int __PropertyOffset_LevelName;

	// Token: 0x0400E6C9 RID: 59081
	private static int __PropertyOffset_CountNumber;

	// Token: 0x0400E6CA RID: 59082
	private static int __PropertyOffset_BaseForce;

	// Token: 0x0400E6CB RID: 59083
	private static int __PropertyOffset_OriginOffset;

	// Token: 0x0400E6CC RID: 59084
	private static int __PropertyOffset_DamageRadius;

	// Token: 0x0400E6CD RID: 59085
	private static int __PropertyOffset_ImpluseFactor;
}
