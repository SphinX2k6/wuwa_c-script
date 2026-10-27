using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F3D RID: 16189
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpOffRail.SMotorRailMoveConfig_JumpOffRail")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SMotorRailMoveConfig_JumpOffRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602933C RID: 168764 RVA: 0x009BE57F File Offset: 0x009BC77F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_JumpOffRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_JumpOffRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpOffRail.SMotorRailMoveConfig_JumpOffRail", ref SMotorRailMoveConfig_JumpOffRail._ScriptStructPtr);
		}

		// Token: 0x17006213 RID: 25107
		// (get) Token: 0x0602933D RID: 168765 RVA: 0x009BE5A4 File Offset: 0x009BC7A4
		// (set) Token: 0x0602933E RID: 168766 RVA: 0x009BE5E7 File Offset: 0x009BC7E7
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006214 RID: 25108
		// (get) Token: 0x0602933F RID: 168767 RVA: 0x009BE608 File Offset: 0x009BC808
		// (set) Token: 0x06029340 RID: 168768 RVA: 0x009BE618 File Offset: 0x009BC818
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006215 RID: 25109
		// (get) Token: 0x06029341 RID: 168769 RVA: 0x009BE629 File Offset: 0x009BC829
		// (set) Token: 0x06029342 RID: 168770 RVA: 0x009BE639 File Offset: 0x009BC839
		public unsafe float SideOffsetAbs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006216 RID: 25110
		// (get) Token: 0x06029343 RID: 168771 RVA: 0x009BE64A File Offset: 0x009BC84A
		// (set) Token: 0x06029344 RID: 168772 RVA: 0x009BE65E File Offset: 0x009BC85E
		public unsafe SMotorRailMove_ParabolaMove ParabolaMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_JumpOffRail.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06029345 RID: 168773 RVA: 0x009BE673 File Offset: 0x009BC873
		public SMotorRailMoveConfig_JumpOffRail()
		{
		}

		// Token: 0x06029346 RID: 168774 RVA: 0x009BE67B File Offset: 0x009BC87B
		public SMotorRailMoveConfig_JumpOffRail(SMotorRailMove_CommonConfig CommonConfig, int SkillId, float SideOffsetAbs, SMotorRailMove_ParabolaMove ParabolaMove)
		{
			this.CommonConfig = CommonConfig;
			this.SkillId = SkillId;
			this.SideOffsetAbs = SideOffsetAbs;
			this.ParabolaMove = ParabolaMove;
		}

		// Token: 0x06029347 RID: 168775 RVA: 0x009BE6A0 File Offset: 0x009BC8A0
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_JumpOffRail.StaticStruct();
		}

		// Token: 0x06029348 RID: 168776 RVA: 0x009BE6AC File Offset: 0x009BC8AC
		[NullableContext(2)]
		public SMotorRailMoveConfig_JumpOffRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029349 RID: 168777 RVA: 0x009BE6B6 File Offset: 0x009BC8B6
		public SMotorRailMoveConfig_JumpOffRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602934A RID: 168778 RVA: 0x009BE6C1 File Offset: 0x009BC8C1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_JumpOffRail(Pointer, false, true);
		}

		// Token: 0x0602934B RID: 168779 RVA: 0x009BE6CB File Offset: 0x009BC8CB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_JumpOffRail(Pointer, MemoryOwner);
		}

		// Token: 0x04015196 RID: 86422
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_JumpOffRail.SMotorRailMoveConfig_JumpOffRail";

		// Token: 0x04015197 RID: 86423
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015198 RID: 86424
		internal static int __PropertyOffset_0;

		// Token: 0x04015199 RID: 86425
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x0401519A RID: 86426
		internal static int __PropertyOffset_1;

		// Token: 0x0401519B RID: 86427
		internal static int __PropertyOffset_2;

		// Token: 0x0401519C RID: 86428
		internal static int __PropertyOffset_3;
	}
}
