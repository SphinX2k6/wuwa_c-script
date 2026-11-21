using System;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003829 RID: 14377
	public static class EObstructionCheckResultExtensions
	{
		// Token: 0x06025574 RID: 152948 RVA: 0x00A85A5C File Offset: 0x00A83C5C
		public static string ToEnumString(this EObstructionCheckResult value)
		{
			string result;
			switch (value)
			{
			case EObstructionCheckResult.None:
				result = "None";
				break;
			case EObstructionCheckResult.TraceBlock:
				result = "TraceBlock";
				break;
			case EObstructionCheckResult.CheckPlayerBlock:
				result = "CheckPlayerBlock";
				break;
			case EObstructionCheckResult.SameRoadwayVehicleBlock:
				result = "SameRoadwayVehicleBlock";
				break;
			case EObstructionCheckResult.NextRoadwayVehicleBlock:
				result = "NextRoadwayVehicleBlock";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06025575 RID: 152949 RVA: 0x00A85ABC File Offset: 0x00A83CBC
		public static EObstructionCheckResult FromString(string name)
		{
			EObstructionCheckResult result;
			if (!EObstructionCheckResultExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EObstructionCheckResult 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06025576 RID: 152950 RVA: 0x00A85AE8 File Offset: 0x00A83CE8
		public static bool TryFromString(string name, out EObstructionCheckResult value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EObstructionCheckResult.None;
				return false;
			}
			if (name == "None")
			{
				value = EObstructionCheckResult.None;
				return true;
			}
			if (name == "TraceBlock")
			{
				value = EObstructionCheckResult.TraceBlock;
				return true;
			}
			if (name == "CheckPlayerBlock")
			{
				value = EObstructionCheckResult.CheckPlayerBlock;
				return true;
			}
			if (name == "SameRoadwayVehicleBlock")
			{
				value = EObstructionCheckResult.SameRoadwayVehicleBlock;
				return true;
			}
			if (!(name == "NextRoadwayVehicleBlock"))
			{
				value = EObstructionCheckResult.None;
				return false;
			}
			value = EObstructionCheckResult.NextRoadwayVehicleBlock;
			return true;
		}

		// Token: 0x06025577 RID: 152951 RVA: 0x00A85B62 File Offset: 0x00A83D62
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"None",
				"TraceBlock",
				"CheckPlayerBlock",
				"SameRoadwayVehicleBlock",
				"NextRoadwayVehicleBlock"
			};
		}

		// Token: 0x06025578 RID: 152952 RVA: 0x00A85B92 File Offset: 0x00A83D92
		public static EObstructionCheckResult[] GetValues()
		{
			return new EObstructionCheckResult[]
			{
				EObstructionCheckResult.None,
				EObstructionCheckResult.TraceBlock,
				EObstructionCheckResult.CheckPlayerBlock,
				EObstructionCheckResult.SameRoadwayVehicleBlock,
				EObstructionCheckResult.NextRoadwayVehicleBlock
			};
		}

		// Token: 0x06025579 RID: 152953 RVA: 0x00A85BA5 File Offset: 0x00A83DA5
		public static string[] GetNames()
		{
			return new string[]
			{
				"None",
				"TraceBlock",
				"CheckPlayerBlock",
				"SameRoadwayVehicleBlock",
				"NextRoadwayVehicleBlock"
			};
		}
	}
}
