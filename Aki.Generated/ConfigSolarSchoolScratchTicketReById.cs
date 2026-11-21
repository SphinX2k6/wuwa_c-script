using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A20 RID: 2592
	public class ConfigSolarSchoolScratchTicketReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CD4 RID: 15572 RVA: 0x001B4853 File Offset: 0x001B2A53
		static ConfigSolarSchoolScratchTicketReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolScratchTicketReById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolScratchTicketReById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x001B4874 File Offset: 0x001B2A74
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolScratchTicketReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolScratchTicketReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolScratchTicketRe"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolScratchTicketRe` where Id=?")
			});
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x001B48F3 File Offset: 0x001B2AF3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolScratchTicketReById.LogPair = null;
			ConfigSolarSchoolScratchTicketReById.HandleId = 0;
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x001B4901 File Offset: 0x001B2B01
		public static void Init()
		{
			ConfigSolarSchoolScratchTicketReById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolScratchTicketReById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolScratchTicketRe` where Id=?");
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x001B491C File Offset: 0x001B2B1C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolScratchTicketRe> GetConfigList(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolScratchTicketReById.HandleId, ConfigSolarSchoolScratchTicketReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolScratchTicketReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				IReadOnlyList<SolarSchoolScratchTicketRe> readOnlyList = (IReadOnlyList<SolarSchoolScratchTicketRe>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolScratchTicketReById.LogPair.Clear();
			ConfigSolarSchoolScratchTicketReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolScratchTicketReById.HandleId, 1, p0Id, ConfigSolarSchoolScratchTicketReById.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolScratchTicketReById.HandleId, ConfigSolarSchoolScratchTicketReById.LogPair);
				return null;
			}
			List<SolarSchoolScratchTicketRe> list = new List<SolarSchoolScratchTicketRe>();
			while (ConfigCommon.Step(ConfigSolarSchoolScratchTicketReById.HandleId, false, ConfigSolarSchoolScratchTicketReById.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolScratchTicketReById.HandleId, 0, ConfigSolarSchoolScratchTicketReById.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolScratchTicketReById.HandleId, ConfigSolarSchoolScratchTicketReById.LogPair);
					return null;
				}
				SolarSchoolScratchTicketRe rootAsSolarSchoolScratchTicketRe = SolarSchoolScratchTicketRe.GetRootAsSolarSchoolScratchTicketRe(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolScratchTicketRe);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolScratchTicketReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolScratchTicketReById.HandleId, ConfigSolarSchoolScratchTicketReById.LogPair);
			return list;
		}

		// Token: 0x040046C6 RID: 18118
		private const string DB = "db_solarschool.db";

		// Token: 0x040046C7 RID: 18119
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040046C8 RID: 18120
		private const string TABLE = "SolarSchoolScratchTicketRe";

		// Token: 0x040046C9 RID: 18121
		private const string COMMAND = "select BinData from `SolarSchoolScratchTicketRe` where Id=?";

		// Token: 0x040046CA RID: 18122
		private const string KEY_PREFIX = "SolarSchoolScratchTicketReById";

		// Token: 0x040046CB RID: 18123
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046CC RID: 18124
		private static int HandleId;
	}
}
