using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x02003C41 RID: 15425
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels.BP_BridgeModels_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class BP_BridgeModels_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239F6 RID: 145910 RVA: 0x009284C9 File Offset: 0x009266C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BridgeModels_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels.BP_BridgeModels_C");
			}
			return BP_BridgeModels_C._ClassPtr;
		}

		// Token: 0x060239F7 RID: 145911 RVA: 0x009284F0 File Offset: 0x009266F0
		public BP_BridgeModels_C() : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239F8 RID: 145912 RVA: 0x00928518 File Offset: 0x00926718
		[NullableContext(1)]
		public BP_BridgeModels_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x060239F9 RID: 145913 RVA: 0x0092854B File Offset: 0x0092674B
		// (set) Token: 0x060239FA RID: 145914 RVA: 0x0092855F File Offset: 0x0092675F
		public unsafe UStaticMeshComponent Cube1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x060239FB RID: 145915 RVA: 0x00928574 File Offset: 0x00926774
		// (set) Token: 0x060239FC RID: 145916 RVA: 0x00928588 File Offset: 0x00926788
		public unsafe UStaticMeshComponent Cube3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x060239FD RID: 145917 RVA: 0x0092859D File Offset: 0x0092679D
		// (set) Token: 0x060239FE RID: 145918 RVA: 0x009285B1 File Offset: 0x009267B1
		public unsafe UStaticMeshComponent Cube6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x060239FF RID: 145919 RVA: 0x009285C6 File Offset: 0x009267C6
		// (set) Token: 0x06023A00 RID: 145920 RVA: 0x009285DA File Offset: 0x009267DA
		public unsafe UStaticMeshComponent Cube8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x06023A01 RID: 145921 RVA: 0x009285EF File Offset: 0x009267EF
		// (set) Token: 0x06023A02 RID: 145922 RVA: 0x00928603 File Offset: 0x00926803
		public unsafe UStaticMeshComponent Cube7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x06023A03 RID: 145923 RVA: 0x00928618 File Offset: 0x00926818
		// (set) Token: 0x06023A04 RID: 145924 RVA: 0x0092862C File Offset: 0x0092682C
		public unsafe UStaticMeshComponent Cube5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x06023A05 RID: 145925 RVA: 0x00928641 File Offset: 0x00926841
		// (set) Token: 0x06023A06 RID: 145926 RVA: 0x00928655 File Offset: 0x00926855
		public unsafe UStaticMeshComponent Cube2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x06023A07 RID: 145927 RVA: 0x0092866A File Offset: 0x0092686A
		// (set) Token: 0x06023A08 RID: 145928 RVA: 0x0092867E File Offset: 0x0092687E
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x06023A09 RID: 145929 RVA: 0x00928693 File Offset: 0x00926893
		// (set) Token: 0x06023A0A RID: 145930 RVA: 0x009286A7 File Offset: 0x009268A7
		public unsafe UChildActorComponent _05_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x06023A0B RID: 145931 RVA: 0x009286BC File Offset: 0x009268BC
		// (set) Token: 0x06023A0C RID: 145932 RVA: 0x009286D0 File Offset: 0x009268D0
		public unsafe UChildActorComponent _05_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x06023A0D RID: 145933 RVA: 0x009286E5 File Offset: 0x009268E5
		// (set) Token: 0x06023A0E RID: 145934 RVA: 0x009286F9 File Offset: 0x009268F9
		public unsafe UChildActorComponent _05_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x06023A0F RID: 145935 RVA: 0x0092870E File Offset: 0x0092690E
		// (set) Token: 0x06023A10 RID: 145936 RVA: 0x00928722 File Offset: 0x00926922
		public unsafe UChildActorComponent _05_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x06023A11 RID: 145937 RVA: 0x00928737 File Offset: 0x00926937
		// (set) Token: 0x06023A12 RID: 145938 RVA: 0x0092874B File Offset: 0x0092694B
		public unsafe UChildActorComponent _37_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x06023A13 RID: 145939 RVA: 0x00928760 File Offset: 0x00926960
		// (set) Token: 0x06023A14 RID: 145940 RVA: 0x00928774 File Offset: 0x00926974
		public unsafe UChildActorComponent _37_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x06023A15 RID: 145941 RVA: 0x00928789 File Offset: 0x00926989
		// (set) Token: 0x06023A16 RID: 145942 RVA: 0x0092879D File Offset: 0x0092699D
		public unsafe UChildActorComponent _27_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x06023A17 RID: 145943 RVA: 0x009287B2 File Offset: 0x009269B2
		// (set) Token: 0x06023A18 RID: 145944 RVA: 0x009287C6 File Offset: 0x009269C6
		public unsafe UChildActorComponent _27_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x06023A19 RID: 145945 RVA: 0x009287DB File Offset: 0x009269DB
		// (set) Token: 0x06023A1A RID: 145946 RVA: 0x009287EF File Offset: 0x009269EF
		public unsafe UChildActorComponent _15_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x06023A1B RID: 145947 RVA: 0x00928804 File Offset: 0x00926A04
		// (set) Token: 0x06023A1C RID: 145948 RVA: 0x00928818 File Offset: 0x00926A18
		public unsafe UChildActorComponent _15_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x06023A1D RID: 145949 RVA: 0x0092882D File Offset: 0x00926A2D
		// (set) Token: 0x06023A1E RID: 145950 RVA: 0x00928841 File Offset: 0x00926A41
		public unsafe UChildActorComponent _15_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x06023A1F RID: 145951 RVA: 0x00928856 File Offset: 0x00926A56
		// (set) Token: 0x06023A20 RID: 145952 RVA: 0x0092886A File Offset: 0x00926A6A
		public unsafe UChildActorComponent _15_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x06023A21 RID: 145953 RVA: 0x0092887F File Offset: 0x00926A7F
		// (set) Token: 0x06023A22 RID: 145954 RVA: 0x00928893 File Offset: 0x00926A93
		public unsafe UChildActorComponent _37_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x06023A23 RID: 145955 RVA: 0x009288A8 File Offset: 0x00926AA8
		// (set) Token: 0x06023A24 RID: 145956 RVA: 0x009288BC File Offset: 0x00926ABC
		public unsafe UChildActorComponent _37_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x06023A25 RID: 145957 RVA: 0x009288D1 File Offset: 0x00926AD1
		// (set) Token: 0x06023A26 RID: 145958 RVA: 0x009288E5 File Offset: 0x00926AE5
		public unsafe UChildActorComponent _27_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x06023A27 RID: 145959 RVA: 0x009288FA File Offset: 0x00926AFA
		// (set) Token: 0x06023A28 RID: 145960 RVA: 0x0092890E File Offset: 0x00926B0E
		public unsafe UChildActorComponent _27_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x06023A29 RID: 145961 RVA: 0x00928923 File Offset: 0x00926B23
		// (set) Token: 0x06023A2A RID: 145962 RVA: 0x00928937 File Offset: 0x00926B37
		public unsafe UStaticMeshComponent StaticMesh42
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x06023A2B RID: 145963 RVA: 0x0092894C File Offset: 0x00926B4C
		// (set) Token: 0x06023A2C RID: 145964 RVA: 0x00928960 File Offset: 0x00926B60
		public unsafe UStaticMeshComponent StaticMesh41
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x06023A2D RID: 145965 RVA: 0x00928975 File Offset: 0x00926B75
		// (set) Token: 0x06023A2E RID: 145966 RVA: 0x00928989 File Offset: 0x00926B89
		public unsafe UStaticMeshComponent StaticMesh40
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x06023A2F RID: 145967 RVA: 0x0092899E File Offset: 0x00926B9E
		// (set) Token: 0x06023A30 RID: 145968 RVA: 0x009289B2 File Offset: 0x00926BB2
		public unsafe UStaticMeshComponent StaticMesh39
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x06023A31 RID: 145969 RVA: 0x009289C7 File Offset: 0x00926BC7
		// (set) Token: 0x06023A32 RID: 145970 RVA: 0x009289DB File Offset: 0x00926BDB
		public unsafe UStaticMeshComponent StaticMesh38
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x06023A33 RID: 145971 RVA: 0x009289F0 File Offset: 0x00926BF0
		// (set) Token: 0x06023A34 RID: 145972 RVA: 0x00928A04 File Offset: 0x00926C04
		public unsafe UStaticMeshComponent StaticMesh37
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x06023A35 RID: 145973 RVA: 0x00928A19 File Offset: 0x00926C19
		// (set) Token: 0x06023A36 RID: 145974 RVA: 0x00928A2D File Offset: 0x00926C2D
		public unsafe UStaticMeshComponent StaticMesh36
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x06023A37 RID: 145975 RVA: 0x00928A42 File Offset: 0x00926C42
		// (set) Token: 0x06023A38 RID: 145976 RVA: 0x00928A56 File Offset: 0x00926C56
		public unsafe UStaticMeshComponent StaticMesh35
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x06023A39 RID: 145977 RVA: 0x00928A6B File Offset: 0x00926C6B
		// (set) Token: 0x06023A3A RID: 145978 RVA: 0x00928A7F File Offset: 0x00926C7F
		public unsafe UStaticMeshComponent StaticMesh34
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x06023A3B RID: 145979 RVA: 0x00928A94 File Offset: 0x00926C94
		// (set) Token: 0x06023A3C RID: 145980 RVA: 0x00928AA8 File Offset: 0x00926CA8
		public unsafe UStaticMeshComponent StaticMesh33
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x06023A3D RID: 145981 RVA: 0x00928ABD File Offset: 0x00926CBD
		// (set) Token: 0x06023A3E RID: 145982 RVA: 0x00928AD1 File Offset: 0x00926CD1
		public unsafe UStaticMeshComponent StaticMesh32
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x06023A3F RID: 145983 RVA: 0x00928AE6 File Offset: 0x00926CE6
		// (set) Token: 0x06023A40 RID: 145984 RVA: 0x00928AFA File Offset: 0x00926CFA
		public unsafe UStaticMeshComponent StaticMesh31
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x06023A41 RID: 145985 RVA: 0x00928B0F File Offset: 0x00926D0F
		// (set) Token: 0x06023A42 RID: 145986 RVA: 0x00928B23 File Offset: 0x00926D23
		public unsafe UStaticMeshComponent StaticMesh30
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x06023A43 RID: 145987 RVA: 0x00928B38 File Offset: 0x00926D38
		// (set) Token: 0x06023A44 RID: 145988 RVA: 0x00928B4C File Offset: 0x00926D4C
		public unsafe UStaticMeshComponent StaticMesh29
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x06023A45 RID: 145989 RVA: 0x00928B61 File Offset: 0x00926D61
		// (set) Token: 0x06023A46 RID: 145990 RVA: 0x00928B75 File Offset: 0x00926D75
		public unsafe UStaticMeshComponent StaticMesh28
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x06023A47 RID: 145991 RVA: 0x00928B8A File Offset: 0x00926D8A
		// (set) Token: 0x06023A48 RID: 145992 RVA: 0x00928B9E File Offset: 0x00926D9E
		public unsafe UStaticMeshComponent StaticMesh27
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x06023A49 RID: 145993 RVA: 0x00928BB3 File Offset: 0x00926DB3
		// (set) Token: 0x06023A4A RID: 145994 RVA: 0x00928BC7 File Offset: 0x00926DC7
		public unsafe UStaticMeshComponent StaticMesh26
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x06023A4B RID: 145995 RVA: 0x00928BDC File Offset: 0x00926DDC
		// (set) Token: 0x06023A4C RID: 145996 RVA: 0x00928BF0 File Offset: 0x00926DF0
		public unsafe UStaticMeshComponent StaticMesh25
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x06023A4D RID: 145997 RVA: 0x00928C05 File Offset: 0x00926E05
		// (set) Token: 0x06023A4E RID: 145998 RVA: 0x00928C19 File Offset: 0x00926E19
		public unsafe UStaticMeshComponent StaticMesh24
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x06023A4F RID: 145999 RVA: 0x00928C2E File Offset: 0x00926E2E
		// (set) Token: 0x06023A50 RID: 146000 RVA: 0x00928C42 File Offset: 0x00926E42
		public unsafe UStaticMeshComponent StaticMesh23
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x06023A51 RID: 146001 RVA: 0x00928C57 File Offset: 0x00926E57
		// (set) Token: 0x06023A52 RID: 146002 RVA: 0x00928C6B File Offset: 0x00926E6B
		public unsafe UStaticMeshComponent StaticMesh22
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x06023A53 RID: 146003 RVA: 0x00928C80 File Offset: 0x00926E80
		// (set) Token: 0x06023A54 RID: 146004 RVA: 0x00928C94 File Offset: 0x00926E94
		public unsafe UStaticMeshComponent StaticMesh21
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x06023A55 RID: 146005 RVA: 0x00928CA9 File Offset: 0x00926EA9
		// (set) Token: 0x06023A56 RID: 146006 RVA: 0x00928CBD File Offset: 0x00926EBD
		public unsafe UStaticMeshComponent StaticMesh20
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x06023A57 RID: 146007 RVA: 0x00928CD2 File Offset: 0x00926ED2
		// (set) Token: 0x06023A58 RID: 146008 RVA: 0x00928CE6 File Offset: 0x00926EE6
		public unsafe UStaticMeshComponent StaticMesh19
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x06023A59 RID: 146009 RVA: 0x00928CFB File Offset: 0x00926EFB
		// (set) Token: 0x06023A5A RID: 146010 RVA: 0x00928D0F File Offset: 0x00926F0F
		public unsafe UStaticMeshComponent StaticMesh18
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x06023A5B RID: 146011 RVA: 0x00928D24 File Offset: 0x00926F24
		// (set) Token: 0x06023A5C RID: 146012 RVA: 0x00928D38 File Offset: 0x00926F38
		public unsafe UStaticMeshComponent StaticMesh17
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x06023A5D RID: 146013 RVA: 0x00928D4D File Offset: 0x00926F4D
		// (set) Token: 0x06023A5E RID: 146014 RVA: 0x00928D61 File Offset: 0x00926F61
		public unsafe UStaticMeshComponent StaticMesh16
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x06023A5F RID: 146015 RVA: 0x00928D76 File Offset: 0x00926F76
		// (set) Token: 0x06023A60 RID: 146016 RVA: 0x00928D8A File Offset: 0x00926F8A
		public unsafe UStaticMeshComponent StaticMesh15
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_51);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_51, value);
			}
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x06023A61 RID: 146017 RVA: 0x00928D9F File Offset: 0x00926F9F
		// (set) Token: 0x06023A62 RID: 146018 RVA: 0x00928DB3 File Offset: 0x00926FB3
		public unsafe UStaticMeshComponent StaticMesh14
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_52);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_52, value);
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x06023A63 RID: 146019 RVA: 0x00928DC8 File Offset: 0x00926FC8
		// (set) Token: 0x06023A64 RID: 146020 RVA: 0x00928DDC File Offset: 0x00926FDC
		public unsafe UStaticMeshComponent StaticMesh13
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_53);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_53, value);
			}
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x06023A65 RID: 146021 RVA: 0x00928DF1 File Offset: 0x00926FF1
		// (set) Token: 0x06023A66 RID: 146022 RVA: 0x00928E05 File Offset: 0x00927005
		public unsafe UStaticMeshComponent StaticMesh12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_54);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_54, value);
			}
		}

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x06023A67 RID: 146023 RVA: 0x00928E1A File Offset: 0x0092701A
		// (set) Token: 0x06023A68 RID: 146024 RVA: 0x00928E2E File Offset: 0x0092702E
		public unsafe UStaticMeshComponent StaticMesh11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_55);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x06023A69 RID: 146025 RVA: 0x00928E43 File Offset: 0x00927043
		// (set) Token: 0x06023A6A RID: 146026 RVA: 0x00928E57 File Offset: 0x00927057
		public unsafe UStaticMeshComponent StaticMesh10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_56);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_56, value);
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x06023A6B RID: 146027 RVA: 0x00928E6C File Offset: 0x0092706C
		// (set) Token: 0x06023A6C RID: 146028 RVA: 0x00928E80 File Offset: 0x00927080
		public unsafe UStaticMeshComponent StaticMesh09
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x06023A6D RID: 146029 RVA: 0x00928E95 File Offset: 0x00927095
		// (set) Token: 0x06023A6E RID: 146030 RVA: 0x00928EA9 File Offset: 0x009270A9
		public unsafe UStaticMeshComponent StaticMesh08
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_58);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x06023A6F RID: 146031 RVA: 0x00928EBE File Offset: 0x009270BE
		// (set) Token: 0x06023A70 RID: 146032 RVA: 0x00928ED2 File Offset: 0x009270D2
		public unsafe UStaticMeshComponent StaticMesh07
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_59);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_59, value);
			}
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x06023A71 RID: 146033 RVA: 0x00928EE7 File Offset: 0x009270E7
		// (set) Token: 0x06023A72 RID: 146034 RVA: 0x00928EFB File Offset: 0x009270FB
		public unsafe UStaticMeshComponent StaticMesh06
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_60);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_60, value);
			}
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x06023A73 RID: 146035 RVA: 0x00928F10 File Offset: 0x00927110
		// (set) Token: 0x06023A74 RID: 146036 RVA: 0x00928F24 File Offset: 0x00927124
		public unsafe UStaticMeshComponent StaticMesh05
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_61);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_61, value);
			}
		}

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x06023A75 RID: 146037 RVA: 0x00928F39 File Offset: 0x00927139
		// (set) Token: 0x06023A76 RID: 146038 RVA: 0x00928F4D File Offset: 0x0092714D
		public unsafe UStaticMeshComponent StaticMesh04
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_62);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_62, value);
			}
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x06023A77 RID: 146039 RVA: 0x00928F62 File Offset: 0x00927162
		// (set) Token: 0x06023A78 RID: 146040 RVA: 0x00928F76 File Offset: 0x00927176
		public unsafe UStaticMeshComponent StaticMesh03
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x06023A79 RID: 146041 RVA: 0x00928F8B File Offset: 0x0092718B
		// (set) Token: 0x06023A7A RID: 146042 RVA: 0x00928F9F File Offset: 0x0092719F
		public unsafe UStaticMeshComponent StaticMesh02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_64);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x06023A7B RID: 146043 RVA: 0x00928FB4 File Offset: 0x009271B4
		// (set) Token: 0x06023A7C RID: 146044 RVA: 0x00928FC8 File Offset: 0x009271C8
		public unsafe UStaticMeshComponent StaticMesh01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x06023A7D RID: 146045 RVA: 0x00928FDD File Offset: 0x009271DD
		// (set) Token: 0x06023A7E RID: 146046 RVA: 0x00928FF1 File Offset: 0x009271F1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_66);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_C.__PropertyOffset_66, value);
			}
		}

		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x06023A7F RID: 146047 RVA: 0x00929008 File Offset: 0x00927208
		// (set) Token: 0x06023A80 RID: 146048 RVA: 0x00929041 File Offset: 0x00927241
		[Nullable(1)]
		public custom custom
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				custom result;
				if ((result = this._custom) == null)
				{
					result = (this._custom = new custom(base.NativePtr + (IntPtr)BP_BridgeModels_C.__PropertyOffset_67, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_BridgeModels_C.__PropertyOffset_67, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06023A81 RID: 146049 RVA: 0x00929064 File Offset: 0x00927264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetBridgeLink(int idx, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UChildActorComponent> tempArray1)
		{
			BP_BridgeModels_C.__GetBridgeLink_FunctionParams* ptr = stackalloc BP_BridgeModels_C.__GetBridgeLink_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_BridgeModels_C.__GetBridgeLink_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr, 1);
			ptr->idx = idx;
			TArray<UChildActorComponent> tarray = tempArray1;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->tempArray1);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr);
			TArray<UChildActorComponent> tarray2 = tempArray1;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->tempArray1);
			}
			UnrealReflectionUtils.DestroyStruct(BP_BridgeModels_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023A82 RID: 146050 RVA: 0x009290E6 File Offset: 0x009272E6
		protected BP_BridgeModels_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011978 RID: 72056
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels.BP_BridgeModels_C";

		// Token: 0x04011979 RID: 72057
		private static IntPtr _ClassPtr;

		// Token: 0x0401197A RID: 72058
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401197B RID: 72059
		public static IntPtr __custom__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401197C RID: 72060
		internal static int __PropertyOffset_0;

		// Token: 0x0401197D RID: 72061
		internal static int __PropertyOffset_1;

		// Token: 0x0401197E RID: 72062
		internal static int __PropertyOffset_2;

		// Token: 0x0401197F RID: 72063
		internal static int __PropertyOffset_3;

		// Token: 0x04011980 RID: 72064
		internal static int __PropertyOffset_4;

		// Token: 0x04011981 RID: 72065
		internal static int __PropertyOffset_5;

		// Token: 0x04011982 RID: 72066
		internal static int __PropertyOffset_6;

		// Token: 0x04011983 RID: 72067
		internal static int __PropertyOffset_7;

		// Token: 0x04011984 RID: 72068
		internal static int __PropertyOffset_8;

		// Token: 0x04011985 RID: 72069
		internal static int __PropertyOffset_9;

		// Token: 0x04011986 RID: 72070
		internal static int __PropertyOffset_10;

		// Token: 0x04011987 RID: 72071
		internal static int __PropertyOffset_11;

		// Token: 0x04011988 RID: 72072
		internal static int __PropertyOffset_12;

		// Token: 0x04011989 RID: 72073
		internal static int __PropertyOffset_13;

		// Token: 0x0401198A RID: 72074
		internal static int __PropertyOffset_14;

		// Token: 0x0401198B RID: 72075
		internal static int __PropertyOffset_15;

		// Token: 0x0401198C RID: 72076
		internal static int __PropertyOffset_16;

		// Token: 0x0401198D RID: 72077
		internal static int __PropertyOffset_17;

		// Token: 0x0401198E RID: 72078
		internal static int __PropertyOffset_18;

		// Token: 0x0401198F RID: 72079
		internal static int __PropertyOffset_19;

		// Token: 0x04011990 RID: 72080
		internal static int __PropertyOffset_20;

		// Token: 0x04011991 RID: 72081
		internal static int __PropertyOffset_21;

		// Token: 0x04011992 RID: 72082
		internal static int __PropertyOffset_22;

		// Token: 0x04011993 RID: 72083
		internal static int __PropertyOffset_23;

		// Token: 0x04011994 RID: 72084
		internal static int __PropertyOffset_24;

		// Token: 0x04011995 RID: 72085
		internal static int __PropertyOffset_25;

		// Token: 0x04011996 RID: 72086
		internal static int __PropertyOffset_26;

		// Token: 0x04011997 RID: 72087
		internal static int __PropertyOffset_27;

		// Token: 0x04011998 RID: 72088
		internal static int __PropertyOffset_28;

		// Token: 0x04011999 RID: 72089
		internal static int __PropertyOffset_29;

		// Token: 0x0401199A RID: 72090
		internal static int __PropertyOffset_30;

		// Token: 0x0401199B RID: 72091
		internal static int __PropertyOffset_31;

		// Token: 0x0401199C RID: 72092
		internal static int __PropertyOffset_32;

		// Token: 0x0401199D RID: 72093
		internal static int __PropertyOffset_33;

		// Token: 0x0401199E RID: 72094
		internal static int __PropertyOffset_34;

		// Token: 0x0401199F RID: 72095
		internal static int __PropertyOffset_35;

		// Token: 0x040119A0 RID: 72096
		internal static int __PropertyOffset_36;

		// Token: 0x040119A1 RID: 72097
		internal static int __PropertyOffset_37;

		// Token: 0x040119A2 RID: 72098
		internal static int __PropertyOffset_38;

		// Token: 0x040119A3 RID: 72099
		internal static int __PropertyOffset_39;

		// Token: 0x040119A4 RID: 72100
		internal static int __PropertyOffset_40;

		// Token: 0x040119A5 RID: 72101
		internal static int __PropertyOffset_41;

		// Token: 0x040119A6 RID: 72102
		internal static int __PropertyOffset_42;

		// Token: 0x040119A7 RID: 72103
		internal static int __PropertyOffset_43;

		// Token: 0x040119A8 RID: 72104
		internal static int __PropertyOffset_44;

		// Token: 0x040119A9 RID: 72105
		internal static int __PropertyOffset_45;

		// Token: 0x040119AA RID: 72106
		internal static int __PropertyOffset_46;

		// Token: 0x040119AB RID: 72107
		internal static int __PropertyOffset_47;

		// Token: 0x040119AC RID: 72108
		internal static int __PropertyOffset_48;

		// Token: 0x040119AD RID: 72109
		internal static int __PropertyOffset_49;

		// Token: 0x040119AE RID: 72110
		internal static int __PropertyOffset_50;

		// Token: 0x040119AF RID: 72111
		internal static int __PropertyOffset_51;

		// Token: 0x040119B0 RID: 72112
		internal static int __PropertyOffset_52;

		// Token: 0x040119B1 RID: 72113
		internal static int __PropertyOffset_53;

		// Token: 0x040119B2 RID: 72114
		internal static int __PropertyOffset_54;

		// Token: 0x040119B3 RID: 72115
		internal static int __PropertyOffset_55;

		// Token: 0x040119B4 RID: 72116
		internal static int __PropertyOffset_56;

		// Token: 0x040119B5 RID: 72117
		internal static int __PropertyOffset_57;

		// Token: 0x040119B6 RID: 72118
		internal static int __PropertyOffset_58;

		// Token: 0x040119B7 RID: 72119
		internal static int __PropertyOffset_59;

		// Token: 0x040119B8 RID: 72120
		internal static int __PropertyOffset_60;

		// Token: 0x040119B9 RID: 72121
		internal static int __PropertyOffset_61;

		// Token: 0x040119BA RID: 72122
		internal static int __PropertyOffset_62;

		// Token: 0x040119BB RID: 72123
		internal static int __PropertyOffset_63;

		// Token: 0x040119BC RID: 72124
		internal static int __PropertyOffset_64;

		// Token: 0x040119BD RID: 72125
		internal static int __PropertyOffset_65;

		// Token: 0x040119BE RID: 72126
		internal static int __PropertyOffset_66;

		// Token: 0x040119BF RID: 72127
		internal static int __PropertyOffset_67;

		// Token: 0x040119C0 RID: 72128
		private custom _custom;

		// Token: 0x040119C1 RID: 72129
		private static IntPtr __GetBridgeLink_NativeFunctionPtr;

		// Token: 0x02009E7E RID: 40574
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __GetBridgeLink_FunctionParams
		{
			// Token: 0x0403171D RID: 202525
			[FieldOffset(0)]
			public int idx;

			// Token: 0x0403171E RID: 202526
			[FieldOffset(8)]
			public byte tempArray1;
		}
	}
}
