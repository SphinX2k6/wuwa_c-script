using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F9 RID: 17145
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataMove.SBulletDataMove")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 140)]
	public class SBulletDataMove : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C4CA RID: 181450 RVA: 0x00A1C914 File Offset: 0x00A1AB14
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataMove._ScriptStructPtr != 0) ? SBulletDataMove._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataMove.SBulletDataMove", ref SBulletDataMove._ScriptStructPtr);
		}

		// Token: 0x17006E99 RID: 28313
		// (get) Token: 0x0602C4CB RID: 181451 RVA: 0x00A1C938 File Offset: 0x00A1AB38
		// (set) Token: 0x0602C4CC RID: 181452 RVA: 0x00A1C94C File Offset: 0x00A1AB4C
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletFollowType> 子弹跟随类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006E9A RID: 28314
		// (get) Token: 0x0602C4CD RID: 181453 RVA: 0x00A1C961 File Offset: 0x00A1AB61
		// (set) Token: 0x0602C4CE RID: 181454 RVA: 0x00A1C975 File Offset: 0x00A1AB75
		public unsafe FName 骨骼名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E9B RID: 28315
		// (get) Token: 0x0602C4CF RID: 181455 RVA: 0x00A1C98A File Offset: 0x00A1AB8A
		// (set) Token: 0x0602C4D0 RID: 181456 RVA: 0x00A1C99A File Offset: 0x00A1AB9A
		public unsafe bool 跟随骨骼面向发射
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E9C RID: 28316
		// (get) Token: 0x0602C4D1 RID: 181457 RVA: 0x00A1C9AB File Offset: 0x00A1ABAB
		// (set) Token: 0x0602C4D2 RID: 181458 RVA: 0x00A1C9BB File Offset: 0x00A1ABBB
		public unsafe bool 瞄准发射
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E9D RID: 28317
		// (get) Token: 0x0602C4D3 RID: 181459 RVA: 0x00A1C9CC File Offset: 0x00A1ABCC
		// (set) Token: 0x0602C4D4 RID: 181460 RVA: 0x00A1C9DC File Offset: 0x00A1ABDC
		public unsafe bool 无限制追踪子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E9E RID: 28318
		// (get) Token: 0x0602C4D5 RID: 181461 RVA: 0x00A1C9ED File Offset: 0x00A1ABED
		// (set) Token: 0x0602C4D6 RID: 181462 RVA: 0x00A1C9FD File Offset: 0x00A1ABFD
		public unsafe bool 不改变朝向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E9F RID: 28319
		// (get) Token: 0x0602C4D7 RID: 181463 RVA: 0x00A1CA0E File Offset: 0x00A1AC0E
		// (set) Token: 0x0602C4D8 RID: 181464 RVA: 0x00A1CA1E File Offset: 0x00A1AC1E
		public unsafe float 瞄准子弹最大射程
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006EA0 RID: 28320
		// (get) Token: 0x0602C4D9 RID: 181465 RVA: 0x00A1CA2F File Offset: 0x00A1AC2F
		// (set) Token: 0x0602C4DA RID: 181466 RVA: 0x00A1CA3F File Offset: 0x00A1AC3F
		public unsafe float 瞄准子弹最大偏转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006EA1 RID: 28321
		// (get) Token: 0x0602C4DB RID: 181467 RVA: 0x00A1CA50 File Offset: 0x00A1AC50
		// (set) Token: 0x0602C4DC RID: 181468 RVA: 0x00A1CA60 File Offset: 0x00A1AC60
		public unsafe bool 初始旋转是否面向目标
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006EA2 RID: 28322
		// (get) Token: 0x0602C4DD RID: 181469 RVA: 0x00A1CA71 File Offset: 0x00A1AC71
		// (set) Token: 0x0602C4DE RID: 181470 RVA: 0x00A1CA81 File Offset: 0x00A1AC81
		public unsafe float 初始旋转最大角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006EA3 RID: 28323
		// (get) Token: 0x0602C4DF RID: 181471 RVA: 0x00A1CA92 File Offset: 0x00A1AC92
		// (set) Token: 0x0602C4E0 RID: 181472 RVA: 0x00A1CAA2 File Offset: 0x00A1ACA2
		public unsafe float 初始速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006EA4 RID: 28324
		// (get) Token: 0x0602C4E1 RID: 181473 RVA: 0x00A1CAB3 File Offset: 0x00A1ACB3
		// (set) Token: 0x0602C4E2 RID: 181474 RVA: 0x00A1CAC7 File Offset: 0x00A1ACC7
		public unsafe UCurveFloat 速度变化曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006EA5 RID: 28325
		// (get) Token: 0x0602C4E3 RID: 181475 RVA: 0x00A1CADC File Offset: 0x00A1ACDC
		// (set) Token: 0x0602C4E4 RID: 181476 RVA: 0x00A1CAF0 File Offset: 0x00A1ACF0
		public unsafe FRotator 初始速度方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006EA6 RID: 28326
		// (get) Token: 0x0602C4E5 RID: 181477 RVA: 0x00A1CB05 File Offset: 0x00A1AD05
		// (set) Token: 0x0602C4E6 RID: 181478 RVA: 0x00A1CB19 File Offset: 0x00A1AD19
		public unsafe FRotator 方向偏转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006EA7 RID: 28327
		// (get) Token: 0x0602C4E7 RID: 181479 RVA: 0x00A1CB2E File Offset: 0x00A1AD2E
		// (set) Token: 0x0602C4E8 RID: 181480 RVA: 0x00A1CB42 File Offset: 0x00A1AD42
		public unsafe UCurveVector 方向偏转速度变化曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17006EA8 RID: 28328
		// (get) Token: 0x0602C4E9 RID: 181481 RVA: 0x00A1CB57 File Offset: 0x00A1AD57
		// (set) Token: 0x0602C4EA RID: 181482 RVA: 0x00A1CB67 File Offset: 0x00A1AD67
		public unsafe float 目标偏转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006EA9 RID: 28329
		// (get) Token: 0x0602C4EB RID: 181483 RVA: 0x00A1CB78 File Offset: 0x00A1AD78
		// (set) Token: 0x0602C4EC RID: 181484 RVA: 0x00A1CB8C File Offset: 0x00A1AD8C
		public unsafe UCurveFloat 目标偏转速度变化曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17006EAA RID: 28330
		// (get) Token: 0x0602C4ED RID: 181485 RVA: 0x00A1CBA1 File Offset: 0x00A1ADA1
		// (set) Token: 0x0602C4EE RID: 181486 RVA: 0x00A1CBB5 File Offset: 0x00A1ADB5
		public unsafe FVector 目标偏转速度分量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006EAB RID: 28331
		// (get) Token: 0x0602C4EF RID: 181487 RVA: 0x00A1CBCA File Offset: 0x00A1ADCA
		// (set) Token: 0x0602C4F0 RID: 181488 RVA: 0x00A1CBDE File Offset: 0x00A1ADDE
		public unsafe UCurveFloat 目标偏转速度分量Y变化曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17006EAC RID: 28332
		// (get) Token: 0x0602C4F1 RID: 181489 RVA: 0x00A1CBF3 File Offset: 0x00A1ADF3
		// (set) Token: 0x0602C4F2 RID: 181490 RVA: 0x00A1CC07 File Offset: 0x00A1AE07
		public unsafe UCurveFloat 目标偏转速度分量Z变化曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataMove.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17006EAD RID: 28333
		// (get) Token: 0x0602C4F3 RID: 181491 RVA: 0x00A1CC1C File Offset: 0x00A1AE1C
		// (set) Token: 0x0602C4F4 RID: 181492 RVA: 0x00A1CC30 File Offset: 0x00A1AE30
		public unsafe FVector 合外力
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMove.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x0602C4F5 RID: 181493 RVA: 0x00A1CC45 File Offset: 0x00A1AE45
		public SBulletDataMove()
		{
		}

		// Token: 0x0602C4F6 RID: 181494 RVA: 0x00A1CC50 File Offset: 0x00A1AE50
		[NullableContext(1)]
		public SBulletDataMove([Nullable(0)] TEnumAsByte<EBulletFollowType> 子弹跟随类型, FName 骨骼名, bool 跟随骨骼面向发射, bool 瞄准发射, bool 无限制追踪子弹, bool 不改变朝向, float 瞄准子弹最大射程, float 瞄准子弹最大偏转角度, bool 初始旋转是否面向目标, float 初始旋转最大角度, float 初始速度, UCurveFloat 速度变化曲线, FRotator 初始速度方向, FRotator 方向偏转速度, UCurveVector 方向偏转速度变化曲线, float 目标偏转速度, UCurveFloat 目标偏转速度变化曲线, FVector 目标偏转速度分量, UCurveFloat 目标偏转速度分量Y变化曲线, UCurveFloat 目标偏转速度分量Z变化曲线, FVector 合外力)
		{
			this.子弹跟随类型 = 子弹跟随类型;
			this.骨骼名 = 骨骼名;
			this.跟随骨骼面向发射 = 跟随骨骼面向发射;
			this.瞄准发射 = 瞄准发射;
			this.无限制追踪子弹 = 无限制追踪子弹;
			this.不改变朝向 = 不改变朝向;
			this.瞄准子弹最大射程 = 瞄准子弹最大射程;
			this.瞄准子弹最大偏转角度 = 瞄准子弹最大偏转角度;
			this.初始旋转是否面向目标 = 初始旋转是否面向目标;
			this.初始旋转最大角度 = 初始旋转最大角度;
			this.初始速度 = 初始速度;
			this.速度变化曲线 = 速度变化曲线;
			this.初始速度方向 = 初始速度方向;
			this.方向偏转速度 = 方向偏转速度;
			this.方向偏转速度变化曲线 = 方向偏转速度变化曲线;
			this.目标偏转速度 = 目标偏转速度;
			this.目标偏转速度变化曲线 = 目标偏转速度变化曲线;
			this.目标偏转速度分量 = 目标偏转速度分量;
			this.目标偏转速度分量Y变化曲线 = 目标偏转速度分量Y变化曲线;
			this.目标偏转速度分量Z变化曲线 = 目标偏转速度分量Z变化曲线;
			this.合外力 = 合外力;
		}

		// Token: 0x0602C4F7 RID: 181495 RVA: 0x00A1CD08 File Offset: 0x00A1AF08
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataMove.StaticStruct();
		}

		// Token: 0x0602C4F8 RID: 181496 RVA: 0x00A1CD14 File Offset: 0x00A1AF14
		public SBulletDataMove(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C4F9 RID: 181497 RVA: 0x00A1CD1E File Offset: 0x00A1AF1E
		public SBulletDataMove(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C4FA RID: 181498 RVA: 0x00A1CD29 File Offset: 0x00A1AF29
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataMove(Pointer, false, true);
		}

		// Token: 0x0602C4FB RID: 181499 RVA: 0x00A1CD33 File Offset: 0x00A1AF33
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataMove(Pointer, MemoryOwner);
		}

		// Token: 0x040175C4 RID: 95684
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataMove.SBulletDataMove";

		// Token: 0x040175C5 RID: 95685
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175C6 RID: 95686
		internal static int __PropertyOffset_0;

		// Token: 0x040175C7 RID: 95687
		internal static int __PropertyOffset_1;

		// Token: 0x040175C8 RID: 95688
		internal static int __PropertyOffset_2;

		// Token: 0x040175C9 RID: 95689
		internal static int __PropertyOffset_3;

		// Token: 0x040175CA RID: 95690
		internal static int __PropertyOffset_4;

		// Token: 0x040175CB RID: 95691
		internal static int __PropertyOffset_5;

		// Token: 0x040175CC RID: 95692
		internal static int __PropertyOffset_6;

		// Token: 0x040175CD RID: 95693
		internal static int __PropertyOffset_7;

		// Token: 0x040175CE RID: 95694
		internal static int __PropertyOffset_8;

		// Token: 0x040175CF RID: 95695
		internal static int __PropertyOffset_9;

		// Token: 0x040175D0 RID: 95696
		internal static int __PropertyOffset_10;

		// Token: 0x040175D1 RID: 95697
		internal static int __PropertyOffset_11;

		// Token: 0x040175D2 RID: 95698
		internal static int __PropertyOffset_12;

		// Token: 0x040175D3 RID: 95699
		internal static int __PropertyOffset_13;

		// Token: 0x040175D4 RID: 95700
		internal static int __PropertyOffset_14;

		// Token: 0x040175D5 RID: 95701
		internal static int __PropertyOffset_15;

		// Token: 0x040175D6 RID: 95702
		internal static int __PropertyOffset_16;

		// Token: 0x040175D7 RID: 95703
		internal static int __PropertyOffset_17;

		// Token: 0x040175D8 RID: 95704
		internal static int __PropertyOffset_18;

		// Token: 0x040175D9 RID: 95705
		internal static int __PropertyOffset_19;

		// Token: 0x040175DA RID: 95706
		internal static int __PropertyOffset_20;
	}
}
