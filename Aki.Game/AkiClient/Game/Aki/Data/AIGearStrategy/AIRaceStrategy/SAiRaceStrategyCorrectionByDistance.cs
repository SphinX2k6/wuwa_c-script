using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003FC5 RID: 16325
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByDistance.SAiRaceStrategyCorrectionByDistance")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SAiRaceStrategyCorrectionByDistance : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029CC1 RID: 171201 RVA: 0x009CCB5C File Offset: 0x009CAD5C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyCorrectionByDistance._ScriptStructPtr != 0) ? SAiRaceStrategyCorrectionByDistance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByDistance.SAiRaceStrategyCorrectionByDistance", ref SAiRaceStrategyCorrectionByDistance._ScriptStructPtr);
		}

		// Token: 0x17006553 RID: 25939
		// (get) Token: 0x06029CC2 RID: 171202 RVA: 0x009CCB80 File Offset: 0x009CAD80
		// (set) Token: 0x06029CC3 RID: 171203 RVA: 0x009CCB90 File Offset: 0x009CAD90
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByDistance.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByDistance.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006554 RID: 25940
		// (get) Token: 0x06029CC4 RID: 171204 RVA: 0x009CCBA4 File Offset: 0x009CADA4
		// (set) Token: 0x06029CC5 RID: 171205 RVA: 0x009CCBE7 File Offset: 0x009CADE7
		public TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByDistanceBetweenConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiRaceStrategyOneParamFunction> result;
				if ((result = this._CalcTargetSpeedByDistanceBetweenConfig) == null)
				{
					result = (this._CalcTargetSpeedByDistanceBetweenConfig = new TArray<SAiRaceStrategyOneParamFunction>(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByDistance.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalcTargetSpeedByDistanceBetweenConfig.CopyAssign(value);
			}
		}

		// Token: 0x06029CC6 RID: 171206 RVA: 0x009CCBF5 File Offset: 0x009CADF5
		public SAiRaceStrategyCorrectionByDistance()
		{
		}

		// Token: 0x06029CC7 RID: 171207 RVA: 0x009CCBFD File Offset: 0x009CADFD
		public SAiRaceStrategyCorrectionByDistance(bool Enable, TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByDistanceBetweenConfig)
		{
			this.Enable = Enable;
			this.CalcTargetSpeedByDistanceBetweenConfig = CalcTargetSpeedByDistanceBetweenConfig;
		}

		// Token: 0x06029CC8 RID: 171208 RVA: 0x009CCC13 File Offset: 0x009CAE13
		protected override IntPtr GetUStructPtr()
		{
			return SAiRaceStrategyCorrectionByDistance.StaticStruct();
		}

		// Token: 0x06029CC9 RID: 171209 RVA: 0x009CCC1F File Offset: 0x009CAE1F
		[NullableContext(2)]
		public SAiRaceStrategyCorrectionByDistance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029CCA RID: 171210 RVA: 0x009CCC29 File Offset: 0x009CAE29
		public SAiRaceStrategyCorrectionByDistance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029CCB RID: 171211 RVA: 0x009CCC34 File Offset: 0x009CAE34
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiRaceStrategyCorrectionByDistance(Pointer, false, true);
		}

		// Token: 0x06029CCC RID: 171212 RVA: 0x009CCC3E File Offset: 0x009CAE3E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiRaceStrategyCorrectionByDistance(Pointer, MemoryOwner);
		}

		// Token: 0x04015777 RID: 87927
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByDistance.SAiRaceStrategyCorrectionByDistance";

		// Token: 0x04015778 RID: 87928
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015779 RID: 87929
		internal static int __PropertyOffset_0;

		// Token: 0x0401577A RID: 87930
		internal static int __PropertyOffset_1;

		// Token: 0x0401577B RID: 87931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAiRaceStrategyOneParamFunction> _CalcTargetSpeedByDistanceBetweenConfig;
	}
}
