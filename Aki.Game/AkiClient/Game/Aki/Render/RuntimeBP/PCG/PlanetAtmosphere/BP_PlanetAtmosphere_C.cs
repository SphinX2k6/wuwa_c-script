using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PlanetAtmosphere
{
	// Token: 0x02003C33 RID: 15411
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PlanetAtmosphere/BP_PlanetAtmosphere.BP_PlanetAtmosphere_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1148)]
	public class BP_PlanetAtmosphere_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060236E7 RID: 145127 RVA: 0x00923BED File Offset: 0x00921DED
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlanetAtmosphere_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PlanetAtmosphere/BP_PlanetAtmosphere.BP_PlanetAtmosphere_C");
			}
			return BP_PlanetAtmosphere_C._ClassPtr;
		}

		// Token: 0x060236E8 RID: 145128 RVA: 0x00923C14 File Offset: 0x00921E14
		public BP_PlanetAtmosphere_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlanetAtmosphere_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060236E9 RID: 145129 RVA: 0x00923C3C File Offset: 0x00921E3C
		[NullableContext(1)]
		public BP_PlanetAtmosphere_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlanetAtmosphere_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700414A RID: 16714
		// (get) Token: 0x060236EA RID: 145130 RVA: 0x00923C6F File Offset: 0x00921E6F
		// (set) Token: 0x060236EB RID: 145131 RVA: 0x00923C83 File Offset: 0x00921E83
		public unsafe UStaticMeshComponent PlanetAtmosphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700414B RID: 16715
		// (get) Token: 0x060236EC RID: 145132 RVA: 0x00923C98 File Offset: 0x00921E98
		// (set) Token: 0x060236ED RID: 145133 RVA: 0x00923CAC File Offset: 0x00921EAC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x060236EE RID: 145134 RVA: 0x00923CC1 File Offset: 0x00921EC1
		// (set) Token: 0x060236EF RID: 145135 RVA: 0x00923CD5 File Offset: 0x00921ED5
		public unsafe UMaterialInstanceDynamic DMI_TransmitanceLut
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700414D RID: 16717
		// (get) Token: 0x060236F0 RID: 145136 RVA: 0x00923CEA File Offset: 0x00921EEA
		// (set) Token: 0x060236F1 RID: 145137 RVA: 0x00923CFE File Offset: 0x00921EFE
		public unsafe UMaterialInstanceDynamic DMI_PlanetAtmosphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x060236F2 RID: 145138 RVA: 0x00923D13 File Offset: 0x00921F13
		// (set) Token: 0x060236F3 RID: 145139 RVA: 0x00923D27 File Offset: 0x00921F27
		public unsafe UTexture2D AtmosphereLut
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlanetAtmosphere_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x060236F4 RID: 145140 RVA: 0x00923D3C File Offset: 0x00921F3C
		// (set) Token: 0x060236F5 RID: 145141 RVA: 0x00923D4C File Offset: 0x00921F4C
		public unsafe bool UseCustomLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x060236F6 RID: 145142 RVA: 0x00923D5D File Offset: 0x00921F5D
		// (set) Token: 0x060236F7 RID: 145143 RVA: 0x00923D6D File Offset: 0x00921F6D
		public unsafe bool UseFakeSky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x060236F8 RID: 145144 RVA: 0x00923D7E File Offset: 0x00921F7E
		// (set) Token: 0x060236F9 RID: 145145 RVA: 0x00923D92 File Offset: 0x00921F92
		public unsafe FRotator CustomLightDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x060236FA RID: 145146 RVA: 0x00923DA7 File Offset: 0x00921FA7
		// (set) Token: 0x060236FB RID: 145147 RVA: 0x00923DB7 File Offset: 0x00921FB7
		public unsafe float 星球半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x060236FC RID: 145148 RVA: 0x00923DC8 File Offset: 0x00921FC8
		// (set) Token: 0x060236FD RID: 145149 RVA: 0x00923DD8 File Offset: 0x00921FD8
		public unsafe float 大气厚度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x060236FE RID: 145150 RVA: 0x00923DE9 File Offset: 0x00921FE9
		// (set) Token: 0x060236FF RID: 145151 RVA: 0x00923DF9 File Offset: 0x00921FF9
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x06023700 RID: 145152 RVA: 0x00923E0A File Offset: 0x0092200A
		// (set) Token: 0x06023701 RID: 145153 RVA: 0x00923E1A File Offset: 0x0092201A
		public unsafe float DensityFallOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004156 RID: 16726
		// (get) Token: 0x06023702 RID: 145154 RVA: 0x00923E2B File Offset: 0x0092202B
		// (set) Token: 0x06023703 RID: 145155 RVA: 0x00923E3B File Offset: 0x0092203B
		public unsafe float ScatteringScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x06023704 RID: 145156 RVA: 0x00923E4C File Offset: 0x0092204C
		// (set) Token: 0x06023705 RID: 145157 RVA: 0x00923E5C File Offset: 0x0092205C
		public unsafe float Luminance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x06023706 RID: 145158 RVA: 0x00923E6D File Offset: 0x0092206D
		// (set) Token: 0x06023707 RID: 145159 RVA: 0x00923E81 File Offset: 0x00922081
		public unsafe FVector WaveLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlanetAtmosphere_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x06023708 RID: 145160 RVA: 0x00923E96 File Offset: 0x00922096
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Lut保存_确定好效果后再点()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlanetAtmosphere_C.__Lut保存_确定好效果后再点_NativeFunctionPtr, null);
		}

		// Token: 0x06023709 RID: 145161 RVA: 0x00923EAA File Offset: 0x009220AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Lut烘焙_调整下面参数后都需要点此按钮_()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlanetAtmosphere_C.__Lut烘焙_调整下面参数后都需要点此按钮__NativeFunctionPtr, null);
		}

		// Token: 0x0602370A RID: 145162 RVA: 0x00923EBE File Offset: 0x009220BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlanetAtmosphere_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602370B RID: 145163 RVA: 0x00923ED2 File Offset: 0x009220D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlanetAtmosphere_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602370C RID: 145164 RVA: 0x00923EE7 File Offset: 0x009220E7
		protected BP_PlanetAtmosphere_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117CE RID: 71630
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PlanetAtmosphere/BP_PlanetAtmosphere.BP_PlanetAtmosphere_C";

		// Token: 0x040117CF RID: 71631
		private static IntPtr _ClassPtr;

		// Token: 0x040117D0 RID: 71632
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117D1 RID: 71633
		internal static int __PropertyOffset_1;

		// Token: 0x040117D2 RID: 71634
		internal static int __PropertyOffset_2;

		// Token: 0x040117D3 RID: 71635
		internal static int __PropertyOffset_3;

		// Token: 0x040117D4 RID: 71636
		internal static int __PropertyOffset_4;

		// Token: 0x040117D5 RID: 71637
		internal static int __PropertyOffset_5;

		// Token: 0x040117D6 RID: 71638
		internal static int __PropertyOffset_6;

		// Token: 0x040117D7 RID: 71639
		internal static int __PropertyOffset_7;

		// Token: 0x040117D8 RID: 71640
		internal static int __PropertyOffset_8;

		// Token: 0x040117D9 RID: 71641
		internal static int __PropertyOffset_9;

		// Token: 0x040117DA RID: 71642
		internal static int __PropertyOffset_10;

		// Token: 0x040117DB RID: 71643
		internal static int __PropertyOffset_11;

		// Token: 0x040117DC RID: 71644
		internal static int __PropertyOffset_12;

		// Token: 0x040117DD RID: 71645
		internal static int __PropertyOffset_13;

		// Token: 0x040117DE RID: 71646
		internal static int __PropertyOffset_14;

		// Token: 0x040117DF RID: 71647
		internal static int __PropertyOffset_15;

		// Token: 0x040117E0 RID: 71648
		private static IntPtr __Lut保存_确定好效果后再点_NativeFunctionPtr;

		// Token: 0x040117E1 RID: 71649
		private static IntPtr __Lut烘焙_调整下面参数后都需要点此按钮__NativeFunctionPtr;

		// Token: 0x040117E2 RID: 71650
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
