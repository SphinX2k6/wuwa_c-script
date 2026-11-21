using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x0200324C RID: 12876
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByTime.SAiRaceStrategyCorrectionByTime")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SAiRaceStrategyCorrectionByTime : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060202C7 RID: 131783 RVA: 0x0093EFBD File Offset: 0x0093D1BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyCorrectionByTime._ScriptStructPtr != 0) ? SAiRaceStrategyCorrectionByTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByTime.SAiRaceStrategyCorrectionByTime", ref SAiRaceStrategyCorrectionByTime._ScriptStructPtr);
		}

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x060202C8 RID: 131784 RVA: 0x0093EFE1 File Offset: 0x0093D1E1
		// (set) Token: 0x060202C9 RID: 131785 RVA: 0x0093EFF1 File Offset: 0x0093D1F1
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByTime.__PropertyOffset_Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByTime.__PropertyOffset_Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x060202CA RID: 131786 RVA: 0x0093F004 File Offset: 0x0093D204
		// (set) Token: 0x060202CB RID: 131787 RVA: 0x0093F047 File Offset: 0x0093D247
		public TArray<SAiRaceStrategyOneParamFunction> CalcTargetSpeedByRunningTimeConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiRaceStrategyOneParamFunction> result;
				if ((result = this._CalcTargetSpeedByRunningTimeConfig) == null)
				{
					result = (this._CalcTargetSpeedByRunningTimeConfig = new TArray<SAiRaceStrategyOneParamFunction>(base.NativePtr + (IntPtr)SAiRaceStrategyCorrectionByTime.__PropertyOffset_CalcTargetSpeedByRunningTimeConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalcTargetSpeedByRunningTimeConfig.CopyAssign(value);
			}
		}

		// Token: 0x060202CC RID: 131788 RVA: 0x0093F055 File Offset: 0x0093D255
		public SAiRaceStrategyCorrectionByTime()
		{
		}

		// Token: 0x060202CD RID: 131789 RVA: 0x0093F05D File Offset: 0x0093D25D
		protected override IntPtr GetUStructPtr()
		{
			return SAiRaceStrategyCorrectionByTime.StaticStruct();
		}

		// Token: 0x060202CE RID: 131790 RVA: 0x0093F069 File Offset: 0x0093D269
		[NullableContext(2)]
		public SAiRaceStrategyCorrectionByTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060202CF RID: 131791 RVA: 0x0093F073 File Offset: 0x0093D273
		public SAiRaceStrategyCorrectionByTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060202D0 RID: 131792 RVA: 0x0093F07E File Offset: 0x0093D27E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiRaceStrategyCorrectionByTime(Pointer, false, true);
		}

		// Token: 0x060202D1 RID: 131793 RVA: 0x0093F088 File Offset: 0x0093D288
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiRaceStrategyCorrectionByTime(Pointer, MemoryOwner);
		}

		// Token: 0x04011514 RID: 70932
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyCorrectionByTime.SAiRaceStrategyCorrectionByTime";

		// Token: 0x04011515 RID: 70933
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011516 RID: 70934
		internal static int __PropertyOffset_Enable;

		// Token: 0x04011517 RID: 70935
		internal static int __PropertyOffset_CalcTargetSpeedByRunningTimeConfig;

		// Token: 0x04011518 RID: 70936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAiRaceStrategyOneParamFunction> _CalcTargetSpeedByRunningTimeConfig;
	}
}
