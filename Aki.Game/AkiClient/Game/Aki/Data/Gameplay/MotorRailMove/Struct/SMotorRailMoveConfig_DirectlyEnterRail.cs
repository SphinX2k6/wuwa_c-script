using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F3B RID: 16187
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_DirectlyEnterRail.SMotorRailMoveConfig_DirectlyEnterRail")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SMotorRailMoveConfig_DirectlyEnterRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602931E RID: 168734 RVA: 0x009BE2F8 File Offset: 0x009BC4F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_DirectlyEnterRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_DirectlyEnterRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_DirectlyEnterRail.SMotorRailMoveConfig_DirectlyEnterRail", ref SMotorRailMoveConfig_DirectlyEnterRail._ScriptStructPtr);
		}

		// Token: 0x1700620C RID: 25100
		// (get) Token: 0x0602931F RID: 168735 RVA: 0x009BE31C File Offset: 0x009BC51C
		// (set) Token: 0x06029320 RID: 168736 RVA: 0x009BE35F File Offset: 0x009BC55F
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700620D RID: 25101
		// (get) Token: 0x06029321 RID: 168737 RVA: 0x009BE380 File Offset: 0x009BC580
		// (set) Token: 0x06029322 RID: 168738 RVA: 0x009BE390 File Offset: 0x009BC590
		public unsafe float MaxAbsorbDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700620E RID: 25102
		// (get) Token: 0x06029323 RID: 168739 RVA: 0x009BE3A1 File Offset: 0x009BC5A1
		// (set) Token: 0x06029324 RID: 168740 RVA: 0x009BE3B5 File Offset: 0x009BC5B5
		public unsafe SMotorRailMove_EnterRailCondition EnterCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700620F RID: 25103
		// (get) Token: 0x06029325 RID: 168741 RVA: 0x009BE3CA File Offset: 0x009BC5CA
		// (set) Token: 0x06029326 RID: 168742 RVA: 0x009BE3DE File Offset: 0x009BC5DE
		public unsafe SMotorRailMove_LinearMove LinearMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_DirectlyEnterRail.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06029327 RID: 168743 RVA: 0x009BE3F3 File Offset: 0x009BC5F3
		public SMotorRailMoveConfig_DirectlyEnterRail()
		{
		}

		// Token: 0x06029328 RID: 168744 RVA: 0x009BE3FB File Offset: 0x009BC5FB
		public SMotorRailMoveConfig_DirectlyEnterRail(SMotorRailMove_CommonConfig CommonConfig, float MaxAbsorbDist, SMotorRailMove_EnterRailCondition EnterCondition, SMotorRailMove_LinearMove LinearMove)
		{
			this.CommonConfig = CommonConfig;
			this.MaxAbsorbDist = MaxAbsorbDist;
			this.EnterCondition = EnterCondition;
			this.LinearMove = LinearMove;
		}

		// Token: 0x06029329 RID: 168745 RVA: 0x009BE420 File Offset: 0x009BC620
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_DirectlyEnterRail.StaticStruct();
		}

		// Token: 0x0602932A RID: 168746 RVA: 0x009BE42C File Offset: 0x009BC62C
		[NullableContext(2)]
		public SMotorRailMoveConfig_DirectlyEnterRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602932B RID: 168747 RVA: 0x009BE436 File Offset: 0x009BC636
		public SMotorRailMoveConfig_DirectlyEnterRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602932C RID: 168748 RVA: 0x009BE441 File Offset: 0x009BC641
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_DirectlyEnterRail(Pointer, false, true);
		}

		// Token: 0x0602932D RID: 168749 RVA: 0x009BE44B File Offset: 0x009BC64B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_DirectlyEnterRail(Pointer, MemoryOwner);
		}

		// Token: 0x04015189 RID: 86409
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_DirectlyEnterRail.SMotorRailMoveConfig_DirectlyEnterRail";

		// Token: 0x0401518A RID: 86410
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401518B RID: 86411
		internal static int __PropertyOffset_0;

		// Token: 0x0401518C RID: 86412
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x0401518D RID: 86413
		internal static int __PropertyOffset_1;

		// Token: 0x0401518E RID: 86414
		internal static int __PropertyOffset_2;

		// Token: 0x0401518F RID: 86415
		internal static int __PropertyOffset_3;
	}
}
