using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi
{
	// Token: 0x02004198 RID: 16792
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_Struct_CrowdAiBoidConfig.BP_Struct_CrowdAiBoidConfig")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 312)]
	public class BP_Struct_CrowdAiBoidConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602B932 RID: 178482 RVA: 0x00A043E7 File Offset: 0x00A025E7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BP_Struct_CrowdAiBoidConfig._ScriptStructPtr != 0) ? BP_Struct_CrowdAiBoidConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_Struct_CrowdAiBoidConfig.BP_Struct_CrowdAiBoidConfig", ref BP_Struct_CrowdAiBoidConfig._ScriptStructPtr);
		}

		// Token: 0x17006BEA RID: 27626
		// (get) Token: 0x0602B933 RID: 178483 RVA: 0x00A0440B File Offset: 0x00A0260B
		// (set) Token: 0x0602B934 RID: 178484 RVA: 0x00A0441B File Offset: 0x00A0261B
		public unsafe float 半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006BEB RID: 27627
		// (get) Token: 0x0602B935 RID: 178485 RVA: 0x00A0442C File Offset: 0x00A0262C
		// (set) Token: 0x0602B936 RID: 178486 RVA: 0x00A0443C File Offset: 0x00A0263C
		public unsafe float 半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006BEC RID: 27628
		// (get) Token: 0x0602B937 RID: 178487 RVA: 0x00A0444D File Offset: 0x00A0264D
		// (set) Token: 0x0602B938 RID: 178488 RVA: 0x00A04461 File Offset: 0x00A02661
		public unsafe FTransform 相对变换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006BED RID: 27629
		// (get) Token: 0x0602B939 RID: 178489 RVA: 0x00A04476 File Offset: 0x00A02676
		// (set) Token: 0x0602B93A RID: 178490 RVA: 0x00A04486 File Offset: 0x00A02686
		public unsafe float 最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006BEE RID: 27630
		// (get) Token: 0x0602B93B RID: 178491 RVA: 0x00A04497 File Offset: 0x00A02697
		// (set) Token: 0x0602B93C RID: 178492 RVA: 0x00A044A7 File Offset: 0x00A026A7
		public unsafe float 最大加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006BEF RID: 27631
		// (get) Token: 0x0602B93D RID: 178493 RVA: 0x00A044B8 File Offset: 0x00A026B8
		// (set) Token: 0x0602B93E RID: 178494 RVA: 0x00A044C8 File Offset: 0x00A026C8
		public unsafe float 移动半径缩放系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006BF0 RID: 27632
		// (get) Token: 0x0602B93F RID: 178495 RVA: 0x00A044D9 File Offset: 0x00A026D9
		// (set) Token: 0x0602B940 RID: 178496 RVA: 0x00A044E9 File Offset: 0x00A026E9
		public unsafe float 地面转向摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006BF1 RID: 27633
		// (get) Token: 0x0602B941 RID: 178497 RVA: 0x00A044FA File Offset: 0x00A026FA
		// (set) Token: 0x0602B942 RID: 178498 RVA: 0x00A0450A File Offset: 0x00A0270A
		public unsafe float 转向插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006BF2 RID: 27634
		// (get) Token: 0x0602B943 RID: 178499 RVA: 0x00A0451B File Offset: 0x00A0271B
		// (set) Token: 0x0602B944 RID: 178500 RVA: 0x00A0452B File Offset: 0x00A0272B
		public unsafe float 移动表现阈值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006BF3 RID: 27635
		// (get) Token: 0x0602B945 RID: 178501 RVA: 0x00A0453C File Offset: 0x00A0273C
		// (set) Token: 0x0602B946 RID: 178502 RVA: 0x00A0454C File Offset: 0x00A0274C
		public unsafe float 待机表现阈值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006BF4 RID: 27636
		// (get) Token: 0x0602B947 RID: 178503 RVA: 0x00A0455D File Offset: 0x00A0275D
		// (set) Token: 0x0602B948 RID: 178504 RVA: 0x00A0456D File Offset: 0x00A0276D
		public unsafe float 斥力额外半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006BF5 RID: 27637
		// (get) Token: 0x0602B949 RID: 178505 RVA: 0x00A0457E File Offset: 0x00A0277E
		// (set) Token: 0x0602B94A RID: 178506 RVA: 0x00A0458E File Offset: 0x00A0278E
		public unsafe float 移动斥力额外半径缩放系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006BF6 RID: 27638
		// (get) Token: 0x0602B94B RID: 178507 RVA: 0x00A0459F File Offset: 0x00A0279F
		// (set) Token: 0x0602B94C RID: 178508 RVA: 0x00A045AF File Offset: 0x00A027AF
		public unsafe float 临近目标减速距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006BF7 RID: 27639
		// (get) Token: 0x0602B94D RID: 178509 RVA: 0x00A045C0 File Offset: 0x00A027C0
		// (set) Token: 0x0602B94E RID: 178510 RVA: 0x00A045D0 File Offset: 0x00A027D0
		public unsafe float 边界空气墙距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006BF8 RID: 27640
		// (get) Token: 0x0602B94F RID: 178511 RVA: 0x00A045E1 File Offset: 0x00A027E1
		// (set) Token: 0x0602B950 RID: 178512 RVA: 0x00A045F1 File Offset: 0x00A027F1
		public unsafe float 额外探测距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006BF9 RID: 27641
		// (get) Token: 0x0602B951 RID: 178513 RVA: 0x00A04602 File Offset: 0x00A02802
		// (set) Token: 0x0602B952 RID: 178514 RVA: 0x00A04612 File Offset: 0x00A02812
		public unsafe float 待机表演最小冷却时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006BFA RID: 27642
		// (get) Token: 0x0602B953 RID: 178515 RVA: 0x00A04623 File Offset: 0x00A02823
		// (set) Token: 0x0602B954 RID: 178516 RVA: 0x00A04633 File Offset: 0x00A02833
		public unsafe float 待机表演最大冷却时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006BFB RID: 27643
		// (get) Token: 0x0602B955 RID: 178517 RVA: 0x00A04644 File Offset: 0x00A02844
		// (set) Token: 0x0602B956 RID: 178518 RVA: 0x00A04654 File Offset: 0x00A02854
		public unsafe float 待机表演最大比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006BFC RID: 27644
		// (get) Token: 0x0602B957 RID: 178519 RVA: 0x00A04668 File Offset: 0x00A02868
		// (set) Token: 0x0602B958 RID: 178520 RVA: 0x00A046AB File Offset: 0x00A028AB
		public TMap<int, EKuroCrowdAiBoidAnimState> 状态配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, EKuroCrowdAiBoidAnimState> result;
				if ((result = this._状态配置) == null)
				{
					result = (this._状态配置 = new TMap<int, EKuroCrowdAiBoidAnimState>(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_18, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.状态配置.CopyAssign(value);
			}
		}

		// Token: 0x17006BFD RID: 27645
		// (get) Token: 0x0602B959 RID: 178521 RVA: 0x00A046BC File Offset: 0x00A028BC
		// (set) Token: 0x0602B95A RID: 178522 RVA: 0x00A046FF File Offset: 0x00A028FF
		public TArray<FKuroCrowdAiAnimSequenceConfig> 动画配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCrowdAiAnimSequenceConfig> result;
				if ((result = this._动画配置) == null)
				{
					result = (this._动画配置 = new TArray<FKuroCrowdAiAnimSequenceConfig>(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_19, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.动画配置.CopyAssign(value);
			}
		}

		// Token: 0x17006BFE RID: 27646
		// (get) Token: 0x0602B95B RID: 178523 RVA: 0x00A04710 File Offset: 0x00A02910
		// (set) Token: 0x0602B95C RID: 178524 RVA: 0x00A04753 File Offset: 0x00A02953
		public TMap<UKuroMaterialControllerDataAsset, int> 材质贴图DA配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKuroMaterialControllerDataAsset, int> result;
				if ((result = this._材质贴图DA配置) == null)
				{
					result = (this._材质贴图DA配置 = new TMap<UKuroMaterialControllerDataAsset, int>(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_20, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.材质贴图DA配置.CopyAssign(value);
			}
		}

		// Token: 0x17006BFF RID: 27647
		// (get) Token: 0x0602B95D RID: 178525 RVA: 0x00A04761 File Offset: 0x00A02961
		// (set) Token: 0x0602B95E RID: 178526 RVA: 0x00A04775 File Offset: 0x00A02975
		[Nullable(2)]
		public unsafe GPUNPCData_C GpuNpcDa
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<GPUNPCData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Struct_CrowdAiBoidConfig.__PropertyOffset_21);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Struct_CrowdAiBoidConfig.__PropertyOffset_21, value);
			}
		}

		// Token: 0x0602B95F RID: 178527 RVA: 0x00A0478A File Offset: 0x00A0298A
		public BP_Struct_CrowdAiBoidConfig()
		{
		}

		// Token: 0x0602B960 RID: 178528 RVA: 0x00A04794 File Offset: 0x00A02994
		public BP_Struct_CrowdAiBoidConfig(float 半径, float 半高, FTransform 相对变换, float 最大速度, float 最大加速度, float 移动半径缩放系数, float 地面转向摩擦力, float 转向插值速度, float 移动表现阈值速度, float 待机表现阈值速度, float 斥力额外半径, float 移动斥力额外半径缩放系数, float 临近目标减速距离, float 边界空气墙距离, float 额外探测距离, float 待机表演最小冷却时间, float 待机表演最大冷却时间, float 待机表演最大比例, TMap<int, EKuroCrowdAiBoidAnimState> 状态配置, TArray<FKuroCrowdAiAnimSequenceConfig> 动画配置, TMap<UKuroMaterialControllerDataAsset, int> 材质贴图DA配置, GPUNPCData_C GpuNpcDa)
		{
			this.半径 = 半径;
			this.半高 = 半高;
			this.相对变换 = 相对变换;
			this.最大速度 = 最大速度;
			this.最大加速度 = 最大加速度;
			this.移动半径缩放系数 = 移动半径缩放系数;
			this.地面转向摩擦力 = 地面转向摩擦力;
			this.转向插值速度 = 转向插值速度;
			this.移动表现阈值速度 = 移动表现阈值速度;
			this.待机表现阈值速度 = 待机表现阈值速度;
			this.斥力额外半径 = 斥力额外半径;
			this.移动斥力额外半径缩放系数 = 移动斥力额外半径缩放系数;
			this.临近目标减速距离 = 临近目标减速距离;
			this.边界空气墙距离 = 边界空气墙距离;
			this.额外探测距离 = 额外探测距离;
			this.待机表演最小冷却时间 = 待机表演最小冷却时间;
			this.待机表演最大冷却时间 = 待机表演最大冷却时间;
			this.待机表演最大比例 = 待机表演最大比例;
			this.状态配置 = 状态配置;
			this.动画配置 = 动画配置;
			this.材质贴图DA配置 = 材质贴图DA配置;
			this.GpuNpcDa = GpuNpcDa;
		}

		// Token: 0x0602B961 RID: 178529 RVA: 0x00A04854 File Offset: 0x00A02A54
		protected override IntPtr GetUStructPtr()
		{
			return BP_Struct_CrowdAiBoidConfig.StaticStruct();
		}

		// Token: 0x0602B962 RID: 178530 RVA: 0x00A04860 File Offset: 0x00A02A60
		[NullableContext(2)]
		public BP_Struct_CrowdAiBoidConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602B963 RID: 178531 RVA: 0x00A0486A File Offset: 0x00A02A6A
		public BP_Struct_CrowdAiBoidConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602B964 RID: 178532 RVA: 0x00A04875 File Offset: 0x00A02A75
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BP_Struct_CrowdAiBoidConfig(Pointer, false, true);
		}

		// Token: 0x0602B965 RID: 178533 RVA: 0x00A0487F File Offset: 0x00A02A7F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BP_Struct_CrowdAiBoidConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04016AFA RID: 92922
		public const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_Struct_CrowdAiBoidConfig.BP_Struct_CrowdAiBoidConfig";

		// Token: 0x04016AFB RID: 92923
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016AFC RID: 92924
		internal static int __PropertyOffset_0;

		// Token: 0x04016AFD RID: 92925
		internal static int __PropertyOffset_1;

		// Token: 0x04016AFE RID: 92926
		internal static int __PropertyOffset_2;

		// Token: 0x04016AFF RID: 92927
		internal static int __PropertyOffset_3;

		// Token: 0x04016B00 RID: 92928
		internal static int __PropertyOffset_4;

		// Token: 0x04016B01 RID: 92929
		internal static int __PropertyOffset_5;

		// Token: 0x04016B02 RID: 92930
		internal static int __PropertyOffset_6;

		// Token: 0x04016B03 RID: 92931
		internal static int __PropertyOffset_7;

		// Token: 0x04016B04 RID: 92932
		internal static int __PropertyOffset_8;

		// Token: 0x04016B05 RID: 92933
		internal static int __PropertyOffset_9;

		// Token: 0x04016B06 RID: 92934
		internal static int __PropertyOffset_10;

		// Token: 0x04016B07 RID: 92935
		internal static int __PropertyOffset_11;

		// Token: 0x04016B08 RID: 92936
		internal static int __PropertyOffset_12;

		// Token: 0x04016B09 RID: 92937
		internal static int __PropertyOffset_13;

		// Token: 0x04016B0A RID: 92938
		internal static int __PropertyOffset_14;

		// Token: 0x04016B0B RID: 92939
		internal static int __PropertyOffset_15;

		// Token: 0x04016B0C RID: 92940
		internal static int __PropertyOffset_16;

		// Token: 0x04016B0D RID: 92941
		internal static int __PropertyOffset_17;

		// Token: 0x04016B0E RID: 92942
		internal static int __PropertyOffset_18;

		// Token: 0x04016B0F RID: 92943
		[Nullable(2)]
		private TMap<int, EKuroCrowdAiBoidAnimState> _状态配置;

		// Token: 0x04016B10 RID: 92944
		internal static int __PropertyOffset_19;

		// Token: 0x04016B11 RID: 92945
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCrowdAiAnimSequenceConfig> _动画配置;

		// Token: 0x04016B12 RID: 92946
		internal static int __PropertyOffset_20;

		// Token: 0x04016B13 RID: 92947
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKuroMaterialControllerDataAsset, int> _材质贴图DA配置;

		// Token: 0x04016B14 RID: 92948
		internal static int __PropertyOffset_21;
	}
}
