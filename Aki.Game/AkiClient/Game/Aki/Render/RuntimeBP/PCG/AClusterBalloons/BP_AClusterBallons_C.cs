using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AClusterBalloons
{
	// Token: 0x02003CE0 RID: 15584
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/BP_AClusterBallons.BP_AClusterBallons_C")]
	[UnrealStructLayout(2048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2048)]
	public class BP_AClusterBallons_C : AKuroCSBalloons, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602506D RID: 151661 RVA: 0x0094F114 File Offset: 0x0094D314
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AClusterBallons_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/BP_AClusterBallons.BP_AClusterBallons_C");
			}
			return BP_AClusterBallons_C._ClassPtr;
		}

		// Token: 0x0602506E RID: 151662 RVA: 0x0094F138 File Offset: 0x0094D338
		public BP_AClusterBallons_C() : this(BuiltinUtils.AllocNativeUObject(BP_AClusterBallons_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602506F RID: 151663 RVA: 0x0094F160 File Offset: 0x0094D360
		[NullableContext(1)]
		public BP_AClusterBallons_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AClusterBallons_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A6A RID: 19050
		// (get) Token: 0x06025070 RID: 151664 RVA: 0x0094F193 File Offset: 0x0094D393
		// (set) Token: 0x06025071 RID: 151665 RVA: 0x0094F1A7 File Offset: 0x0094D3A7
		public unsafe UStaticMeshComponent balloonBase
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004A6B RID: 19051
		// (get) Token: 0x06025072 RID: 151666 RVA: 0x0094F1BC File Offset: 0x0094D3BC
		// (set) Token: 0x06025073 RID: 151667 RVA: 0x0094F1D0 File Offset: 0x0094D3D0
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004A6C RID: 19052
		// (get) Token: 0x06025074 RID: 151668 RVA: 0x0094F1E5 File Offset: 0x0094D3E5
		// (set) Token: 0x06025075 RID: 151669 RVA: 0x0094F1F9 File Offset: 0x0094D3F9
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004A6D RID: 19053
		// (get) Token: 0x06025076 RID: 151670 RVA: 0x0094F20E File Offset: 0x0094D40E
		// (set) Token: 0x06025077 RID: 151671 RVA: 0x0094F222 File Offset: 0x0094D422
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004A6E RID: 19054
		// (get) Token: 0x06025078 RID: 151672 RVA: 0x0094F237 File Offset: 0x0094D437
		// (set) Token: 0x06025079 RID: 151673 RVA: 0x0094F24B File Offset: 0x0094D44B
		public unsafe PD_BakedBalloon_C DA_Bake
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_BakedBalloon_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004A6F RID: 19055
		// (get) Token: 0x0602507A RID: 151674 RVA: 0x0094F260 File Offset: 0x0094D460
		// (set) Token: 0x0602507B RID: 151675 RVA: 0x0094F274 File Offset: 0x0094D474
		public unsafe PD_SM_To_Balloon_C DA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_SM_To_Balloon_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004A70 RID: 19056
		// (get) Token: 0x0602507C RID: 151676 RVA: 0x0094F289 File Offset: 0x0094D489
		// (set) Token: 0x0602507D RID: 151677 RVA: 0x0094F29D File Offset: 0x0094D49D
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004A71 RID: 19057
		// (get) Token: 0x0602507E RID: 151678 RVA: 0x0094F2B2 File Offset: 0x0094D4B2
		// (set) Token: 0x0602507F RID: 151679 RVA: 0x0094F2C2 File Offset: 0x0094D4C2
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A72 RID: 19058
		// (get) Token: 0x06025080 RID: 151680 RVA: 0x0094F2D3 File Offset: 0x0094D4D3
		// (set) Token: 0x06025081 RID: 151681 RVA: 0x0094F2E7 File Offset: 0x0094D4E7
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004A73 RID: 19059
		// (get) Token: 0x06025082 RID: 151682 RVA: 0x0094F2FC File Offset: 0x0094D4FC
		// (set) Token: 0x06025083 RID: 151683 RVA: 0x0094F30C File Offset: 0x0094D50C
		public unsafe float force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004A74 RID: 19060
		// (get) Token: 0x06025084 RID: 151684 RVA: 0x0094F31D File Offset: 0x0094D51D
		// (set) Token: 0x06025085 RID: 151685 RVA: 0x0094F32D File Offset: 0x0094D52D
		public unsafe bool Pressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A75 RID: 19061
		// (get) Token: 0x06025086 RID: 151686 RVA: 0x0094F33E File Offset: 0x0094D53E
		// (set) Token: 0x06025087 RID: 151687 RVA: 0x0094F34E File Offset: 0x0094D54E
		public unsafe bool FS_isPhysicSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A76 RID: 19062
		// (get) Token: 0x06025088 RID: 151688 RVA: 0x0094F35F File Offset: 0x0094D55F
		// (set) Token: 0x06025089 RID: 151689 RVA: 0x0094F36F File Offset: 0x0094D56F
		public unsafe float mass_in_kg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004A77 RID: 19063
		// (get) Token: 0x0602508A RID: 151690 RVA: 0x0094F380 File Offset: 0x0094D580
		// (set) Token: 0x0602508B RID: 151691 RVA: 0x0094F390 File Offset: 0x0094D590
		public unsafe bool beditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A78 RID: 19064
		// (get) Token: 0x0602508C RID: 151692 RVA: 0x0094F3A1 File Offset: 0x0094D5A1
		// (set) Token: 0x0602508D RID: 151693 RVA: 0x0094F3B1 File Offset: 0x0094D5B1
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A79 RID: 19065
		// (get) Token: 0x0602508E RID: 151694 RVA: 0x0094F3C2 File Offset: 0x0094D5C2
		// (set) Token: 0x0602508F RID: 151695 RVA: 0x0094F3D2 File Offset: 0x0094D5D2
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004A7A RID: 19066
		// (get) Token: 0x06025090 RID: 151696 RVA: 0x0094F3E3 File Offset: 0x0094D5E3
		// (set) Token: 0x06025091 RID: 151697 RVA: 0x0094F3F3 File Offset: 0x0094D5F3
		public unsafe int YCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004A7B RID: 19067
		// (get) Token: 0x06025092 RID: 151698 RVA: 0x0094F404 File Offset: 0x0094D604
		// (set) Token: 0x06025093 RID: 151699 RVA: 0x0094F414 File Offset: 0x0094D614
		public unsafe bool ReadDataInBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A7C RID: 19068
		// (get) Token: 0x06025094 RID: 151700 RVA: 0x0094F425 File Offset: 0x0094D625
		// (set) Token: 0x06025095 RID: 151701 RVA: 0x0094F439 File Offset: 0x0094D639
		public unsafe UStaticMesh inputStaticMesh_ForBPL_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004A7D RID: 19069
		// (get) Token: 0x06025096 RID: 151702 RVA: 0x0094F44E File Offset: 0x0094D64E
		// (set) Token: 0x06025097 RID: 151703 RVA: 0x0094F462 File Offset: 0x0094D662
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004A7E RID: 19070
		// (get) Token: 0x06025098 RID: 151704 RVA: 0x0094F477 File Offset: 0x0094D677
		// (set) Token: 0x06025099 RID: 151705 RVA: 0x0094F48B File Offset: 0x0094D68B
		public unsafe UMaterialInstanceDynamic MID1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004A7F RID: 19071
		// (get) Token: 0x0602509A RID: 151706 RVA: 0x0094F4A0 File Offset: 0x0094D6A0
		// (set) Token: 0x0602509B RID: 151707 RVA: 0x0094F4B0 File Offset: 0x0094D6B0
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A80 RID: 19072
		// (get) Token: 0x0602509C RID: 151708 RVA: 0x0094F4C1 File Offset: 0x0094D6C1
		// (set) Token: 0x0602509D RID: 151709 RVA: 0x0094F4D1 File Offset: 0x0094D6D1
		public unsafe bool UseYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A81 RID: 19073
		// (get) Token: 0x0602509E RID: 151710 RVA: 0x0094F4E2 File Offset: 0x0094D6E2
		// (set) Token: 0x0602509F RID: 151711 RVA: 0x0094F4F6 File Offset: 0x0094D6F6
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004A82 RID: 19074
		// (get) Token: 0x060250A0 RID: 151712 RVA: 0x0094F50B File Offset: 0x0094D70B
		// (set) Token: 0x060250A1 RID: 151713 RVA: 0x0094F51F File Offset: 0x0094D71F
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004A83 RID: 19075
		// (get) Token: 0x060250A2 RID: 151714 RVA: 0x0094F534 File Offset: 0x0094D734
		// (set) Token: 0x060250A3 RID: 151715 RVA: 0x0094F544 File Offset: 0x0094D744
		public unsafe bool alreadyBuildArr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A84 RID: 19076
		// (get) Token: 0x060250A4 RID: 151716 RVA: 0x0094F555 File Offset: 0x0094D755
		// (set) Token: 0x060250A5 RID: 151717 RVA: 0x0094F565 File Offset: 0x0094D765
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A85 RID: 19077
		// (get) Token: 0x060250A6 RID: 151718 RVA: 0x0094F576 File Offset: 0x0094D776
		// (set) Token: 0x060250A7 RID: 151719 RVA: 0x0094F586 File Offset: 0x0094D786
		public unsafe bool PlatformCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A86 RID: 19078
		// (get) Token: 0x060250A8 RID: 151720 RVA: 0x0094F597 File Offset: 0x0094D797
		// (set) Token: 0x060250A9 RID: 151721 RVA: 0x0094F5A7 File Offset: 0x0094D7A7
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A87 RID: 19079
		// (get) Token: 0x060250AA RID: 151722 RVA: 0x0094F5B8 File Offset: 0x0094D7B8
		// (set) Token: 0x060250AB RID: 151723 RVA: 0x0094F5CC File Offset: 0x0094D7CC
		public unsafe UChildActorComponent EditorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17004A88 RID: 19080
		// (get) Token: 0x060250AC RID: 151724 RVA: 0x0094F5E4 File Offset: 0x0094D7E4
		// (set) Token: 0x060250AD RID: 151725 RVA: 0x0094F61D File Offset: 0x0094D81D
		[Nullable(1)]
		public TArray<float> weightArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._weightArr) == null)
				{
					result = (this._weightArr = new TArray<float>(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_31, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.weightArr.CopyAssign(value);
			}
		}

		// Token: 0x17004A89 RID: 19081
		// (get) Token: 0x060250AE RID: 151726 RVA: 0x0094F62B File Offset: 0x0094D82B
		// (set) Token: 0x060250AF RID: 151727 RVA: 0x0094F63F File Offset: 0x0094D83F
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17004A8A RID: 19082
		// (get) Token: 0x060250B0 RID: 151728 RVA: 0x0094F654 File Offset: 0x0094D854
		// (set) Token: 0x060250B1 RID: 151729 RVA: 0x0094F68D File Offset: 0x0094D88D
		[Nullable(1)]
		public TArray<UStaticMesh> SMarr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._SMarr) == null)
				{
					result = (this._SMarr = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_33, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMarr.CopyAssign(value);
			}
		}

		// Token: 0x17004A8B RID: 19083
		// (get) Token: 0x060250B2 RID: 151730 RVA: 0x0094F69C File Offset: 0x0094D89C
		// (set) Token: 0x060250B3 RID: 151731 RVA: 0x0094F6D5 File Offset: 0x0094D8D5
		[Nullable(1)]
		public TArray<UStaticMeshComponent> SMComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._SMComponents) == null)
				{
					result = (this._SMComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_34, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x060250B4 RID: 151732 RVA: 0x0094F6E3 File Offset: 0x0094D8E3
		// (set) Token: 0x060250B5 RID: 151733 RVA: 0x0094F6F3 File Offset: 0x0094D8F3
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x060250B6 RID: 151734 RVA: 0x0094F704 File Offset: 0x0094D904
		// (set) Token: 0x060250B7 RID: 151735 RVA: 0x0094F714 File Offset: 0x0094D914
		public unsafe bool UseBakedData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x060250B8 RID: 151736 RVA: 0x0094F725 File Offset: 0x0094D925
		// (set) Token: 0x060250B9 RID: 151737 RVA: 0x0094F739 File Offset: 0x0094D939
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x060250BA RID: 151738 RVA: 0x0094F74E File Offset: 0x0094D94E
		// (set) Token: 0x060250BB RID: 151739 RVA: 0x0094F75E File Offset: 0x0094D95E
		public unsafe int BakeID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x060250BC RID: 151740 RVA: 0x0094F76F File Offset: 0x0094D96F
		// (set) Token: 0x060250BD RID: 151741 RVA: 0x0094F77F File Offset: 0x0094D97F
		public unsafe bool startWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A91 RID: 19089
		// (get) Token: 0x060250BE RID: 151742 RVA: 0x0094F790 File Offset: 0x0094D990
		// (set) Token: 0x060250BF RID: 151743 RVA: 0x0094F7A0 File Offset: 0x0094D9A0
		public unsafe bool rebuild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A92 RID: 19090
		// (get) Token: 0x060250C0 RID: 151744 RVA: 0x0094F7B1 File Offset: 0x0094D9B1
		// (set) Token: 0x060250C1 RID: 151745 RVA: 0x0094F7C5 File Offset: 0x0094D9C5
		public unsafe AKuroCSReadback ReadBackActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroCSReadback>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17004A93 RID: 19091
		// (get) Token: 0x060250C2 RID: 151746 RVA: 0x0094F7DA File Offset: 0x0094D9DA
		// (set) Token: 0x060250C3 RID: 151747 RVA: 0x0094F7EE File Offset: 0x0094D9EE
		public unsafe FVector 气球包围盒半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17004A94 RID: 19092
		// (get) Token: 0x060250C4 RID: 151748 RVA: 0x0094F803 File Offset: 0x0094DA03
		// (set) Token: 0x060250C5 RID: 151749 RVA: 0x0094F813 File Offset: 0x0094DA13
		public unsafe bool useStaticRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A95 RID: 19093
		// (get) Token: 0x060250C6 RID: 151750 RVA: 0x0094F824 File Offset: 0x0094DA24
		// (set) Token: 0x060250C7 RID: 151751 RVA: 0x0094F838 File Offset: 0x0094DA38
		public unsafe UTextureRenderTarget2D StaticRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x17004A96 RID: 19094
		// (get) Token: 0x060250C8 RID: 151752 RVA: 0x0094F84D File Offset: 0x0094DA4D
		// (set) Token: 0x060250C9 RID: 151753 RVA: 0x0094F861 File Offset: 0x0094DA61
		public unsafe UTextureRenderTarget2D StaticRT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17004A97 RID: 19095
		// (get) Token: 0x060250CA RID: 151754 RVA: 0x0094F876 File Offset: 0x0094DA76
		// (set) Token: 0x060250CB RID: 151755 RVA: 0x0094F88A File Offset: 0x0094DA8A
		public unsafe UMaterialInstanceDynamic MID_bake
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x17004A98 RID: 19096
		// (get) Token: 0x060250CC RID: 151756 RVA: 0x0094F89F File Offset: 0x0094DA9F
		// (set) Token: 0x060250CD RID: 151757 RVA: 0x0094F8B3 File Offset: 0x0094DAB3
		public unsafe UTexture2D Tex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17004A99 RID: 19097
		// (get) Token: 0x060250CE RID: 151758 RVA: 0x0094F8C8 File Offset: 0x0094DAC8
		// (set) Token: 0x060250CF RID: 151759 RVA: 0x0094F8DC File Offset: 0x0094DADC
		public unsafe UTexture2D Tex_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x17004A9A RID: 19098
		// (get) Token: 0x060250D0 RID: 151760 RVA: 0x0094F8F1 File Offset: 0x0094DAF1
		// (set) Token: 0x060250D1 RID: 151761 RVA: 0x0094F905 File Offset: 0x0094DB05
		public unsafe UTextureRenderTarget2D RT_test1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x17004A9B RID: 19099
		// (get) Token: 0x060250D2 RID: 151762 RVA: 0x0094F91A File Offset: 0x0094DB1A
		// (set) Token: 0x060250D3 RID: 151763 RVA: 0x0094F92E File Offset: 0x0094DB2E
		public unsafe UMaterialInstanceDynamic MID_bake_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x060250D4 RID: 151764 RVA: 0x0094F943 File Offset: 0x0094DB43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void buildFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__buildFunction_NativeFunctionPtr, null);
		}

		// Token: 0x060250D5 RID: 151765 RVA: 0x0094F957 File Offset: 0x0094DB57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060250D6 RID: 151766 RVA: 0x0094F96B File Offset: 0x0094DB6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060250D7 RID: 151767 RVA: 0x0094F980 File Offset: 0x0094DB80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060250D8 RID: 151768 RVA: 0x0094F994 File Offset: 0x0094DB94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060250D9 RID: 151769 RVA: 0x0094F9AC File Offset: 0x0094DBAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_AClusterBallons_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AClusterBallons_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AClusterBallons_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060250DA RID: 151770 RVA: 0x0094F9F4 File Offset: 0x0094DBF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_AClusterBallons_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AClusterBallons_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AClusterBallons_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060250DB RID: 151771 RVA: 0x0094FA3C File Offset: 0x0094DC3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_AClusterBallons_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_AClusterBallons_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_AClusterBallons_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060250DC RID: 151772 RVA: 0x0094FA88 File Offset: 0x0094DC88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_AClusterBallons_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_AClusterBallons_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_AClusterBallons_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060250DD RID: 151773 RVA: 0x0094FAD4 File Offset: 0x0094DCD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060250DE RID: 151774 RVA: 0x0094FB90 File Offset: 0x0094DD90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060250DF RID: 151775 RVA: 0x0094FC1C File Offset: 0x0094DE1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_AClusterBallons_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_AClusterBallons_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_AClusterBallons_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060250E0 RID: 151776 RVA: 0x0094FC7F File Offset: 0x0094DE7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060250E1 RID: 151777 RVA: 0x0094FC93 File Offset: 0x0094DE93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Bake()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__Bake_NativeFunctionPtr, null);
		}

		// Token: 0x060250E2 RID: 151778 RVA: 0x0094FCA7 File Offset: 0x0094DEA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x060250E3 RID: 151779 RVA: 0x0094FCBB File Offset: 0x0094DEBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__CustomEvent_1_NativeFunctionPtr, null);
		}

		// Token: 0x060250E4 RID: 151780 RVA: 0x0094FCCF File Offset: 0x0094DECF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OpenPhysicsVisibility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__OpenPhysicsVisibility_NativeFunctionPtr, null);
		}

		// Token: 0x060250E5 RID: 151781 RVA: 0x0094FCE3 File Offset: 0x0094DEE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OpenPhysicsVisibility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_C.__OpenPhysicsVisibility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060250E6 RID: 151782 RVA: 0x0094FCF8 File Offset: 0x0094DEF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ClosePhysicsVisibility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_C.__ClosePhysicsVisibility_NativeFunctionPtr, null);
		}

		// Token: 0x060250E7 RID: 151783 RVA: 0x0094FD0C File Offset: 0x0094DF0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ClosePhysicsVisibility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_C.__ClosePhysicsVisibility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060250E8 RID: 151784 RVA: 0x0094FD21 File Offset: 0x0094DF21
		protected BP_AClusterBallons_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126AA RID: 75434
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/BP_AClusterBallons.BP_AClusterBallons_C";

		// Token: 0x040126AB RID: 75435
		private static IntPtr _ClassPtr;

		// Token: 0x040126AC RID: 75436
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040126AD RID: 75437
		internal static int __PropertyOffset_1;

		// Token: 0x040126AE RID: 75438
		internal static int __PropertyOffset_2;

		// Token: 0x040126AF RID: 75439
		internal static int __PropertyOffset_3;

		// Token: 0x040126B0 RID: 75440
		internal static int __PropertyOffset_4;

		// Token: 0x040126B1 RID: 75441
		internal static int __PropertyOffset_5;

		// Token: 0x040126B2 RID: 75442
		internal static int __PropertyOffset_6;

		// Token: 0x040126B3 RID: 75443
		internal static int __PropertyOffset_7;

		// Token: 0x040126B4 RID: 75444
		internal static int __PropertyOffset_8;

		// Token: 0x040126B5 RID: 75445
		internal static int __PropertyOffset_9;

		// Token: 0x040126B6 RID: 75446
		internal static int __PropertyOffset_10;

		// Token: 0x040126B7 RID: 75447
		internal static int __PropertyOffset_11;

		// Token: 0x040126B8 RID: 75448
		internal static int __PropertyOffset_12;

		// Token: 0x040126B9 RID: 75449
		internal static int __PropertyOffset_13;

		// Token: 0x040126BA RID: 75450
		internal static int __PropertyOffset_14;

		// Token: 0x040126BB RID: 75451
		internal static int __PropertyOffset_15;

		// Token: 0x040126BC RID: 75452
		internal static int __PropertyOffset_16;

		// Token: 0x040126BD RID: 75453
		internal static int __PropertyOffset_17;

		// Token: 0x040126BE RID: 75454
		internal static int __PropertyOffset_18;

		// Token: 0x040126BF RID: 75455
		internal static int __PropertyOffset_19;

		// Token: 0x040126C0 RID: 75456
		internal static int __PropertyOffset_20;

		// Token: 0x040126C1 RID: 75457
		internal static int __PropertyOffset_21;

		// Token: 0x040126C2 RID: 75458
		internal static int __PropertyOffset_22;

		// Token: 0x040126C3 RID: 75459
		internal static int __PropertyOffset_23;

		// Token: 0x040126C4 RID: 75460
		internal static int __PropertyOffset_24;

		// Token: 0x040126C5 RID: 75461
		internal static int __PropertyOffset_25;

		// Token: 0x040126C6 RID: 75462
		internal static int __PropertyOffset_26;

		// Token: 0x040126C7 RID: 75463
		internal static int __PropertyOffset_27;

		// Token: 0x040126C8 RID: 75464
		internal static int __PropertyOffset_28;

		// Token: 0x040126C9 RID: 75465
		internal static int __PropertyOffset_29;

		// Token: 0x040126CA RID: 75466
		internal static int __PropertyOffset_30;

		// Token: 0x040126CB RID: 75467
		internal static int __PropertyOffset_31;

		// Token: 0x040126CC RID: 75468
		private TArray<float> _weightArr;

		// Token: 0x040126CD RID: 75469
		internal static int __PropertyOffset_32;

		// Token: 0x040126CE RID: 75470
		internal static int __PropertyOffset_33;

		// Token: 0x040126CF RID: 75471
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _SMarr;

		// Token: 0x040126D0 RID: 75472
		internal static int __PropertyOffset_34;

		// Token: 0x040126D1 RID: 75473
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _SMComponents;

		// Token: 0x040126D2 RID: 75474
		internal static int __PropertyOffset_35;

		// Token: 0x040126D3 RID: 75475
		internal static int __PropertyOffset_36;

		// Token: 0x040126D4 RID: 75476
		internal static int __PropertyOffset_37;

		// Token: 0x040126D5 RID: 75477
		internal static int __PropertyOffset_38;

		// Token: 0x040126D6 RID: 75478
		internal static int __PropertyOffset_39;

		// Token: 0x040126D7 RID: 75479
		internal static int __PropertyOffset_40;

		// Token: 0x040126D8 RID: 75480
		internal static int __PropertyOffset_41;

		// Token: 0x040126D9 RID: 75481
		internal static int __PropertyOffset_42;

		// Token: 0x040126DA RID: 75482
		internal static int __PropertyOffset_43;

		// Token: 0x040126DB RID: 75483
		internal static int __PropertyOffset_44;

		// Token: 0x040126DC RID: 75484
		internal static int __PropertyOffset_45;

		// Token: 0x040126DD RID: 75485
		internal static int __PropertyOffset_46;

		// Token: 0x040126DE RID: 75486
		internal static int __PropertyOffset_47;

		// Token: 0x040126DF RID: 75487
		internal static int __PropertyOffset_48;

		// Token: 0x040126E0 RID: 75488
		internal static int __PropertyOffset_49;

		// Token: 0x040126E1 RID: 75489
		internal static int __PropertyOffset_50;

		// Token: 0x040126E2 RID: 75490
		private static IntPtr __buildFunction_NativeFunctionPtr;

		// Token: 0x040126E3 RID: 75491
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040126E4 RID: 75492
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040126E5 RID: 75493
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040126E6 RID: 75494
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040126E7 RID: 75495
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040126E8 RID: 75496
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040126E9 RID: 75497
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040126EA RID: 75498
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040126EB RID: 75499
		private static IntPtr __Bake_NativeFunctionPtr;

		// Token: 0x040126EC RID: 75500
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x040126ED RID: 75501
		private static IntPtr __CustomEvent_1_NativeFunctionPtr;

		// Token: 0x040126EE RID: 75502
		private static IntPtr __OpenPhysicsVisibility_NativeFunctionPtr;

		// Token: 0x040126EF RID: 75503
		private static IntPtr __ClosePhysicsVisibility_NativeFunctionPtr;

		// Token: 0x02009FA8 RID: 40872
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319FC RID: 203260
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FA9 RID: 40873
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040319FD RID: 203261
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009FAA RID: 40874
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319FE RID: 203262
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319FF RID: 203263
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031A00 RID: 203264
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031A01 RID: 203265
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031A02 RID: 203266
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031A03 RID: 203267
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009FAB RID: 40875
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031A04 RID: 203268
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031A05 RID: 203269
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031A06 RID: 203270
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031A07 RID: 203271
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009FAC RID: 40876
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031A08 RID: 203272
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031A09 RID: 203273
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031A0A RID: 203274
			[FieldOffset(32)]
			public int Id;
		}
	}
}
