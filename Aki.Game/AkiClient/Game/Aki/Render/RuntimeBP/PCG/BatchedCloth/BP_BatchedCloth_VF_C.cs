using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BatchedCloth
{
	// Token: 0x02003CD3 RID: 15571
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/BP_BatchedCloth_VF.BP_BatchedCloth_VF_C")]
	[UnrealStructLayout(2696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2692)]
	public class BP_BatchedCloth_VF_C : AKuroCSJacobiCloth, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024EC6 RID: 151238 RVA: 0x0094C3A8 File Offset: 0x0094A5A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BatchedCloth_VF_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/BP_BatchedCloth_VF.BP_BatchedCloth_VF_C");
			}
			return BP_BatchedCloth_VF_C._ClassPtr;
		}

		// Token: 0x06024EC7 RID: 151239 RVA: 0x0094C3CC File Offset: 0x0094A5CC
		public BP_BatchedCloth_VF_C() : this(BuiltinUtils.AllocNativeUObject(BP_BatchedCloth_VF_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024EC8 RID: 151240 RVA: 0x0094C3F4 File Offset: 0x0094A5F4
		[NullableContext(1)]
		public BP_BatchedCloth_VF_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BatchedCloth_VF_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049DD RID: 18909
		// (get) Token: 0x06024EC9 RID: 151241 RVA: 0x0094C427 File Offset: 0x0094A627
		// (set) Token: 0x06024ECA RID: 151242 RVA: 0x0094C43B File Offset: 0x0094A63B
		public unsafe UStaticMeshComponent SM_ClothController
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_VF_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_VF_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170049DE RID: 18910
		// (get) Token: 0x06024ECB RID: 151243 RVA: 0x0094C450 File Offset: 0x0094A650
		// (set) Token: 0x06024ECC RID: 151244 RVA: 0x0094C464 File Offset: 0x0094A664
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_VF_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_VF_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170049DF RID: 18911
		// (get) Token: 0x06024ECD RID: 151245 RVA: 0x0094C479 File Offset: 0x0094A679
		// (set) Token: 0x06024ECE RID: 151246 RVA: 0x0094C489 File Offset: 0x0094A689
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049E0 RID: 18912
		// (get) Token: 0x06024ECF RID: 151247 RVA: 0x0094C49A File Offset: 0x0094A69A
		// (set) Token: 0x06024ED0 RID: 151248 RVA: 0x0094C4AA File Offset: 0x0094A6AA
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049E1 RID: 18913
		// (get) Token: 0x06024ED1 RID: 151249 RVA: 0x0094C4BB File Offset: 0x0094A6BB
		// (set) Token: 0x06024ED2 RID: 151250 RVA: 0x0094C4CF File Offset: 0x0094A6CF
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_VF_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_VF_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170049E2 RID: 18914
		// (get) Token: 0x06024ED3 RID: 151251 RVA: 0x0094C4E4 File Offset: 0x0094A6E4
		// (set) Token: 0x06024ED4 RID: 151252 RVA: 0x0094C4F8 File Offset: 0x0094A6F8
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_VF_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedCloth_VF_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x06024ED5 RID: 151253 RVA: 0x0094C50D File Offset: 0x0094A70D
		// (set) Token: 0x06024ED6 RID: 151254 RVA: 0x0094C51D File Offset: 0x0094A71D
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x06024ED7 RID: 151255 RVA: 0x0094C52E File Offset: 0x0094A72E
		// (set) Token: 0x06024ED8 RID: 151256 RVA: 0x0094C53E File Offset: 0x0094A73E
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x06024ED9 RID: 151257 RVA: 0x0094C54F File Offset: 0x0094A74F
		// (set) Token: 0x06024EDA RID: 151258 RVA: 0x0094C55F File Offset: 0x0094A75F
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x06024EDB RID: 151259 RVA: 0x0094C570 File Offset: 0x0094A770
		// (set) Token: 0x06024EDC RID: 151260 RVA: 0x0094C580 File Offset: 0x0094A780
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x06024EDD RID: 151261 RVA: 0x0094C591 File Offset: 0x0094A791
		// (set) Token: 0x06024EDE RID: 151262 RVA: 0x0094C5A1 File Offset: 0x0094A7A1
		public unsafe bool PlatformCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x06024EDF RID: 151263 RVA: 0x0094C5B2 File Offset: 0x0094A7B2
		// (set) Token: 0x06024EE0 RID: 151264 RVA: 0x0094C5C2 File Offset: 0x0094A7C2
		public unsafe bool debugWindField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x06024EE1 RID: 151265 RVA: 0x0094C5D3 File Offset: 0x0094A7D3
		// (set) Token: 0x06024EE2 RID: 151266 RVA: 0x0094C5E7 File Offset: 0x0094A7E7
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x06024EE3 RID: 151267 RVA: 0x0094C5FC File Offset: 0x0094A7FC
		// (set) Token: 0x06024EE4 RID: 151268 RVA: 0x0094C610 File Offset: 0x0094A810
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x06024EE5 RID: 151269 RVA: 0x0094C625 File Offset: 0x0094A825
		// (set) Token: 0x06024EE6 RID: 151270 RVA: 0x0094C635 File Offset: 0x0094A835
		public unsafe bool bOnlyForHighQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x06024EE7 RID: 151271 RVA: 0x0094C646 File Offset: 0x0094A846
		// (set) Token: 0x06024EE8 RID: 151272 RVA: 0x0094C656 File Offset: 0x0094A856
		public unsafe int HighQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedCloth_VF_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06024EE9 RID: 151273 RVA: 0x0094C667 File Offset: 0x0094A867
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawParticlesOffline_2s_()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__DrawParticlesOffline_2s__NativeFunctionPtr, null);
		}

		// Token: 0x06024EEA RID: 151274 RVA: 0x0094C67B File Offset: 0x0094A87B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024EEB RID: 151275 RVA: 0x0094C68F File Offset: 0x0094A88F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024EEC RID: 151276 RVA: 0x0094C6A4 File Offset: 0x0094A8A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024EED RID: 151277 RVA: 0x0094C6B8 File Offset: 0x0094A8B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024EEE RID: 151278 RVA: 0x0094C6D0 File Offset: 0x0094A8D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BatchedCloth_VF_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BatchedCloth_VF_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BatchedCloth_VF_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_VF_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EEF RID: 151279 RVA: 0x0094C718 File Offset: 0x0094A918
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BatchedCloth_VF_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BatchedCloth_VF_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BatchedCloth_VF_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_VF_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024EF0 RID: 151280 RVA: 0x0094C760 File Offset: 0x0094A960
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_BatchedCloth_VF_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_BatchedCloth_VF_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BatchedCloth_VF_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_VF_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EF1 RID: 151281 RVA: 0x0094C7AC File Offset: 0x0094A9AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_BatchedCloth_VF_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_BatchedCloth_VF_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BatchedCloth_VF_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_VF_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024EF2 RID: 151282 RVA: 0x0094C7F8 File Offset: 0x0094A9F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024EF3 RID: 151283 RVA: 0x0094C80C File Offset: 0x0094AA0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_BatchedCloth_VF_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_BatchedCloth_VF_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_BatchedCloth_VF_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_VF_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EF4 RID: 151284 RVA: 0x0094C870 File Offset: 0x0094AA70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EF5 RID: 151285 RVA: 0x0094C8FC File Offset: 0x0094AAFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024EF6 RID: 151286 RVA: 0x0094C9B6 File Offset: 0x0094ABB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedCloth_VF_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06024EF7 RID: 151287 RVA: 0x0094C9CA File Offset: 0x0094ABCA
		protected BP_BatchedCloth_VF_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125C0 RID: 75200
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/BP_BatchedCloth_VF.BP_BatchedCloth_VF_C";

		// Token: 0x040125C1 RID: 75201
		private static IntPtr _ClassPtr;

		// Token: 0x040125C2 RID: 75202
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125C3 RID: 75203
		internal static int __PropertyOffset_1;

		// Token: 0x040125C4 RID: 75204
		internal static int __PropertyOffset_2;

		// Token: 0x040125C5 RID: 75205
		internal static int __PropertyOffset_3;

		// Token: 0x040125C6 RID: 75206
		internal static int __PropertyOffset_4;

		// Token: 0x040125C7 RID: 75207
		internal static int __PropertyOffset_5;

		// Token: 0x040125C8 RID: 75208
		internal static int __PropertyOffset_6;

		// Token: 0x040125C9 RID: 75209
		internal static int __PropertyOffset_7;

		// Token: 0x040125CA RID: 75210
		internal static int __PropertyOffset_8;

		// Token: 0x040125CB RID: 75211
		internal static int __PropertyOffset_9;

		// Token: 0x040125CC RID: 75212
		internal static int __PropertyOffset_10;

		// Token: 0x040125CD RID: 75213
		internal static int __PropertyOffset_11;

		// Token: 0x040125CE RID: 75214
		internal static int __PropertyOffset_12;

		// Token: 0x040125CF RID: 75215
		internal static int __PropertyOffset_13;

		// Token: 0x040125D0 RID: 75216
		internal static int __PropertyOffset_14;

		// Token: 0x040125D1 RID: 75217
		internal static int __PropertyOffset_15;

		// Token: 0x040125D2 RID: 75218
		internal static int __PropertyOffset_16;

		// Token: 0x040125D3 RID: 75219
		private static IntPtr __DrawParticlesOffline_2s__NativeFunctionPtr;

		// Token: 0x040125D4 RID: 75220
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040125D5 RID: 75221
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040125D6 RID: 75222
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040125D7 RID: 75223
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040125D8 RID: 75224
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040125D9 RID: 75225
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040125DA RID: 75226
		private static IntPtr __BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040125DB RID: 75227
		private static IntPtr __BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040125DC RID: 75228
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x02009F8F RID: 40847
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319BB RID: 203195
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F90 RID: 40848
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040319BC RID: 203196
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F91 RID: 40849
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040319BD RID: 203197
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040319BE RID: 203198
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040319BF RID: 203199
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009F92 RID: 40850
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319C0 RID: 203200
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319C1 RID: 203201
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319C2 RID: 203202
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319C3 RID: 203203
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F93 RID: 40851
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BatchedCloth_2_ManagementBounds_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319C4 RID: 203204
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319C5 RID: 203205
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319C6 RID: 203206
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319C7 RID: 203207
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040319C8 RID: 203208
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040319C9 RID: 203209
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
