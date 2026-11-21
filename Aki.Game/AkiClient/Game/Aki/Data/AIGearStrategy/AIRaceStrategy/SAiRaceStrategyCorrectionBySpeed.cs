using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x0200324B RID: 12875
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionBySpeed.SAiRaceStrategyCorrectionBySpeed")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SAiRaceStrategyCorrectionBySpeed : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060202BA RID: 131770 RVA: 0x0093EE95 File Offset: 0x0093D095
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyCorrectionBySpeed._ScriptStructPtr != 0) ? SAiRaceStrategyCorrectionBySpeed._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionBySpeed.SAiRaceStrategyCorrectionBySpeed", ref SAiRaceStrategyCorrectionBySpeed._ScriptStructPtr);
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x060202BB RID: 131771 RVA: 0x0093EEB9 File Offset: 0x0093D0B9
		// (set) Token: 0x060202BC RID: 131772 RVA: 0x0093EEC9 File Offset: 0x0093D0C9
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionBySpeed.__PropertyOffset_Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionBySpeed.__PropertyOffset_Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x060202BD RID: 131773 RVA: 0x0093EEDC File Offset: 0x0093D0DC
		// (set) Token: 0x060202BE RID: 131774 RVA: 0x0093EF1F File Offset: 0x0093D11F
		public TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByDeltaAbsSpeedConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiRaceStrategyOneParamFunction> result;
				if ((result = this._CalcTargetSpeedByDeltaAbsSpeedConfig) == null)
				{
					result = (this._CalcTargetSpeedByDeltaAbsSpeedConfig = new TArray<SAiRaceStrategyOneParamFunction>(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionBySpeed.__PropertyOffset_CalcTargetSpeedByDeltaAbsSpeedConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalcTargetSpeedByDeltaAbsSpeedConfig.CopyAssign(value);
			}
		}

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x060202BF RID: 131775 RVA: 0x0093EF30 File Offset: 0x0093D130
		// (set) Token: 0x060202C0 RID: 131776 RVA: 0x0093EF73 File Offset: 0x0093D173
		public TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByRivalAbsSpeedConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiRaceStrategyOneParamFunction> result;
				if ((result = this._CalcTargetSpeedByRivalAbsSpeedConfig) == null)
				{
					result = (this._CalcTargetSpeedByRivalAbsSpeedConfig = new TArray<SAiRaceStrategyOneParamFunction>(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionBySpeed.__PropertyOffset_CalcTargetSpeedByRivalAbsSpeedConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalcTargetSpeedByRivalAbsSpeedConfig.CopyAssign(value);
			}
		}

		// Token: 0x060202C1 RID: 131777 RVA: 0x0093EF81 File Offset: 0x0093D181
		public SAiRaceStrategyCorrectionBySpeed()
		{
		}

		// Token: 0x060202C2 RID: 131778 RVA: 0x0093EF89 File Offset: 0x0093D189
		protected override IntPtr GetUStructPtr()
		{
			return SAiRaceStrategyCorrectionBySpeed.StaticStruct();
		}

		// Token: 0x060202C3 RID: 131779 RVA: 0x0093EF95 File Offset: 0x0093D195
		[NullableContext(2)]
		public SAiRaceStrategyCorrectionBySpeed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060202C4 RID: 131780 RVA: 0x0093EF9F File Offset: 0x0093D19F
		public SAiRaceStrategyCorrectionBySpeed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060202C5 RID: 131781 RVA: 0x0093EFAA File Offset: 0x0093D1AA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiRaceStrategyCorrectionBySpeed(Pointer, false, true);
		}

		// Token: 0x060202C6 RID: 131782 RVA: 0x0093EFB4 File Offset: 0x0093D1B4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiRaceStrategyCorrectionBySpeed(Pointer, MemoryOwner);
		}

		// Token: 0x0401150D RID: 70925
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionBySpeed.SAiRaceStrategyCorrectionBySpeed";

		// Token: 0x0401150E RID: 70926
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401150F RID: 70927
		internal static int __PropertyOffset_Enable;

		// Token: 0x04011510 RID: 70928
		internal static int __PropertyOffset_CalcTargetSpeedByDeltaAbsSpeedConfig;

		// Token: 0x04011511 RID: 70929
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAiRaceStrategyOneParamFunction> _CalcTargetSpeedByDeltaAbsSpeedConfig;

		// Token: 0x04011512 RID: 70930
		internal static int __PropertyOffset_CalcTargetSpeedByRivalAbsSpeedConfig;

		// Token: 0x04011513 RID: 70931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAiRaceStrategyOneParamFunction> _CalcTargetSpeedByRivalAbsSpeedConfig;
	}
}
