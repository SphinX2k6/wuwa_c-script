using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002A06 RID: 10758
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionDebugActor.SceneInteractionDebugActor_C")]
public class SceneInteractionDebugActor : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002C31 RID: 11313
	// (get) Token: 0x0601B14D RID: 110925 RVA: 0x00850038 File Offset: 0x0084E238
	// (set) Token: 0x0601B14E RID: 110926 RVA: 0x00850048 File Offset: 0x0084E248
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

	// Token: 0x17002C32 RID: 11314
	// (get) Token: 0x0601B14F RID: 110927 RVA: 0x00850059 File Offset: 0x0084E259
	// (set) Token: 0x0601B150 RID: 110928 RVA: 0x0085006D File Offset: 0x0084E26D
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

	// Token: 0x17002C33 RID: 11315
	// (get) Token: 0x0601B151 RID: 110929 RVA: 0x00850082 File Offset: 0x0084E282
	// (set) Token: 0x0601B152 RID: 110930 RVA: 0x00850096 File Offset: 0x0084E296
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

	// Token: 0x17002C34 RID: 11316
	// (get) Token: 0x0601B153 RID: 110931 RVA: 0x008500AB File Offset: 0x0084E2AB
	// (set) Token: 0x0601B154 RID: 110932 RVA: 0x008500BB File Offset: 0x0084E2BB
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

	// Token: 0x17002C35 RID: 11317
	// (get) Token: 0x0601B155 RID: 110933 RVA: 0x008500CC File Offset: 0x0084E2CC
	// (set) Token: 0x0601B156 RID: 110934 RVA: 0x008500DC File Offset: 0x0084E2DC
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

	// Token: 0x17002C36 RID: 11318
	// (get) Token: 0x0601B157 RID: 110935 RVA: 0x008500ED File Offset: 0x0084E2ED
	// (set) Token: 0x0601B158 RID: 110936 RVA: 0x00850101 File Offset: 0x0084E301
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

	// Token: 0x17002C37 RID: 11319
	// (get) Token: 0x0601B159 RID: 110937 RVA: 0x00850116 File Offset: 0x0084E316
	// (set) Token: 0x0601B15A RID: 110938 RVA: 0x00850126 File Offset: 0x0084E326
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

	// Token: 0x17002C38 RID: 11320
	// (get) Token: 0x0601B15B RID: 110939 RVA: 0x00850137 File Offset: 0x0084E337
	// (set) Token: 0x0601B15C RID: 110940 RVA: 0x00850147 File Offset: 0x0084E347
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

	// Token: 0x17002C39 RID: 11321
	// (get) Token: 0x0601B15D RID: 110941 RVA: 0x00850158 File Offset: 0x0084E358
	// (set) Token: 0x0601B15E RID: 110942 RVA: 0x0085016C File Offset: 0x0084E36C
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

	// Token: 0x17002C3A RID: 11322
	// (get) Token: 0x0601B15F RID: 110943 RVA: 0x00850181 File Offset: 0x0084E381
	// (set) Token: 0x0601B160 RID: 110944 RVA: 0x00850191 File Offset: 0x0084E391
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

	// Token: 0x17002C3B RID: 11323
	// (get) Token: 0x0601B161 RID: 110945 RVA: 0x008501A2 File Offset: 0x0084E3A2
	// (set) Token: 0x0601B162 RID: 110946 RVA: 0x008501B2 File Offset: 0x0084E3B2
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

	// Token: 0x0601B163 RID: 110947 RVA: 0x008501C4 File Offset: 0x0084E3C4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B164 RID: 110948 RVA: 0x0085021D File Offset: 0x0084E41D
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.HandleId = -1;
	}

	// Token: 0x0601B165 RID: 110949 RVA: 0x00850228 File Offset: 0x0084E428
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState1()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState1"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState1_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B166 RID: 110950 RVA: 0x00850284 File Offset: 0x0084E484
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

	// Token: 0x0601B167 RID: 110951 RVA: 0x008502E4 File Offset: 0x0084E4E4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState2()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState2"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState2_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B168 RID: 110952 RVA: 0x00850340 File Offset: 0x0084E540
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

	// Token: 0x0601B169 RID: 110953 RVA: 0x008503A0 File Offset: 0x0084E5A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState3()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState3"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState3_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B16A RID: 110954 RVA: 0x008503FC File Offset: 0x0084E5FC
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

	// Token: 0x0601B16B RID: 110955 RVA: 0x0085045C File Offset: 0x0084E65C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState4()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState4"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState4_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B16C RID: 110956 RVA: 0x008504B8 File Offset: 0x0084E6B8
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

	// Token: 0x0601B16D RID: 110957 RVA: 0x00850518 File Offset: 0x0084E718
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState5()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState5"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState5_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B16E RID: 110958 RVA: 0x00850574 File Offset: 0x0084E774
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

	// Token: 0x0601B16F RID: 110959 RVA: 0x008505D4 File Offset: 0x0084E7D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState6()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState6"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState6_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B170 RID: 110960 RVA: 0x00850630 File Offset: 0x0084E830
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

	// Token: 0x0601B171 RID: 110961 RVA: 0x00850690 File Offset: 0x0084E890
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState7()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState7"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState7_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B172 RID: 110962 RVA: 0x008506EC File Offset: 0x0084E8EC
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

	// Token: 0x0601B173 RID: 110963 RVA: 0x0085074C File Offset: 0x0084E94C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeState8()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeState8"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeState8_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B174 RID: 110964 RVA: 0x008507A8 File Offset: 0x0084E9A8
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

	// Token: 0x0601B175 RID: 110965 RVA: 0x00850808 File Offset: 0x0084EA08
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Create()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Create"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Create_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B176 RID: 110966 RVA: 0x00850864 File Offset: 0x0084EA64
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

	// Token: 0x0601B177 RID: 110967 RVA: 0x00850928 File Offset: 0x0084EB28
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Remove()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Remove"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Remove_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B178 RID: 110968 RVA: 0x00850984 File Offset: 0x0084EB84
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

	// Token: 0x0601B179 RID: 110969 RVA: 0x008509E4 File Offset: 0x0084EBE4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void PrintState()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PrintState"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.PrintState_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B17A RID: 110970 RVA: 0x00850A3D File Offset: 0x0084EC3D
	protected void PrintState_Implementation()
	{
		int handleId = this.HandleId;
	}

	// Token: 0x0601B17B RID: 110971 RVA: 0x00850A48 File Offset: 0x0084EC48
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void PlaySceneEffect()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PlaySceneEffect"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.PlaySceneEffect_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B17C RID: 110972 RVA: 0x00850AA1 File Offset: 0x0084ECA1
	protected void PlaySceneEffect_Implementation()
	{
		if (this.HandleId >= 0)
		{
			SceneInteractionManager.Get().PlaySceneInteractionEffect(this.HandleId, this.EffectKey.Value);
		}
	}

	// Token: 0x0601B17D RID: 110973 RVA: 0x00850AC8 File Offset: 0x0084ECC8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ChangeDirection()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeDirection"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ChangeDirection_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B17E RID: 110974 RVA: 0x00850B21 File Offset: 0x0084ED21
	protected void ChangeDirection_Implementation()
	{
		if (this.HandleId >= 0)
		{
			this.CountNumber += 1f;
			SceneInteractionManager.Get().ChangeSceneInteractionPlayDirection(this.HandleId, this.CountNumber % 2f == 0f);
		}
	}

	// Token: 0x0601B17F RID: 110975 RVA: 0x00850B64 File Offset: 0x0084ED64
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void GetDebugActorRefByKey()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDebugActorRefByKey"), SceneInteractionDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.GetDebugActorRefByKey_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B180 RID: 110976 RVA: 0x00850BC0 File Offset: 0x0084EDC0
	protected void GetDebugActorRefByKey_Implementation()
	{
		if (this.HandleId >= 0)
		{
			AActor sceneInteractionActorByKey = SceneInteractionManager.Get().GetSceneInteractionActorByKey(this.HandleId, this.DebugActorKey);
			this.HandleId = -1;
			this.DebugActorRef = sceneInteractionActorByKey;
		}
	}

	// Token: 0x0601B181 RID: 110977 RVA: 0x00850BFB File Offset: 0x0084EDFB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SceneInteractionDebugActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionDebugActor.SceneInteractionDebugActor_C");
		}
		return SceneInteractionDebugActor._ClassPtr;
	}

	// Token: 0x0601B182 RID: 110978 RVA: 0x00850C20 File Offset: 0x0084EE20
	public SceneInteractionDebugActor() : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B183 RID: 110979 RVA: 0x00850C48 File Offset: 0x0084EE48
	public SceneInteractionDebugActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B184 RID: 110980 RVA: 0x00850C7B File Offset: 0x0084EE7B
	protected SceneInteractionDebugActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17002C3C RID: 11324
	// (get) Token: 0x0601B185 RID: 110981 RVA: 0x00850C84 File Offset: 0x0084EE84
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionDebugActor.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601B186 RID: 110982 RVA: 0x00850C98 File Offset: 0x0084EE98
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601B187 RID: 110983 RVA: 0x00850CA0 File Offset: 0x0084EEA0
	protected virtual void __CPPCALL_ChangeState1_Implementation()
	{
		this.ChangeState1_Implementation();
	}

	// Token: 0x0601B188 RID: 110984 RVA: 0x00850CA8 File Offset: 0x0084EEA8
	protected virtual void __CPPCALL_ChangeState2_Implementation()
	{
		this.ChangeState2_Implementation();
	}

	// Token: 0x0601B189 RID: 110985 RVA: 0x00850CB0 File Offset: 0x0084EEB0
	protected virtual void __CPPCALL_ChangeState3_Implementation()
	{
		this.ChangeState3_Implementation();
	}

	// Token: 0x0601B18A RID: 110986 RVA: 0x00850CB8 File Offset: 0x0084EEB8
	protected virtual void __CPPCALL_ChangeState4_Implementation()
	{
		this.ChangeState4_Implementation();
	}

	// Token: 0x0601B18B RID: 110987 RVA: 0x00850CC0 File Offset: 0x0084EEC0
	protected virtual void __CPPCALL_ChangeState5_Implementation()
	{
		this.ChangeState5_Implementation();
	}

	// Token: 0x0601B18C RID: 110988 RVA: 0x00850CC8 File Offset: 0x0084EEC8
	protected virtual void __CPPCALL_ChangeState6_Implementation()
	{
		this.ChangeState6_Implementation();
	}

	// Token: 0x0601B18D RID: 110989 RVA: 0x00850CD0 File Offset: 0x0084EED0
	protected virtual void __CPPCALL_ChangeState7_Implementation()
	{
		this.ChangeState7_Implementation();
	}

	// Token: 0x0601B18E RID: 110990 RVA: 0x00850CD8 File Offset: 0x0084EED8
	protected virtual void __CPPCALL_ChangeState8_Implementation()
	{
		this.ChangeState8_Implementation();
	}

	// Token: 0x0601B18F RID: 110991 RVA: 0x00850CE0 File Offset: 0x0084EEE0
	protected virtual void __CPPCALL_Create_Implementation()
	{
		this.Create_Implementation();
	}

	// Token: 0x0601B190 RID: 110992 RVA: 0x00850CE8 File Offset: 0x0084EEE8
	protected virtual void __CPPCALL_Remove_Implementation()
	{
		this.Remove_Implementation();
	}

	// Token: 0x0601B191 RID: 110993 RVA: 0x00850CF0 File Offset: 0x0084EEF0
	protected virtual void __CPPCALL_PrintState_Implementation()
	{
		this.PrintState_Implementation();
	}

	// Token: 0x0601B192 RID: 110994 RVA: 0x00850CF8 File Offset: 0x0084EEF8
	protected virtual void __CPPCALL_PlaySceneEffect_Implementation()
	{
		this.PlaySceneEffect_Implementation();
	}

	// Token: 0x0601B193 RID: 110995 RVA: 0x00850D00 File Offset: 0x0084EF00
	protected virtual void __CPPCALL_ChangeDirection_Implementation()
	{
		this.ChangeDirection_Implementation();
	}

	// Token: 0x0601B194 RID: 110996 RVA: 0x00850D08 File Offset: 0x0084EF08
	protected virtual void __CPPCALL_GetDebugActorRefByKey_Implementation()
	{
		this.GetDebugActorRefByKey_Implementation();
	}

	// Token: 0x0400EB72 RID: 60274
	public ESceneInteractionEffect? EffectKey;

	// Token: 0x0400EB73 RID: 60275
	public EKuroSceneInteractionState? InitState;

	// Token: 0x0400EB74 RID: 60276
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/SceneInteractionDebugActor.SceneInteractionDebugActor_C";

	// Token: 0x0400EB75 RID: 60277
	private static IntPtr _ClassPtr;

	// Token: 0x0400EB76 RID: 60278
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EB77 RID: 60279
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400EB78 RID: 60280
	private static int __PropertyOffset_HandleId;

	// Token: 0x0400EB79 RID: 60281
	private static int __PropertyOffset_DebugActorRef;

	// Token: 0x0400EB7A RID: 60282
	private static int __PropertyOffset_DebugActorKey;

	// Token: 0x0400EB7B RID: 60283
	private static int __PropertyOffset_NeedTransition;

	// Token: 0x0400EB7C RID: 60284
	private static int __PropertyOffset_Force;

	// Token: 0x0400EB7D RID: 60285
	private static int __PropertyOffset_LevelName;

	// Token: 0x0400EB7E RID: 60286
	private static int __PropertyOffset_CountNumber;

	// Token: 0x0400EB7F RID: 60287
	private static int __PropertyOffset_BaseForce;

	// Token: 0x0400EB80 RID: 60288
	private static int __PropertyOffset_OriginOffset;

	// Token: 0x0400EB81 RID: 60289
	private static int __PropertyOffset_DamageRadius;

	// Token: 0x0400EB82 RID: 60290
	private static int __PropertyOffset_ImpluseFactor;
}
