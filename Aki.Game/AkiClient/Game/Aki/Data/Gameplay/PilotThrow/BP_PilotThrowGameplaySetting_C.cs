using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.PilotThrow
{
	// Token: 0x02003F37 RID: 16183
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/PilotThrow/BP_PilotThrowGameplaySetting.BP_PilotThrowGameplaySetting_C")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class BP_PilotThrowGameplaySetting_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602929E RID: 168606 RVA: 0x009BD521 File Offset: 0x009BB721
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PilotThrowGameplaySetting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/PilotThrow/BP_PilotThrowGameplaySetting.BP_PilotThrowGameplaySetting_C");
			}
			return BP_PilotThrowGameplaySetting_C._ClassPtr;
		}

		// Token: 0x0602929F RID: 168607 RVA: 0x009BD548 File Offset: 0x009BB748
		public BP_PilotThrowGameplaySetting_C() : this(BuiltinUtils.AllocNativeUObject(BP_PilotThrowGameplaySetting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060292A0 RID: 168608 RVA: 0x009BD570 File Offset: 0x009BB770
		public BP_PilotThrowGameplaySetting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PilotThrowGameplaySetting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061DA RID: 25050
		// (get) Token: 0x060292A1 RID: 168609 RVA: 0x009BD5A3 File Offset: 0x009BB7A3
		// (set) Token: 0x060292A2 RID: 168610 RVA: 0x009BD5B3 File Offset: 0x009BB7B3
		public unsafe bool DebugMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061DB RID: 25051
		// (get) Token: 0x060292A3 RID: 168611 RVA: 0x009BD5C4 File Offset: 0x009BB7C4
		// (set) Token: 0x060292A4 RID: 168612 RVA: 0x009BD5D4 File Offset: 0x009BB7D4
		public unsafe float 初速度仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170061DC RID: 25052
		// (get) Token: 0x060292A5 RID: 168613 RVA: 0x009BD5E5 File Offset: 0x009BB7E5
		// (set) Token: 0x060292A6 RID: 168614 RVA: 0x009BD5F5 File Offset: 0x009BB7F5
		public unsafe float 初速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170061DD RID: 25053
		// (get) Token: 0x060292A7 RID: 168615 RVA: 0x009BD606 File Offset: 0x009BB806
		// (set) Token: 0x060292A8 RID: 168616 RVA: 0x009BD616 File Offset: 0x009BB816
		public unsafe float 射线检测半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170061DE RID: 25054
		// (get) Token: 0x060292A9 RID: 168617 RVA: 0x009BD627 File Offset: 0x009BB827
		// (set) Token: 0x060292AA RID: 168618 RVA: 0x009BD637 File Offset: 0x009BB837
		public unsafe float 重力加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170061DF RID: 25055
		// (get) Token: 0x060292AB RID: 168619 RVA: 0x009BD648 File Offset: 0x009BB848
		// (set) Token: 0x060292AC RID: 168620 RVA: 0x009BD65D File Offset: 0x009BB85D
		public TSoftObjectPtr<EffectModelGroup> 样条特效
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_5, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061E0 RID: 25056
		// (get) Token: 0x060292AD RID: 168621 RVA: 0x009BD682 File Offset: 0x009BB882
		// (set) Token: 0x060292AE RID: 168622 RVA: 0x009BD697 File Offset: 0x009BB897
		public TSoftObjectPtr<UEffectModelGroup> 终点特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_6, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061E1 RID: 25057
		// (get) Token: 0x060292AF RID: 168623 RVA: 0x009BD6BC File Offset: 0x009BB8BC
		// (set) Token: 0x060292B0 RID: 168624 RVA: 0x009BD6D0 File Offset: 0x009BB8D0
		public unsafe FVector2D 触屏移动系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170061E2 RID: 25058
		// (get) Token: 0x060292B1 RID: 168625 RVA: 0x009BD6E5 File Offset: 0x009BB8E5
		// (set) Token: 0x060292B2 RID: 168626 RVA: 0x009BD6F9 File Offset: 0x009BB8F9
		public unsafe FVector2D PC移动系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170061E3 RID: 25059
		// (get) Token: 0x060292B3 RID: 168627 RVA: 0x009BD70E File Offset: 0x009BB90E
		// (set) Token: 0x060292B4 RID: 168628 RVA: 0x009BD722 File Offset: 0x009BB922
		public unsafe FVector2D 手柄移动系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170061E4 RID: 25060
		// (get) Token: 0x060292B5 RID: 168629 RVA: 0x009BD737 File Offset: 0x009BB937
		// (set) Token: 0x060292B6 RID: 168630 RVA: 0x009BD747 File Offset: 0x009BB947
		public unsafe int 目标点高亮距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170061E5 RID: 25061
		// (get) Token: 0x060292B7 RID: 168631 RVA: 0x009BD758 File Offset: 0x009BB958
		// (set) Token: 0x060292B8 RID: 168632 RVA: 0x009BD768 File Offset: 0x009BB968
		public unsafe int 边缘超出角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170061E6 RID: 25062
		// (get) Token: 0x060292B9 RID: 168633 RVA: 0x009BD779 File Offset: 0x009BB979
		// (set) Token: 0x060292BA RID: 168634 RVA: 0x009BD789 File Offset: 0x009BB989
		public unsafe float Ui缩放_废弃_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170061E7 RID: 25063
		// (get) Token: 0x060292BB RID: 168635 RVA: 0x009BD79A File Offset: 0x009BB99A
		// (set) Token: 0x060292BC RID: 168636 RVA: 0x009BD7AA File Offset: 0x009BB9AA
		public unsafe float 铁驭旋转偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170061E8 RID: 25064
		// (get) Token: 0x060292BD RID: 168637 RVA: 0x009BD7BB File Offset: 0x009BB9BB
		// (set) Token: 0x060292BE RID: 168638 RVA: 0x009BD7CF File Offset: 0x009BB9CF
		[Nullable(2)]
		public unsafe UKuroForceFeedbackEffect 手柄震动配置
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PilotThrowGameplaySetting_C.__PropertyOffset_14);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PilotThrowGameplaySetting_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170061E9 RID: 25065
		// (get) Token: 0x060292BF RID: 168639 RVA: 0x009BD7E4 File Offset: 0x009BB9E4
		// (set) Token: 0x060292C0 RID: 168640 RVA: 0x009BD7F8 File Offset: 0x009BB9F8
		public unsafe FVectorDouble 抛物线起点偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170061EA RID: 25066
		// (get) Token: 0x060292C1 RID: 168641 RVA: 0x009BD80D File Offset: 0x009BBA0D
		// (set) Token: 0x060292C2 RID: 168642 RVA: 0x009BD81D File Offset: 0x009BBA1D
		public unsafe float 启动镜头插值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170061EB RID: 25067
		// (get) Token: 0x060292C3 RID: 168643 RVA: 0x009BD82E File Offset: 0x009BBA2E
		// (set) Token: 0x060292C4 RID: 168644 RVA: 0x009BD83E File Offset: 0x009BBA3E
		public unsafe float 自动投掷转状态延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170061EC RID: 25068
		// (get) Token: 0x060292C5 RID: 168645 RVA: 0x009BD84F File Offset: 0x009BBA4F
		// (set) Token: 0x060292C6 RID: 168646 RVA: 0x009BD863 File Offset: 0x009BBA63
		[Nullable(2)]
		public unsafe UCurveFloat 缩放曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PilotThrowGameplaySetting_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PilotThrowGameplaySetting_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x060292C7 RID: 168647 RVA: 0x009BD878 File Offset: 0x009BBA78
		protected BP_PilotThrowGameplaySetting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401513C RID: 86332
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/PilotThrow/BP_PilotThrowGameplaySetting.BP_PilotThrowGameplaySetting_C";

		// Token: 0x0401513D RID: 86333
		private static IntPtr _ClassPtr;

		// Token: 0x0401513E RID: 86334
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401513F RID: 86335
		internal static int __PropertyOffset_0;

		// Token: 0x04015140 RID: 86336
		internal static int __PropertyOffset_1;

		// Token: 0x04015141 RID: 86337
		internal static int __PropertyOffset_2;

		// Token: 0x04015142 RID: 86338
		internal static int __PropertyOffset_3;

		// Token: 0x04015143 RID: 86339
		internal static int __PropertyOffset_4;

		// Token: 0x04015144 RID: 86340
		internal static int __PropertyOffset_5;

		// Token: 0x04015145 RID: 86341
		internal static int __PropertyOffset_6;

		// Token: 0x04015146 RID: 86342
		internal static int __PropertyOffset_7;

		// Token: 0x04015147 RID: 86343
		internal static int __PropertyOffset_8;

		// Token: 0x04015148 RID: 86344
		internal static int __PropertyOffset_9;

		// Token: 0x04015149 RID: 86345
		internal static int __PropertyOffset_10;

		// Token: 0x0401514A RID: 86346
		internal static int __PropertyOffset_11;

		// Token: 0x0401514B RID: 86347
		internal static int __PropertyOffset_12;

		// Token: 0x0401514C RID: 86348
		internal static int __PropertyOffset_13;

		// Token: 0x0401514D RID: 86349
		internal static int __PropertyOffset_14;

		// Token: 0x0401514E RID: 86350
		internal static int __PropertyOffset_15;

		// Token: 0x0401514F RID: 86351
		internal static int __PropertyOffset_16;

		// Token: 0x04015150 RID: 86352
		internal static int __PropertyOffset_17;

		// Token: 0x04015151 RID: 86353
		internal static int __PropertyOffset_18;
	}
}
