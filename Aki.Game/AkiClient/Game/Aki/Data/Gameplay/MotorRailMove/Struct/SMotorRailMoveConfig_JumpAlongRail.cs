using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F3C RID: 16188
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpAlongRail.SMotorRailMoveConfig_JumpAlongRail")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 188)]
	public class SMotorRailMoveConfig_JumpAlongRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602932E RID: 168750 RVA: 0x009BE454 File Offset: 0x009BC654
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_JumpAlongRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_JumpAlongRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpAlongRail.SMotorRailMoveConfig_JumpAlongRail", ref SMotorRailMoveConfig_JumpAlongRail._ScriptStructPtr);
		}

		// Token: 0x17006210 RID: 25104
		// (get) Token: 0x0602932F RID: 168751 RVA: 0x009BE478 File Offset: 0x009BC678
		// (set) Token: 0x06029330 RID: 168752 RVA: 0x009BE4BB File Offset: 0x009BC6BB
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006211 RID: 25105
		// (get) Token: 0x06029331 RID: 168753 RVA: 0x009BE4DC File Offset: 0x009BC6DC
		// (set) Token: 0x06029332 RID: 168754 RVA: 0x009BE4EC File Offset: 0x009BC6EC
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006212 RID: 25106
		// (get) Token: 0x06029333 RID: 168755 RVA: 0x009BE4FD File Offset: 0x009BC6FD
		// (set) Token: 0x06029334 RID: 168756 RVA: 0x009BE511 File Offset: 0x009BC711
		public unsafe SMotorRailMove_ParabolaMove ParabolaMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpAlongRail.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06029335 RID: 168757 RVA: 0x009BE526 File Offset: 0x009BC726
		public SMotorRailMoveConfig_JumpAlongRail()
		{
		}

		// Token: 0x06029336 RID: 168758 RVA: 0x009BE52E File Offset: 0x009BC72E
		public SMotorRailMoveConfig_JumpAlongRail(SMotorRailMove_CommonConfig CommonConfig, int SkillId, SMotorRailMove_ParabolaMove ParabolaMove)
		{
			this.CommonConfig = CommonConfig;
			this.SkillId = SkillId;
			this.ParabolaMove = ParabolaMove;
		}

		// Token: 0x06029337 RID: 168759 RVA: 0x009BE54B File Offset: 0x009BC74B
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_JumpAlongRail.StaticStruct();
		}

		// Token: 0x06029338 RID: 168760 RVA: 0x009BE557 File Offset: 0x009BC757
		[NullableContext(2)]
		public SMotorRailMoveConfig_JumpAlongRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029339 RID: 168761 RVA: 0x009BE561 File Offset: 0x009BC761
		public SMotorRailMoveConfig_JumpAlongRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602933A RID: 168762 RVA: 0x009BE56C File Offset: 0x009BC76C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_JumpAlongRail(Pointer, false, true);
		}

		// Token: 0x0602933B RID: 168763 RVA: 0x009BE576 File Offset: 0x009BC776
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_JumpAlongRail(Pointer, MemoryOwner);
		}

		// Token: 0x04015190 RID: 86416
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpAlongRail.SMotorRailMoveConfig_JumpAlongRail";

		// Token: 0x04015191 RID: 86417
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015192 RID: 86418
		internal static int __PropertyOffset_0;

		// Token: 0x04015193 RID: 86419
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x04015194 RID: 86420
		internal static int __PropertyOffset_1;

		// Token: 0x04015195 RID: 86421
		internal static int __PropertyOffset_2;
	}
}
