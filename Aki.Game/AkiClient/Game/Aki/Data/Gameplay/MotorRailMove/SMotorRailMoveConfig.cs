using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove
{
	// Token: 0x02003F38 RID: 16184
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/SMotorRailMoveConfig.SMotorRailMoveConfig")]
	[UnrealStructLayout(2064, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2064)]
	public class SMotorRailMoveConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060292C8 RID: 168648 RVA: 0x009BD881 File Offset: 0x009BBA81
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig._ScriptStructPtr != 0) ? SMotorRailMoveConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/SMotorRailMoveConfig.SMotorRailMoveConfig", ref SMotorRailMoveConfig._ScriptStructPtr);
		}

		// Token: 0x170061ED RID: 25069
		// (get) Token: 0x060292C9 RID: 168649 RVA: 0x009BD8A5 File Offset: 0x009BBAA5
		// (set) Token: 0x060292CA RID: 168650 RVA: 0x009BD8B9 File Offset: 0x009BBAB9
		public unsafe string Remarks
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SMotorRailMoveConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SMotorRailMoveConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170061EE RID: 25070
		// (get) Token: 0x060292CB RID: 168651 RVA: 0x009BD8CE File Offset: 0x009BBACE
		// (set) Token: 0x060292CC RID: 168652 RVA: 0x009BD8DE File Offset: 0x009BBADE
		public unsafe bool EnableBasicConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061EF RID: 25071
		// (get) Token: 0x060292CD RID: 168653 RVA: 0x009BD8F0 File Offset: 0x009BBAF0
		// (set) Token: 0x060292CE RID: 168654 RVA: 0x009BD933 File Offset: 0x009BBB33
		public SMotorRailMoveConfig_Basic BasicConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_Basic result;
				if ((result = this._BasicConfig) == null)
				{
					result = (this._BasicConfig = new SMotorRailMoveConfig_Basic(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_Basic.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061F0 RID: 25072
		// (get) Token: 0x060292CF RID: 168655 RVA: 0x009BD954 File Offset: 0x009BBB54
		// (set) Token: 0x060292D0 RID: 168656 RVA: 0x009BD964 File Offset: 0x009BBB64
		public unsafe bool EnableDirectlyEnterRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061F1 RID: 25073
		// (get) Token: 0x060292D1 RID: 168657 RVA: 0x009BD978 File Offset: 0x009BBB78
		// (set) Token: 0x060292D2 RID: 168658 RVA: 0x009BD9BB File Offset: 0x009BBBBB
		public SMotorRailMoveConfig_DirectlyEnterRail DirectlyEnterRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_DirectlyEnterRail result;
				if ((result = this._DirectlyEnterRailConfig) == null)
				{
					result = (this._DirectlyEnterRailConfig = new SMotorRailMoveConfig_DirectlyEnterRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_DirectlyEnterRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061F2 RID: 25074
		// (get) Token: 0x060292D3 RID: 168659 RVA: 0x009BD9DC File Offset: 0x009BBBDC
		// (set) Token: 0x060292D4 RID: 168660 RVA: 0x009BD9EC File Offset: 0x009BBBEC
		public unsafe bool EnableAccelerateAlongRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061F3 RID: 25075
		// (get) Token: 0x060292D5 RID: 168661 RVA: 0x009BDA00 File Offset: 0x009BBC00
		// (set) Token: 0x060292D6 RID: 168662 RVA: 0x009BDA43 File Offset: 0x009BBC43
		public SMotorRailMoveConfig_AccelerateAlongRail AccelerateAlongRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_AccelerateAlongRail result;
				if ((result = this._AccelerateAlongRailConfig) == null)
				{
					result = (this._AccelerateAlongRailConfig = new SMotorRailMoveConfig_AccelerateAlongRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_AccelerateAlongRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061F4 RID: 25076
		// (get) Token: 0x060292D7 RID: 168663 RVA: 0x009BDA64 File Offset: 0x009BBC64
		// (set) Token: 0x060292D8 RID: 168664 RVA: 0x009BDA74 File Offset: 0x009BBC74
		public unsafe bool EnableJumpToRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061F5 RID: 25077
		// (get) Token: 0x060292D9 RID: 168665 RVA: 0x009BDA88 File Offset: 0x009BBC88
		// (set) Token: 0x060292DA RID: 168666 RVA: 0x009BDACB File Offset: 0x009BBCCB
		public SMotorRailMoveConfig_JumpToRail JumpToRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_JumpToRail result;
				if ((result = this._JumpToRailConfig) == null)
				{
					result = (this._JumpToRailConfig = new SMotorRailMoveConfig_JumpToRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_JumpToRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061F6 RID: 25078
		// (get) Token: 0x060292DB RID: 168667 RVA: 0x009BDAEC File Offset: 0x009BBCEC
		// (set) Token: 0x060292DC RID: 168668 RVA: 0x009BDAFC File Offset: 0x009BBCFC
		public unsafe bool EnableSwitchRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061F7 RID: 25079
		// (get) Token: 0x060292DD RID: 168669 RVA: 0x009BDB10 File Offset: 0x009BBD10
		// (set) Token: 0x060292DE RID: 168670 RVA: 0x009BDB53 File Offset: 0x009BBD53
		public SMotorRailMoveConfig_SwitchRail SwitchRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_SwitchRail result;
				if ((result = this._SwitchRailConfig) == null)
				{
					result = (this._SwitchRailConfig = new SMotorRailMoveConfig_SwitchRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_SwitchRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061F8 RID: 25080
		// (get) Token: 0x060292DF RID: 168671 RVA: 0x009BDB74 File Offset: 0x009BBD74
		// (set) Token: 0x060292E0 RID: 168672 RVA: 0x009BDB84 File Offset: 0x009BBD84
		public unsafe bool EnableJumpOffRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061F9 RID: 25081
		// (get) Token: 0x060292E1 RID: 168673 RVA: 0x009BDB98 File Offset: 0x009BBD98
		// (set) Token: 0x060292E2 RID: 168674 RVA: 0x009BDBDB File Offset: 0x009BBDDB
		public SMotorRailMoveConfig_JumpOffRail JumpOffRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_JumpOffRail result;
				if ((result = this._JumpOffRailConfig) == null)
				{
					result = (this._JumpOffRailConfig = new SMotorRailMoveConfig_JumpOffRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_JumpOffRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061FA RID: 25082
		// (get) Token: 0x060292E3 RID: 168675 RVA: 0x009BDBFC File Offset: 0x009BBDFC
		// (set) Token: 0x060292E4 RID: 168676 RVA: 0x009BDC0C File Offset: 0x009BBE0C
		public unsafe bool EnableJumpAlongRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061FB RID: 25083
		// (get) Token: 0x060292E5 RID: 168677 RVA: 0x009BDC20 File Offset: 0x009BBE20
		// (set) Token: 0x060292E6 RID: 168678 RVA: 0x009BDC63 File Offset: 0x009BBE63
		public SMotorRailMoveConfig_JumpAlongRail JumpAlongRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_JumpAlongRail result;
				if ((result = this._JumpAlongRailConfig) == null)
				{
					result = (this._JumpAlongRailConfig = new SMotorRailMoveConfig_JumpAlongRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_14, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_JumpAlongRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_14, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060292E7 RID: 168679 RVA: 0x009BDC84 File Offset: 0x009BBE84
		public SMotorRailMoveConfig()
		{
		}

		// Token: 0x060292E8 RID: 168680 RVA: 0x009BDC8C File Offset: 0x009BBE8C
		public SMotorRailMoveConfig(string Remarks, bool EnableBasicConfig, SMotorRailMoveConfig_Basic BasicConfig, bool EnableDirectlyEnterRailConfig, SMotorRailMoveConfig_DirectlyEnterRail DirectlyEnterRailConfig, bool EnableAccelerateAlongRailConfig, SMotorRailMoveConfig_AccelerateAlongRail AccelerateAlongRailConfig, bool EnableJumpToRailConfig, SMotorRailMoveConfig_JumpToRail JumpToRailConfig, bool EnableSwitchRailConfig, SMotorRailMoveConfig_SwitchRail SwitchRailConfig, bool EnableJumpOffRailConfig, SMotorRailMoveConfig_JumpOffRail JumpOffRailConfig, bool EnableJumpAlongRailConfig, SMotorRailMoveConfig_JumpAlongRail JumpAlongRailConfig)
		{
			this.Remarks = Remarks;
			this.EnableBasicConfig = EnableBasicConfig;
			this.BasicConfig = BasicConfig;
			this.EnableDirectlyEnterRailConfig = EnableDirectlyEnterRailConfig;
			this.DirectlyEnterRailConfig = DirectlyEnterRailConfig;
			this.EnableAccelerateAlongRailConfig = EnableAccelerateAlongRailConfig;
			this.AccelerateAlongRailConfig = AccelerateAlongRailConfig;
			this.EnableJumpToRailConfig = EnableJumpToRailConfig;
			this.JumpToRailConfig = JumpToRailConfig;
			this.EnableSwitchRailConfig = EnableSwitchRailConfig;
			this.SwitchRailConfig = SwitchRailConfig;
			this.EnableJumpOffRailConfig = EnableJumpOffRailConfig;
			this.JumpOffRailConfig = JumpOffRailConfig;
			this.EnableJumpAlongRailConfig = EnableJumpAlongRailConfig;
			this.JumpAlongRailConfig = JumpAlongRailConfig;
		}

		// Token: 0x060292E9 RID: 168681 RVA: 0x009BDD14 File Offset: 0x009BBF14
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig.StaticStruct();
		}

		// Token: 0x060292EA RID: 168682 RVA: 0x009BDD20 File Offset: 0x009BBF20
		[NullableContext(2)]
		public SMotorRailMoveConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060292EB RID: 168683 RVA: 0x009BDD2A File Offset: 0x009BBF2A
		public SMotorRailMoveConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060292EC RID: 168684 RVA: 0x009BDD35 File Offset: 0x009BBF35
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig(Pointer, false, true);
		}

		// Token: 0x060292ED RID: 168685 RVA: 0x009BDD3F File Offset: 0x009BBF3F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04015152 RID: 86354
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/SMotorRailMoveConfig.SMotorRailMoveConfig";

		// Token: 0x04015153 RID: 86355
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015154 RID: 86356
		internal static int __PropertyOffset_0;

		// Token: 0x04015155 RID: 86357
		internal static int __PropertyOffset_1;

		// Token: 0x04015156 RID: 86358
		internal static int __PropertyOffset_2;

		// Token: 0x04015157 RID: 86359
		[Nullable(2)]
		private SMotorRailMoveConfig_Basic _BasicConfig;

		// Token: 0x04015158 RID: 86360
		internal static int __PropertyOffset_3;

		// Token: 0x04015159 RID: 86361
		internal static int __PropertyOffset_4;

		// Token: 0x0401515A RID: 86362
		[Nullable(2)]
		private SMotorRailMoveConfig_DirectlyEnterRail _DirectlyEnterRailConfig;

		// Token: 0x0401515B RID: 86363
		internal static int __PropertyOffset_5;

		// Token: 0x0401515C RID: 86364
		internal static int __PropertyOffset_6;

		// Token: 0x0401515D RID: 86365
		[Nullable(2)]
		private SMotorRailMoveConfig_AccelerateAlongRail _AccelerateAlongRailConfig;

		// Token: 0x0401515E RID: 86366
		internal static int __PropertyOffset_7;

		// Token: 0x0401515F RID: 86367
		internal static int __PropertyOffset_8;

		// Token: 0x04015160 RID: 86368
		[Nullable(2)]
		private SMotorRailMoveConfig_JumpToRail _JumpToRailConfig;

		// Token: 0x04015161 RID: 86369
		internal static int __PropertyOffset_9;

		// Token: 0x04015162 RID: 86370
		internal static int __PropertyOffset_10;

		// Token: 0x04015163 RID: 86371
		[Nullable(2)]
		private SMotorRailMoveConfig_SwitchRail _SwitchRailConfig;

		// Token: 0x04015164 RID: 86372
		internal static int __PropertyOffset_11;

		// Token: 0x04015165 RID: 86373
		internal static int __PropertyOffset_12;

		// Token: 0x04015166 RID: 86374
		[Nullable(2)]
		private SMotorRailMoveConfig_JumpOffRail _JumpOffRailConfig;

		// Token: 0x04015167 RID: 86375
		internal static int __PropertyOffset_13;

		// Token: 0x04015168 RID: 86376
		internal static int __PropertyOffset_14;

		// Token: 0x04015169 RID: 86377
		[Nullable(2)]
		private SMotorRailMoveConfig_JumpAlongRail _JumpAlongRailConfig;
	}
}
