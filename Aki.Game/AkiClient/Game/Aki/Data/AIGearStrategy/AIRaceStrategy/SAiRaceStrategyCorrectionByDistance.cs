using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x0200324A RID: 12874
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByDistance.SAiRaceStrategyCorrectionByDistance")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SAiRaceStrategyCorrectionByDistance : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060202AF RID: 131759 RVA: 0x0093EDC0 File Offset: 0x0093CFC0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyCorrectionByDistance._ScriptStructPtr != 0) ? SAiRaceStrategyCorrectionByDistance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByDistance.SAiRaceStrategyCorrectionByDistance", ref SAiRaceStrategyCorrectionByDistance._ScriptStructPtr);
		}

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x060202B0 RID: 131760 RVA: 0x0093EDE4 File Offset: 0x0093CFE4
		// (set) Token: 0x060202B1 RID: 131761 RVA: 0x0093EDF4 File Offset: 0x0093CFF4
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByDistance.__PropertyOffset_Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByDistance.__PropertyOffset_Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x060202B2 RID: 131762 RVA: 0x0093EE08 File Offset: 0x0093D008
		// (set) Token: 0x060202B3 RID: 131763 RVA: 0x0093EE4B File Offset: 0x0093D04B
		public TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByDistanceBetweenConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiRaceStrategyOneParamFunction> result;
				if ((result = this._CalcTargetSpeedByDistanceBetweenConfig) == null)
				{
					result = (this._CalcTargetSpeedByDistanceBetweenConfig = new TArray<SAiRaceStrategyOneParamFunction>(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByDistance.__PropertyOffset_CalcTargetSpeedByDistanceBetweenConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalcTargetSpeedByDistanceBetweenConfig.CopyAssign(value);
			}
		}

		// Token: 0x060202B4 RID: 131764 RVA: 0x0093EE59 File Offset: 0x0093D059
		public SAiRaceStrategyCorrectionByDistance()
		{
		}

		// Token: 0x060202B5 RID: 131765 RVA: 0x0093EE61 File Offset: 0x0093D061
		protected override IntPtr GetUStructPtr()
		{
			return SAiRaceStrategyCorrectionByDistance.StaticStruct();
		}

		// Token: 0x060202B6 RID: 131766 RVA: 0x0093EE6D File Offset: 0x0093D06D
		[NullableContext(2)]
		public SAiRaceStrategyCorrectionByDistance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060202B7 RID: 131767 RVA: 0x0093EE77 File Offset: 0x0093D077
		public SAiRaceStrategyCorrectionByDistance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060202B8 RID: 131768 RVA: 0x0093EE82 File Offset: 0x0093D082
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiRaceStrategyCorrectionByDistance(Pointer, false, true);
		}

		// Token: 0x060202B9 RID: 131769 RVA: 0x0093EE8C File Offset: 0x0093D08C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiRaceStrategyCorrectionByDistance(Pointer, MemoryOwner);
		}

		// Token: 0x04011508 RID: 70920
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByDistance.SAiRaceStrategyCorrectionByDistance";

		// Token: 0x04011509 RID: 70921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401150A RID: 70922
		internal static int __PropertyOffset_Enable;

		// Token: 0x0401150B RID: 70923
		internal static int __PropertyOffset_CalcTargetSpeedByDistanceBetweenConfig;

		// Token: 0x0401150C RID: 70924
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAiRaceStrategyOneParamFunction> _CalcTargetSpeedByDistanceBetweenConfig;
	}
}
