using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x02003EFA RID: 16122
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/BP_GongduolaConfig.BP_GongduolaConfig_C")]
	[UnrealStructLayout(976, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 972)]
	public class BP_GongduolaConfig_C : BP_VehicleConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028D44 RID: 167236 RVA: 0x009B58DC File Offset: 0x009B3ADC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GongduolaConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/BP_GongduolaConfig.BP_GongduolaConfig_C");
			}
			return BP_GongduolaConfig_C._ClassPtr;
		}

		// Token: 0x06028D45 RID: 167237 RVA: 0x009B5900 File Offset: 0x009B3B00
		public BP_GongduolaConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_GongduolaConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028D46 RID: 167238 RVA: 0x009B5928 File Offset: 0x009B3B28
		[NullableContext(1)]
		public BP_GongduolaConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GongduolaConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FC5 RID: 24517
		// (get) Token: 0x06028D47 RID: 167239 RVA: 0x009B595B File Offset: 0x009B3B5B
		// (set) Token: 0x06028D48 RID: 167240 RVA: 0x009B596B File Offset: 0x009B3B6B
		public unsafe float 前进最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005FC6 RID: 24518
		// (get) Token: 0x06028D49 RID: 167241 RVA: 0x009B597C File Offset: 0x009B3B7C
		// (set) Token: 0x06028D4A RID: 167242 RVA: 0x009B598C File Offset: 0x009B3B8C
		public unsafe float 常态后退最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005FC7 RID: 24519
		// (get) Token: 0x06028D4B RID: 167243 RVA: 0x009B599D File Offset: 0x009B3B9D
		// (set) Token: 0x06028D4C RID: 167244 RVA: 0x009B59AD File Offset: 0x009B3BAD
		public unsafe float 常态前进加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005FC8 RID: 24520
		// (get) Token: 0x06028D4D RID: 167245 RVA: 0x009B59BE File Offset: 0x009B3BBE
		// (set) Token: 0x06028D4E RID: 167246 RVA: 0x009B59CE File Offset: 0x009B3BCE
		public unsafe float 常态后退加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005FC9 RID: 24521
		// (get) Token: 0x06028D4F RID: 167247 RVA: 0x009B59DF File Offset: 0x009B3BDF
		// (set) Token: 0x06028D50 RID: 167248 RVA: 0x009B59EF File Offset: 0x009B3BEF
		public unsafe float 常态刹车加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005FCA RID: 24522
		// (get) Token: 0x06028D51 RID: 167249 RVA: 0x009B5A00 File Offset: 0x009B3C00
		// (set) Token: 0x06028D52 RID: 167250 RVA: 0x009B5A10 File Offset: 0x009B3C10
		public unsafe float 常态最小加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005FCB RID: 24523
		// (get) Token: 0x06028D53 RID: 167251 RVA: 0x009B5A21 File Offset: 0x009B3C21
		// (set) Token: 0x06028D54 RID: 167252 RVA: 0x009B5A31 File Offset: 0x009B3C31
		public unsafe float 常态最大转向加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005FCC RID: 24524
		// (get) Token: 0x06028D55 RID: 167253 RVA: 0x009B5A42 File Offset: 0x009B3C42
		// (set) Token: 0x06028D56 RID: 167254 RVA: 0x009B5A52 File Offset: 0x009B3C52
		public unsafe float 常态最小转向加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005FCD RID: 24525
		// (get) Token: 0x06028D57 RID: 167255 RVA: 0x009B5A63 File Offset: 0x009B3C63
		// (set) Token: 0x06028D58 RID: 167256 RVA: 0x009B5A73 File Offset: 0x009B3C73
		public unsafe float 常态转向公式角度修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005FCE RID: 24526
		// (get) Token: 0x06028D59 RID: 167257 RVA: 0x009B5A84 File Offset: 0x009B3C84
		// (set) Token: 0x06028D5A RID: 167258 RVA: 0x009B5A94 File Offset: 0x009B3C94
		public unsafe float 常态转向公式速度修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005FCF RID: 24527
		// (get) Token: 0x06028D5B RID: 167259 RVA: 0x009B5AA5 File Offset: 0x009B3CA5
		// (set) Token: 0x06028D5C RID: 167260 RVA: 0x009B5AB5 File Offset: 0x009B3CB5
		public unsafe float 常态转向公式最终修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005FD0 RID: 24528
		// (get) Token: 0x06028D5D RID: 167261 RVA: 0x009B5AC6 File Offset: 0x009B3CC6
		// (set) Token: 0x06028D5E RID: 167262 RVA: 0x009B5AD6 File Offset: 0x009B3CD6
		public unsafe float 常态径向运动摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005FD1 RID: 24529
		// (get) Token: 0x06028D5F RID: 167263 RVA: 0x009B5AE7 File Offset: 0x009B3CE7
		// (set) Token: 0x06028D60 RID: 167264 RVA: 0x009B5AF7 File Offset: 0x009B3CF7
		public unsafe float 常态横向运动摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005FD2 RID: 24530
		// (get) Token: 0x06028D61 RID: 167265 RVA: 0x009B5B08 File Offset: 0x009B3D08
		// (set) Token: 0x06028D62 RID: 167266 RVA: 0x009B5B18 File Offset: 0x009B3D18
		public unsafe float 常态最大转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005FD3 RID: 24531
		// (get) Token: 0x06028D63 RID: 167267 RVA: 0x009B5B29 File Offset: 0x009B3D29
		// (set) Token: 0x06028D64 RID: 167268 RVA: 0x009B5B39 File Offset: 0x009B3D39
		public unsafe float 常态转向摩擦力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005FD4 RID: 24532
		// (get) Token: 0x06028D65 RID: 167269 RVA: 0x009B5B4A File Offset: 0x009B3D4A
		// (set) Token: 0x06028D66 RID: 167270 RVA: 0x009B5B5A File Offset: 0x009B3D5A
		public unsafe float 常态转向静止摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005FD5 RID: 24533
		// (get) Token: 0x06028D67 RID: 167271 RVA: 0x009B5B6B File Offset: 0x009B3D6B
		// (set) Token: 0x06028D68 RID: 167272 RVA: 0x009B5B7B File Offset: 0x009B3D7B
		public unsafe float 冲刺超限持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005FD6 RID: 24534
		// (get) Token: 0x06028D69 RID: 167273 RVA: 0x009B5B8C File Offset: 0x009B3D8C
		// (set) Token: 0x06028D6A RID: 167274 RVA: 0x009B5B9C File Offset: 0x009B3D9C
		public unsafe float 冲刺超限移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005FD7 RID: 24535
		// (get) Token: 0x06028D6B RID: 167275 RVA: 0x009B5BAD File Offset: 0x009B3DAD
		// (set) Token: 0x06028D6C RID: 167276 RVA: 0x009B5BBD File Offset: 0x009B3DBD
		public unsafe float 冲刺最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005FD8 RID: 24536
		// (get) Token: 0x06028D6D RID: 167277 RVA: 0x009B5BCE File Offset: 0x009B3DCE
		// (set) Token: 0x06028D6E RID: 167278 RVA: 0x009B5BDE File Offset: 0x009B3DDE
		public unsafe float 冲刺后退最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005FD9 RID: 24537
		// (get) Token: 0x06028D6F RID: 167279 RVA: 0x009B5BEF File Offset: 0x009B3DEF
		// (set) Token: 0x06028D70 RID: 167280 RVA: 0x009B5BFF File Offset: 0x009B3DFF
		public unsafe float 冲刺停止速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005FDA RID: 24538
		// (get) Token: 0x06028D71 RID: 167281 RVA: 0x009B5C10 File Offset: 0x009B3E10
		// (set) Token: 0x06028D72 RID: 167282 RVA: 0x009B5C20 File Offset: 0x009B3E20
		public unsafe float 冲刺前进加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005FDB RID: 24539
		// (get) Token: 0x06028D73 RID: 167283 RVA: 0x009B5C31 File Offset: 0x009B3E31
		// (set) Token: 0x06028D74 RID: 167284 RVA: 0x009B5C41 File Offset: 0x009B3E41
		public unsafe float 冲刺刹车加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005FDC RID: 24540
		// (get) Token: 0x06028D75 RID: 167285 RVA: 0x009B5C52 File Offset: 0x009B3E52
		// (set) Token: 0x06028D76 RID: 167286 RVA: 0x009B5C62 File Offset: 0x009B3E62
		public unsafe float 冲刺后退加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005FDD RID: 24541
		// (get) Token: 0x06028D77 RID: 167287 RVA: 0x009B5C73 File Offset: 0x009B3E73
		// (set) Token: 0x06028D78 RID: 167288 RVA: 0x009B5C83 File Offset: 0x009B3E83
		public unsafe float 冲刺最小加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005FDE RID: 24542
		// (get) Token: 0x06028D79 RID: 167289 RVA: 0x009B5C94 File Offset: 0x009B3E94
		// (set) Token: 0x06028D7A RID: 167290 RVA: 0x009B5CA4 File Offset: 0x009B3EA4
		public unsafe float 冲刺最大转向加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005FDF RID: 24543
		// (get) Token: 0x06028D7B RID: 167291 RVA: 0x009B5CB5 File Offset: 0x009B3EB5
		// (set) Token: 0x06028D7C RID: 167292 RVA: 0x009B5CC5 File Offset: 0x009B3EC5
		public unsafe float 冲刺最小转向加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005FE0 RID: 24544
		// (get) Token: 0x06028D7D RID: 167293 RVA: 0x009B5CD6 File Offset: 0x009B3ED6
		// (set) Token: 0x06028D7E RID: 167294 RVA: 0x009B5CE6 File Offset: 0x009B3EE6
		public unsafe float 冲刺转向公式角度修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17005FE1 RID: 24545
		// (get) Token: 0x06028D7F RID: 167295 RVA: 0x009B5CF7 File Offset: 0x009B3EF7
		// (set) Token: 0x06028D80 RID: 167296 RVA: 0x009B5D07 File Offset: 0x009B3F07
		public unsafe float 冲刺转向公式速度修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17005FE2 RID: 24546
		// (get) Token: 0x06028D81 RID: 167297 RVA: 0x009B5D18 File Offset: 0x009B3F18
		// (set) Token: 0x06028D82 RID: 167298 RVA: 0x009B5D28 File Offset: 0x009B3F28
		public unsafe float 冲刺转向公式最终修正系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17005FE3 RID: 24547
		// (get) Token: 0x06028D83 RID: 167299 RVA: 0x009B5D39 File Offset: 0x009B3F39
		// (set) Token: 0x06028D84 RID: 167300 RVA: 0x009B5D49 File Offset: 0x009B3F49
		public unsafe float 冲刺径向运动摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17005FE4 RID: 24548
		// (get) Token: 0x06028D85 RID: 167301 RVA: 0x009B5D5A File Offset: 0x009B3F5A
		// (set) Token: 0x06028D86 RID: 167302 RVA: 0x009B5D6A File Offset: 0x009B3F6A
		public unsafe float 冲刺横向运动摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17005FE5 RID: 24549
		// (get) Token: 0x06028D87 RID: 167303 RVA: 0x009B5D7B File Offset: 0x009B3F7B
		// (set) Token: 0x06028D88 RID: 167304 RVA: 0x009B5D8B File Offset: 0x009B3F8B
		public unsafe float 冲刺最大转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17005FE6 RID: 24550
		// (get) Token: 0x06028D89 RID: 167305 RVA: 0x009B5D9C File Offset: 0x009B3F9C
		// (set) Token: 0x06028D8A RID: 167306 RVA: 0x009B5DAC File Offset: 0x009B3FAC
		public unsafe float 冲刺转向摩擦力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17005FE7 RID: 24551
		// (get) Token: 0x06028D8B RID: 167307 RVA: 0x009B5DBD File Offset: 0x009B3FBD
		// (set) Token: 0x06028D8C RID: 167308 RVA: 0x009B5DCD File Offset: 0x009B3FCD
		public unsafe float 冲刺转向静止摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17005FE8 RID: 24552
		// (get) Token: 0x06028D8D RID: 167309 RVA: 0x009B5DDE File Offset: 0x009B3FDE
		// (set) Token: 0x06028D8E RID: 167310 RVA: 0x009B5DEE File Offset: 0x009B3FEE
		public unsafe float 超出最大速度时的额外摩擦力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17005FE9 RID: 24553
		// (get) Token: 0x06028D8F RID: 167311 RVA: 0x009B5DFF File Offset: 0x009B3FFF
		// (set) Token: 0x06028D90 RID: 167312 RVA: 0x009B5E0F File Offset: 0x009B400F
		public unsafe float 冲刺固定前向输入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17005FEA RID: 24554
		// (get) Token: 0x06028D91 RID: 167313 RVA: 0x009B5E20 File Offset: 0x009B4020
		// (set) Token: 0x06028D92 RID: 167314 RVA: 0x009B5E30 File Offset: 0x009B4030
		public unsafe float 最大上浮速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17005FEB RID: 24555
		// (get) Token: 0x06028D93 RID: 167315 RVA: 0x009B5E41 File Offset: 0x009B4041
		// (set) Token: 0x06028D94 RID: 167316 RVA: 0x009B5E51 File Offset: 0x009B4051
		public unsafe float 浮力平衡位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17005FEC RID: 24556
		// (get) Token: 0x06028D95 RID: 167317 RVA: 0x009B5E62 File Offset: 0x009B4062
		// (set) Token: 0x06028D96 RID: 167318 RVA: 0x009B5E72 File Offset: 0x009B4072
		public unsafe float 搁浅位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17005FED RID: 24557
		// (get) Token: 0x06028D97 RID: 167319 RVA: 0x009B5E83 File Offset: 0x009B4083
		// (set) Token: 0x06028D98 RID: 167320 RVA: 0x009B5E93 File Offset: 0x009B4093
		public unsafe float 漂浮阻力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17005FEE RID: 24558
		// (get) Token: 0x06028D99 RID: 167321 RVA: 0x009B5EA4 File Offset: 0x009B40A4
		// (set) Token: 0x06028D9A RID: 167322 RVA: 0x009B5EB4 File Offset: 0x009B40B4
		public unsafe float 转动惯量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17005FEF RID: 24559
		// (get) Token: 0x06028D9B RID: 167323 RVA: 0x009B5EC5 File Offset: 0x009B40C5
		// (set) Token: 0x06028D9C RID: 167324 RVA: 0x009B5ED5 File Offset: 0x009B40D5
		public unsafe float 速度冲击力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17005FF0 RID: 24560
		// (get) Token: 0x06028D9D RID: 167325 RVA: 0x009B5EE6 File Offset: 0x009B40E6
		// (set) Token: 0x06028D9E RID: 167326 RVA: 0x009B5EF6 File Offset: 0x009B40F6
		public unsafe float 旋转冲击力系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17005FF1 RID: 24561
		// (get) Token: 0x06028D9F RID: 167327 RVA: 0x009B5F07 File Offset: 0x009B4107
		// (set) Token: 0x06028DA0 RID: 167328 RVA: 0x009B5F17 File Offset: 0x009B4117
		public unsafe float 常态转向强制前向输入系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17005FF2 RID: 24562
		// (get) Token: 0x06028DA1 RID: 167329 RVA: 0x009B5F28 File Offset: 0x009B4128
		// (set) Token: 0x06028DA2 RID: 167330 RVA: 0x009B5F38 File Offset: 0x009B4138
		public unsafe float 冲刺转向强制前向输入系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17005FF3 RID: 24563
		// (get) Token: 0x06028DA3 RID: 167331 RVA: 0x009B5F49 File Offset: 0x009B4149
		// (set) Token: 0x06028DA4 RID: 167332 RVA: 0x009B5F59 File Offset: 0x009B4159
		public unsafe float 常态最大前后输入阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17005FF4 RID: 24564
		// (get) Token: 0x06028DA5 RID: 167333 RVA: 0x009B5F6A File Offset: 0x009B416A
		// (set) Token: 0x06028DA6 RID: 167334 RVA: 0x009B5F7A File Offset: 0x009B417A
		public unsafe float 常态最大左右输入阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17005FF5 RID: 24565
		// (get) Token: 0x06028DA7 RID: 167335 RVA: 0x009B5F8B File Offset: 0x009B418B
		// (set) Token: 0x06028DA8 RID: 167336 RVA: 0x009B5F9B File Offset: 0x009B419B
		public unsafe float 冲刺最大前后输入阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17005FF6 RID: 24566
		// (get) Token: 0x06028DA9 RID: 167337 RVA: 0x009B5FAC File Offset: 0x009B41AC
		// (set) Token: 0x06028DAA RID: 167338 RVA: 0x009B5FBC File Offset: 0x009B41BC
		public unsafe float 冲刺最大左右输入阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17005FF7 RID: 24567
		// (get) Token: 0x06028DAB RID: 167339 RVA: 0x009B5FCD File Offset: 0x009B41CD
		// (set) Token: 0x06028DAC RID: 167340 RVA: 0x009B5FDD File Offset: 0x009B41DD
		public unsafe float 冲刺持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17005FF8 RID: 24568
		// (get) Token: 0x06028DAD RID: 167341 RVA: 0x009B5FEE File Offset: 0x009B41EE
		// (set) Token: 0x06028DAE RID: 167342 RVA: 0x009B5FFE File Offset: 0x009B41FE
		public unsafe float 冲刺冷却时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17005FF9 RID: 24569
		// (get) Token: 0x06028DAF RID: 167343 RVA: 0x009B600F File Offset: 0x009B420F
		// (set) Token: 0x06028DB0 RID: 167344 RVA: 0x009B601F File Offset: 0x009B421F
		public unsafe int 冲刺最大使用次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17005FFA RID: 24570
		// (get) Token: 0x06028DB1 RID: 167345 RVA: 0x009B6030 File Offset: 0x009B4230
		// (set) Token: 0x06028DB2 RID: 167346 RVA: 0x009B6040 File Offset: 0x009B4240
		public unsafe float 前向转弯最小X输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17005FFB RID: 24571
		// (get) Token: 0x06028DB3 RID: 167347 RVA: 0x009B6051 File Offset: 0x009B4251
		// (set) Token: 0x06028DB4 RID: 167348 RVA: 0x009B6061 File Offset: 0x009B4261
		public unsafe float 后向转向最大X输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GongduolaConfig_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x06028DB5 RID: 167349 RVA: 0x009B6072 File Offset: 0x009B4272
		protected BP_GongduolaConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E06 RID: 85510
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/BP_GongduolaConfig.BP_GongduolaConfig_C";

		// Token: 0x04014E07 RID: 85511
		private static IntPtr _ClassPtr;

		// Token: 0x04014E08 RID: 85512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014E09 RID: 85513
		internal new static int __PropertyOffset_0;

		// Token: 0x04014E0A RID: 85514
		internal new static int __PropertyOffset_1;

		// Token: 0x04014E0B RID: 85515
		internal new static int __PropertyOffset_2;

		// Token: 0x04014E0C RID: 85516
		internal new static int __PropertyOffset_3;

		// Token: 0x04014E0D RID: 85517
		internal new static int __PropertyOffset_4;

		// Token: 0x04014E0E RID: 85518
		internal new static int __PropertyOffset_5;

		// Token: 0x04014E0F RID: 85519
		internal new static int __PropertyOffset_6;

		// Token: 0x04014E10 RID: 85520
		internal new static int __PropertyOffset_7;

		// Token: 0x04014E11 RID: 85521
		internal new static int __PropertyOffset_8;

		// Token: 0x04014E12 RID: 85522
		internal new static int __PropertyOffset_9;

		// Token: 0x04014E13 RID: 85523
		internal new static int __PropertyOffset_10;

		// Token: 0x04014E14 RID: 85524
		internal new static int __PropertyOffset_11;

		// Token: 0x04014E15 RID: 85525
		internal new static int __PropertyOffset_12;

		// Token: 0x04014E16 RID: 85526
		internal new static int __PropertyOffset_13;

		// Token: 0x04014E17 RID: 85527
		internal new static int __PropertyOffset_14;

		// Token: 0x04014E18 RID: 85528
		internal new static int __PropertyOffset_15;

		// Token: 0x04014E19 RID: 85529
		internal new static int __PropertyOffset_16;

		// Token: 0x04014E1A RID: 85530
		internal new static int __PropertyOffset_17;

		// Token: 0x04014E1B RID: 85531
		internal new static int __PropertyOffset_18;

		// Token: 0x04014E1C RID: 85532
		internal new static int __PropertyOffset_19;

		// Token: 0x04014E1D RID: 85533
		internal static int __PropertyOffset_20;

		// Token: 0x04014E1E RID: 85534
		internal static int __PropertyOffset_21;

		// Token: 0x04014E1F RID: 85535
		internal static int __PropertyOffset_22;

		// Token: 0x04014E20 RID: 85536
		internal static int __PropertyOffset_23;

		// Token: 0x04014E21 RID: 85537
		internal static int __PropertyOffset_24;

		// Token: 0x04014E22 RID: 85538
		internal static int __PropertyOffset_25;

		// Token: 0x04014E23 RID: 85539
		internal static int __PropertyOffset_26;

		// Token: 0x04014E24 RID: 85540
		internal static int __PropertyOffset_27;

		// Token: 0x04014E25 RID: 85541
		internal static int __PropertyOffset_28;

		// Token: 0x04014E26 RID: 85542
		internal static int __PropertyOffset_29;

		// Token: 0x04014E27 RID: 85543
		internal static int __PropertyOffset_30;

		// Token: 0x04014E28 RID: 85544
		internal static int __PropertyOffset_31;

		// Token: 0x04014E29 RID: 85545
		internal static int __PropertyOffset_32;

		// Token: 0x04014E2A RID: 85546
		internal static int __PropertyOffset_33;

		// Token: 0x04014E2B RID: 85547
		internal static int __PropertyOffset_34;

		// Token: 0x04014E2C RID: 85548
		internal static int __PropertyOffset_35;

		// Token: 0x04014E2D RID: 85549
		internal static int __PropertyOffset_36;

		// Token: 0x04014E2E RID: 85550
		internal static int __PropertyOffset_37;

		// Token: 0x04014E2F RID: 85551
		internal static int __PropertyOffset_38;

		// Token: 0x04014E30 RID: 85552
		internal static int __PropertyOffset_39;

		// Token: 0x04014E31 RID: 85553
		internal static int __PropertyOffset_40;

		// Token: 0x04014E32 RID: 85554
		internal static int __PropertyOffset_41;

		// Token: 0x04014E33 RID: 85555
		internal static int __PropertyOffset_42;

		// Token: 0x04014E34 RID: 85556
		internal static int __PropertyOffset_43;

		// Token: 0x04014E35 RID: 85557
		internal static int __PropertyOffset_44;

		// Token: 0x04014E36 RID: 85558
		internal static int __PropertyOffset_45;

		// Token: 0x04014E37 RID: 85559
		internal static int __PropertyOffset_46;

		// Token: 0x04014E38 RID: 85560
		internal static int __PropertyOffset_47;

		// Token: 0x04014E39 RID: 85561
		internal static int __PropertyOffset_48;

		// Token: 0x04014E3A RID: 85562
		internal static int __PropertyOffset_49;

		// Token: 0x04014E3B RID: 85563
		internal static int __PropertyOffset_50;

		// Token: 0x04014E3C RID: 85564
		internal static int __PropertyOffset_51;

		// Token: 0x04014E3D RID: 85565
		internal static int __PropertyOffset_52;

		// Token: 0x04014E3E RID: 85566
		internal static int __PropertyOffset_53;

		// Token: 0x04014E3F RID: 85567
		internal static int __PropertyOffset_54;
	}
}
