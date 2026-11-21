using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087B RID: 2171
	public class ConfigRogueResThemeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032F4 RID: 13044 RVA: 0x0017D06B File Offset: 0x0017B26B
		static ConfigRogueResThemeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResThemeAll.CreateStaticDefaultValue), new Action(ConfigRogueResThemeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x0017D08C File Offset: 0x0017B28C
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

		// Token: 0x060032F6 RID: 13046 RVA: 0x0017D10B File Offset: 0x0017B30B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResThemeAll.LogPair = null;
			ConfigRogueResThemeAll.HandleId = 0;
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x0017D119 File Offset: 0x0017B319
		public static void Init()
		{
			ConfigRogueResThemeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResThemeAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTheme`");
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0017D134 File Offset: 0x0017B334
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

		// Token: 0x04003B43 RID: 15171
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B44 RID: 15172
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B45 RID: 15173
		private const string TABLE = "RogueResTheme";

		// Token: 0x04003B46 RID: 15174
		private const string COMMAND = "select BinData from `RogueResTheme`";

		// Token: 0x04003B47 RID: 15175
		private const string KEY_PREFIX = "RogueResThemeAll";

		// Token: 0x04003B48 RID: 15176
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B49 RID: 15177
		private static int HandleId;
	}
}
