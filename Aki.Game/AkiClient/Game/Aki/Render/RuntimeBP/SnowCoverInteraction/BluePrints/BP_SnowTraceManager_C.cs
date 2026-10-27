using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints
{
	// Token: 0x02003AD2 RID: 15058
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTraceManager.BP_SnowTraceManager_C")]
	[UnrealStructLayout(1896, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1896)]
	public class BP_SnowTraceManager_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020725 RID: 132901 RVA: 0x008D2F70 File Offset: 0x008D1170
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTraceManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTraceManager.BP_SnowTraceManager_C");
			}
			return BP_SnowTraceManager_C._ClassPtr;
		}

		// Token: 0x06020726 RID: 132902 RVA: 0x008D2F94 File Offset: 0x008D1194
		public BP_SnowTraceManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTraceManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020727 RID: 132903 RVA: 0x008D2FBC File Offset: 0x008D11BC
		[NullableContext(1)]
		public BP_SnowTraceManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTraceManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x06020728 RID: 132904 RVA: 0x008D2FEF File Offset: 0x008D11EF
		// (set) Token: 0x06020729 RID: 132905 RVA: 0x008D3003 File Offset: 0x008D1203
		public unsafe BP_SnowTrailComponent_C BP_SnowTrailComponent_WeaponInte
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0602072A RID: 132906 RVA: 0x008D3018 File Offset: 0x008D1218
		// (set) Token: 0x0602072B RID: 132907 RVA: 0x008D302C File Offset: 0x008D122C
		public unsafe BP_SnowTrailComponent_C BP_SnowTrailComponent_FootR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0602072C RID: 132908 RVA: 0x008D3041 File Offset: 0x008D1241
		// (set) Token: 0x0602072D RID: 132909 RVA: 0x008D3055 File Offset: 0x008D1255
		public unsafe BP_SnowTrailComponent_C BP_SnowTrailComponent_FootL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0602072E RID: 132910 RVA: 0x008D306A File Offset: 0x008D126A
		// (set) Token: 0x0602072F RID: 132911 RVA: 0x008D307E File Offset: 0x008D127E
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x06020730 RID: 132912 RVA: 0x008D3093 File Offset: 0x008D1293
		// (set) Token: 0x06020731 RID: 132913 RVA: 0x008D30A7 File Offset: 0x008D12A7
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x06020732 RID: 132914 RVA: 0x008D30BC File Offset: 0x008D12BC
		// (set) Token: 0x06020733 RID: 132915 RVA: 0x008D30D0 File Offset: 0x008D12D0
		public unsafe UMaterial M_TrialDrawer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x06020734 RID: 132916 RVA: 0x008D30E5 File Offset: 0x008D12E5
		// (set) Token: 0x06020735 RID: 132917 RVA: 0x008D30F9 File Offset: 0x008D12F9
		public unsafe UMaterial M_TrailDrawer_Weapon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x06020736 RID: 132918 RVA: 0x008D310E File Offset: 0x008D130E
		// (set) Token: 0x06020737 RID: 132919 RVA: 0x008D3122 File Offset: 0x008D1322
		public unsafe UMaterial M_HistoryMerge
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x06020738 RID: 132920 RVA: 0x008D3137 File Offset: 0x008D1337
		// (set) Token: 0x06020739 RID: 132921 RVA: 0x008D314B File Offset: 0x008D134B
		public unsafe UMaterial M_HistoryCopy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x0602073A RID: 132922 RVA: 0x008D3160 File Offset: 0x008D1360
		// (set) Token: 0x0602073B RID: 132923 RVA: 0x008D3174 File Offset: 0x008D1374
		public unsafe UMaterial M_DrawEdge
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0602073C RID: 132924 RVA: 0x008D3189 File Offset: 0x008D1389
		// (set) Token: 0x0602073D RID: 132925 RVA: 0x008D319D File Offset: 0x008D139D
		public unsafe UMaterialInstanceDynamic MI_TrailDrawer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x0602073E RID: 132926 RVA: 0x008D31B2 File Offset: 0x008D13B2
		// (set) Token: 0x0602073F RID: 132927 RVA: 0x008D31C6 File Offset: 0x008D13C6
		public unsafe UMaterialInstanceDynamic MI_TrailDrawer_Weapon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x06020740 RID: 132928 RVA: 0x008D31DB File Offset: 0x008D13DB
		// (set) Token: 0x06020741 RID: 132929 RVA: 0x008D31EF File Offset: 0x008D13EF
		public unsafe UMaterialInstanceDynamic MI_HistoryMerge
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x06020742 RID: 132930 RVA: 0x008D3204 File Offset: 0x008D1404
		// (set) Token: 0x06020743 RID: 132931 RVA: 0x008D3218 File Offset: 0x008D1418
		public unsafe UMaterialInstanceDynamic MI_HistoryCopy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x06020744 RID: 132932 RVA: 0x008D322D File Offset: 0x008D142D
		// (set) Token: 0x06020745 RID: 132933 RVA: 0x008D3241 File Offset: 0x008D1441
		public unsafe UMaterialInstanceDynamic MI_TrailEdge
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x06020746 RID: 132934 RVA: 0x008D3256 File Offset: 0x008D1456
		// (set) Token: 0x06020747 RID: 132935 RVA: 0x008D326A File Offset: 0x008D146A
		public unsafe UMaterialInstanceDynamic MI_WiderTrail
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x06020748 RID: 132936 RVA: 0x008D327F File Offset: 0x008D147F
		// (set) Token: 0x06020749 RID: 132937 RVA: 0x008D3293 File Offset: 0x008D1493
		public unsafe UTextureRenderTarget2D CurrentRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0602074A RID: 132938 RVA: 0x008D32A8 File Offset: 0x008D14A8
		// (set) Token: 0x0602074B RID: 132939 RVA: 0x008D32BC File Offset: 0x008D14BC
		public unsafe UTextureRenderTarget2D HistoryRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0602074C RID: 132940 RVA: 0x008D32D1 File Offset: 0x008D14D1
		// (set) Token: 0x0602074D RID: 132941 RVA: 0x008D32E5 File Offset: 0x008D14E5
		public unsafe UTextureRenderTarget2D TrialRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0602074E RID: 132942 RVA: 0x008D32FA File Offset: 0x008D14FA
		// (set) Token: 0x0602074F RID: 132943 RVA: 0x008D330A File Offset: 0x008D150A
		public unsafe float MaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06020750 RID: 132944 RVA: 0x008D331B File Offset: 0x008D151B
		// (set) Token: 0x06020751 RID: 132945 RVA: 0x008D332B File Offset: 0x008D152B
		public unsafe float SideFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06020752 RID: 132946 RVA: 0x008D333C File Offset: 0x008D153C
		// (set) Token: 0x06020753 RID: 132947 RVA: 0x008D3350 File Offset: 0x008D1550
		public unsafe UTextureRenderTarget2D WiderTrailRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06020754 RID: 132948 RVA: 0x008D3365 File Offset: 0x008D1565
		// (set) Token: 0x06020755 RID: 132949 RVA: 0x008D3379 File Offset: 0x008D1579
		public unsafe UMaterialParameterCollection PMC_SnowTraceParams
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06020756 RID: 132950 RVA: 0x008D338E File Offset: 0x008D158E
		// (set) Token: 0x06020757 RID: 132951 RVA: 0x008D33A2 File Offset: 0x008D15A2
		public unsafe FVector CurrentManagerLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06020758 RID: 132952 RVA: 0x008D33B7 File Offset: 0x008D15B7
		// (set) Token: 0x06020759 RID: 132953 RVA: 0x008D33CB File Offset: 0x008D15CB
		public unsafe FVector HistoryLocaiton
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0602075A RID: 132954 RVA: 0x008D33E0 File Offset: 0x008D15E0
		// (set) Token: 0x0602075B RID: 132955 RVA: 0x008D33F0 File Offset: 0x008D15F0
		public unsafe bool IsLocaitonCalculated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x0602075C RID: 132956 RVA: 0x008D3404 File Offset: 0x008D1604
		// (set) Token: 0x0602075D RID: 132957 RVA: 0x008D343D File Offset: 0x008D163D
		[Nullable(1)]
		public TArray<float> Hardness
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Hardness) == null)
				{
					result = (this._Hardness = new TArray<float>(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Hardness.CopyAssign(value);
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0602075E RID: 132958 RVA: 0x008D344C File Offset: 0x008D164C
		// (set) Token: 0x0602075F RID: 132959 RVA: 0x008D3485 File Offset: 0x008D1685
		[Nullable(1)]
		public TArray<float> TrailDepth
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._TrailDepth) == null)
				{
					result = (this._TrailDepth = new TArray<float>(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_28, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TrailDepth.CopyAssign(value);
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06020760 RID: 132960 RVA: 0x008D3494 File Offset: 0x008D1694
		// (set) Token: 0x06020761 RID: 132961 RVA: 0x008D34CD File Offset: 0x008D16CD
		[Nullable(1)]
		public TArray<float> TrailRadius
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._TrailRadius) == null)
				{
					result = (this._TrailRadius = new TArray<float>(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_29, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TrailRadius.CopyAssign(value);
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x06020762 RID: 132962 RVA: 0x008D34DC File Offset: 0x008D16DC
		// (set) Token: 0x06020763 RID: 132963 RVA: 0x008D3515 File Offset: 0x008D1715
		[Nullable(1)]
		public TArray<float> Rotation
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new TArray<float>(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_30, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Rotation.CopyAssign(value);
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x06020764 RID: 132964 RVA: 0x008D3524 File Offset: 0x008D1724
		// (set) Token: 0x06020765 RID: 132965 RVA: 0x008D355D File Offset: 0x008D175D
		[Nullable(1)]
		public TArray<FVector2D> TrailsLocation
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._TrailsLocation) == null)
				{
					result = (this._TrailsLocation = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_31, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TrailsLocation.CopyAssign(value);
			}
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x06020766 RID: 132966 RVA: 0x008D356B File Offset: 0x008D176B
		// (set) Token: 0x06020767 RID: 132967 RVA: 0x008D357B File Offset: 0x008D177B
		public unsafe float TrailFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x06020768 RID: 132968 RVA: 0x008D358C File Offset: 0x008D178C
		// (set) Token: 0x06020769 RID: 132969 RVA: 0x008D359C File Offset: 0x008D179C
		public unsafe float TrailAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0602076A RID: 132970 RVA: 0x008D35AD File Offset: 0x008D17AD
		// (set) Token: 0x0602076B RID: 132971 RVA: 0x008D35BD File Offset: 0x008D17BD
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0602076C RID: 132972 RVA: 0x008D35CE File Offset: 0x008D17CE
		// (set) Token: 0x0602076D RID: 132973 RVA: 0x008D35DE File Offset: 0x008D17DE
		public unsafe float MovementThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0602076E RID: 132974 RVA: 0x008D35EF File Offset: 0x008D17EF
		// (set) Token: 0x0602076F RID: 132975 RVA: 0x008D35FF File Offset: 0x008D17FF
		public unsafe float TrailSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x06020770 RID: 132976 RVA: 0x008D3610 File Offset: 0x008D1810
		// (set) Token: 0x06020771 RID: 132977 RVA: 0x008D3620 File Offset: 0x008D1820
		public unsafe float TrailIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x06020772 RID: 132978 RVA: 0x008D3631 File Offset: 0x008D1831
		// (set) Token: 0x06020773 RID: 132979 RVA: 0x008D3641 File Offset: 0x008D1841
		public unsafe float SnowDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x06020774 RID: 132980 RVA: 0x008D3652 File Offset: 0x008D1852
		// (set) Token: 0x06020775 RID: 132981 RVA: 0x008D3662 File Offset: 0x008D1862
		public unsafe bool DrawEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x06020776 RID: 132982 RVA: 0x008D3673 File Offset: 0x008D1873
		// (set) Token: 0x06020777 RID: 132983 RVA: 0x008D3683 File Offset: 0x008D1883
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x06020778 RID: 132984 RVA: 0x008D3694 File Offset: 0x008D1894
		// (set) Token: 0x06020779 RID: 132985 RVA: 0x008D36A4 File Offset: 0x008D18A4
		public unsafe bool bIsHitSnow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0602077A RID: 132986 RVA: 0x008D36B8 File Offset: 0x008D18B8
		// (set) Token: 0x0602077B RID: 132987 RVA: 0x008D36F1 File Offset: 0x008D18F1
		[Nullable(1)]
		public FDrawToRenderTargetContext RenderContext
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FDrawToRenderTargetContext result;
				if ((result = this._RenderContext) == null)
				{
					result = (this._RenderContext = new FDrawToRenderTargetContext(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_42, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDrawToRenderTargetContext.StaticStruct(), base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_42, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x0602077C RID: 132988 RVA: 0x008D3712 File Offset: 0x008D1912
		// (set) Token: 0x0602077D RID: 132989 RVA: 0x008D3722 File Offset: 0x008D1922
		public unsafe float GlobalMovementThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0602077E RID: 132990 RVA: 0x008D3733 File Offset: 0x008D1933
		// (set) Token: 0x0602077F RID: 132991 RVA: 0x008D3743 File Offset: 0x008D1943
		public unsafe float GlobalTrailAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x06020780 RID: 132992 RVA: 0x008D3754 File Offset: 0x008D1954
		// (set) Token: 0x06020781 RID: 132993 RVA: 0x008D378D File Offset: 0x008D198D
		[Nullable(1)]
		public TArray<FVector2D> BulletPosList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._BulletPosList) == null)
				{
					result = (this._BulletPosList = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_45, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletPosList.CopyAssign(value);
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x06020782 RID: 132994 RVA: 0x008D379B File Offset: 0x008D199B
		// (set) Token: 0x06020783 RID: 132995 RVA: 0x008D37AB File Offset: 0x008D19AB
		public unsafe float GlobalMaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x06020784 RID: 132996 RVA: 0x008D37BC File Offset: 0x008D19BC
		// (set) Token: 0x06020785 RID: 132997 RVA: 0x008D37CC File Offset: 0x008D19CC
		public unsafe float WeaponRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x06020786 RID: 132998 RVA: 0x008D37DD File Offset: 0x008D19DD
		// (set) Token: 0x06020787 RID: 132999 RVA: 0x008D37F1 File Offset: 0x008D19F1
		public unsafe FLinearColor Parameter_Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x06020788 RID: 133000 RVA: 0x008D3806 File Offset: 0x008D1A06
		// (set) Token: 0x06020789 RID: 133001 RVA: 0x008D381A File Offset: 0x008D1A1A
		public unsafe FName Parameter_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0602078A RID: 133002 RVA: 0x008D3830 File Offset: 0x008D1A30
		// (set) Token: 0x0602078B RID: 133003 RVA: 0x008D3869 File Offset: 0x008D1A69
		[Nullable(1)]
		public TArray<FName> FootPointName
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._FootPointName) == null)
				{
					result = (this._FootPointName = new TArray<FName>(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_50, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FootPointName.CopyAssign(value);
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0602078C RID: 133004 RVA: 0x008D3877 File Offset: 0x008D1A77
		// (set) Token: 0x0602078D RID: 133005 RVA: 0x008D3887 File Offset: 0x008D1A87
		public unsafe float WeaponDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0602078E RID: 133006 RVA: 0x008D3898 File Offset: 0x008D1A98
		// (set) Token: 0x0602078F RID: 133007 RVA: 0x008D38A8 File Offset: 0x008D1AA8
		public unsafe bool bIsMoto
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_52) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_52) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x06020790 RID: 133008 RVA: 0x008D38B9 File Offset: 0x008D1AB9
		// (set) Token: 0x06020791 RID: 133009 RVA: 0x008D38CD File Offset: 0x008D1ACD
		public unsafe UMaterialParameterCollection MPC_SnowTrail
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_53);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_53, value);
			}
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x06020792 RID: 133010 RVA: 0x008D38E2 File Offset: 0x008D1AE2
		// (set) Token: 0x06020793 RID: 133011 RVA: 0x008D38F2 File Offset: 0x008D1AF2
		public unsafe bool bSequenceMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06020794 RID: 133012 RVA: 0x008D3903 File Offset: 0x008D1B03
		// (set) Token: 0x06020795 RID: 133013 RVA: 0x008D3913 File Offset: 0x008D1B13
		public unsafe bool bGICustom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTraceManager_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06020796 RID: 133014 RVA: 0x008D3924 File Offset: 0x008D1B24
		// (set) Token: 0x06020797 RID: 133015 RVA: 0x008D3938 File Offset: 0x008D1B38
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_56);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTraceManager_C.__PropertyOffset_56, value);
			}
		}

		// Token: 0x06020798 RID: 133016 RVA: 0x008D3950 File Offset: 0x008D1B50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetCharacterComp(bool bIsEnable)
		{
			BP_SnowTraceManager_C.__SetCharacterComp_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__SetCharacterComp_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_SnowTraceManager_C.__SetCharacterComp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__SetCharacterComp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsEnable = bIsEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__SetCharacterComp_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020799 RID: 133017 RVA: 0x008D3998 File Offset: 0x008D1B98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CheckIfHitSnow(ref bool IsHit)
		{
			BP_SnowTraceManager_C.__CheckIfHitSnow_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__CheckIfHitSnow_FunctionParams[(UIntPtr)311] + 15L / (long)sizeof(BP_SnowTraceManager_C.__CheckIfHitSnow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__CheckIfHitSnow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsHit = IsHit;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__CheckIfHitSnow_NativeFunctionPtr, (void*)ptr);
			IsHit = ptr->IsHit;
		}

		// Token: 0x0602079A RID: 133018 RVA: 0x008D39EA File Offset: 0x008D1BEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCurrentSettings()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__UpdateCurrentSettings_NativeFunctionPtr, null);
		}

		// Token: 0x0602079B RID: 133019 RVA: 0x008D3A00 File Offset: 0x008D1C00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Register_Trail_Lerp(FVector Location, float Size)
		{
			BP_SnowTraceManager_C.__Register_Trail_Lerp_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__Register_Trail_Lerp_FunctionParams[(UIntPtr)147] + 15L / (long)sizeof(BP_SnowTraceManager_C.__Register_Trail_Lerp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__Register_Trail_Lerp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			ptr->Size = Size;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__Register_Trail_Lerp_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602079C RID: 133020 RVA: 0x008D3A50 File Offset: 0x008D1C50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void VisualizeCollSphere(AActor Actor)
		{
			BP_SnowTraceManager_C.__VisualizeCollSphere_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__VisualizeCollSphere_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SnowTraceManager_C.__VisualizeCollSphere_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__VisualizeCollSphere_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__VisualizeCollSphere_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602079D RID: 133021 RVA: 0x008D3AA5 File Offset: 0x008D1CA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RenderTrail()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__RenderTrail_NativeFunctionPtr, null);
		}

		// Token: 0x0602079E RID: 133022 RVA: 0x008D3ABC File Offset: 0x008D1CBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Register_Trail(FVector TrialCompLocation, float Radisu, float Depth, float Hardness, float Rotation)
		{
			BP_SnowTraceManager_C.__Register_Trail_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__Register_Trail_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_SnowTraceManager_C.__Register_Trail_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__Register_Trail_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TrialCompLocation = TrialCompLocation;
			ptr->Radisu = Radisu;
			ptr->Depth = Depth;
			ptr->Hardness = Hardness;
			ptr->Rotation = Rotation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__Register_Trail_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602079F RID: 133023 RVA: 0x008D3B24 File Offset: 0x008D1D24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RegisterWeaponPoint(FVector TrialCompLocation, float Radius, float Depth)
		{
			BP_SnowTraceManager_C.__RegisterWeaponPoint_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__RegisterWeaponPoint_FunctionParams[(UIntPtr)115] + 15L / (long)sizeof(BP_SnowTraceManager_C.__RegisterWeaponPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__RegisterWeaponPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TrialCompLocation = TrialCompLocation;
			ptr->Radius = Radius;
			ptr->Depth = Depth;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__RegisterWeaponPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207A0 RID: 133024 RVA: 0x008D3B78 File Offset: 0x008D1D78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalculateLocation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__CalculateLocation_NativeFunctionPtr, null);
		}

		// Token: 0x060207A1 RID: 133025 RVA: 0x008D3B8C File Offset: 0x008D1D8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Initialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x060207A2 RID: 133026 RVA: 0x008D3BA0 File Offset: 0x008D1DA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060207A3 RID: 133027 RVA: 0x008D3BB4 File Offset: 0x008D1DB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060207A4 RID: 133028 RVA: 0x008D3BCC File Offset: 0x008D1DCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SnowTraceManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTraceManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207A5 RID: 133029 RVA: 0x008D3C14 File Offset: 0x008D1E14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SnowTraceManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTraceManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060207A6 RID: 133030 RVA: 0x008D3C5B File Offset: 0x008D1E5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ChangeSettings()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__ChangeSettings_NativeFunctionPtr, null);
		}

		// Token: 0x060207A7 RID: 133031 RVA: 0x008D3C70 File Offset: 0x008D1E70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SnowTraceManager_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SnowTraceManager_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207A8 RID: 133032 RVA: 0x008D3CBC File Offset: 0x008D1EBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SnowTraceManager_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SnowTraceManager_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060207A9 RID: 133033 RVA: 0x008D3D08 File Offset: 0x008D1F08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207AA RID: 133034 RVA: 0x008D3D60 File Offset: 0x008D1F60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060207AB RID: 133035 RVA: 0x008D3DB8 File Offset: 0x008D1FB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			BP_SnowTraceManager_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SnowTraceManager_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207AC RID: 133036 RVA: 0x008D3E10 File Offset: 0x008D2010
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			BP_SnowTraceManager_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_SnowTraceManager_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SnowTraceManager_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTraceManager_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTraceManager_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060207AD RID: 133037 RVA: 0x008D3E66 File Offset: 0x008D2066
		protected BP_SnowTraceManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB69 RID: 64361
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTraceManager.BP_SnowTraceManager_C";

		// Token: 0x0400FB6A RID: 64362
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB6B RID: 64363
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB6C RID: 64364
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB6D RID: 64365
		internal static int __PropertyOffset_2;

		// Token: 0x0400FB6E RID: 64366
		internal static int __PropertyOffset_3;

		// Token: 0x0400FB6F RID: 64367
		internal static int __PropertyOffset_4;

		// Token: 0x0400FB70 RID: 64368
		internal static int __PropertyOffset_5;

		// Token: 0x0400FB71 RID: 64369
		internal static int __PropertyOffset_6;

		// Token: 0x0400FB72 RID: 64370
		internal static int __PropertyOffset_7;

		// Token: 0x0400FB73 RID: 64371
		internal static int __PropertyOffset_8;

		// Token: 0x0400FB74 RID: 64372
		internal static int __PropertyOffset_9;

		// Token: 0x0400FB75 RID: 64373
		internal static int __PropertyOffset_10;

		// Token: 0x0400FB76 RID: 64374
		internal static int __PropertyOffset_11;

		// Token: 0x0400FB77 RID: 64375
		internal static int __PropertyOffset_12;

		// Token: 0x0400FB78 RID: 64376
		internal static int __PropertyOffset_13;

		// Token: 0x0400FB79 RID: 64377
		internal static int __PropertyOffset_14;

		// Token: 0x0400FB7A RID: 64378
		internal static int __PropertyOffset_15;

		// Token: 0x0400FB7B RID: 64379
		internal static int __PropertyOffset_16;

		// Token: 0x0400FB7C RID: 64380
		internal static int __PropertyOffset_17;

		// Token: 0x0400FB7D RID: 64381
		internal static int __PropertyOffset_18;

		// Token: 0x0400FB7E RID: 64382
		internal static int __PropertyOffset_19;

		// Token: 0x0400FB7F RID: 64383
		internal static int __PropertyOffset_20;

		// Token: 0x0400FB80 RID: 64384
		internal static int __PropertyOffset_21;

		// Token: 0x0400FB81 RID: 64385
		internal static int __PropertyOffset_22;

		// Token: 0x0400FB82 RID: 64386
		internal static int __PropertyOffset_23;

		// Token: 0x0400FB83 RID: 64387
		internal static int __PropertyOffset_24;

		// Token: 0x0400FB84 RID: 64388
		internal static int __PropertyOffset_25;

		// Token: 0x0400FB85 RID: 64389
		internal static int __PropertyOffset_26;

		// Token: 0x0400FB86 RID: 64390
		internal static int __PropertyOffset_27;

		// Token: 0x0400FB87 RID: 64391
		private TArray<float> _Hardness;

		// Token: 0x0400FB88 RID: 64392
		internal static int __PropertyOffset_28;

		// Token: 0x0400FB89 RID: 64393
		private TArray<float> _TrailDepth;

		// Token: 0x0400FB8A RID: 64394
		internal static int __PropertyOffset_29;

		// Token: 0x0400FB8B RID: 64395
		private TArray<float> _TrailRadius;

		// Token: 0x0400FB8C RID: 64396
		internal static int __PropertyOffset_30;

		// Token: 0x0400FB8D RID: 64397
		private TArray<float> _Rotation;

		// Token: 0x0400FB8E RID: 64398
		internal static int __PropertyOffset_31;

		// Token: 0x0400FB8F RID: 64399
		private TArray<FVector2D> _TrailsLocation;

		// Token: 0x0400FB90 RID: 64400
		internal static int __PropertyOffset_32;

		// Token: 0x0400FB91 RID: 64401
		internal static int __PropertyOffset_33;

		// Token: 0x0400FB92 RID: 64402
		internal static int __PropertyOffset_34;

		// Token: 0x0400FB93 RID: 64403
		internal static int __PropertyOffset_35;

		// Token: 0x0400FB94 RID: 64404
		internal static int __PropertyOffset_36;

		// Token: 0x0400FB95 RID: 64405
		internal static int __PropertyOffset_37;

		// Token: 0x0400FB96 RID: 64406
		internal static int __PropertyOffset_38;

		// Token: 0x0400FB97 RID: 64407
		internal static int __PropertyOffset_39;

		// Token: 0x0400FB98 RID: 64408
		internal static int __PropertyOffset_40;

		// Token: 0x0400FB99 RID: 64409
		internal static int __PropertyOffset_41;

		// Token: 0x0400FB9A RID: 64410
		internal static int __PropertyOffset_42;

		// Token: 0x0400FB9B RID: 64411
		private FDrawToRenderTargetContext _RenderContext;

		// Token: 0x0400FB9C RID: 64412
		internal static int __PropertyOffset_43;

		// Token: 0x0400FB9D RID: 64413
		internal static int __PropertyOffset_44;

		// Token: 0x0400FB9E RID: 64414
		internal static int __PropertyOffset_45;

		// Token: 0x0400FB9F RID: 64415
		private TArray<FVector2D> _BulletPosList;

		// Token: 0x0400FBA0 RID: 64416
		internal static int __PropertyOffset_46;

		// Token: 0x0400FBA1 RID: 64417
		internal static int __PropertyOffset_47;

		// Token: 0x0400FBA2 RID: 64418
		internal static int __PropertyOffset_48;

		// Token: 0x0400FBA3 RID: 64419
		internal static int __PropertyOffset_49;

		// Token: 0x0400FBA4 RID: 64420
		internal static int __PropertyOffset_50;

		// Token: 0x0400FBA5 RID: 64421
		private TArray<FName> _FootPointName;

		// Token: 0x0400FBA6 RID: 64422
		internal static int __PropertyOffset_51;

		// Token: 0x0400FBA7 RID: 64423
		internal static int __PropertyOffset_52;

		// Token: 0x0400FBA8 RID: 64424
		internal static int __PropertyOffset_53;

		// Token: 0x0400FBA9 RID: 64425
		internal static int __PropertyOffset_54;

		// Token: 0x0400FBAA RID: 64426
		internal static int __PropertyOffset_55;

		// Token: 0x0400FBAB RID: 64427
		internal static int __PropertyOffset_56;

		// Token: 0x0400FBAC RID: 64428
		private static IntPtr __SetCharacterComp_NativeFunctionPtr;

		// Token: 0x0400FBAD RID: 64429
		private static IntPtr __CheckIfHitSnow_NativeFunctionPtr;

		// Token: 0x0400FBAE RID: 64430
		private static IntPtr __UpdateCurrentSettings_NativeFunctionPtr;

		// Token: 0x0400FBAF RID: 64431
		private static IntPtr __Register_Trail_Lerp_NativeFunctionPtr;

		// Token: 0x0400FBB0 RID: 64432
		private static IntPtr __VisualizeCollSphere_NativeFunctionPtr;

		// Token: 0x0400FBB1 RID: 64433
		private static IntPtr __RenderTrail_NativeFunctionPtr;

		// Token: 0x0400FBB2 RID: 64434
		private static IntPtr __Register_Trail_NativeFunctionPtr;

		// Token: 0x0400FBB3 RID: 64435
		private static IntPtr __RegisterWeaponPoint_NativeFunctionPtr;

		// Token: 0x0400FBB4 RID: 64436
		private static IntPtr __CalculateLocation_NativeFunctionPtr;

		// Token: 0x0400FBB5 RID: 64437
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400FBB6 RID: 64438
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FBB7 RID: 64439
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FBB8 RID: 64440
		private static IntPtr __ChangeSettings_NativeFunctionPtr;

		// Token: 0x0400FBB9 RID: 64441
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0400FBBA RID: 64442
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x0400FBBB RID: 64443
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x02009BB9 RID: 39865
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetCharacterComp_FunctionParams
		{
			// Token: 0x04031237 RID: 201271
			[FieldOffset(0)]
			public bool bIsEnable;
		}

		// Token: 0x02009BBA RID: 39866
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __CheckIfHitSnow_FunctionParams
		{
			// Token: 0x04031238 RID: 201272
			[FieldOffset(0)]
			public bool IsHit;
		}

		// Token: 0x02009BBB RID: 39867
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 132)]
		protected ref struct __Register_Trail_Lerp_FunctionParams
		{
			// Token: 0x04031239 RID: 201273
			[FieldOffset(0)]
			public FVector Location;

			// Token: 0x0403123A RID: 201274
			[FieldOffset(12)]
			public float Size;
		}

		// Token: 0x02009BBC RID: 39868
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __VisualizeCollSphere_FunctionParams
		{
			// Token: 0x0403123B RID: 201275
			[FieldOffset(0)]
			public IntPtr Actor;
		}

		// Token: 0x02009BBD RID: 39869
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __Register_Trail_FunctionParams
		{
			// Token: 0x0403123C RID: 201276
			[FieldOffset(0)]
			public FVector TrialCompLocation;

			// Token: 0x0403123D RID: 201277
			[FieldOffset(12)]
			public float Radisu;

			// Token: 0x0403123E RID: 201278
			[FieldOffset(16)]
			public float Depth;

			// Token: 0x0403123F RID: 201279
			[FieldOffset(20)]
			public float Hardness;

			// Token: 0x04031240 RID: 201280
			[FieldOffset(24)]
			public float Rotation;
		}

		// Token: 0x02009BBE RID: 39870
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 100)]
		protected ref struct __RegisterWeaponPoint_FunctionParams
		{
			// Token: 0x04031241 RID: 201281
			[FieldOffset(0)]
			public FVector TrialCompLocation;

			// Token: 0x04031242 RID: 201282
			[FieldOffset(12)]
			public float Radius;

			// Token: 0x04031243 RID: 201283
			[FieldOffset(16)]
			public float Depth;
		}

		// Token: 0x02009BBF RID: 39871
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031244 RID: 201284
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BC0 RID: 39872
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031245 RID: 201285
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009BC1 RID: 39873
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x04031246 RID: 201286
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009BC2 RID: 39874
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x04031247 RID: 201287
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
