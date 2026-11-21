using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove
{
	// Token: 0x020031E4 RID: 12772
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/SMotorRailMoveConfig.SMotorRailMoveConfig")]
	[UnrealStructLayout(2064, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2064)]
	public class SMotorRailMoveConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FBF5 RID: 130037 RVA: 0x00934B52 File Offset: 0x00932D52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig._ScriptStructPtr != 0) ? SMotorRailMoveConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/SMotorRailMoveConfig.SMotorRailMoveConfig", ref SMotorRailMoveConfig._ScriptStructPtr);
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x0601FBF6 RID: 130038 RVA: 0x00934B76 File Offset: 0x00932D76
		// (set) Token: 0x0601FBF7 RID: 130039 RVA: 0x00934B8A File Offset: 0x00932D8A
		public unsafe string Remarks
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SMotorRailMoveConfig.__PropertyOffset_Remarks)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SMotorRailMoveConfig.__PropertyOffset_Remarks)), value);
			}
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x0601FBF8 RID: 130040 RVA: 0x00934B9F File Offset: 0x00932D9F
		// (set) Token: 0x0601FBF9 RID: 130041 RVA: 0x00934BAF File Offset: 0x00932DAF
		public unsafe bool EnableBasicConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableBasicConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableBasicConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x0601FBFA RID: 130042 RVA: 0x00934BC0 File Offset: 0x00932DC0
		// (set) Token: 0x0601FBFB RID: 130043 RVA: 0x00934C03 File Offset: 0x00932E03
		public SMotorRailMoveConfig_Basic BasicConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_Basic result;
				if ((result = this._BasicConfig) == null)
				{
					result = (this._BasicConfig = new SMotorRailMoveConfig_Basic(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_BasicConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_Basic.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_BasicConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x0601FBFC RID: 130044 RVA: 0x00934C24 File Offset: 0x00932E24
		// (set) Token: 0x0601FBFD RID: 130045 RVA: 0x00934C34 File Offset: 0x00932E34
		public unsafe bool EnableDirectlyEnterRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableDirectlyEnterRailConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableDirectlyEnterRailConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0601FBFE RID: 130046 RVA: 0x00934C48 File Offset: 0x00932E48
		// (set) Token: 0x0601FBFF RID: 130047 RVA: 0x00934C8B File Offset: 0x00932E8B
		public SMotorRailMoveConfig_DirectlyEnterRail DirectlyEnterRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_DirectlyEnterRail result;
				if ((result = this._DirectlyEnterRailConfig) == null)
				{
					result = (this._DirectlyEnterRailConfig = new SMotorRailMoveConfig_DirectlyEnterRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_DirectlyEnterRailConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_DirectlyEnterRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_DirectlyEnterRailConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x0601FC00 RID: 130048 RVA: 0x00934CAC File Offset: 0x00932EAC
		// (set) Token: 0x0601FC01 RID: 130049 RVA: 0x00934CBC File Offset: 0x00932EBC
		public unsafe bool EnableAccelerateAlongRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableAccelerateAlongRailConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableAccelerateAlongRailConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0601FC02 RID: 130050 RVA: 0x00934CD0 File Offset: 0x00932ED0
		// (set) Token: 0x0601FC03 RID: 130051 RVA: 0x00934D13 File Offset: 0x00932F13
		public SMotorRailMoveConfig_AccelerateAlongRail AccelerateAlongRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_AccelerateAlongRail result;
				if ((result = this._AccelerateAlongRailConfig) == null)
				{
					result = (this._AccelerateAlongRailConfig = new SMotorRailMoveConfig_AccelerateAlongRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_AccelerateAlongRailConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_AccelerateAlongRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_AccelerateAlongRailConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x0601FC04 RID: 130052 RVA: 0x00934D34 File Offset: 0x00932F34
		// (set) Token: 0x0601FC05 RID: 130053 RVA: 0x00934D44 File Offset: 0x00932F44
		public unsafe bool EnableJumpToRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableJumpToRailConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableJumpToRailConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x0601FC06 RID: 130054 RVA: 0x00934D58 File Offset: 0x00932F58
		// (set) Token: 0x0601FC07 RID: 130055 RVA: 0x00934D9B File Offset: 0x00932F9B
		public SMotorRailMoveConfig_JumpToRail JumpToRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_JumpToRail result;
				if ((result = this._JumpToRailConfig) == null)
				{
					result = (this._JumpToRailConfig = new SMotorRailMoveConfig_JumpToRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_JumpToRailConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_JumpToRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_JumpToRailConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x0601FC08 RID: 130056 RVA: 0x00934DBC File Offset: 0x00932FBC
		// (set) Token: 0x0601FC09 RID: 130057 RVA: 0x00934DCC File Offset: 0x00932FCC
		public unsafe bool EnableSwitchRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableSwitchRailConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableSwitchRailConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x0601FC0A RID: 130058 RVA: 0x00934DE0 File Offset: 0x00932FE0
		// (set) Token: 0x0601FC0B RID: 130059 RVA: 0x00934E23 File Offset: 0x00933023
		public SMotorRailMoveConfig_SwitchRail SwitchRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_SwitchRail result;
				if ((result = this._SwitchRailConfig) == null)
				{
					result = (this._SwitchRailConfig = new SMotorRailMoveConfig_SwitchRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_SwitchRailConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_SwitchRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_SwitchRailConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x0601FC0C RID: 130060 RVA: 0x00934E44 File Offset: 0x00933044
		// (set) Token: 0x0601FC0D RID: 130061 RVA: 0x00934E54 File Offset: 0x00933054
		public unsafe bool EnableJumpOffRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableJumpOffRailConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableJumpOffRailConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0601FC0E RID: 130062 RVA: 0x00934E68 File Offset: 0x00933068
		// (set) Token: 0x0601FC0F RID: 130063 RVA: 0x00934EAB File Offset: 0x009330AB
		public SMotorRailMoveConfig_JumpOffRail JumpOffRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_JumpOffRail result;
				if ((result = this._JumpOffRailConfig) == null)
				{
					result = (this._JumpOffRailConfig = new SMotorRailMoveConfig_JumpOffRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_JumpOffRailConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_JumpOffRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_JumpOffRailConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0601FC10 RID: 130064 RVA: 0x00934ECC File Offset: 0x009330CC
		// (set) Token: 0x0601FC11 RID: 130065 RVA: 0x00934EDC File Offset: 0x009330DC
		public unsafe bool EnableJumpAlongRailConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableJumpAlongRailConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_EnableJumpAlongRailConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x0601FC12 RID: 130066 RVA: 0x00934EF0 File Offset: 0x009330F0
		// (set) Token: 0x0601FC13 RID: 130067 RVA: 0x00934F33 File Offset: 0x00933133
		public SMotorRailMoveConfig_JumpAlongRail JumpAlongRailConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMoveConfig_JumpAlongRail result;
				if ((result = this._JumpAlongRailConfig) == null)
				{
					result = (this._JumpAlongRailConfig = new SMotorRailMoveConfig_JumpAlongRail(base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_JumpAlongRailConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMoveConfig_JumpAlongRail.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig.__PropertyOffset_JumpAlongRailConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FC14 RID: 130068 RVA: 0x00934F54 File Offset: 0x00933154
		public SMotorRailMoveConfig()
		{
		}

		// Token: 0x0601FC15 RID: 130069 RVA: 0x00934F5C File Offset: 0x0093315C
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig.StaticStruct();
		}

		// Token: 0x0601FC16 RID: 130070 RVA: 0x00934F68 File Offset: 0x00933168
		[NullableContext(2)]
		public SMotorRailMoveConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC17 RID: 130071 RVA: 0x00934F72 File Offset: 0x00933172
		public SMotorRailMoveConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC18 RID: 130072 RVA: 0x00934F7D File Offset: 0x0093317D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig(Pointer, false, true);
		}

		// Token: 0x0601FC19 RID: 130073 RVA: 0x00934F87 File Offset: 0x00933187
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401108E RID: 69774
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/SMotorRailMoveConfig.SMotorRailMoveConfig";

		// Token: 0x0401108F RID: 69775
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011090 RID: 69776
		internal static int __PropertyOffset_Remarks;

		// Token: 0x04011091 RID: 69777
		internal static int __PropertyOffset_EnableBasicConfig;

		// Token: 0x04011092 RID: 69778
		internal static int __PropertyOffset_BasicConfig;

		// Token: 0x04011093 RID: 69779
		[Nullable(2)]
		private SMotorRailMoveConfig_Basic _BasicConfig;

		// Token: 0x04011094 RID: 69780
		internal static int __PropertyOffset_EnableDirectlyEnterRailConfig;

		// Token: 0x04011095 RID: 69781
		internal static int __PropertyOffset_DirectlyEnterRailConfig;

		// Token: 0x04011096 RID: 69782
		[Nullable(2)]
		private SMotorRailMoveConfig_DirectlyEnterRail _DirectlyEnterRailConfig;

		// Token: 0x04011097 RID: 69783
		internal static int __PropertyOffset_EnableAccelerateAlongRailConfig;

		// Token: 0x04011098 RID: 69784
		internal static int __PropertyOffset_AccelerateAlongRailConfig;

		// Token: 0x04011099 RID: 69785
		[Nullable(2)]
		private SMotorRailMoveConfig_AccelerateAlongRail _AccelerateAlongRailConfig;

		// Token: 0x0401109A RID: 69786
		internal static int __PropertyOffset_EnableJumpToRailConfig;

		// Token: 0x0401109B RID: 69787
		internal static int __PropertyOffset_JumpToRailConfig;

		// Token: 0x0401109C RID: 69788
		[Nullable(2)]
		private SMotorRailMoveConfig_JumpToRail _JumpToRailConfig;

		// Token: 0x0401109D RID: 69789
		internal static int __PropertyOffset_EnableSwitchRailConfig;

		// Token: 0x0401109E RID: 69790
		internal static int __PropertyOffset_SwitchRailConfig;

		// Token: 0x0401109F RID: 69791
		[Nullable(2)]
		private SMotorRailMoveConfig_SwitchRail _SwitchRailConfig;

		// Token: 0x040110A0 RID: 69792
		internal static int __PropertyOffset_EnableJumpOffRailConfig;

		// Token: 0x040110A1 RID: 69793
		internal static int __PropertyOffset_JumpOffRailConfig;

		// Token: 0x040110A2 RID: 69794
		[Nullable(2)]
		private SMotorRailMoveConfig_JumpOffRail _JumpOffRailConfig;

		// Token: 0x040110A3 RID: 69795
		internal static int __PropertyOffset_EnableJumpAlongRailConfig;

		// Token: 0x040110A4 RID: 69796
		internal static int __PropertyOffset_JumpAlongRailConfig;

		// Token: 0x040110A5 RID: 69797
		[Nullable(2)]
		private SMotorRailMoveConfig_JumpAlongRail _JumpAlongRailConfig;
	}
}
