using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074C RID: 1868
	public class ConfigPlotHandBookConfigByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BD9 RID: 11225 RVA: 0x001514C7 File Offset: 0x0014F6C7
		static ConfigPlotHandBookConfigByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotHandBookConfigByQuestId.CreateStaticDefaultValue), new Action(ConfigPlotHandBookConfigByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x001514E8 File Offset: 0x0014F6E8
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

		// Token: 0x06002BDB RID: 11227 RVA: 0x00151567 File Offset: 0x0014F767
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotHandBookConfigByQuestId.LogPair = null;
			ConfigPlotHandBookConfigByQuestId.HandleId = 0;
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00151575 File Offset: 0x0014F775
		public static void Init()
		{
			ConfigPlotHandBookConfigByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigPlotHandBookConfigByQuestId.HandleId, "db_plothandbook.db", "select BinData from `PlotHandBookConfig` where QuestId=?");
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00151590 File Offset: 0x0014F790
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

		// Token: 0x040032FA RID: 13050
		private const string DB = "db_plothandbook.db";

		// Token: 0x040032FB RID: 13051
		private const string FILE = "UniverseEditor/PlotHandBook/剧情图鉴_Json_PlotHandBook.csv";

		// Token: 0x040032FC RID: 13052
		private const string TABLE = "PlotHandBookConfig";

		// Token: 0x040032FD RID: 13053
		private const string COMMAND = "select BinData from `PlotHandBookConfig` where QuestId=?";

		// Token: 0x040032FE RID: 13054
		private const string KEY_PREFIX = "PlotHandBookConfigByQuestId";

		// Token: 0x040032FF RID: 13055
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003300 RID: 13056
		private static int HandleId;
	}
}
