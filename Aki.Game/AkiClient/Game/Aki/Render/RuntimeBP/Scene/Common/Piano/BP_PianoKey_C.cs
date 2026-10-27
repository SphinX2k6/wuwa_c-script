using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.Piano
{
	// Token: 0x02003B67 RID: 15207
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoKey.BP_PianoKey_C")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1269)]
	public class BP_PianoKey_C : AActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06021C9D RID: 138397 RVA: 0x008F5D01 File Offset: 0x008F3F01
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PianoKey_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoKey.BP_PianoKey_C");
			}
			return BP_PianoKey_C._ClassPtr;
		}

		// Token: 0x06021C9E RID: 138398 RVA: 0x008F5D25 File Offset: 0x008F3F25
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return BP_PianoKey_C.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x06021C9F RID: 138399 RVA: 0x008F5D2C File Offset: 0x008F3F2C
		public BP_PianoKey_C() : this(BuiltinUtils.AllocNativeUObject(BP_PianoKey_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021CA0 RID: 138400 RVA: 0x008F5D54 File Offset: 0x008F3F54
		[NullableContext(1)]
		public BP_PianoKey_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PianoKey_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x06021CA1 RID: 138401 RVA: 0x008F5D87 File Offset: 0x008F3F87
		// (set) Token: 0x06021CA2 RID: 138402 RVA: 0x008F5D9B File Offset: 0x008F3F9B
		public unsafe USceneComponent Effect_Slot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x06021CA3 RID: 138403 RVA: 0x008F5DB0 File Offset: 0x008F3FB0
		// (set) Token: 0x06021CA4 RID: 138404 RVA: 0x008F5DC4 File Offset: 0x008F3FC4
		public unsafe UBoxComponent BoxCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x06021CA5 RID: 138405 RVA: 0x008F5DD9 File Offset: 0x008F3FD9
		// (set) Token: 0x06021CA6 RID: 138406 RVA: 0x008F5DED File Offset: 0x008F3FED
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x06021CA7 RID: 138407 RVA: 0x008F5E02 File Offset: 0x008F4002
		// (set) Token: 0x06021CA8 RID: 138408 RVA: 0x008F5E16 File Offset: 0x008F4016
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x06021CA9 RID: 138409 RVA: 0x008F5E2B File Offset: 0x008F402B
		// (set) Token: 0x06021CAA RID: 138410 RVA: 0x008F5E3F File Offset: 0x008F403F
		public unsafe FLinearColor PressKey_Material_Emission_Color_9732C74A4AA26579682CB0A93FCAF28C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x06021CAB RID: 138411 RVA: 0x008F5E54 File Offset: 0x008F4054
		// (set) Token: 0x06021CAC RID: 138412 RVA: 0x008F5E68 File Offset: 0x008F4068
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> PressKey_Material__Direction_9732C74A4AA26579682CB0A93FCAF28C
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x06021CAD RID: 138413 RVA: 0x008F5E7D File Offset: 0x008F407D
		// (set) Token: 0x06021CAE RID: 138414 RVA: 0x008F5E91 File Offset: 0x008F4091
		public unsafe UTimelineComponent PressKey_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x06021CAF RID: 138415 RVA: 0x008F5EA6 File Offset: 0x008F40A6
		// (set) Token: 0x06021CB0 RID: 138416 RVA: 0x008F5EB6 File Offset: 0x008F40B6
		public unsafe float PressKey_Animation_PressAlpha_6091365E42EA7766A18EF8A4A338DA23
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x06021CB1 RID: 138417 RVA: 0x008F5EC7 File Offset: 0x008F40C7
		// (set) Token: 0x06021CB2 RID: 138418 RVA: 0x008F5EDB File Offset: 0x008F40DB
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> PressKey_Animation__Direction_6091365E42EA7766A18EF8A4A338DA23
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_9);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x06021CB3 RID: 138419 RVA: 0x008F5EF0 File Offset: 0x008F40F0
		// (set) Token: 0x06021CB4 RID: 138420 RVA: 0x008F5F04 File Offset: 0x008F4104
		public unsafe UTimelineComponent PressKey_Animation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x06021CB5 RID: 138421 RVA: 0x008F5F19 File Offset: 0x008F4119
		// (set) Token: 0x06021CB6 RID: 138422 RVA: 0x008F5F2D File Offset: 0x008F412D
		[Nullable(0)]
		public unsafe TEnumAsByte<PianoKeyEnum> PianoKeyTyoe
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x06021CB7 RID: 138423 RVA: 0x008F5F44 File Offset: 0x008F4144
		// (set) Token: 0x06021CB8 RID: 138424 RVA: 0x008F5F7D File Offset: 0x008F417D
		[Nullable(1)]
		public EventDispatcher EventDispatcher
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				EventDispatcher result;
				if ((result = this._EventDispatcher) == null)
				{
					result = (this._EventDispatcher = new EventDispatcher(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_12, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x06021CB9 RID: 138425 RVA: 0x008F5F9E File Offset: 0x008F419E
		// (set) Token: 0x06021CBA RID: 138426 RVA: 0x008F5FAE File Offset: 0x008F41AE
		public unsafe bool IsPressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x06021CBB RID: 138427 RVA: 0x008F5FBF File Offset: 0x008F41BF
		// (set) Token: 0x06021CBC RID: 138428 RVA: 0x008F5FD3 File Offset: 0x008F41D3
		public unsafe UStaticMesh KeyMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x06021CBD RID: 138429 RVA: 0x008F5FE8 File Offset: 0x008F41E8
		// (set) Token: 0x06021CBE RID: 138430 RVA: 0x008F5FFC File Offset: 0x008F41FC
		public unsafe FVector CollisionExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x06021CBF RID: 138431 RVA: 0x008F6011 File Offset: 0x008F4211
		// (set) Token: 0x06021CC0 RID: 138432 RVA: 0x008F6025 File Offset: 0x008F4225
		public unsafe FVector CollisionLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x06021CC1 RID: 138433 RVA: 0x008F603A File Offset: 0x008F423A
		// (set) Token: 0x06021CC2 RID: 138434 RVA: 0x008F604E File Offset: 0x008F424E
		public unsafe FRotator CollisionRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x06021CC3 RID: 138435 RVA: 0x008F6063 File Offset: 0x008F4263
		// (set) Token: 0x06021CC4 RID: 138436 RVA: 0x008F6073 File Offset: 0x008F4273
		public unsafe bool IsPressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x06021CC5 RID: 138437 RVA: 0x008F6084 File Offset: 0x008F4284
		// (set) Token: 0x06021CC6 RID: 138438 RVA: 0x008F6098 File Offset: 0x008F4298
		public unsafe FRotator CurrentRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x06021CC7 RID: 138439 RVA: 0x008F60AD File Offset: 0x008F42AD
		// (set) Token: 0x06021CC8 RID: 138440 RVA: 0x008F60C1 File Offset: 0x008F42C1
		public unsafe UObject PressedEffectDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x06021CC9 RID: 138441 RVA: 0x008F60D8 File Offset: 0x008F42D8
		// (set) Token: 0x06021CCA RID: 138442 RVA: 0x008F6111 File Offset: 0x008F4311
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> MaterialInstanceArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MaterialInstanceArray) == null)
				{
					result = (this._MaterialInstanceArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_21, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceArray.CopyAssign(value);
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x06021CCB RID: 138443 RVA: 0x008F611F File Offset: 0x008F431F
		// (set) Token: 0x06021CCC RID: 138444 RVA: 0x008F6133 File Offset: 0x008F4333
		public unsafe FVector EffectSlotLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x06021CCD RID: 138445 RVA: 0x008F6148 File Offset: 0x008F4348
		// (set) Token: 0x06021CCE RID: 138446 RVA: 0x008F6158 File Offset: 0x008F4358
		public unsafe bool PressByBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021CCF RID: 138447 RVA: 0x008F6169 File Offset: 0x008F4369
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Tick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__Tick_NativeFunctionPtr, null);
		}

		// Token: 0x06021CD0 RID: 138448 RVA: 0x008F617D File Offset: 0x008F437D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021CD1 RID: 138449 RVA: 0x008F6191 File Offset: 0x008F4391
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PianoKey_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021CD2 RID: 138450 RVA: 0x008F61A6 File Offset: 0x008F43A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PressKey_Animation__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__PressKey_Animation__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021CD3 RID: 138451 RVA: 0x008F61BA File Offset: 0x008F43BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PressKey_Animation__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__PressKey_Animation__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021CD4 RID: 138452 RVA: 0x008F61CE File Offset: 0x008F43CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PressKey_Material__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__PressKey_Material__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021CD5 RID: 138453 RVA: 0x008F61E2 File Offset: 0x008F43E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PressKey_Material__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__PressKey_Material__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021CD6 RID: 138454 RVA: 0x008F61F6 File Offset: 0x008F43F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021CD7 RID: 138455 RVA: 0x008F620A File Offset: 0x008F440A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PianoKey_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021CD8 RID: 138456 RVA: 0x008F6220 File Offset: 0x008F4420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021CD9 RID: 138457 RVA: 0x008F62DC File Offset: 0x008F44DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021CDA RID: 138458 RVA: 0x008F6365 File Offset: 0x008F4565
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x06021CDB RID: 138459 RVA: 0x008F637C File Offset: 0x008F457C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_PianoKey_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_PianoKey_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_PianoKey_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PianoKey_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021CDC RID: 138460 RVA: 0x008F63D0 File Offset: 0x008F45D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_PianoKey_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_PianoKey_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_PianoKey_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PianoKey_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PianoKey_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021CDD RID: 138461 RVA: 0x008F6423 File Offset: 0x008F4623
		protected BP_PianoKey_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107E5 RID: 67557
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x040107E6 RID: 67558
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoKey.BP_PianoKey_C";

		// Token: 0x040107E7 RID: 67559
		private static IntPtr _ClassPtr;

		// Token: 0x040107E8 RID: 67560
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040107E9 RID: 67561
		public static IntPtr __EventDispatcher__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040107EA RID: 67562
		internal static int __PropertyOffset_1;

		// Token: 0x040107EB RID: 67563
		internal static int __PropertyOffset_2;

		// Token: 0x040107EC RID: 67564
		internal static int __PropertyOffset_3;

		// Token: 0x040107ED RID: 67565
		internal static int __PropertyOffset_4;

		// Token: 0x040107EE RID: 67566
		internal static int __PropertyOffset_5;

		// Token: 0x040107EF RID: 67567
		internal static int __PropertyOffset_6;

		// Token: 0x040107F0 RID: 67568
		internal static int __PropertyOffset_7;

		// Token: 0x040107F1 RID: 67569
		internal static int __PropertyOffset_8;

		// Token: 0x040107F2 RID: 67570
		internal static int __PropertyOffset_9;

		// Token: 0x040107F3 RID: 67571
		internal static int __PropertyOffset_10;

		// Token: 0x040107F4 RID: 67572
		internal static int __PropertyOffset_11;

		// Token: 0x040107F5 RID: 67573
		internal static int __PropertyOffset_12;

		// Token: 0x040107F6 RID: 67574
		private EventDispatcher _EventDispatcher;

		// Token: 0x040107F7 RID: 67575
		internal static int __PropertyOffset_13;

		// Token: 0x040107F8 RID: 67576
		internal static int __PropertyOffset_14;

		// Token: 0x040107F9 RID: 67577
		internal static int __PropertyOffset_15;

		// Token: 0x040107FA RID: 67578
		internal static int __PropertyOffset_16;

		// Token: 0x040107FB RID: 67579
		internal static int __PropertyOffset_17;

		// Token: 0x040107FC RID: 67580
		internal static int __PropertyOffset_18;

		// Token: 0x040107FD RID: 67581
		internal static int __PropertyOffset_19;

		// Token: 0x040107FE RID: 67582
		internal static int __PropertyOffset_20;

		// Token: 0x040107FF RID: 67583
		internal static int __PropertyOffset_21;

		// Token: 0x04010800 RID: 67584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MaterialInstanceArray;

		// Token: 0x04010801 RID: 67585
		internal static int __PropertyOffset_22;

		// Token: 0x04010802 RID: 67586
		internal static int __PropertyOffset_23;

		// Token: 0x04010803 RID: 67587
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04010804 RID: 67588
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010805 RID: 67589
		private static IntPtr __PressKey_Animation__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04010806 RID: 67590
		private static IntPtr __PressKey_Animation__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04010807 RID: 67591
		private static IntPtr __PressKey_Material__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04010808 RID: 67592
		private static IntPtr __PressKey_Material__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04010809 RID: 67593
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401080A RID: 67594
		private static IntPtr __BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401080B RID: 67595
		private static IntPtr __BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401080C RID: 67596
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x0401080D RID: 67597
		private static IntPtr __OnBulletHit_NativeFunctionPtr;

		// Token: 0x02009CD2 RID: 40146
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040313B8 RID: 201656
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040313B9 RID: 201657
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040313BA RID: 201658
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040313BB RID: 201659
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040313BC RID: 201660
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040313BD RID: 201661
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009CD3 RID: 40147
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040313BE RID: 201662
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040313BF RID: 201663
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040313C0 RID: 201664
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040313C1 RID: 201665
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009CD4 RID: 40148
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x040313C2 RID: 201666
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x040313C3 RID: 201667
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}
	}
}
