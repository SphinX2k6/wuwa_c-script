using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031B RID: 795
	public class ConfigFloatingSubtitle2DAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x000C695C File Offset: 0x000C4B5C
		static ConfigFloatingSubtitle2DAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloatingSubtitle2DAll.CreateStaticDefaultValue), new Action(ConfigFloatingSubtitle2DAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000C697C File Offset: 0x000C4B7C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloatingSubtitle2DAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloatingSubtitle2DAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_floatingsubtitle.db"),
				new ValueTuple<string, object>("文件", "p.飘浮字幕.xlsx"),
				new ValueTuple<string, object>("表名", "FloatingSubtitle2D"),
				new ValueTuple<string, object>("语句", "select BinData from `FloatingSubtitle2D`")
			});
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x000C69FB File Offset: 0x000C4BFB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloatingSubtitle2DAll.LogPair = null;
			ConfigFloatingSubtitle2DAll.HandleId = 0;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000C6A09 File Offset: 0x000C4C09
		public static void Init()
		{
			ConfigFloatingSubtitle2DAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloatingSubtitle2DAll.HandleId, "db_floatingsubtitle.db", "select BinData from `FloatingSubtitle2D`");
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000C6A24 File Offset: 0x000C4C24
		[NullableContext(2)]
		public static IReadOnlyList<FloatingSubtitle2D> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloatingSubtitle2DAll.HandleId, ConfigFloatingSubtitle2DAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloatingSubtitle2D> readOnlyList = (IReadOnlyList<FloatingSubtitle2D>)ConfigCommon.GetConfig("FloatingSubtitle2DAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloatingSubtitle2D> list = new List<FloatingSubtitle2D>();
			while (ConfigCommon.Step(ConfigFloatingSubtitle2DAll.HandleId, false, ConfigFloatingSubtitle2DAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloatingSubtitle2DAll.HandleId, 0, ConfigFloatingSubtitle2DAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloatingSubtitle2DAll.HandleId, ConfigFloatingSubtitle2DAll.LogPair);
					return null;
				}
				FloatingSubtitle2D rootAsFloatingSubtitle2D = FloatingSubtitle2D.GetRootAsFloatingSubtitle2D(new ByteBuffer(item2));
				list.Add(rootAsFloatingSubtitle2D);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloatingSubtitle2DAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloatingSubtitle2DAll.HandleId, ConfigFloatingSubtitle2DAll.LogPair);
			return list;
		}

		// Token: 0x040015A1 RID: 5537
		private const string DB = "db_floatingsubtitle.db";

		// Token: 0x040015A2 RID: 5538
		private const string FILE = "p.飘浮字幕.xlsx";

		// Token: 0x040015A3 RID: 5539
		private const string TABLE = "FloatingSubtitle2D";

		// Token: 0x040015A4 RID: 5540
		private const string COMMAND = "select BinData from `FloatingSubtitle2D`";

		// Token: 0x040015A5 RID: 5541
		private const string KEY_PREFIX = "FloatingSubtitle2DAll";

		// Token: 0x040015A6 RID: 5542
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015A7 RID: 5543
		private static int HandleId;
	}
}
