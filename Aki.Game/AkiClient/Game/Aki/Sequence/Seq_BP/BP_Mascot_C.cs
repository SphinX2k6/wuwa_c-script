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
	// Token: 0x0200306A RID: 12394
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BP_Mascot.BP_Mascot_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_Mascot_C : AActor, IUnrealUObject, IUnrealObject, IBPI_SeqTalkActor_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601D721 RID: 120609 RVA: 0x008F6BF5 File Offset: 0x008F4DF5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Mascot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BP_Mascot.BP_Mascot_C");
			}
			return BP_Mascot_C._ClassPtr;
		}

		// Token: 0x0601D722 RID: 120610 RVA: 0x008F6C1C File Offset: 0x008F4E1C
		public BP_Mascot_C() : this(BuiltinUtils.AllocNativeUObject(BP_Mascot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D723 RID: 120611 RVA: 0x008F6C44 File Offset: 0x008F4E44
		[NullableContext(1)]
		public BP_Mascot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Mascot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0601D724 RID: 120612 RVA: 0x008F6C77 File Offset: 0x008F4E77
		// (set) Token: 0x0601D725 RID: 120613 RVA: 0x008F6C8B File Offset: 0x008F4E8B
		public unsafe ABPC_Seq_Body_V2_C ABPC_Body_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABPC_Seq_Body_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_ABPC_Body_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_ABPC_Body_V2, value);
			}
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x0601D726 RID: 120614 RVA: 0x008F6CA0 File Offset: 0x008F4EA0
		// (set) Token: 0x0601D727 RID: 120615 RVA: 0x008F6CB4 File Offset: 0x008F4EB4
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_SkeletalMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x0601D728 RID: 120616 RVA: 0x008F6CC9 File Offset: 0x008F4EC9
		// (set) Token: 0x0601D729 RID: 120617 RVA: 0x008F6CDD File Offset: 0x008F4EDD
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0601D72A RID: 120618 RVA: 0x008F6CF2 File Offset: 0x008F4EF2
		// (set) Token: 0x0601D72B RID: 120619 RVA: 0x008F6D06 File Offset: 0x008F4F06
		public unsafe FRotator Add_Spine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_Add_Spine);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_Add_Spine) = value;
			}
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0601D72C RID: 120620 RVA: 0x008F6D1B File Offset: 0x008F4F1B
		// (set) Token: 0x0601D72D RID: 120621 RVA: 0x008F6D2F File Offset: 0x008F4F2F
		public unsafe FRotator Add_Spine_Head
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_Add_Spine_Head);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_Add_Spine_Head) = value;
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0601D72E RID: 120622 RVA: 0x008F6D44 File Offset: 0x008F4F44
		// (set) Token: 0x0601D72F RID: 120623 RVA: 0x008F6D58 File Offset: 0x008F4F58
		public unsafe USkeletalMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Mascot_C.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0601D730 RID: 120624 RVA: 0x008F6D70 File Offset: 0x008F4F70
		// (set) Token: 0x0601D731 RID: 120625 RVA: 0x008F6DA9 File Offset: 0x008F4FA9
		[Nullable(1)]
		public FKuroCurveFloat KuroFixCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._KuroFixCurve) == null)
				{
					result = (this._KuroFixCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_KuroFixCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_KuroFixCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0601D732 RID: 120626 RVA: 0x008F6DCA File Offset: 0x008F4FCA
		// (set) Token: 0x0601D733 RID: 120627 RVA: 0x008F6DDA File Offset: 0x008F4FDA
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_TalkID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_TalkID) = value;
			}
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0601D734 RID: 120628 RVA: 0x008F6DEB File Offset: 0x008F4FEB
		// (set) Token: 0x0601D735 RID: 120629 RVA: 0x008F6DFB File Offset: 0x008F4FFB
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_TalkID_SP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_TalkID_SP) = value;
			}
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x0601D736 RID: 120630 RVA: 0x008F6E0C File Offset: 0x008F500C
		// (set) Token: 0x0601D737 RID: 120631 RVA: 0x008F6E45 File Offset: 0x008F5045
		[Nullable(1)]
		public TMap<FName, FTransform> Float_Curve_Data
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FTransform> result;
				if ((result = this._Float_Curve_Data) == null)
				{
					result = (this._Float_Curve_Data = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_Mascot_C.__PropertyOffset_Float_Curve_Data, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Float_Curve_Data.CopyAssign(value);
			}
		}

		// Token: 0x0601D738 RID: 120632 RVA: 0x008F6E54 File Offset: 0x008F5054
		[SkipLocalsInit]
		public unsafe virtual void GetSeqTalkId(ref int TalkID, ref int TalkID_SP)
		{
			BP_Mascot_C.__GetSeqTalkId_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetSeqTalkId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Mascot_C.__GetSeqTalkId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TalkID = TalkID;
			ptr->TalkID_SP = TalkID_SP;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr);
			TalkID = ptr->TalkID;
			TalkID_SP = ptr->TalkID_SP;
		}

		// Token: 0x0601D739 RID: 120633 RVA: 0x008F6EB4 File Offset: 0x008F50B4
		[SkipLocalsInit]
		public unsafe virtual void GetSeqMouthAnimInstance(ref UAnimInstance AnimInstance)
		{
			BP_Mascot_C.__GetSeqMouthAnimInstance_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetSeqMouthAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Mascot_C.__GetSeqMouthAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_Mascot_C.__GetSeqMouthAnimInstance_FunctionParams ptr2 = ref *ptr;
			UAnimInstance uanimInstance = AnimInstance;
			ptr2.AnimInstance = ((uanimInstance != null) ? uanimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr);
			AnimInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(ptr->AnimInstance);
		}

		// Token: 0x0601D73A RID: 120634 RVA: 0x008F6F18 File Offset: 0x008F5118
		[SkipLocalsInit]
		public unsafe virtual void GetAddSpineHeadValue(ref FRotator AddSpineHead)
		{
			BP_Mascot_C.__GetAddSpineHeadValue_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAddSpineHeadValue_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Mascot_C.__GetAddSpineHeadValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAddSpineHeadValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AddSpineHead = AddSpineHead;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAddSpineHeadValue_NativeFunctionPtr, (void*)ptr);
			AddSpineHead = ptr->AddSpineHead;
		}

		// Token: 0x0601D73B RID: 120635 RVA: 0x008F6F70 File Offset: 0x008F5170
		[SkipLocalsInit]
		public unsafe virtual void GetAddSpineValue(ref FRotator AddSpine)
		{
			BP_Mascot_C.__GetAddSpineValue_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAddSpineValue_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_Mascot_C.__GetAddSpineValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAddSpineValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AddSpine = AddSpine;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAddSpineValue_NativeFunctionPtr, (void*)ptr);
			AddSpine = ptr->AddSpine;
		}

		// Token: 0x0601D73C RID: 120636 RVA: 0x008F6FC8 File Offset: 0x008F51C8
		[SkipLocalsInit]
		public unsafe virtual bool GetAnimDataTransform(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_Mascot_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D73D RID: 120637 RVA: 0x008F7048 File Offset: 0x008F5248
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_Mascot_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D73E RID: 120638 RVA: 0x008F70C8 File Offset: 0x008F52C8
		[SkipLocalsInit]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_Mascot_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_Mascot_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Mascot_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D73F RID: 120639 RVA: 0x008F7110 File Offset: 0x008F5310
		[SkipLocalsInit]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_Mascot_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_Mascot_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Mascot_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D740 RID: 120640 RVA: 0x008F7158 File Offset: 0x008F5358
		[SkipLocalsInit]
		public unsafe virtual bool SetAnimDataTransform(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_Mascot_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D741 RID: 120641 RVA: 0x008F71D8 File Offset: 0x008F53D8
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_Mascot_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D742 RID: 120642 RVA: 0x008F7258 File Offset: 0x008F5458
		[SkipLocalsInit]
		public unsafe virtual bool GetAnimDataVector(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_Mascot_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D743 RID: 120643 RVA: 0x008F72D8 File Offset: 0x008F54D8
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_Mascot_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_Mascot_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D744 RID: 120644 RVA: 0x008F7358 File Offset: 0x008F5558
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_Mascot_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Mascot_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601D745 RID: 120645 RVA: 0x008F73B8 File Offset: 0x008F55B8
		[NullableContext(1)]
		[SkipLocalsInit]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_Mascot_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Mascot_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601D746 RID: 120646 RVA: 0x008F7418 File Offset: 0x008F5618
		[SkipLocalsInit]
		public unsafe virtual bool SetAnimDataVector(in TMap<FName, FVector> VectorCurveData)
		{
			BP_Mascot_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataVector_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D747 RID: 120647 RVA: 0x008F749C File Offset: 0x008F569C
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_Mascot_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_Mascot_C.__SetAnimDataVector_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_Mascot_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_Mascot_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D748 RID: 120648 RVA: 0x008F7520 File Offset: 0x008F5720
		[SkipLocalsInit]
		public unsafe virtual void HasFixCurve(FName CheckName, ref bool Ret, ref FName FixName)
		{
			BP_Mascot_C.__HasFixCurve_FunctionParams* ptr = stackalloc BP_Mascot_C.__HasFixCurve_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Mascot_C.__HasFixCurve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__HasFixCurve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CheckName = CheckName;
			ptr->Ret = Ret;
			ptr->FixName = FixName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__HasFixCurve_NativeFunctionPtr, (void*)ptr);
			Ret = ptr->Ret;
			FixName = ptr->FixName;
		}

		// Token: 0x0601D749 RID: 120649 RVA: 0x008F7590 File Offset: 0x008F5790
		[SkipLocalsInit]
		public unsafe virtual void GetFixValue(float inValue, ref float FixValue)
		{
			BP_Mascot_C.__GetFixValue_FunctionParams* ptr = stackalloc BP_Mascot_C.__GetFixValue_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Mascot_C.__GetFixValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Mascot_C.__GetFixValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inValue = inValue;
			ptr->FixValue = FixValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__GetFixValue_NativeFunctionPtr, (void*)ptr);
			FixValue = ptr->FixValue;
		}

		// Token: 0x0601D74A RID: 120650 RVA: 0x008F75E6 File Offset: 0x008F57E6
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Mascot_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D74B RID: 120651 RVA: 0x008F75FA File Offset: 0x008F57FA
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Mascot_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D74C RID: 120652 RVA: 0x008F760E File Offset: 0x008F580E
		protected BP_Mascot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F80B RID: 63499
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BP_Mascot.BP_Mascot_C";

		// Token: 0x0400F80C RID: 63500
		private static IntPtr _ClassPtr;

		// Token: 0x0400F80D RID: 63501
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F80E RID: 63502
		internal static int __PropertyOffset_ABPC_Body_V2;

		// Token: 0x0400F80F RID: 63503
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x0400F810 RID: 63504
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F811 RID: 63505
		internal static int __PropertyOffset_Add_Spine;

		// Token: 0x0400F812 RID: 63506
		internal static int __PropertyOffset_Add_Spine_Head;

		// Token: 0x0400F813 RID: 63507
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400F814 RID: 63508
		internal static int __PropertyOffset_KuroFixCurve;

		// Token: 0x0400F815 RID: 63509
		private FKuroCurveFloat _KuroFixCurve;

		// Token: 0x0400F816 RID: 63510
		internal static int __PropertyOffset_TalkID;

		// Token: 0x0400F817 RID: 63511
		internal static int __PropertyOffset_TalkID_SP;

		// Token: 0x0400F818 RID: 63512
		internal static int __PropertyOffset_Float_Curve_Data;

		// Token: 0x0400F819 RID: 63513
		private TMap<FName, FTransform> _Float_Curve_Data;

		// Token: 0x0400F81A RID: 63514
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0400F81B RID: 63515
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0400F81C RID: 63516
		private static IntPtr __GetAddSpineHeadValue_NativeFunctionPtr;

		// Token: 0x0400F81D RID: 63517
		private static IntPtr __GetAddSpineValue_NativeFunctionPtr;

		// Token: 0x0400F81E RID: 63518
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F81F RID: 63519
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x0400F820 RID: 63520
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F821 RID: 63521
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F822 RID: 63522
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x0400F823 RID: 63523
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F824 RID: 63524
		private static IntPtr __HasFixCurve_NativeFunctionPtr;

		// Token: 0x0400F825 RID: 63525
		private static IntPtr __GetFixValue_NativeFunctionPtr;

		// Token: 0x0400F826 RID: 63526
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02008D11 RID: 36113
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x0402C862 RID: 182370
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x0402C863 RID: 182371
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02008D12 RID: 36114
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0402C864 RID: 182372
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02008D13 RID: 36115
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAddSpineHeadValue_FunctionParams
		{
			// Token: 0x0402C865 RID: 182373
			[FieldOffset(0)]
			public FRotator AddSpineHead;
		}

		// Token: 0x02008D14 RID: 36116
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetAddSpineValue_FunctionParams
		{
			// Token: 0x0402C866 RID: 182374
			[FieldOffset(0)]
			public FRotator AddSpine;
		}

		// Token: 0x02008D15 RID: 36117
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402C867 RID: 182375
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402C868 RID: 182376
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D16 RID: 36118
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x0402C869 RID: 182377
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02008D17 RID: 36119
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402C86A RID: 182378
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402C86B RID: 182379
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D18 RID: 36120
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x0402C86C RID: 182380
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402C86D RID: 182381
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D19 RID: 36121
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x0402C86E RID: 182382
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02008D1A RID: 36122
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x0402C86F RID: 182383
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402C870 RID: 182384
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D1B RID: 36123
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __HasFixCurve_FunctionParams
		{
			// Token: 0x0402C871 RID: 182385
			[FieldOffset(0)]
			public FName CheckName;

			// Token: 0x0402C872 RID: 182386
			[FieldOffset(12)]
			public bool Ret;

			// Token: 0x0402C873 RID: 182387
			[FieldOffset(16)]
			public FName FixName;
		}

		// Token: 0x02008D1C RID: 36124
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetFixValue_FunctionParams
		{
			// Token: 0x0402C874 RID: 182388
			[FieldOffset(0)]
			public float inValue;

			// Token: 0x0402C875 RID: 182389
			[FieldOffset(4)]
			public float FixValue;
		}
	}
}
