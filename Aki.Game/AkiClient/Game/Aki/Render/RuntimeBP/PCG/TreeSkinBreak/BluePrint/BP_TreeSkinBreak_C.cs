using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.TreeSkinBreak.BluePrint
{
	// Token: 0x02003BE9 RID: 15337
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/TreeSkinBreak/BluePrint/BP_TreeSkinBreak.BP_TreeSkinBreak_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_TreeSkinBreak_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022CD1 RID: 142545 RVA: 0x00912755 File Offset: 0x00910955
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TreeSkinBreak_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/TreeSkinBreak/BluePrint/BP_TreeSkinBreak.BP_TreeSkinBreak_C");
			}
			return BP_TreeSkinBreak_C._ClassPtr;
		}

		// Token: 0x06022CD2 RID: 142546 RVA: 0x0091277C File Offset: 0x0091097C
		public BP_TreeSkinBreak_C() : this(BuiltinUtils.AllocNativeUObject(BP_TreeSkinBreak_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022CD3 RID: 142547 RVA: 0x009127A4 File Offset: 0x009109A4
		[NullableContext(1)]
		public BP_TreeSkinBreak_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TreeSkinBreak_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x06022CD4 RID: 142548 RVA: 0x009127D7 File Offset: 0x009109D7
		// (set) Token: 0x06022CD5 RID: 142549 RVA: 0x009127EB File Offset: 0x009109EB
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x06022CD6 RID: 142550 RVA: 0x00912800 File Offset: 0x00910A00
		// (set) Token: 0x06022CD7 RID: 142551 RVA: 0x00912814 File Offset: 0x00910A14
		public unsafe UStaticMeshComponent SM_Tree
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x06022CD8 RID: 142552 RVA: 0x00912829 File Offset: 0x00910A29
		// (set) Token: 0x06022CD9 RID: 142553 RVA: 0x0091283D File Offset: 0x00910A3D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x06022CDA RID: 142554 RVA: 0x00912852 File Offset: 0x00910A52
		// (set) Token: 0x06022CDB RID: 142555 RVA: 0x00912862 File Offset: 0x00910A62
		public unsafe float HitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x06022CDC RID: 142556 RVA: 0x00912873 File Offset: 0x00910A73
		// (set) Token: 0x06022CDD RID: 142557 RVA: 0x00912883 File Offset: 0x00910A83
		public unsafe float TraceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x06022CDE RID: 142558 RVA: 0x00912894 File Offset: 0x00910A94
		// (set) Token: 0x06022CDF RID: 142559 RVA: 0x009128A8 File Offset: 0x00910AA8
		public unsafe FVector LastWeaponPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x06022CE0 RID: 142560 RVA: 0x009128BD File Offset: 0x00910ABD
		// (set) Token: 0x06022CE1 RID: 142561 RVA: 0x009128CD File Offset: 0x00910ACD
		public unsafe bool DebugBreak
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x06022CE2 RID: 142562 RVA: 0x009128DE File Offset: 0x00910ADE
		// (set) Token: 0x06022CE3 RID: 142563 RVA: 0x009128EE File Offset: 0x00910AEE
		public unsafe bool DebugEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x06022CE4 RID: 142564 RVA: 0x009128FF File Offset: 0x00910AFF
		// (set) Token: 0x06022CE5 RID: 142565 RVA: 0x0091290F File Offset: 0x00910B0F
		public unsafe float SpeedThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x06022CE6 RID: 142566 RVA: 0x00912920 File Offset: 0x00910B20
		// (set) Token: 0x06022CE7 RID: 142567 RVA: 0x00912930 File Offset: 0x00910B30
		public unsafe bool LastPointUseAble
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x06022CE8 RID: 142568 RVA: 0x00912941 File Offset: 0x00910B41
		// (set) Token: 0x06022CE9 RID: 142569 RVA: 0x00912955 File Offset: 0x00910B55
		public unsafe UMaterialInstanceDynamic StampMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x06022CEA RID: 142570 RVA: 0x0091296A File Offset: 0x00910B6A
		// (set) Token: 0x06022CEB RID: 142571 RVA: 0x0091297E File Offset: 0x00910B7E
		public unsafe UMaterialInstanceDynamic TreeSkinMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x06022CEC RID: 142572 RVA: 0x00912993 File Offset: 0x00910B93
		// (set) Token: 0x06022CED RID: 142573 RVA: 0x009129A7 File Offset: 0x00910BA7
		public unsafe UStaticMesh SMTree
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x06022CEE RID: 142574 RVA: 0x009129BC File Offset: 0x00910BBC
		// (set) Token: 0x06022CEF RID: 142575 RVA: 0x009129D0 File Offset: 0x00910BD0
		public unsafe UMaterialInterface TreeSkinMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x06022CF0 RID: 142576 RVA: 0x009129E5 File Offset: 0x00910BE5
		// (set) Token: 0x06022CF1 RID: 142577 RVA: 0x009129F5 File Offset: 0x00910BF5
		public unsafe int TreeMatIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x06022CF2 RID: 142578 RVA: 0x00912A06 File Offset: 0x00910C06
		// (set) Token: 0x06022CF3 RID: 142579 RVA: 0x00912A1B File Offset: 0x00910C1B
		[Nullable(1)]
		public TSoftObjectPtr<UTexture2D> TreePosTexture
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_16, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_16, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x06022CF4 RID: 142580 RVA: 0x00912A40 File Offset: 0x00910C40
		// (set) Token: 0x06022CF5 RID: 142581 RVA: 0x00912A54 File Offset: 0x00910C54
		public unsafe UNiagaraSystem NiagaraFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x06022CF6 RID: 142582 RVA: 0x00912A69 File Offset: 0x00910C69
		// (set) Token: 0x06022CF7 RID: 142583 RVA: 0x00912A7D File Offset: 0x00910C7D
		public unsafe UTextureRenderTarget2D SkinMaskRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x06022CF8 RID: 142584 RVA: 0x00912A92 File Offset: 0x00910C92
		// (set) Token: 0x06022CF9 RID: 142585 RVA: 0x00912AA2 File Offset: 0x00910CA2
		public unsafe float VFXSpawnTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x06022CFA RID: 142586 RVA: 0x00912AB3 File Offset: 0x00910CB3
		// (set) Token: 0x06022CFB RID: 142587 RVA: 0x00912AC3 File Offset: 0x00910CC3
		public unsafe float SwordRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x06022CFC RID: 142588 RVA: 0x00912AD4 File Offset: 0x00910CD4
		// (set) Token: 0x06022CFD RID: 142589 RVA: 0x00912AE4 File Offset: 0x00910CE4
		public unsafe float KnifeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x06022CFE RID: 142590 RVA: 0x00912AF5 File Offset: 0x00910CF5
		// (set) Token: 0x06022CFF RID: 142591 RVA: 0x00912B05 File Offset: 0x00910D05
		public unsafe float WeaponRadius2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x06022D00 RID: 142592 RVA: 0x00912B16 File Offset: 0x00910D16
		// (set) Token: 0x06022D01 RID: 142593 RVA: 0x00912B26 File Offset: 0x00910D26
		public unsafe float BulletRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x06022D02 RID: 142594 RVA: 0x00912B37 File Offset: 0x00910D37
		// (set) Token: 0x06022D03 RID: 142595 RVA: 0x00912B4B File Offset: 0x00910D4B
		public unsafe BP_SceneBattleInteract_C SceneInteractConf
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TreeSkinBreak_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x06022D04 RID: 142596 RVA: 0x00912B60 File Offset: 0x00910D60
		// (set) Token: 0x06022D05 RID: 142597 RVA: 0x00912B74 File Offset: 0x00910D74
		public unsafe FVector LastWeaponP1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x06022D06 RID: 142598 RVA: 0x00912B89 File Offset: 0x00910D89
		// (set) Token: 0x06022D07 RID: 142599 RVA: 0x00912B9D File Offset: 0x00910D9D
		public unsafe FVector LastWeaponP2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x06022D08 RID: 142600 RVA: 0x00912BB4 File Offset: 0x00910DB4
		// (set) Token: 0x06022D09 RID: 142601 RVA: 0x00912BED File Offset: 0x00910DED
		[Nullable(1)]
		public TArray<float> CustomData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new TArray<float>(base.NativePtr + (IntPtr)BP_TreeSkinBreak_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x06022D0A RID: 142602 RVA: 0x00912BFC File Offset: 0x00910DFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetLastPosition(int Index, ref FVector NewParam1)
		{
			BP_TreeSkinBreak_C.__GetLastPosition_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__GetLastPosition_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__GetLastPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__GetLastPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			ptr->NewParam1 = NewParam1;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__GetLastPosition_NativeFunctionPtr, (void*)ptr);
			NewParam1 = ptr->NewParam1;
		}

		// Token: 0x06022D0B RID: 142603 RVA: 0x00912C5C File Offset: 0x00910E5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DrawBreakTrail(FVector CurrPos, FVector PrevPos, float Radius)
		{
			BP_TreeSkinBreak_C.__DrawBreakTrail_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__DrawBreakTrail_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__DrawBreakTrail_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__DrawBreakTrail_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrPos = CurrPos;
			ptr->PrevPos = PrevPos;
			ptr->Radius = Radius;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__DrawBreakTrail_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D0C RID: 142604 RVA: 0x00912CB4 File Offset: 0x00910EB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLastPosition(int Index, FVector HitPos)
		{
			BP_TreeSkinBreak_C.__SetLastPosition_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__SetLastPosition_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__SetLastPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__SetLastPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			ptr->HitPos = HitPos;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__SetLastPosition_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D0D RID: 142605 RVA: 0x00912D01 File Offset: 0x00910F01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06022D0E RID: 142606 RVA: 0x00912D15 File Offset: 0x00910F15
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022D0F RID: 142607 RVA: 0x00912D29 File Offset: 0x00910F29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TreeSkinBreak_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022D10 RID: 142608 RVA: 0x00912D40 File Offset: 0x00910F40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_48399B0741DF29F7DA29A6AB705C74E1(int PlayingID)
		{
			BP_TreeSkinBreak_C.__Completed_48399B0741DF29F7DA29A6AB705C74E1_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__Completed_48399B0741DF29F7DA29A6AB705C74E1_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__Completed_48399B0741DF29F7DA29A6AB705C74E1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__Completed_48399B0741DF29F7DA29A6AB705C74E1_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__Completed_48399B0741DF29F7DA29A6AB705C74E1_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D11 RID: 142609 RVA: 0x00912D88 File Offset: 0x00910F88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_0008B86B46891F8C5758E09BE6773947(UObject Loaded)
		{
			BP_TreeSkinBreak_C.__OnLoaded_0008B86B46891F8C5758E09BE6773947_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__OnLoaded_0008B86B46891F8C5758E09BE6773947_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__OnLoaded_0008B86B46891F8C5758E09BE6773947_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__OnLoaded_0008B86B46891F8C5758E09BE6773947_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__OnLoaded_0008B86B46891F8C5758E09BE6773947_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D12 RID: 142610 RVA: 0x00912DDD File Offset: 0x00910FDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022D13 RID: 142611 RVA: 0x00912DF1 File Offset: 0x00910FF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TreeSkinBreak_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022D14 RID: 142612 RVA: 0x00912E08 File Offset: 0x00911008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_TreeSkinBreak_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D15 RID: 142613 RVA: 0x00912E6C File Offset: 0x0091106C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D16 RID: 142614 RVA: 0x00912F28 File Offset: 0x00911128
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D17 RID: 142615 RVA: 0x00912FB4 File Offset: 0x009111B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_TreeSkinBreak_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TreeSkinBreak_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D18 RID: 142616 RVA: 0x00913000 File Offset: 0x00911200
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_TreeSkinBreak_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_TreeSkinBreak_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_TreeSkinBreak_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TreeSkinBreak_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TreeSkinBreak_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022D19 RID: 142617 RVA: 0x0091304C File Offset: 0x0091124C
		protected BP_TreeSkinBreak_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040111EA RID: 70122
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/TreeSkinBreak/BluePrint/BP_TreeSkinBreak.BP_TreeSkinBreak_C";

		// Token: 0x040111EB RID: 70123
		private static IntPtr _ClassPtr;

		// Token: 0x040111EC RID: 70124
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040111ED RID: 70125
		internal static int __PropertyOffset_1;

		// Token: 0x040111EE RID: 70126
		internal static int __PropertyOffset_2;

		// Token: 0x040111EF RID: 70127
		internal static int __PropertyOffset_3;

		// Token: 0x040111F0 RID: 70128
		internal static int __PropertyOffset_4;

		// Token: 0x040111F1 RID: 70129
		internal static int __PropertyOffset_5;

		// Token: 0x040111F2 RID: 70130
		internal static int __PropertyOffset_6;

		// Token: 0x040111F3 RID: 70131
		internal static int __PropertyOffset_7;

		// Token: 0x040111F4 RID: 70132
		internal static int __PropertyOffset_8;

		// Token: 0x040111F5 RID: 70133
		internal static int __PropertyOffset_9;

		// Token: 0x040111F6 RID: 70134
		internal static int __PropertyOffset_10;

		// Token: 0x040111F7 RID: 70135
		internal static int __PropertyOffset_11;

		// Token: 0x040111F8 RID: 70136
		internal static int __PropertyOffset_12;

		// Token: 0x040111F9 RID: 70137
		internal static int __PropertyOffset_13;

		// Token: 0x040111FA RID: 70138
		internal static int __PropertyOffset_14;

		// Token: 0x040111FB RID: 70139
		internal static int __PropertyOffset_15;

		// Token: 0x040111FC RID: 70140
		internal static int __PropertyOffset_16;

		// Token: 0x040111FD RID: 70141
		internal static int __PropertyOffset_17;

		// Token: 0x040111FE RID: 70142
		internal static int __PropertyOffset_18;

		// Token: 0x040111FF RID: 70143
		internal static int __PropertyOffset_19;

		// Token: 0x04011200 RID: 70144
		internal static int __PropertyOffset_20;

		// Token: 0x04011201 RID: 70145
		internal static int __PropertyOffset_21;

		// Token: 0x04011202 RID: 70146
		internal static int __PropertyOffset_22;

		// Token: 0x04011203 RID: 70147
		internal static int __PropertyOffset_23;

		// Token: 0x04011204 RID: 70148
		internal static int __PropertyOffset_24;

		// Token: 0x04011205 RID: 70149
		internal static int __PropertyOffset_25;

		// Token: 0x04011206 RID: 70150
		internal static int __PropertyOffset_26;

		// Token: 0x04011207 RID: 70151
		internal static int __PropertyOffset_27;

		// Token: 0x04011208 RID: 70152
		private TArray<float> _CustomData;

		// Token: 0x04011209 RID: 70153
		private static IntPtr __GetLastPosition_NativeFunctionPtr;

		// Token: 0x0401120A RID: 70154
		private static IntPtr __DrawBreakTrail_NativeFunctionPtr;

		// Token: 0x0401120B RID: 70155
		private static IntPtr __SetLastPosition_NativeFunctionPtr;

		// Token: 0x0401120C RID: 70156
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0401120D RID: 70157
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401120E RID: 70158
		private static IntPtr __Completed_48399B0741DF29F7DA29A6AB705C74E1_NativeFunctionPtr;

		// Token: 0x0401120F RID: 70159
		private static IntPtr __OnLoaded_0008B86B46891F8C5758E09BE6773947_NativeFunctionPtr;

		// Token: 0x04011210 RID: 70160
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011211 RID: 70161
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04011212 RID: 70162
		private static IntPtr __BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011213 RID: 70163
		private static IntPtr __BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011214 RID: 70164
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009DCC RID: 40396
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __GetLastPosition_FunctionParams
		{
			// Token: 0x040315BF RID: 202175
			[FieldOffset(0)]
			public int Index;

			// Token: 0x040315C0 RID: 202176
			[FieldOffset(4)]
			public FVector NewParam1;
		}

		// Token: 0x02009DCD RID: 40397
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __DrawBreakTrail_FunctionParams
		{
			// Token: 0x040315C1 RID: 202177
			[FieldOffset(0)]
			public FVector CurrPos;

			// Token: 0x040315C2 RID: 202178
			[FieldOffset(12)]
			public FVector PrevPos;

			// Token: 0x040315C3 RID: 202179
			[FieldOffset(24)]
			public float Radius;
		}

		// Token: 0x02009DCE RID: 40398
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __SetLastPosition_FunctionParams
		{
			// Token: 0x040315C4 RID: 202180
			[FieldOffset(0)]
			public int Index;

			// Token: 0x040315C5 RID: 202181
			[FieldOffset(4)]
			public FVector HitPos;
		}

		// Token: 0x02009DCF RID: 40399
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_48399B0741DF29F7DA29A6AB705C74E1_FunctionParams
		{
			// Token: 0x040315C6 RID: 202182
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DD0 RID: 40400
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_0008B86B46891F8C5758E09BE6773947_FunctionParams
		{
			// Token: 0x040315C7 RID: 202183
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x02009DD1 RID: 40401
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040315C8 RID: 202184
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040315C9 RID: 202185
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040315CA RID: 202186
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009DD2 RID: 40402
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315CB RID: 202187
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040315CC RID: 202188
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040315CD RID: 202189
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040315CE RID: 202190
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040315CF RID: 202191
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040315D0 RID: 202192
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009DD3 RID: 40403
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_TreeSkinBreak_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315D1 RID: 202193
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040315D2 RID: 202194
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040315D3 RID: 202195
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040315D4 RID: 202196
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009DD4 RID: 40404
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040315D5 RID: 202197
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
