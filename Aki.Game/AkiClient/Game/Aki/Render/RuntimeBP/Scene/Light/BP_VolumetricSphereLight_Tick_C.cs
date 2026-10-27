using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B2D RID: 15149
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLight_Tick.BP_VolumetricSphereLight_Tick_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class BP_VolumetricSphereLight_Tick_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021728 RID: 137000 RVA: 0x008ECA30 File Offset: 0x008EAC30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricSphereLight_Tick_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLight_Tick.BP_VolumetricSphereLight_Tick_C");
			}
			return BP_VolumetricSphereLight_Tick_C._ClassPtr;
		}

		// Token: 0x06021729 RID: 137001 RVA: 0x008ECA54 File Offset: 0x008EAC54
		public BP_VolumetricSphereLight_Tick_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricSphereLight_Tick_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602172A RID: 137002 RVA: 0x008ECA7C File Offset: 0x008EAC7C
		[NullableContext(1)]
		public BP_VolumetricSphereLight_Tick_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricSphereLight_Tick_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0602172B RID: 137003 RVA: 0x008ECAAF File Offset: 0x008EACAF
		// (set) Token: 0x0602172C RID: 137004 RVA: 0x008ECAC3 File Offset: 0x008EACC3
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0602172D RID: 137005 RVA: 0x008ECAD8 File Offset: 0x008EACD8
		// (set) Token: 0x0602172E RID: 137006 RVA: 0x008ECAEC File Offset: 0x008EACEC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0602172F RID: 137007 RVA: 0x008ECB01 File Offset: 0x008EAD01
		// (set) Token: 0x06021730 RID: 137008 RVA: 0x008ECB15 File Offset: 0x008EAD15
		public unsafe UStaticMesh SphereLightStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x06021731 RID: 137009 RVA: 0x008ECB2A File Offset: 0x008EAD2A
		// (set) Token: 0x06021732 RID: 137010 RVA: 0x008ECB3E File Offset: 0x008EAD3E
		public unsafe UMaterialInstance SphereLightMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x06021733 RID: 137011 RVA: 0x008ECB53 File Offset: 0x008EAD53
		// (set) Token: 0x06021734 RID: 137012 RVA: 0x008ECB63 File Offset: 0x008EAD63
		public unsafe bool IsReverseCulling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x06021735 RID: 137013 RVA: 0x008ECB74 File Offset: 0x008EAD74
		// (set) Token: 0x06021736 RID: 137014 RVA: 0x008ECB84 File Offset: 0x008EAD84
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x06021737 RID: 137015 RVA: 0x008ECB95 File Offset: 0x008EAD95
		// (set) Token: 0x06021738 RID: 137016 RVA: 0x008ECBA5 File Offset: 0x008EADA5
		public unsafe bool OutDistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x06021739 RID: 137017 RVA: 0x008ECBB6 File Offset: 0x008EADB6
		// (set) Token: 0x0602173A RID: 137018 RVA: 0x008ECBC6 File Offset: 0x008EADC6
		public unsafe bool ApplyFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0602173B RID: 137019 RVA: 0x008ECBD7 File Offset: 0x008EADD7
		// (set) Token: 0x0602173C RID: 137020 RVA: 0x008ECBE7 File Offset: 0x008EADE7
		public unsafe bool IsTickIntenisty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0602173D RID: 137021 RVA: 0x008ECBF8 File Offset: 0x008EADF8
		// (set) Token: 0x0602173E RID: 137022 RVA: 0x008ECC08 File Offset: 0x008EAE08
		public unsafe float FogInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0602173F RID: 137023 RVA: 0x008ECC19 File Offset: 0x008EAE19
		// (set) Token: 0x06021740 RID: 137024 RVA: 0x008ECC29 File Offset: 0x008EAE29
		public unsafe float FogPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x06021741 RID: 137025 RVA: 0x008ECC3A File Offset: 0x008EAE3A
		// (set) Token: 0x06021742 RID: 137026 RVA: 0x008ECC4A File Offset: 0x008EAE4A
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x06021743 RID: 137027 RVA: 0x008ECC5B File Offset: 0x008EAE5B
		// (set) Token: 0x06021744 RID: 137028 RVA: 0x008ECC6B File Offset: 0x008EAE6B
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x06021745 RID: 137029 RVA: 0x008ECC7C File Offset: 0x008EAE7C
		// (set) Token: 0x06021746 RID: 137030 RVA: 0x008ECC90 File Offset: 0x008EAE90
		public unsafe FLinearColor InsideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x06021747 RID: 137031 RVA: 0x008ECCA5 File Offset: 0x008EAEA5
		// (set) Token: 0x06021748 RID: 137032 RVA: 0x008ECCB9 File Offset: 0x008EAEB9
		public unsafe FLinearColor OutSideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x06021749 RID: 137033 RVA: 0x008ECCCE File Offset: 0x008EAECE
		// (set) Token: 0x0602174A RID: 137034 RVA: 0x008ECCDE File Offset: 0x008EAEDE
		public unsafe float SphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0602174B RID: 137035 RVA: 0x008ECCEF File Offset: 0x008EAEEF
		// (set) Token: 0x0602174C RID: 137036 RVA: 0x008ECCFF File Offset: 0x008EAEFF
		public unsafe float LightStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0602174D RID: 137037 RVA: 0x008ECD10 File Offset: 0x008EAF10
		// (set) Token: 0x0602174E RID: 137038 RVA: 0x008ECD20 File Offset: 0x008EAF20
		public unsafe float NearFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0602174F RID: 137039 RVA: 0x008ECD31 File Offset: 0x008EAF31
		// (set) Token: 0x06021750 RID: 137040 RVA: 0x008ECD41 File Offset: 0x008EAF41
		public unsafe float FullIntLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x06021751 RID: 137041 RVA: 0x008ECD52 File Offset: 0x008EAF52
		// (set) Token: 0x06021752 RID: 137042 RVA: 0x008ECD62 File Offset: 0x008EAF62
		public unsafe float FarFadeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLight_Tick_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x06021753 RID: 137043 RVA: 0x008ECD73 File Offset: 0x008EAF73
		// (set) Token: 0x06021754 RID: 137044 RVA: 0x008ECD87 File Offset: 0x008EAF87
		public unsafe UMaterialInstanceDynamic MaterialInstanceDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x06021755 RID: 137045 RVA: 0x008ECD9C File Offset: 0x008EAF9C
		// (set) Token: 0x06021756 RID: 137046 RVA: 0x008ECDB0 File Offset: 0x008EAFB0
		public unsafe UMaterialInstance SphereLightMatWithOutDF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x06021757 RID: 137047 RVA: 0x008ECDC5 File Offset: 0x008EAFC5
		// (set) Token: 0x06021758 RID: 137048 RVA: 0x008ECDD9 File Offset: 0x008EAFD9
		public unsafe UMaterialInstance SphereLightMatWithOutFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x06021759 RID: 137049 RVA: 0x008ECDEE File Offset: 0x008EAFEE
		// (set) Token: 0x0602175A RID: 137050 RVA: 0x008ECE02 File Offset: 0x008EB002
		public unsafe UMaterialInstance SphereLightMatWithOutDFWithOutFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLight_Tick_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x0602175B RID: 137051 RVA: 0x008ECE17 File Offset: 0x008EB017
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateVolumetricSphereLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__UpdateVolumetricSphereLight_NativeFunctionPtr, null);
		}

		// Token: 0x0602175C RID: 137052 RVA: 0x008ECE2B File Offset: 0x008EB02B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602175D RID: 137053 RVA: 0x008ECE3F File Offset: 0x008EB03F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602175E RID: 137054 RVA: 0x008ECE54 File Offset: 0x008EB054
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602175F RID: 137055 RVA: 0x008ECE68 File Offset: 0x008EB068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021760 RID: 137056 RVA: 0x008ECE80 File Offset: 0x008EB080
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricSphereLight_Tick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_Tick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_Tick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021761 RID: 137057 RVA: 0x008ECEC8 File Offset: 0x008EB0C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricSphereLight_Tick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_Tick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_Tick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021762 RID: 137058 RVA: 0x008ECF10 File Offset: 0x008EB110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VolumetricSphereLight_Tick_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_Tick_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_Tick_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021763 RID: 137059 RVA: 0x008ECF58 File Offset: 0x008EB158
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricSphereLight_Tick_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricSphereLight_Tick_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricSphereLight_Tick_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricSphereLight_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLight_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021764 RID: 137060 RVA: 0x008ECF9F File Offset: 0x008EB19F
		protected BP_VolumetricSphereLight_Tick_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040104B2 RID: 66738
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLight_Tick.BP_VolumetricSphereLight_Tick_C";

		// Token: 0x040104B3 RID: 66739
		private static IntPtr _ClassPtr;

		// Token: 0x040104B4 RID: 66740
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040104B5 RID: 66741
		internal static int __PropertyOffset_1;

		// Token: 0x040104B6 RID: 66742
		internal static int __PropertyOffset_2;

		// Token: 0x040104B7 RID: 66743
		internal static int __PropertyOffset_3;

		// Token: 0x040104B8 RID: 66744
		internal static int __PropertyOffset_4;

		// Token: 0x040104B9 RID: 66745
		internal static int __PropertyOffset_5;

		// Token: 0x040104BA RID: 66746
		internal static int __PropertyOffset_6;

		// Token: 0x040104BB RID: 66747
		internal static int __PropertyOffset_7;

		// Token: 0x040104BC RID: 66748
		internal static int __PropertyOffset_8;

		// Token: 0x040104BD RID: 66749
		internal static int __PropertyOffset_9;

		// Token: 0x040104BE RID: 66750
		internal static int __PropertyOffset_10;

		// Token: 0x040104BF RID: 66751
		internal static int __PropertyOffset_11;

		// Token: 0x040104C0 RID: 66752
		internal static int __PropertyOffset_12;

		// Token: 0x040104C1 RID: 66753
		internal static int __PropertyOffset_13;

		// Token: 0x040104C2 RID: 66754
		internal static int __PropertyOffset_14;

		// Token: 0x040104C3 RID: 66755
		internal static int __PropertyOffset_15;

		// Token: 0x040104C4 RID: 66756
		internal static int __PropertyOffset_16;

		// Token: 0x040104C5 RID: 66757
		internal static int __PropertyOffset_17;

		// Token: 0x040104C6 RID: 66758
		internal static int __PropertyOffset_18;

		// Token: 0x040104C7 RID: 66759
		internal static int __PropertyOffset_19;

		// Token: 0x040104C8 RID: 66760
		internal static int __PropertyOffset_20;

		// Token: 0x040104C9 RID: 66761
		internal static int __PropertyOffset_21;

		// Token: 0x040104CA RID: 66762
		internal static int __PropertyOffset_22;

		// Token: 0x040104CB RID: 66763
		internal static int __PropertyOffset_23;

		// Token: 0x040104CC RID: 66764
		internal static int __PropertyOffset_24;

		// Token: 0x040104CD RID: 66765
		private static IntPtr __UpdateVolumetricSphereLight_NativeFunctionPtr;

		// Token: 0x040104CE RID: 66766
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040104CF RID: 66767
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040104D0 RID: 66768
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040104D1 RID: 66769
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C92 RID: 40082
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031350 RID: 201552
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C93 RID: 40083
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031351 RID: 201553
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
