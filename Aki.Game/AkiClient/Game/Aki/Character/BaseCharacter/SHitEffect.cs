using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200431A RID: 17178
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SHitEffect.SHitEffect")]
	[UnrealStructLayout(164, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 164)]
	public class SHitEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C722 RID: 182050 RVA: 0x00A1FEE2 File Offset: 0x00A1E0E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHitEffect._ScriptStructPtr != 0) ? SHitEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SHitEffect.SHitEffect", ref SHitEffect._ScriptStructPtr);
		}

		// Token: 0x17006F44 RID: 28484
		// (get) Token: 0x0602C723 RID: 182051 RVA: 0x00A1FF06 File Offset: 0x00A1E106
		// (set) Token: 0x0602C724 RID: 182052 RVA: 0x00A1FF1A File Offset: 0x00A1E11A
		public unsafe TEnumAsByte<EHitAnim> 被击动作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F45 RID: 28485
		// (get) Token: 0x0602C725 RID: 182053 RVA: 0x00A1FF2F File Offset: 0x00A1E12F
		// (set) Token: 0x0602C726 RID: 182054 RVA: 0x00A1FF3F File Offset: 0x00A1E13F
		public unsafe float 受击朝向Z轴偏转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F46 RID: 28486
		// (get) Token: 0x0602C727 RID: 182055 RVA: 0x00A1FF50 File Offset: 0x00A1E150
		// (set) Token: 0x0602C728 RID: 182056 RVA: 0x00A1FF64 File Offset: 0x00A1E164
		public unsafe FVector 空中受击速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F47 RID: 28487
		// (get) Token: 0x0602C729 RID: 182057 RVA: 0x00A1FF79 File Offset: 0x00A1E179
		// (set) Token: 0x0602C72A RID: 182058 RVA: 0x00A1FF89 File Offset: 0x00A1E189
		public unsafe float 空中受击移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F48 RID: 28488
		// (get) Token: 0x0602C72B RID: 182059 RVA: 0x00A1FF9A File Offset: 0x00A1E19A
		// (set) Token: 0x0602C72C RID: 182060 RVA: 0x00A1FFAA File Offset: 0x00A1E1AA
		public unsafe float 命中硬直时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006F49 RID: 28489
		// (get) Token: 0x0602C72D RID: 182061 RVA: 0x00A1FFBB File Offset: 0x00A1E1BB
		// (set) Token: 0x0602C72E RID: 182062 RVA: 0x00A1FFCF File Offset: 0x00A1E1CF
		public unsafe FVector 地面受击速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006F4A RID: 28490
		// (get) Token: 0x0602C72F RID: 182063 RVA: 0x00A1FFE4 File Offset: 0x00A1E1E4
		// (set) Token: 0x0602C730 RID: 182064 RVA: 0x00A1FFF4 File Offset: 0x00A1E1F4
		public unsafe float 地面受击移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006F4B RID: 28491
		// (get) Token: 0x0602C731 RID: 182065 RVA: 0x00A20005 File Offset: 0x00A1E205
		// (set) Token: 0x0602C732 RID: 182066 RVA: 0x00A20019 File Offset: 0x00A1E219
		public unsafe TEnumAsByte<EVelocityCurveType> 地面受击移动曲线
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006F4C RID: 28492
		// (get) Token: 0x0602C733 RID: 182067 RVA: 0x00A2002E File Offset: 0x00A1E22E
		// (set) Token: 0x0602C734 RID: 182068 RVA: 0x00A2003E File Offset: 0x00A1E23E
		public unsafe float 地面受击最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006F4D RID: 28493
		// (get) Token: 0x0602C735 RID: 182069 RVA: 0x00A2004F File Offset: 0x00A1E24F
		// (set) Token: 0x0602C736 RID: 182070 RVA: 0x00A2005F File Offset: 0x00A1E25F
		public unsafe float 地面受击最小速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006F4E RID: 28494
		// (get) Token: 0x0602C737 RID: 182071 RVA: 0x00A20070 File Offset: 0x00A1E270
		// (set) Token: 0x0602C738 RID: 182072 RVA: 0x00A20080 File Offset: 0x00A1E280
		public unsafe float 速度阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006F4F RID: 28495
		// (get) Token: 0x0602C739 RID: 182073 RVA: 0x00A20091 File Offset: 0x00A1E291
		// (set) Token: 0x0602C73A RID: 182074 RVA: 0x00A200A1 File Offset: 0x00A1E2A1
		public unsafe float 上升标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006F50 RID: 28496
		// (get) Token: 0x0602C73B RID: 182075 RVA: 0x00A200B2 File Offset: 0x00A1E2B2
		// (set) Token: 0x0602C73C RID: 182076 RVA: 0x00A200C2 File Offset: 0x00A1E2C2
		public unsafe float 弧顶标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006F51 RID: 28497
		// (get) Token: 0x0602C73D RID: 182077 RVA: 0x00A200D3 File Offset: 0x00A1E2D3
		// (set) Token: 0x0602C73E RID: 182078 RVA: 0x00A200E3 File Offset: 0x00A1E2E3
		public unsafe float 下落标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006F52 RID: 28498
		// (get) Token: 0x0602C73F RID: 182079 RVA: 0x00A200F4 File Offset: 0x00A1E2F4
		// (set) Token: 0x0602C740 RID: 182080 RVA: 0x00A20104 File Offset: 0x00A1E304
		public unsafe bool 到达弧顶清除速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F53 RID: 28499
		// (get) Token: 0x0602C741 RID: 182081 RVA: 0x00A20115 File Offset: 0x00A1E315
		// (set) Token: 0x0602C742 RID: 182082 RVA: 0x00A20129 File Offset: 0x00A1E329
		public unsafe FVector 落地反弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006F54 RID: 28500
		// (get) Token: 0x0602C743 RID: 182083 RVA: 0x00A2013E File Offset: 0x00A1E33E
		// (set) Token: 0x0602C744 RID: 182084 RVA: 0x00A2014E File Offset: 0x00A1E34E
		public unsafe float 落地反弹上升重力标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006F55 RID: 28501
		// (get) Token: 0x0602C745 RID: 182085 RVA: 0x00A2015F File Offset: 0x00A1E35F
		// (set) Token: 0x0602C746 RID: 182086 RVA: 0x00A2016F File Offset: 0x00A1E36F
		public unsafe float 落地反弹弧顶重力标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006F56 RID: 28502
		// (get) Token: 0x0602C747 RID: 182087 RVA: 0x00A20180 File Offset: 0x00A1E380
		// (set) Token: 0x0602C748 RID: 182088 RVA: 0x00A20190 File Offset: 0x00A1E390
		public unsafe float 落地反弹下落重力标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006F57 RID: 28503
		// (get) Token: 0x0602C749 RID: 182089 RVA: 0x00A201A1 File Offset: 0x00A1E3A1
		// (set) Token: 0x0602C74A RID: 182090 RVA: 0x00A201B1 File Offset: 0x00A1E3B1
		public unsafe float 落地反弹速度阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006F58 RID: 28504
		// (get) Token: 0x0602C74B RID: 182091 RVA: 0x00A201C2 File Offset: 0x00A1E3C2
		// (set) Token: 0x0602C74C RID: 182092 RVA: 0x00A201D2 File Offset: 0x00A1E3D2
		public unsafe float 落地反弹时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006F59 RID: 28505
		// (get) Token: 0x0602C74D RID: 182093 RVA: 0x00A201E4 File Offset: 0x00A1E3E4
		// (set) Token: 0x0602C74E RID: 182094 RVA: 0x00A20227 File Offset: 0x00A1E427
		[Nullable(1)]
		public SHitWhirlpool 地面受击滞空
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SHitWhirlpool result;
				if ((result = this._地面受击滞空) == null)
				{
					result = (this._地面受击滞空 = new SHitWhirlpool(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_21, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitWhirlpool.StaticStruct(), base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_21, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F5A RID: 28506
		// (get) Token: 0x0602C74F RID: 182095 RVA: 0x00A20248 File Offset: 0x00A1E448
		// (set) Token: 0x0602C750 RID: 182096 RVA: 0x00A2028B File Offset: 0x00A1E48B
		[Nullable(1)]
		public SHitWhirlpool 空中受击滞空
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SHitWhirlpool result;
				if ((result = this._空中受击滞空) == null)
				{
					result = (this._空中受击滞空 = new SHitWhirlpool(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_22, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitWhirlpool.StaticStruct(), base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_22, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C751 RID: 182097 RVA: 0x00A202AC File Offset: 0x00A1E4AC
		public SHitEffect()
		{
		}

		// Token: 0x0602C752 RID: 182098 RVA: 0x00A202B4 File Offset: 0x00A1E4B4
		public SHitEffect(TEnumAsByte<EHitAnim> 被击动作, float 受击朝向Z轴偏转, FVector 空中受击速度, float 空中受击移动时间, float 命中硬直时间, FVector 地面受击速度, float 地面受击移动时间, TEnumAsByte<EVelocityCurveType> 地面受击移动曲线, float 地面受击最大速度, float 地面受击最小速度, float 速度阈值, float 上升标量, float 弧顶标量, float 下落标量, bool 到达弧顶清除速度, FVector 落地反弹, float 落地反弹上升重力标量, float 落地反弹弧顶重力标量, float 落地反弹下落重力标量, float 落地反弹速度阈值, float 落地反弹时长, [Nullable(1)] SHitWhirlpool 地面受击滞空, [Nullable(1)] SHitWhirlpool 空中受击滞空)
		{
			this.被击动作 = 被击动作;
			this.受击朝向Z轴偏转 = 受击朝向Z轴偏转;
			this.空中受击速度 = 空中受击速度;
			this.空中受击移动时间 = 空中受击移动时间;
			this.命中硬直时间 = 命中硬直时间;
			this.地面受击速度 = 地面受击速度;
			this.地面受击移动时间 = 地面受击移动时间;
			this.地面受击移动曲线 = 地面受击移动曲线;
			this.地面受击最大速度 = 地面受击最大速度;
			this.地面受击最小速度 = 地面受击最小速度;
			this.速度阈值 = 速度阈值;
			this.上升标量 = 上升标量;
			this.弧顶标量 = 弧顶标量;
			this.下落标量 = 下落标量;
			this.到达弧顶清除速度 = 到达弧顶清除速度;
			this.落地反弹 = 落地反弹;
			this.落地反弹上升重力标量 = 落地反弹上升重力标量;
			this.落地反弹弧顶重力标量 = 落地反弹弧顶重力标量;
			this.落地反弹下落重力标量 = 落地反弹下落重力标量;
			this.落地反弹速度阈值 = 落地反弹速度阈值;
			this.落地反弹时长 = 落地反弹时长;
			this.地面受击滞空 = 地面受击滞空;
			this.空中受击滞空 = 空中受击滞空;
		}

		// Token: 0x0602C753 RID: 182099 RVA: 0x00A2037C File Offset: 0x00A1E57C
		protected override IntPtr GetUStructPtr()
		{
			return SHitEffect.StaticStruct();
		}

		// Token: 0x0602C754 RID: 182100 RVA: 0x00A20388 File Offset: 0x00A1E588
		[NullableContext(2)]
		public SHitEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C755 RID: 182101 RVA: 0x00A20392 File Offset: 0x00A1E592
		public SHitEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C756 RID: 182102 RVA: 0x00A2039D File Offset: 0x00A1E59D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHitEffect(Pointer, false, true);
		}

		// Token: 0x0602C757 RID: 182103 RVA: 0x00A203A7 File Offset: 0x00A1E5A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHitEffect(Pointer, MemoryOwner);
		}

		// Token: 0x040176E6 RID: 95974
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SHitEffect.SHitEffect";

		// Token: 0x040176E7 RID: 95975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176E8 RID: 95976
		internal static int __PropertyOffset_0;

		// Token: 0x040176E9 RID: 95977
		internal static int __PropertyOffset_1;

		// Token: 0x040176EA RID: 95978
		internal static int __PropertyOffset_2;

		// Token: 0x040176EB RID: 95979
		internal static int __PropertyOffset_3;

		// Token: 0x040176EC RID: 95980
		internal static int __PropertyOffset_4;

		// Token: 0x040176ED RID: 95981
		internal static int __PropertyOffset_5;

		// Token: 0x040176EE RID: 95982
		internal static int __PropertyOffset_6;

		// Token: 0x040176EF RID: 95983
		internal static int __PropertyOffset_7;

		// Token: 0x040176F0 RID: 95984
		internal static int __PropertyOffset_8;

		// Token: 0x040176F1 RID: 95985
		internal static int __PropertyOffset_9;

		// Token: 0x040176F2 RID: 95986
		internal static int __PropertyOffset_10;

		// Token: 0x040176F3 RID: 95987
		internal static int __PropertyOffset_11;

		// Token: 0x040176F4 RID: 95988
		internal static int __PropertyOffset_12;

		// Token: 0x040176F5 RID: 95989
		internal static int __PropertyOffset_13;

		// Token: 0x040176F6 RID: 95990
		internal static int __PropertyOffset_14;

		// Token: 0x040176F7 RID: 95991
		internal static int __PropertyOffset_15;

		// Token: 0x040176F8 RID: 95992
		internal static int __PropertyOffset_16;

		// Token: 0x040176F9 RID: 95993
		internal static int __PropertyOffset_17;

		// Token: 0x040176FA RID: 95994
		internal static int __PropertyOffset_18;

		// Token: 0x040176FB RID: 95995
		internal static int __PropertyOffset_19;

		// Token: 0x040176FC RID: 95996
		internal static int __PropertyOffset_20;

		// Token: 0x040176FD RID: 95997
		internal static int __PropertyOffset_21;

		// Token: 0x040176FE RID: 95998
		[Nullable(2)]
		private SHitWhirlpool _地面受击滞空;

		// Token: 0x040176FF RID: 95999
		internal static int __PropertyOffset_22;

		// Token: 0x04017700 RID: 96000
		[Nullable(2)]
		private SHitWhirlpool _空中受击滞空;
	}
}
