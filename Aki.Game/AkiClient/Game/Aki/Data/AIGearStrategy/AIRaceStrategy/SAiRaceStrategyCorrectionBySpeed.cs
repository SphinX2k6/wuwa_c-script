using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003FC6 RID: 16326
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionBySpeed.SAiRaceStrategyCorrectionBySpeed")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SAiRaceStrategyCorrectionBySpeed : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029CCD RID: 171213 RVA: 0x009CCC47 File Offset: 0x009CAE47
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyCorrectionBySpeed._ScriptStructPtr != 0) ? SAiRaceStrategyCorrectionBySpeed._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionBySpeed.SAiRaceStrategyCorrectionBySpeed", ref SAiRaceStrategyCorrectionBySpeed._ScriptStructPtr);
		}

		// Token: 0x17006555 RID: 25941
		// (get) Token: 0x06029CCE RID: 171214 RVA: 0x009CCC6B File Offset: 0x009CAE6B
		// (set) Token: 0x06029CCF RID: 171215 RVA: 0x009CCC7B File Offset: 0x009CAE7B
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionBySpeed.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionBySpeed.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006556 RID: 25942
		// (get) Token: 0x06029CD0 RID: 171216 RVA: 0x009CCC8C File Offset: 0x009CAE8C
		// (set) Token: 0x06029CD1 RID: 171217 RVA: 0x009CCCCF File Offset: 0x009CAECF
		public TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByDeltaAbsSpeedConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiRaceStrategyOneParamFunction> result;
				if ((result = this._CalcTargetSpeedByDeltaAbsSpeedConfig) == null)
				{
					result = (this._CalcTargetSpeedByDeltaAbsSpeedConfig = new TArray<SAiRaceStrategyOneParamFunction>(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionBySpeed.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalcTargetSpeedByDeltaAbsSpeedConfig.CopyAssign(value);
			}
		}

		// Token: 0x17006557 RID: 25943
		// (get) Token: 0x06029CD2 RID: 171218 RVA: 0x009CCCE0 File Offset: 0x009CAEE0
		// (set) Token: 0x06029CD3 RID: 171219 RVA: 0x009CCD23 File Offset: 0x009CAF23
		public TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByRivalAbsSpeedConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiRaceStrategyOneParamFunction> result;
				if ((result = this._CalcTargetSpeedByRivalAbsSpeedConfig) == null)
				{
					result = (this._CalcTargetSpeedByRivalAbsSpeedConfig = new TArray<SAiRaceStrategyOneParamFunction>(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionBySpeed.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalcTargetSpeedByRivalAbsSpeedConfig.CopyAssign(value);
			}
		}

		// Token: 0x06029CD4 RID: 171220 RVA: 0x009CCD31 File Offset: 0x009CAF31
		public SAiRaceStrategyCorrectionBySpeed()
		{
		}

		// Token: 0x06029CD5 RID: 171221 RVA: 0x009CCD39 File Offset: 0x009CAF39
		public SAiRaceStrategyCorrectionBySpeed(bool Enable, TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByDeltaAbsSpeedConfig, TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByRivalAbsSpeedConfig)
		{
			this.Enable = Enable;
			this.CalcTargetSpeedByDeltaAbsSpeedConfig = CalcTargetSpeedByDeltaAbsSpeedConfig;
			this.CalcTargetSpeedByRivalAbsSpeedConfig = CalcTargetSpeedByRivalAbsSpeedConfig;
		}

		// Token: 0x06029CD6 RID: 171222 RVA: 0x009CCD56 File Offset: 0x009CAF56
		protected override IntPtr GetUStructPtr()
		{
			return SAiRaceStrategyCorrectionBySpeed.StaticStruct();
		}

		// Token: 0x06029CD7 RID: 171223 RVA: 0x009CCD62 File Offset: 0x009CAF62
		[NullableContext(2)]
		public SAiRaceStrategyCorrectionBySpeed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029CD8 RID: 171224 RVA: 0x009CCD6C File Offset: 0x009CAF6C
		public SAiRaceStrategyCorrectionBySpeed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029CD9 RID: 171225 RVA: 0x009CCD77 File Offset: 0x009CAF77
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiRaceStrategyCorrectionBySpeed(Pointer, false, true);
		}

		// Token: 0x06029CDA RID: 171226 RVA: 0x009CCD81 File Offset: 0x009CAF81
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiRaceStrategyCorrectionBySpeed(Pointer, MemoryOwner);
		}

		// Token: 0x0401577C RID: 87932
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionBySpeed.SAiRaceStrategyCorrectionBySpeed";

		// Token: 0x0401577D RID: 87933
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401577E RID: 87934
		internal static int __PropertyOffset_0;

		// Token: 0x0401577F RID: 87935
		internal static int __PropertyOffset_1;

		// Token: 0x04015780 RID: 87936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAiRaceStrategyOneParamFunction> _CalcTargetSpeedByDeltaAbsSpeedConfig;

		// Token: 0x04015781 RID: 87937
		internal static int __PropertyOffset_2;

		// Token: 0x04015782 RID: 87938
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAiRaceStrategyOneParamFunction> _CalcTargetSpeedByRivalAbsSpeedConfig;
	}
}
