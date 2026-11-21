using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031E8 RID: 12776
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpAlongRail.SMotorRailMoveConfig_JumpAlongRail")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 188)]
	public class SMotorRailMoveConfig_JumpAlongRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC57 RID: 130135 RVA: 0x009355DF File Offset: 0x009337DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_JumpAlongRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_JumpAlongRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpAlongRail.SMotorRailMoveConfig_JumpAlongRail", ref SMotorRailMoveConfig_JumpAlongRail._ScriptStructPtr);
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x0601FC58 RID: 130136 RVA: 0x00935604 File Offset: 0x00933804
		// (set) Token: 0x0601FC59 RID: 130137 RVA: 0x00935647 File Offset: 0x00933847
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_CommonConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_CommonConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x0601FC5A RID: 130138 RVA: 0x00935668 File Offset: 0x00933868
		// (set) Token: 0x0601FC5B RID: 130139 RVA: 0x00935678 File Offset: 0x00933878
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x0601FC5C RID: 130140 RVA: 0x00935689 File Offset: 0x00933889
		// (set) Token: 0x0601FC5D RID: 130141 RVA: 0x0093569D File Offset: 0x0093389D
		public unsafe SMotorRailMove_ParabolaMove ParabolaMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_ParabolaMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_ParabolaMove) = value;
			}
		}

		// Token: 0x0601FC5E RID: 130142 RVA: 0x009356B2 File Offset: 0x009338B2
		public SMotorRailMoveConfig_JumpAlongRail()
		{
		}

		// Token: 0x0601FC5F RID: 130143 RVA: 0x009356BA File Offset: 0x009338BA
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_JumpAlongRail.StaticStruct();
		}

		// Token: 0x0601FC60 RID: 130144 RVA: 0x009356C6 File Offset: 0x009338C6
		[NullableContext(2)]
		public SMotorRailMoveConfig_JumpAlongRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC61 RID: 130145 RVA: 0x009356D0 File Offset: 0x009338D0
		public SMotorRailMoveConfig_JumpAlongRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC62 RID: 130146 RVA: 0x009356DB File Offset: 0x009338DB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_JumpAlongRail(Pointer, false, true);
		}

		// Token: 0x0601FC63 RID: 130147 RVA: 0x009356E5 File Offset: 0x009338E5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_JumpAlongRail(Pointer, MemoryOwner);
		}

		// Token: 0x040110CC RID: 69836
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpAlongRail.SMotorRailMoveConfig_JumpAlongRail";

		// Token: 0x040110CD RID: 69837
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110CE RID: 69838
		internal static int __PropertyOffset_CommonConfig;

		// Token: 0x040110CF RID: 69839
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x040110D0 RID: 69840
		internal static int __PropertyOffset_SkillId;

		// Token: 0x040110D1 RID: 69841
		internal static int __PropertyOffset_ParabolaMove;
	}
}
