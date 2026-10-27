using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseSeqCharacter;
using AkiClient.Game.Aki.Sequence.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP
{
	// Token: 0x02003A1E RID: 14878
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BP_SeqSkeletal.BP_SeqSkeletal_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class BP_SeqSkeletal_C : AActor, IUnrealUObject, IUnrealObject, ISeqAnimDataInterface, IUnrealNativeInterface, IUnrealInterface, IABPC_Seq_Interface_C, IUnrealBlueprintInterface, IBPI_SeqAudio_C, IBPI_SeqTalkActor_C
	{
		// Token: 0x0601F3CC RID: 127948 RVA: 0x008B1EE8 File Offset: 0x008B00E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqSkeletal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BP_SeqSkeletal.BP_SeqSkeletal_C");
			}
			return BP_SeqSkeletal_C._ClassPtr;
		}

		// Token: 0x0601F3CD RID: 127949 RVA: 0x008B1F0C File Offset: 0x008B010C
		int ISeqAnimDataInterface.InterfaceOffset()
		{
			return BP_SeqSkeletal_C.__InterfaceOffset_ISeqAnimDataInterface;
		}

		// Token: 0x0601F3CE RID: 127950 RVA: 0x008B1F14 File Offset: 0x008B0114
		public BP_SeqSkeletal_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqSkeletal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F3CF RID: 127951 RVA: 0x008B1F3C File Offset: 0x008B013C
		[NullableContext(1)]
		public BP_SeqSkeletal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqSkeletal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x0601F3D0 RID: 127952 RVA: 0x008B1F6F File Offset: 0x008B016F
		// (set) Token: 0x0601F3D1 RID: 127953 RVA: 0x008B1F83 File Offset: 0x008B0183
		public unsafe SeqAudio_Seq_V2_C SeqAudio_Seq_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<SeqAudio_Seq_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x0601F3D2 RID: 127954 RVA: 0x008B1F98 File Offset: 0x008B0198
		// (set) Token: 0x0601F3D3 RID: 127955 RVA: 0x008B1FAC File Offset: 0x008B01AC
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x0601F3D4 RID: 127956 RVA: 0x008B1FC1 File Offset: 0x008B01C1
		// (set) Token: 0x0601F3D5 RID: 127957 RVA: 0x008B1FD5 File Offset: 0x008B01D5
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x0601F3D6 RID: 127958 RVA: 0x008B1FEA File Offset: 0x008B01EA
		// (set) Token: 0x0601F3D7 RID: 127959 RVA: 0x008B1FFE File Offset: 0x008B01FE
		public unsafe ABPC_Seq_Body_V2_C ABPC_Body_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABPC_Seq_Body_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x0601F3D8 RID: 127960 RVA: 0x008B2013 File Offset: 0x008B0213
		// (set) Token: 0x0601F3D9 RID: 127961 RVA: 0x008B2027 File Offset: 0x008B0227
		public unsafe USkeletalMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0601F3DA RID: 127962 RVA: 0x008B203C File Offset: 0x008B023C
		// (set) Token: 0x0601F3DB RID: 127963 RVA: 0x008B204C File Offset: 0x008B024C
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0601F3DC RID: 127964 RVA: 0x008B205D File Offset: 0x008B025D
		// (set) Token: 0x0601F3DD RID: 127965 RVA: 0x008B206D File Offset: 0x008B026D
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x0601F3DE RID: 127966 RVA: 0x008B2080 File Offset: 0x008B0280
		// (set) Token: 0x0601F3DF RID: 127967 RVA: 0x008B20B9 File Offset: 0x008B02B9
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
					result = (this._BoneData = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoneData.CopyAssign(value);
			}
		}

		// Token: 0x0601F3E0 RID: 127968 RVA: 0x008B20C8 File Offset: 0x008B02C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqTalkId(ref int TalkID, ref int TalkID_SP)
		{
			BP_SeqSkeletal_C.__GetSeqTalkId_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetSeqTalkId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetSeqTalkId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TalkID = TalkID;
			ptr->TalkID_SP = TalkID_SP;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr);
			TalkID = ptr->TalkID;
			TalkID_SP = ptr->TalkID_SP;
		}

		// Token: 0x0601F3E1 RID: 127969 RVA: 0x008B2128 File Offset: 0x008B0328
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqMouthAnimInstance(ref UAnimInstance AnimInstance)
		{
			BP_SeqSkeletal_C.__GetSeqMouthAnimInstance_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetSeqMouthAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetSeqMouthAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqSkeletal_C.__GetSeqMouthAnimInstance_FunctionParams ptr2 = ref *ptr;
			UAnimInstance uanimInstance = AnimInstance;
			ptr2.AnimInstance = ((uanimInstance != null) ? uanimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr);
			AnimInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(ptr->AnimInstance);
		}

		// Token: 0x0601F3E2 RID: 127970 RVA: 0x008B218C File Offset: 0x008B038C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqAudio(ref SeqAudio_Seq_V2_C SeqAudio)
		{
			BP_SeqSkeletal_C.__GetSeqAudio_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetSeqAudio_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetSeqAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetSeqAudio_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqSkeletal_C.__GetSeqAudio_FunctionParams ptr2 = ref *ptr;
			SeqAudio_Seq_V2_C seqAudio_Seq_V2_C = SeqAudio;
			ptr2.SeqAudio = ((seqAudio_Seq_V2_C != null) ? seqAudio_Seq_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetSeqAudio_NativeFunctionPtr, (void*)ptr);
			SeqAudio = BuiltinUtils.GetOrCreateUObjectByNativePointer<SeqAudio_Seq_V2_C>(ptr->SeqAudio);
		}

		// Token: 0x0601F3E3 RID: 127971 RVA: 0x008B21F0 File Offset: 0x008B03F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetABPC_Body_V2(ref ABPC_Seq_Body_V2_C ABPC_Body_V2)
		{
			BP_SeqSkeletal_C.__GetABPC_Body_V2_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetABPC_Body_V2_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetABPC_Body_V2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqSkeletal_C.__GetABPC_Body_V2_FunctionParams ptr2 = ref *ptr;
			ABPC_Seq_Body_V2_C abpc_Seq_Body_V2_C = ABPC_Body_V2;
			ptr2.ABPC_Body_V2 = ((abpc_Seq_Body_V2_C != null) ? abpc_Seq_Body_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr);
			ABPC_Body_V2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ABPC_Seq_Body_V2_C>(ptr->ABPC_Body_V2);
		}

		// Token: 0x0601F3E4 RID: 127972 RVA: 0x008B2254 File Offset: 0x008B0454
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataTransform(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3E5 RID: 127973 RVA: 0x008B22D4 File Offset: 0x008B04D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3E6 RID: 127974 RVA: 0x008B2354 File Offset: 0x008B0554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F3E7 RID: 127975 RVA: 0x008B239C File Offset: 0x008B059C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F3E8 RID: 127976 RVA: 0x008B23E4 File Offset: 0x008B05E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataTransform(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3E9 RID: 127977 RVA: 0x008B2464 File Offset: 0x008B0664
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3EA RID: 127978 RVA: 0x008B24E4 File Offset: 0x008B06E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqSkeletal_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3EB RID: 127979 RVA: 0x008B2564 File Offset: 0x008B0764
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqSkeletal_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3EC RID: 127980 RVA: 0x008B25E4 File Offset: 0x008B07E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataVector(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3ED RID: 127981 RVA: 0x008B2664 File Offset: 0x008B0864
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3EE RID: 127982 RVA: 0x008B26E4 File Offset: 0x008B08E4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F3EF RID: 127983 RVA: 0x008B2744 File Offset: 0x008B0944
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F3F0 RID: 127984 RVA: 0x008B27A4 File Offset: 0x008B09A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqSkeletal_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqSkeletal_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3F1 RID: 127985 RVA: 0x008B2824 File Offset: 0x008B0A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_SeqSkeletal_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SeqSkeletal_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3F2 RID: 127986 RVA: 0x008B28A4 File Offset: 0x008B0AA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataVector(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3F3 RID: 127987 RVA: 0x008B2924 File Offset: 0x008B0B24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601F3F4 RID: 127988 RVA: 0x008B29A3 File Offset: 0x008B0BA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F3F5 RID: 127989 RVA: 0x008B29B7 File Offset: 0x008B0BB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F3F6 RID: 127990 RVA: 0x008B29CC File Offset: 0x008B0BCC
		protected BP_SeqSkeletal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EF9F RID: 61343
		internal static int __InterfaceOffset_ISeqAnimDataInterface;

		// Token: 0x0400EFA0 RID: 61344
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BP_SeqSkeletal.BP_SeqSkeletal_C";

		// Token: 0x0400EFA1 RID: 61345
		private static IntPtr _ClassPtr;

		// Token: 0x0400EFA2 RID: 61346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EFA3 RID: 61347
		internal static int __PropertyOffset_0;

		// Token: 0x0400EFA4 RID: 61348
		internal static int __PropertyOffset_1;

		// Token: 0x0400EFA5 RID: 61349
		internal static int __PropertyOffset_2;

		// Token: 0x0400EFA6 RID: 61350
		internal static int __PropertyOffset_3;

		// Token: 0x0400EFA7 RID: 61351
		internal static int __PropertyOffset_4;

		// Token: 0x0400EFA8 RID: 61352
		internal static int __PropertyOffset_5;

		// Token: 0x0400EFA9 RID: 61353
		internal static int __PropertyOffset_6;

		// Token: 0x0400EFAA RID: 61354
		internal static int __PropertyOffset_7;

		// Token: 0x0400EFAB RID: 61355
		private TMap<FName, FTransform> _BoneData;

		// Token: 0x0400EFAC RID: 61356
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0400EFAD RID: 61357
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0400EFAE RID: 61358
		private static IntPtr __GetSeqAudio_NativeFunctionPtr;

		// Token: 0x0400EFAF RID: 61359
		private static IntPtr __GetABPC_Body_V2_NativeFunctionPtr;

		// Token: 0x0400EFB0 RID: 61360
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400EFB1 RID: 61361
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x0400EFB2 RID: 61362
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400EFB3 RID: 61363
		private static IntPtr __GetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x0400EFB4 RID: 61364
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400EFB5 RID: 61365
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x0400EFB6 RID: 61366
		private static IntPtr __SetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x0400EFB7 RID: 61367
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400EFB8 RID: 61368
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02009A91 RID: 39569
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x04031005 RID: 200709
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x04031006 RID: 200710
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02009A92 RID: 39570
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x04031007 RID: 200711
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02009A93 RID: 39571
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqAudio_FunctionParams
		{
			// Token: 0x04031008 RID: 200712
			[FieldOffset(0)]
			public IntPtr SeqAudio;
		}

		// Token: 0x02009A94 RID: 39572
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetABPC_Body_V2_FunctionParams
		{
			// Token: 0x04031009 RID: 200713
			[FieldOffset(0)]
			public IntPtr ABPC_Body_V2;
		}

		// Token: 0x02009A95 RID: 39573
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x0403100A RID: 200714
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0403100B RID: 200715
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A96 RID: 39574
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x0403100C RID: 200716
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009A97 RID: 39575
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x0403100D RID: 200717
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0403100E RID: 200718
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A98 RID: 39576
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAnimDataFloat_FunctionParams
		{
			// Token: 0x0403100F RID: 200719
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04031010 RID: 200720
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009A99 RID: 39577
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x04031011 RID: 200721
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04031012 RID: 200722
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009A9A RID: 39578
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x04031013 RID: 200723
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02009A9B RID: 39579
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetAnimDataFloat_FunctionParams
		{
			// Token: 0x04031014 RID: 200724
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04031015 RID: 200725
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009A9C RID: 39580
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x04031016 RID: 200726
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04031017 RID: 200727
			[FieldOffset(80)]
			public bool __Result;
		}
	}
}
