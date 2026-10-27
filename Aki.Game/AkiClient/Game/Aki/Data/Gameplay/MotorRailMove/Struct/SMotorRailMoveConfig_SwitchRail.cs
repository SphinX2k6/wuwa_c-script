using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F3F RID: 16191
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_SwitchRail.SMotorRailMoveConfig_SwitchRail")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class SMotorRailMoveConfig_SwitchRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602935C RID: 168796 RVA: 0x009BE830 File Offset: 0x009BCA30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_SwitchRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_SwitchRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_SwitchRail.SMotorRailMoveConfig_SwitchRail", ref SMotorRailMoveConfig_SwitchRail._ScriptStructPtr);
		}

		// Token: 0x1700621B RID: 25115
		// (get) Token: 0x0602935D RID: 168797 RVA: 0x009BE854 File Offset: 0x009BCA54
		// (set) Token: 0x0602935E RID: 168798 RVA: 0x009BE897 File Offset: 0x009BCA97
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700621C RID: 25116
		// (get) Token: 0x0602935F RID: 168799 RVA: 0x009BE8B8 File Offset: 0x009BCAB8
		// (set) Token: 0x06029360 RID: 168800 RVA: 0x009BE8C8 File Offset: 0x009BCAC8
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700621D RID: 25117
		// (get) Token: 0x06029361 RID: 168801 RVA: 0x009BE8D9 File Offset: 0x009BCAD9
		// (set) Token: 0x06029362 RID: 168802 RVA: 0x009BE8ED File Offset: 0x009BCAED
		public unsafe SMotorRailMove_EnterRailCondition EnterCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700621E RID: 25118
		// (get) Token: 0x06029363 RID: 168803 RVA: 0x009BE902 File Offset: 0x009BCB02
		// (set) Token: 0x06029364 RID: 168804 RVA: 0x009BE916 File Offset: 0x009BCB16
		public unsafe SMotorRailMove_ParabolaMove ParabolaMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_SwitchRail.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06029365 RID: 168805 RVA: 0x009BE92B File Offset: 0x009BCB2B
		public SMotorRailMoveConfig_SwitchRail()
		{
		}

		// Token: 0x06029366 RID: 168806 RVA: 0x009BE933 File Offset: 0x009BCB33
		public SMotorRailMoveConfig_SwitchRail(SMotorRailMove_CommonConfig CommonConfig, int SkillId, SMotorRailMove_EnterRailCondition EnterCondition, SMotorRailMove_ParabolaMove ParabolaMove)
		{
			this.CommonConfig = CommonConfig;
			this.SkillId = SkillId;
			this.EnterCondition = EnterCondition;
			this.ParabolaMove = ParabolaMove;
		}

		// Token: 0x06029367 RID: 168807 RVA: 0x009BE958 File Offset: 0x009BCB58
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_SwitchRail.StaticStruct();
		}

		// Token: 0x06029368 RID: 168808 RVA: 0x009BE964 File Offset: 0x009BCB64
		[NullableContext(2)]
		public SMotorRailMoveConfig_SwitchRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029369 RID: 168809 RVA: 0x009BE96E File Offset: 0x009BCB6E
		public SMotorRailMoveConfig_SwitchRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602936A RID: 168810 RVA: 0x009BE979 File Offset: 0x009BCB79
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_SwitchRail(Pointer, false, true);
		}

		// Token: 0x0602936B RID: 168811 RVA: 0x009BE983 File Offset: 0x009BCB83
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_SwitchRail(Pointer, MemoryOwner);
		}

		// Token: 0x040151A4 RID: 86436
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_SwitchRail.SMotorRailMoveConfig_SwitchRail";

		// Token: 0x040151A5 RID: 86437
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151A6 RID: 86438
		internal static int __PropertyOffset_0;

		// Token: 0x040151A7 RID: 86439
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x040151A8 RID: 86440
		internal static int __PropertyOffset_1;

		// Token: 0x040151A9 RID: 86441
		internal static int __PropertyOffset_2;

		// Token: 0x040151AA RID: 86442
		internal static int __PropertyOffset_3;
	}
}
