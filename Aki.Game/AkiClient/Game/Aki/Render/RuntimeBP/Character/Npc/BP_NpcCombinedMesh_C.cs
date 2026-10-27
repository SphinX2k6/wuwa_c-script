using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003DF9 RID: 15865
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/BP_NpcCombinedMesh.BP_NpcCombinedMesh_C")]
	[UnrealStructLayout(1776, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1769)]
	public class BP_NpcCombinedMesh_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A12 RID: 162322 RVA: 0x009968DC File Offset: 0x00994ADC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NpcCombinedMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/BP_NpcCombinedMesh.BP_NpcCombinedMesh_C");
			}
			return BP_NpcCombinedMesh_C._ClassPtr;
		}

		// Token: 0x06027A13 RID: 162323 RVA: 0x00996900 File Offset: 0x00994B00
		public BP_NpcCombinedMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_NpcCombinedMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A14 RID: 162324 RVA: 0x00996928 File Offset: 0x00994B28
		[NullableContext(1)]
		public BP_NpcCombinedMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NpcCombinedMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700591A RID: 22810
		// (get) Token: 0x06027A15 RID: 162325 RVA: 0x0099695B File Offset: 0x00994B5B
		// (set) Token: 0x06027A16 RID: 162326 RVA: 0x0099696F File Offset: 0x00994B6F
		[Nullable(2)]
		public unsafe USkeletalMeshComponent Skel_Main
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700591B RID: 22811
		// (get) Token: 0x06027A17 RID: 162327 RVA: 0x00996984 File Offset: 0x00994B84
		// (set) Token: 0x06027A18 RID: 162328 RVA: 0x00996998 File Offset: 0x00994B98
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700591C RID: 22812
		// (get) Token: 0x06027A19 RID: 162329 RVA: 0x009969AD File Offset: 0x00994BAD
		// (set) Token: 0x06027A1A RID: 162330 RVA: 0x009969C1 File Offset: 0x00994BC1
		[Nullable(2)]
		public unsafe PD_NpcSetupData_C NpcData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_NpcSetupData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700591D RID: 22813
		// (get) Token: 0x06027A1B RID: 162331 RVA: 0x009969D6 File Offset: 0x00994BD6
		// (set) Token: 0x06027A1C RID: 162332 RVA: 0x009969E6 File Offset: 0x00994BE6
		public unsafe bool OriginalSkeletalVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700591E RID: 22814
		// (get) Token: 0x06027A1D RID: 162333 RVA: 0x009969F8 File Offset: 0x00994BF8
		// (set) Token: 0x06027A1E RID: 162334 RVA: 0x00996A31 File Offset: 0x00994C31
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
					result = (this._AllSubSkeletalComponents = new TMap<FName, SNpcSetupPartInfo>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AllSubSkeletalComponents.CopyAssign(value);
			}
		}

		// Token: 0x1700591F RID: 22815
		// (get) Token: 0x06027A1F RID: 162335 RVA: 0x00996A3F File Offset: 0x00994C3F
		// (set) Token: 0x06027A20 RID: 162336 RVA: 0x00996A53 File Offset: 0x00994C53
		[Nullable(2)]
		public unsafe BP_NpcCombinedMesh_C Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_NpcCombinedMesh_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_6);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NpcCombinedMesh_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005920 RID: 22816
		// (get) Token: 0x06027A21 RID: 162337 RVA: 0x00996A68 File Offset: 0x00994C68
		// (set) Token: 0x06027A22 RID: 162338 RVA: 0x00996AA1 File Offset: 0x00994CA1
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
					result = (this._AllBodyPartName = new TMap<FName, TEnumAsByte<EBodyPartName>>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_7, this));
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

		// Token: 0x17005921 RID: 22817
		// (get) Token: 0x06027A23 RID: 162339 RVA: 0x00996AAF File Offset: 0x00994CAF
		// (set) Token: 0x06027A24 RID: 162340 RVA: 0x00996AC3 File Offset: 0x00994CC3
		public unsafe FLinearColor ColorNPC01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005922 RID: 22818
		// (get) Token: 0x06027A25 RID: 162341 RVA: 0x00996AD8 File Offset: 0x00994CD8
		// (set) Token: 0x06027A26 RID: 162342 RVA: 0x00996AEC File Offset: 0x00994CEC
		public unsafe FLinearColor ColorNPC02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005923 RID: 22819
		// (get) Token: 0x06027A27 RID: 162343 RVA: 0x00996B01 File Offset: 0x00994D01
		// (set) Token: 0x06027A28 RID: 162344 RVA: 0x00996B11 File Offset: 0x00994D11
		public unsafe int Forced_LOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005924 RID: 22820
		// (get) Token: 0x06027A29 RID: 162345 RVA: 0x00996B22 File Offset: 0x00994D22
		// (set) Token: 0x06027A2A RID: 162346 RVA: 0x00996B36 File Offset: 0x00994D36
		public unsafe FLinearColor SkinColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005925 RID: 22821
		// (get) Token: 0x06027A2B RID: 162347 RVA: 0x00996B4C File Offset: 0x00994D4C
		// (set) Token: 0x06027A2C RID: 162348 RVA: 0x00996B85 File Offset: 0x00994D85
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
					result = (this._SkelMeshArray = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkelMeshArray.CopyAssign(value);
			}
		}

		// Token: 0x17005926 RID: 22822
		// (get) Token: 0x06027A2D RID: 162349 RVA: 0x00996B94 File Offset: 0x00994D94
		// (set) Token: 0x06027A2E RID: 162350 RVA: 0x00996BCD File Offset: 0x00994DCD
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
					result = (this._MINPCs = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MINPCs.CopyAssign(value);
			}
		}

		// Token: 0x17005927 RID: 22823
		// (get) Token: 0x06027A2F RID: 162351 RVA: 0x00996BDB File Offset: 0x00994DDB
		// (set) Token: 0x06027A30 RID: 162352 RVA: 0x00996BEB File Offset: 0x00994DEB
		public unsafe bool AdaptMaterialController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005928 RID: 22824
		// (get) Token: 0x06027A31 RID: 162353 RVA: 0x00996BFC File Offset: 0x00994DFC
		// (set) Token: 0x06027A32 RID: 162354 RVA: 0x00996C0C File Offset: 0x00994E0C
		public unsafe bool Ticked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005929 RID: 22825
		// (get) Token: 0x06027A33 RID: 162355 RVA: 0x00996C20 File Offset: 0x00994E20
		// (set) Token: 0x06027A34 RID: 162356 RVA: 0x00996C59 File Offset: 0x00994E59
		[Nullable(1)]
		public TArray<UKuroNpcExtraDecorationConfig> DecorationData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroNpcExtraDecorationConfig> result;
				if ((result = this._DecorationData) == null)
				{
					result = (this._DecorationData = new TArray<UKuroNpcExtraDecorationConfig>(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DecorationData.CopyAssign(value);
			}
		}

		// Token: 0x1700592A RID: 22826
		// (get) Token: 0x06027A35 RID: 162357 RVA: 0x00996C67 File Offset: 0x00994E67
		// (set) Token: 0x06027A36 RID: 162358 RVA: 0x00996C77 File Offset: 0x00994E77
		public unsafe bool SkelTickableWhenPaused
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NpcCombinedMesh_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027A37 RID: 162359 RVA: 0x00996C88 File Offset: 0x00994E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ApplySkelTickableWhenPaused()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ApplySkelTickableWhenPaused_NativeFunctionPtr, null);
		}

		// Token: 0x06027A38 RID: 162360 RVA: 0x00996C9C File Offset: 0x00994E9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetSkelTickableWhenPaused(bool bTickableWhenPaused)
		{
			BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bTickableWhenPaused = bTickableWhenPaused;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetSkelTickableWhenPaused_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027A39 RID: 162361 RVA: 0x00996CE4 File Offset: 0x00994EE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetupDecorations([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UKuroNpcExtraDecorationConfig> Decorations)
		{
			BP_NpcCombinedMesh_C.__SetupDecorations_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__SetupDecorations_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__SetupDecorations_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__SetupDecorations_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UKuroNpcExtraDecorationConfig> tarray = Decorations;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Decorations);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupDecorations_NativeFunctionPtr, (void*)ptr);
			TArray<UKuroNpcExtraDecorationConfig> tarray2 = Decorations;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Decorations);
			}
			UnrealReflectionUtils.DestroyStruct(BP_NpcCombinedMesh_C.__SetupDecorations_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027A3A RID: 162362 RVA: 0x00996D5C File Offset: 0x00994F5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetupCastShadow(bool bIgnoreCastShadow)
		{
			BP_NpcCombinedMesh_C.__SetupCastShadow_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__SetupCastShadow_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__SetupCastShadow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__SetupCastShadow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIgnoreCastShadow = bIgnoreCastShadow;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupCastShadow_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027A3B RID: 162363 RVA: 0x00996DA2 File Offset: 0x00994FA2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetupHiddenBones()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupHiddenBones_NativeFunctionPtr, null);
		}

		// Token: 0x06027A3C RID: 162364 RVA: 0x00996DB6 File Offset: 0x00994FB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetupChildParts()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupChildParts_NativeFunctionPtr, null);
		}

		// Token: 0x06027A3D RID: 162365 RVA: 0x00996DCC File Offset: 0x00994FCC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A3E RID: 162366 RVA: 0x00996E6E File Offset: 0x0099506E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 预览MorphTarget()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__预览MorphTarget_NativeFunctionPtr, null);
		}

		// Token: 0x06027A3F RID: 162367 RVA: 0x00996E84 File Offset: 0x00995084
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Test(USkeletalMeshComponent SKMesh, UMaterialInstance MI)
		{
			BP_NpcCombinedMesh_C.__Test_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__Test_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__Test_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__Test_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SKMesh = ((SKMesh != null) ? SKMesh.NativePtr : IntPtr.Zero);
			ptr->MI = ((MI != null) ? MI.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__Test_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027A40 RID: 162368 RVA: 0x00996EF0 File Offset: 0x009950F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A41 RID: 162369 RVA: 0x00996F58 File Offset: 0x00995158
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A42 RID: 162370 RVA: 0x00997010 File Offset: 0x00995210
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddSkeletalComponent(FName Name, USkeletalMeshComponent SkeletalComp)
		{
			BP_NpcCombinedMesh_C.__AddSkeletalComponent_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__AddSkeletalComponent_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__AddSkeletalComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__AddSkeletalComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Name = Name;
			ptr->SkeletalComp = ((SkeletalComp != null) ? SkeletalComp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__AddSkeletalComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027A43 RID: 162371 RVA: 0x0099706C File Offset: 0x0099526C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A44 RID: 162372 RVA: 0x00997110 File Offset: 0x00995310
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A45 RID: 162373 RVA: 0x00997178 File Offset: 0x00995378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A46 RID: 162374 RVA: 0x009971E0 File Offset: 0x009953E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A47 RID: 162375 RVA: 0x00997248 File Offset: 0x00995448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A48 RID: 162376 RVA: 0x009972B0 File Offset: 0x009954B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A49 RID: 162377 RVA: 0x00997318 File Offset: 0x00995518
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A4A RID: 162378 RVA: 0x00997424 File Offset: 0x00995624
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetupSockets()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupSockets_NativeFunctionPtr, null);
		}

		// Token: 0x06027A4B RID: 162379 RVA: 0x00997438 File Offset: 0x00995638
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetupSkeletalMeshComponents(ref bool Suc)
		{
			BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Suc = Suc;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__SetupSkeletalMeshComponents_NativeFunctionPtr, (void*)ptr);
			Suc = ptr->Suc;
		}

		// Token: 0x06027A4C RID: 162380 RVA: 0x00997487 File Offset: 0x00995687
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetNpcMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ResetNpcMesh_NativeFunctionPtr, null);
		}

		// Token: 0x06027A4D RID: 162381 RVA: 0x0099749C File Offset: 0x0099569C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A4E RID: 162382 RVA: 0x0099754C File Offset: 0x0099574C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027A4F RID: 162383 RVA: 0x00997560 File Offset: 0x00995760
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027A50 RID: 162384 RVA: 0x00997575 File Offset: 0x00995775
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027A51 RID: 162385 RVA: 0x00997589 File Offset: 0x00995789
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027A52 RID: 162386 RVA: 0x009975A0 File Offset: 0x009957A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027A53 RID: 162387 RVA: 0x009975E8 File Offset: 0x009957E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NpcCombinedMesh_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NpcCombinedMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NpcCombinedMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027A54 RID: 162388 RVA: 0x0099762F File Offset: 0x0099582F
		protected BP_NpcCombinedMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040140B1 RID: 82097
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/BP_NpcCombinedMesh.BP_NpcCombinedMesh_C";

		// Token: 0x040140B2 RID: 82098
		private static IntPtr _ClassPtr;

		// Token: 0x040140B3 RID: 82099
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040140B4 RID: 82100
		internal static int __PropertyOffset_1;

		// Token: 0x040140B5 RID: 82101
		internal static int __PropertyOffset_2;

		// Token: 0x040140B6 RID: 82102
		internal static int __PropertyOffset_3;

		// Token: 0x040140B7 RID: 82103
		internal static int __PropertyOffset_4;

		// Token: 0x040140B8 RID: 82104
		internal static int __PropertyOffset_5;

		// Token: 0x040140B9 RID: 82105
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, SNpcSetupPartInfo> _AllSubSkeletalComponents;

		// Token: 0x040140BA RID: 82106
		internal static int __PropertyOffset_6;

		// Token: 0x040140BB RID: 82107
		internal static int __PropertyOffset_7;

		// Token: 0x040140BC RID: 82108
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<FName, TEnumAsByte<EBodyPartName>> _AllBodyPartName;

		// Token: 0x040140BD RID: 82109
		internal static int __PropertyOffset_8;

		// Token: 0x040140BE RID: 82110
		internal static int __PropertyOffset_9;

		// Token: 0x040140BF RID: 82111
		internal static int __PropertyOffset_10;

		// Token: 0x040140C0 RID: 82112
		internal static int __PropertyOffset_11;

		// Token: 0x040140C1 RID: 82113
		internal static int __PropertyOffset_12;

		// Token: 0x040140C2 RID: 82114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _SkelMeshArray;

		// Token: 0x040140C3 RID: 82115
		internal static int __PropertyOffset_13;

		// Token: 0x040140C4 RID: 82116
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _MINPCs;

		// Token: 0x040140C5 RID: 82117
		internal static int __PropertyOffset_14;

		// Token: 0x040140C6 RID: 82118
		internal static int __PropertyOffset_15;

		// Token: 0x040140C7 RID: 82119
		internal static int __PropertyOffset_16;

		// Token: 0x040140C8 RID: 82120
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroNpcExtraDecorationConfig> _DecorationData;

		// Token: 0x040140C9 RID: 82121
		internal static int __PropertyOffset_17;

		// Token: 0x040140CA RID: 82122
		private static IntPtr __ApplySkelTickableWhenPaused_NativeFunctionPtr;

		// Token: 0x040140CB RID: 82123
		private static IntPtr __SetSkelTickableWhenPaused_NativeFunctionPtr;

		// Token: 0x040140CC RID: 82124
		private static IntPtr __SetupDecorations_NativeFunctionPtr;

		// Token: 0x040140CD RID: 82125
		private static IntPtr __SetupCastShadow_NativeFunctionPtr;

		// Token: 0x040140CE RID: 82126
		private static IntPtr __SetupHiddenBones_NativeFunctionPtr;

		// Token: 0x040140CF RID: 82127
		private static IntPtr __SetupChildParts_NativeFunctionPtr;

		// Token: 0x040140D0 RID: 82128
		private static IntPtr __Set_Skeletal_Mesh_Material_NativeFunctionPtr;

		// Token: 0x040140D1 RID: 82129
		private static IntPtr __预览MorphTarget_NativeFunctionPtr;

		// Token: 0x040140D2 RID: 82130
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x040140D3 RID: 82131
		private static IntPtr __GetHeadTransform_NativeFunctionPtr;

		// Token: 0x040140D4 RID: 82132
		private static IntPtr __Set_Skeleton_Mesh_DI_NativeFunctionPtr;

		// Token: 0x040140D5 RID: 82133
		private static IntPtr __AddSkeletalComponent_NativeFunctionPtr;

		// Token: 0x040140D6 RID: 82134
		private static IntPtr __Setup_Skeletal_Mesh_Component_NativeFunctionPtr;

		// Token: 0x040140D7 RID: 82135
		private static IntPtr __GetWaistTransform_NativeFunctionPtr;

		// Token: 0x040140D8 RID: 82136
		private static IntPtr __GetBackTransform_NativeFunctionPtr;

		// Token: 0x040140D9 RID: 82137
		private static IntPtr __GetLegTransform_NativeFunctionPtr;

		// Token: 0x040140DA RID: 82138
		private static IntPtr __GetWeaponTransform_NativeFunctionPtr;

		// Token: 0x040140DB RID: 82139
		private static IntPtr __GetArmTransform_NativeFunctionPtr;

		// Token: 0x040140DC RID: 82140
		private static IntPtr __Setup_Socket_NativeFunctionPtr;

		// Token: 0x040140DD RID: 82141
		private static IntPtr __SetupSockets_NativeFunctionPtr;

		// Token: 0x040140DE RID: 82142
		private static IntPtr __SetupSkeletalMeshComponents_NativeFunctionPtr;

		// Token: 0x040140DF RID: 82143
		private static IntPtr __ResetNpcMesh_NativeFunctionPtr;

		// Token: 0x040140E0 RID: 82144
		private static IntPtr __SetupNpcMesh_NativeFunctionPtr;

		// Token: 0x040140E1 RID: 82145
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040140E2 RID: 82146
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040140E3 RID: 82147
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A258 RID: 41560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetSkelTickableWhenPaused_FunctionParams
		{
			// Token: 0x04031EF6 RID: 204534
			[FieldOffset(0)]
			public bool bTickableWhenPaused;
		}

		// Token: 0x0200A259 RID: 41561
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetupDecorations_FunctionParams
		{
			// Token: 0x04031EF7 RID: 204535
			[FieldOffset(0)]
			public byte Decorations;
		}

		// Token: 0x0200A25A RID: 41562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetupCastShadow_FunctionParams
		{
			// Token: 0x04031EF8 RID: 204536
			[FieldOffset(0)]
			public bool bIgnoreCastShadow;
		}

		// Token: 0x0200A25B RID: 41563
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 808)]
		protected ref struct __Set_Skeletal_Mesh_Material_FunctionParams
		{
			// Token: 0x04031EF9 RID: 204537
			[FieldOffset(0)]
			public IntPtr ReplaceMaterial;

			// Token: 0x04031EFA RID: 204538
			[FieldOffset(8)]
			public IntPtr SkeletalMeshComp;

			// Token: 0x04031EFB RID: 204539
			[FieldOffset(16)]
			public FName ParamName01;

			// Token: 0x04031EFC RID: 204540
			[FieldOffset(28)]
			public FName ParamName02;

			// Token: 0x04031EFD RID: 204541
			[FieldOffset(40)]
			public FName SkinColorName;

			// Token: 0x04031EFE RID: 204542
			[FieldOffset(52)]
			public int NumSlots;

			// Token: 0x04031EFF RID: 204543
			[FieldOffset(56)]
			public int MaterialIndex;

			// Token: 0x04031F00 RID: 204544
			[FieldOffset(60)]
			public TEnumAsByte<EBodyPartName> BodyType;
		}

		// Token: 0x0200A25C RID: 41564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Test_FunctionParams
		{
			// Token: 0x04031F01 RID: 204545
			[FieldOffset(0)]
			public IntPtr SKMesh;

			// Token: 0x04031F02 RID: 204546
			[FieldOffset(8)]
			public IntPtr MI;
		}

		// Token: 0x0200A25D RID: 41565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetHeadTransform_FunctionParams
		{
			// Token: 0x04031F03 RID: 204547
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x04031F04 RID: 204548
			[FieldOffset(48)]
			public int Index;

			// Token: 0x04031F05 RID: 204549
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x0200A25E RID: 41566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __Set_Skeleton_Mesh_DI_FunctionParams
		{
			// Token: 0x04031F06 RID: 204550
			[FieldOffset(0)]
			public IntPtr SKMesh;

			// Token: 0x04031F07 RID: 204551
			[FieldOffset(8)]
			public FName ParamName01;

			// Token: 0x04031F08 RID: 204552
			[FieldOffset(20)]
			public FName ParamName02;

			// Token: 0x04031F09 RID: 204553
			[FieldOffset(32)]
			public TEnumAsByte<EBodyPartName> BodyType;

			// Token: 0x04031F0A RID: 204554
			[FieldOffset(36)]
			public FName SkinColorName;

			// Token: 0x04031F0B RID: 204555
			[FieldOffset(48)]
			public byte Materials;
		}

		// Token: 0x0200A25F RID: 41567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __AddSkeletalComponent_FunctionParams
		{
			// Token: 0x04031F0C RID: 204556
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x04031F0D RID: 204557
			[FieldOffset(16)]
			public IntPtr SkeletalComp;
		}

		// Token: 0x0200A260 RID: 41568
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 608)]
		protected ref struct __Setup_Skeletal_Mesh_Component_FunctionParams
		{
			// Token: 0x04031F0E RID: 204558
			[FieldOffset(0)]
			public IntPtr InSkeletalMesh;

			// Token: 0x04031F0F RID: 204559
			[FieldOffset(8)]
			public TEnumAsByte<EBodyPartName> BodyType;

			// Token: 0x04031F10 RID: 204560
			[FieldOffset(12)]
			public int Index;

			// Token: 0x04031F11 RID: 204561
			[FieldOffset(16)]
			public bool Suc;

			// Token: 0x04031F12 RID: 204562
			[FieldOffset(24)]
			public IntPtr SkeletalComp;
		}

		// Token: 0x0200A261 RID: 41569
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetWaistTransform_FunctionParams
		{
			// Token: 0x04031F13 RID: 204563
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x04031F14 RID: 204564
			[FieldOffset(48)]
			public int Index;

			// Token: 0x04031F15 RID: 204565
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x0200A262 RID: 41570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetBackTransform_FunctionParams
		{
			// Token: 0x04031F16 RID: 204566
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x04031F17 RID: 204567
			[FieldOffset(48)]
			public int Index;

			// Token: 0x04031F18 RID: 204568
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x0200A263 RID: 41571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetLegTransform_FunctionParams
		{
			// Token: 0x04031F19 RID: 204569
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x04031F1A RID: 204570
			[FieldOffset(48)]
			public int Index;

			// Token: 0x04031F1B RID: 204571
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x0200A264 RID: 41572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetWeaponTransform_FunctionParams
		{
			// Token: 0x04031F1C RID: 204572
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x04031F1D RID: 204573
			[FieldOffset(48)]
			public int Index;

			// Token: 0x04031F1E RID: 204574
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x0200A265 RID: 41573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetArmTransform_FunctionParams
		{
			// Token: 0x04031F1F RID: 204575
			[FieldOffset(0)]
			public FTransform InTransform;

			// Token: 0x04031F20 RID: 204576
			[FieldOffset(48)]
			public int Index;

			// Token: 0x04031F21 RID: 204577
			[FieldOffset(64)]
			public FTransform OutTransform;
		}

		// Token: 0x0200A266 RID: 41574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 592)]
		protected ref struct __Setup_Socket_FunctionParams
		{
			// Token: 0x04031F22 RID: 204578
			[FieldOffset(0)]
			public FName SocketName;

			// Token: 0x04031F23 RID: 204579
			[FieldOffset(16)]
			public FTransform Transform;

			// Token: 0x04031F24 RID: 204580
			[FieldOffset(64)]
			public IntPtr SkeletalMesh;

			// Token: 0x04031F25 RID: 204581
			[FieldOffset(72)]
			public byte MorphTargets;

			// Token: 0x04031F26 RID: 204582
			[FieldOffset(88)]
			public byte Materials;

			// Token: 0x04031F27 RID: 204583
			[FieldOffset(104)]
			public int index;

			// Token: 0x04031F28 RID: 204584
			[FieldOffset(108)]
			public bool Suc;

			// Token: 0x04031F29 RID: 204585
			[FieldOffset(112)]
			public IntPtr SkeletalComp;
		}

		// Token: 0x0200A267 RID: 41575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetupSkeletalMeshComponents_FunctionParams
		{
			// Token: 0x04031F2A RID: 204586
			[FieldOffset(0)]
			public bool Suc;
		}

		// Token: 0x0200A268 RID: 41576
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetupNpcMesh_FunctionParams
		{
			// Token: 0x04031F2B RID: 204587
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x04031F2C RID: 204588
			[FieldOffset(8)]
			public bool bIgnoreSockets;

			// Token: 0x04031F2D RID: 204589
			[FieldOffset(9)]
			public bool bIgnoreCastShadow;

			// Token: 0x04031F2E RID: 204590
			[FieldOffset(10)]
			public bool IsSuc;

			// Token: 0x04031F2F RID: 204591
			[FieldOffset(16)]
			public byte SkleMain;
		}

		// Token: 0x0200A269 RID: 41577
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031F30 RID: 204592
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
