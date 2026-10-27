using System;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048B4 RID: 18612
	public static class EMoveCheckResultExtensions
	{
		// Token: 0x06030A51 RID: 199249 RVA: 0x00B4AE0C File Offset: 0x00B4900C
		public static string ToEnumString(this EMoveCheckResult value)
		{
			string result;
			switch (value)
			{
			case EMoveCheckResult.None:
				result = "None";
				break;
			case EMoveCheckResult.TraceBlock:
				result = "TraceBlock";
				break;
			case EMoveCheckResult.CheckPlayerBlock:
				result = "CheckPlayerBlock";
				break;
			case EMoveCheckResult.SameRoadwayVehicleBlock:
				result = "SameRoadwayVehicleBlock";
				break;
			case EMoveCheckResult.NextRoadwayVehicleBlock:
				result = "NextRoadwayVehicleBlock";
				break;
			case EMoveCheckResult.Intersection:
				result = "Intersection";
				break;
			case EMoveCheckResult.CrossPlayer:
				result = "CrossPlayer";
				break;
			case EMoveCheckResult.CrossSameRoadwayVehicle:
				result = "CrossSameRoadwayVehicle";
				break;
			case EMoveCheckResult.CrossNextRoadwayVehicle:
				result = "CrossNextRoadwayVehicle";
				break;
			case EMoveCheckResult.HeadOverRoadOnWaitIntersection:
				result = "HeadOverRoadOnWaitIntersection";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06030A52 RID: 199250 RVA: 0x00B4AEA8 File Offset: 0x00B490A8
		public static EMoveCheckResult FromString(string name)
		{
			EMoveCheckResult result;
			if (!EMoveCheckResultExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveCheckResult 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06030A53 RID: 199251 RVA: 0x00B4AED4 File Offset: 0x00B490D4
		public static bool TryFromString(string name, out EMoveCheckResult value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMoveCheckResult.None;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length <= 16)
				{
					if (length != 4)
					{
						switch (length)
						{
						case 10:
							if (name == "TraceBlock")
							{
								value = EMoveCheckResult.TraceBlock;
								return true;
							}
							break;
						case 11:
							if (name == "CrossPlayer")
							{
								value = EMoveCheckResult.CrossPlayer;
								return true;
							}
							break;
						case 12:
							if (name == "Intersection")
							{
								value = EMoveCheckResult.Intersection;
								return true;
							}
							break;
						case 16:
							if (name == "CheckPlayerBlock")
							{
								value = EMoveCheckResult.CheckPlayerBlock;
								return true;
							}
							break;
						}
					}
					else if (name == "None")
					{
						value = EMoveCheckResult.None;
						return true;
					}
				}
				else if (length != 23)
				{
					if (length == 30)
					{
						if (name == "HeadOverRoadOnWaitIntersection")
						{
							value = EMoveCheckResult.HeadOverRoadOnWaitIntersection;
							return true;
						}
					}
				}
				else
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'N')
						{
							if (c == 'S')
							{
								if (name == "SameRoadwayVehicleBlock")
								{
									value = EMoveCheckResult.SameRoadwayVehicleBlock;
									return true;
								}
							}
						}
						else if (name == "NextRoadwayVehicleBlock")
						{
							value = EMoveCheckResult.NextRoadwayVehicleBlock;
							return true;
						}
					}
					else
					{
						if (name == "CrossSameRoadwayVehicle")
						{
							value = EMoveCheckResult.CrossSameRoadwayVehicle;
							return true;
						}
						if (name == "CrossNextRoadwayVehicle")
						{
							value = EMoveCheckResult.CrossNextRoadwayVehicle;
							return true;
						}
					}
				}
			}
			value = EMoveCheckResult.None;
			return false;
		}

		// Token: 0x06030A54 RID: 199252 RVA: 0x00B4B03C File Offset: 0x00B4923C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"None",
				"TraceBlock",
				"CheckPlayerBlock",
				"SameRoadwayVehicleBlock",
				"NextRoadwayVehicleBlock",
				"Intersection",
				"CrossPlayer",
				"CrossSameRoadwayVehicle",
				"CrossNextRoadwayVehicle",
				"HeadOverRoadOnWaitIntersection"
			};
		}

		// Token: 0x06030A55 RID: 199253 RVA: 0x00B4B0A1 File Offset: 0x00B492A1
		public static EMoveCheckResult[] GetValues()
		{
			return new EMoveCheckResult[]
			{
				EMoveCheckResult.None,
				EMoveCheckResult.TraceBlock,
				EMoveCheckResult.CheckPlayerBlock,
				EMoveCheckResult.SameRoadwayVehicleBlock,
				EMoveCheckResult.NextRoadwayVehicleBlock,
				EMoveCheckResult.Intersection,
				EMoveCheckResult.CrossPlayer,
				EMoveCheckResult.CrossSameRoadwayVehicle,
				EMoveCheckResult.CrossNextRoadwayVehicle,
				EMoveCheckResult.HeadOverRoadOnWaitIntersection
			};
		}

		// Token: 0x06030A56 RID: 199254 RVA: 0x00B4B0B8 File Offset: 0x00B492B8
		public static string[] GetNames()
		{
			return new string[]
			{
				"None",
				"TraceBlock",
				"CheckPlayerBlock",
				"SameRoadwayVehicleBlock",
				"NextRoadwayVehicleBlock",
				"Intersection",
				"CrossPlayer",
				"CrossSameRoadwayVehicle",
				"CrossNextRoadwayVehicle",
				"HeadOverRoadOnWaitIntersection"
			};
		}
	}
}
