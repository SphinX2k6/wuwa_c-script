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
	// Token: 0x020032DB RID: 13019
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/BP_BaseRole_Seq_V2.BP_BaseRole_Seq_V2_C")]
	[UnrealStructLayout(1392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1392)]
	public class BP_BaseRole_Seq_V2_C : APawn, IUnrealUObject, IUnrealObject, IBPI_SeqAudio_C, IUnrealBlueprintInterface, IUnrealInterface, IBPI_SeqBindingActor_C, IBPI_SeqBlendActor_C, IBPI_SeqTalkActor_C, IBPI_SeqCostumeState_C, IBPI_SeqRoleMesh_C
	{
		// Token: 0x0602104B RID: 135243 RVA: 0x00956848 File Offset: 0x00954A48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseRole_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseSeqCharacter/BP_BaseRole_Seq_V2.BP_BaseRole_Seq_V2_C");
			}
			return BP_BaseRole_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602104C RID: 135244 RVA: 0x0095686C File Offset: 0x00954A6C
		public BP_BaseRole_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseRole_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602104D RID: 135245 RVA: 0x00956894 File Offset: 0x00954A94
		[NullableContext(1)]
		public BP_BaseRole_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseRole_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x0602104E RID: 135246 RVA: 0x009568C7 File Offset: 0x00954AC7
		// (set) Token: 0x0602104F RID: 135247 RVA: 0x009568DB File Offset: 0x00954ADB
		public unsafe SeqAudio_Seq_V2_C SeqAudio_Seq_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<SeqAudio_Seq_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_SeqAudio_Seq_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_SeqAudio_Seq_V2, value);
			}
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x06021050 RID: 135248 RVA: 0x009568F0 File Offset: 0x00954AF0
		// (set) Token: 0x06021051 RID: 135249 RVA: 0x00956904 File Offset: 0x00954B04
		public unsafe UChildActorComponent Hulu
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_Hulu);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_Hulu, value);
			}
		}

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x06021052 RID: 135250 RVA: 0x00956919 File Offset: 0x00954B19
		// (set) Token: 0x06021053 RID: 135251 RVA: 0x0095692D File Offset: 0x00954B2D
		public unsafe ABPC_Seq_Body_V2_C ABPC_Body_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABPC_Seq_Body_V2_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_ABPC_Body_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_ABPC_Body_V2, value);
			}
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x06021054 RID: 135252 RVA: 0x00956942 File Offset: 0x00954B42
		// (set) Token: 0x06021055 RID: 135253 RVA: 0x00956956 File Offset: 0x00954B56
		public unsafe USkeletalMeshComponent SkeletalMeshComponent0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_SkeletalMeshComponent0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_SkeletalMeshComponent0, value);
			}
		}

		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x06021056 RID: 135254 RVA: 0x0095696B File Offset: 0x00954B6B
		// (set) Token: 0x06021057 RID: 135255 RVA: 0x0095697F File Offset: 0x00954B7F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x06021058 RID: 135256 RVA: 0x00956994 File Offset: 0x00954B94
		// (set) Token: 0x06021059 RID: 135257 RVA: 0x009569A4 File Offset: 0x00954BA4
		public unsafe int TalkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_TalkID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_TalkID) = value;
			}
		}

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x0602105A RID: 135258 RVA: 0x009569B5 File Offset: 0x00954BB5
		// (set) Token: 0x0602105B RID: 135259 RVA: 0x009569C9 File Offset: 0x00954BC9
		public unsafe FName BindingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_BindingTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_BindingTag) = value;
			}
		}

		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x0602105C RID: 135260 RVA: 0x009569DE File Offset: 0x00954BDE
		// (set) Token: 0x0602105D RID: 135261 RVA: 0x009569EE File Offset: 0x00954BEE
		public unsafe float HuluFX_Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_HuluFX_Handle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_HuluFX_Handle) = value;
			}
		}

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x0602105E RID: 135262 RVA: 0x009569FF File Offset: 0x00954BFF
		// (set) Token: 0x0602105F RID: 135263 RVA: 0x00956A0F File Offset: 0x00954C0F
		public unsafe float CharFX_Group_Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_CharFX_Group_Handle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_CharFX_Group_Handle) = value;
			}
		}

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x06021060 RID: 135264 RVA: 0x00956A20 File Offset: 0x00954C20
		// (set) Token: 0x06021061 RID: 135265 RVA: 0x00956A30 File Offset: 0x00954C30
		public unsafe float CharFX_Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_CharFX_Handle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_CharFX_Handle) = value;
			}
		}

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x06021062 RID: 135266 RVA: 0x00956A41 File Offset: 0x00954C41
		// (set) Token: 0x06021063 RID: 135267 RVA: 0x00956A55 File Offset: 0x00954C55
		public unsafe PD_CharacterControllerDataGroup_C DataGroup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_DataGroup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_DataGroup, value);
			}
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x06021064 RID: 135268 RVA: 0x00956A6A File Offset: 0x00954C6A
		// (set) Token: 0x06021065 RID: 135269 RVA: 0x00956A7E File Offset: 0x00954C7E
		public unsafe PD_CharacterControllerData_C Data
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_Data);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_Data, value);
			}
		}

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x06021066 RID: 135270 RVA: 0x00956A93 File Offset: 0x00954C93
		// (set) Token: 0x06021067 RID: 135271 RVA: 0x00956AA7 File Offset: 0x00954CA7
		public unsafe BP_Fx_Scanning_C BPScanning
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Fx_Scanning_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_BPScanning);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_BPScanning, value);
			}
		}

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x06021068 RID: 135272 RVA: 0x00956ABC File Offset: 0x00954CBC
		// (set) Token: 0x06021069 RID: 135273 RVA: 0x00956AD0 File Offset: 0x00954CD0
		public unsafe CharRenderingComponent CharRenderingComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<CharRenderingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_CharRenderingComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseRole_Seq_V2_C.__PropertyOffset_CharRenderingComponent, value);
			}
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x0602106A RID: 135274 RVA: 0x00956AE5 File Offset: 0x00954CE5
		// (set) Token: 0x0602106B RID: 135275 RVA: 0x00956AF5 File Offset: 0x00954CF5
		public unsafe int TalkID_SP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_TalkID_SP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_TalkID_SP) = value;
			}
		}

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x0602106C RID: 135276 RVA: 0x00956B06 File Offset: 0x00954D06
		// (set) Token: 0x0602106D RID: 135277 RVA: 0x00956B16 File Offset: 0x00954D16
		public unsafe bool EnableKeyLightChan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_EnableKeyLightChan) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_EnableKeyLightChan) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x0602106E RID: 135278 RVA: 0x00956B27 File Offset: 0x00954D27
		// (set) Token: 0x0602106F RID: 135279 RVA: 0x00956B37 File Offset: 0x00954D37
		public unsafe bool ToonLightChan0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_ToonLightChan0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_ToonLightChan0) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x06021070 RID: 135280 RVA: 0x00956B48 File Offset: 0x00954D48
		// (set) Token: 0x06021071 RID: 135281 RVA: 0x00956B58 File Offset: 0x00954D58
		public unsafe bool ToonLightChan1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_ToonLightChan1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_ToonLightChan1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x06021072 RID: 135282 RVA: 0x00956B69 File Offset: 0x00954D69
		// (set) Token: 0x06021073 RID: 135283 RVA: 0x00956B79 File Offset: 0x00954D79
		public unsafe bool ToonLightChan2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_ToonLightChan2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_ToonLightChan2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x06021074 RID: 135284 RVA: 0x00956B8C File Offset: 0x00954D8C
		// (set) Token: 0x06021075 RID: 135285 RVA: 0x00956BC5 File Offset: 0x00954DC5
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
					result = (this._CustomData = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_CustomData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x06021076 RID: 135286 RVA: 0x00956BD3 File Offset: 0x00954DD3
		// (set) Token: 0x06021077 RID: 135287 RVA: 0x00956BE8 File Offset: 0x00954DE8
		[Nullable(1)]
		public TSoftObjectPtr<USkeletalMesh> MeshRef
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_MeshRef, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_BaseRole_Seq_V2_C.__PropertyOffset_MeshRef, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021078 RID: 135288 RVA: 0x00956C10 File Offset: 0x00954E10
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x06021079 RID: 135289 RVA: 0x00956C9C File Offset: 0x00954E9C
		[SkipLocalsInit]
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

		// Token: 0x0602107A RID: 135290 RVA: 0x00956CFC File Offset: 0x00954EFC
		[SkipLocalsInit]
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

		// Token: 0x0602107B RID: 135291 RVA: 0x00956D60 File Offset: 0x00954F60
		[SkipLocalsInit]
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

		// Token: 0x0602107C RID: 135292 RVA: 0x00956DC4 File Offset: 0x00954FC4
		[SkipLocalsInit]
		public unsafe virtual void GetSeqBindingTag(ref FName Tag)
		{
			BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSeqBindingTag_NativeFunctionPtr, (void*)ptr);
			Tag = ptr->Tag;
		}

		// Token: 0x0602107D RID: 135293 RVA: 0x00956E1C File Offset: 0x0095501C
		[SkipLocalsInit]
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

		// Token: 0x0602107E RID: 135294 RVA: 0x00956E80 File Offset: 0x00955080
		[SkipLocalsInit]
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

		// Token: 0x0602107F RID: 135295 RVA: 0x00956F00 File Offset: 0x00955100
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06021080 RID: 135296 RVA: 0x00956F80 File Offset: 0x00955180
		[SkipLocalsInit]
		public unsafe virtual bool IsCustomSupport()
		{
			BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021081 RID: 135297 RVA: 0x00956FC8 File Offset: 0x009551C8
		[SkipLocalsInit]
		protected unsafe virtual bool IsCustomSupport_Implementation()
		{
			BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021082 RID: 135298 RVA: 0x00957010 File Offset: 0x00955210
		[SkipLocalsInit]
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

		// Token: 0x06021083 RID: 135299 RVA: 0x00957090 File Offset: 0x00955290
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06021084 RID: 135300 RVA: 0x00957110 File Offset: 0x00955310
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual TArray<FName> GetSupportGroupNames()
		{
			BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06021085 RID: 135301 RVA: 0x00957170 File Offset: 0x00955370
		[NullableContext(1)]
		[SkipLocalsInit]
		protected unsafe virtual TArray<FName> GetSupportGroupNames_Implementation()
		{
			BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06021086 RID: 135302 RVA: 0x009571D0 File Offset: 0x009553D0
		[SkipLocalsInit]
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

		// Token: 0x06021087 RID: 135303 RVA: 0x00957250 File Offset: 0x00955450
		[SkipLocalsInit]
		protected unsafe virtual bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06021088 RID: 135304 RVA: 0x009572D0 File Offset: 0x009554D0
		[SkipLocalsInit]
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

		// Token: 0x06021089 RID: 135305 RVA: 0x00957350 File Offset: 0x00955550
		[SkipLocalsInit]
		protected unsafe virtual bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_BaseRole_Seq_V2_C.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602108A RID: 135306 RVA: 0x009573D0 File Offset: 0x009555D0
		[SkipLocalsInit]
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

		// Token: 0x0602108B RID: 135307 RVA: 0x00957434 File Offset: 0x00955634
		[SkipLocalsInit]
		public virtual void LightChanel()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__LightChanel_NativeFunctionPtr, null);
		}

		// Token: 0x0602108C RID: 135308 RVA: 0x00957448 File Offset: 0x00955648
		[SkipLocalsInit]
		public unsafe virtual void EndSwitchPose_ToBP(AActor To, bool Log)
		{
			BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->Log = Log;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToBP_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602108D RID: 135309 RVA: 0x009574A4 File Offset: 0x009556A4
		[SkipLocalsInit]
		public unsafe virtual void EndSwitchPose_ToSeq(AActor To, bool Log)
		{
			BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->Log = Log;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__EndSwitchPose_ToSeq_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602108E RID: 135310 RVA: 0x00957500 File Offset: 0x00955700
		[SkipLocalsInit]
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

		// Token: 0x0602108F RID: 135311 RVA: 0x00957580 File Offset: 0x00955780
		[SkipLocalsInit]
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

		// Token: 0x06021090 RID: 135312 RVA: 0x009575FD File Offset: 0x009557FD
		[SkipLocalsInit]
		public virtual void 添加扫描效果()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__添加扫描效果_NativeFunctionPtr, null);
		}

		// Token: 0x06021091 RID: 135313 RVA: 0x00957611 File Offset: 0x00955811
		[SkipLocalsInit]
		public virtual void 卸载角色材质控制器()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__卸载角色材质控制器_NativeFunctionPtr, null);
		}

		// Token: 0x06021092 RID: 135314 RVA: 0x00957625 File Offset: 0x00955825
		[SkipLocalsInit]
		public virtual void 添加角色材质控制器()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__添加角色材质控制器_NativeFunctionPtr, null);
		}

		// Token: 0x06021093 RID: 135315 RVA: 0x00957639 File Offset: 0x00955839
		[SkipLocalsInit]
		public virtual void 卸载角色材质控制器组()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__卸载角色材质控制器组_NativeFunctionPtr, null);
		}

		// Token: 0x06021094 RID: 135316 RVA: 0x0095764D File Offset: 0x0095584D
		[SkipLocalsInit]
		public virtual void 添加角色材质控制器组()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__添加角色材质控制器组_NativeFunctionPtr, null);
		}

		// Token: 0x06021095 RID: 135317 RVA: 0x00957661 File Offset: 0x00955861
		[SkipLocalsInit]
		public virtual void CleanHuluState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__CleanHuluState_NativeFunctionPtr, null);
		}

		// Token: 0x06021096 RID: 135318 RVA: 0x00957678 File Offset: 0x00955878
		[SkipLocalsInit]
		public unsafe virtual void ChangeHuluState(int State)
		{
			BP_BaseRole_Seq_V2_C.__ChangeHuluState_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__ChangeHuluState_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__ChangeHuluState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__ChangeHuluState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ChangeHuluState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021097 RID: 135319 RVA: 0x009576C0 File Offset: 0x009558C0
		[SkipLocalsInit]
		public unsafe virtual void SwitchMeshTransform(bool LevelA)
		{
			BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LevelA = LevelA;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__SwitchMeshTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021098 RID: 135320 RVA: 0x00957708 File Offset: 0x00955908
		[SkipLocalsInit]
		public unsafe virtual void EndSwitchPose(AActor To, bool Log)
		{
			BP_BaseRole_Seq_V2_C.__EndSwitchPose_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__EndSwitchPose_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__EndSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__EndSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->Log = Log;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__EndSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021099 RID: 135321 RVA: 0x00957764 File Offset: 0x00955964
		[SkipLocalsInit]
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

		// Token: 0x0602109A RID: 135322 RVA: 0x009577DE File Offset: 0x009559DE
		[SkipLocalsInit]
		public virtual void JumpFrame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__JumpFrame_NativeFunctionPtr, null);
		}

		// Token: 0x0602109B RID: 135323 RVA: 0x009577F2 File Offset: 0x009559F2
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602109C RID: 135324 RVA: 0x00957806 File Offset: 0x00955A06
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602109D RID: 135325 RVA: 0x0095781A File Offset: 0x00955A1A
		[SkipLocalsInit]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0602109E RID: 135326 RVA: 0x0095782E File Offset: 0x00955A2E
		[SkipLocalsInit]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0602109F RID: 135327 RVA: 0x00957844 File Offset: 0x00955A44
		[SkipLocalsInit]
		public unsafe virtual void BeginSeqSwitchPose(AActor From, AActor To, float SwitchTime)
		{
			BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->SwitchTime = SwitchTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__BeginSeqSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210A0 RID: 135328 RVA: 0x009578B8 File Offset: 0x00955AB8
		[SkipLocalsInit]
		public unsafe virtual void EndSeqSwitchPose(AActor To)
		{
			BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__EndSeqSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210A1 RID: 135329 RVA: 0x00957910 File Offset: 0x00955B10
		[SkipLocalsInit]
		public unsafe virtual void ApplySeqCostumeState(int State)
		{
			BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_FunctionParams* ptr = stackalloc BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ApplySeqCostumeState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210A2 RID: 135330 RVA: 0x00957956 File Offset: 0x00955B56
		[SkipLocalsInit]
		public virtual void ClearSeqCostumeState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseRole_Seq_V2_C.__ClearSeqCostumeState_NativeFunctionPtr, null);
		}

		// Token: 0x060210A3 RID: 135331 RVA: 0x0095796A File Offset: 0x00955B6A
		protected BP_BaseRole_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E92 RID: 73362
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/BP_BaseRole_Seq_V2.BP_BaseRole_Seq_V2_C";

		// Token: 0x04011E93 RID: 73363
		private static IntPtr _ClassPtr;

		// Token: 0x04011E94 RID: 73364
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E95 RID: 73365
		internal static int __PropertyOffset_SeqAudio_Seq_V2;

		// Token: 0x04011E96 RID: 73366
		internal static int __PropertyOffset_Hulu;

		// Token: 0x04011E97 RID: 73367
		internal static int __PropertyOffset_ABPC_Body_V2;

		// Token: 0x04011E98 RID: 73368
		internal static int __PropertyOffset_SkeletalMeshComponent0;

		// Token: 0x04011E99 RID: 73369
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04011E9A RID: 73370
		internal static int __PropertyOffset_TalkID;

		// Token: 0x04011E9B RID: 73371
		internal static int __PropertyOffset_BindingTag;

		// Token: 0x04011E9C RID: 73372
		internal static int __PropertyOffset_HuluFX_Handle;

		// Token: 0x04011E9D RID: 73373
		internal static int __PropertyOffset_CharFX_Group_Handle;

		// Token: 0x04011E9E RID: 73374
		internal static int __PropertyOffset_CharFX_Handle;

		// Token: 0x04011E9F RID: 73375
		internal static int __PropertyOffset_DataGroup;

		// Token: 0x04011EA0 RID: 73376
		internal static int __PropertyOffset_Data;

		// Token: 0x04011EA1 RID: 73377
		internal static int __PropertyOffset_BPScanning;

		// Token: 0x04011EA2 RID: 73378
		internal static int __PropertyOffset_CharRenderingComponent;

		// Token: 0x04011EA3 RID: 73379
		internal static int __PropertyOffset_TalkID_SP;

		// Token: 0x04011EA4 RID: 73380
		internal static int __PropertyOffset_EnableKeyLightChan;

		// Token: 0x04011EA5 RID: 73381
		internal static int __PropertyOffset_ToonLightChan0;

		// Token: 0x04011EA6 RID: 73382
		internal static int __PropertyOffset_ToonLightChan1;

		// Token: 0x04011EA7 RID: 73383
		internal static int __PropertyOffset_ToonLightChan2;

		// Token: 0x04011EA8 RID: 73384
		internal static int __PropertyOffset_CustomData;

		// Token: 0x04011EA9 RID: 73385
		private TMap<FName, FTransform> _CustomData;

		// Token: 0x04011EAA RID: 73386
		internal static int __PropertyOffset_MeshRef;

		// Token: 0x04011EAB RID: 73387
		private static IntPtr __GetSeqMeshRef_NativeFunctionPtr;

		// Token: 0x04011EAC RID: 73388
		private static IntPtr __GetSeqTalkId_NativeFunctionPtr;

		// Token: 0x04011EAD RID: 73389
		private static IntPtr __GetSeqMouthAnimInstance_NativeFunctionPtr;

		// Token: 0x04011EAE RID: 73390
		private static IntPtr __GetSeqBlendMesh_NativeFunctionPtr;

		// Token: 0x04011EAF RID: 73391
		private static IntPtr __GetSeqBindingTag_NativeFunctionPtr;

		// Token: 0x04011EB0 RID: 73392
		private static IntPtr __GetSeqAudio_NativeFunctionPtr;

		// Token: 0x04011EB1 RID: 73393
		private static IntPtr __GetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x04011EB2 RID: 73394
		private static IntPtr __IsCustomSupport_NativeFunctionPtr;

		// Token: 0x04011EB3 RID: 73395
		private static IntPtr __SetAnimDataTransform_NativeFunctionPtr;

		// Token: 0x04011EB4 RID: 73396
		private static IntPtr __GetSupportGroupNames_NativeFunctionPtr;

		// Token: 0x04011EB5 RID: 73397
		private static IntPtr __GetAnimDataVector_NativeFunctionPtr;

		// Token: 0x04011EB6 RID: 73398
		private static IntPtr __SetAnimDataVector_NativeFunctionPtr;

		// Token: 0x04011EB7 RID: 73399
		private static IntPtr __GetABPC_Body_V2_NativeFunctionPtr;

		// Token: 0x04011EB8 RID: 73400
		private static IntPtr __LightChanel_NativeFunctionPtr;

		// Token: 0x04011EB9 RID: 73401
		private static IntPtr __EndSwitchPose_ToBP_NativeFunctionPtr;

		// Token: 0x04011EBA RID: 73402
		private static IntPtr __EndSwitchPose_ToSeq_NativeFunctionPtr;

		// Token: 0x04011EBB RID: 73403
		private static IntPtr __BeginSwitchPose_ToBP_NativeFunctionPtr;

		// Token: 0x04011EBC RID: 73404
		private static IntPtr __Begin_Switch_Pose_to_Seq_NativeFunctionPtr;

		// Token: 0x04011EBD RID: 73405
		private static IntPtr __添加扫描效果_NativeFunctionPtr;

		// Token: 0x04011EBE RID: 73406
		private static IntPtr __卸载角色材质控制器_NativeFunctionPtr;

		// Token: 0x04011EBF RID: 73407
		private static IntPtr __添加角色材质控制器_NativeFunctionPtr;

		// Token: 0x04011EC0 RID: 73408
		private static IntPtr __卸载角色材质控制器组_NativeFunctionPtr;

		// Token: 0x04011EC1 RID: 73409
		private static IntPtr __添加角色材质控制器组_NativeFunctionPtr;

		// Token: 0x04011EC2 RID: 73410
		private static IntPtr __CleanHuluState_NativeFunctionPtr;

		// Token: 0x04011EC3 RID: 73411
		private static IntPtr __ChangeHuluState_NativeFunctionPtr;

		// Token: 0x04011EC4 RID: 73412
		private static IntPtr __SwitchMeshTransform_NativeFunctionPtr;

		// Token: 0x04011EC5 RID: 73413
		private static IntPtr __EndSwitchPose_NativeFunctionPtr;

		// Token: 0x04011EC6 RID: 73414
		private static IntPtr __BeginSwitchPose_NativeFunctionPtr;

		// Token: 0x04011EC7 RID: 73415
		private static IntPtr __JumpFrame_NativeFunctionPtr;

		// Token: 0x04011EC8 RID: 73416
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011EC9 RID: 73417
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04011ECA RID: 73418
		private static IntPtr __BeginSeqSwitchPose_NativeFunctionPtr;

		// Token: 0x04011ECB RID: 73419
		private static IntPtr __EndSeqSwitchPose_NativeFunctionPtr;

		// Token: 0x04011ECC RID: 73420
		private static IntPtr __ApplySeqCostumeState_NativeFunctionPtr;

		// Token: 0x04011ECD RID: 73421
		private static IntPtr __ClearSeqCostumeState_NativeFunctionPtr;

		// Token: 0x02009062 RID: 36962
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSeqMeshRef_FunctionParams
		{
			// Token: 0x0402CE62 RID: 183906
			[FieldOffset(0)]
			public byte MeshRef;
		}

		// Token: 0x02009063 RID: 36963
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqTalkId_FunctionParams
		{
			// Token: 0x0402CE63 RID: 183907
			[FieldOffset(0)]
			public int TalkID;

			// Token: 0x0402CE64 RID: 183908
			[FieldOffset(4)]
			public int TalkID_SP;
		}

		// Token: 0x02009064 RID: 36964
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSeqMouthAnimInstance_FunctionParams
		{
			// Token: 0x0402CE65 RID: 183909
			[FieldOffset(0)]
			public IntPtr AnimInstance;
		}

		// Token: 0x02009065 RID: 36965
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqBlendMesh_FunctionParams
		{
			// Token: 0x0402CE66 RID: 183910
			[FieldOffset(0)]
			public IntPtr Mesh;
		}

		// Token: 0x02009066 RID: 36966
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetSeqBindingTag_FunctionParams
		{
			// Token: 0x0402CE67 RID: 183911
			[FieldOffset(0)]
			public FName Tag;
		}

		// Token: 0x02009067 RID: 36967
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqAudio_FunctionParams
		{
			// Token: 0x0402CE68 RID: 183912
			[FieldOffset(0)]
			public IntPtr SeqAudio;
		}

		// Token: 0x02009068 RID: 36968
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402CE69 RID: 183913
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402CE6A RID: 183914
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02009069 RID: 36969
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x0402CE6B RID: 183915
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200906A RID: 36970
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x0402CE6C RID: 183916
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x0402CE6D RID: 183917
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x0200906B RID: 36971
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x0402CE6E RID: 183918
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200906C RID: 36972
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x0402CE6F RID: 183919
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402CE70 RID: 183920
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x0200906D RID: 36973
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x0402CE71 RID: 183921
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x0402CE72 RID: 183922
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x0200906E RID: 36974
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetABPC_Body_V2_FunctionParams
		{
			// Token: 0x0402CE73 RID: 183923
			[FieldOffset(0)]
			public IntPtr ABPC_Body_V2;
		}

		// Token: 0x0200906F RID: 36975
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __EndSwitchPose_ToBP_FunctionParams
		{
			// Token: 0x0402CE74 RID: 183924
			[FieldOffset(0)]
			public IntPtr To;

			// Token: 0x0402CE75 RID: 183925
			[FieldOffset(8)]
			public bool Log;
		}

		// Token: 0x02009070 RID: 36976
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EndSwitchPose_ToSeq_FunctionParams
		{
			// Token: 0x0402CE76 RID: 183926
			[FieldOffset(0)]
			public IntPtr To;

			// Token: 0x0402CE77 RID: 183927
			[FieldOffset(8)]
			public bool Log;
		}

		// Token: 0x02009071 RID: 36977
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __BeginSwitchPose_ToBP_FunctionParams
		{
			// Token: 0x0402CE78 RID: 183928
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x0402CE79 RID: 183929
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x0402CE7A RID: 183930
			[FieldOffset(16)]
			public float SwitchTime;

			// Token: 0x0402CE7B RID: 183931
			[FieldOffset(20)]
			public bool ErrorLog;
		}

		// Token: 0x02009072 RID: 36978
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __Begin_Switch_Pose_to_Seq_FunctionParams
		{
			// Token: 0x0402CE7C RID: 183932
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x0402CE7D RID: 183933
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x0402CE7E RID: 183934
			[FieldOffset(16)]
			public float SwitchTime;

			// Token: 0x0402CE7F RID: 183935
			[FieldOffset(20)]
			public bool ErrorLog;
		}

		// Token: 0x02009073 RID: 36979
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ChangeHuluState_FunctionParams
		{
			// Token: 0x0402CE80 RID: 183936
			[FieldOffset(0)]
			public int State;
		}

		// Token: 0x02009074 RID: 36980
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SwitchMeshTransform_FunctionParams
		{
			// Token: 0x0402CE81 RID: 183937
			[FieldOffset(0)]
			public bool LevelA;
		}

		// Token: 0x02009075 RID: 36981
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __EndSwitchPose_FunctionParams
		{
			// Token: 0x0402CE82 RID: 183938
			[FieldOffset(0)]
			public IntPtr To;

			// Token: 0x0402CE83 RID: 183939
			[FieldOffset(8)]
			public bool Log;
		}

		// Token: 0x02009076 RID: 36982
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __BeginSwitchPose_FunctionParams
		{
			// Token: 0x0402CE84 RID: 183940
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x0402CE85 RID: 183941
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x0402CE86 RID: 183942
			[FieldOffset(16)]
			public float SwitchTime;

			// Token: 0x0402CE87 RID: 183943
			[FieldOffset(20)]
			public bool ErrorLog;
		}

		// Token: 0x02009077 RID: 36983
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BeginSeqSwitchPose_FunctionParams
		{
			// Token: 0x0402CE88 RID: 183944
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x0402CE89 RID: 183945
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x0402CE8A RID: 183946
			[FieldOffset(16)]
			public float SwitchTime;
		}

		// Token: 0x02009078 RID: 36984
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EndSeqSwitchPose_FunctionParams
		{
			// Token: 0x0402CE8B RID: 183947
			[FieldOffset(0)]
			public IntPtr To;
		}

		// Token: 0x02009079 RID: 36985
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplySeqCostumeState_FunctionParams
		{
			// Token: 0x0402CE8C RID: 183948
			[FieldOffset(0)]
			public int State;
		}
	}
}
