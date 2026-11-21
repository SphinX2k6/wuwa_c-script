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
	// Token: 0x0200306C RID: 12396
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BP_SeqSkeletal.BP_SeqSkeletal_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class BP_SeqSkeletal_C : AActor, IUnrealUObject, IUnrealObject, IBPI_SeqAudio_C, IUnrealBlueprintInterface, IUnrealInterface, IBPI_SeqTalkActor_C
	{
		// Token: 0x0601D782 RID: 120706 RVA: 0x008F80C3 File Offset: 0x008F62C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqSkeletal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BP_SeqSkeletal.BP_SeqSkeletal_C");
			}
			return BP_SeqSkeletal_C._ClassPtr;
		}

		// Token: 0x0601D783 RID: 120707 RVA: 0x008F80E8 File Offset: 0x008F62E8
		public BP_SeqSkeletal_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqSkeletal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D784 RID: 120708 RVA: 0x008F8110 File Offset: 0x008F6310
		[NullableContext(1)]
		public BP_SeqSkeletal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqSkeletal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0601D785 RID: 120709 RVA: 0x008F8143 File Offset: 0x008F6343
		// (set) Token: 0x0601D786 RID: 120710 RVA: 0x008F8157 File Offset: 0x008F6357
		public unsafe SeqAudio_Seq_V2_C SeqAudio_Seq_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<SeqAudio_Seq_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_SeqAudio_Seq_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_SeqAudio_Seq_V2, value);
			}
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0601D787 RID: 120711 RVA: 0x008F816C File Offset: 0x008F636C
		// (set) Token: 0x0601D788 RID: 120712 RVA: 0x008F8180 File Offset: 0x008F6380
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_SkeletalMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x0601D789 RID: 120713 RVA: 0x008F8195 File Offset: 0x008F6395
		// (set) Token: 0x0601D78A RID: 120714 RVA: 0x008F81A9 File Offset: 0x008F63A9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x0601D78B RID: 120715 RVA: 0x008F81BE File Offset: 0x008F63BE
		// (set) Token: 0x0601D78C RID: 120716 RVA: 0x008F81D2 File Offset: 0x008F63D2
		public unsafe ABPC_Seq_Body_V2_C ABPC_Body_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABPC_Seq_Body_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_ABPC_Body_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_ABPC_Body_V2, value);
			}
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x0601D78D RID: 120717 RVA: 0x008F81E7 File Offset: 0x008F63E7
		// (set) Token: 0x0601D78E RID: 120718 RVA: 0x008F81FB File Offset: 0x008F63FB
		public unsafe USkeletalMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqSkeletal_C.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x0601D78F RID: 120719 RVA: 0x008F8210 File Offset: 0x008F6410
		// (set) Token: 0x0601D790 RID: 120720 RVA: 0x008F8220 File Offset: 0x008F6420
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_TalkID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_TalkID) = value;
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x0601D791 RID: 120721 RVA: 0x008F8231 File Offset: 0x008F6431
		// (set) Token: 0x0601D792 RID: 120722 RVA: 0x008F8241 File Offset: 0x008F6441
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_TalkID_SP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_TalkID_SP) = value;
			}
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x0601D793 RID: 120723 RVA: 0x008F8254 File Offset: 0x008F6454
		// (set) Token: 0x0601D794 RID: 120724 RVA: 0x008F828D File Offset: 0x008F648D
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
					result = (this._BoneData = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_SeqSkeletal_C.__PropertyOffset_BoneData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoneData.CopyAssign(value);
			}
		}

		// Token: 0x0601D795 RID: 120725 RVA: 0x008F829C File Offset: 0x008F649C
		[SkipLocalsInit]
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

		// Token: 0x0601D796 RID: 120726 RVA: 0x008F82FC File Offset: 0x008F64FC
		[SkipLocalsInit]
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

		// Token: 0x0601D797 RID: 120727 RVA: 0x008F8360 File Offset: 0x008F6560
		[SkipLocalsInit]
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

		// Token: 0x0601D798 RID: 120728 RVA: 0x008F83C4 File Offset: 0x008F65C4
		[SkipLocalsInit]
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

		// Token: 0x0601D799 RID: 120729 RVA: 0x008F8428 File Offset: 0x008F6628
		[SkipLocalsInit]
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

		// Token: 0x0601D79A RID: 120730 RVA: 0x008F84A8 File Offset: 0x008F66A8
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D79B RID: 120731 RVA: 0x008F8528 File Offset: 0x008F6728
		[SkipLocalsInit]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D79C RID: 120732 RVA: 0x008F8570 File Offset: 0x008F6770
		[SkipLocalsInit]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqSkeletal_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D79D RID: 120733 RVA: 0x008F85B8 File Offset: 0x008F67B8
		[SkipLocalsInit]
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

		// Token: 0x0601D79E RID: 120734 RVA: 0x008F8638 File Offset: 0x008F6838
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D79F RID: 120735 RVA: 0x008F86B8 File Offset: 0x008F68B8
		[SkipLocalsInit]
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

		// Token: 0x0601D7A0 RID: 120736 RVA: 0x008F8738 File Offset: 0x008F6938
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D7A1 RID: 120737 RVA: 0x008F87B8 File Offset: 0x008F69B8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601D7A2 RID: 120738 RVA: 0x008F8818 File Offset: 0x008F6A18
		[NullableContext(1)]
		[SkipLocalsInit]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeqSkeletal_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601D7A3 RID: 120739 RVA: 0x008F8878 File Offset: 0x008F6A78
		[SkipLocalsInit]
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

		// Token: 0x0601D7A4 RID: 120740 RVA: 0x008F88F8 File Offset: 0x008F6AF8
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqSkeletal_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqSkeletal_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D7A5 RID: 120741 RVA: 0x008F8976 File Offset: 0x008F6B76
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqSkeletal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7A6 RID: 120742 RVA: 0x008F898A File Offset: 0x008F6B8A
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqSkeletal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D7A7 RID: 120743 RVA: 0x008F899E File Offset: 0x008F6B9E
		protected BP_SeqSkeletal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F846 RID: 63558
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BP_SeqSkeletal.BP_SeqSkeletal_C";

		// Token: 0x0400F847 RID: 63559
		private static IntPtr _ClassPtr;

		// Token: 0x0400F848 RID: 63560
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F849 RID: 63561
		internal static int __PropertyOffset_SeqAudio_Seq_V2;

		// Token: 0x0400F84A RID: 63562
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x0400F84B RID: 63563
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F84C RID: 63564
		internal static int __PropertyOffset_ABPC_Body_V2;

		// Token: 0x0400F84D RID: 63565
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400F84E RID: 63566
		internal static int __PropertyOffset_TalkID;

		// Token: 0x0400F84F RID: 63567
		internal static int __PropertyOffset_TalkID_SP;

		// Token: 0x0400F850 RID: 63568
		internal static int __PropertyOffset_BoneData;

		// Token: 0x0400F851 RID: 63569
		private TMap<FName, FTransform> _BoneData;

		// Token: 0x0400F852 RID: 63570
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0400F853 RID: 63571
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0400F854 RID: 63572
		private static IntPtr __GetSeqAudio_NativeFunctionPtr;

		// Token: 0x0400F855 RID: 63573
		private static IntPtr __GetABPC_Body_V2_NativeFunctionPtr;

		// Token: 0x0400F856 RID: 63574
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F857 RID: 63575
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x0400F858 RID: 63576
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F859 RID: 63577
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F85A RID: 63578
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x0400F85B RID: 63579
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F85C RID: 63580
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02008D29 RID: 36137
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x0402C887 RID: 182407
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x0402C888 RID: 182408
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02008D2A RID: 36138
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0402C889 RID: 182409
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02008D2B RID: 36139
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqAudio_FunctionParams
		{
			// Token: 0x0402C88A RID: 182410
			[FieldOffset(0)]
			public IntPtr SeqAudio;
		}

		// Token: 0x02008D2C RID: 36140
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetABPC_Body_V2_FunctionParams
		{
			// Token: 0x0402C88B RID: 182411
			[FieldOffset(0)]
			public IntPtr ABPC_Body_V2;
		}

		// Token: 0x02008D2D RID: 36141
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402C88C RID: 182412
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402C88D RID: 182413
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D2E RID: 36142
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x0402C88E RID: 182414
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02008D2F RID: 36143
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402C88F RID: 182415
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402C890 RID: 182416
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D30 RID: 36144
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x0402C891 RID: 182417
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402C892 RID: 182418
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D31 RID: 36145
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x0402C893 RID: 182419
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02008D32 RID: 36146
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x0402C894 RID: 182420
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402C895 RID: 182421
			[FieldOffset(80)]
			public bool __Result;
		}
	}
}
