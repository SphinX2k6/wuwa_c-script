using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085F RID: 2143
	public class ConfigRogueResThemeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600324C RID: 12876 RVA: 0x00175D83 File Offset: 0x00173F83
		static ConfigRogueResThemeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResThemeAll.CreateStaticDefaultValue), new Action(ConfigRogueResThemeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x00175DA4 File Offset: 0x00173FA4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResThemeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResThemeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTheme"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTheme`")
			});
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x00175E23 File Offset: 0x00174023
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResThemeAll.LogPair = null;
			ConfigRogueResThemeAll.HandleId = 0;
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x00175E31 File Offset: 0x00174031
		public static void Init()
		{
			ConfigRogueResThemeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResThemeAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTheme`");
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x00175E4C File Offset: 0x0017404C
		[NullableContext(2)]
		public static IReadOnlyList<RogueResTheme> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResThemeAll.HandleId, ConfigRogueResThemeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResTheme> readOnlyList = (IReadOnlyList<RogueResTheme>)ConfigCommon.GetConfig("RogueResThemeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResTheme> list = new List<RogueResTheme>();
			while (ConfigCommon.Step(ConfigRogueResThemeAll.HandleId, false, ConfigRogueResThemeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResThemeAll.HandleId, 0, ConfigRogueResThemeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResThemeAll.HandleId, ConfigRogueResThemeAll.LogPair);
					return null;
				}
				RogueResTheme rootAsRogueResTheme = RogueResTheme.GetRootAsRogueResTheme(new ByteBuffer(item2));
				list.Add(rootAsRogueResTheme);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResThemeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResThemeAll.HandleId, ConfigRogueResThemeAll.LogPair);
			return list;
		}

		// Token: 0x04003A7F RID: 14975
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A80 RID: 14976
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A81 RID: 14977
		private const string TABLE = "RogueResTheme";

		// Token: 0x04003A82 RID: 14978
		private const string COMMAND = "select BinData from `RogueResTheme`";

		// Token: 0x04003A83 RID: 14979
		private const string KEY_PREFIX = "RogueResThemeAll";

		// Token: 0x04003A84 RID: 14980
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A85 RID: 14981
		private static int HandleId;
	}
}
