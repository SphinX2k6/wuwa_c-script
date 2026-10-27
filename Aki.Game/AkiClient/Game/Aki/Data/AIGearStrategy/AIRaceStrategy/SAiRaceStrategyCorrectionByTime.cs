using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003FC7 RID: 16327
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByTime.SAiRaceStrategyCorrectionByTime")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SAiRaceStrategyCorrectionByTime : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029CDB RID: 171227 RVA: 0x009CCD8A File Offset: 0x009CAF8A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyCorrectionByTime._ScriptStructPtr != 0) ? SAiRaceStrategyCorrectionByTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByTime.SAiRaceStrategyCorrectionByTime", ref SAiRaceStrategyCorrectionByTime._ScriptStructPtr);
		}

		// Token: 0x17006558 RID: 25944
		// (get) Token: 0x06029CDC RID: 171228 RVA: 0x009CCDAE File Offset: 0x009CAFAE
		// (set) Token: 0x06029CDD RID: 171229 RVA: 0x009CCDBE File Offset: 0x009CAFBE
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByTime.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByTime.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006559 RID: 25945
		// (get) Token: 0x06029CDE RID: 171230 RVA: 0x009CCDD0 File Offset: 0x009CAFD0
		// (set) Token: 0x06029CDF RID: 171231 RVA: 0x009CCE13 File Offset: 0x009CB013
		public TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByRunningTimeConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiRaceStrategyOneParamFunction> result;
				if ((result = this._CalcTargetSpeedByRunningTimeConfig) == null)
				{
					result = (this._CalcTargetSpeedByRunningTimeConfig = new TArray<SAiRaceStrategyOneParamFunction>(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByTime.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalcTargetSpeedByRunningTimeConfig.CopyAssign(value);
			}
		}

		// Token: 0x06029CE0 RID: 171232 RVA: 0x009CCE21 File Offset: 0x009CB021
		public SAiRaceStrategyCorrectionByTime()
		{
		}

		// Token: 0x06029CE1 RID: 171233 RVA: 0x009CCE29 File Offset: 0x009CB029
		public SAiRaceStrategyCorrectionByTime(bool Enable, TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByRunningTimeConfig)
		{
			this.Enable = Enable;
			this.CalcTargetSpeedByRunningTimeConfig = CalcTargetSpeedByRunningTimeConfig;
		}

		// Token: 0x06029CE2 RID: 171234 RVA: 0x009CCE3F File Offset: 0x009CB03F
		protected override IntPtr GetUStructPtr()
		{
			return SAiRaceStrategyCorrectionByTime.StaticStruct();
		}

		// Token: 0x06029CE3 RID: 171235 RVA: 0x009CCE4B File Offset: 0x009CB04B
		[NullableContext(2)]
		public SAiRaceStrategyCorrectionByTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029CE4 RID: 171236 RVA: 0x009CCE55 File Offset: 0x009CB055
		public SAiRaceStrategyCorrectionByTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029CE5 RID: 171237 RVA: 0x009CCE60 File Offset: 0x009CB060
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiRaceStrategyCorrectionByTime(Pointer, false, true);
		}

		// Token: 0x06029CE6 RID: 171238 RVA: 0x009CCE6A File Offset: 0x009CB06A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiRaceStrategyCorrectionByTime(Pointer, MemoryOwner);
		}

		// Token: 0x04015783 RID: 87939
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByTime.SAiRaceStrategyCorrectionByTime";

		// Token: 0x04015784 RID: 87940
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015785 RID: 87941
		internal static int __PropertyOffset_0;

		// Token: 0x04015786 RID: 87942
		internal static int __PropertyOffset_1;

		// Token: 0x04015787 RID: 87943
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAiRaceStrategyOneParamFunction> _CalcTargetSpeedByRunningTimeConfig;
	}
}
