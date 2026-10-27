using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.Sequence.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x0200426E RID: 17006
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/BP_BaseRole_Seq_V2.BP_BaseRole_Seq_V2_C")]
	[UnrealStructLayout(1392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1392)]
	public class BP_BaseRole_Seq_V2_C : APawn, IUnrealUObject, IUnrealObject, IABPC_Seq_Interface_C, IUnrealBlueprintInterface, IUnrealInterface, ISeqAnimDataInterface, IUnrealNativeInterface, IBPI_SeqAudio_C, IBPI_SeqBindingActor_C, IBPI_SeqBlendActor_C, IBPI_SeqTalkActor_C, IBPI_SeqCostumeState_C, IBPI_SeqRoleMesh_C
	{
		// Token: 0x0602C19E RID: 180638 RVA: 0x00A15AC8 File Offset: 0x00A13CC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseRole_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseSeqCharacter/BP_BaseRole_Seq_V2.BP_BaseRole_Seq_V2_C");
			}
			return BP_BaseRole_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602C19F RID: 180639 RVA: 0x00A15AEC File Offset: 0x00A13CEC
		int ISeqAnimDataInterface.InterfaceOffset()
		{
			return BP_BaseRole_Seq_V2_C.__InterfaceOffset_ISeqAnimDataInterface;
		}

		// Token: 0x0602C1A0 RID: 180640 RVA: 0x00A15AF4 File Offset: 0x00A13CF4
		public BP_BaseRole_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseRole_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C1A1 RID: 180641 RVA: 0x00A15B1C File Offset: 0x00A13D1C
		[NullableContext(1)]
		public BP_BaseRole_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseRole_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D9C RID: 28060
		// (get) Token: 0x0602C1A2 RID: 180642 RVA: 0x00A15B4F File Offset: 0x00A13D4F
		// (set) Token: 0x0602C1A3 RID: 180643 RVA: 0x00A15B63 File Offset: 0x00A13D63
		public unsafe SeqAudio_Seq_V2_C SeqAudio_Seq_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<SeqAudio_Seq_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006D9D RID: 28061
		// (get) Token: 0x0602C1A4 RID: 180644 RVA: 0x00A15B78 File Offset: 0x00A13D78
		// (set) Token: 0x0602C1A5 RID: 180645 RVA: 0x00A15B8C File Offset: 0x00A13D8C
		public unsafe UChildActorComponent Hulu
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006D9E RID: 28062
		// (get) Token: 0x0602C1A6 RID: 180646 RVA: 0x00A15BA1 File Offset: 0x00A13DA1
		// (set) Token: 0x0602C1A7 RID: 180647 RVA: 0x00A15BB5 File Offset: 0x00A13DB5
		public unsafe ABPC_Seq_Body_V2_C ABPC_Body_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABPC_Seq_Body_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006D9F RID: 28063
		// (get) Token: 0x0602C1A8 RID: 180648 RVA: 0x00A15BCA File Offset: 0x00A13DCA
		// (set) Token: 0x0602C1A9 RID: 180649 RVA: 0x00A15BDE File Offset: 0x00A13DDE
		public unsafe USkeletalMeshComponent SkeletalMeshComponent0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17006DA0 RID: 28064
		// (get) Token: 0x0602C1AA RID: 180650 RVA: 0x00A15BF3 File Offset: 0x00A13DF3
		// (set) Token: 0x0602C1AB RID: 180651 RVA: 0x00A15C07 File Offset: 0x00A13E07
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17006DA1 RID: 28065
		// (get) Token: 0x0602C1AC RID: 180652 RVA: 0x00A15C1C File Offset: 0x00A13E1C
		// (set) Token: 0x0602C1AD RID: 180653 RVA: 0x00A15C2C File Offset: 0x00A13E2C
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006DA2 RID: 28066
		// (get) Token: 0x0602C1AE RID: 180654 RVA: 0x00A15C3D File Offset: 0x00A13E3D
		// (set) Token: 0x0602C1AF RID: 180655 RVA: 0x00A15C51 File Offset: 0x00A13E51
		public unsafe FName BindingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006DA3 RID: 28067
		// (get) Token: 0x0602C1B0 RID: 180656 RVA: 0x00A15C66 File Offset: 0x00A13E66
		// (set) Token: 0x0602C1B1 RID: 180657 RVA: 0x00A15C76 File Offset: 0x00A13E76
		public unsafe float HuluFX_Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006DA4 RID: 28068
		// (get) Token: 0x0602C1B2 RID: 180658 RVA: 0x00A15C87 File Offset: 0x00A13E87
		// (set) Token: 0x0602C1B3 RID: 180659 RVA: 0x00A15C97 File Offset: 0x00A13E97
		public unsafe float CharFX_Group_Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006DA5 RID: 28069
		// (get) Token: 0x0602C1B4 RID: 180660 RVA: 0x00A15CA8 File Offset: 0x00A13EA8
		// (set) Token: 0x0602C1B5 RID: 180661 RVA: 0x00A15CB8 File Offset: 0x00A13EB8
		public unsafe float CharFX_Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006DA6 RID: 28070
		// (get) Token: 0x0602C1B6 RID: 180662 RVA: 0x00A15CC9 File Offset: 0x00A13EC9
		// (set) Token: 0x0602C1B7 RID: 180663 RVA: 0x00A15CDD File Offset: 0x00A13EDD
		public unsafe PD_CharacterControllerDataGroup_C DataGroup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006DA7 RID: 28071
		// (get) Token: 0x0602C1B8 RID: 180664 RVA: 0x00A15CF2 File Offset: 0x00A13EF2
		// (set) Token: 0x0602C1B9 RID: 180665 RVA: 0x00A15D06 File Offset: 0x00A13F06
		public unsafe PD_CharacterControllerData_C Data
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17006DA8 RID: 28072
		// (get) Token: 0x0602C1BA RID: 180666 RVA: 0x00A15D1B File Offset: 0x00A13F1B
		// (set) Token: 0x0602C1BB RID: 180667 RVA: 0x00A15D2F File Offset: 0x00A13F2F
		public unsafe BP_Fx_Scanning_C BPScanning
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Fx_Scanning_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006DA9 RID: 28073
		// (get) Token: 0x0602C1BC RID: 180668 RVA: 0x00A15D44 File Offset: 0x00A13F44
		// (set) Token: 0x0602C1BD RID: 180669 RVA: 0x00A15D58 File Offset: 0x00A13F58
		public unsafe CharRenderingComponent CharRenderingComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<CharRenderingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17006DAA RID: 28074
		// (get) Token: 0x0602C1BE RID: 180670 RVA: 0x00A15D6D File Offset: 0x00A13F6D
		// (set) Token: 0x0602C1BF RID: 180671 RVA: 0x00A15D7D File Offset: 0x00A13F7D
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006DAB RID: 28075
		// (get) Token: 0x0602C1C0 RID: 180672 RVA: 0x00A15D8E File Offset: 0x00A13F8E
		// (set) Token: 0x0602C1C1 RID: 180673 RVA: 0x00A15D9E File Offset: 0x00A13F9E
		public unsafe bool EnableKeyLightChan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DAC RID: 28076
		// (get) Token: 0x0602C1C2 RID: 180674 RVA: 0x00A15DAF File Offset: 0x00A13FAF
		// (set) Token: 0x0602C1C3 RID: 180675 RVA: 0x00A15DBF File Offset: 0x00A13FBF
		public unsafe bool ToonLightChan0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DAD RID: 28077
		// (get) Token: 0x0602C1C4 RID: 180676 RVA: 0x00A15DD0 File Offset: 0x00A13FD0
		// (set) Token: 0x0602C1C5 RID: 180677 RVA: 0x00A15DE0 File Offset: 0x00A13FE0
		public unsafe bool ToonLightChan1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DAE RID: 28078
		// (get) Token: 0x0602C1C6 RID: 180678 RVA: 0x00A15DF1 File Offset: 0x00A13FF1
		// (set) Token: 0x0602C1C7 RID: 180679 RVA: 0x00A15E01 File Offset: 0x00A14001
		public unsafe bool ToonLightChan2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DAF RID: 28079
		// (get) Token: 0x0602C1C8 RID: 180680 RVA: 0x00A15E14 File Offset: 0x00A14014
		// (set) Token: 0x0602C1C9 RID: 180681 RVA: 0x00A15E4D File Offset: 0x00A1404D
		[Nullable(1)]
		public TMap<FName, FTransform> CustomData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FTransform> result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x17006DB0 RID: 28080
		// (get) Token: 0x0602C1CA RID: 180682 RVA: 0x00A15E5B File Offset: 0x00A1405B
		// (set) Token: 0x0602C1CB RID: 180683 RVA: 0x00A15E70 File Offset: 0x00A14070
		[Nullable(1)]
		public TSoftObjectPtr<USkeletalMesh> MeshRef
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_21, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_21, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602C1CC RID: 180684 RVA: 0x00A15E98 File Offset: 0x00A14098
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqMeshRef(ref TSoftObjectPtr<USkeletalMesh> MeshRef)
		{
			BP_BaseRole_Seq_V2_C.__GetSeqMeshRef_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSeqMeshRef_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSeqMeshRef_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSeqMeshRef_NativeFunctionPtr, (void*)ptr, 1);
			if (MeshRef != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->MeshRef, MeshRef.NativePtr, 1);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSeqMeshRef_NativeFunctionPtr, (void*)ptr);
			if (MeshRef != null)
			{
				FSoftObjectPtr.NativeCopy(MeshRef.NativePtr, &ptr->MeshRef, 1);
			}
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetSeqMeshRef_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C1CD RID: 180685 RVA: 0x00A15F24 File Offset: 0x00A14124
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqTalkId(ref int TalkID, ref int TalkID_SP)
		{
			BP_BaseRole_Seq_V2_C.__GetSeqTalkId_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSeqTalkId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSeqTalkId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TalkID = TalkID;
			ptr->TalkID_SP = TalkID_SP;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSeqTalkId_NativeFunctionPtr, (void*)ptr);
			TalkID = ptr->TalkID;
			TalkID_SP = ptr->TalkID_SP;
		}

		// Token: 0x0602C1CE RID: 180686 RVA: 0x00A15F84 File Offset: 0x00A14184
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqMouthAnimInstance(ref UAnimInstance AnimInstance)
		{
			BP_BaseRole_Seq_V2_C.__GetSeqMouthAnimInstance_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSeqMouthAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSeqMouthAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_BaseRole_Seq_V2_C.__GetSeqMouthAnimInstance_FunctionParams ptr2 = ref *ptr;
			UAnimInstance uanimInstance = AnimInstance;
			ptr2.AnimInstance = ((uanimInstance != null) ? uanimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSeqMouthAnimInstance_NativeFunctionPtr, (void*)ptr);
			AnimInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(ptr->AnimInstance);
		}

		// Token: 0x0602C1CF RID: 180687 RVA: 0x00A15FE8 File Offset: 0x00A141E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqBlendMesh(ref USkeletalMeshComponent Mesh)
		{
			BP_BaseRole_Seq_V2_C.__GetSeqBlendMesh_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSeqBlendMesh_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSeqBlendMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSeqBlendMesh_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_BaseRole_Seq_V2_C.__GetSeqBlendMesh_FunctionParams ptr2 = ref *ptr;
			USkeletalMeshComponent uskeletalMeshComponent = Mesh;
			ptr2.Mesh = ((uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSeqBlendMesh_NativeFunctionPtr, (void*)ptr);
			Mesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ptr->Mesh);
		}

		// Token: 0x0602C1D0 RID: 180688 RVA: 0x00A1604C File Offset: 0x00A1424C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqBindingTag(ref FName Tag)
		{
			BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr);
			Tag = ptr->Tag;
		}

		// Token: 0x0602C1D1 RID: 180689 RVA: 0x00A160A4 File Offset: 0x00A142A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSeqAudio(ref SeqAudio_Seq_V2_C SeqAudio)
		{
			BP_BaseRole_Seq_V2_C.__GetSeqAudio_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSeqAudio_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSeqAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSeqAudio_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_BaseRole_Seq_V2_C.__GetSeqAudio_FunctionParams ptr2 = ref *ptr;
			SeqAudio_Seq_V2_C seqAudio_Seq_V2_C = SeqAudio;
			ptr2.SeqAudio = ((seqAudio_Seq_V2_C != null) ? seqAudio_Seq_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSeqAudio_NativeFunctionPtr, (void*)ptr);
			SeqAudio = BuiltinUtils.GetOrCreateUObjectByNativePointer<SeqAudio_Seq_V2_C>(ptr->SeqAudio);
		}

		// Token: 0x0602C1D2 RID: 180690 RVA: 0x00A16108 File Offset: 0x00A14308
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataTransform(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1D3 RID: 180691 RVA: 0x00A16188 File Offset: 0x00A14388
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1D4 RID: 180692 RVA: 0x00A16208 File Offset: 0x00A14408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C1D5 RID: 180693 RVA: 0x00A16250 File Offset: 0x00A14450
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602C1D6 RID: 180694 RVA: 0x00A16298 File Offset: 0x00A14498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataTransform(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1D7 RID: 180695 RVA: 0x00A16318 File Offset: 0x00A14518
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1D8 RID: 180696 RVA: 0x00A16398 File Offset: 0x00A14598
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602C1D9 RID: 180697 RVA: 0x00A163F8 File Offset: 0x00A145F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602C1DA RID: 180698 RVA: 0x00A16458 File Offset: 0x00A14658
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1DB RID: 180699 RVA: 0x00A164D8 File Offset: 0x00A146D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1DC RID: 180700 RVA: 0x00A16558 File Offset: 0x00A14758
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool GetAnimDataVector(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1DD RID: 180701 RVA: 0x00A165D8 File Offset: 0x00A147D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1DE RID: 180702 RVA: 0x00A16658 File Offset: 0x00A14858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1DF RID: 180703 RVA: 0x00A166D8 File Offset: 0x00A148D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1E0 RID: 180704 RVA: 0x00A16758 File Offset: 0x00A14958
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool SetAnimDataVector(in TMap<FName, FVector> VectorCurveData)
		{
			BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1E1 RID: 180705 RVA: 0x00A167D8 File Offset: 0x00A149D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C1E2 RID: 180706 RVA: 0x00A16858 File Offset: 0x00A14A58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetABPC_Body_V2(ref ABPC_Seq_Body_V2_C ABPC_Body_V2)
		{
			BP_BaseRole_Seq_V2_C.__GetABPC_Body_V2_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetABPC_Body_V2_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetABPC_Body_V2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_BaseRole_Seq_V2_C.__GetABPC_Body_V2_FunctionParams ptr2 = ref *ptr;
			ABPC_Seq_Body_V2_C abpc_Seq_Body_V2_C = ABPC_Body_V2;
			ptr2.ABPC_Body_V2 = ((abpc_Seq_Body_V2_C != null) ? abpc_Seq_Body_V2_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetABPC_Body_V2_NativeFunctionPtr, (void*)ptr);
			ABPC_Body_V2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ABPC_Seq_Body_V2_C>(ptr->ABPC_Body_V2);
		}

		// Token: 0x0602C1E3 RID: 180707 RVA: 0x00A168BC File Offset: 0x00A14ABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LightChanel()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__LightChanel_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1E4 RID: 180708 RVA: 0x00A168D0 File Offset: 0x00A14AD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EndSwitchPose_ToBP(AActor To, bool Log)
		{
			BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->Log = Log;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1E5 RID: 180709 RVA: 0x00A1692C File Offset: 0x00A14B2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EndSwitchPose_ToSeq(AActor To, bool Log)
		{
			BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->Log = Log;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1E6 RID: 180710 RVA: 0x00A16988 File Offset: 0x00A14B88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BeginSwitchPose_ToBP(AActor From, AActor To, float SwitchTime, bool ErrorLog)
		{
			BP_BaseRole_Seq_V2_C.__BeginSwitchPose_ToBP_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__BeginSwitchPose_ToBP_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__BeginSwitchPose_ToBP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__BeginSwitchPose_ToBP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->SwitchTime = SwitchTime;
			ptr->ErrorLog = ErrorLog;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__BeginSwitchPose_ToBP_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1E7 RID: 180711 RVA: 0x00A16A08 File Offset: 0x00A14C08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Begin_Switch_Pose_to_Seq(AActor From, AActor To, float SwitchTime, bool ErrorLog)
		{
			BP_BaseRole_Seq_V2_C.__Begin_Switch_Pose_to_Seq_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__Begin_Switch_Pose_to_Seq_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__Begin_Switch_Pose_to_Seq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__Begin_Switch_Pose_to_Seq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->SwitchTime = SwitchTime;
			ptr->ErrorLog = ErrorLog;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__Begin_Switch_Pose_to_Seq_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1E8 RID: 180712 RVA: 0x00A16A85 File Offset: 0x00A14C85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加扫描效果()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__添加扫描效果_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1E9 RID: 180713 RVA: 0x00A16A99 File Offset: 0x00A14C99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 卸载角色材质控制器()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__卸载角色材质控制器_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1EA RID: 180714 RVA: 0x00A16AAD File Offset: 0x00A14CAD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加角色材质控制器()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__添加角色材质控制器_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1EB RID: 180715 RVA: 0x00A16AC1 File Offset: 0x00A14CC1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 卸载角色材质控制器组()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__卸载角色材质控制器组_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1EC RID: 180716 RVA: 0x00A16AD5 File Offset: 0x00A14CD5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加角色材质控制器组()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__添加角色材质控制器组_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1ED RID: 180717 RVA: 0x00A16AE9 File Offset: 0x00A14CE9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CleanHuluState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__CleanHuluState_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1EE RID: 180718 RVA: 0x00A16B00 File Offset: 0x00A14D00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeHuluState(int State)
		{
			BP_BaseRole_Seq_V2_C.__ChangeHuluState_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__ChangeHuluState_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__ChangeHuluState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__ChangeHuluState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ChangeHuluState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1EF RID: 180719 RVA: 0x00A16B48 File Offset: 0x00A14D48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SwitchMeshTransform(bool LevelA)
		{
			BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LevelA = LevelA;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1F0 RID: 180720 RVA: 0x00A16B90 File Offset: 0x00A14D90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EndSwitchPose(AActor To, bool Log)
		{
			BP_BaseRole_Seq_V2_C.__EndSwitchPose_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__EndSwitchPose_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__EndSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__EndSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->Log = Log;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__EndSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1F1 RID: 180721 RVA: 0x00A16BEC File Offset: 0x00A14DEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BeginSwitchPose(AActor From, AActor To, float SwitchTime, bool ErrorLog)
		{
			BP_BaseRole_Seq_V2_C.__BeginSwitchPose_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__BeginSwitchPose_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__BeginSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__BeginSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->SwitchTime = SwitchTime;
			ptr->ErrorLog = ErrorLog;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__BeginSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1F2 RID: 180722 RVA: 0x00A16C66 File Offset: 0x00A14E66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void JumpFrame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__JumpFrame_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1F3 RID: 180723 RVA: 0x00A16C7A File Offset: 0x00A14E7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1F4 RID: 180724 RVA: 0x00A16C8E File Offset: 0x00A14E8E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602C1F5 RID: 180725 RVA: 0x00A16CA3 File Offset: 0x00A14EA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1F6 RID: 180726 RVA: 0x00A16CB7 File Offset: 0x00A14EB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602C1F7 RID: 180727 RVA: 0x00A16CCC File Offset: 0x00A14ECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BeginSeqSwitchPose(AActor From, AActor To, float SwitchTime)
		{
			BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->SwitchTime = SwitchTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1F8 RID: 180728 RVA: 0x00A16D40 File Offset: 0x00A14F40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EndSeqSwitchPose(AActor To)
		{
			BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1F9 RID: 180729 RVA: 0x00A16D98 File Offset: 0x00A14F98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplySeqCostumeState(int State)
		{
			BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C1FA RID: 180730 RVA: 0x00A16DDE File Offset: 0x00A14FDE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearSeqCostumeState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ClearSeqCostumeState_NativeFunctionPtr, null);
		}

		// Token: 0x0602C1FB RID: 180731 RVA: 0x00A16DF2 File Offset: 0x00A14FF2
		protected BP_BaseRole_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401710F RID: 94479
		internal static int __InterfaceOffset_ISeqAnimDataInterface;

		// Token: 0x04017110 RID: 94480
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/BP_BaseRole_Seq_V2.BP_BaseRole_Seq_V2_C";

		// Token: 0x04017111 RID: 94481
		private static IntPtr _ClassPtr;

		// Token: 0x04017112 RID: 94482
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017113 RID: 94483
		internal static int __PropertyOffset_1;

		// Token: 0x04017114 RID: 94484
		internal static int __PropertyOffset_2;

		// Token: 0x04017115 RID: 94485
		internal static int __PropertyOffset_3;

		// Token: 0x04017116 RID: 94486
		internal static int __PropertyOffset_4;

		// Token: 0x04017117 RID: 94487
		internal static int __PropertyOffset_5;

		// Token: 0x04017118 RID: 94488
		internal static int __PropertyOffset_6;

		// Token: 0x04017119 RID: 94489
		internal static int __PropertyOffset_7;

		// Token: 0x0401711A RID: 94490
		internal static int __PropertyOffset_8;

		// Token: 0x0401711B RID: 94491
		internal static int __PropertyOffset_9;

		// Token: 0x0401711C RID: 94492
		internal static int __PropertyOffset_10;

		// Token: 0x0401711D RID: 94493
		internal static int __PropertyOffset_11;

		// Token: 0x0401711E RID: 94494
		internal static int __PropertyOffset_12;

		// Token: 0x0401711F RID: 94495
		internal static int __PropertyOffset_13;

		// Token: 0x04017120 RID: 94496
		internal static int __PropertyOffset_14;

		// Token: 0x04017121 RID: 94497
		internal static int __PropertyOffset_15;

		// Token: 0x04017122 RID: 94498
		internal static int __PropertyOffset_16;

		// Token: 0x04017123 RID: 94499
		internal static int __PropertyOffset_17;

		// Token: 0x04017124 RID: 94500
		internal static int __PropertyOffset_18;

		// Token: 0x04017125 RID: 94501
		internal static int __PropertyOffset_19;

		// Token: 0x04017126 RID: 94502
		internal static int __PropertyOffset_20;

		// Token: 0x04017127 RID: 94503
		private TMap<FName, FTransform> _CustomData;

		// Token: 0x04017128 RID: 94504
		internal static int __PropertyOffset_21;

		// Token: 0x04017129 RID: 94505
		private static IntPtr __GetSeqMeshRef_NativeFunctionPtr;

		// Token: 0x0401712A RID: 94506
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x0401712B RID: 94507
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x0401712C RID: 94508
		private static IntPtr __GetSeqBlendMesh_NativeFunctionPtr;

		// Token: 0x0401712D RID: 94509
		private static IntPtr __GetSeqBindingTag_NativeFunctionPtr;

		// Token: 0x0401712E RID: 94510
		private static IntPtr __GetSeqAudio_NativeFunctionPtr;

		// Token: 0x0401712F RID: 94511
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x04017130 RID: 94512
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x04017131 RID: 94513
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x04017132 RID: 94514
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x04017133 RID: 94515
		private static IntPtr __GetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x04017134 RID: 94516
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x04017135 RID: 94517
		private static IntPtr __SetAnimDataFloat_NativeFunctionPtr;

		// Token: 0x04017136 RID: 94518
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x04017137 RID: 94519
		private static IntPtr __GetABPC_Body_V2_NativeFunctionPtr;

		// Token: 0x04017138 RID: 94520
		private static IntPtr __LightChanel_NativeFunctionPtr;

		// Token: 0x04017139 RID: 94521
		private static IntPtr __EndSwitchPose_ToBP_NativeFunctionPtr;

		// Token: 0x0401713A RID: 94522
		private static IntPtr __EndSwitchPose_ToSeq_NativeFunctionPtr;

		// Token: 0x0401713B RID: 94523
		private static IntPtr __BeginSwitchPose_ToBP_NativeFunctionPtr;

		// Token: 0x0401713C RID: 94524
		private static IntPtr __Begin_Switch_Pose_to_Seq_NativeFunctionPtr;

		// Token: 0x0401713D RID: 94525
		private static IntPtr __添加扫描效果_NativeFunctionPtr;

		// Token: 0x0401713E RID: 94526
		private static IntPtr __卸载角色材质控制器_NativeFunctionPtr;

		// Token: 0x0401713F RID: 94527
		private static IntPtr __添加角色材质控制器_NativeFunctionPtr;

		// Token: 0x04017140 RID: 94528
		private static IntPtr __卸载角色材质控制器组_NativeFunctionPtr;

		// Token: 0x04017141 RID: 94529
		private static IntPtr __添加角色材质控制器组_NativeFunctionPtr;

		// Token: 0x04017142 RID: 94530
		private static IntPtr __CleanHuluState_NativeFunctionPtr;

		// Token: 0x04017143 RID: 94531
		private static IntPtr __ChangeHuluState_NativeFunctionPtr;

		// Token: 0x04017144 RID: 94532
		private static IntPtr __SwitchMeshTransform_NativeFunctionPtr;

		// Token: 0x04017145 RID: 94533
		private static IntPtr __EndSwitchPose_NativeFunctionPtr;

		// Token: 0x04017146 RID: 94534
		private static IntPtr __BeginSwitchPose_NativeFunctionPtr;

		// Token: 0x04017147 RID: 94535
		private static IntPtr __JumpFrame_NativeFunctionPtr;

		// Token: 0x04017148 RID: 94536
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04017149 RID: 94537
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0401714A RID: 94538
		private static IntPtr __BeginSeqSwitchPose_NativeFunctionPtr;

		// Token: 0x0401714B RID: 94539
		private static IntPtr __EndSeqSwitchPose_NativeFunctionPtr;

		// Token: 0x0401714C RID: 94540
		private static IntPtr __ApplySeqCostumeState_NativeFunctionPtr;

		// Token: 0x0401714D RID: 94541
		private static IntPtr __ClearSeqCostumeState_NativeFunctionPtr;

		// Token: 0x0200A62D RID: 42541
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSeqMeshRef_FunctionParams
		{
			// Token: 0x04032517 RID: 206103
			[FieldOffset(0)]
			public byte MeshRef;
		}

		// Token: 0x0200A62E RID: 42542
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x04032518 RID: 206104
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x04032519 RID: 206105
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x0200A62F RID: 42543
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0403251A RID: 206106
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x0200A630 RID: 42544
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqBlendMesh_FunctionParams
		{
			// Token: 0x0403251B RID: 206107
			[FieldOffset(0)]
			public IntPtr Mesh;
		}

		// Token: 0x0200A631 RID: 42545
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetSeqBindingTag_FunctionParams
		{
			// Token: 0x0403251C RID: 206108
			[FieldOffset(0)]
			public FName Tag;
		}

		// Token: 0x0200A632 RID: 42546
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqAudio_FunctionParams
		{
			// Token: 0x0403251D RID: 206109
			[FieldOffset(0)]
			public IntPtr SeqAudio;
		}

		// Token: 0x0200A633 RID: 42547
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x0403251E RID: 206110
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0403251F RID: 206111
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x0200A634 RID: 42548
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x04032520 RID: 206112
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200A635 RID: 42549
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x04032521 RID: 206113
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04032522 RID: 206114
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x0200A636 RID: 42550
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x04032523 RID: 206115
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A637 RID: 42551
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAnimDataFloat_FunctionParams
		{
			// Token: 0x04032524 RID: 206116
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04032525 RID: 206117
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200A638 RID: 42552
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x04032526 RID: 206118
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x04032527 RID: 206119
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x0200A639 RID: 42553
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetAnimDataFloat_FunctionParams
		{
			// Token: 0x04032528 RID: 206120
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x04032529 RID: 206121
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200A63A RID: 42554
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x0403252A RID: 206122
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0403252B RID: 206123
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x0200A63B RID: 42555
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetABPC_Body_V2_FunctionParams
		{
			// Token: 0x0403252C RID: 206124
			[FieldOffset(0)]
			public IntPtr ABPC_Body_V2;
		}

		// Token: 0x0200A63C RID: 42556
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __EndSwitchPose_ToBP_FunctionParams
		{
			// Token: 0x0403252D RID: 206125
			[FieldOffset(0)]
			public IntPtr To;

			// Token: 0x0403252E RID: 206126
			[FieldOffset(8)]
			public bool Log;
		}

		// Token: 0x0200A63D RID: 42557
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EndSwitchPose_ToSeq_FunctionParams
		{
			// Token: 0x0403252F RID: 206127
			[FieldOffset(0)]
			public IntPtr To;

			// Token: 0x04032530 RID: 206128
			[FieldOffset(8)]
			public bool Log;
		}

		// Token: 0x0200A63E RID: 42558
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __BeginSwitchPose_ToBP_FunctionParams
		{
			// Token: 0x04032531 RID: 206129
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x04032532 RID: 206130
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x04032533 RID: 206131
			[FieldOffset(16)]
			public float SwitchTime;

			// Token: 0x04032534 RID: 206132
			[FieldOffset(20)]
			public bool ErrorLog;
		}

		// Token: 0x0200A63F RID: 42559
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __Begin_Switch_Pose_to_Seq_FunctionParams
		{
			// Token: 0x04032535 RID: 206133
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x04032536 RID: 206134
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x04032537 RID: 206135
			[FieldOffset(16)]
			public float SwitchTime;

			// Token: 0x04032538 RID: 206136
			[FieldOffset(20)]
			public bool ErrorLog;
		}

		// Token: 0x0200A640 RID: 42560
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ChangeHuluState_FunctionParams
		{
			// Token: 0x04032539 RID: 206137
			[FieldOffset(0)]
			public int State;
		}

		// Token: 0x0200A641 RID: 42561
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SwitchMeshTransform_FunctionParams
		{
			// Token: 0x0403253A RID: 206138
			[FieldOffset(0)]
			public bool LevelA;
		}

		// Token: 0x0200A642 RID: 42562
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __EndSwitchPose_FunctionParams
		{
			// Token: 0x0403253B RID: 206139
			[FieldOffset(0)]
			public IntPtr To;

			// Token: 0x0403253C RID: 206140
			[FieldOffset(8)]
			public bool Log;
		}

		// Token: 0x0200A643 RID: 42563
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __BeginSwitchPose_FunctionParams
		{
			// Token: 0x0403253D RID: 206141
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x0403253E RID: 206142
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x0403253F RID: 206143
			[FieldOffset(16)]
			public float SwitchTime;

			// Token: 0x04032540 RID: 206144
			[FieldOffset(20)]
			public bool ErrorLog;
		}

		// Token: 0x0200A644 RID: 42564
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BeginSeqSwitchPose_FunctionParams
		{
			// Token: 0x04032541 RID: 206145
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x04032542 RID: 206146
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x04032543 RID: 206147
			[FieldOffset(16)]
			public float SwitchTime;
		}

		// Token: 0x0200A645 RID: 42565
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EndSeqSwitchPose_FunctionParams
		{
			// Token: 0x04032544 RID: 206148
			[FieldOffset(0)]
			public IntPtr To;
		}

		// Token: 0x0200A646 RID: 42566
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplySeqCostumeState_FunctionParams
		{
			// Token: 0x04032545 RID: 206149
			[FieldOffset(0)]
			public int State;
		}
	}
}
