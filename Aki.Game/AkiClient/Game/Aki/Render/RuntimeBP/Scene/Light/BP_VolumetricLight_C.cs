using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B29 RID: 15145
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLight.BP_VolumetricLight_C")]
	[UnrealStructLayout(1224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1224)]
	public class BP_VolumetricLight_C : AKuroLightActorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060215E6 RID: 136678 RVA: 0x008EAF11 File Offset: 0x008E9111
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLight.BP_VolumetricLight_C");
			}
			return BP_VolumetricLight_C._ClassPtr;
		}

		// Token: 0x060215E7 RID: 136679 RVA: 0x008EAF38 File Offset: 0x008E9138
		public BP_VolumetricLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060215E8 RID: 136680 RVA: 0x008EAF60 File Offset: 0x008E9160
		[NullableContext(1)]
		public BP_VolumetricLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x060215E9 RID: 136681 RVA: 0x008EAF93 File Offset: 0x008E9193
		// (set) Token: 0x060215EA RID: 136682 RVA: 0x008EAFA7 File Offset: 0x008E91A7
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x060215EB RID: 136683 RVA: 0x008EAFBC File Offset: 0x008E91BC
		// (set) Token: 0x060215EC RID: 136684 RVA: 0x008EAFD0 File Offset: 0x008E91D0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x060215ED RID: 136685 RVA: 0x008EAFE5 File Offset: 0x008E91E5
		// (set) Token: 0x060215EE RID: 136686 RVA: 0x008EAFF9 File Offset: 0x008E91F9
		public unsafe UStaticMesh StaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x060215EF RID: 136687 RVA: 0x008EB00E File Offset: 0x008E920E
		// (set) Token: 0x060215F0 RID: 136688 RVA: 0x008EB022 File Offset: 0x008E9222
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x060215F1 RID: 136689 RVA: 0x008EB037 File Offset: 0x008E9237
		// (set) Token: 0x060215F2 RID: 136690 RVA: 0x008EB04B File Offset: 0x008E924B
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x060215F3 RID: 136691 RVA: 0x008EB060 File Offset: 0x008E9260
		// (set) Token: 0x060215F4 RID: 136692 RVA: 0x008EB074 File Offset: 0x008E9274
		public unsafe UMaterialInstance MaterialInstanceBT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x060215F5 RID: 136693 RVA: 0x008EB089 File Offset: 0x008E9289
		// (set) Token: 0x060215F6 RID: 136694 RVA: 0x008EB09D File Offset: 0x008E929D
		public unsafe UMaterialInstance MaterialInstanceT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x060215F7 RID: 136695 RVA: 0x008EB0B2 File Offset: 0x008E92B2
		// (set) Token: 0x060215F8 RID: 136696 RVA: 0x008EB0C2 File Offset: 0x008E92C2
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x060215F9 RID: 136697 RVA: 0x008EB0D3 File Offset: 0x008E92D3
		// (set) Token: 0x060215FA RID: 136698 RVA: 0x008EB0E3 File Offset: 0x008E92E3
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x060215FB RID: 136699 RVA: 0x008EB0F4 File Offset: 0x008E92F4
		// (set) Token: 0x060215FC RID: 136700 RVA: 0x008EB104 File Offset: 0x008E9304
		public unsafe bool EnableFlickent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x060215FD RID: 136701 RVA: 0x008EB115 File Offset: 0x008E9315
		// (set) Token: 0x060215FE RID: 136702 RVA: 0x008EB125 File Offset: 0x008E9325
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x060215FF RID: 136703 RVA: 0x008EB136 File Offset: 0x008E9336
		// (set) Token: 0x06021600 RID: 136704 RVA: 0x008EB146 File Offset: 0x008E9346
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x06021601 RID: 136705 RVA: 0x008EB157 File Offset: 0x008E9357
		// (set) Token: 0x06021602 RID: 136706 RVA: 0x008EB167 File Offset: 0x008E9367
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x06021603 RID: 136707 RVA: 0x008EB178 File Offset: 0x008E9378
		// (set) Token: 0x06021604 RID: 136708 RVA: 0x008EB188 File Offset: 0x008E9388
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x06021605 RID: 136709 RVA: 0x008EB199 File Offset: 0x008E9399
		// (set) Token: 0x06021606 RID: 136710 RVA: 0x008EB1AD File Offset: 0x008E93AD
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x06021607 RID: 136711 RVA: 0x008EB1C2 File Offset: 0x008E93C2
		// (set) Token: 0x06021608 RID: 136712 RVA: 0x008EB1D6 File Offset: 0x008E93D6
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x06021609 RID: 136713 RVA: 0x008EB1EB File Offset: 0x008E93EB
		// (set) Token: 0x0602160A RID: 136714 RVA: 0x008EB1FB File Offset: 0x008E93FB
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0602160B RID: 136715 RVA: 0x008EB20C File Offset: 0x008E940C
		// (set) Token: 0x0602160C RID: 136716 RVA: 0x008EB21C File Offset: 0x008E941C
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0602160D RID: 136717 RVA: 0x008EB22D File Offset: 0x008E942D
		// (set) Token: 0x0602160E RID: 136718 RVA: 0x008EB23D File Offset: 0x008E943D
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0602160F RID: 136719 RVA: 0x008EB24E File Offset: 0x008E944E
		// (set) Token: 0x06021610 RID: 136720 RVA: 0x008EB25E File Offset: 0x008E945E
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x06021611 RID: 136721 RVA: 0x008EB26F File Offset: 0x008E946F
		// (set) Token: 0x06021612 RID: 136722 RVA: 0x008EB27F File Offset: 0x008E947F
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x06021613 RID: 136723 RVA: 0x008EB290 File Offset: 0x008E9490
		// (set) Token: 0x06021614 RID: 136724 RVA: 0x008EB2A0 File Offset: 0x008E94A0
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x06021615 RID: 136725 RVA: 0x008EB2B1 File Offset: 0x008E94B1
		// (set) Token: 0x06021616 RID: 136726 RVA: 0x008EB2C1 File Offset: 0x008E94C1
		public unsafe float LightStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x06021617 RID: 136727 RVA: 0x008EB2D2 File Offset: 0x008E94D2
		// (set) Token: 0x06021618 RID: 136728 RVA: 0x008EB2E2 File Offset: 0x008E94E2
		public unsafe float NearFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x06021619 RID: 136729 RVA: 0x008EB2F3 File Offset: 0x008E94F3
		// (set) Token: 0x0602161A RID: 136730 RVA: 0x008EB303 File Offset: 0x008E9503
		public unsafe float FullIntLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0602161B RID: 136731 RVA: 0x008EB314 File Offset: 0x008E9514
		// (set) Token: 0x0602161C RID: 136732 RVA: 0x008EB324 File Offset: 0x008E9524
		public unsafe float FarFadeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricLight_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0602161D RID: 136733 RVA: 0x008EB335 File Offset: 0x008E9535
		// (set) Token: 0x0602161E RID: 136734 RVA: 0x008EB349 File Offset: 0x008E9549
		public unsafe UMaterialInstanceDynamic DynMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricLight_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x0602161F RID: 136735 RVA: 0x008EB35E File Offset: 0x008E955E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021620 RID: 136736 RVA: 0x008EB372 File Offset: 0x008E9572
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021621 RID: 136737 RVA: 0x008EB388 File Offset: 0x008E9588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void SetLightIntensityScale(float ScaleFactor)
		{
			BP_VolumetricLight_C.__SetLightIntensityScale_FunctionParams* ptr = stackalloc BP_VolumetricLight_C.__SetLightIntensityScale_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricLight_C.__SetLightIntensityScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricLight_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScaleFactor = ScaleFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricLight_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021622 RID: 136738 RVA: 0x008EB3D0 File Offset: 0x008E95D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void SetLightIntensityScale_Implementation(float ScaleFactor)
		{
			BP_VolumetricLight_C.__SetLightIntensityScale_FunctionParams* ptr = stackalloc BP_VolumetricLight_C.__SetLightIntensityScale_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricLight_C.__SetLightIntensityScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricLight_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScaleFactor = ScaleFactor;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricLight_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021623 RID: 136739 RVA: 0x008EB417 File Offset: 0x008E9617
		protected BP_VolumetricLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010408 RID: 66568
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricLight.BP_VolumetricLight_C";

		// Token: 0x04010409 RID: 66569
		private static IntPtr _ClassPtr;

		// Token: 0x0401040A RID: 66570
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401040B RID: 66571
		internal static int __PropertyOffset_1;

		// Token: 0x0401040C RID: 66572
		internal static int __PropertyOffset_2;

		// Token: 0x0401040D RID: 66573
		internal static int __PropertyOffset_3;

		// Token: 0x0401040E RID: 66574
		internal static int __PropertyOffset_4;

		// Token: 0x0401040F RID: 66575
		internal static int __PropertyOffset_5;

		// Token: 0x04010410 RID: 66576
		internal static int __PropertyOffset_6;

		// Token: 0x04010411 RID: 66577
		internal static int __PropertyOffset_7;

		// Token: 0x04010412 RID: 66578
		internal static int __PropertyOffset_8;

		// Token: 0x04010413 RID: 66579
		internal static int __PropertyOffset_9;

		// Token: 0x04010414 RID: 66580
		internal static int __PropertyOffset_10;

		// Token: 0x04010415 RID: 66581
		internal static int __PropertyOffset_11;

		// Token: 0x04010416 RID: 66582
		internal static int __PropertyOffset_12;

		// Token: 0x04010417 RID: 66583
		internal static int __PropertyOffset_13;

		// Token: 0x04010418 RID: 66584
		internal static int __PropertyOffset_14;

		// Token: 0x04010419 RID: 66585
		internal static int __PropertyOffset_15;

		// Token: 0x0401041A RID: 66586
		internal static int __PropertyOffset_16;

		// Token: 0x0401041B RID: 66587
		internal static int __PropertyOffset_17;

		// Token: 0x0401041C RID: 66588
		internal static int __PropertyOffset_18;

		// Token: 0x0401041D RID: 66589
		internal static int __PropertyOffset_19;

		// Token: 0x0401041E RID: 66590
		internal static int __PropertyOffset_20;

		// Token: 0x0401041F RID: 66591
		internal static int __PropertyOffset_21;

		// Token: 0x04010420 RID: 66592
		internal static int __PropertyOffset_22;

		// Token: 0x04010421 RID: 66593
		internal static int __PropertyOffset_23;

		// Token: 0x04010422 RID: 66594
		internal static int __PropertyOffset_24;

		// Token: 0x04010423 RID: 66595
		internal static int __PropertyOffset_25;

		// Token: 0x04010424 RID: 66596
		internal static int __PropertyOffset_26;

		// Token: 0x04010425 RID: 66597
		internal static int __PropertyOffset_27;

		// Token: 0x04010426 RID: 66598
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010427 RID: 66599
		private static IntPtr __SetLightIntensityScale_NativeFunctionPtr;

		// Token: 0x02009C8B RID: 40075
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __SetLightIntensityScale_FunctionParams
		{
			// Token: 0x04031349 RID: 201545
			[FieldOffset(0)]
			public float ScaleFactor;
		}
	}
}
