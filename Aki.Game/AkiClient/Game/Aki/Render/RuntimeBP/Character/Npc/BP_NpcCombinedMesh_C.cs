using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x0200311B RID: 12571
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/BP_NpcCombinedMesh.BP_NpcCombinedMesh_C")]
	[UnrealStructLayout(1776, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1769)]
	public class BP_NpcCombinedMesh_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ECE0 RID: 126176 RVA: 0x0091DBC7 File Offset: 0x0091BDC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NpcCombinedMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/BP_NpcCombinedMesh.BP_NpcCombinedMesh_C");
			}
			return BP_NpcCombinedMesh_C._ClassPtr;
		}

		// Token: 0x0601ECE1 RID: 126177 RVA: 0x0091DBEC File Offset: 0x0091BDEC
		public BP_NpcCombinedMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_NpcCombinedMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ECE2 RID: 126178 RVA: 0x0091DC14 File Offset: 0x0091BE14
		[NullableContext(1)]
		public BP_NpcCombinedMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NpcCombinedMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0601ECE3 RID: 126179 RVA: 0x0091DC47 File Offset: 0x0091BE47
		// (set) Token: 0x0601ECE4 RID: 126180 RVA: 0x0091DC5B File Offset: 0x0091BE5B
		[Nullable(2)]
		public unsafe USkeletalMeshComponent Skel_Main
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_Skel_Main);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_Skel_Main, value);
			}
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0601ECE5 RID: 126181 RVA: 0x0091DC70 File Offset: 0x0091BE70
		// (set) Token: 0x0601ECE6 RID: 126182 RVA: 0x0091DC84 File Offset: 0x0091BE84
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0601ECE7 RID: 126183 RVA: 0x0091DC99 File Offset: 0x0091BE99
		// (set) Token: 0x0601ECE8 RID: 126184 RVA: 0x0091DCAD File Offset: 0x0091BEAD
		[Nullable(2)]
		public unsafe PD_NpcSetupData_C NpcData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_NpcSetupData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_NpcData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_NpcData, value);
			}
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0601ECE9 RID: 126185 RVA: 0x0091DCC2 File Offset: 0x0091BEC2
		// (set) Token: 0x0601ECEA RID: 126186 RVA: 0x0091DCD2 File Offset: 0x0091BED2
		public unsafe bool OriginalSkeletalVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_OriginalSkeletalVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_OriginalSkeletalVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0601ECEB RID: 126187 RVA: 0x0091DCE4 File Offset: 0x0091BEE4
		// (set) Token: 0x0601ECEC RID: 126188 RVA: 0x0091DD1D File Offset: 0x0091BF1D
		[Nullable(1)]
		public TMap<FName, SNpcSetupPartInfo> AllSubSkeletalComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, SNpcSetupPartInfo> result;
				if ((result = this._AllSubSkeletalComponents) == null)
				{
					result = (this._AllSubSkeletalComponents = new TMap<FName, SNpcSetupPartInfo>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_AllSubSkeletalComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AllSubSkeletalComponents.CopyAssign(value);
			}
		}

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0601ECED RID: 126189 RVA: 0x0091DD2B File Offset: 0x0091BF2B
		// (set) Token: 0x0601ECEE RID: 126190 RVA: 0x0091DD3F File Offset: 0x0091BF3F
		[Nullable(2)]
		public unsafe BP_NpcCombinedMesh_C Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_NpcCombinedMesh_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_Target);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0601ECEF RID: 126191 RVA: 0x0091DD54 File Offset: 0x0091BF54
		// (set) Token: 0x0601ECF0 RID: 126192 RVA: 0x0091DD8D File Offset: 0x0091BF8D
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<FName, TEnumAsByte<EBodyPartName>> AllBodyPartName
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, TEnumAsByte<EBodyPartName>> result;
				if ((result = this._AllBodyPartName) == null)
				{
					result = (this._AllBodyPartName = new TMap<FName, TEnumAsByte<EBodyPartName>>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_AllBodyPartName, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.AllBodyPartName.CopyAssign(value);
			}
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0601ECF1 RID: 126193 RVA: 0x0091DD9B File Offset: 0x0091BF9B
		// (set) Token: 0x0601ECF2 RID: 126194 RVA: 0x0091DDAF File Offset: 0x0091BFAF
		public unsafe FLinearColor ColorNPC01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_ColorNPC01);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_ColorNPC01) = value;
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0601ECF3 RID: 126195 RVA: 0x0091DDC4 File Offset: 0x0091BFC4
		// (set) Token: 0x0601ECF4 RID: 126196 RVA: 0x0091DDD8 File Offset: 0x0091BFD8
		public unsafe FLinearColor ColorNPC02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_ColorNPC02);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_ColorNPC02) = value;
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0601ECF5 RID: 126197 RVA: 0x0091DDED File Offset: 0x0091BFED
		// (set) Token: 0x0601ECF6 RID: 126198 RVA: 0x0091DDFD File Offset: 0x0091BFFD
		public unsafe int Forced_LOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_Forced_LOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_Forced_LOD) = value;
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0601ECF7 RID: 126199 RVA: 0x0091DE0E File Offset: 0x0091C00E
		// (set) Token: 0x0601ECF8 RID: 126200 RVA: 0x0091DE22 File Offset: 0x0091C022
		public unsafe FLinearColor SkinColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_SkinColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_SkinColor) = value;
			}
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0601ECF9 RID: 126201 RVA: 0x0091DE38 File Offset: 0x0091C038
		// (set) Token: 0x0601ECFA RID: 126202 RVA: 0x0091DE71 File Offset: 0x0091C071
		[Nullable(1)]
		public TArray<USkeletalMeshComponent> SkelMeshArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshComponent> result;
				if ((result = this._SkelMeshArray) == null)
				{
					result = (this._SkelMeshArray = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_SkelMeshArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkelMeshArray.CopyAssign(value);
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0601ECFB RID: 126203 RVA: 0x0091DE80 File Offset: 0x0091C080
		// (set) Token: 0x0601ECFC RID: 126204 RVA: 0x0091DEB9 File Offset: 0x0091C0B9
		[Nullable(1)]
		public TArray<UMaterialInstance> MINPCs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._MINPCs) == null)
				{
					result = (this._MINPCs = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_MINPCs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MINPCs.CopyAssign(value);
			}
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0601ECFD RID: 126205 RVA: 0x0091DEC7 File Offset: 0x0091C0C7
		// (set) Token: 0x0601ECFE RID: 126206 RVA: 0x0091DED7 File Offset: 0x0091C0D7
		public unsafe bool AdaptMaterialController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_AdaptMaterialController) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_AdaptMaterialController) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0601ECFF RID: 126207 RVA: 0x0091DEE8 File Offset: 0x0091C0E8
		// (set) Token: 0x0601ED00 RID: 126208 RVA: 0x0091DEF8 File Offset: 0x0091C0F8
		public unsafe bool Ticked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_Ticked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_Ticked) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0601ED01 RID: 126209 RVA: 0x0091DF09 File Offset: 0x0091C109
		// (set) Token: 0x0601ED02 RID: 126210 RVA: 0x0091DF19 File Offset: 0x0091C119
		public unsafe bool SkelTickableWhenPaused
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_SkelTickableWhenPaused) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_SkelTickableWhenPaused) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601ED03 RID: 126211 RVA: 0x0091DF2A File Offset: 0x0091C12A
		[SkipLocalsInit]
		public virtual void ApplySkelTickableWhenPaused()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ApplySkelTickableWhenPaused_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED04 RID: 126212 RVA: 0x0091DF40 File Offset: 0x0091C140
		[SkipLocalsInit]
		public unsafe virtual void SetSkelTickableWhenPaused(bool bTickableWhenPaused)
		{
			BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bTickableWhenPaused = bTickableWhenPaused;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ED05 RID: 126213 RVA: 0x0091DF88 File Offset: 0x0091C188
		[SkipLocalsInit]
		public unsafe virtual void SetupCastShadow(bool bIgnoreCastShadow)
		{
			BP_NpcCombinedMesh_C.__SetupCastShadow_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__SetupCastShadow_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__SetupCastShadow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__SetupCastShadow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIgnoreCastShadow = bIgnoreCastShadow;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupCastShadow_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ED06 RID: 126214 RVA: 0x0091DFCE File Offset: 0x0091C1CE
		[SkipLocalsInit]
		public virtual void SetupHiddenBones()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupHiddenBones_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED07 RID: 126215 RVA: 0x0091DFE2 File Offset: 0x0091C1E2
		[SkipLocalsInit]
		public virtual void SetupChildParts()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupChildParts_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED08 RID: 126216 RVA: 0x0091DFF8 File Offset: 0x0091C1F8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void Set_Skeletal_Mesh_Material(UMaterialInterface ReplaceMaterial, USkeletalMeshComponent SkeletalMeshComp, FName ParamName01, FName ParamName02, FName SkinColorName, int NumSlots, int MaterialIndex, EBodyPartName BodyType)
		{
			BP_NpcCombinedMesh_C.__Set_Skeletal_Mesh_Material_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__Set_Skeletal_Mesh_Material_FunctionParams[(UIntPtr)823] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__Set_Skeletal_Mesh_Material_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__Set_Skeletal_Mesh_Material_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ReplaceMaterial = ((ReplaceMaterial != null) ? ReplaceMaterial.NativePtr : IntPtr.Zero);
			ptr->SkeletalMeshComp = ((SkeletalMeshComp != null) ? SkeletalMeshComp.NativePtr : IntPtr.Zero);
			ptr->ParamName01 = ParamName01;
			ptr->ParamName02 = ParamName02;
			ptr->SkinColorName = SkinColorName;
			ptr->NumSlots = NumSlots;
			ptr->MaterialIndex = MaterialIndex;
			ptr->BodyType = BodyType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__Set_Skeletal_Mesh_Material_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ED09 RID: 126217 RVA: 0x0091E09A File Offset: 0x0091C29A
		[SkipLocalsInit]
		public virtual void 预览MorphTarget()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__预览MorphTarget_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED0A RID: 126218 RVA: 0x0091E0B0 File Offset: 0x0091C2B0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void Test(USkeletalMeshComponent SKMesh, UMaterialInstance MI)
		{
			BP_NpcCombinedMesh_C.__Test_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__Test_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__Test_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__Test_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SKMesh = ((SKMesh != null) ? SKMesh.NativePtr : IntPtr.Zero);
			ptr->MI = ((MI != null) ? MI.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__Test_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ED0B RID: 126219 RVA: 0x0091E11C File Offset: 0x0091C31C
		[SkipLocalsInit]
		public unsafe virtual void GetHeadTransform(FTransform InTransform, int Index, ref FTransform OutTransform)
		{
			BP_NpcCombinedMesh_C.__GetHeadTransform_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__GetHeadTransform_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__GetHeadTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__GetHeadTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			ptr->Index = Index;
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__GetHeadTransform_NativeFunctionPtr, (void*)ptr);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0601ED0C RID: 126220 RVA: 0x0091E184 File Offset: 0x0091C384
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void Set_Skeleton_Mesh_DI(USkeletalMeshComponent SKMesh, FName ParamName01, FName ParamName02, EBodyPartName BodyType, FName SkinColorName, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInterface> Materials)
		{
			BP_NpcCombinedMesh_C.__Set_Skeleton_Mesh_DI_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__Set_Skeleton_Mesh_DI_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__Set_Skeleton_Mesh_DI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__Set_Skeleton_Mesh_DI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SKMesh = ((SKMesh != null) ? SKMesh.NativePtr : IntPtr.Zero);
			ptr->ParamName01 = ParamName01;
			ptr->ParamName02 = ParamName02;
			ptr->BodyType = BodyType;
			ptr->SkinColorName = SkinColorName;
			TArray<UMaterialInterface> tarray = Materials;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Materials);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__Set_Skeleton_Mesh_DI_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInterface> tarray2 = Materials;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Materials);
			}
			UnrealReflectionUtils.DestroyStruct(BP_NpcCombinedMesh_C.__Set_Skeleton_Mesh_DI_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601ED0D RID: 126221 RVA: 0x0091E23C File Offset: 0x0091C43C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void AddSkeletalComponent(FName Name, USkeletalMeshComponent SkeletalComp)
		{
			BP_NpcCombinedMesh_C.__AddSkeletalComponent_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__AddSkeletalComponent_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__AddSkeletalComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__AddSkeletalComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Name = Name;
			ptr->SkeletalComp = ((SkeletalComp != null) ? SkeletalComp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__AddSkeletalComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ED0E RID: 126222 RVA: 0x0091E298 File Offset: 0x0091C498
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void Setup_Skeletal_Mesh_Component(USkeletalMesh InSkeletalMesh, EBodyPartName BodyType, int Index, ref bool Suc, ref USkeletalMeshComponent SkeletalComp)
		{
			BP_NpcCombinedMesh_C.__Setup_Skeletal_Mesh_Component_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__Setup_Skeletal_Mesh_Component_FunctionParams[(UIntPtr)623] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__Setup_Skeletal_Mesh_Component_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__Setup_Skeletal_Mesh_Component_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSkeletalMesh = ((InSkeletalMesh != null) ? InSkeletalMesh.NativePtr : IntPtr.Zero);
			ptr->BodyType = BodyType;
			ptr->Index = Index;
			ptr->Suc = Suc;
			ref BP_NpcCombinedMesh_C.__Setup_Skeletal_Mesh_Component_FunctionParams ptr2 = ref *ptr;
			USkeletalMeshComponent uskeletalMeshComponent = SkeletalComp;
			ptr2.SkeletalComp = ((uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__Setup_Skeletal_Mesh_Component_NativeFunctionPtr, (void*)ptr);
			Suc = ptr->Suc;
			SkeletalComp = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ptr->SkeletalComp);
		}

		// Token: 0x0601ED0F RID: 126223 RVA: 0x0091E33C File Offset: 0x0091C53C
		[SkipLocalsInit]
		public unsafe virtual void GetWaistTransform(FTransform InTransform, int Index, ref FTransform OutTransform)
		{
			BP_NpcCombinedMesh_C.__GetWaistTransform_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__GetWaistTransform_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__GetWaistTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__GetWaistTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			ptr->Index = Index;
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__GetWaistTransform_NativeFunctionPtr, (void*)ptr);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0601ED10 RID: 126224 RVA: 0x0091E3A4 File Offset: 0x0091C5A4
		[SkipLocalsInit]
		public unsafe virtual void GetBackTransform(FTransform InTransform, int Index, ref FTransform OutTransform)
		{
			BP_NpcCombinedMesh_C.__GetBackTransform_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__GetBackTransform_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__GetBackTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__GetBackTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			ptr->Index = Index;
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__GetBackTransform_NativeFunctionPtr, (void*)ptr);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0601ED11 RID: 126225 RVA: 0x0091E40C File Offset: 0x0091C60C
		[SkipLocalsInit]
		public unsafe virtual void GetLegTransform(FTransform InTransform, int Index, ref FTransform OutTransform)
		{
			BP_NpcCombinedMesh_C.__GetLegTransform_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__GetLegTransform_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__GetLegTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__GetLegTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			ptr->Index = Index;
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__GetLegTransform_NativeFunctionPtr, (void*)ptr);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0601ED12 RID: 126226 RVA: 0x0091E474 File Offset: 0x0091C674
		[SkipLocalsInit]
		public unsafe virtual void GetWeaponTransform(FTransform InTransform, int Index, ref FTransform OutTransform)
		{
			BP_NpcCombinedMesh_C.__GetWeaponTransform_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__GetWeaponTransform_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__GetWeaponTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__GetWeaponTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			ptr->Index = Index;
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__GetWeaponTransform_NativeFunctionPtr, (void*)ptr);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0601ED13 RID: 126227 RVA: 0x0091E4DC File Offset: 0x0091C6DC
		[SkipLocalsInit]
		public unsafe virtual void GetArmTransform(FTransform InTransform, int Index, ref FTransform OutTransform)
		{
			BP_NpcCombinedMesh_C.__GetArmTransform_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__GetArmTransform_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__GetArmTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__GetArmTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			ptr->Index = Index;
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__GetArmTransform_NativeFunctionPtr, (void*)ptr);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0601ED14 RID: 126228 RVA: 0x0091E544 File Offset: 0x0091C744
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void Setup_Socket(FName SocketName, FTransform Transform, USkeletalMesh SkeletalMesh, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMorphTargetPreviewItem> MorphTargets, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SNpcHookPartMaterial> Materials, int index, ref bool Suc, ref USkeletalMeshComponent SkeletalComp)
		{
			BP_NpcCombinedMesh_C.__Setup_Socket_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__Setup_Socket_FunctionParams[(UIntPtr)607] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__Setup_Socket_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__Setup_Socket_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SocketName = SocketName;
			ptr->Transform = Transform;
			ptr->SkeletalMesh = ((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero);
			TArray<FMorphTargetPreviewItem> tarray = MorphTargets;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->MorphTargets);
			}
			TArray<SNpcHookPartMaterial> tarray2 = Materials;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Materials);
			}
			ptr->index = index;
			ptr->Suc = Suc;
			ref BP_NpcCombinedMesh_C.__Setup_Socket_FunctionParams ptr2 = ref *ptr;
			USkeletalMeshComponent uskeletalMeshComponent = SkeletalComp;
			ptr2.SkeletalComp = ((uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__Setup_Socket_NativeFunctionPtr, (void*)ptr);
			TArray<FMorphTargetPreviewItem> tarray3 = MorphTargets;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->MorphTargets);
			}
			TArray<SNpcHookPartMaterial> tarray4 = Materials;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Materials);
			}
			Suc = ptr->Suc;
			SkeletalComp = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ptr->SkeletalComp);
			UnrealReflectionUtils.DestroyStruct(BP_NpcCombinedMesh_C.__Setup_Socket_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601ED15 RID: 126229 RVA: 0x0091E650 File Offset: 0x0091C850
		[SkipLocalsInit]
		public virtual void SetupSockets()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupSockets_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED16 RID: 126230 RVA: 0x0091E664 File Offset: 0x0091C864
		[SkipLocalsInit]
		public unsafe virtual void SetupSkeletalMeshComponents(ref bool Suc)
		{
			BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Suc = Suc;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_NativeFunctionPtr, (void*)ptr);
			Suc = ptr->Suc;
		}

		// Token: 0x0601ED17 RID: 126231 RVA: 0x0091E6B3 File Offset: 0x0091C8B3
		[SkipLocalsInit]
		public virtual void ResetNpcMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ResetNpcMesh_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED18 RID: 126232 RVA: 0x0091E6C8 File Offset: 0x0091C8C8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void SetupNpcMesh(PD_NpcSetupData_C Data, bool bIgnoreSockets, bool bIgnoreCastShadow, ref bool IsSuc, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USkeletalMeshComponent> SkleMain)
		{
			BP_NpcCombinedMesh_C.__SetupNpcMesh_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__SetupNpcMesh_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__SetupNpcMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__SetupNpcMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->bIgnoreSockets = bIgnoreSockets;
			ptr->bIgnoreCastShadow = bIgnoreCastShadow;
			ptr->IsSuc = IsSuc;
			TArray<USkeletalMeshComponent> tarray = SkleMain;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SkleMain);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupNpcMesh_NativeFunctionPtr, (void*)ptr);
			IsSuc = ptr->IsSuc;
			TArray<USkeletalMeshComponent> tarray2 = SkleMain;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->SkleMain);
			}
			UnrealReflectionUtils.DestroyStruct(BP_NpcCombinedMesh_C.__SetupNpcMesh_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601ED19 RID: 126233 RVA: 0x0091E778 File Offset: 0x0091C978
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED1A RID: 126234 RVA: 0x0091E78C File Offset: 0x0091C98C
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED1B RID: 126235 RVA: 0x0091E7A0 File Offset: 0x0091C9A0
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED1C RID: 126236 RVA: 0x0091E7B4 File Offset: 0x0091C9B4
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601ED1D RID: 126237 RVA: 0x0091E7C8 File Offset: 0x0091C9C8
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ED1E RID: 126238 RVA: 0x0091E810 File Offset: 0x0091CA10
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ED1F RID: 126239 RVA: 0x0091E856 File Offset: 0x0091CA56
		protected BP_NpcCombinedMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040105DE RID: 67038
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/BP_NpcCombinedMesh.BP_NpcCombinedMesh_C";

		// Token: 0x040105DF RID: 67039
		private static IntPtr _ClassPtr;

		// Token: 0x040105E0 RID: 67040
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040105E1 RID: 67041
		internal static int __PropertyOffset_Skel_Main;

		// Token: 0x040105E2 RID: 67042
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040105E3 RID: 67043
		internal static int __PropertyOffset_NpcData;

		// Token: 0x040105E4 RID: 67044
		internal static int __PropertyOffset_OriginalSkeletalVisible;

		// Token: 0x040105E5 RID: 67045
		internal static int __PropertyOffset_AllSubSkeletalComponents;

		// Token: 0x040105E6 RID: 67046
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, SNpcSetupPartInfo> _AllSubSkeletalComponents;

		// Token: 0x040105E7 RID: 67047
		internal static int __PropertyOffset_Target;

		// Token: 0x040105E8 RID: 67048
		internal static int __PropertyOffset_AllBodyPartName;

		// Token: 0x040105E9 RID: 67049
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<FName, TEnumAsByte<EBodyPartName>> _AllBodyPartName;

		// Token: 0x040105EA RID: 67050
		internal static int __PropertyOffset_ColorNPC01;

		// Token: 0x040105EB RID: 67051
		internal static int __PropertyOffset_ColorNPC02;

		// Token: 0x040105EC RID: 67052
		internal static int __PropertyOffset_Forced_LOD;

		// Token: 0x040105ED RID: 67053
		internal static int __PropertyOffset_SkinColor;

		// Token: 0x040105EE RID: 67054
		internal static int __PropertyOffset_SkelMeshArray;

		// Token: 0x040105EF RID: 67055
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _SkelMeshArray;

		// Token: 0x040105F0 RID: 67056
		internal static int __PropertyOffset_MINPCs;

		// Token: 0x040105F1 RID: 67057
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _MINPCs;

		// Token: 0x040105F2 RID: 67058
		internal static int __PropertyOffset_AdaptMaterialController;

		// Token: 0x040105F3 RID: 67059
		internal static int __PropertyOffset_Ticked;

		// Token: 0x040105F4 RID: 67060
		internal static int __PropertyOffset_SkelTickableWhenPaused;

		// Token: 0x040105F5 RID: 67061
		private static IntPtr __ApplySkelTickableWhenPaused_NativeFunctionPtr;

		// Token: 0x040105F6 RID: 67062
		private static IntPtr __SetSkelTickableWhenPaused_NativeFunctionPtr;

		// Token: 0x040105F7 RID: 67063
		private static IntPtr __SetupCastShadow_NativeFunctionPtr;

		// Token: 0x040105F8 RID: 67064
		private static IntPtr __SetupHiddenBones_NativeFunctionPtr;

		// Token: 0x040105F9 RID: 67065
		private static IntPtr __SetupChildParts_NativeFunctionPtr;

		// Token: 0x040105FA RID: 67066
		private static IntPtr __Set_Skeletal_Mesh_Material_NativeFunctionPtr;

		// Token: 0x040105FB RID: 67067
		private static IntPtr __预览MorphTarget_NativeFunctionPtr;

		// Token: 0x040105FC RID: 67068
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x040105FD RID: 67069
		private static IntPtr __GetHeadTransform_NativeFunctionPtr;

		// Token: 0x040105FE RID: 67070
		private static IntPtr __Set_Skeleton_Mesh_DI_NativeFunctionPtr;

		// Token: 0x040105FF RID: 67071
		private static IntPtr __AddSkeletalComponent_NativeFunctionPtr;

		// Token: 0x04010600 RID: 67072
		private static IntPtr __Setup_Skeletal_Mesh_Component_NativeFunctionPtr;

		// Token: 0x04010601 RID: 67073
		private static IntPtr __GetWaistTransform_NativeFunctionPtr;

		// Token: 0x04010602 RID: 67074
		private static IntPtr __GetBackTransform_NativeFunctionPtr;

		// Token: 0x04010603 RID: 67075
		private static IntPtr __GetLegTransform_NativeFunctionPtr;

		// Token: 0x04010604 RID: 67076
		private static IntPtr __GetWeaponTransform_NativeFunctionPtr;

		// Token: 0x04010605 RID: 67077
		private static IntPtr __GetArmTransform_NativeFunctionPtr;

		// Token: 0x04010606 RID: 67078
		private static IntPtr __Setup_Socket_NativeFunctionPtr;

		// Token: 0x04010607 RID: 67079
		private static IntPtr __SetupSockets_NativeFunctionPtr;

		// Token: 0x04010608 RID: 67080
		private static IntPtr __SetupSkeletalMeshComponents_NativeFunctionPtr;

		// Token: 0x04010609 RID: 67081
		private static IntPtr __ResetNpcMesh_NativeFunctionPtr;

		// Token: 0x0401060A RID: 67082
		private static IntPtr __SetupNpcMesh_NativeFunctionPtr;

		// Token: 0x0401060B RID: 67083
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401060C RID: 67084
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401060D RID: 67085
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008ED9 RID: 36569
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetSkelTickableWhenPaused_FunctionParams
		{
			// Token: 0x0402CB96 RID: 183190
			[FieldOffset(0)]
			public bool bTickableWhenPaused;
		}

		// Token: 0x02008EDA RID: 36570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetupCastShadow_FunctionParams
		{
			// Token: 0x0402CB97 RID: 183191
			[FieldOffset(0)]
			public bool bIgnoreCastShadow;
		}

		// Token: 0x02008EDB RID: 36571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 808)]
		protected ref struct __Set_Skeletal_Mesh_Material_FunctionParams
		{
			// Token: 0x0402CB98 RID: 183192
			[FieldOffset(0)]
			public IntPtr ReplaceMaterial;

			// Token: 0x0402CB99 RID: 183193
			[FieldOffset(8)]
			public IntPtr SkeletalMeshComp;

			// Token: 0x0402CB9A RID: 183194
			[FieldOffset(16)]
			public FName ParamName01;

			// Token: 0x0402CB9B RID: 183195
			[FieldOffset(28)]
			public FName ParamName02;

			// Token: 0x0402CB9C RID: 183196
			[FieldOffset(40)]
			public FName SkinColorName;

			// Token: 0x0402CB9D RID: 183197
			[FieldOffset(52)]
			public int NumSlots;

			// Token: 0x0402CB9E RID: 183198
			[FieldOffset(56)]
			public int MaterialIndex;

			// Token: 0x0402CB9F RID: 183199
			[FieldOffset(60)]
			public TEnumAsByte<EBodyPartName> BodyType;
		}

		// Token: 0x02008EDC RID: 36572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Test_FunctionParams
		{
			// Token: 0x0402CBA0 RID: 183200
			[FieldOffset(0)]
			public IntPtr SKMesh;

			// Token: 0x0402CBA1 RID: 183201
			[FieldOffset(8)]
			public IntPtr MI;
		}

		// Token: 0x02008EDD RID: 36573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetHeadTransform_FunctionParams
		{
			// Token: 0x0402CBA2 RID: 183202
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x0402CBA3 RID: 183203
			[FieldOffset(48)]
			public int Index;

			// Token: 0x0402CBA4 RID: 183204
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x02008EDE RID: 36574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __Set_Skeleton_Mesh_DI_FunctionParams
		{
			// Token: 0x0402CBA5 RID: 183205
			[FieldOffset(0)]
			public IntPtr SKMesh;

			// Token: 0x0402CBA6 RID: 183206
			[FieldOffset(8)]
			public FName ParamName01;

			// Token: 0x0402CBA7 RID: 183207
			[FieldOffset(20)]
			public FName ParamName02;

			// Token: 0x0402CBA8 RID: 183208
			[FieldOffset(32)]
			public TEnumAsByte<EBodyPartName> BodyType;

			// Token: 0x0402CBA9 RID: 183209
			[FieldOffset(36)]
			public FName SkinColorName;

			// Token: 0x0402CBAA RID: 183210
			[FieldOffset(48)]
			public byte Materials;
		}

		// Token: 0x02008EDF RID: 36575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __AddSkeletalComponent_FunctionParams
		{
			// Token: 0x0402CBAB RID: 183211
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x0402CBAC RID: 183212
			[FieldOffset(16)]
			public IntPtr SkeletalComp;
		}

		// Token: 0x02008EE0 RID: 36576
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 608)]
		protected ref struct __Setup_Skeletal_Mesh_Component_FunctionParams
		{
			// Token: 0x0402CBAD RID: 183213
			[FieldOffset(0)]
			public IntPtr InSkeletalMesh;

			// Token: 0x0402CBAE RID: 183214
			[FieldOffset(8)]
			public TEnumAsByte<EBodyPartName> BodyType;

			// Token: 0x0402CBAF RID: 183215
			[FieldOffset(12)]
			public int Index;

			// Token: 0x0402CBB0 RID: 183216
			[FieldOffset(16)]
			public bool Suc;

			// Token: 0x0402CBB1 RID: 183217
			[FieldOffset(24)]
			public IntPtr SkeletalComp;
		}

		// Token: 0x02008EE1 RID: 36577
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetWaistTransform_FunctionParams
		{
			// Token: 0x0402CBB2 RID: 183218
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x0402CBB3 RID: 183219
			[FieldOffset(48)]
			public int Index;

			// Token: 0x0402CBB4 RID: 183220
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x02008EE2 RID: 36578
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetBackTransform_FunctionParams
		{
			// Token: 0x0402CBB5 RID: 183221
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x0402CBB6 RID: 183222
			[FieldOffset(48)]
			public int Index;

			// Token: 0x0402CBB7 RID: 183223
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x02008EE3 RID: 36579
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetLegTransform_FunctionParams
		{
			// Token: 0x0402CBB8 RID: 183224
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x0402CBB9 RID: 183225
			[FieldOffset(48)]
			public int Index;

			// Token: 0x0402CBBA RID: 183226
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x02008EE4 RID: 36580
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetWeaponTransform_FunctionParams
		{
			// Token: 0x0402CBBB RID: 183227
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x0402CBBC RID: 183228
			[FieldOffset(48)]
			public int Index;

			// Token: 0x0402CBBD RID: 183229
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x02008EE5 RID: 36581
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetArmTransform_FunctionParams
		{
			// Token: 0x0402CBBE RID: 183230
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x0402CBBF RID: 183231
			[FieldOffset(48)]
			public int Index;

			// Token: 0x0402CBC0 RID: 183232
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x02008EE6 RID: 36582
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 592)]
		protected ref struct __Setup_Socket_FunctionParams
		{
			// Token: 0x0402CBC1 RID: 183233
			[FieldOffset(0)]
			public FName SocketName;

			// Token: 0x0402CBC2 RID: 183234
			[FieldOffset(16)]
			public FTransform Transform;

			// Token: 0x0402CBC3 RID: 183235
			[FieldOffset(64)]
			public IntPtr SkeletalMesh;

			// Token: 0x0402CBC4 RID: 183236
			[FieldOffset(72)]
			public byte MorphTargets;

			// Token: 0x0402CBC5 RID: 183237
			[FieldOffset(88)]
			public byte Materials;

			// Token: 0x0402CBC6 RID: 183238
			[FieldOffset(104)]
			public int index;

			// Token: 0x0402CBC7 RID: 183239
			[FieldOffset(108)]
			public bool Suc;

			// Token: 0x0402CBC8 RID: 183240
			[FieldOffset(112)]
			public IntPtr SkeletalComp;
		}

		// Token: 0x02008EE7 RID: 36583
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __SetupSkeletalMeshComponents_FunctionParams
		{
			// Token: 0x0402CBC9 RID: 183241
			[FieldOffset(0)]
			public bool Suc;
		}

		// Token: 0x02008EE8 RID: 36584
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetupNpcMesh_FunctionParams
		{
			// Token: 0x0402CBCA RID: 183242
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x0402CBCB RID: 183243
			[FieldOffset(8)]
			public bool bIgnoreSockets;

			// Token: 0x0402CBCC RID: 183244
			[FieldOffset(9)]
			public bool bIgnoreCastShadow;

			// Token: 0x0402CBCD RID: 183245
			[FieldOffset(10)]
			public bool IsSuc;

			// Token: 0x0402CBCE RID: 183246
			[FieldOffset(16)]
			public byte SkleMain;
		}

		// Token: 0x02008EE9 RID: 36585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CBCF RID: 183247
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
