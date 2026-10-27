using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader.GuideSpriteDecal.Bak
{
	// Token: 0x02003C08 RID: 15368
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/Bak/BP_GuideSpriteDecal_PointLight.BP_GuideSpriteDecal_PointLight_C")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1644)]
	public class BP_GuideSpriteDecal_PointLight_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023094 RID: 143508 RVA: 0x00918E6A File Offset: 0x0091706A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GuideSpriteDecal_PointLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/Bak/BP_GuideSpriteDecal_PointLight.BP_GuideSpriteDecal_PointLight_C");
			}
			return BP_GuideSpriteDecal_PointLight_C._ClassPtr;
		}

		// Token: 0x06023095 RID: 143509 RVA: 0x00918E90 File Offset: 0x00917090
		public BP_GuideSpriteDecal_PointLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_GuideSpriteDecal_PointLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023096 RID: 143510 RVA: 0x00918EB8 File Offset: 0x009170B8
		[NullableContext(1)]
		public BP_GuideSpriteDecal_PointLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GuideSpriteDecal_PointLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x06023097 RID: 143511 RVA: 0x00918EEB File Offset: 0x009170EB
		// (set) Token: 0x06023098 RID: 143512 RVA: 0x00918EFF File Offset: 0x009170FF
		public unsafe UTextRenderComponent GuideSpline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x06023099 RID: 143513 RVA: 0x00918F14 File Offset: 0x00917114
		// (set) Token: 0x0602309A RID: 143514 RVA: 0x00918F28 File Offset: 0x00917128
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x0602309B RID: 143515 RVA: 0x00918F3D File Offset: 0x0091713D
		// (set) Token: 0x0602309C RID: 143516 RVA: 0x00918F51 File Offset: 0x00917151
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x0602309D RID: 143517 RVA: 0x00918F66 File Offset: 0x00917166
		// (set) Token: 0x0602309E RID: 143518 RVA: 0x00918F7A File Offset: 0x0091717A
		public unsafe UBoxComponent TriggerBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x0602309F RID: 143519 RVA: 0x00918F8F File Offset: 0x0091718F
		// (set) Token: 0x060230A0 RID: 143520 RVA: 0x00918FA3 File Offset: 0x009171A3
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x060230A1 RID: 143521 RVA: 0x00918FB8 File Offset: 0x009171B8
		// (set) Token: 0x060230A2 RID: 143522 RVA: 0x00918FCC File Offset: 0x009171CC
		public unsafe FVector Collision_Box_Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x060230A3 RID: 143523 RVA: 0x00918FE1 File Offset: 0x009171E1
		// (set) Token: 0x060230A4 RID: 143524 RVA: 0x00918FF1 File Offset: 0x009171F1
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x060230A5 RID: 143525 RVA: 0x00919002 File Offset: 0x00917202
		// (set) Token: 0x060230A6 RID: 143526 RVA: 0x00919012 File Offset: 0x00917212
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x060230A7 RID: 143527 RVA: 0x00919023 File Offset: 0x00917223
		// (set) Token: 0x060230A8 RID: 143528 RVA: 0x00919033 File Offset: 0x00917233
		public unsafe bool bShouldMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x060230A9 RID: 143529 RVA: 0x00919044 File Offset: 0x00917244
		// (set) Token: 0x060230AA RID: 143530 RVA: 0x00919059 File Offset: 0x00917259
		[Nullable(1)]
		public TSoftObjectPtr<ADecalActor> Decal
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<ADecalActor>(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_10, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x060230AB RID: 143531 RVA: 0x0091907E File Offset: 0x0091727E
		// (set) Token: 0x060230AC RID: 143532 RVA: 0x0091908E File Offset: 0x0091728E
		public unsafe float Decal_ProgressSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x060230AD RID: 143533 RVA: 0x0091909F File Offset: 0x0091729F
		// (set) Token: 0x060230AE RID: 143534 RVA: 0x009190AF File Offset: 0x009172AF
		public unsafe float Decal_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x060230AF RID: 143535 RVA: 0x009190C0 File Offset: 0x009172C0
		// (set) Token: 0x060230B0 RID: 143536 RVA: 0x009190D4 File Offset: 0x009172D4
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x060230B1 RID: 143537 RVA: 0x009190E9 File Offset: 0x009172E9
		// (set) Token: 0x060230B2 RID: 143538 RVA: 0x009190F9 File Offset: 0x009172F9
		public unsafe float Debug_Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x060230B3 RID: 143539 RVA: 0x0091910A File Offset: 0x0091730A
		// (set) Token: 0x060230B4 RID: 143540 RVA: 0x0091911A File Offset: 0x0091731A
		public unsafe bool Play_Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x060230B5 RID: 143541 RVA: 0x0091912B File Offset: 0x0091732B
		// (set) Token: 0x060230B6 RID: 143542 RVA: 0x0091913B File Offset: 0x0091733B
		public unsafe float MovementSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x060230B7 RID: 143543 RVA: 0x0091914C File Offset: 0x0091734C
		// (set) Token: 0x060230B8 RID: 143544 RVA: 0x0091915C File Offset: 0x0091735C
		public unsafe float CurrentDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x060230B9 RID: 143545 RVA: 0x0091916D File Offset: 0x0091736D
		// (set) Token: 0x060230BA RID: 143546 RVA: 0x00919181 File Offset: 0x00917381
		public unsafe FLinearColor Light_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x060230BB RID: 143547 RVA: 0x00919196 File Offset: 0x00917396
		// (set) Token: 0x060230BC RID: 143548 RVA: 0x009191A6 File Offset: 0x009173A6
		public unsafe float Attenuation_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x060230BD RID: 143549 RVA: 0x009191B7 File Offset: 0x009173B7
		// (set) Token: 0x060230BE RID: 143550 RVA: 0x009191C7 File Offset: 0x009173C7
		public unsafe float LightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x060230BF RID: 143551 RVA: 0x009191D8 File Offset: 0x009173D8
		// (set) Token: 0x060230C0 RID: 143552 RVA: 0x009191E8 File Offset: 0x009173E8
		public unsafe float PointLight_SpeedOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x060230C1 RID: 143553 RVA: 0x009191F9 File Offset: 0x009173F9
		// (set) Token: 0x060230C2 RID: 143554 RVA: 0x00919209 File Offset: 0x00917409
		public unsafe bool Debug_One
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x060230C3 RID: 143555 RVA: 0x0091921A File Offset: 0x0091741A
		// (set) Token: 0x060230C4 RID: 143556 RVA: 0x0091922A File Offset: 0x0091742A
		public unsafe float Progress_Point
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x060230C5 RID: 143557 RVA: 0x0091923B File Offset: 0x0091743B
		// (set) Token: 0x060230C6 RID: 143558 RVA: 0x0091924B File Offset: 0x0091744B
		public unsafe float LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x060230C7 RID: 143559 RVA: 0x0091925C File Offset: 0x0091745C
		// (set) Token: 0x060230C8 RID: 143560 RVA: 0x0091926C File Offset: 0x0091746C
		public unsafe float Decal_EmissiveStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_PointLight_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x060230C9 RID: 143561 RVA: 0x0091927D File Offset: 0x0091747D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Initialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x060230CA RID: 143562 RVA: 0x00919291 File Offset: 0x00917491
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060230CB RID: 143563 RVA: 0x009192A5 File Offset: 0x009174A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060230CC RID: 143564 RVA: 0x009192BC File Offset: 0x009174BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_47AF222149CCF672491DAAA954977259(UObject Loaded)
		{
			BP_GuideSpriteDecal_PointLight_C.__OnLoaded_47AF222149CCF672491DAAA954977259_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__OnLoaded_47AF222149CCF672491DAAA954977259_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__OnLoaded_47AF222149CCF672491DAAA954977259_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__OnLoaded_47AF222149CCF672491DAAA954977259_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__OnLoaded_47AF222149CCF672491DAAA954977259_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060230CD RID: 143565 RVA: 0x00919311 File Offset: 0x00917511
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060230CE RID: 143566 RVA: 0x00919325 File Offset: 0x00917525
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060230CF RID: 143567 RVA: 0x0091933C File Offset: 0x0091753C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060230D0 RID: 143568 RVA: 0x00919384 File Offset: 0x00917584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060230D1 RID: 143569 RVA: 0x009193CC File Offset: 0x009175CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060230D2 RID: 143570 RVA: 0x00919414 File Offset: 0x00917614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060230D3 RID: 143571 RVA: 0x0091945B File Offset: 0x0091765B
		protected BP_GuideSpriteDecal_PointLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011411 RID: 70673
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/Bak/BP_GuideSpriteDecal_PointLight.BP_GuideSpriteDecal_PointLight_C";

		// Token: 0x04011412 RID: 70674
		private static IntPtr _ClassPtr;

		// Token: 0x04011413 RID: 70675
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011414 RID: 70676
		internal static int __PropertyOffset_1;

		// Token: 0x04011415 RID: 70677
		internal static int __PropertyOffset_2;

		// Token: 0x04011416 RID: 70678
		internal static int __PropertyOffset_3;

		// Token: 0x04011417 RID: 70679
		internal static int __PropertyOffset_4;

		// Token: 0x04011418 RID: 70680
		internal static int __PropertyOffset_5;

		// Token: 0x04011419 RID: 70681
		internal static int __PropertyOffset_6;

		// Token: 0x0401141A RID: 70682
		internal static int __PropertyOffset_7;

		// Token: 0x0401141B RID: 70683
		internal static int __PropertyOffset_8;

		// Token: 0x0401141C RID: 70684
		internal static int __PropertyOffset_9;

		// Token: 0x0401141D RID: 70685
		internal static int __PropertyOffset_10;

		// Token: 0x0401141E RID: 70686
		internal static int __PropertyOffset_11;

		// Token: 0x0401141F RID: 70687
		internal static int __PropertyOffset_12;

		// Token: 0x04011420 RID: 70688
		internal static int __PropertyOffset_13;

		// Token: 0x04011421 RID: 70689
		internal static int __PropertyOffset_14;

		// Token: 0x04011422 RID: 70690
		internal static int __PropertyOffset_15;

		// Token: 0x04011423 RID: 70691
		internal static int __PropertyOffset_16;

		// Token: 0x04011424 RID: 70692
		internal static int __PropertyOffset_17;

		// Token: 0x04011425 RID: 70693
		internal static int __PropertyOffset_18;

		// Token: 0x04011426 RID: 70694
		internal static int __PropertyOffset_19;

		// Token: 0x04011427 RID: 70695
		internal static int __PropertyOffset_20;

		// Token: 0x04011428 RID: 70696
		internal static int __PropertyOffset_21;

		// Token: 0x04011429 RID: 70697
		internal static int __PropertyOffset_22;

		// Token: 0x0401142A RID: 70698
		internal static int __PropertyOffset_23;

		// Token: 0x0401142B RID: 70699
		internal static int __PropertyOffset_24;

		// Token: 0x0401142C RID: 70700
		internal static int __PropertyOffset_25;

		// Token: 0x0401142D RID: 70701
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0401142E RID: 70702
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401142F RID: 70703
		private static IntPtr __OnLoaded_47AF222149CCF672491DAAA954977259_NativeFunctionPtr;

		// Token: 0x04011430 RID: 70704
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011431 RID: 70705
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011432 RID: 70706
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E06 RID: 40454
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_47AF222149CCF672491DAAA954977259_FunctionParams
		{
			// Token: 0x0403162D RID: 202285
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x02009E07 RID: 40455
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403162E RID: 202286
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E08 RID: 40456
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403162F RID: 202287
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
