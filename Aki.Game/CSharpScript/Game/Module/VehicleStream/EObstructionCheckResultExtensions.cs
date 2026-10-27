using System;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048B2 RID: 18610
	public static class EObstructionCheckResultExtensions
	{
		// Token: 0x06030A48 RID: 199240 RVA: 0x00B4AC54 File Offset: 0x00B48E54
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

		// Token: 0x06030A49 RID: 199241 RVA: 0x00B4ACB4 File Offset: 0x00B48EB4
		public static EObstructionCheckResult FromString(string name)
		{
			EObstructionCheckResult result;
			if (!EObstructionCheckResultExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EObstructionCheckResult 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06030A4A RID: 199242 RVA: 0x00B4ACE0 File Offset: 0x00B48EE0
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

		// Token: 0x06030A4B RID: 199243 RVA: 0x00B4AD5A File Offset: 0x00B48F5A
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

		// Token: 0x06030A4C RID: 199244 RVA: 0x00B4AD8A File Offset: 0x00B48F8A
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

		// Token: 0x06030A4D RID: 199245 RVA: 0x00B4AD9D File Offset: 0x00B48F9D
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
