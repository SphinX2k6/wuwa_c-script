using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseSeqCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using AkiClient.Game.Aki.Sequence.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP
{
	// Token: 0x0200306B RID: 12395
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BP_SeqNPC.BP_SeqNPC_C")]
	[UnrealStructLayout(1952, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1952)]
	public class BP_SeqNPC_C : BP_NpcCombinedMesh_C, IUnrealUObject, IUnrealObject, IBPI_SeqAudio_C, IUnrealBlueprintInterface, IUnrealInterface, IBPI_SeqTalkActor_C
	{
		// Token: 0x0601D74D RID: 120653 RVA: 0x008F7617 File Offset: 0x008F5817
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BP_SeqNPC.BP_SeqNPC_C");
			}
			return BP_SeqNPC_C._ClassPtr;
		}

		// Token: 0x0601D74E RID: 120654 RVA: 0x008F763C File Offset: 0x008F583C
		public BP_SeqNPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D74F RID: 120655 RVA: 0x008F7664 File Offset: 0x008F5864
		[NullableContext(1)]
		public BP_SeqNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x0601D750 RID: 120656 RVA: 0x008F7697 File Offset: 0x008F5897
		// (set) Token: 0x0601D751 RID: 120657 RVA: 0x008F76AB File Offset: 0x008F58AB
		public unsafe SeqAudio_Seq_V2_C SeqAudio_Seq_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<SeqAudio_Seq_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_SeqAudio_Seq_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_SeqAudio_Seq_V2, value);
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x0601D752 RID: 120658 RVA: 0x008F76C0 File Offset: 0x008F58C0
		// (set) Token: 0x0601D753 RID: 120659 RVA: 0x008F76D4 File Offset: 0x008F58D4
		public unsafe ABPC_Seq_Body_V2_C ABPC_Body_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABPC_Seq_Body_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_ABPC_Body_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_ABPC_Body_V2, value);
			}
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x0601D754 RID: 120660 RVA: 0x008F76E9 File Offset: 0x008F58E9
		// (set) Token: 0x0601D755 RID: 120661 RVA: 0x008F76FD File Offset: 0x008F58FD
		public unsafe PD_NpcSetupData_C NPC_DA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_NpcSetupData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_NPC_DA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqNPC_C.__PropertyOffset_NPC_DA, value);
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x0601D756 RID: 120662 RVA: 0x008F7712 File Offset: 0x008F5912
		// (set) Token: 0x0601D757 RID: 120663 RVA: 0x008F7722 File Offset: 0x008F5922
		public unsafe int MaxLod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_MaxLod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_MaxLod) = value;
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0601D758 RID: 120664 RVA: 0x008F7733 File Offset: 0x008F5933
		// (set) Token: 0x0601D759 RID: 120665 RVA: 0x008F7743 File Offset: 0x008F5943
		public unsafe int LodBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_LodBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_LodBias) = value;
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0601D75A RID: 120666 RVA: 0x008F7754 File Offset: 0x008F5954
		// (set) Token: 0x0601D75B RID: 120667 RVA: 0x008F7764 File Offset: 0x008F5964
		public unsafe bool IgnoreSockets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_IgnoreSockets) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_IgnoreSockets) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0601D75C RID: 120668 RVA: 0x008F7775 File Offset: 0x008F5975
		// (set) Token: 0x0601D75D RID: 120669 RVA: 0x008F7785 File Offset: 0x008F5985
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_TalkID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_TalkID) = value;
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0601D75E RID: 120670 RVA: 0x008F7796 File Offset: 0x008F5996
		// (set) Token: 0x0601D75F RID: 120671 RVA: 0x008F77A6 File Offset: 0x008F59A6
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_TalkID_SP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_TalkID_SP) = value;
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x0601D760 RID: 120672 RVA: 0x008F77B8 File Offset: 0x008F59B8
		// (set) Token: 0x0601D761 RID: 120673 RVA: 0x008F77F1 File Offset: 0x008F59F1
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
					result = (this._Float_Curve_Data = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_Float_Curve_Data, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Float_Curve_Data.CopyAssign(value);
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x0601D762 RID: 120674 RVA: 0x008F77FF File Offset: 0x008F59FF
		// (set) Token: 0x0601D763 RID: 120675 RVA: 0x008F780F File Offset: 0x008F5A0F
		public unsafe bool 开启阴影投射
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_开启阴影投射) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_开启阴影投射) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x0601D764 RID: 120676 RVA: 0x008F7820 File Offset: 0x008F5A20
		// (set) Token: 0x0601D765 RID: 120677 RVA: 0x008F7830 File Offset: 0x008F5A30
		public unsafe bool 开启阴影投射Cache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_开启阴影投射Cache) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_开启阴影投射Cache) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0601D766 RID: 120678 RVA: 0x008F7841 File Offset: 0x008F5A41
		// (set) Token: 0x0601D767 RID: 120679 RVA: 0x008F7851 File Offset: 0x008F5A51
		public unsafe bool SetMobileCustomStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_SetMobileCustomStencil) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_SetMobileCustomStencil) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0601D768 RID: 120680 RVA: 0x008F7862 File Offset: 0x008F5A62
		// (set) Token: 0x0601D769 RID: 120681 RVA: 0x008F7872 File Offset: 0x008F5A72
		public unsafe int StencilVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_StencilVal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqNPC_C.__PropertyOffset_StencilVal) = value;
			}
		}

		// Token: 0x0601D76A RID: 120682 RVA: 0x008F7884 File Offset: 0x008F5A84
		[SkipLocalsInit]
		public unsafe virtual void GetSeqTalkId(ref int TalkID, ref int TalkID_SP)
		{
			BP_SeqNPC_C.__GetSeqTalkId_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSeqTalkId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSeqTalkId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TalkID = TalkID;
			ptr->TalkID_SP = TalkID_SP;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr);
			TalkID = ptr->TalkID;
			TalkID_SP = ptr->TalkID_SP;
		}

		// Token: 0x0601D76B RID: 120683 RVA: 0x008F78E4 File Offset: 0x008F5AE4
		[SkipLocalsInit]
		public unsafe virtual void GetSeqMouthAnimInstance(ref UAnimInstance AnimInstance)
		{
			BP_SeqNPC_C.__GetSeqMouthAnimInstance_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSeqMouthAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSeqMouthAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqNPC_C.__GetSeqMouthAnimInstance_FunctionParams ptr2 = ref *ptr;
			UAnimInstance uanimInstance = AnimInstance;
			ptr2.AnimInstance = ((uanimInstance != null) ? uanimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr);
			AnimInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(ptr->AnimInstance);
		}

		// Token: 0x0601D76C RID: 120684 RVA: 0x008F7948 File Offset: 0x008F5B48
		[SkipLocalsInit]
		public unsafe virtual void GetSeqAudio(ref SeqAudio_Seq_V2_C SeqAudio)
		{
			BP_SeqNPC_C.__GetSeqAudio_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSeqAudio_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSeqAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSeqAudio_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqNPC_C.__GetSeqAudio_FunctionParams ptr2 = ref *ptr;
			SeqAudio_Seq_V2_C seqAudio_Seq_V2_C = SeqAudio;
			ptr2.SeqAudio = ((seqAudio_Seq_V2_C != null) ? seqAudio_Seq_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetSeqAudio_NativeFunctionPtr, (void*)ptr);
			SeqAudio = BuiltinUtils.GetOrCreateUObjectByNativePointer<SeqAudio_Seq_V2_C>(ptr->SeqAudio);
		}

		// Token: 0x0601D76D RID: 120685 RVA: 0x008F79AC File Offset: 0x008F5BAC
		[SkipLocalsInit]
		public unsafe virtual void GetABPC_Body_V2(ref ABPC_Seq_Body_V2_C ABPC_Body_V2)
		{
			BP_SeqNPC_C.__GetABPC_Body_V2_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetABPC_Body_V2_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqNPC_C.__GetABPC_Body_V2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_SeqNPC_C.__GetABPC_Body_V2_FunctionParams ptr2 = ref *ptr;
			ABPC_Seq_Body_V2_C abpc_Seq_Body_V2_C = ABPC_Body_V2;
			ptr2.ABPC_Body_V2 = ((abpc_Seq_Body_V2_C != null) ? abpc_Seq_Body_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr);
			ABPC_Body_V2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ABPC_Seq_Body_V2_C>(ptr->ABPC_Body_V2);
		}

		// Token: 0x0601D76E RID: 120686 RVA: 0x008F7A10 File Offset: 0x008F5C10
		[SkipLocalsInit]
		public unsafe virtual bool GetAnimDataTransform(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D76F RID: 120687 RVA: 0x008F7A90 File Offset: 0x008F5C90
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D770 RID: 120688 RVA: 0x008F7B10 File Offset: 0x008F5D10
		[SkipLocalsInit]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_SeqNPC_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqNPC_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D771 RID: 120689 RVA: 0x008F7B58 File Offset: 0x008F5D58
		[SkipLocalsInit]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_SeqNPC_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqNPC_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D772 RID: 120690 RVA: 0x008F7BA0 File Offset: 0x008F5DA0
		[SkipLocalsInit]
		public unsafe virtual bool SetAnimDataTransform(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D773 RID: 120691 RVA: 0x008F7C20 File Offset: 0x008F5E20
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D774 RID: 120692 RVA: 0x008F7CA0 File Offset: 0x008F5EA0
		[SkipLocalsInit]
		public unsafe virtual bool GetAnimDataVector(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D775 RID: 120693 RVA: 0x008F7D20 File Offset: 0x008F5F20
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqNPC_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D776 RID: 120694 RVA: 0x008F7DA0 File Offset: 0x008F5FA0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601D777 RID: 120695 RVA: 0x008F7E00 File Offset: 0x008F6000
		[NullableContext(1)]
		[SkipLocalsInit]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SeqNPC_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601D778 RID: 120696 RVA: 0x008F7E60 File Offset: 0x008F6060
		[SkipLocalsInit]
		public unsafe virtual bool SetAnimDataVector(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D779 RID: 120697 RVA: 0x008F7EE0 File Offset: 0x008F60E0
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_SeqNPC_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SeqNPC_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_SeqNPC_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601D77A RID: 120698 RVA: 0x008F7F5E File Offset: 0x008F615E
		[SkipLocalsInit]
		public virtual void UpdateNpcByDa()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__UpdateNpcByDa_NativeFunctionPtr, null);
		}

		// Token: 0x0601D77B RID: 120699 RVA: 0x008F7F72 File Offset: 0x008F6172
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D77C RID: 120700 RVA: 0x008F7F86 File Offset: 0x008F6186
		[SkipLocalsInit]
		protected override void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D77D RID: 120701 RVA: 0x008F7F9C File Offset: 0x008F619C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SeqNPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqNPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D77E RID: 120702 RVA: 0x008F7FE4 File Offset: 0x008F61E4
		[SkipLocalsInit]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SeqNPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqNPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D77F RID: 120703 RVA: 0x008F802C File Offset: 0x008F622C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SeqNPC_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqNPC_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqNPC_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D780 RID: 120704 RVA: 0x008F8074 File Offset: 0x008F6274
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SeqNPC_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeqNPC_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqNPC_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqNPC_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqNPC_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D781 RID: 120705 RVA: 0x008F80BA File Offset: 0x008F62BA
		protected BP_SeqNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F827 RID: 63527
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BP_SeqNPC.BP_SeqNPC_C";

		// Token: 0x0400F828 RID: 63528
		private static IntPtr _ClassPtr;

		// Token: 0x0400F829 RID: 63529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F82A RID: 63530
		internal static int __PropertyOffset_SeqAudio_Seq_V2;

		// Token: 0x0400F82B RID: 63531
		internal static int __PropertyOffset_ABPC_Body_V2;

		// Token: 0x0400F82C RID: 63532
		internal static int __PropertyOffset_NPC_DA;

		// Token: 0x0400F82D RID: 63533
		internal static int __PropertyOffset_MaxLod;

		// Token: 0x0400F82E RID: 63534
		internal static int __PropertyOffset_LodBias;

		// Token: 0x0400F82F RID: 63535
		internal static int __PropertyOffset_IgnoreSockets;

		// Token: 0x0400F830 RID: 63536
		internal static int __PropertyOffset_TalkID;

		// Token: 0x0400F831 RID: 63537
		internal static int __PropertyOffset_TalkID_SP;

		// Token: 0x0400F832 RID: 63538
		internal static int __PropertyOffset_Float_Curve_Data;

		// Token: 0x0400F833 RID: 63539
		private TMap<FName, FTransform> _Float_Curve_Data;

		// Token: 0x0400F834 RID: 63540
		internal static int __PropertyOffset_开启阴影投射;

		// Token: 0x0400F835 RID: 63541
		internal static int __PropertyOffset_开启阴影投射Cache;

		// Token: 0x0400F836 RID: 63542
		internal static int __PropertyOffset_SetMobileCustomStencil;

		// Token: 0x0400F837 RID: 63543
		internal static int __PropertyOffset_StencilVal;

		// Token: 0x0400F838 RID: 63544
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0400F839 RID: 63545
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0400F83A RID: 63546
		private static IntPtr __GetSeqAudio_NativeFunctionPtr;

		// Token: 0x0400F83B RID: 63547
		private static IntPtr __GetABPC_Body_V2_NativeFunctionPtr;

		// Token: 0x0400F83C RID: 63548
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F83D RID: 63549
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x0400F83E RID: 63550
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x0400F83F RID: 63551
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F840 RID: 63552
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x0400F841 RID: 63553
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x0400F842 RID: 63554
		private static IntPtr __UpdateNpcByDa_NativeFunctionPtr;

		// Token: 0x0400F843 RID: 63555
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F844 RID: 63556
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F845 RID: 63557
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008D1D RID: 36125
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x0402C876 RID: 182390
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x0402C877 RID: 182391
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02008D1E RID: 36126
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0402C878 RID: 182392
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02008D1F RID: 36127
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqAudio_FunctionParams
		{
			// Token: 0x0402C879 RID: 182393
			[FieldOffset(0)]
			public IntPtr SeqAudio;
		}

		// Token: 0x02008D20 RID: 36128
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetABPC_Body_V2_FunctionParams
		{
			// Token: 0x0402C87A RID: 182394
			[FieldOffset(0)]
			public IntPtr ABPC_Body_V2;
		}

		// Token: 0x02008D21 RID: 36129
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402C87B RID: 182395
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402C87C RID: 182396
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D22 RID: 36130
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x0402C87D RID: 182397
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02008D23 RID: 36131
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402C87E RID: 182398
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402C87F RID: 182399
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D24 RID: 36132
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x0402C880 RID: 182400
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402C881 RID: 182401
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D25 RID: 36133
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x0402C882 RID: 182402
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02008D26 RID: 36134
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x0402C883 RID: 182403
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402C884 RID: 182404
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02008D27 RID: 36135
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C885 RID: 182405
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D28 RID: 36136
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402C886 RID: 182406
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
