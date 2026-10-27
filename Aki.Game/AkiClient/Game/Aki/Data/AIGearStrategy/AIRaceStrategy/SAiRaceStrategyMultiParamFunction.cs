using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003FC8 RID: 16328
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyMultiParamFunction.SAiRaceStrategyMultiParamFunction")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct SAiRaceStrategyMultiParamFunction : IEqualityOperators<SAiRaceStrategyMultiParamFunction, SAiRaceStrategyMultiParamFunction, bool>, IEquatable<SAiRaceStrategyMultiParamFunction>, IUnrealScriptStruct
	{
		// Token: 0x06029CE7 RID: 171239 RVA: 0x009CCE73 File Offset: 0x009CB073
		public SAiRaceStrategyMultiParamFunction(TEnumAsByte<EAiRaceStrategyMultiParamFuncType> FunctionType)
		{
			this.FunctionType = FunctionType;
		}

		// Token: 0x06029CE8 RID: 171240 RVA: 0x009CCE7C File Offset: 0x009CB07C
		public static bool operator ==(SAiRaceStrategyMultiParamFunction left, SAiRaceStrategyMultiParamFunction right)
		{
			return left.FunctionType == right.FunctionType;
		}

		// Token: 0x06029CE9 RID: 171241 RVA: 0x009CCE8F File Offset: 0x009CB08F
		public static bool operator !=(SAiRaceStrategyMultiParamFunction left, SAiRaceStrategyMultiParamFunction right)
		{
			return !(left == right);
		}

		// Token: 0x06029CEA RID: 171242 RVA: 0x009CCE9B File Offset: 0x009CB09B
		public bool Equals(SAiRaceStrategyMultiParamFunction other)
		{
			return this == other;
		}

		// Token: 0x06029CEB RID: 171243 RVA: 0x009CCEAC File Offset: 0x009CB0AC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SAiRaceStrategyMultiParamFunction)
			{
				SAiRaceStrategyMultiParamFunction other = (SAiRaceStrategyMultiParamFunction)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029CEC RID: 171244 RVA: 0x009CCED1 File Offset: 0x009CB0D1
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EAiRaceStrategyMultiParamFuncType>>(this.FunctionType);
		}

		// Token: 0x06029CED RID: 171245 RVA: 0x009CCEDE File Offset: 0x009CB0DE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyMultiParamFunction._ScriptStructPtr != 0) ? SAiRaceStrategyMultiParamFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyMultiParamFunction.SAiRaceStrategyMultiParamFunction", ref SAiRaceStrategyMultiParamFunction._ScriptStructPtr);
		}

		// Token: 0x04015788 RID: 87944
		[FieldOffset(0)]
		public TEnumAsByte<EAiRaceStrategyMultiParamFuncType> FunctionType;

		// Token: 0x04015789 RID: 87945
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyMultiParamFunction.SAiRaceStrategyMultiParamFunction";

		// Token: 0x0401578A RID: 87946
		private static IntPtr _ScriptStructPtr;
	}
}
