using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031EA RID: 12778
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpToRail.SMotorRailMoveConfig_JumpToRail")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class SMotorRailMoveConfig_JumpToRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC73 RID: 130163 RVA: 0x0093581F File Offset: 0x00933A1F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_JumpToRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_JumpToRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpToRail.SMotorRailMoveConfig_JumpToRail", ref SMotorRailMoveConfig_JumpToRail._ScriptStructPtr);
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x0601FC74 RID: 130164 RVA: 0x00935844 File Offset: 0x00933A44
		// (set) Token: 0x0601FC75 RID: 130165 RVA: 0x00935887 File Offset: 0x00933A87
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_CommonConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_CommonConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0601FC76 RID: 130166 RVA: 0x009358A8 File Offset: 0x00933AA8
		// (set) Token: 0x0601FC77 RID: 130167 RVA: 0x009358B8 File Offset: 0x00933AB8
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0601FC78 RID: 130168 RVA: 0x009358C9 File Offset: 0x00933AC9
		// (set) Token: 0x0601FC79 RID: 130169 RVA: 0x009358DD File Offset: 0x00933ADD
		public unsafe SMotorRailMove_EnterRailCondition EnterCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_EnterCondition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_EnterCondition) = value;
			}
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0601FC7A RID: 130170 RVA: 0x009358F2 File Offset: 0x00933AF2
		// (set) Token: 0x0601FC7B RID: 130171 RVA: 0x00935906 File Offset: 0x00933B06
		public unsafe SMotorRailMove_ParabolaMove ParabolaMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_ParabolaMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_ParabolaMove) = value;
			}
		}

		// Token: 0x0601FC7C RID: 130172 RVA: 0x0093591B File Offset: 0x00933B1B
		public SMotorRailMoveConfig_JumpToRail()
		{
		}

		// Token: 0x0601FC7D RID: 130173 RVA: 0x00935923 File Offset: 0x00933B23
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_JumpToRail.StaticStruct();
		}

		// Token: 0x0601FC7E RID: 130174 RVA: 0x0093592F File Offset: 0x00933B2F
		[NullableContext(2)]
		public SMotorRailMoveConfig_JumpToRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC7F RID: 130175 RVA: 0x00935939 File Offset: 0x00933B39
		public SMotorRailMoveConfig_JumpToRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC80 RID: 130176 RVA: 0x00935944 File Offset: 0x00933B44
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_JumpToRail(Pointer, false, true);
		}

		// Token: 0x0601FC81 RID: 130177 RVA: 0x0093594E File Offset: 0x00933B4E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_JumpToRail(Pointer, MemoryOwner);
		}

		// Token: 0x040110D9 RID: 69849
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpToRail.SMotorRailMoveConfig_JumpToRail";

		// Token: 0x040110DA RID: 69850
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110DB RID: 69851
		internal static int __PropertyOffset_CommonConfig;

		// Token: 0x040110DC RID: 69852
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x040110DD RID: 69853
		internal static int __PropertyOffset_SkillId;

		// Token: 0x040110DE RID: 69854
		internal static int __PropertyOffset_EnterCondition;

		// Token: 0x040110DF RID: 69855
		internal static int __PropertyOffset_ParabolaMove;
	}
}
