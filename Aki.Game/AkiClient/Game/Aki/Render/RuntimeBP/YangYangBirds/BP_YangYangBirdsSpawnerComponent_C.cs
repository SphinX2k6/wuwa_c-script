using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.YangYangBirds
{
	// Token: 0x02003A75 RID: 14965
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangYangBirdsSpawnerComponent.BP_YangYangBirdsSpawnerComponent_C")]
	[UnrealStructLayout(704, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 702)]
	public class BP_YangYangBirdsSpawnerComponent_C : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAED RID: 129773 RVA: 0x008BFA03 File Offset: 0x008BDC03
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_YangYangBirdsSpawnerComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangYangBirdsSpawnerComponent.BP_YangYangBirdsSpawnerComponent_C");
			}
			return BP_YangYangBirdsSpawnerComponent_C._ClassPtr;
		}

		// Token: 0x0601FAEE RID: 129774 RVA: 0x008BFA28 File Offset: 0x008BDC28
		public BP_YangYangBirdsSpawnerComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_YangYangBirdsSpawnerComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAEF RID: 129775 RVA: 0x008BFA50 File Offset: 0x008BDC50
		[NullableContext(1)]
		public BP_YangYangBirdsSpawnerComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_YangYangBirdsSpawnerComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x0601FAF0 RID: 129776 RVA: 0x008BFA83 File Offset: 0x008BDC83
		// (set) Token: 0x0601FAF1 RID: 129777 RVA: 0x008BFA97 File Offset: 0x008BDC97
		public unsafe BP_YangYangBirds_C BirdsActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_YangYangBirds_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x0601FAF2 RID: 129778 RVA: 0x008BFAAC File Offset: 0x008BDCAC
		// (set) Token: 0x0601FAF3 RID: 129779 RVA: 0x008BFAC0 File Offset: 0x008BDCC0
		public unsafe BP_YangyangBirdssss_Skill_C SkillBirdsActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_YangyangBirdssss_Skill_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x0601FAF4 RID: 129780 RVA: 0x008BFAD8 File Offset: 0x008BDCD8
		// (set) Token: 0x0601FAF5 RID: 129781 RVA: 0x008BFB11 File Offset: 0x008BDD11
		[Nullable(1)]
		public TArray<FVectorDouble> Points
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x0601FAF6 RID: 129782 RVA: 0x008BFB1F File Offset: 0x008BDD1F
		// (set) Token: 0x0601FAF7 RID: 129783 RVA: 0x008BFB2F File Offset: 0x008BDD2F
		public unsafe int LoopCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x0601FAF8 RID: 129784 RVA: 0x008BFB40 File Offset: 0x008BDD40
		// (set) Token: 0x0601FAF9 RID: 129785 RVA: 0x008BFB50 File Offset: 0x008BDD50
		public unsafe float StartCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x0601FAFA RID: 129786 RVA: 0x008BFB61 File Offset: 0x008BDD61
		// (set) Token: 0x0601FAFB RID: 129787 RVA: 0x008BFB75 File Offset: 0x008BDD75
		public unsafe FVectorDouble MovementBoundMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x0601FAFC RID: 129788 RVA: 0x008BFB8A File Offset: 0x008BDD8A
		// (set) Token: 0x0601FAFD RID: 129789 RVA: 0x008BFB9E File Offset: 0x008BDD9E
		public unsafe FVectorDouble MovementBoundMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x0601FAFE RID: 129790 RVA: 0x008BFBB3 File Offset: 0x008BDDB3
		// (set) Token: 0x0601FAFF RID: 129791 RVA: 0x008BFBC3 File Offset: 0x008BDDC3
		public unsafe bool BirdsPendingDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x0601FB00 RID: 129792 RVA: 0x008BFBD4 File Offset: 0x008BDDD4
		// (set) Token: 0x0601FB01 RID: 129793 RVA: 0x008BFBE4 File Offset: 0x008BDDE4
		public unsafe bool BirdsPendingSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x0601FB02 RID: 129794 RVA: 0x008BFBF5 File Offset: 0x008BDDF5
		// (set) Token: 0x0601FB03 RID: 129795 RVA: 0x008BFC05 File Offset: 0x008BDE05
		public unsafe float LastTimeDestroyBirds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x0601FB04 RID: 129796 RVA: 0x008BFC16 File Offset: 0x008BDE16
		// (set) Token: 0x0601FB05 RID: 129797 RVA: 0x008BFC26 File Offset: 0x008BDE26
		public unsafe float LastTimeSpawnBirds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x0601FB06 RID: 129798 RVA: 0x008BFC37 File Offset: 0x008BDE37
		// (set) Token: 0x0601FB07 RID: 129799 RVA: 0x008BFC47 File Offset: 0x008BDE47
		public unsafe float IntervalBetweenSpawns
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x0601FB08 RID: 129800 RVA: 0x008BFC58 File Offset: 0x008BDE58
		// (set) Token: 0x0601FB09 RID: 129801 RVA: 0x008BFC68 File Offset: 0x008BDE68
		public unsafe float MaxBirdsLiveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x0601FB0A RID: 129802 RVA: 0x008BFC79 File Offset: 0x008BDE79
		// (set) Token: 0x0601FB0B RID: 129803 RVA: 0x008BFC89 File Offset: 0x008BDE89
		public unsafe bool ForceSpawnBirds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x0601FB0C RID: 129804 RVA: 0x008BFC9A File Offset: 0x008BDE9A
		// (set) Token: 0x0601FB0D RID: 129805 RVA: 0x008BFCAA File Offset: 0x008BDEAA
		public unsafe bool IsPlayingSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirdsSpawnerComponent_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FB0E RID: 129806 RVA: 0x008BFCBC File Offset: 0x008BDEBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcShouldSpawnOrDestroyBirds(float DeltaTime)
		{
			BP_YangYangBirdsSpawnerComponent_C.__CalcShouldSpawnOrDestroyBirds_FunctionParams* ptr = stackalloc BP_YangYangBirdsSpawnerComponent_C.__CalcShouldSpawnOrDestroyBirds_FunctionParams[(UIntPtr)431] + 15L / (long)sizeof(BP_YangYangBirdsSpawnerComponent_C.__CalcShouldSpawnOrDestroyBirds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirdsSpawnerComponent_C.__CalcShouldSpawnOrDestroyBirds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__CalcShouldSpawnOrDestroyBirds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FB0F RID: 129807 RVA: 0x008BFD05 File Offset: 0x008BDF05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DestroyBirds()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__DestroyBirds_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB10 RID: 129808 RVA: 0x008BFD19 File Offset: 0x008BDF19
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SpawnBirds()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__SpawnBirds_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB11 RID: 129809 RVA: 0x008BFD2D File Offset: 0x008BDF2D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB12 RID: 129810 RVA: 0x008BFD41 File Offset: 0x008BDF41
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FB13 RID: 129811 RVA: 0x008BFD58 File Offset: 0x008BDF58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FB14 RID: 129812 RVA: 0x008BFDA0 File Offset: 0x008BDFA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FB15 RID: 129813 RVA: 0x008BFDE7 File Offset: 0x008BDFE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SpawnSkillBirds()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__SpawnSkillBirds_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB16 RID: 129814 RVA: 0x008BFDFB File Offset: 0x008BDFFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DestroySkillBirds()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__DestroySkillBirds_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB17 RID: 129815 RVA: 0x008BFE10 File Offset: 0x008BE010
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FB18 RID: 129816 RVA: 0x008BFE5C File Offset: 0x008BE05C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirdsSpawnerComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FB19 RID: 129817 RVA: 0x008BFEA8 File Offset: 0x008BE0A8
		protected BP_YangYangBirdsSpawnerComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F416 RID: 62486
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangYangBirdsSpawnerComponent.BP_YangYangBirdsSpawnerComponent_C";

		// Token: 0x0400F417 RID: 62487
		private static IntPtr _ClassPtr;

		// Token: 0x0400F418 RID: 62488
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F419 RID: 62489
		internal static int __PropertyOffset_1;

		// Token: 0x0400F41A RID: 62490
		internal static int __PropertyOffset_2;

		// Token: 0x0400F41B RID: 62491
		internal static int __PropertyOffset_3;

		// Token: 0x0400F41C RID: 62492
		private TArray<FVectorDouble> _Points;

		// Token: 0x0400F41D RID: 62493
		internal static int __PropertyOffset_4;

		// Token: 0x0400F41E RID: 62494
		internal static int __PropertyOffset_5;

		// Token: 0x0400F41F RID: 62495
		internal static int __PropertyOffset_6;

		// Token: 0x0400F420 RID: 62496
		internal static int __PropertyOffset_7;

		// Token: 0x0400F421 RID: 62497
		internal static int __PropertyOffset_8;

		// Token: 0x0400F422 RID: 62498
		internal static int __PropertyOffset_9;

		// Token: 0x0400F423 RID: 62499
		internal static int __PropertyOffset_10;

		// Token: 0x0400F424 RID: 62500
		internal static int __PropertyOffset_11;

		// Token: 0x0400F425 RID: 62501
		internal static int __PropertyOffset_12;

		// Token: 0x0400F426 RID: 62502
		internal static int __PropertyOffset_13;

		// Token: 0x0400F427 RID: 62503
		internal static int __PropertyOffset_14;

		// Token: 0x0400F428 RID: 62504
		internal static int __PropertyOffset_15;

		// Token: 0x0400F429 RID: 62505
		private static IntPtr __CalcShouldSpawnOrDestroyBirds_NativeFunctionPtr;

		// Token: 0x0400F42A RID: 62506
		private static IntPtr __DestroyBirds_NativeFunctionPtr;

		// Token: 0x0400F42B RID: 62507
		private static IntPtr __SpawnBirds_NativeFunctionPtr;

		// Token: 0x0400F42C RID: 62508
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F42D RID: 62509
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F42E RID: 62510
		private static IntPtr __SpawnSkillBirds_NativeFunctionPtr;

		// Token: 0x0400F42F RID: 62511
		private static IntPtr __DestroySkillBirds_NativeFunctionPtr;

		// Token: 0x0400F430 RID: 62512
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009B36 RID: 39734
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 416)]
		protected ref struct __CalcShouldSpawnOrDestroyBirds_FunctionParams
		{
			// Token: 0x04031149 RID: 201033
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02009B37 RID: 39735
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403114A RID: 201034
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B38 RID: 39736
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403114B RID: 201035
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
