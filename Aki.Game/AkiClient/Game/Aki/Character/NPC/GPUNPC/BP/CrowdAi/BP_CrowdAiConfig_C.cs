using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi
{
	// Token: 0x020032B4 RID: 12980
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiConfig.BP_CrowdAiConfig_C")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 196)]
	public class BP_CrowdAiConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020BAC RID: 134060 RVA: 0x0094DC3E File Offset: 0x0094BE3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CrowdAiConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiConfig.BP_CrowdAiConfig_C");
			}
			return BP_CrowdAiConfig_C._ClassPtr;
		}

		// Token: 0x06020BAD RID: 134061 RVA: 0x0094DC64 File Offset: 0x0094BE64
		public BP_CrowdAiConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_CrowdAiConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020BAE RID: 134062 RVA: 0x0094DC8C File Offset: 0x0094BE8C
		public BP_CrowdAiConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CrowdAiConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x06020BAF RID: 134063 RVA: 0x0094DCBF File Offset: 0x0094BEBF
		// (set) Token: 0x06020BB0 RID: 134064 RVA: 0x0094DCCF File Offset: 0x0094BECF
		public unsafe bool 启用Navmesh贴地修正
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_启用Navmesh贴地修正) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_启用Navmesh贴地修正) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x06020BB1 RID: 134065 RVA: 0x0094DCE0 File Offset: 0x0094BEE0
		// (set) Token: 0x06020BB2 RID: 134066 RVA: 0x0094DCF0 File Offset: 0x0094BEF0
		public unsafe float 分组最大距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_分组最大距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_分组最大距离) = value;
			}
		}

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x06020BB3 RID: 134067 RVA: 0x0094DD04 File Offset: 0x0094BF04
		// (set) Token: 0x06020BB4 RID: 134068 RVA: 0x0094DD3D File Offset: 0x0094BF3D
		public TArray<BP_Struct_CrowdAiBoidConfig> Boid种类配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_Struct_CrowdAiBoidConfig> result;
				if ((result = this._Boid种类配置) == null)
				{
					result = (this._Boid种类配置 = new TArray<BP_Struct_CrowdAiBoidConfig>(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_Boid种类配置, this));
				}
				return result;
			}
			set
			{
				this.Boid种类配置.CopyAssign(value);
			}
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x06020BB5 RID: 134069 RVA: 0x0094DD4B File Offset: 0x0094BF4B
		// (set) Token: 0x06020BB6 RID: 134070 RVA: 0x0094DD5B File Offset: 0x0094BF5B
		public unsafe bool 启用传送
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_启用传送) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_启用传送) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x06020BB7 RID: 134071 RVA: 0x0094DD6C File Offset: 0x0094BF6C
		// (set) Token: 0x06020BB8 RID: 134072 RVA: 0x0094DD7C File Offset: 0x0094BF7C
		public unsafe float 传送最小计数时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_传送最小计数时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_传送最小计数时间) = value;
			}
		}

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x06020BB9 RID: 134073 RVA: 0x0094DD8D File Offset: 0x0094BF8D
		// (set) Token: 0x06020BBA RID: 134074 RVA: 0x0094DD9D File Offset: 0x0094BF9D
		public unsafe float 传送最大计数时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_传送最大计数时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_传送最大计数时间) = value;
			}
		}

		// Token: 0x170040C6 RID: 16582
		// (get) Token: 0x06020BBB RID: 134075 RVA: 0x0094DDAE File Offset: 0x0094BFAE
		// (set) Token: 0x06020BBC RID: 134076 RVA: 0x0094DDBE File Offset: 0x0094BFBE
		public unsafe float 传送目标最大半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_传送目标最大半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_传送目标最大半径) = value;
			}
		}

		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x06020BBD RID: 134077 RVA: 0x0094DDCF File Offset: 0x0094BFCF
		// (set) Token: 0x06020BBE RID: 134078 RVA: 0x0094DDDF File Offset: 0x0094BFDF
		public unsafe float 传送目标最小半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_传送目标最小半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_传送目标最小半径) = value;
			}
		}

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x06020BBF RID: 134079 RVA: 0x0094DDF0 File Offset: 0x0094BFF0
		// (set) Token: 0x06020BC0 RID: 134080 RVA: 0x0094DE00 File Offset: 0x0094C000
		public unsafe float 玩家移动半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_玩家移动半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_玩家移动半径) = value;
			}
		}

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x06020BC1 RID: 134081 RVA: 0x0094DE11 File Offset: 0x0094C011
		// (set) Token: 0x06020BC2 RID: 134082 RVA: 0x0094DE21 File Offset: 0x0094C021
		public unsafe float 玩家待机半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_玩家待机半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_玩家待机半径) = value;
			}
		}

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x06020BC3 RID: 134083 RVA: 0x0094DE32 File Offset: 0x0094C032
		// (set) Token: 0x06020BC4 RID: 134084 RVA: 0x0094DE42 File Offset: 0x0094C042
		public unsafe float 玩家半径变化时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_玩家半径变化时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_玩家半径变化时间) = value;
			}
		}

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x06020BC5 RID: 134085 RVA: 0x0094DE53 File Offset: 0x0094C053
		// (set) Token: 0x06020BC6 RID: 134086 RVA: 0x0094DE63 File Offset: 0x0094C063
		public unsafe bool 启用跟随区域限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_启用跟随区域限制) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_启用跟随区域限制) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x06020BC7 RID: 134087 RVA: 0x0094DE74 File Offset: 0x0094C074
		// (set) Token: 0x06020BC8 RID: 134088 RVA: 0x0094DE84 File Offset: 0x0094C084
		public unsafe float 停驻最小目标距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_停驻最小目标距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_停驻最小目标距离) = value;
			}
		}

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x06020BC9 RID: 134089 RVA: 0x0094DE95 File Offset: 0x0094C095
		// (set) Token: 0x06020BCA RID: 134090 RVA: 0x0094DEA5 File Offset: 0x0094C0A5
		public unsafe float 触发传送最小垂直距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_触发传送最小垂直距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_触发传送最小垂直距离) = value;
			}
		}

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x06020BCB RID: 134091 RVA: 0x0094DEB6 File Offset: 0x0094C0B6
		// (set) Token: 0x06020BCC RID: 134092 RVA: 0x0094DEC6 File Offset: 0x0094C0C6
		public unsafe float 触发传送最小水平距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_触发传送最小水平距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_触发传送最小水平距离) = value;
			}
		}

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x06020BCD RID: 134093 RVA: 0x0094DED7 File Offset: 0x0094C0D7
		// (set) Token: 0x06020BCE RID: 134094 RVA: 0x0094DEE7 File Offset: 0x0094C0E7
		public unsafe float 暂停传送最大水平速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_暂停传送最大水平速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_暂停传送最大水平速度) = value;
			}
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x06020BCF RID: 134095 RVA: 0x0094DEF8 File Offset: 0x0094C0F8
		// (set) Token: 0x06020BD0 RID: 134096 RVA: 0x0094DF08 File Offset: 0x0094C108
		public unsafe int 最大尝试寻点次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_最大尝试寻点次数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_最大尝试寻点次数) = value;
			}
		}

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x06020BD1 RID: 134097 RVA: 0x0094DF19 File Offset: 0x0094C119
		// (set) Token: 0x06020BD2 RID: 134098 RVA: 0x0094DF29 File Offset: 0x0094C129
		public unsafe float 跟随扇形区域夹角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_跟随扇形区域夹角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_跟随扇形区域夹角) = value;
			}
		}

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x06020BD3 RID: 134099 RVA: 0x0094DF3A File Offset: 0x0094C13A
		// (set) Token: 0x06020BD4 RID: 134100 RVA: 0x0094DF4A File Offset: 0x0094C14A
		public unsafe float 跟随扇形区域两边长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_跟随扇形区域两边长度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_跟随扇形区域两边长度) = value;
			}
		}

		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x06020BD5 RID: 134101 RVA: 0x0094DF5B File Offset: 0x0094C15B
		// (set) Token: 0x06020BD6 RID: 134102 RVA: 0x0094DF6B File Offset: 0x0094C16B
		public unsafe float 跟随扇形区域底边半长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_跟随扇形区域底边半长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_跟随扇形区域底边半长) = value;
			}
		}

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x06020BD7 RID: 134103 RVA: 0x0094DF7C File Offset: 0x0094C17C
		// (set) Token: 0x06020BD8 RID: 134104 RVA: 0x0094DF8C File Offset: 0x0094C18C
		public unsafe float 跟随扇形区域底边距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_跟随扇形区域底边距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_跟随扇形区域底边距离) = value;
			}
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x06020BD9 RID: 134105 RVA: 0x0094DF9D File Offset: 0x0094C19D
		// (set) Token: 0x06020BDA RID: 134106 RVA: 0x0094DFAD File Offset: 0x0094C1AD
		public unsafe float 停驻计时时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_停驻计时时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_停驻计时时间) = value;
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x06020BDB RID: 134107 RVA: 0x0094DFBE File Offset: 0x0094C1BE
		// (set) Token: 0x06020BDC RID: 134108 RVA: 0x0094DFCE File Offset: 0x0094C1CE
		public unsafe float 停驻最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_停驻最大速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_停驻最大速度) = value;
			}
		}

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x06020BDD RID: 134109 RVA: 0x0094DFDF File Offset: 0x0094C1DF
		// (set) Token: 0x06020BDE RID: 134110 RVA: 0x0094DFEF File Offset: 0x0094C1EF
		public unsafe float 出生最大随机延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_出生最大随机延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_出生最大随机延迟时间) = value;
			}
		}

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x06020BDF RID: 134111 RVA: 0x0094E000 File Offset: 0x0094C200
		// (set) Token: 0x06020BE0 RID: 134112 RVA: 0x0094E010 File Offset: 0x0094C210
		public unsafe float 销毁最大随机延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_销毁最大随机延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_销毁最大随机延迟时间) = value;
			}
		}

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x06020BE1 RID: 134113 RVA: 0x0094E021 File Offset: 0x0094C221
		// (set) Token: 0x06020BE2 RID: 134114 RVA: 0x0094E031 File Offset: 0x0094C231
		public unsafe float 组寻路间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_组寻路间隔);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_组寻路间隔) = value;
			}
		}

		// Token: 0x06020BE3 RID: 134115 RVA: 0x0094E042 File Offset: 0x0094C242
		protected BP_CrowdAiConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B46 RID: 72518
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiConfig.BP_CrowdAiConfig_C";

		// Token: 0x04011B47 RID: 72519
		private static IntPtr _ClassPtr;

		// Token: 0x04011B48 RID: 72520
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B49 RID: 72521
		internal static int __PropertyOffset_启用Navmesh贴地修正;

		// Token: 0x04011B4A RID: 72522
		internal static int __PropertyOffset_分组最大距离;

		// Token: 0x04011B4B RID: 72523
		internal static int __PropertyOffset_Boid种类配置;

		// Token: 0x04011B4C RID: 72524
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_Struct_CrowdAiBoidConfig> _Boid种类配置;

		// Token: 0x04011B4D RID: 72525
		internal static int __PropertyOffset_启用传送;

		// Token: 0x04011B4E RID: 72526
		internal static int __PropertyOffset_传送最小计数时间;

		// Token: 0x04011B4F RID: 72527
		internal static int __PropertyOffset_传送最大计数时间;

		// Token: 0x04011B50 RID: 72528
		internal static int __PropertyOffset_传送目标最大半径;

		// Token: 0x04011B51 RID: 72529
		internal static int __PropertyOffset_传送目标最小半径;

		// Token: 0x04011B52 RID: 72530
		internal static int __PropertyOffset_玩家移动半径;

		// Token: 0x04011B53 RID: 72531
		internal static int __PropertyOffset_玩家待机半径;

		// Token: 0x04011B54 RID: 72532
		internal static int __PropertyOffset_玩家半径变化时间;

		// Token: 0x04011B55 RID: 72533
		internal static int __PropertyOffset_启用跟随区域限制;

		// Token: 0x04011B56 RID: 72534
		internal static int __PropertyOffset_停驻最小目标距离;

		// Token: 0x04011B57 RID: 72535
		internal static int __PropertyOffset_触发传送最小垂直距离;

		// Token: 0x04011B58 RID: 72536
		internal static int __PropertyOffset_触发传送最小水平距离;

		// Token: 0x04011B59 RID: 72537
		internal static int __PropertyOffset_暂停传送最大水平速度;

		// Token: 0x04011B5A RID: 72538
		internal static int __PropertyOffset_最大尝试寻点次数;

		// Token: 0x04011B5B RID: 72539
		internal static int __PropertyOffset_跟随扇形区域夹角;

		// Token: 0x04011B5C RID: 72540
		internal static int __PropertyOffset_跟随扇形区域两边长度;

		// Token: 0x04011B5D RID: 72541
		internal static int __PropertyOffset_跟随扇形区域底边半长;

		// Token: 0x04011B5E RID: 72542
		internal static int __PropertyOffset_跟随扇形区域底边距离;

		// Token: 0x04011B5F RID: 72543
		internal static int __PropertyOffset_停驻计时时间;

		// Token: 0x04011B60 RID: 72544
		internal static int __PropertyOffset_停驻最大速度;

		// Token: 0x04011B61 RID: 72545
		internal static int __PropertyOffset_出生最大随机延迟时间;

		// Token: 0x04011B62 RID: 72546
		internal static int __PropertyOffset_销毁最大随机延迟时间;

		// Token: 0x04011B63 RID: 72547
		internal static int __PropertyOffset_组寻路间隔;
	}
}
