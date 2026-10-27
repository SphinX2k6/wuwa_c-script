using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F3E RID: 16190
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpToRail.SMotorRailMoveConfig_JumpToRail")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class SMotorRailMoveConfig_JumpToRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602934C RID: 168780 RVA: 0x009BE6D4 File Offset: 0x009BC8D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_JumpToRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_JumpToRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpToRail.SMotorRailMoveConfig_JumpToRail", ref SMotorRailMoveConfig_JumpToRail._ScriptStructPtr);
		}

		// Token: 0x17006217 RID: 25111
		// (get) Token: 0x0602934D RID: 168781 RVA: 0x009BE6F8 File Offset: 0x009BC8F8
		// (set) Token: 0x0602934E RID: 168782 RVA: 0x009BE73B File Offset: 0x009BC93B
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006218 RID: 25112
		// (get) Token: 0x0602934F RID: 168783 RVA: 0x009BE75C File Offset: 0x009BC95C
		// (set) Token: 0x06029350 RID: 168784 RVA: 0x009BE76C File Offset: 0x009BC96C
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006219 RID: 25113
		// (get) Token: 0x06029351 RID: 168785 RVA: 0x009BE77D File Offset: 0x009BC97D
		// (set) Token: 0x06029352 RID: 168786 RVA: 0x009BE791 File Offset: 0x009BC991
		public unsafe SMotorRailMove_EnterRailCondition EnterCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700621A RID: 25114
		// (get) Token: 0x06029353 RID: 168787 RVA: 0x009BE7A6 File Offset: 0x009BC9A6
		// (set) Token: 0x06029354 RID: 168788 RVA: 0x009BE7BA File Offset: 0x009BC9BA
		public unsafe SMotorRailMove_ParabolaMove ParabolaMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpToRail.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06029355 RID: 168789 RVA: 0x009BE7CF File Offset: 0x009BC9CF
		public SMotorRailMoveConfig_JumpToRail()
		{
		}

		// Token: 0x06029356 RID: 168790 RVA: 0x009BE7D7 File Offset: 0x009BC9D7
		public SMotorRailMoveConfig_JumpToRail(SMotorRailMove_CommonConfig CommonConfig, int SkillId, SMotorRailMove_EnterRailCondition EnterCondition, SMotorRailMove_ParabolaMove ParabolaMove)
		{
			this.CommonConfig = CommonConfig;
			this.SkillId = SkillId;
			this.EnterCondition = EnterCondition;
			this.ParabolaMove = ParabolaMove;
		}

		// Token: 0x06029357 RID: 168791 RVA: 0x009BE7FC File Offset: 0x009BC9FC
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_JumpToRail.StaticStruct();
		}

		// Token: 0x06029358 RID: 168792 RVA: 0x009BE808 File Offset: 0x009BCA08
		[NullableContext(2)]
		public SMotorRailMoveConfig_JumpToRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029359 RID: 168793 RVA: 0x009BE812 File Offset: 0x009BCA12
		public SMotorRailMoveConfig_JumpToRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602935A RID: 168794 RVA: 0x009BE81D File Offset: 0x009BCA1D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_JumpToRail(Pointer, false, true);
		}

		// Token: 0x0602935B RID: 168795 RVA: 0x009BE827 File Offset: 0x009BCA27
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_JumpToRail(Pointer, MemoryOwner);
		}

		// Token: 0x0401519D RID: 86429
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpToRail.SMotorRailMoveConfig_JumpToRail";

		// Token: 0x0401519E RID: 86430
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401519F RID: 86431
		internal static int __PropertyOffset_0;

		// Token: 0x040151A0 RID: 86432
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x040151A1 RID: 86433
		internal static int __PropertyOffset_1;

		// Token: 0x040151A2 RID: 86434
		internal static int __PropertyOffset_2;

		// Token: 0x040151A3 RID: 86435
		internal static int __PropertyOffset_3;
	}
}
