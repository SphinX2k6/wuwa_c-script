using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031E5 RID: 12773
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_AccelerateAlongRail.SMotorRailMoveConfig_AccelerateAlongRail")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class SMotorRailMoveConfig_AccelerateAlongRail : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC1A RID: 130074 RVA: 0x00934F90 File Offset: 0x00933190
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_AccelerateAlongRail._ScriptStructPtr != 0) ? SMotorRailMoveConfig_AccelerateAlongRail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_AccelerateAlongRail.SMotorRailMoveConfig_AccelerateAlongRail", ref SMotorRailMoveConfig_AccelerateAlongRail._ScriptStructPtr);
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x0601FC1B RID: 130075 RVA: 0x00934FB4 File Offset: 0x009331B4
		// (set) Token: 0x0601FC1C RID: 130076 RVA: 0x00934FF7 File Offset: 0x009331F7
		public SMotorRailMove_CommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMotorRailMove_CommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SMotorRailMove_CommonConfig(base.NativePtr + (IntPtr)SMotorRailMoveConfig_AccelerateAlongRail.__PropertyOffset_CommonConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorRailMove_CommonConfig.StaticStruct(), base.NativePtr + (IntPtr)SMotorRailMoveConfig_AccelerateAlongRail.__PropertyOffset_CommonConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x0601FC1D RID: 130077 RVA: 0x00935018 File Offset: 0x00933218
		// (set) Token: 0x0601FC1E RID: 130078 RVA: 0x0093502C File Offset: 0x0093322C
		public unsafe SMotorRailMove_LinearMove LinearMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_AccelerateAlongRail.__PropertyOffset_LinearMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_AccelerateAlongRail.__PropertyOffset_LinearMove) = value;
			}
		}

		// Token: 0x0601FC1F RID: 130079 RVA: 0x00935041 File Offset: 0x00933241
		public SMotorRailMoveConfig_AccelerateAlongRail()
		{
		}

		// Token: 0x0601FC20 RID: 130080 RVA: 0x00935049 File Offset: 0x00933249
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_AccelerateAlongRail.StaticStruct();
		}

		// Token: 0x0601FC21 RID: 130081 RVA: 0x00935055 File Offset: 0x00933255
		[NullableContext(2)]
		public SMotorRailMoveConfig_AccelerateAlongRail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC22 RID: 130082 RVA: 0x0093505F File Offset: 0x0093325F
		public SMotorRailMoveConfig_AccelerateAlongRail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC23 RID: 130083 RVA: 0x0093506A File Offset: 0x0093326A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_AccelerateAlongRail(Pointer, false, true);
		}

		// Token: 0x0601FC24 RID: 130084 RVA: 0x00935074 File Offset: 0x00933274
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_AccelerateAlongRail(Pointer, MemoryOwner);
		}

		// Token: 0x040110A6 RID: 69798
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_AccelerateAlongRail.SMotorRailMoveConfig_AccelerateAlongRail";

		// Token: 0x040110A7 RID: 69799
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110A8 RID: 69800
		internal static int __PropertyOffset_CommonConfig;

		// Token: 0x040110A9 RID: 69801
		[Nullable(2)]
		private SMotorRailMove_CommonConfig _CommonConfig;

		// Token: 0x040110AA RID: 69802
		internal static int __PropertyOffset_LinearMove;
	}
}
