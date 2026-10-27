using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUChainSimulation
{
	// Token: 0x02003CAF RID: 15535
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/BP_CSChain.BP_CSChain_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_CSChain_C : AKuroCSChain, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060248CB RID: 149707 RVA: 0x00941BF6 File Offset: 0x0093FDF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CSChain_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/BP_CSChain.BP_CSChain_C");
			}
			return BP_CSChain_C._ClassPtr;
		}

		// Token: 0x060248CC RID: 149708 RVA: 0x00941C1C File Offset: 0x0093FE1C
		public BP_CSChain_C() : this(BuiltinUtils.AllocNativeUObject(BP_CSChain_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060248CD RID: 149709 RVA: 0x00941C44 File Offset: 0x0093FE44
		[NullableContext(1)]
		public BP_CSChain_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CSChain_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170047A7 RID: 18343
		// (get) Token: 0x060248CE RID: 149710 RVA: 0x00941C77 File Offset: 0x0093FE77
		// (set) Token: 0x060248CF RID: 149711 RVA: 0x00941C8B File Offset: 0x0093FE8B
		public unsafe UChildActorComponent ChainEnd
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170047A8 RID: 18344
		// (get) Token: 0x060248D0 RID: 149712 RVA: 0x00941CA0 File Offset: 0x0093FEA0
		// (set) Token: 0x060248D1 RID: 149713 RVA: 0x00941CB4 File Offset: 0x0093FEB4
		public unsafe UChildActorComponent ChainStart
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170047A9 RID: 18345
		// (get) Token: 0x060248D2 RID: 149714 RVA: 0x00941CC9 File Offset: 0x0093FEC9
		// (set) Token: 0x060248D3 RID: 149715 RVA: 0x00941CDD File Offset: 0x0093FEDD
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170047AA RID: 18346
		// (get) Token: 0x060248D4 RID: 149716 RVA: 0x00941CF2 File Offset: 0x0093FEF2
		// (set) Token: 0x060248D5 RID: 149717 RVA: 0x00941D06 File Offset: 0x0093FF06
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170047AB RID: 18347
		// (get) Token: 0x060248D6 RID: 149718 RVA: 0x00941D1B File Offset: 0x0093FF1B
		// (set) Token: 0x060248D7 RID: 149719 RVA: 0x00941D2B File Offset: 0x0093FF2B
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047AC RID: 18348
		// (get) Token: 0x060248D8 RID: 149720 RVA: 0x00941D3C File Offset: 0x0093FF3C
		// (set) Token: 0x060248D9 RID: 149721 RVA: 0x00941D4C File Offset: 0x0093FF4C
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170047AD RID: 18349
		// (get) Token: 0x060248DA RID: 149722 RVA: 0x00941D60 File Offset: 0x0093FF60
		// (set) Token: 0x060248DB RID: 149723 RVA: 0x00941D99 File Offset: 0x0093FF99
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Mats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Mats) == null)
				{
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x170047AE RID: 18350
		// (get) Token: 0x060248DC RID: 149724 RVA: 0x00941DA7 File Offset: 0x0093FFA7
		// (set) Token: 0x060248DD RID: 149725 RVA: 0x00941DB7 File Offset: 0x0093FFB7
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047AF RID: 18351
		// (get) Token: 0x060248DE RID: 149726 RVA: 0x00941DC8 File Offset: 0x0093FFC8
		// (set) Token: 0x060248DF RID: 149727 RVA: 0x00941DD8 File Offset: 0x0093FFD8
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x060248E0 RID: 149728 RVA: 0x00941DE9 File Offset: 0x0093FFE9
		// (set) Token: 0x060248E1 RID: 149729 RVA: 0x00941DF9 File Offset: 0x0093FFF9
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047B1 RID: 18353
		// (get) Token: 0x060248E2 RID: 149730 RVA: 0x00941E0A File Offset: 0x0094000A
		// (set) Token: 0x060248E3 RID: 149731 RVA: 0x00941E1A File Offset: 0x0094001A
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047B2 RID: 18354
		// (get) Token: 0x060248E4 RID: 149732 RVA: 0x00941E2B File Offset: 0x0094002B
		// (set) Token: 0x060248E5 RID: 149733 RVA: 0x00941E3F File Offset: 0x0094003F
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170047B3 RID: 18355
		// (get) Token: 0x060248E6 RID: 149734 RVA: 0x00941E54 File Offset: 0x00940054
		// (set) Token: 0x060248E7 RID: 149735 RVA: 0x00941E68 File Offset: 0x00940068
		public unsafe FVector gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170047B4 RID: 18356
		// (get) Token: 0x060248E8 RID: 149736 RVA: 0x00941E7D File Offset: 0x0094007D
		// (set) Token: 0x060248E9 RID: 149737 RVA: 0x00941E91 File Offset: 0x00940091
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170047B5 RID: 18357
		// (get) Token: 0x060248EA RID: 149738 RVA: 0x00941EA6 File Offset: 0x009400A6
		// (set) Token: 0x060248EB RID: 149739 RVA: 0x00941EB6 File Offset: 0x009400B6
		public unsafe float 弹力系数_编译器下可更改_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170047B6 RID: 18358
		// (get) Token: 0x060248EC RID: 149740 RVA: 0x00941EC7 File Offset: 0x009400C7
		// (set) Token: 0x060248ED RID: 149741 RVA: 0x00941ED7 File Offset: 0x009400D7
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047B7 RID: 18359
		// (get) Token: 0x060248EE RID: 149742 RVA: 0x00941EE8 File Offset: 0x009400E8
		// (set) Token: 0x060248EF RID: 149743 RVA: 0x00941EFC File Offset: 0x009400FC
		public unsafe AStaticMeshActor SM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x060248F0 RID: 149744 RVA: 0x00941F11 File Offset: 0x00940111
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x060248F1 RID: 149745 RVA: 0x00941F25 File Offset: 0x00940125
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x060248F2 RID: 149746 RVA: 0x00941F39 File Offset: 0x00940139
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060248F3 RID: 149747 RVA: 0x00941F4D File Offset: 0x0094014D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CSChain_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060248F4 RID: 149748 RVA: 0x00941F62 File Offset: 0x00940162
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060248F5 RID: 149749 RVA: 0x00941F76 File Offset: 0x00940176
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CSChain_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060248F6 RID: 149750 RVA: 0x00941F8C File Offset: 0x0094018C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CSChain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CSChain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CSChain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060248F7 RID: 149751 RVA: 0x00941FD4 File Offset: 0x009401D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CSChain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CSChain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CSChain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CSChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060248F8 RID: 149752 RVA: 0x0094201B File Offset: 0x0094021B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060248F9 RID: 149753 RVA: 0x00942030 File Offset: 0x00940230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_CSChain_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CSChain_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CSChain_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060248FA RID: 149754 RVA: 0x0094207C File Offset: 0x0094027C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_CSChain_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CSChain_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CSChain_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CSChain_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060248FB RID: 149755 RVA: 0x009420C8 File Offset: 0x009402C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060248FC RID: 149756 RVA: 0x00942184 File Offset: 0x00940384
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060248FD RID: 149757 RVA: 0x0094220D File Offset: 0x0094040D
		protected BP_CSChain_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012260 RID: 74336
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/BP_CSChain.BP_CSChain_C";

		// Token: 0x04012261 RID: 74337
		private static IntPtr _ClassPtr;

		// Token: 0x04012262 RID: 74338
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012263 RID: 74339
		internal static int __PropertyOffset_1;

		// Token: 0x04012264 RID: 74340
		internal static int __PropertyOffset_2;

		// Token: 0x04012265 RID: 74341
		internal static int __PropertyOffset_3;

		// Token: 0x04012266 RID: 74342
		internal static int __PropertyOffset_4;

		// Token: 0x04012267 RID: 74343
		internal static int __PropertyOffset_5;

		// Token: 0x04012268 RID: 74344
		internal static int __PropertyOffset_6;

		// Token: 0x04012269 RID: 74345
		internal static int __PropertyOffset_7;

		// Token: 0x0401226A RID: 74346
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x0401226B RID: 74347
		internal static int __PropertyOffset_8;

		// Token: 0x0401226C RID: 74348
		internal static int __PropertyOffset_9;

		// Token: 0x0401226D RID: 74349
		internal static int __PropertyOffset_10;

		// Token: 0x0401226E RID: 74350
		internal static int __PropertyOffset_11;

		// Token: 0x0401226F RID: 74351
		internal static int __PropertyOffset_12;

		// Token: 0x04012270 RID: 74352
		internal static int __PropertyOffset_13;

		// Token: 0x04012271 RID: 74353
		internal static int __PropertyOffset_14;

		// Token: 0x04012272 RID: 74354
		internal static int __PropertyOffset_15;

		// Token: 0x04012273 RID: 74355
		internal static int __PropertyOffset_16;

		// Token: 0x04012274 RID: 74356
		internal static int __PropertyOffset_17;

		// Token: 0x04012275 RID: 74357
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04012276 RID: 74358
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04012277 RID: 74359
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012278 RID: 74360
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012279 RID: 74361
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401227A RID: 74362
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401227B RID: 74363
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0401227C RID: 74364
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401227D RID: 74365
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F37 RID: 40759
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318C1 RID: 202945
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F38 RID: 40760
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040318C2 RID: 202946
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F39 RID: 40761
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318C3 RID: 202947
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040318C4 RID: 202948
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318C5 RID: 202949
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318C6 RID: 202950
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040318C7 RID: 202951
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040318C8 RID: 202952
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F3A RID: 40762
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318C9 RID: 202953
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040318CA RID: 202954
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318CB RID: 202955
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318CC RID: 202956
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
