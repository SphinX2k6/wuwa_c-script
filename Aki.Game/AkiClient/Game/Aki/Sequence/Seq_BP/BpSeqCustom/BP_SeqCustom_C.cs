using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Sequence.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP.BpSeqCustom
{
	// Token: 0x02003A22 RID: 14882
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BpSeqCustom/BP_SeqCustom.BP_SeqCustom_C")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1204)]
	public class BP_SeqCustom_C : AActor, IUnrealUObject, IUnrealObject, ISeqAnimDataInterface, IUnrealNativeInterface, IUnrealInterface, IBPI_SeqTalkActor_C, IUnrealBlueprintInterface
	{
		// Token: 0x0601F444 RID: 128068 RVA: 0x008B32FE File Offset: 0x008B14FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqCustom_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BpSeqCustom/BP_SeqCustom.BP_SeqCustom_C");
			}
			return BP_SeqCustom_C._ClassPtr;
		}

		// Token: 0x0601F445 RID: 128069 RVA: 0x008B3322 File Offset: 0x008B1522
		int ISeqAnimDataInterface.InterfaceOffset()
		{
			return BP_SeqCustom_C.__InterfaceOffset_ISeqAnimDataInterface;
		}

		// Token: 0x0601F446 RID: 128070 RVA: 0x008B332C File Offset: 0x008B152C
		public BP_SeqCustom_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqCustom_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F447 RID: 128071 RVA: 0x008B3354 File Offset: 0x008B1554
		[NullableContext(1)]
		public BP_SeqCustom_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqCustom_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x0601F448 RID: 128072 RVA: 0x008B3387 File Offset: 0x008B1587
		// (set) Token: 0x0601F449 RID: 128073 RVA: 0x008B339B File Offset: 0x008B159B
		public unsafe SeqCustomComp_C SeqCustomComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<SeqCustomComp_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x0601F44A RID: 128074 RVA: 0x008B33B0 File Offset: 0x008B15B0
		// (set) Token: 0x0601F44B RID: 128075 RVA: 0x008B33C4 File Offset: 0x008B15C4
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x0601F44C RID: 128076 RVA: 0x008B33D9 File Offset: 0x008B15D9
		// (set) Token: 0x0601F44D RID: 128077 RVA: 0x008B33ED File Offset: 0x008B15ED
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x0601F44E RID: 128078 RVA: 0x008B3402 File Offset: 0x008B1602
		// (set) Token: 0x0601F44F RID: 128079 RVA: 0x008B3416 File Offset: 0x008B1616
		public unsafe USkeletalMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x0601F450 RID: 128080 RVA: 0x008B342C File Offset: 0x008B162C
		// (set) Token: 0x0601F451 RID: 128081 RVA: 0x008B3465 File Offset: 0x008B1665
		[Nullable(1)]
		public TMap<FName, FTransform> BoneData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FTransform> result;
				if ((result = this._BoneData) == null)
				{
					result = (this._BoneData = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoneData.CopyAssign(value);
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x0601F452 RID: 128082 RVA: 0x008B3474 File Offset: 0x008B1674
		// (set) Token: 0x0601F453 RID: 128083 RVA: 0x008B34AD File Offset: 0x008B16AD
		[Nullable(1)]
		public TArray<FName> SupportNames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SupportNames) == null)
				{
					result = (this._SupportNames = new TArray<FName>(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SupportNames.CopyAssign(value);
			}
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x0601F454 RID: 128084 RVA: 0x008B34BB File Offset: 0x008B16BB
		// (set) Token: 0x0601F455 RID: 128085 RVA: 0x008B34CB File Offset: 0x008B16CB
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x0601F456 RID: 128086 RVA: 0x008B34DC File Offset: 0x008B16DC
		// (set) Token: 0x0601F457 RID: 128087 RVA: 0x008B34EC File Offset: 0x008B16EC
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x0601F458 RID: 128088 RVA: 0x008B34FD File Offset: 0x008B16FD
		// (set) Token: 0x0601F459 RID: 128089 RVA: 0x008B350D File Offset: 0x008B170D
		public unsafe bool SetNewBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x0601F45A RID: 128090 RVA: 0x008B351E File Offset: 0x008B171E
		// (set) Token: 0x0601F45B RID: 128091 RVA: 0x008B352E File Offset: 0x008B172E
		public unsafe float NewBoundScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x0601F45C RID: 128092 RVA: 0x008B353F File Offset: 0x008B173F
		// (set) Token: 0x0601F45D RID: 128093 RVA: 0x008B354F File Offset: 0x008B174F
		public unsafe float OriginBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x0601F45E RID: 128094 RVA: 0x008B3560 File Offset: 0x008B1760
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqTalkId(ref int TalkID, ref int TalkID_SP)
		{
			BP_SeqCustom_C.__GetSeqTalkId_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetSeqTalkId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqCustom_C.__GetSeqTalkId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TalkID = TalkID;
			ptr->TalkID_SP = TalkID_SP;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr);
			TalkID = ptr->TalkID;
			TalkID_SP = ptr->TalkID_SP;
		}

		// Token: 0x0601F45F RID: 128095 RVA: 0x008B35C0 File Offset: 0x008B17C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqMouthAnimInstance(ref UAnimInstance AnimInstance)
		{
			BP_SeqCustom_C.__GetSeqMouthAnimInstance_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetSeqMouthAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SeqCustom_C.__GetSeqMouthAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqCustom_C.__GetSeqMouthAnimInstance_FunctionParams ptr2 = ref *ptr;
			UAnimInstance uanimInstance = AnimInstance;
			ptr2.AnimInstance = ((uanimInstance != null) ? uanimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr);
			AnimInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(ptr->AnimInstance);
		}

		// Token: 0x0601F460 RID: 128096 RVA: 0x008B3624 File Offset: 0x008B1824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_SeqCustom_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqCustom_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F461 RID: 128097 RVA: 0x008B366C File Offset: 0x008B186C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_SeqCustom_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqCustom_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F462 RID: 128098 RVA: 0x008B36B4 File Offset: 0x008B18B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataTransform(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F463 RID: 128099 RVA: 0x008B3734 File Offset: 0x008B1934
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F464 RID: 128100 RVA: 0x008B37B4 File Offset: 0x008B19B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataTransform(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F465 RID: 128101 RVA: 0x008B3834 File Offset: 0x008B1A34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F466 RID: 128102 RVA: 0x008B38B4 File Offset: 0x008B1AB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqCustom_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqCustom_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F467 RID: 128103 RVA: 0x008B3934 File Offset: 0x008B1B34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqCustom_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqCustom_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F468 RID: 128104 RVA: 0x008B39B4 File Offset: 0x008B1BB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataVector(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqCustom_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F469 RID: 128105 RVA: 0x008B3A34 File Offset: 0x008B1C34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqCustom_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F46A RID: 128106 RVA: 0x008B3AB4 File Offset: 0x008B1CB4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F46B RID: 128107 RVA: 0x008B3B14 File Offset: 0x008B1D14
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F46C RID: 128108 RVA: 0x008B3B74 File Offset: 0x008B1D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqCustom_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqCustom_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F46D RID: 128109 RVA: 0x008B3BF4 File Offset: 0x008B1DF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqCustom_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqCustom_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F46E RID: 128110 RVA: 0x008B3C74 File Offset: 0x008B1E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataVector(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqCustom_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F46F RID: 128111 RVA: 0x008B3CF4 File Offset: 0x008B1EF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqCustom_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F470 RID: 128112 RVA: 0x008B3D73 File Offset: 0x008B1F73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F471 RID: 128113 RVA: 0x008B3D87 File Offset: 0x008B1F87
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F472 RID: 128114 RVA: 0x008B3D9C File Offset: 0x008B1F9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F473 RID: 128115 RVA: 0x008B3DB0 File Offset: 0x008B1FB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F474 RID: 128116 RVA: 0x008B3DC8 File Offset: 0x008B1FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SeqCustom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqCustom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F475 RID: 128117 RVA: 0x008B3E10 File Offset: 0x008B2010
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SeqCustom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqCustom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F476 RID: 128118 RVA: 0x008B3E58 File Offset: 0x008B2058
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F477 RID: 128119 RVA: 0x008B3EA4 File Offset: 0x008B20A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F478 RID: 128120 RVA: 0x008B3EF0 File Offset: 0x008B20F0
		protected BP_SeqCustom_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EFEB RID: 61419
		internal static int __InterfaceOffset_ISeqAnimDataInterface;

		// Token: 0x0400EFEC RID: 61420
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BpSeqCustom/BP_SeqCustom.BP_SeqCustom_C";

		// Token: 0x0400EFED RID: 61421
		private static IntPtr _ClassPtr;

		// Token: 0x0400EFEE RID: 61422
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EFEF RID: 61423
		internal static int __PropertyOffset_1;

		// Token: 0x0400EFF0 RID: 61424
		internal static int __PropertyOffset_2;

		// Token: 0x0400EFF1 RID: 61425
		internal static int __PropertyOffset_3;

		// Token: 0x0400EFF2 RID: 61426
		internal static int __PropertyOffset_4;

		// Token: 0x0400EFF3 RID: 61427
		internal static int __PropertyOffset_5;

		// Token: 0x0400EFF4 RID: 61428
		private TMap<FName, FTransform> _BoneData;

		// Token: 0x0400EFF5 RID: 61429
		internal static int __PropertyOffset_6;

		// Token: 0x0400EFF6 RID: 61430
		private TArray<FName> _SupportNames;

		// Token: 0x0400EFF7 RID: 61431
		internal static int __PropertyOffset_7;

		// Token: 0x0400EFF8 RID: 61432
		internal static int __PropertyOffset_8;

		// Token: 0x0400EFF9 RID: 61433
		internal static int __PropertyOffset_9;

		// Token: 0x0400EFFA RID: 61434
		internal static int __PropertyOffset_10;

		// Token: 0x0400EFFB RID: 61435
		internal static int __PropertyOffset_11;

		// Token: 0x0400EFFC RID: 61436
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0400EFFD RID: 61437
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0400EFFE RID: 61438
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x0400EFFF RID: 61439
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F000 RID: 61440
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F001 RID: 61441
		private static IntPtr __GetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x0400F002 RID: 61442
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F003 RID: 61443
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x0400F004 RID: 61444
		private static IntPtr __SetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x0400F005 RID: 61445
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F006 RID: 61446
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F007 RID: 61447
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F008 RID: 61448
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F009 RID: 61449
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009AA5 RID: 39589
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x04031028 RID: 200744
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x04031029 RID: 200745
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02009AA6 RID: 39590
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0403102A RID: 200746
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02009AA7 RID: 39591
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x0403102B RID: 200747
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009AA8 RID: 39592
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x0403102C RID: 200748
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0403102D RID: 200749
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009AA9 RID: 39593
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x0403102E RID: 200750
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0403102F RID: 200751
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009AAA RID: 39594
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAnimDataFloat_FunctionParams
		{
			// Token: 0x04031030 RID: 200752
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04031031 RID: 200753
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009AAB RID: 39595
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x04031032 RID: 200754
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04031033 RID: 200755
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009AAC RID: 39596
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x04031034 RID: 200756
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02009AAD RID: 39597
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetAnimDataFloat_FunctionParams
		{
			// Token: 0x04031035 RID: 200757
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04031036 RID: 200758
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009AAE RID: 39598
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x04031037 RID: 200759
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04031038 RID: 200760
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009AAF RID: 39599
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031039 RID: 200761
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009AB0 RID: 39600
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403103A RID: 200762
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
