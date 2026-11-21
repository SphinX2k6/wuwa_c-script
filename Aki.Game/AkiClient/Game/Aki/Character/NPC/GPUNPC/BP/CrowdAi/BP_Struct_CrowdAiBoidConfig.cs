using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi
{
	// Token: 0x020032B5 RID: 12981
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_Struct_CrowdAiBoidConfig.BP_Struct_CrowdAiBoidConfig")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 312)]
	public class BP_Struct_CrowdAiBoidConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020BE4 RID: 134116 RVA: 0x0094E04B File Offset: 0x0094C24B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BP_Struct_CrowdAiBoidConfig._ScriptStructPtr != 0) ? BP_Struct_CrowdAiBoidConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_Struct_CrowdAiBoidConfig.BP_Struct_CrowdAiBoidConfig", ref BP_Struct_CrowdAiBoidConfig._ScriptStructPtr);
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x06020BE5 RID: 134117 RVA: 0x0094E06F File Offset: 0x0094C26F
		// (set) Token: 0x06020BE6 RID: 134118 RVA: 0x0094E07F File Offset: 0x0094C27F
		public unsafe float 半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_半径) = value;
			}
		}

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x06020BE7 RID: 134119 RVA: 0x0094E090 File Offset: 0x0094C290
		// (set) Token: 0x06020BE8 RID: 134120 RVA: 0x0094E0A0 File Offset: 0x0094C2A0
		public unsafe float 半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_半高);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_半高) = value;
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x06020BE9 RID: 134121 RVA: 0x0094E0B1 File Offset: 0x0094C2B1
		// (set) Token: 0x06020BEA RID: 134122 RVA: 0x0094E0C5 File Offset: 0x0094C2C5
		public unsafe FTransform 相对变换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_相对变换);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_相对变换) = value;
			}
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x06020BEB RID: 134123 RVA: 0x0094E0DA File Offset: 0x0094C2DA
		// (set) Token: 0x06020BEC RID: 134124 RVA: 0x0094E0EA File Offset: 0x0094C2EA
		public unsafe float 最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_最大速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_最大速度) = value;
			}
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x06020BED RID: 134125 RVA: 0x0094E0FB File Offset: 0x0094C2FB
		// (set) Token: 0x06020BEE RID: 134126 RVA: 0x0094E10B File Offset: 0x0094C30B
		public unsafe float 最大加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_最大加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_最大加速度) = value;
			}
		}

		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x06020BEF RID: 134127 RVA: 0x0094E11C File Offset: 0x0094C31C
		// (set) Token: 0x06020BF0 RID: 134128 RVA: 0x0094E12C File Offset: 0x0094C32C
		public unsafe float 移动半径缩放系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_移动半径缩放系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_移动半径缩放系数) = value;
			}
		}

		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x06020BF1 RID: 134129 RVA: 0x0094E13D File Offset: 0x0094C33D
		// (set) Token: 0x06020BF2 RID: 134130 RVA: 0x0094E14D File Offset: 0x0094C34D
		public unsafe float 地面转向摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_地面转向摩擦力);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_地面转向摩擦力) = value;
			}
		}

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x06020BF3 RID: 134131 RVA: 0x0094E15E File Offset: 0x0094C35E
		// (set) Token: 0x06020BF4 RID: 134132 RVA: 0x0094E16E File Offset: 0x0094C36E
		public unsafe float 转向插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_转向插值速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_转向插值速度) = value;
			}
		}

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x06020BF5 RID: 134133 RVA: 0x0094E17F File Offset: 0x0094C37F
		// (set) Token: 0x06020BF6 RID: 134134 RVA: 0x0094E18F File Offset: 0x0094C38F
		public unsafe float 移动表现阈值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_移动表现阈值速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_移动表现阈值速度) = value;
			}
		}

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x06020BF7 RID: 134135 RVA: 0x0094E1A0 File Offset: 0x0094C3A0
		// (set) Token: 0x06020BF8 RID: 134136 RVA: 0x0094E1B0 File Offset: 0x0094C3B0
		public unsafe float 待机表现阈值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_待机表现阈值速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_待机表现阈值速度) = value;
			}
		}

		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x06020BF9 RID: 134137 RVA: 0x0094E1C1 File Offset: 0x0094C3C1
		// (set) Token: 0x06020BFA RID: 134138 RVA: 0x0094E1D1 File Offset: 0x0094C3D1
		public unsafe float 斥力额外半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_斥力额外半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_斥力额外半径) = value;
			}
		}

		// Token: 0x170040E5 RID: 16613
		// (get) Token: 0x06020BFB RID: 134139 RVA: 0x0094E1E2 File Offset: 0x0094C3E2
		// (set) Token: 0x06020BFC RID: 134140 RVA: 0x0094E1F2 File Offset: 0x0094C3F2
		public unsafe float 移动斥力额外半径缩放系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_移动斥力额外半径缩放系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_移动斥力额外半径缩放系数) = value;
			}
		}

		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x06020BFD RID: 134141 RVA: 0x0094E203 File Offset: 0x0094C403
		// (set) Token: 0x06020BFE RID: 134142 RVA: 0x0094E213 File Offset: 0x0094C413
		public unsafe float 临近目标减速距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_临近目标减速距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_临近目标减速距离) = value;
			}
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x06020BFF RID: 134143 RVA: 0x0094E224 File Offset: 0x0094C424
		// (set) Token: 0x06020C00 RID: 134144 RVA: 0x0094E234 File Offset: 0x0094C434
		public unsafe float 边界空气墙距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_边界空气墙距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_边界空气墙距离) = value;
			}
		}

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x06020C01 RID: 134145 RVA: 0x0094E245 File Offset: 0x0094C445
		// (set) Token: 0x06020C02 RID: 134146 RVA: 0x0094E255 File Offset: 0x0094C455
		public unsafe float 额外探测距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_额外探测距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_额外探测距离) = value;
			}
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x06020C03 RID: 134147 RVA: 0x0094E266 File Offset: 0x0094C466
		// (set) Token: 0x06020C04 RID: 134148 RVA: 0x0094E276 File Offset: 0x0094C476
		public unsafe float 待机表演最小冷却时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_待机表演最小冷却时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_待机表演最小冷却时间) = value;
			}
		}

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x06020C05 RID: 134149 RVA: 0x0094E287 File Offset: 0x0094C487
		// (set) Token: 0x06020C06 RID: 134150 RVA: 0x0094E297 File Offset: 0x0094C497
		public unsafe float 待机表演最大冷却时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_待机表演最大冷却时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_待机表演最大冷却时间) = value;
			}
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x06020C07 RID: 134151 RVA: 0x0094E2A8 File Offset: 0x0094C4A8
		// (set) Token: 0x06020C08 RID: 134152 RVA: 0x0094E2B8 File Offset: 0x0094C4B8
		public unsafe float 待机表演最大比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_待机表演最大比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_待机表演最大比例) = value;
			}
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x06020C09 RID: 134153 RVA: 0x0094E2CC File Offset: 0x0094C4CC
		// (set) Token: 0x06020C0A RID: 134154 RVA: 0x0094E30F File Offset: 0x0094C50F
		public TMap<int, EKuroCrowdAiBoidAnimState> 状态配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, EKuroCrowdAiBoidAnimState> result;
				if ((result = this._状态配置) == null)
				{
					result = (this._状态配置 = new TMap<int, EKuroCrowdAiBoidAnimState>(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_状态配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.状态配置.CopyAssign(value);
			}
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x06020C0B RID: 134155 RVA: 0x0094E320 File Offset: 0x0094C520
		// (set) Token: 0x06020C0C RID: 134156 RVA: 0x0094E363 File Offset: 0x0094C563
		public TArray<FKuroCrowdAiAnimSequenceConfig> 动画配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCrowdAiAnimSequenceConfig> result;
				if ((result = this._动画配置) == null)
				{
					result = (this._动画配置 = new TArray<FKuroCrowdAiAnimSequenceConfig>(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_动画配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.动画配置.CopyAssign(value);
			}
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x06020C0D RID: 134157 RVA: 0x0094E374 File Offset: 0x0094C574
		// (set) Token: 0x06020C0E RID: 134158 RVA: 0x0094E3B7 File Offset: 0x0094C5B7
		public TMap<UKuroMaterialControllerDataAsset, int> 材质贴图DA配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKuroMaterialControllerDataAsset, int> result;
				if ((result = this._材质贴图DA配置) == null)
				{
					result = (this._材质贴图DA配置 = new TMap<UKuroMaterialControllerDataAsset, int>(base.NativePtr + (IntPtr)BP_Struct_CrowdAiBoidConfig.__PropertyOffset_材质贴图DA配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.材质贴图DA配置.CopyAssign(value);
			}
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x06020C0F RID: 134159 RVA: 0x0094E3C5 File Offset: 0x0094C5C5
		// (set) Token: 0x06020C10 RID: 134160 RVA: 0x0094E3D9 File Offset: 0x0094C5D9
		[Nullable(2)]
		public unsafe GPUNPCData_C GpuNpcDa
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<GPUNPCData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Struct_CrowdAiBoidConfig.__PropertyOffset_GpuNpcDa);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Struct_CrowdAiBoidConfig.__PropertyOffset_GpuNpcDa, value);
			}
		}

		// Token: 0x06020C11 RID: 134161 RVA: 0x0094E3EE File Offset: 0x0094C5EE
		public BP_Struct_CrowdAiBoidConfig()
		{
		}

		// Token: 0x06020C12 RID: 134162 RVA: 0x0094E3F6 File Offset: 0x0094C5F6
		protected override IntPtr GetUStructPtr()
		{
			return BP_Struct_CrowdAiBoidConfig.StaticStruct();
		}

		// Token: 0x06020C13 RID: 134163 RVA: 0x0094E402 File Offset: 0x0094C602
		[NullableContext(2)]
		public BP_Struct_CrowdAiBoidConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020C14 RID: 134164 RVA: 0x0094E40C File Offset: 0x0094C60C
		public BP_Struct_CrowdAiBoidConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020C15 RID: 134165 RVA: 0x0094E417 File Offset: 0x0094C617
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BP_Struct_CrowdAiBoidConfig(Pointer, false, true);
		}

		// Token: 0x06020C16 RID: 134166 RVA: 0x0094E421 File Offset: 0x0094C621
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BP_Struct_CrowdAiBoidConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04011B64 RID: 72548
		public const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_Struct_CrowdAiBoidConfig.BP_Struct_CrowdAiBoidConfig";

		// Token: 0x04011B65 RID: 72549
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B66 RID: 72550
		internal static int __PropertyOffset_半径;

		// Token: 0x04011B67 RID: 72551
		internal static int __PropertyOffset_半高;

		// Token: 0x04011B68 RID: 72552
		internal static int __PropertyOffset_相对变换;

		// Token: 0x04011B69 RID: 72553
		internal static int __PropertyOffset_最大速度;

		// Token: 0x04011B6A RID: 72554
		internal static int __PropertyOffset_最大加速度;

		// Token: 0x04011B6B RID: 72555
		internal static int __PropertyOffset_移动半径缩放系数;

		// Token: 0x04011B6C RID: 72556
		internal static int __PropertyOffset_地面转向摩擦力;

		// Token: 0x04011B6D RID: 72557
		internal static int __PropertyOffset_转向插值速度;

		// Token: 0x04011B6E RID: 72558
		internal static int __PropertyOffset_移动表现阈值速度;

		// Token: 0x04011B6F RID: 72559
		internal static int __PropertyOffset_待机表现阈值速度;

		// Token: 0x04011B70 RID: 72560
		internal static int __PropertyOffset_斥力额外半径;

		// Token: 0x04011B71 RID: 72561
		internal static int __PropertyOffset_移动斥力额外半径缩放系数;

		// Token: 0x04011B72 RID: 72562
		internal static int __PropertyOffset_临近目标减速距离;

		// Token: 0x04011B73 RID: 72563
		internal static int __PropertyOffset_边界空气墙距离;

		// Token: 0x04011B74 RID: 72564
		internal static int __PropertyOffset_额外探测距离;

		// Token: 0x04011B75 RID: 72565
		internal static int __PropertyOffset_待机表演最小冷却时间;

		// Token: 0x04011B76 RID: 72566
		internal static int __PropertyOffset_待机表演最大冷却时间;

		// Token: 0x04011B77 RID: 72567
		internal static int __PropertyOffset_待机表演最大比例;

		// Token: 0x04011B78 RID: 72568
		internal static int __PropertyOffset_状态配置;

		// Token: 0x04011B79 RID: 72569
		[Nullable(2)]
		private TMap<int, EKuroCrowdAiBoidAnimState> _状态配置;

		// Token: 0x04011B7A RID: 72570
		internal static int __PropertyOffset_动画配置;

		// Token: 0x04011B7B RID: 72571
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCrowdAiAnimSequenceConfig> _动画配置;

		// Token: 0x04011B7C RID: 72572
		internal static int __PropertyOffset_材质贴图DA配置;

		// Token: 0x04011B7D RID: 72573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKuroMaterialControllerDataAsset, int> _材质贴图DA配置;

		// Token: 0x04011B7E RID: 72574
		internal static int __PropertyOffset_GpuNpcDa;
	}
}
