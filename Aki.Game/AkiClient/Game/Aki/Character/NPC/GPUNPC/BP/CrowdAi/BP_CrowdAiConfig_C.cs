using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi
{
	// Token: 0x02004197 RID: 16791
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiConfig.BP_CrowdAiConfig_C")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 196)]
	public class BP_CrowdAiConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B8FA RID: 178426 RVA: 0x00A03FDB File Offset: 0x00A021DB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CrowdAiConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiConfig.BP_CrowdAiConfig_C");
			}
			return BP_CrowdAiConfig_C._ClassPtr;
		}

		// Token: 0x0602B8FB RID: 178427 RVA: 0x00A04000 File Offset: 0x00A02200
		public BP_CrowdAiConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_CrowdAiConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B8FC RID: 178428 RVA: 0x00A04028 File Offset: 0x00A02228
		public BP_CrowdAiConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CrowdAiConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006BD0 RID: 27600
		// (get) Token: 0x0602B8FD RID: 178429 RVA: 0x00A0405B File Offset: 0x00A0225B
		// (set) Token: 0x0602B8FE RID: 178430 RVA: 0x00A0406B File Offset: 0x00A0226B
		public unsafe bool 启用Navmesh贴地修正
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BD1 RID: 27601
		// (get) Token: 0x0602B8FF RID: 178431 RVA: 0x00A0407C File Offset: 0x00A0227C
		// (set) Token: 0x0602B900 RID: 178432 RVA: 0x00A0408C File Offset: 0x00A0228C
		public unsafe float 分组最大距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006BD2 RID: 27602
		// (get) Token: 0x0602B901 RID: 178433 RVA: 0x00A040A0 File Offset: 0x00A022A0
		// (set) Token: 0x0602B902 RID: 178434 RVA: 0x00A040D9 File Offset: 0x00A022D9
		public TArray<BP_Struct_CrowdAiBoidConfig> Boid种类配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_Struct_CrowdAiBoidConfig> result;
				if ((result = this._Boid种类配置) == null)
				{
					result = (this._Boid种类配置 = new TArray<BP_Struct_CrowdAiBoidConfig>(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.Boid种类配置.CopyAssign(value);
			}
		}

		// Token: 0x17006BD3 RID: 27603
		// (get) Token: 0x0602B903 RID: 178435 RVA: 0x00A040E7 File Offset: 0x00A022E7
		// (set) Token: 0x0602B904 RID: 178436 RVA: 0x00A040F7 File Offset: 0x00A022F7
		public unsafe bool 启用传送
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BD4 RID: 27604
		// (get) Token: 0x0602B905 RID: 178437 RVA: 0x00A04108 File Offset: 0x00A02308
		// (set) Token: 0x0602B906 RID: 178438 RVA: 0x00A04118 File Offset: 0x00A02318
		public unsafe float 传送最小计数时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006BD5 RID: 27605
		// (get) Token: 0x0602B907 RID: 178439 RVA: 0x00A04129 File Offset: 0x00A02329
		// (set) Token: 0x0602B908 RID: 178440 RVA: 0x00A04139 File Offset: 0x00A02339
		public unsafe float 传送最大计数时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006BD6 RID: 27606
		// (get) Token: 0x0602B909 RID: 178441 RVA: 0x00A0414A File Offset: 0x00A0234A
		// (set) Token: 0x0602B90A RID: 178442 RVA: 0x00A0415A File Offset: 0x00A0235A
		public unsafe float 传送目标最大半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006BD7 RID: 27607
		// (get) Token: 0x0602B90B RID: 178443 RVA: 0x00A0416B File Offset: 0x00A0236B
		// (set) Token: 0x0602B90C RID: 178444 RVA: 0x00A0417B File Offset: 0x00A0237B
		public unsafe float 传送目标最小半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006BD8 RID: 27608
		// (get) Token: 0x0602B90D RID: 178445 RVA: 0x00A0418C File Offset: 0x00A0238C
		// (set) Token: 0x0602B90E RID: 178446 RVA: 0x00A0419C File Offset: 0x00A0239C
		public unsafe float 玩家移动半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006BD9 RID: 27609
		// (get) Token: 0x0602B90F RID: 178447 RVA: 0x00A041AD File Offset: 0x00A023AD
		// (set) Token: 0x0602B910 RID: 178448 RVA: 0x00A041BD File Offset: 0x00A023BD
		public unsafe float 玩家待机半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006BDA RID: 27610
		// (get) Token: 0x0602B911 RID: 178449 RVA: 0x00A041CE File Offset: 0x00A023CE
		// (set) Token: 0x0602B912 RID: 178450 RVA: 0x00A041DE File Offset: 0x00A023DE
		public unsafe float 玩家半径变化时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006BDB RID: 27611
		// (get) Token: 0x0602B913 RID: 178451 RVA: 0x00A041EF File Offset: 0x00A023EF
		// (set) Token: 0x0602B914 RID: 178452 RVA: 0x00A041FF File Offset: 0x00A023FF
		public unsafe bool 启用跟随区域限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BDC RID: 27612
		// (get) Token: 0x0602B915 RID: 178453 RVA: 0x00A04210 File Offset: 0x00A02410
		// (set) Token: 0x0602B916 RID: 178454 RVA: 0x00A04220 File Offset: 0x00A02420
		public unsafe float 停驻最小目标距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006BDD RID: 27613
		// (get) Token: 0x0602B917 RID: 178455 RVA: 0x00A04231 File Offset: 0x00A02431
		// (set) Token: 0x0602B918 RID: 178456 RVA: 0x00A04241 File Offset: 0x00A02441
		public unsafe float 触发传送最小垂直距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006BDE RID: 27614
		// (get) Token: 0x0602B919 RID: 178457 RVA: 0x00A04252 File Offset: 0x00A02452
		// (set) Token: 0x0602B91A RID: 178458 RVA: 0x00A04262 File Offset: 0x00A02462
		public unsafe float 触发传送最小水平距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006BDF RID: 27615
		// (get) Token: 0x0602B91B RID: 178459 RVA: 0x00A04273 File Offset: 0x00A02473
		// (set) Token: 0x0602B91C RID: 178460 RVA: 0x00A04283 File Offset: 0x00A02483
		public unsafe float 暂停传送最大水平速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006BE0 RID: 27616
		// (get) Token: 0x0602B91D RID: 178461 RVA: 0x00A04294 File Offset: 0x00A02494
		// (set) Token: 0x0602B91E RID: 178462 RVA: 0x00A042A4 File Offset: 0x00A024A4
		public unsafe int 最大尝试寻点次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006BE1 RID: 27617
		// (get) Token: 0x0602B91F RID: 178463 RVA: 0x00A042B5 File Offset: 0x00A024B5
		// (set) Token: 0x0602B920 RID: 178464 RVA: 0x00A042C5 File Offset: 0x00A024C5
		public unsafe float 跟随扇形区域夹角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006BE2 RID: 27618
		// (get) Token: 0x0602B921 RID: 178465 RVA: 0x00A042D6 File Offset: 0x00A024D6
		// (set) Token: 0x0602B922 RID: 178466 RVA: 0x00A042E6 File Offset: 0x00A024E6
		public unsafe float 跟随扇形区域两边长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006BE3 RID: 27619
		// (get) Token: 0x0602B923 RID: 178467 RVA: 0x00A042F7 File Offset: 0x00A024F7
		// (set) Token: 0x0602B924 RID: 178468 RVA: 0x00A04307 File Offset: 0x00A02507
		public unsafe float 跟随扇形区域底边半长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006BE4 RID: 27620
		// (get) Token: 0x0602B925 RID: 178469 RVA: 0x00A04318 File Offset: 0x00A02518
		// (set) Token: 0x0602B926 RID: 178470 RVA: 0x00A04328 File Offset: 0x00A02528
		public unsafe float 跟随扇形区域底边距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006BE5 RID: 27621
		// (get) Token: 0x0602B927 RID: 178471 RVA: 0x00A04339 File Offset: 0x00A02539
		// (set) Token: 0x0602B928 RID: 178472 RVA: 0x00A04349 File Offset: 0x00A02549
		public unsafe float 停驻计时时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006BE6 RID: 27622
		// (get) Token: 0x0602B929 RID: 178473 RVA: 0x00A0435A File Offset: 0x00A0255A
		// (set) Token: 0x0602B92A RID: 178474 RVA: 0x00A0436A File Offset: 0x00A0256A
		public unsafe float 停驻最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006BE7 RID: 27623
		// (get) Token: 0x0602B92B RID: 178475 RVA: 0x00A0437B File Offset: 0x00A0257B
		// (set) Token: 0x0602B92C RID: 178476 RVA: 0x00A0438B File Offset: 0x00A0258B
		public unsafe float 出生最大随机延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17006BE8 RID: 27624
		// (get) Token: 0x0602B92D RID: 178477 RVA: 0x00A0439C File Offset: 0x00A0259C
		// (set) Token: 0x0602B92E RID: 178478 RVA: 0x00A043AC File Offset: 0x00A025AC
		public unsafe float 销毁最大随机延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17006BE9 RID: 27625
		// (get) Token: 0x0602B92F RID: 178479 RVA: 0x00A043BD File Offset: 0x00A025BD
		// (set) Token: 0x0602B930 RID: 178480 RVA: 0x00A043CD File Offset: 0x00A025CD
		public unsafe float 组寻路间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CrowdAiConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x0602B931 RID: 178481 RVA: 0x00A043DE File Offset: 0x00A025DE
		protected BP_CrowdAiConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016ADC RID: 92892
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiConfig.BP_CrowdAiConfig_C";

		// Token: 0x04016ADD RID: 92893
		private static IntPtr _ClassPtr;

		// Token: 0x04016ADE RID: 92894
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016ADF RID: 92895
		internal static int __PropertyOffset_0;

		// Token: 0x04016AE0 RID: 92896
		internal static int __PropertyOffset_1;

		// Token: 0x04016AE1 RID: 92897
		internal static int __PropertyOffset_2;

		// Token: 0x04016AE2 RID: 92898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_Struct_CrowdAiBoidConfig> _Boid种类配置;

		// Token: 0x04016AE3 RID: 92899
		internal static int __PropertyOffset_3;

		// Token: 0x04016AE4 RID: 92900
		internal static int __PropertyOffset_4;

		// Token: 0x04016AE5 RID: 92901
		internal static int __PropertyOffset_5;

		// Token: 0x04016AE6 RID: 92902
		internal static int __PropertyOffset_6;

		// Token: 0x04016AE7 RID: 92903
		internal static int __PropertyOffset_7;

		// Token: 0x04016AE8 RID: 92904
		internal static int __PropertyOffset_8;

		// Token: 0x04016AE9 RID: 92905
		internal static int __PropertyOffset_9;

		// Token: 0x04016AEA RID: 92906
		internal static int __PropertyOffset_10;

		// Token: 0x04016AEB RID: 92907
		internal static int __PropertyOffset_11;

		// Token: 0x04016AEC RID: 92908
		internal static int __PropertyOffset_12;

		// Token: 0x04016AED RID: 92909
		internal static int __PropertyOffset_13;

		// Token: 0x04016AEE RID: 92910
		internal static int __PropertyOffset_14;

		// Token: 0x04016AEF RID: 92911
		internal static int __PropertyOffset_15;

		// Token: 0x04016AF0 RID: 92912
		internal static int __PropertyOffset_16;

		// Token: 0x04016AF1 RID: 92913
		internal static int __PropertyOffset_17;

		// Token: 0x04016AF2 RID: 92914
		internal static int __PropertyOffset_18;

		// Token: 0x04016AF3 RID: 92915
		internal static int __PropertyOffset_19;

		// Token: 0x04016AF4 RID: 92916
		internal static int __PropertyOffset_20;

		// Token: 0x04016AF5 RID: 92917
		internal static int __PropertyOffset_21;

		// Token: 0x04016AF6 RID: 92918
		internal static int __PropertyOffset_22;

		// Token: 0x04016AF7 RID: 92919
		internal static int __PropertyOffset_23;

		// Token: 0x04016AF8 RID: 92920
		internal static int __PropertyOffset_24;

		// Token: 0x04016AF9 RID: 92921
		internal static int __PropertyOffset_25;
	}
}
