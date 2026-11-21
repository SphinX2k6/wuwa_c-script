using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031E7 RID: 12775
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_DirectlyEnterRail.SMotorRailMoveConfig_DirectlyEnterRail")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SMotorRailMoveConfig_DirectlyEnterRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC48 RID: 130120 RVA: 0x009354A5 File Offset: 0x009336A5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_DirectlyEnterRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_DirectlyEnterRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_DirectlyEnterRail.SMotorRailMoveConfig_DirectlyEnterRail", ref SMotorRailMoveConfig_DirectlyEnterRail._ScriptStructPtr);
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x0601FC49 RID: 130121 RVA: 0x009354CC File Offset: 0x009336CC
		// (set) Token: 0x0601FC4A RID: 130122 RVA: 0x0093550F File Offset: 0x0093370F
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_CommonConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_CommonConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x0601FC4B RID: 130123 RVA: 0x00935530 File Offset: 0x00933730
		// (set) Token: 0x0601FC4C RID: 130124 RVA: 0x00935540 File Offset: 0x00933740
		public unsafe float MaxAbsorbDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_MaxAbsorbDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_MaxAbsorbDist) = value;
			}
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x0601FC4D RID: 130125 RVA: 0x00935551 File Offset: 0x00933751
		// (set) Token: 0x0601FC4E RID: 130126 RVA: 0x00935565 File Offset: 0x00933765
		public unsafe SMotorRailMove_EnterRailCondition EnterCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_EnterCondition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_EnterCondition) = value;
			}
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x0601FC4F RID: 130127 RVA: 0x0093557A File Offset: 0x0093377A
		// (set) Token: 0x0601FC50 RID: 130128 RVA: 0x0093558E File Offset: 0x0093378E
		public unsafe SMotorRailMove_LinearMove LinearMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_LinearMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_LinearMove) = value;
			}
		}

		// Token: 0x0601FC51 RID: 130129 RVA: 0x009355A3 File Offset: 0x009337A3
		public SMotorRailMoveConfig_DirectlyEnterRail()
		{
		}

		// Token: 0x0601FC52 RID: 130130 RVA: 0x009355AB File Offset: 0x009337AB
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_DirectlyEnterRail.StaticStruct();
		}

		// Token: 0x0601FC53 RID: 130131 RVA: 0x009355B7 File Offset: 0x009337B7
		[NullableContext(2)]
		public SMotorRailMoveConfig_DirectlyEnterRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC54 RID: 130132 RVA: 0x009355C1 File Offset: 0x009337C1
		public SMotorRailMoveConfig_DirectlyEnterRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC55 RID: 130133 RVA: 0x009355CC File Offset: 0x009337CC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_DirectlyEnterRail(Pointer, false, true);
		}

		// Token: 0x0601FC56 RID: 130134 RVA: 0x009355D6 File Offset: 0x009337D6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_DirectlyEnterRail(Pointer, MemoryOwner);
		}

		// Token: 0x040110C5 RID: 69829
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_DirectlyEnterRail.SMotorRailMoveConfig_DirectlyEnterRail";

		// Token: 0x040110C6 RID: 69830
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110C7 RID: 69831
		internal static int __PropertyOffset_CommonConfig;

		// Token: 0x040110C8 RID: 69832
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x040110C9 RID: 69833
		internal static int __PropertyOffset_MaxAbsorbDist;

		// Token: 0x040110CA RID: 69834
		internal static int __PropertyOffset_EnterCondition;

		// Token: 0x040110CB RID: 69835
		internal static int __PropertyOffset_LinearMove;
	}
}
