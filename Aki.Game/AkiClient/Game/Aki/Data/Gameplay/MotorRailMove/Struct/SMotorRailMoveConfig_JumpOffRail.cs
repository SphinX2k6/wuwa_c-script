using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031E9 RID: 12777
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpOffRail.SMotorRailMoveConfig_JumpOffRail")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SMotorRailMoveConfig_JumpOffRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC64 RID: 130148 RVA: 0x009356EE File Offset: 0x009338EE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_JumpOffRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_JumpOffRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpOffRail.SMotorRailMoveConfig_JumpOffRail", ref SMotorRailMoveConfig_JumpOffRail._ScriptStructPtr);
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0601FC65 RID: 130149 RVA: 0x00935714 File Offset: 0x00933914
		// (set) Token: 0x0601FC66 RID: 130150 RVA: 0x00935757 File Offset: 0x00933957
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_CommonConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_CommonConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0601FC67 RID: 130151 RVA: 0x00935778 File Offset: 0x00933978
		// (set) Token: 0x0601FC68 RID: 130152 RVA: 0x00935788 File Offset: 0x00933988
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0601FC69 RID: 130153 RVA: 0x00935799 File Offset: 0x00933999
		// (set) Token: 0x0601FC6A RID: 130154 RVA: 0x009357A9 File Offset: 0x009339A9
		public unsafe float SideOffsetAbs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_SideOffsetAbs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_SideOffsetAbs) = value;
			}
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x0601FC6B RID: 130155 RVA: 0x009357BA File Offset: 0x009339BA
		// (set) Token: 0x0601FC6C RID: 130156 RVA: 0x009357CE File Offset: 0x009339CE
		public unsafe SMotorRailMove_ParabolaMove ParabolaMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_ParabolaMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_ParabolaMove) = value;
			}
		}

		// Token: 0x0601FC6D RID: 130157 RVA: 0x009357E3 File Offset: 0x009339E3
		public SMotorRailMoveConfig_JumpOffRail()
		{
		}

		// Token: 0x0601FC6E RID: 130158 RVA: 0x009357EB File Offset: 0x009339EB
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_JumpOffRail.StaticStruct();
		}

		// Token: 0x0601FC6F RID: 130159 RVA: 0x009357F7 File Offset: 0x009339F7
		[NullableContext(2)]
		public SMotorRailMoveConfig_JumpOffRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC70 RID: 130160 RVA: 0x00935801 File Offset: 0x00933A01
		public SMotorRailMoveConfig_JumpOffRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC71 RID: 130161 RVA: 0x0093580C File Offset: 0x00933A0C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_JumpOffRail(Pointer, false, true);
		}

		// Token: 0x0601FC72 RID: 130162 RVA: 0x00935816 File Offset: 0x00933A16
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_JumpOffRail(Pointer, MemoryOwner);
		}

		// Token: 0x040110D2 RID: 69842
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpOffRail.SMotorRailMoveConfig_JumpOffRail";

		// Token: 0x040110D3 RID: 69843
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110D4 RID: 69844
		internal static int __PropertyOffset_CommonConfig;

		// Token: 0x040110D5 RID: 69845
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x040110D6 RID: 69846
		internal static int __PropertyOffset_SkillId;

		// Token: 0x040110D7 RID: 69847
		internal static int __PropertyOffset_SideOffsetAbs;

		// Token: 0x040110D8 RID: 69848
		internal static int __PropertyOffset_ParabolaMove;
	}
}
