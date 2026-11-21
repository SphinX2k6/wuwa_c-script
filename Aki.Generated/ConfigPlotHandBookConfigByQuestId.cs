using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000764 RID: 1892
	public class ConfigPlotHandBookConfigByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C69 RID: 11369 RVA: 0x00157F43 File Offset: 0x00156143
		static ConfigPlotHandBookConfigByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotHandBookConfigByQuestId.CreateStaticDefaultValue), new Action(ConfigPlotHandBookConfigByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00157F64 File Offset: 0x00156164
		public static void CreateStaticDefaultValue()
		{
			ConfigPlotHandBookConfigByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlotHandBookConfigByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_plothandbook.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/PlotHandBook/剧情图鉴_Json_PlotHandBook.csv"),
				new ValueTuple<string, object>("表名", "PlotHandBookConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PlotHandBookConfig` where QuestId=?")
			});
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x00157FE3 File Offset: 0x001561E3
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotHandBookConfigByQuestId.LogPair = null;
			ConfigPlotHandBookConfigByQuestId.HandleId = 0;
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00157FF1 File Offset: 0x001561F1
		public static void Init()
		{
			ConfigPlotHandBookConfigByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigPlotHandBookConfigByQuestId.HandleId, "db_plothandbook.db", "select BinData from `PlotHandBookConfig` where QuestId=?");
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0015800C File Offset: 0x0015620C
		public static PlotHandBookConfig? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlotHandBookConfigByQuestId.HandleId, ConfigPlotHandBookConfigByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlotHandBookConfigByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlotHandBookConfig?(PlotHandBookConfig.GetRootAsPlotHandBookConfig(configBuffer));
				}
			}
			ConfigPlotHandBookConfigByQuestId.LogPair.Clear();
			ConfigPlotHandBookConfigByQuestId.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigPlotHandBookConfigByQuestId.HandleId, 1, p0QuestId, ConfigPlotHandBookConfigByQuestId.LogPair) || ConfigCommon.Step(ConfigPlotHandBookConfigByQuestId.HandleId, true, ConfigPlotHandBookConfigByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlotHandBookConfigByQuestId.HandleId, ConfigPlotHandBookConfigByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlotHandBookConfigByQuestId.HandleId, 0, ConfigPlotHandBookConfigByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlotHandBookConfigByQuestId.HandleId, ConfigPlotHandBookConfigByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlotHandBookConfig rootAsPlotHandBookConfig = PlotHandBookConfig.GetRootAsPlotHandBookConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlotHandBookConfigByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlotHandBookConfigByQuestId.HandleId, ConfigPlotHandBookConfigByQuestId.LogPair);
			return new PlotHandBookConfig?(rootAsPlotHandBookConfig);
		}

		// Token: 0x040033A2 RID: 13218
		private const string DB = "db_plothandbook.db";

		// Token: 0x040033A3 RID: 13219
		private const string FILE = "UniverseEditor/PlotHandBook/剧情图鉴_Json_PlotHandBook.csv";

		// Token: 0x040033A4 RID: 13220
		private const string TABLE = "PlotHandBookConfig";

		// Token: 0x040033A5 RID: 13221
		private const string COMMAND = "select BinData from `PlotHandBookConfig` where QuestId=?";

		// Token: 0x040033A6 RID: 13222
		private const string KEY_PREFIX = "PlotHandBookConfigByQuestId";

		// Token: 0x040033A7 RID: 13223
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033A8 RID: 13224
		private static int HandleId;
	}
}
