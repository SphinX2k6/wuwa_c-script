using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SandTrail
{
	// Token: 0x02003C1E RID: 15390
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BPC_ShachongTrail.BPC_ShachongTrail_C")]
	[UnrealStructLayout(624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 620)]
	public class BPC_ShachongTrail_C : UKuroBPActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023417 RID: 144407 RVA: 0x0091EFBC File Offset: 0x0091D1BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPC_ShachongTrail_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BPC_ShachongTrail.BPC_ShachongTrail_C");
			}
			return BPC_ShachongTrail_C._ClassPtr;
		}

		// Token: 0x06023418 RID: 144408 RVA: 0x0091EFE0 File Offset: 0x0091D1E0
		public BPC_ShachongTrail_C() : this(BuiltinUtils.AllocNativeUObject(BPC_ShachongTrail_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023419 RID: 144409 RVA: 0x0091F008 File Offset: 0x0091D208
		public BPC_ShachongTrail_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPC_ShachongTrail_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x0602341A RID: 144410 RVA: 0x0091F03B File Offset: 0x0091D23B
		// (set) Token: 0x0602341B RID: 144411 RVA: 0x0091F04B File Offset: 0x0091D24B
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x0602341C RID: 144412 RVA: 0x0091F05C File Offset: 0x0091D25C
		// (set) Token: 0x0602341D RID: 144413 RVA: 0x0091F070 File Offset: 0x0091D270
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MDI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_ShachongTrail_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_ShachongTrail_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x0602341E RID: 144414 RVA: 0x0091F085 File Offset: 0x0091D285
		// (set) Token: 0x0602341F RID: 144415 RVA: 0x0091F099 File Offset: 0x0091D299
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MDI_pre
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_ShachongTrail_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_ShachongTrail_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x06023420 RID: 144416 RVA: 0x0091F0B0 File Offset: 0x0091D2B0
		// (set) Token: 0x06023421 RID: 144417 RVA: 0x0091F0E9 File Offset: 0x0091D2E9
		public TArray<FName> BoundBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoundBones) == null)
				{
					result = (this._BoundBones = new TArray<FName>(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.BoundBones.CopyAssign(value);
			}
		}

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x06023422 RID: 144418 RVA: 0x0091F0F8 File Offset: 0x0091D2F8
		// (set) Token: 0x06023423 RID: 144419 RVA: 0x0091F131 File Offset: 0x0091D331
		public TArray<float> tempWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._tempWeights) == null)
				{
					result = (this._tempWeights = new TArray<float>(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.tempWeights.CopyAssign(value);
			}
		}

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x06023424 RID: 144420 RVA: 0x0091F13F File Offset: 0x0091D33F
		// (set) Token: 0x06023425 RID: 144421 RVA: 0x0091F14F File Offset: 0x0091D34F
		public unsafe double FadeDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x06023426 RID: 144422 RVA: 0x0091F160 File Offset: 0x0091D360
		// (set) Token: 0x06023427 RID: 144423 RVA: 0x0091F170 File Offset: 0x0091D370
		public unsafe double FadeDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x06023428 RID: 144424 RVA: 0x0091F181 File Offset: 0x0091D381
		// (set) Token: 0x06023429 RID: 144425 RVA: 0x0091F191 File Offset: 0x0091D391
		public unsafe float tempVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x0602342A RID: 144426 RVA: 0x0091F1A4 File Offset: 0x0091D3A4
		// (set) Token: 0x0602342B RID: 144427 RVA: 0x0091F1DD File Offset: 0x0091D3DD
		public TMap<FName, float> BoundBonesVelocity
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._BoundBonesVelocity) == null)
				{
					result = (this._BoundBonesVelocity = new TMap<FName, float>(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.BoundBonesVelocity.CopyAssign(value);
			}
		}

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x0602342C RID: 144428 RVA: 0x0091F1EC File Offset: 0x0091D3EC
		// (set) Token: 0x0602342D RID: 144429 RVA: 0x0091F225 File Offset: 0x0091D425
		public TMap<FName, FVector> BoundBonesHitPos
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FVector> result;
				if ((result = this._BoundBonesHitPos) == null)
				{
					result = (this._BoundBonesHitPos = new TMap<FName, FVector>(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.BoundBonesHitPos.CopyAssign(value);
			}
		}

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x0602342E RID: 144430 RVA: 0x0091F233 File Offset: 0x0091D433
		// (set) Token: 0x0602342F RID: 144431 RVA: 0x0091F243 File Offset: 0x0091D443
		public unsafe float WorldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x06023430 RID: 144432 RVA: 0x0091F254 File Offset: 0x0091D454
		// (set) Token: 0x06023431 RID: 144433 RVA: 0x0091F268 File Offset: 0x0091D468
		[Nullable(2)]
		public unsafe USkeletalMeshComponent Skeletal_Mesh_Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_ShachongTrail_C.__PropertyOffset_12);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_ShachongTrail_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x06023432 RID: 144434 RVA: 0x0091F27D File Offset: 0x0091D47D
		// (set) Token: 0x06023433 RID: 144435 RVA: 0x0091F291 File Offset: 0x0091D491
		public unsafe FVector LastPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x06023434 RID: 144436 RVA: 0x0091F2A6 File Offset: 0x0091D4A6
		// (set) Token: 0x06023435 RID: 144437 RVA: 0x0091F2BA File Offset: 0x0091D4BA
		public unsafe FVectorDouble SkeletalMeshPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x06023436 RID: 144438 RVA: 0x0091F2CF File Offset: 0x0091D4CF
		// (set) Token: 0x06023437 RID: 144439 RVA: 0x0091F2E3 File Offset: 0x0091D4E3
		[Nullable(2)]
		public unsafe AActor Shachong
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_ShachongTrail_C.__PropertyOffset_15);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_ShachongTrail_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x06023438 RID: 144440 RVA: 0x0091F2F8 File Offset: 0x0091D4F8
		// (set) Token: 0x06023439 RID: 144441 RVA: 0x0091F30C File Offset: 0x0091D50C
		public unsafe FLinearColor tempColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x0602343A RID: 144442 RVA: 0x0091F321 File Offset: 0x0091D521
		// (set) Token: 0x0602343B RID: 144443 RVA: 0x0091F331 File Offset: 0x0091D531
		public unsafe float fadespeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x0602343C RID: 144444 RVA: 0x0091F342 File Offset: 0x0091D542
		// (set) Token: 0x0602343D RID: 144445 RVA: 0x0091F356 File Offset: 0x0091D556
		public unsafe FVector SandHitPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x0602343E RID: 144446 RVA: 0x0091F36B File Offset: 0x0091D56B
		// (set) Token: 0x0602343F RID: 144447 RVA: 0x0091F37B File Offset: 0x0091D57B
		public unsafe float VelocityRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x06023440 RID: 144448 RVA: 0x0091F38C File Offset: 0x0091D58C
		// (set) Token: 0x06023441 RID: 144449 RVA: 0x0091F39C File Offset: 0x0091D59C
		public unsafe float MaxWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x06023442 RID: 144450 RVA: 0x0091F3AD File Offset: 0x0091D5AD
		// (set) Token: 0x06023443 RID: 144451 RVA: 0x0091F3BD File Offset: 0x0091D5BD
		public unsafe float MinWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x06023444 RID: 144452 RVA: 0x0091F3CE File Offset: 0x0091D5CE
		// (set) Token: 0x06023445 RID: 144453 RVA: 0x0091F3E2 File Offset: 0x0091D5E2
		public unsafe FVector ActivePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x06023446 RID: 144454 RVA: 0x0091F3F8 File Offset: 0x0091D5F8
		// (set) Token: 0x06023447 RID: 144455 RVA: 0x0091F431 File Offset: 0x0091D631
		public TArray<FName> BoundBonesMatparams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoundBonesMatparams) == null)
				{
					result = (this._BoundBonesMatparams = new TArray<FName>(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				this.BoundBonesMatparams.CopyAssign(value);
			}
		}

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x06023448 RID: 144456 RVA: 0x0091F43F File Offset: 0x0091D63F
		// (set) Token: 0x06023449 RID: 144457 RVA: 0x0091F44F File Offset: 0x0091D64F
		public unsafe float MaxHitHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x0602344A RID: 144458 RVA: 0x0091F460 File Offset: 0x0091D660
		// (set) Token: 0x0602344B RID: 144459 RVA: 0x0091F474 File Offset: 0x0091D674
		public unsafe FVector WorldOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x0602344C RID: 144460 RVA: 0x0091F489 File Offset: 0x0091D689
		// (set) Token: 0x0602344D RID: 144461 RVA: 0x0091F499 File Offset: 0x0091D699
		public unsafe int NowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_ShachongTrail_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x0602344E RID: 144462 RVA: 0x0091F4AA File Offset: 0x0091D6AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPC_ShachongTrail_C.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x0602344F RID: 144463 RVA: 0x0091F4C0 File Offset: 0x0091D6C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual float CaclChacaterAttenuation(FVector InVec)
		{
			BPC_ShachongTrail_C.__CaclChacaterAttenuation_FunctionParams* ptr = stackalloc BPC_ShachongTrail_C.__CaclChacaterAttenuation_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BPC_ShachongTrail_C.__CaclChacaterAttenuation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPC_ShachongTrail_C.__CaclChacaterAttenuation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVec = InVec;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPC_ShachongTrail_C.__CaclChacaterAttenuation_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06023450 RID: 144464 RVA: 0x0091F50F File Offset: 0x0091D70F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPC_ShachongTrail_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023451 RID: 144465 RVA: 0x0091F523 File Offset: 0x0091D723
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BPC_ShachongTrail_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023452 RID: 144466 RVA: 0x0091F538 File Offset: 0x0091D738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BPC_ShachongTrail_C.__ReceiveTick_FunctionParams* ptr = stackalloc BPC_ShachongTrail_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BPC_ShachongTrail_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPC_ShachongTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPC_ShachongTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023453 RID: 144467 RVA: 0x0091F580 File Offset: 0x0091D780
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BPC_ShachongTrail_C.__ReceiveTick_FunctionParams* ptr = stackalloc BPC_ShachongTrail_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BPC_ShachongTrail_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPC_ShachongTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BPC_ShachongTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023454 RID: 144468 RVA: 0x0091F5C8 File Offset: 0x0091D7C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BPC_ShachongTrail_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BPC_ShachongTrail_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BPC_ShachongTrail_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPC_ShachongTrail_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPC_ShachongTrail_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023455 RID: 144469 RVA: 0x0091F614 File Offset: 0x0091D814
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BPC_ShachongTrail_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BPC_ShachongTrail_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BPC_ShachongTrail_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPC_ShachongTrail_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BPC_ShachongTrail_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023456 RID: 144470 RVA: 0x0091F660 File Offset: 0x0091D860
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPC_ShachongTrail_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06023457 RID: 144471 RVA: 0x0091F674 File Offset: 0x0091D874
		protected BPC_ShachongTrail_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011629 RID: 71209
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BPC_ShachongTrail.BPC_ShachongTrail_C";

		// Token: 0x0401162A RID: 71210
		private static IntPtr _ClassPtr;

		// Token: 0x0401162B RID: 71211
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401162C RID: 71212
		internal static int __PropertyOffset_1;

		// Token: 0x0401162D RID: 71213
		internal static int __PropertyOffset_2;

		// Token: 0x0401162E RID: 71214
		internal static int __PropertyOffset_3;

		// Token: 0x0401162F RID: 71215
		internal static int __PropertyOffset_4;

		// Token: 0x04011630 RID: 71216
		[Nullable(2)]
		private TArray<FName> _BoundBones;

		// Token: 0x04011631 RID: 71217
		internal static int __PropertyOffset_5;

		// Token: 0x04011632 RID: 71218
		[Nullable(2)]
		private TArray<float> _tempWeights;

		// Token: 0x04011633 RID: 71219
		internal static int __PropertyOffset_6;

		// Token: 0x04011634 RID: 71220
		internal static int __PropertyOffset_7;

		// Token: 0x04011635 RID: 71221
		internal static int __PropertyOffset_8;

		// Token: 0x04011636 RID: 71222
		internal static int __PropertyOffset_9;

		// Token: 0x04011637 RID: 71223
		[Nullable(2)]
		private TMap<FName, float> _BoundBonesVelocity;

		// Token: 0x04011638 RID: 71224
		internal static int __PropertyOffset_10;

		// Token: 0x04011639 RID: 71225
		[Nullable(2)]
		private TMap<FName, FVector> _BoundBonesHitPos;

		// Token: 0x0401163A RID: 71226
		internal static int __PropertyOffset_11;

		// Token: 0x0401163B RID: 71227
		internal static int __PropertyOffset_12;

		// Token: 0x0401163C RID: 71228
		internal static int __PropertyOffset_13;

		// Token: 0x0401163D RID: 71229
		internal static int __PropertyOffset_14;

		// Token: 0x0401163E RID: 71230
		internal static int __PropertyOffset_15;

		// Token: 0x0401163F RID: 71231
		internal static int __PropertyOffset_16;

		// Token: 0x04011640 RID: 71232
		internal static int __PropertyOffset_17;

		// Token: 0x04011641 RID: 71233
		internal static int __PropertyOffset_18;

		// Token: 0x04011642 RID: 71234
		internal static int __PropertyOffset_19;

		// Token: 0x04011643 RID: 71235
		internal static int __PropertyOffset_20;

		// Token: 0x04011644 RID: 71236
		internal static int __PropertyOffset_21;

		// Token: 0x04011645 RID: 71237
		internal static int __PropertyOffset_22;

		// Token: 0x04011646 RID: 71238
		internal static int __PropertyOffset_23;

		// Token: 0x04011647 RID: 71239
		[Nullable(2)]
		private TArray<FName> _BoundBonesMatparams;

		// Token: 0x04011648 RID: 71240
		internal static int __PropertyOffset_24;

		// Token: 0x04011649 RID: 71241
		internal static int __PropertyOffset_25;

		// Token: 0x0401164A RID: 71242
		internal static int __PropertyOffset_26;

		// Token: 0x0401164B RID: 71243
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x0401164C RID: 71244
		private static IntPtr __CaclChacaterAttenuation_NativeFunctionPtr;

		// Token: 0x0401164D RID: 71245
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401164E RID: 71246
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401164F RID: 71247
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04011650 RID: 71248
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x02009E44 RID: 40516
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __CaclChacaterAttenuation_FunctionParams
		{
			// Token: 0x040316B5 RID: 202421
			[FieldOffset(0)]
			public FVector InVec;

			// Token: 0x040316B6 RID: 202422
			[FieldOffset(12)]
			public float __Result;
		}

		// Token: 0x02009E45 RID: 40517
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316B7 RID: 202423
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E46 RID: 40518
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040316B8 RID: 202424
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
