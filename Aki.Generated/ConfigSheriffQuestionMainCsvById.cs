using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096B RID: 2411
	public class ConfigSheriffQuestionMainCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003895 RID: 14485 RVA: 0x0019C748 File Offset: 0x0019A948
		static ConfigSheriffQuestionMainCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestionMainCsvById.CreateStaticDefaultValue), new Action(ConfigSheriffQuestionMainCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x0019C768 File Offset: 0x0019A968
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffQuestionMainCsvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffQuestionMainCsvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriffquestionmaincsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.推理玩法总表/*.csv*"),
				new ValueTuple<string, object>("表名", "SheriffQuestionMainCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffQuestionMainCsv` where Id=?")
			});
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x0019C7E7 File Offset: 0x0019A9E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestionMainCsvById.LogPair = null;
			ConfigSheriffQuestionMainCsvById.HandleId = 0;
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x0019C7F5 File Offset: 0x0019A9F5
		public static void Init()
		{
			ConfigSheriffQuestionMainCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestionMainCsvById.HandleId, "db_sheriffquestionmaincsv.db", "select BinData from `SheriffQuestionMainCsv` where Id=?");
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0019C810 File Offset: 0x0019AA10
		public static SheriffQuestionMainCsv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffQuestionMainCsvById.HandleId, ConfigSheriffQuestionMainCsvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestionMainCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffQuestionMainCsv?(SheriffQuestionMainCsv.GetRootAsSheriffQuestionMainCsv(configBuffer));
				}
			}
			ConfigSheriffQuestionMainCsvById.LogPair.Clear();
			ConfigSheriffQuestionMainCsvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffQuestionMainCsvById.HandleId, 1, p0Id, ConfigSheriffQuestionMainCsvById.LogPair) || ConfigCommon.Step(ConfigSheriffQuestionMainCsvById.HandleId, true, ConfigSheriffQuestionMainCsvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffQuestionMainCsvById.HandleId, ConfigSheriffQuestionMainCsvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffQuestionMainCsvById.HandleId, 0, ConfigSheriffQuestionMainCsvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffQuestionMainCsvById.HandleId, ConfigSheriffQuestionMainCsvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffQuestionMainCsv rootAsSheriffQuestionMainCsv = SheriffQuestionMainCsv.GetRootAsSheriffQuestionMainCsv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestionMainCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffQuestionMainCsvById.HandleId, ConfigSheriffQuestionMainCsvById.LogPair);
			return new SheriffQuestionMainCsv?(rootAsSheriffQuestionMainCsv);
		}

		// Token: 0x040041D3 RID: 16851
		private const string DB = "db_sheriffquestionmaincsv.db";

		// Token: 0x040041D4 RID: 16852
		private const string FILE = "k.可视化编辑/c.Csv/t.推理玩法总表/*.csv*";

		// Token: 0x040041D5 RID: 16853
		private const string TABLE = "SheriffQuestionMainCsv";

		// Token: 0x040041D6 RID: 16854
		private const string COMMAND = "select BinData from `SheriffQuestionMainCsv` where Id=?";

		// Token: 0x040041D7 RID: 16855
		private const string KEY_PREFIX = "SheriffQuestionMainCsvById";

		// Token: 0x040041D8 RID: 16856
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041D9 RID: 16857
		private static int HandleId;
	}
}
