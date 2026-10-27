using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B2A RID: 15146
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLightLaunchScene.BP_VolumetricSphereLightLaunchScene_C")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class BP_VolumetricSphereLightLaunchScene_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021624 RID: 136740 RVA: 0x008EB420 File Offset: 0x008E9620
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricSphereLightLaunchScene_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLightLaunchScene.BP_VolumetricSphereLightLaunchScene_C");
			}
			return BP_VolumetricSphereLightLaunchScene_C._ClassPtr;
		}

		// Token: 0x06021625 RID: 136741 RVA: 0x008EB444 File Offset: 0x008E9644
		public BP_VolumetricSphereLightLaunchScene_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricSphereLightLaunchScene_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021626 RID: 136742 RVA: 0x008EB46C File Offset: 0x008E966C
		[NullableContext(1)]
		public BP_VolumetricSphereLightLaunchScene_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricSphereLightLaunchScene_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x06021627 RID: 136743 RVA: 0x008EB49F File Offset: 0x008E969F
		// (set) Token: 0x06021628 RID: 136744 RVA: 0x008EB4B3 File Offset: 0x008E96B3
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x06021629 RID: 136745 RVA: 0x008EB4C8 File Offset: 0x008E96C8
		// (set) Token: 0x0602162A RID: 136746 RVA: 0x008EB4DC File Offset: 0x008E96DC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0602162B RID: 136747 RVA: 0x008EB4F1 File Offset: 0x008E96F1
		// (set) Token: 0x0602162C RID: 136748 RVA: 0x008EB505 File Offset: 0x008E9705
		public unsafe UStaticMesh SphereLightStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0602162D RID: 136749 RVA: 0x008EB51A File Offset: 0x008E971A
		// (set) Token: 0x0602162E RID: 136750 RVA: 0x008EB52E File Offset: 0x008E972E
		public unsafe UMaterialInstance SphereLightMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0602162F RID: 136751 RVA: 0x008EB543 File Offset: 0x008E9743
		// (set) Token: 0x06021630 RID: 136752 RVA: 0x008EB553 File Offset: 0x008E9753
		public unsafe bool IsReverseCulling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x06021631 RID: 136753 RVA: 0x008EB564 File Offset: 0x008E9764
		// (set) Token: 0x06021632 RID: 136754 RVA: 0x008EB574 File Offset: 0x008E9774
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x06021633 RID: 136755 RVA: 0x008EB585 File Offset: 0x008E9785
		// (set) Token: 0x06021634 RID: 136756 RVA: 0x008EB595 File Offset: 0x008E9795
		public unsafe bool OutDistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x06021635 RID: 136757 RVA: 0x008EB5A6 File Offset: 0x008E97A6
		// (set) Token: 0x06021636 RID: 136758 RVA: 0x008EB5B6 File Offset: 0x008E97B6
		public unsafe bool ApplyFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x06021637 RID: 136759 RVA: 0x008EB5C7 File Offset: 0x008E97C7
		// (set) Token: 0x06021638 RID: 136760 RVA: 0x008EB5D7 File Offset: 0x008E97D7
		public unsafe float FogInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x06021639 RID: 136761 RVA: 0x008EB5E8 File Offset: 0x008E97E8
		// (set) Token: 0x0602163A RID: 136762 RVA: 0x008EB5F8 File Offset: 0x008E97F8
		public unsafe float FogPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0602163B RID: 136763 RVA: 0x008EB609 File Offset: 0x008E9809
		// (set) Token: 0x0602163C RID: 136764 RVA: 0x008EB619 File Offset: 0x008E9819
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0602163D RID: 136765 RVA: 0x008EB62A File Offset: 0x008E982A
		// (set) Token: 0x0602163E RID: 136766 RVA: 0x008EB63A File Offset: 0x008E983A
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0602163F RID: 136767 RVA: 0x008EB64B File Offset: 0x008E984B
		// (set) Token: 0x06021640 RID: 136768 RVA: 0x008EB65F File Offset: 0x008E985F
		public unsafe FLinearColor InsideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x06021641 RID: 136769 RVA: 0x008EB674 File Offset: 0x008E9874
		// (set) Token: 0x06021642 RID: 136770 RVA: 0x008EB688 File Offset: 0x008E9888
		public unsafe FLinearColor OutSideColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x06021643 RID: 136771 RVA: 0x008EB69D File Offset: 0x008E989D
		// (set) Token: 0x06021644 RID: 136772 RVA: 0x008EB6AD File Offset: 0x008E98AD
		public unsafe float SphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x06021645 RID: 136773 RVA: 0x008EB6BE File Offset: 0x008E98BE
		// (set) Token: 0x06021646 RID: 136774 RVA: 0x008EB6CE File Offset: 0x008E98CE
		public unsafe float LightStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x06021647 RID: 136775 RVA: 0x008EB6DF File Offset: 0x008E98DF
		// (set) Token: 0x06021648 RID: 136776 RVA: 0x008EB6EF File Offset: 0x008E98EF
		public unsafe float NearFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x06021649 RID: 136777 RVA: 0x008EB700 File Offset: 0x008E9900
		// (set) Token: 0x0602164A RID: 136778 RVA: 0x008EB710 File Offset: 0x008E9910
		public unsafe float FullIntLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0602164B RID: 136779 RVA: 0x008EB721 File Offset: 0x008E9921
		// (set) Token: 0x0602164C RID: 136780 RVA: 0x008EB731 File Offset: 0x008E9931
		public unsafe float FarFadeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0602164D RID: 136781 RVA: 0x008EB742 File Offset: 0x008E9942
		// (set) Token: 0x0602164E RID: 136782 RVA: 0x008EB756 File Offset: 0x008E9956
		public unsafe UMaterialInstanceDynamic MaterialInstanceDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0602164F RID: 136783 RVA: 0x008EB76B File Offset: 0x008E996B
		// (set) Token: 0x06021650 RID: 136784 RVA: 0x008EB77F File Offset: 0x008E997F
		public unsafe UMaterialInstance SphereLightMatWithOutDF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x06021651 RID: 136785 RVA: 0x008EB794 File Offset: 0x008E9994
		// (set) Token: 0x06021652 RID: 136786 RVA: 0x008EB7A8 File Offset: 0x008E99A8
		public unsafe UMaterialInstance SphereLightMatWithOutFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x06021653 RID: 136787 RVA: 0x008EB7BD File Offset: 0x008E99BD
		// (set) Token: 0x06021654 RID: 136788 RVA: 0x008EB7D1 File Offset: 0x008E99D1
		public unsafe UMaterialInstance SphereLightMatWithOutDFWithOutFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricSphereLightLaunchScene_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x06021655 RID: 136789 RVA: 0x008EB7E6 File Offset: 0x008E99E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateVolumetricSphereLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightLaunchScene_C.__UpdateVolumetricSphereLight_NativeFunctionPtr, null);
		}

		// Token: 0x06021656 RID: 136790 RVA: 0x008EB7FA File Offset: 0x008E99FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightLaunchScene_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021657 RID: 136791 RVA: 0x008EB80E File Offset: 0x008E9A0E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLightLaunchScene_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021658 RID: 136792 RVA: 0x008EB823 File Offset: 0x008E9A23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricSphereLightLaunchScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021659 RID: 136793 RVA: 0x008EB837 File Offset: 0x008E9A37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricSphereLightLaunchScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602165A RID: 136794 RVA: 0x008EB84C File Offset: 0x008E9A4C
		protected BP_VolumetricSphereLightLaunchScene_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010428 RID: 66600
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricSphereLightLaunchScene.BP_VolumetricSphereLightLaunchScene_C";

		// Token: 0x04010429 RID: 66601
		private static IntPtr _ClassPtr;

		// Token: 0x0401042A RID: 66602
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401042B RID: 66603
		internal static int __PropertyOffset_1;

		// Token: 0x0401042C RID: 66604
		internal static int __PropertyOffset_2;

		// Token: 0x0401042D RID: 66605
		internal static int __PropertyOffset_3;

		// Token: 0x0401042E RID: 66606
		internal static int __PropertyOffset_4;

		// Token: 0x0401042F RID: 66607
		internal static int __PropertyOffset_5;

		// Token: 0x04010430 RID: 66608
		internal static int __PropertyOffset_6;

		// Token: 0x04010431 RID: 66609
		internal static int __PropertyOffset_7;

		// Token: 0x04010432 RID: 66610
		internal static int __PropertyOffset_8;

		// Token: 0x04010433 RID: 66611
		internal static int __PropertyOffset_9;

		// Token: 0x04010434 RID: 66612
		internal static int __PropertyOffset_10;

		// Token: 0x04010435 RID: 66613
		internal static int __PropertyOffset_11;

		// Token: 0x04010436 RID: 66614
		internal static int __PropertyOffset_12;

		// Token: 0x04010437 RID: 66615
		internal static int __PropertyOffset_13;

		// Token: 0x04010438 RID: 66616
		internal static int __PropertyOffset_14;

		// Token: 0x04010439 RID: 66617
		internal static int __PropertyOffset_15;

		// Token: 0x0401043A RID: 66618
		internal static int __PropertyOffset_16;

		// Token: 0x0401043B RID: 66619
		internal static int __PropertyOffset_17;

		// Token: 0x0401043C RID: 66620
		internal static int __PropertyOffset_18;

		// Token: 0x0401043D RID: 66621
		internal static int __PropertyOffset_19;

		// Token: 0x0401043E RID: 66622
		internal static int __PropertyOffset_20;

		// Token: 0x0401043F RID: 66623
		internal static int __PropertyOffset_21;

		// Token: 0x04010440 RID: 66624
		internal static int __PropertyOffset_22;

		// Token: 0x04010441 RID: 66625
		internal static int __PropertyOffset_23;

		// Token: 0x04010442 RID: 66626
		private static IntPtr __UpdateVolumetricSphereLight_NativeFunctionPtr;

		// Token: 0x04010443 RID: 66627
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010444 RID: 66628
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
