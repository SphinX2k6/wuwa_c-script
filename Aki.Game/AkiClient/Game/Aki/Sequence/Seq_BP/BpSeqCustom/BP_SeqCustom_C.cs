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
	// Token: 0x0200306F RID: 12399
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BpSeqCustom/BP_SeqCustom.BP_SeqCustom_C")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1204)]
	public class BP_SeqCustom_C : AActor, IUnrealUObject, IUnrealObject, IBPI_SeqTalkActor_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601D7F5 RID: 120821 RVA: 0x008F92CE File Offset: 0x008F74CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqCustom_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BpSeqCustom/BP_SeqCustom.BP_SeqCustom_C");
			}
			return BP_SeqCustom_C._ClassPtr;
		}

		// Token: 0x0601D7F6 RID: 120822 RVA: 0x008F92F4 File Offset: 0x008F74F4
		public BP_SeqCustom_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqCustom_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D7F7 RID: 120823 RVA: 0x008F931C File Offset: 0x008F751C
		[NullableContext(1)]
		public BP_SeqCustom_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqCustom_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x0601D7F8 RID: 120824 RVA: 0x008F934F File Offset: 0x008F754F
		// (set) Token: 0x0601D7F9 RID: 120825 RVA: 0x008F9363 File Offset: 0x008F7563
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_SkeletalMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x0601D7FA RID: 120826 RVA: 0x008F9378 File Offset: 0x008F7578
		// (set) Token: 0x0601D7FB RID: 120827 RVA: 0x008F938C File Offset: 0x008F758C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x0601D7FC RID: 120828 RVA: 0x008F93A1 File Offset: 0x008F75A1
		// (set) Token: 0x0601D7FD RID: 120829 RVA: 0x008F93B5 File Offset: 0x008F75B5
		public unsafe USkeletalMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqCustom_C.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x0601D7FE RID: 120830 RVA: 0x008F93CC File Offset: 0x008F75CC
		// (set) Token: 0x0601D7FF RID: 120831 RVA: 0x008F9405 File Offset: 0x008F7605
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
					result = (this._BoneData = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_BoneData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoneData.CopyAssign(value);
			}
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x0601D800 RID: 120832 RVA: 0x008F9414 File Offset: 0x008F7614
		// (set) Token: 0x0601D801 RID: 120833 RVA: 0x008F944D File Offset: 0x008F764D
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
					result = (this._SupportNames = new TArray<FName>(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_SupportNames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SupportNames.CopyAssign(value);
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x0601D802 RID: 120834 RVA: 0x008F945B File Offset: 0x008F765B
		// (set) Token: 0x0601D803 RID: 120835 RVA: 0x008F946B File Offset: 0x008F766B
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_TalkID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_TalkID) = value;
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x0601D804 RID: 120836 RVA: 0x008F947C File Offset: 0x008F767C
		// (set) Token: 0x0601D805 RID: 120837 RVA: 0x008F948C File Offset: 0x008F768C
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_TalkID_SP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_TalkID_SP) = value;
			}
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x0601D806 RID: 120838 RVA: 0x008F949D File Offset: 0x008F769D
		// (set) Token: 0x0601D807 RID: 120839 RVA: 0x008F94AD File Offset: 0x008F76AD
		public unsafe bool SetNewBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_SetNewBound) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_SetNewBound) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x0601D808 RID: 120840 RVA: 0x008F94BE File Offset: 0x008F76BE
		// (set) Token: 0x0601D809 RID: 120841 RVA: 0x008F94CE File Offset: 0x008F76CE
		public unsafe float NewBoundScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_NewBoundScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_NewBoundScale) = value;
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0601D80A RID: 120842 RVA: 0x008F94DF File Offset: 0x008F76DF
		// (set) Token: 0x0601D80B RID: 120843 RVA: 0x008F94EF File Offset: 0x008F76EF
		public unsafe float OriginBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_OriginBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqCustom_C.__PropertyOffset_OriginBound) = value;
			}
		}

		// Token: 0x0601D80C RID: 120844 RVA: 0x008F9500 File Offset: 0x008F7700
		[SkipLocalsInit]
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

		// Token: 0x0601D80D RID: 120845 RVA: 0x008F9560 File Offset: 0x008F7760
		[SkipLocalsInit]
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

		// Token: 0x0601D80E RID: 120846 RVA: 0x008F95C4 File Offset: 0x008F77C4
		[SkipLocalsInit]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_SeqCustom_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqCustom_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D80F RID: 120847 RVA: 0x008F960C File Offset: 0x008F780C
		[SkipLocalsInit]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_SeqCustom_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqCustom_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D810 RID: 120848 RVA: 0x008F9654 File Offset: 0x008F7854
		[SkipLocalsInit]
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

		// Token: 0x0601D811 RID: 120849 RVA: 0x008F96D4 File Offset: 0x008F78D4
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D812 RID: 120850 RVA: 0x008F9754 File Offset: 0x008F7954
		[SkipLocalsInit]
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

		// Token: 0x0601D813 RID: 120851 RVA: 0x008F97D4 File Offset: 0x008F79D4
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D814 RID: 120852 RVA: 0x008F9854 File Offset: 0x008F7A54
		[SkipLocalsInit]
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

		// Token: 0x0601D815 RID: 120853 RVA: 0x008F98D4 File Offset: 0x008F7AD4
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqCustom_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D816 RID: 120854 RVA: 0x008F9954 File Offset: 0x008F7B54
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601D817 RID: 120855 RVA: 0x008F99B4 File Offset: 0x008F7BB4
		[NullableContext(1)]
		[SkipLocalsInit]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SeqCustom_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601D818 RID: 120856 RVA: 0x008F9A14 File Offset: 0x008F7C14
		[SkipLocalsInit]
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

		// Token: 0x0601D819 RID: 120857 RVA: 0x008F9A94 File Offset: 0x008F7C94
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqCustom_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqCustom_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqCustom_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D81A RID: 120858 RVA: 0x008F9B12 File Offset: 0x008F7D12
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D81B RID: 120859 RVA: 0x008F9B26 File Offset: 0x008F7D26
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D81C RID: 120860 RVA: 0x008F9B3A File Offset: 0x008F7D3A
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D81D RID: 120861 RVA: 0x008F9B4E File Offset: 0x008F7D4E
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D81E RID: 120862 RVA: 0x008F9B64 File Offset: 0x008F7D64
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SeqCustom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqCustom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D81F RID: 120863 RVA: 0x008F9BAC File Offset: 0x008F7DAC
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SeqCustom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqCustom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D820 RID: 120864 RVA: 0x008F9BF4 File Offset: 0x008F7DF4
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D821 RID: 120865 RVA: 0x008F9C40 File Offset: 0x008F7E40
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqCustom_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqCustom_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqCustom_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D822 RID: 120866 RVA: 0x008F9C8B File Offset: 0x008F7E8B
		protected BP_SeqCustom_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F889 RID: 63625
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BpSeqCustom/BP_SeqCustom.BP_SeqCustom_C";

		// Token: 0x0400F88A RID: 63626
		private static IntPtr _ClassPtr;

		// Token: 0x0400F88B RID: 63627
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F88C RID: 63628
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x0400F88D RID: 63629
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F88E RID: 63630
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400F88F RID: 63631
		internal static int __PropertyOffset_BoneData;

		// Token: 0x0400F890 RID: 63632
		private TMap<FName, FTransform> _BoneData;

		// Token: 0x0400F891 RID: 63633
		internal static int __PropertyOffset_SupportNames;

		// Token: 0x0400F892 RID: 63634
		private TArray<FName> _SupportNames;

		// Token: 0x0400F893 RID: 63635
		internal static int __PropertyOffset_TalkID;

		// Token: 0x0400F894 RID: 63636
		internal static int __PropertyOffset_TalkID_SP;

		// Token: 0x0400F895 RID: 63637
		internal static int __PropertyOffset_SetNewBound;

		// Token: 0x0400F896 RID: 63638
		internal static int __PropertyOffset_NewBoundScale;

		// Token: 0x0400F897 RID: 63639
		internal static int __PropertyOffset_OriginBound;

		// Token: 0x0400F898 RID: 63640
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0400F899 RID: 63641
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0400F89A RID: 63642
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x0400F89B RID: 63643
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F89C RID: 63644
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F89D RID: 63645
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F89E RID: 63646
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x0400F89F RID: 63647
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F8A0 RID: 63648
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F8A1 RID: 63649
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F8A2 RID: 63650
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F8A3 RID: 63651
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008D3B RID: 36155
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x0402C8A6 RID: 182438
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x0402C8A7 RID: 182439
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02008D3C RID: 36156
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0402C8A8 RID: 182440
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02008D3D RID: 36157
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x0402C8A9 RID: 182441
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02008D3E RID: 36158
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402C8AA RID: 182442
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402C8AB RID: 182443
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D3F RID: 36159
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402C8AC RID: 182444
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402C8AD RID: 182445
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D40 RID: 36160
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x0402C8AE RID: 182446
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402C8AF RID: 182447
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D41 RID: 36161
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x0402C8B0 RID: 182448
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02008D42 RID: 36162
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x0402C8B1 RID: 182449
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402C8B2 RID: 182450
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D43 RID: 36163
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C8B3 RID: 182451
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D44 RID: 36164
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402C8B4 RID: 182452
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
