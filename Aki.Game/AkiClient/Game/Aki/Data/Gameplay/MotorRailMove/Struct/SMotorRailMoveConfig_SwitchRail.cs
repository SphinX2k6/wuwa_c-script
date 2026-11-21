using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031EB RID: 12779
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_SwitchRail.SMotorRailMoveConfig_SwitchRail")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class SMotorRailMoveConfig_SwitchRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC82 RID: 130178 RVA: 0x00935957 File Offset: 0x00933B57
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_SwitchRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_SwitchRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_SwitchRail.SMotorRailMoveConfig_SwitchRail", ref SMotorRailMoveConfig_SwitchRail._ScriptStructPtr);
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x0601FC83 RID: 130179 RVA: 0x0093597C File Offset: 0x00933B7C
		// (set) Token: 0x0601FC84 RID: 130180 RVA: 0x009359BF File Offset: 0x00933BBF
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_CommonConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_CommonConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x0601FC85 RID: 130181 RVA: 0x009359E0 File Offset: 0x00933BE0
		// (set) Token: 0x0601FC86 RID: 130182 RVA: 0x009359F0 File Offset: 0x00933BF0
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x0601FC87 RID: 130183 RVA: 0x00935A01 File Offset: 0x00933C01
		// (set) Token: 0x0601FC88 RID: 130184 RVA: 0x00935A15 File Offset: 0x00933C15
		public unsafe SMotorRailMove_EnterRailCondition EnterCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_EnterCondition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_EnterCondition) = value;
			}
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x0601FC89 RID: 130185 RVA: 0x00935A2A File Offset: 0x00933C2A
		// (set) Token: 0x0601FC8A RID: 130186 RVA: 0x00935A3E File Offset: 0x00933C3E
		public unsafe SMotorRailMove_ParabolaMove ParabolaMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_ParabolaMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_ParabolaMove) = value;
			}
		}

		// Token: 0x0601FC8B RID: 130187 RVA: 0x00935A53 File Offset: 0x00933C53
		public SMotorRailMoveConfig_SwitchRail()
		{
		}

		// Token: 0x0601FC8C RID: 130188 RVA: 0x00935A5B File Offset: 0x00933C5B
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_SwitchRail.StaticStruct();
		}

		// Token: 0x0601FC8D RID: 130189 RVA: 0x00935A67 File Offset: 0x00933C67
		[NullableContext(2)]
		public SMotorRailMoveConfig_SwitchRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC8E RID: 130190 RVA: 0x00935A71 File Offset: 0x00933C71
		public SMotorRailMoveConfig_SwitchRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC8F RID: 130191 RVA: 0x00935A7C File Offset: 0x00933C7C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_SwitchRail(Pointer, false, true);
		}

		// Token: 0x0601FC90 RID: 130192 RVA: 0x00935A86 File Offset: 0x00933C86
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_SwitchRail(Pointer, MemoryOwner);
		}

		// Token: 0x040110E0 RID: 69856
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_SwitchRail.SMotorRailMoveConfig_SwitchRail";

		// Token: 0x040110E1 RID: 69857
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110E2 RID: 69858
		internal static int __PropertyOffset_CommonConfig;

		// Token: 0x040110E3 RID: 69859
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x040110E4 RID: 69860
		internal static int __PropertyOffset_SkillId;

		// Token: 0x040110E5 RID: 69861
		internal static int __PropertyOffset_EnterCondition;

		// Token: 0x040110E6 RID: 69862
		internal static int __PropertyOffset_ParabolaMove;
	}
}
