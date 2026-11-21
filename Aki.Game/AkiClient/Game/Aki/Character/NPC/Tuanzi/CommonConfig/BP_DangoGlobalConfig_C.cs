using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Tuanzi.CommonConfig
{
	// Token: 0x020032B0 RID: 12976
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Tuanzi/CommonConfig/BP_DangoGlobalConfig.BP_DangoGlobalConfig_C")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class BP_DangoGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A63 RID: 133731 RVA: 0x0094BF42 File Offset: 0x0094A142
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DangoGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Tuanzi/CommonConfig/BP_DangoGlobalConfig.BP_DangoGlobalConfig_C");
			}
			return BP_DangoGlobalConfig_C._ClassPtr;
		}

		// Token: 0x06020A64 RID: 133732 RVA: 0x0094BF68 File Offset: 0x0094A168
		public BP_DangoGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_DangoGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A65 RID: 133733 RVA: 0x0094BF90 File Offset: 0x0094A190
		[NullableContext(1)]
		public BP_DangoGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DangoGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x06020A66 RID: 133734 RVA: 0x0094BFC3 File Offset: 0x0094A1C3
		// (set) Token: 0x06020A67 RID: 133735 RVA: 0x0094BFD3 File Offset: 0x0094A1D3
		public unsafe int 跳跃前摇时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前摇时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前摇时间) = value;
			}
		}

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x06020A68 RID: 133736 RVA: 0x0094BFE4 File Offset: 0x0094A1E4
		// (set) Token: 0x06020A69 RID: 133737 RVA: 0x0094BFF4 File Offset: 0x0094A1F4
		public unsafe int 跳跃移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃移动时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃移动时间) = value;
			}
		}

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x06020A6A RID: 133738 RVA: 0x0094C005 File Offset: 0x0094A205
		// (set) Token: 0x06020A6B RID: 133739 RVA: 0x0094C015 File Offset: 0x0094A215
		public unsafe int 跳跃后摇时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃后摇时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃后摇时间) = value;
			}
		}

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x06020A6C RID: 133740 RVA: 0x0094C026 File Offset: 0x0094A226
		// (set) Token: 0x06020A6D RID: 133741 RVA: 0x0094C036 File Offset: 0x0094A236
		public unsafe int 跳跃旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃旋转速度) = value;
			}
		}

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x06020A6E RID: 133742 RVA: 0x0094C047 File Offset: 0x0094A247
		// (set) Token: 0x06020A6F RID: 133743 RVA: 0x0094C057 File Offset: 0x0094A257
		public unsafe int 跳跃高度偏移基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃高度偏移基准);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃高度偏移基准) = value;
			}
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x06020A70 RID: 133744 RVA: 0x0094C068 File Offset: 0x0094A268
		// (set) Token: 0x06020A71 RID: 133745 RVA: 0x0094C078 File Offset: 0x0094A278
		public unsafe int 跳跃上升偏移曲线高度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃上升偏移曲线高度范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃上升偏移曲线高度范围) = value;
			}
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x06020A72 RID: 133746 RVA: 0x0094C089 File Offset: 0x0094A289
		// (set) Token: 0x06020A73 RID: 133747 RVA: 0x0094C099 File Offset: 0x0094A299
		public unsafe int 跳跃下降偏移曲线高度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃下降偏移曲线高度范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃下降偏移曲线高度范围) = value;
			}
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x06020A74 RID: 133748 RVA: 0x0094C0AA File Offset: 0x0094A2AA
		// (set) Token: 0x06020A75 RID: 133749 RVA: 0x0094C0BE File Offset: 0x0094A2BE
		public unsafe UCurveFloat 跳跃上升偏移曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_跳跃上升偏移曲线);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_跳跃上升偏移曲线, value);
			}
		}

		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x06020A76 RID: 133750 RVA: 0x0094C0D3 File Offset: 0x0094A2D3
		// (set) Token: 0x06020A77 RID: 133751 RVA: 0x0094C0E7 File Offset: 0x0094A2E7
		public unsafe UCurveFloat 跳跃下降偏移曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_跳跃下降偏移曲线);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_跳跃下降偏移曲线, value);
			}
		}

		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x06020A78 RID: 133752 RVA: 0x0094C0FC File Offset: 0x0094A2FC
		// (set) Token: 0x06020A79 RID: 133753 RVA: 0x0094C10C File Offset: 0x0094A30C
		public unsafe int 跳跃中镜头臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃中镜头臂长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃中镜头臂长) = value;
			}
		}

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x06020A7A RID: 133754 RVA: 0x0094C11D File Offset: 0x0094A31D
		// (set) Token: 0x06020A7B RID: 133755 RVA: 0x0094C12D File Offset: 0x0094A32D
		public unsafe int 跳跃中镜头追踪时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃中镜头追踪时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃中镜头追踪时间) = value;
			}
		}

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x06020A7C RID: 133756 RVA: 0x0094C13E File Offset: 0x0094A33E
		// (set) Token: 0x06020A7D RID: 133757 RVA: 0x0094C14E File Offset: 0x0094A34E
		public unsafe float 跳跃中镜头FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃中镜头FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃中镜头FOV) = value;
			}
		}

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x06020A7E RID: 133758 RVA: 0x0094C160 File Offset: 0x0094A360
		// (set) Token: 0x06020A7F RID: 133759 RVA: 0x0094C199 File Offset: 0x0094A399
		[Nullable(1)]
		public SBaseCurve 跳跃中镜头曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._跳跃中镜头曲线) == null)
				{
					result = (this._跳跃中镜头曲线 = new SBaseCurve(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃中镜头曲线, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃中镜头曲线, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x06020A80 RID: 133760 RVA: 0x0094C1BA File Offset: 0x0094A3BA
		// (set) Token: 0x06020A81 RID: 133761 RVA: 0x0094C1CA File Offset: 0x0094A3CA
		public unsafe int 跳跃前镜头死区距离基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头死区距离基准);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头死区距离基准) = value;
			}
		}

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x06020A82 RID: 133762 RVA: 0x0094C1DB File Offset: 0x0094A3DB
		// (set) Token: 0x06020A83 RID: 133763 RVA: 0x0094C1EB File Offset: 0x0094A3EB
		public unsafe int 跳跃前镜头臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头臂长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头臂长) = value;
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x06020A84 RID: 133764 RVA: 0x0094C1FC File Offset: 0x0094A3FC
		// (set) Token: 0x06020A85 RID: 133765 RVA: 0x0094C210 File Offset: 0x0094A410
		public unsafe FInt32Range 跳跃前镜头近距离基准范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头近距离基准范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头近距离基准范围) = value;
			}
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x06020A86 RID: 133766 RVA: 0x0094C225 File Offset: 0x0094A425
		// (set) Token: 0x06020A87 RID: 133767 RVA: 0x0094C239 File Offset: 0x0094A439
		public unsafe FInt32Range 跳跃前镜头近距离追踪时间范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头近距离追踪时间范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头近距离追踪时间范围) = value;
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x06020A88 RID: 133768 RVA: 0x0094C24E File Offset: 0x0094A44E
		// (set) Token: 0x06020A89 RID: 133769 RVA: 0x0094C25E File Offset: 0x0094A45E
		public unsafe int 跳跃前镜头远距离基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头远距离基准);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头远距离基准) = value;
			}
		}

		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x06020A8A RID: 133770 RVA: 0x0094C26F File Offset: 0x0094A46F
		// (set) Token: 0x06020A8B RID: 133771 RVA: 0x0094C27F File Offset: 0x0094A47F
		public unsafe int 跳跃前镜头远距离追踪时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头远距离追踪时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头远距离追踪时间) = value;
			}
		}

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x06020A8C RID: 133772 RVA: 0x0094C290 File Offset: 0x0094A490
		// (set) Token: 0x06020A8D RID: 133773 RVA: 0x0094C2A0 File Offset: 0x0094A4A0
		public unsafe float 跳跃前镜头FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头FOV) = value;
			}
		}

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x06020A8E RID: 133774 RVA: 0x0094C2B4 File Offset: 0x0094A4B4
		// (set) Token: 0x06020A8F RID: 133775 RVA: 0x0094C2ED File Offset: 0x0094A4ED
		[Nullable(1)]
		public SBaseCurve 跳跃前镜头曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._跳跃前镜头曲线) == null)
				{
					result = (this._跳跃前镜头曲线 = new SBaseCurve(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头曲线, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_跳跃前镜头曲线, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x06020A90 RID: 133776 RVA: 0x0094C310 File Offset: 0x0094A510
		// (set) Token: 0x06020A91 RID: 133777 RVA: 0x0094C349 File Offset: 0x0094A549
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EDangoPerformType>, SDangoPerformData> 动作表现
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EDangoPerformType>, SDangoPerformData> result;
				if ((result = this._动作表现) == null)
				{
					result = (this._动作表现 = new TMap<TEnumAsByte<EDangoPerformType>, SDangoPerformData>(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_动作表现, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.动作表现.CopyAssign(value);
			}
		}

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x06020A92 RID: 133778 RVA: 0x0094C357 File Offset: 0x0094A557
		// (set) Token: 0x06020A93 RID: 133779 RVA: 0x0094C36B File Offset: 0x0094A56B
		public unsafe FName 堆叠绑定骨骼名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_堆叠绑定骨骼名称);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_堆叠绑定骨骼名称) = value;
			}
		}

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x06020A94 RID: 133780 RVA: 0x0094C380 File Offset: 0x0094A580
		// (set) Token: 0x06020A95 RID: 133781 RVA: 0x0094C390 File Offset: 0x0094A590
		public unsafe int 堆叠间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_堆叠间隔);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_堆叠间隔) = value;
			}
		}

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x06020A96 RID: 133782 RVA: 0x0094C3A1 File Offset: 0x0094A5A1
		// (set) Token: 0x06020A97 RID: 133783 RVA: 0x0094C3B5 File Offset: 0x0094A5B5
		public unsafe UCurveFloat 黑洞下降偏移曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_黑洞下降偏移曲线);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_黑洞下降偏移曲线, value);
			}
		}

		// Token: 0x06020A98 RID: 133784 RVA: 0x0094C3CA File Offset: 0x0094A5CA
		protected BP_DangoGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A89 RID: 72329
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Tuanzi/CommonConfig/BP_DangoGlobalConfig.BP_DangoGlobalConfig_C";

		// Token: 0x04011A8A RID: 72330
		private static IntPtr _ClassPtr;

		// Token: 0x04011A8B RID: 72331
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A8C RID: 72332
		internal static int __PropertyOffset_跳跃前摇时间;

		// Token: 0x04011A8D RID: 72333
		internal static int __PropertyOffset_跳跃移动时间;

		// Token: 0x04011A8E RID: 72334
		internal static int __PropertyOffset_跳跃后摇时间;

		// Token: 0x04011A8F RID: 72335
		internal static int __PropertyOffset_跳跃旋转速度;

		// Token: 0x04011A90 RID: 72336
		internal static int __PropertyOffset_跳跃高度偏移基准;

		// Token: 0x04011A91 RID: 72337
		internal static int __PropertyOffset_跳跃上升偏移曲线高度范围;

		// Token: 0x04011A92 RID: 72338
		internal static int __PropertyOffset_跳跃下降偏移曲线高度范围;

		// Token: 0x04011A93 RID: 72339
		internal static int __PropertyOffset_跳跃上升偏移曲线;

		// Token: 0x04011A94 RID: 72340
		internal static int __PropertyOffset_跳跃下降偏移曲线;

		// Token: 0x04011A95 RID: 72341
		internal static int __PropertyOffset_跳跃中镜头臂长;

		// Token: 0x04011A96 RID: 72342
		internal static int __PropertyOffset_跳跃中镜头追踪时间;

		// Token: 0x04011A97 RID: 72343
		internal static int __PropertyOffset_跳跃中镜头FOV;

		// Token: 0x04011A98 RID: 72344
		internal static int __PropertyOffset_跳跃中镜头曲线;

		// Token: 0x04011A99 RID: 72345
		private SBaseCurve _跳跃中镜头曲线;

		// Token: 0x04011A9A RID: 72346
		internal static int __PropertyOffset_跳跃前镜头死区距离基准;

		// Token: 0x04011A9B RID: 72347
		internal static int __PropertyOffset_跳跃前镜头臂长;

		// Token: 0x04011A9C RID: 72348
		internal static int __PropertyOffset_跳跃前镜头近距离基准范围;

		// Token: 0x04011A9D RID: 72349
		internal static int __PropertyOffset_跳跃前镜头近距离追踪时间范围;

		// Token: 0x04011A9E RID: 72350
		internal static int __PropertyOffset_跳跃前镜头远距离基准;

		// Token: 0x04011A9F RID: 72351
		internal static int __PropertyOffset_跳跃前镜头远距离追踪时间;

		// Token: 0x04011AA0 RID: 72352
		internal static int __PropertyOffset_跳跃前镜头FOV;

		// Token: 0x04011AA1 RID: 72353
		internal static int __PropertyOffset_跳跃前镜头曲线;

		// Token: 0x04011AA2 RID: 72354
		private SBaseCurve _跳跃前镜头曲线;

		// Token: 0x04011AA3 RID: 72355
		internal static int __PropertyOffset_动作表现;

		// Token: 0x04011AA4 RID: 72356
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EDangoPerformType>, SDangoPerformData> _动作表现;

		// Token: 0x04011AA5 RID: 72357
		internal static int __PropertyOffset_堆叠绑定骨骼名称;

		// Token: 0x04011AA6 RID: 72358
		internal static int __PropertyOffset_堆叠间隔;

		// Token: 0x04011AA7 RID: 72359
		internal static int __PropertyOffset_黑洞下降偏移曲线;
	}
}
