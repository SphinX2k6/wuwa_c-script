using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CA RID: 2506
	public class ConfigSolarSchoolEndingByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AD0 RID: 15056 RVA: 0x001A926B File Offset: 0x001A746B
		static ConfigSolarSchoolEndingByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEndingByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEndingByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x001A928C File Offset: 0x001A748C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEndingByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEndingByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEnding` where ActivityId=?")
			});
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x001A930B File Offset: 0x001A750B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEndingByActivityId.LogPair = null;
			ConfigSolarSchoolEndingByActivityId.HandleId = 0;
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x001A9319 File Offset: 0x001A7519
		public static void Init()
		{
			ConfigSolarSchoolEndingByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEndingByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEnding` where ActivityId=?");
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x001A9334 File Offset: 0x001A7534
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolEnding> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEndingByActivityId.HandleId, ConfigSolarSchoolEndingByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolEnding> readOnlyList = (IReadOnlyList<SolarSchoolEnding>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolEndingByActivityId.LogPair.Clear();
			ConfigSolarSchoolEndingByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEndingByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolEndingByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingByActivityId.HandleId, ConfigSolarSchoolEndingByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolEnding> list = new List<SolarSchoolEnding>();
			while (ConfigCommon.Step(ConfigSolarSchoolEndingByActivityId.HandleId, false, ConfigSolarSchoolEndingByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEndingByActivityId.HandleId, 0, ConfigSolarSchoolEndingByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolEndingByActivityId.HandleId, ConfigSolarSchoolEndingByActivityId.LogPair);
					return null;
				}
				SolarSchoolEnding rootAsSolarSchoolEnding = SolarSchoolEnding.GetRootAsSolarSchoolEnding(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolEnding);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEndingByActivityId.HandleId, ConfigSolarSchoolEndingByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400446C RID: 17516
		private const string DB = "db_solarschool.db";

		// Token: 0x0400446D RID: 17517
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x0400446E RID: 17518
		private const string TABLE = "SolarSchoolEnding";

		// Token: 0x0400446F RID: 17519
		private const string COMMAND = "select BinData from `SolarSchoolEnding` where ActivityId=?";

		// Token: 0x04004470 RID: 17520
		private const string KEY_PREFIX = "SolarSchoolEndingByActivityId";

		// Token: 0x04004471 RID: 17521
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004472 RID: 17522
		private static int HandleId;
	}
}
