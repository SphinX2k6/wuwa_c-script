using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.KuroVolumetricVoxelFog
{
	// Token: 0x02003CFE RID: 15614
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/KuroVolumetricVoxelFog/BP_VoxelFog.BP_VoxelFog_C")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1172)]
	public class BP_VoxelFog_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602549B RID: 152731 RVA: 0x00956200 File Offset: 0x00954400
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VoxelFog_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/KuroVolumetricVoxelFog/BP_VoxelFog.BP_VoxelFog_C");
			}
			return BP_VoxelFog_C._ClassPtr;
		}

		// Token: 0x0602549C RID: 152732 RVA: 0x00956224 File Offset: 0x00954424
		public BP_VoxelFog_C() : this(BuiltinUtils.AllocNativeUObject(BP_VoxelFog_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602549D RID: 152733 RVA: 0x0095624C File Offset: 0x0095444C
		[NullableContext(1)]
		public BP_VoxelFog_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VoxelFog_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BCF RID: 19407
		// (get) Token: 0x0602549E RID: 152734 RVA: 0x0095627F File Offset: 0x0095447F
		// (set) Token: 0x0602549F RID: 152735 RVA: 0x00956293 File Offset: 0x00954493
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004BD0 RID: 19408
		// (get) Token: 0x060254A0 RID: 152736 RVA: 0x009562A8 File Offset: 0x009544A8
		// (set) Token: 0x060254A1 RID: 152737 RVA: 0x009562BC File Offset: 0x009544BC
		public unsafe UStaticMesh FogMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004BD1 RID: 19409
		// (get) Token: 0x060254A2 RID: 152738 RVA: 0x009562D1 File Offset: 0x009544D1
		// (set) Token: 0x060254A3 RID: 152739 RVA: 0x009562E1 File Offset: 0x009544E1
		public unsafe int FogXYScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004BD2 RID: 19410
		// (get) Token: 0x060254A4 RID: 152740 RVA: 0x009562F2 File Offset: 0x009544F2
		// (set) Token: 0x060254A5 RID: 152741 RVA: 0x00956302 File Offset: 0x00954502
		public unsafe int FogZScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x060254A6 RID: 152742 RVA: 0x00956313 File Offset: 0x00954513
		// (set) Token: 0x060254A7 RID: 152743 RVA: 0x00956327 File Offset: 0x00954527
		public unsafe UMaterialInstance M_VoxelFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x060254A8 RID: 152744 RVA: 0x0095633C File Offset: 0x0095453C
		// (set) Token: 0x060254A9 RID: 152745 RVA: 0x0095634C File Offset: 0x0095454C
		public unsafe float BaseNoiseCtrl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x060254AA RID: 152746 RVA: 0x0095635D File Offset: 0x0095455D
		// (set) Token: 0x060254AB RID: 152747 RVA: 0x0095636D File Offset: 0x0095456D
		public unsafe float BaseNoiseTill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x060254AC RID: 152748 RVA: 0x0095637E File Offset: 0x0095457E
		// (set) Token: 0x060254AD RID: 152749 RVA: 0x00956392 File Offset: 0x00954592
		public unsafe UTexture2D BaseNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x060254AE RID: 152750 RVA: 0x009563A7 File Offset: 0x009545A7
		// (set) Token: 0x060254AF RID: 152751 RVA: 0x009563B7 File Offset: 0x009545B7
		public unsafe float SideFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x060254B0 RID: 152752 RVA: 0x009563C8 File Offset: 0x009545C8
		// (set) Token: 0x060254B1 RID: 152753 RVA: 0x009563D8 File Offset: 0x009545D8
		public unsafe float Flatten
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004BD9 RID: 19417
		// (get) Token: 0x060254B2 RID: 152754 RVA: 0x009563E9 File Offset: 0x009545E9
		// (set) Token: 0x060254B3 RID: 152755 RVA: 0x009563F9 File Offset: 0x009545F9
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004BDA RID: 19418
		// (get) Token: 0x060254B4 RID: 152756 RVA: 0x0095640A File Offset: 0x0095460A
		// (set) Token: 0x060254B5 RID: 152757 RVA: 0x0095641A File Offset: 0x0095461A
		public unsafe float WindDirectionX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x060254B6 RID: 152758 RVA: 0x0095642B File Offset: 0x0095462B
		// (set) Token: 0x060254B7 RID: 152759 RVA: 0x0095643B File Offset: 0x0095463B
		public unsafe float WindDirectionY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x060254B8 RID: 152760 RVA: 0x0095644C File Offset: 0x0095464C
		// (set) Token: 0x060254B9 RID: 152761 RVA: 0x00956460 File Offset: 0x00954660
		public unsafe UTexture2D ShapeTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x060254BA RID: 152762 RVA: 0x00956475 File Offset: 0x00954675
		// (set) Token: 0x060254BB RID: 152763 RVA: 0x00956489 File Offset: 0x00954689
		public unsafe FColor FogTopColorOne
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x060254BC RID: 152764 RVA: 0x0095649E File Offset: 0x0095469E
		// (set) Token: 0x060254BD RID: 152765 RVA: 0x009564B2 File Offset: 0x009546B2
		public unsafe FColor FogTopColorTwo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x060254BE RID: 152766 RVA: 0x009564C7 File Offset: 0x009546C7
		// (set) Token: 0x060254BF RID: 152767 RVA: 0x009564DB File Offset: 0x009546DB
		public unsafe FColor FogBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x060254C0 RID: 152768 RVA: 0x009564F0 File Offset: 0x009546F0
		// (set) Token: 0x060254C1 RID: 152769 RVA: 0x00956500 File Offset: 0x00954700
		public unsafe float DetailNoiseCtrl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x060254C2 RID: 152770 RVA: 0x00956511 File Offset: 0x00954711
		// (set) Token: 0x060254C3 RID: 152771 RVA: 0x00956521 File Offset: 0x00954721
		public unsafe float DetailSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x060254C4 RID: 152772 RVA: 0x00956532 File Offset: 0x00954732
		// (set) Token: 0x060254C5 RID: 152773 RVA: 0x00956542 File Offset: 0x00954742
		public unsafe float DetailTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x060254C6 RID: 152774 RVA: 0x00956553 File Offset: 0x00954753
		// (set) Token: 0x060254C7 RID: 152775 RVA: 0x00956567 File Offset: 0x00954767
		public unsafe UTexture2D DetailNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VoxelFog_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004BE4 RID: 19428
		// (get) Token: 0x060254C8 RID: 152776 RVA: 0x0095657C File Offset: 0x0095477C
		// (set) Token: 0x060254C9 RID: 152777 RVA: 0x0095658C File Offset: 0x0095478C
		public unsafe float ColorGradient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004BE5 RID: 19429
		// (get) Token: 0x060254CA RID: 152778 RVA: 0x0095659D File Offset: 0x0095479D
		// (set) Token: 0x060254CB RID: 152779 RVA: 0x009565AD File Offset: 0x009547AD
		public unsafe float EmssiveInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004BE6 RID: 19430
		// (get) Token: 0x060254CC RID: 152780 RVA: 0x009565BE File Offset: 0x009547BE
		// (set) Token: 0x060254CD RID: 152781 RVA: 0x009565CE File Offset: 0x009547CE
		public unsafe float ShapeTexTill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004BE7 RID: 19431
		// (get) Token: 0x060254CE RID: 152782 RVA: 0x009565DF File Offset: 0x009547DF
		// (set) Token: 0x060254CF RID: 152783 RVA: 0x009565EF File Offset: 0x009547EF
		public unsafe float ShapeMoveX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004BE8 RID: 19432
		// (get) Token: 0x060254D0 RID: 152784 RVA: 0x00956600 File Offset: 0x00954800
		// (set) Token: 0x060254D1 RID: 152785 RVA: 0x00956610 File Offset: 0x00954810
		public unsafe float ShapeMoveY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VoxelFog_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x060254D2 RID: 152786 RVA: 0x00956621 File Offset: 0x00954821
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VoxelFog_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060254D3 RID: 152787 RVA: 0x00956635 File Offset: 0x00954835
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VoxelFog_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060254D4 RID: 152788 RVA: 0x0095664A File Offset: 0x0095484A
		protected BP_VoxelFog_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012968 RID: 76136
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/KuroVolumetricVoxelFog/BP_VoxelFog.BP_VoxelFog_C";

		// Token: 0x04012969 RID: 76137
		private static IntPtr _ClassPtr;

		// Token: 0x0401296A RID: 76138
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401296B RID: 76139
		internal static int __PropertyOffset_0;

		// Token: 0x0401296C RID: 76140
		internal static int __PropertyOffset_1;

		// Token: 0x0401296D RID: 76141
		internal static int __PropertyOffset_2;

		// Token: 0x0401296E RID: 76142
		internal static int __PropertyOffset_3;

		// Token: 0x0401296F RID: 76143
		internal static int __PropertyOffset_4;

		// Token: 0x04012970 RID: 76144
		internal static int __PropertyOffset_5;

		// Token: 0x04012971 RID: 76145
		internal static int __PropertyOffset_6;

		// Token: 0x04012972 RID: 76146
		internal static int __PropertyOffset_7;

		// Token: 0x04012973 RID: 76147
		internal static int __PropertyOffset_8;

		// Token: 0x04012974 RID: 76148
		internal static int __PropertyOffset_9;

		// Token: 0x04012975 RID: 76149
		internal static int __PropertyOffset_10;

		// Token: 0x04012976 RID: 76150
		internal static int __PropertyOffset_11;

		// Token: 0x04012977 RID: 76151
		internal static int __PropertyOffset_12;

		// Token: 0x04012978 RID: 76152
		internal static int __PropertyOffset_13;

		// Token: 0x04012979 RID: 76153
		internal static int __PropertyOffset_14;

		// Token: 0x0401297A RID: 76154
		internal static int __PropertyOffset_15;

		// Token: 0x0401297B RID: 76155
		internal static int __PropertyOffset_16;

		// Token: 0x0401297C RID: 76156
		internal static int __PropertyOffset_17;

		// Token: 0x0401297D RID: 76157
		internal static int __PropertyOffset_18;

		// Token: 0x0401297E RID: 76158
		internal static int __PropertyOffset_19;

		// Token: 0x0401297F RID: 76159
		internal static int __PropertyOffset_20;

		// Token: 0x04012980 RID: 76160
		internal static int __PropertyOffset_21;

		// Token: 0x04012981 RID: 76161
		internal static int __PropertyOffset_22;

		// Token: 0x04012982 RID: 76162
		internal static int __PropertyOffset_23;

		// Token: 0x04012983 RID: 76163
		internal static int __PropertyOffset_24;

		// Token: 0x04012984 RID: 76164
		internal static int __PropertyOffset_25;

		// Token: 0x04012985 RID: 76165
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
