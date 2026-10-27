using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200431B RID: 17179
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SHitInformation.SHitInformation")]
	[UnrealStructLayout(2272, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2272)]
	public class SHitInformation : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C758 RID: 182104 RVA: 0x00A203B0 File Offset: 0x00A1E5B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHitInformation._ScriptStructPtr != 0) ? SHitInformation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SHitInformation.SHitInformation", ref SHitInformation._ScriptStructPtr);
		}

		// Token: 0x17006F5B RID: 28507
		// (get) Token: 0x0602C759 RID: 182105 RVA: 0x00A203D4 File Offset: 0x00A1E5D4
		// (set) Token: 0x0602C75A RID: 182106 RVA: 0x00A203E8 File Offset: 0x00A1E5E8
		[Nullable(2)]
		public unsafe TsBaseCharacter 攻击者
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006F5C RID: 28508
		// (get) Token: 0x0602C75B RID: 182107 RVA: 0x00A203FD File Offset: 0x00A1E5FD
		// (set) Token: 0x0602C75C RID: 182108 RVA: 0x00A20411 File Offset: 0x00A1E611
		[Nullable(2)]
		public unsafe TsBaseCharacter 受击者
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006F5D RID: 28509
		// (get) Token: 0x0602C75D RID: 182109 RVA: 0x00A20428 File Offset: 0x00A1E628
		// (set) Token: 0x0602C75E RID: 182110 RVA: 0x00A2046B File Offset: 0x00A1E66B
		public SHitEffect 被击效果
		{
			get
			{
				base.FastCheckIsValid();
				SHitEffect result;
				if ((result = this._被击效果) == null)
				{
					result = (this._被击效果 = new SHitEffect(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitEffect.StaticStruct(), base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F5E RID: 28510
		// (get) Token: 0x0602C75F RID: 182111 RVA: 0x00A2048C File Offset: 0x00A1E68C
		// (set) Token: 0x0602C760 RID: 182112 RVA: 0x00A2049C File Offset: 0x00A1E69C
		public unsafe int 子弹ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F5F RID: 28511
		// (get) Token: 0x0602C761 RID: 182113 RVA: 0x00A204AD File Offset: 0x00A1E6AD
		// (set) Token: 0x0602C762 RID: 182114 RVA: 0x00A204C1 File Offset: 0x00A1E6C1
		public unsafe FVector 受击特效位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006F60 RID: 28512
		// (get) Token: 0x0602C763 RID: 182115 RVA: 0x00A204D6 File Offset: 0x00A1E6D6
		// (set) Token: 0x0602C764 RID: 182116 RVA: 0x00A204EA File Offset: 0x00A1E6EA
		public unsafe FRotator 受击特效旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006F61 RID: 28513
		// (get) Token: 0x0602C765 RID: 182117 RVA: 0x00A204FF File Offset: 0x00A1E6FF
		// (set) Token: 0x0602C766 RID: 182118 RVA: 0x00A2050F File Offset: 0x00A1E70F
		public unsafe bool 是否震动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F62 RID: 28514
		// (get) Token: 0x0602C767 RID: 182119 RVA: 0x00A20520 File Offset: 0x00A1E720
		// (set) Token: 0x0602C768 RID: 182120 RVA: 0x00A20534 File Offset: 0x00A1E734
		public unsafe FName 受击部位
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006F63 RID: 28515
		// (get) Token: 0x0602C769 RID: 182121 RVA: 0x00A20549 File Offset: 0x00A1E749
		// (set) Token: 0x0602C76A RID: 182122 RVA: 0x00A2055D File Offset: 0x00A1E75D
		public unsafe FVector 受击位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006F64 RID: 28516
		// (get) Token: 0x0602C76B RID: 182123 RVA: 0x00A20572 File Offset: 0x00A1E772
		// (set) Token: 0x0602C76C RID: 182124 RVA: 0x00A20582 File Offset: 0x00A1E782
		public unsafe int 技能等级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006F65 RID: 28517
		// (get) Token: 0x0602C76D RID: 182125 RVA: 0x00A20594 File Offset: 0x00A1E794
		// (set) Token: 0x0602C76E RID: 182126 RVA: 0x00A205D7 File Offset: 0x00A1E7D7
		public SReBulletDataMain 重构子弹数据
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataMain result;
				if ((result = this._重构子弹数据) == null)
				{
					result = (this._重构子弹数据 = new SReBulletDataMain(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMain.StaticStruct(), base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F66 RID: 28518
		// (get) Token: 0x0602C76F RID: 182127 RVA: 0x00A205F8 File Offset: 0x00A1E7F8
		// (set) Token: 0x0602C770 RID: 182128 RVA: 0x00A2060C File Offset: 0x00A1E80C
		[Nullable(2)]
		public unsafe BulletLogicType_C 子弹逻辑预设
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BulletLogicType_C>(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_11);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006F67 RID: 28519
		// (get) Token: 0x0602C771 RID: 182129 RVA: 0x00A20621 File Offset: 0x00A1E821
		// (set) Token: 0x0602C772 RID: 182130 RVA: 0x00A20635 File Offset: 0x00A1E835
		public unsafe string 子弹表ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SHitInformation.__PropertyOffset_12)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SHitInformation.__PropertyOffset_12)), value);
			}
		}

		// Token: 0x17006F68 RID: 28520
		// (get) Token: 0x0602C773 RID: 182131 RVA: 0x00A2064A File Offset: 0x00A1E84A
		// (set) Token: 0x0602C774 RID: 182132 RVA: 0x00A2065A File Offset: 0x00A1E85A
		public unsafe int 伤害类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006F69 RID: 28521
		// (get) Token: 0x0602C775 RID: 182133 RVA: 0x00A2066B File Offset: 0x00A1E86B
		// (set) Token: 0x0602C776 RID: 182134 RVA: 0x00A2067B File Offset: 0x00A1E87B
		public unsafe long 伤害ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x0602C777 RID: 182135 RVA: 0x00A2068C File Offset: 0x00A1E88C
		public SHitInformation()
		{
		}

		// Token: 0x0602C778 RID: 182136 RVA: 0x00A20694 File Offset: 0x00A1E894
		public SHitInformation(TsBaseCharacter 攻击者, TsBaseCharacter 受击者, SHitEffect 被击效果, int 子弹ID, FVector 受击特效位置, FRotator 受击特效旋转, bool 是否震动, FName 受击部位, FVector 受击位置, int 技能等级, SReBulletDataMain 重构子弹数据, BulletLogicType_C 子弹逻辑预设, string 子弹表ID, int 伤害类型, long 伤害ID)
		{
			this.攻击者 = 攻击者;
			this.受击者 = 受击者;
			this.被击效果 = 被击效果;
			this.子弹ID = 子弹ID;
			this.受击特效位置 = 受击特效位置;
			this.受击特效旋转 = 受击特效旋转;
			this.是否震动 = 是否震动;
			this.受击部位 = 受击部位;
			this.受击位置 = 受击位置;
			this.技能等级 = 技能等级;
			this.重构子弹数据 = 重构子弹数据;
			this.子弹逻辑预设 = 子弹逻辑预设;
			this.子弹表ID = 子弹表ID;
			this.伤害类型 = 伤害类型;
			this.伤害ID = 伤害ID;
		}

		// Token: 0x0602C779 RID: 182137 RVA: 0x00A2071C File Offset: 0x00A1E91C
		protected override IntPtr GetUStructPtr()
		{
			return SHitInformation.StaticStruct();
		}

		// Token: 0x0602C77A RID: 182138 RVA: 0x00A20728 File Offset: 0x00A1E928
		[NullableContext(2)]
		public SHitInformation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C77B RID: 182139 RVA: 0x00A20732 File Offset: 0x00A1E932
		public SHitInformation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C77C RID: 182140 RVA: 0x00A2073D File Offset: 0x00A1E93D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHitInformation(Pointer, false, true);
		}

		// Token: 0x0602C77D RID: 182141 RVA: 0x00A20747 File Offset: 0x00A1E947
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHitInformation(Pointer, MemoryOwner);
		}

		// Token: 0x04017701 RID: 96001
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SHitInformation.SHitInformation";

		// Token: 0x04017702 RID: 96002
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017703 RID: 96003
		internal static int __PropertyOffset_0;

		// Token: 0x04017704 RID: 96004
		internal static int __PropertyOffset_1;

		// Token: 0x04017705 RID: 96005
		internal static int __PropertyOffset_2;

		// Token: 0x04017706 RID: 96006
		[Nullable(2)]
		private SHitEffect _被击效果;

		// Token: 0x04017707 RID: 96007
		internal static int __PropertyOffset_3;

		// Token: 0x04017708 RID: 96008
		internal static int __PropertyOffset_4;

		// Token: 0x04017709 RID: 96009
		internal static int __PropertyOffset_5;

		// Token: 0x0401770A RID: 96010
		internal static int __PropertyOffset_6;

		// Token: 0x0401770B RID: 96011
		internal static int __PropertyOffset_7;

		// Token: 0x0401770C RID: 96012
		internal static int __PropertyOffset_8;

		// Token: 0x0401770D RID: 96013
		internal static int __PropertyOffset_9;

		// Token: 0x0401770E RID: 96014
		internal static int __PropertyOffset_10;

		// Token: 0x0401770F RID: 96015
		[Nullable(2)]
		private SReBulletDataMain _重构子弹数据;

		// Token: 0x04017710 RID: 96016
		internal static int __PropertyOffset_11;

		// Token: 0x04017711 RID: 96017
		internal static int __PropertyOffset_12;

		// Token: 0x04017712 RID: 96018
		internal static int __PropertyOffset_13;

		// Token: 0x04017713 RID: 96019
		internal static int __PropertyOffset_14;
	}
}
