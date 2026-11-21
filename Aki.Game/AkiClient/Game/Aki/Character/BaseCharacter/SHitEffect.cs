using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003352 RID: 13138
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SHitEffect.SHitEffect")]
	[UnrealStructLayout(164, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 164)]
	public class SHitEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213FC RID: 136188 RVA: 0x0095C7C7 File Offset: 0x0095A9C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHitEffect._ScriptStructPtr != 0) ? SHitEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SHitEffect.SHitEffect", ref SHitEffect._ScriptStructPtr);
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x060213FD RID: 136189 RVA: 0x0095C7EB File Offset: 0x0095A9EB
		// (set) Token: 0x060213FE RID: 136190 RVA: 0x0095C7FF File Offset: 0x0095A9FF
		public unsafe TEnumAsByte<EHitAnim> 被击动作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_被击动作);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_被击动作) = value;
			}
		}

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x060213FF RID: 136191 RVA: 0x0095C814 File Offset: 0x0095AA14
		// (set) Token: 0x06021400 RID: 136192 RVA: 0x0095C824 File Offset: 0x0095AA24
		public unsafe float 受击朝向Z轴偏转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_受击朝向Z轴偏转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_受击朝向Z轴偏转) = value;
			}
		}

		// Token: 0x17004359 RID: 17241
		// (get) Token: 0x06021401 RID: 136193 RVA: 0x0095C835 File Offset: 0x0095AA35
		// (set) Token: 0x06021402 RID: 136194 RVA: 0x0095C849 File Offset: 0x0095AA49
		public unsafe FVector 空中受击速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_空中受击速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_空中受击速度) = value;
			}
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x06021403 RID: 136195 RVA: 0x0095C85E File Offset: 0x0095AA5E
		// (set) Token: 0x06021404 RID: 136196 RVA: 0x0095C86E File Offset: 0x0095AA6E
		public unsafe float 空中受击移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_空中受击移动时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_空中受击移动时间) = value;
			}
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x06021405 RID: 136197 RVA: 0x0095C87F File Offset: 0x0095AA7F
		// (set) Token: 0x06021406 RID: 136198 RVA: 0x0095C88F File Offset: 0x0095AA8F
		public unsafe float 命中硬直时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_命中硬直时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_命中硬直时间) = value;
			}
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x06021407 RID: 136199 RVA: 0x0095C8A0 File Offset: 0x0095AAA0
		// (set) Token: 0x06021408 RID: 136200 RVA: 0x0095C8B4 File Offset: 0x0095AAB4
		public unsafe FVector 地面受击速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击速度) = value;
			}
		}

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x06021409 RID: 136201 RVA: 0x0095C8C9 File Offset: 0x0095AAC9
		// (set) Token: 0x0602140A RID: 136202 RVA: 0x0095C8D9 File Offset: 0x0095AAD9
		public unsafe float 地面受击移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击移动时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击移动时间) = value;
			}
		}

		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x0602140B RID: 136203 RVA: 0x0095C8EA File Offset: 0x0095AAEA
		// (set) Token: 0x0602140C RID: 136204 RVA: 0x0095C8FE File Offset: 0x0095AAFE
		public unsafe TEnumAsByte<EVelocityCurveType> 地面受击移动曲线
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击移动曲线);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击移动曲线) = value;
			}
		}

		// Token: 0x1700435F RID: 17247
		// (get) Token: 0x0602140D RID: 136205 RVA: 0x0095C913 File Offset: 0x0095AB13
		// (set) Token: 0x0602140E RID: 136206 RVA: 0x0095C923 File Offset: 0x0095AB23
		public unsafe float 地面受击最大速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击最大速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击最大速度) = value;
			}
		}

		// Token: 0x17004360 RID: 17248
		// (get) Token: 0x0602140F RID: 136207 RVA: 0x0095C934 File Offset: 0x0095AB34
		// (set) Token: 0x06021410 RID: 136208 RVA: 0x0095C944 File Offset: 0x0095AB44
		public unsafe float 地面受击最小速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击最小速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击最小速度) = value;
			}
		}

		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x06021411 RID: 136209 RVA: 0x0095C955 File Offset: 0x0095AB55
		// (set) Token: 0x06021412 RID: 136210 RVA: 0x0095C965 File Offset: 0x0095AB65
		public unsafe float 速度阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_速度阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_速度阈值) = value;
			}
		}

		// Token: 0x17004362 RID: 17250
		// (get) Token: 0x06021413 RID: 136211 RVA: 0x0095C976 File Offset: 0x0095AB76
		// (set) Token: 0x06021414 RID: 136212 RVA: 0x0095C986 File Offset: 0x0095AB86
		public unsafe float 上升标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_上升标量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_上升标量) = value;
			}
		}

		// Token: 0x17004363 RID: 17251
		// (get) Token: 0x06021415 RID: 136213 RVA: 0x0095C997 File Offset: 0x0095AB97
		// (set) Token: 0x06021416 RID: 136214 RVA: 0x0095C9A7 File Offset: 0x0095ABA7
		public unsafe float 弧顶标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_弧顶标量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_弧顶标量) = value;
			}
		}

		// Token: 0x17004364 RID: 17252
		// (get) Token: 0x06021417 RID: 136215 RVA: 0x0095C9B8 File Offset: 0x0095ABB8
		// (set) Token: 0x06021418 RID: 136216 RVA: 0x0095C9C8 File Offset: 0x0095ABC8
		public unsafe float 下落标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_下落标量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_下落标量) = value;
			}
		}

		// Token: 0x17004365 RID: 17253
		// (get) Token: 0x06021419 RID: 136217 RVA: 0x0095C9D9 File Offset: 0x0095ABD9
		// (set) Token: 0x0602141A RID: 136218 RVA: 0x0095C9E9 File Offset: 0x0095ABE9
		public unsafe bool 到达弧顶清除速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_到达弧顶清除速度) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_到达弧顶清除速度) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004366 RID: 17254
		// (get) Token: 0x0602141B RID: 136219 RVA: 0x0095C9FA File Offset: 0x0095ABFA
		// (set) Token: 0x0602141C RID: 136220 RVA: 0x0095CA0E File Offset: 0x0095AC0E
		public unsafe FVector 落地反弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹) = value;
			}
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x0602141D RID: 136221 RVA: 0x0095CA23 File Offset: 0x0095AC23
		// (set) Token: 0x0602141E RID: 136222 RVA: 0x0095CA33 File Offset: 0x0095AC33
		public unsafe float 落地反弹上升重力标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹上升重力标量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹上升重力标量) = value;
			}
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x0602141F RID: 136223 RVA: 0x0095CA44 File Offset: 0x0095AC44
		// (set) Token: 0x06021420 RID: 136224 RVA: 0x0095CA54 File Offset: 0x0095AC54
		public unsafe float 落地反弹弧顶重力标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹弧顶重力标量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹弧顶重力标量) = value;
			}
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x06021421 RID: 136225 RVA: 0x0095CA65 File Offset: 0x0095AC65
		// (set) Token: 0x06021422 RID: 136226 RVA: 0x0095CA75 File Offset: 0x0095AC75
		public unsafe float 落地反弹下落重力标量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹下落重力标量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹下落重力标量) = value;
			}
		}

		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x06021423 RID: 136227 RVA: 0x0095CA86 File Offset: 0x0095AC86
		// (set) Token: 0x06021424 RID: 136228 RVA: 0x0095CA96 File Offset: 0x0095AC96
		public unsafe float 落地反弹速度阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹速度阈值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹速度阈值) = value;
			}
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x06021425 RID: 136229 RVA: 0x0095CAA7 File Offset: 0x0095ACA7
		// (set) Token: 0x06021426 RID: 136230 RVA: 0x0095CAB7 File Offset: 0x0095ACB7
		public unsafe float 落地反弹时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_落地反弹时长) = value;
			}
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x06021427 RID: 136231 RVA: 0x0095CAC8 File Offset: 0x0095ACC8
		// (set) Token: 0x06021428 RID: 136232 RVA: 0x0095CB0B File Offset: 0x0095AD0B
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
					result = (this._地面受击滞空 = new SHitWhirlpool(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击滞空, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitWhirlpool.StaticStruct(), base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_地面受击滞空, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700436D RID: 17261
		// (get) Token: 0x06021429 RID: 136233 RVA: 0x0095CB2C File Offset: 0x0095AD2C
		// (set) Token: 0x0602142A RID: 136234 RVA: 0x0095CB6F File Offset: 0x0095AD6F
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
					result = (this._空中受击滞空 = new SHitWhirlpool(base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_空中受击滞空, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitWhirlpool.StaticStruct(), base.NativePtr + (IntPtr)SHitEffect.__PropertyOffset_空中受击滞空, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602142B RID: 136235 RVA: 0x0095CB90 File Offset: 0x0095AD90
		public SHitEffect()
		{
		}

		// Token: 0x0602142C RID: 136236 RVA: 0x0095CB98 File Offset: 0x0095AD98
		protected override IntPtr GetUStructPtr()
		{
			return SHitEffect.StaticStruct();
		}

		// Token: 0x0602142D RID: 136237 RVA: 0x0095CBA4 File Offset: 0x0095ADA4
		[NullableContext(2)]
		public SHitEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602142E RID: 136238 RVA: 0x0095CBAE File Offset: 0x0095ADAE
		public SHitEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602142F RID: 136239 RVA: 0x0095CBB9 File Offset: 0x0095ADB9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHitEffect(Pointer, false, true);
		}

		// Token: 0x06021430 RID: 136240 RVA: 0x0095CBC3 File Offset: 0x0095ADC3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHitEffect(Pointer, MemoryOwner);
		}

		// Token: 0x040122D0 RID: 74448
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SHitEffect.SHitEffect";

		// Token: 0x040122D1 RID: 74449
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122D2 RID: 74450
		internal static int __PropertyOffset_被击动作;

		// Token: 0x040122D3 RID: 74451
		internal static int __PropertyOffset_受击朝向Z轴偏转;

		// Token: 0x040122D4 RID: 74452
		internal static int __PropertyOffset_空中受击速度;

		// Token: 0x040122D5 RID: 74453
		internal static int __PropertyOffset_空中受击移动时间;

		// Token: 0x040122D6 RID: 74454
		internal static int __PropertyOffset_命中硬直时间;

		// Token: 0x040122D7 RID: 74455
		internal static int __PropertyOffset_地面受击速度;

		// Token: 0x040122D8 RID: 74456
		internal static int __PropertyOffset_地面受击移动时间;

		// Token: 0x040122D9 RID: 74457
		internal static int __PropertyOffset_地面受击移动曲线;

		// Token: 0x040122DA RID: 74458
		internal static int __PropertyOffset_地面受击最大速度;

		// Token: 0x040122DB RID: 74459
		internal static int __PropertyOffset_地面受击最小速度;

		// Token: 0x040122DC RID: 74460
		internal static int __PropertyOffset_速度阈值;

		// Token: 0x040122DD RID: 74461
		internal static int __PropertyOffset_上升标量;

		// Token: 0x040122DE RID: 74462
		internal static int __PropertyOffset_弧顶标量;

		// Token: 0x040122DF RID: 74463
		internal static int __PropertyOffset_下落标量;

		// Token: 0x040122E0 RID: 74464
		internal static int __PropertyOffset_到达弧顶清除速度;

		// Token: 0x040122E1 RID: 74465
		internal static int __PropertyOffset_落地反弹;

		// Token: 0x040122E2 RID: 74466
		internal static int __PropertyOffset_落地反弹上升重力标量;

		// Token: 0x040122E3 RID: 74467
		internal static int __PropertyOffset_落地反弹弧顶重力标量;

		// Token: 0x040122E4 RID: 74468
		internal static int __PropertyOffset_落地反弹下落重力标量;

		// Token: 0x040122E5 RID: 74469
		internal static int __PropertyOffset_落地反弹速度阈值;

		// Token: 0x040122E6 RID: 74470
		internal static int __PropertyOffset_落地反弹时长;

		// Token: 0x040122E7 RID: 74471
		internal static int __PropertyOffset_地面受击滞空;

		// Token: 0x040122E8 RID: 74472
		[Nullable(2)]
		private SHitWhirlpool _地面受击滞空;

		// Token: 0x040122E9 RID: 74473
		internal static int __PropertyOffset_空中受击滞空;

		// Token: 0x040122EA RID: 74474
		[Nullable(2)]
		private SHitWhirlpool _空中受击滞空;
	}
}
