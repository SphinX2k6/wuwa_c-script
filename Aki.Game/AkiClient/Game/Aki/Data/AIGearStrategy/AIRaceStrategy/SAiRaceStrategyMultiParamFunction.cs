using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x0200324D RID: 12877
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyMultiParamFunction.SAiRaceStrategyMultiParamFunction")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct SAiRaceStrategyMultiParamFunction : IEqualityOperators<SAiRaceStrategyMultiParamFunction, SAiRaceStrategyMultiParamFunction, bool>, IEquatable<SAiRaceStrategyMultiParamFunction>, IUnrealScriptStruct
	{
		// Token: 0x060202D2 RID: 131794 RVA: 0x0093F091 File Offset: 0x0093D291
		public SAiRaceStrategyMultiParamFunction(TEnumAsByte<EAiRaceStrategyMultiParamFuncType> FunctionType)
		{
			this.FunctionType = FunctionType;
		}

		// Token: 0x060202D3 RID: 131795 RVA: 0x0093F09A File Offset: 0x0093D29A
		public static bool operator ==(SAiRaceStrategyMultiParamFunction left, SAiRaceStrategyMultiParamFunction right)
		{
			return left.FunctionType == right.FunctionType;
		}

		// Token: 0x060202D4 RID: 131796 RVA: 0x0093F0AD File Offset: 0x0093D2AD
		public static bool operator !=(SAiRaceStrategyMultiParamFunction left, SAiRaceStrategyMultiParamFunction right)
		{
			return !(left == right);
		}

		// Token: 0x060202D5 RID: 131797 RVA: 0x0093F0B9 File Offset: 0x0093D2B9
		public bool Equals(SAiRaceStrategyMultiParamFunction other)
		{
			return this == other;
		}

		// Token: 0x060202D6 RID: 131798 RVA: 0x0093F0C8 File Offset: 0x0093D2C8
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

		// Token: 0x060202D7 RID: 131799 RVA: 0x0093F0ED File Offset: 0x0093D2ED
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EAiRaceStrategyMultiParamFuncType>>(this.FunctionType);
		}

		// Token: 0x060202D8 RID: 131800 RVA: 0x0093F0FA File Offset: 0x0093D2FA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyMultiParamFunction._ScriptStructPtr != 0) ? SAiRaceStrategyMultiParamFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyMultiParamFunction.SAiRaceStrategyMultiParamFunction", ref SAiRaceStrategyMultiParamFunction._ScriptStructPtr);
		}

		// Token: 0x04011519 RID: 70937
		[FieldOffset(0)]
		public TEnumAsByte<EAiRaceStrategyMultiParamFuncType> FunctionType;

		// Token: 0x0401151A RID: 70938
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyMultiParamFunction.SAiRaceStrategyMultiParamFunction";

		// Token: 0x0401151B RID: 70939
		private static IntPtr _ScriptStructPtr;
	}
}
