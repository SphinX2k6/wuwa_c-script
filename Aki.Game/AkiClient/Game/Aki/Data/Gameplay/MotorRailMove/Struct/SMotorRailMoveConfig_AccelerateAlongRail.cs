using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F39 RID: 16185
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_AccelerateAlongRail.SMotorRailMoveConfig_AccelerateAlongRail")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class SMotorRailMoveConfig_AccelerateAlongRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060292EE RID: 168686 RVA: 0x009BDD48 File Offset: 0x009BBF48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_AccelerateAlongRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_AccelerateAlongRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_AccelerateAlongRail.SMotorRailMoveConfig_AccelerateAlongRail", ref SMotorRailMoveConfig_AccelerateAlongRail._ScriptStructPtr);
		}

		// Token: 0x170061FC RID: 25084
		// (get) Token: 0x060292EF RID: 168687 RVA: 0x009BDD6C File Offset: 0x009BBF6C
		// (set) Token: 0x060292F0 RID: 168688 RVA: 0x009BDDAF File Offset: 0x009BBFAF
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_AccelerateAlongRail.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_AccelerateAlongRail.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061FD RID: 25085
		// (get) Token: 0x060292F1 RID: 168689 RVA: 0x009BDDD0 File Offset: 0x009BBFD0
		// (set) Token: 0x060292F2 RID: 168690 RVA: 0x009BDDE4 File Offset: 0x009BBFE4
		public unsafe SMotorRailMove_LinearMove LinearMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_AccelerateAlongRail.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_AccelerateAlongRail.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x060292F3 RID: 168691 RVA: 0x009BDDF9 File Offset: 0x009BBFF9
		public SMotorRailMoveConfig_AccelerateAlongRail()
		{
		}

		// Token: 0x060292F4 RID: 168692 RVA: 0x009BDE01 File Offset: 0x009BC001
		public SMotorRailMoveConfig_AccelerateAlongRail(SMotorRailMove_CommonConfig CommonConfig, SMotorRailMove_LinearMove LinearMove)
		{
			this.CommonConfig = CommonConfig;
			this.LinearMove = LinearMove;
		}

		// Token: 0x060292F5 RID: 168693 RVA: 0x009BDE17 File Offset: 0x009BC017
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_AccelerateAlongRail.StaticStruct();
		}

		// Token: 0x060292F6 RID: 168694 RVA: 0x009BDE23 File Offset: 0x009BC023
		[NullableContext(2)]
		public SMotorRailMoveConfig_AccelerateAlongRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060292F7 RID: 168695 RVA: 0x009BDE2D File Offset: 0x009BC02D
		public SMotorRailMoveConfig_AccelerateAlongRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060292F8 RID: 168696 RVA: 0x009BDE38 File Offset: 0x009BC038
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_AccelerateAlongRail(Pointer, false, true);
		}

		// Token: 0x060292F9 RID: 168697 RVA: 0x009BDE42 File Offset: 0x009BC042
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_AccelerateAlongRail(Pointer, MemoryOwner);
		}

		// Token: 0x0401516A RID: 86378
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_AccelerateAlongRail.SMotorRailMoveConfig_AccelerateAlongRail";

		// Token: 0x0401516B RID: 86379
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401516C RID: 86380
		internal static int __PropertyOffset_0;

		// Token: 0x0401516D RID: 86381
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x0401516E RID: 86382
		internal static int __PropertyOffset_1;
	}
}
