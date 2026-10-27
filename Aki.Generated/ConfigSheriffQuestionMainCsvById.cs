using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000920 RID: 2336
	public class ConfigSheriffQuestionMainCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036D3 RID: 14035 RVA: 0x0018F528 File Offset: 0x0018D728
		static ConfigSheriffQuestionMainCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestionMainCsvById.CreateStaticDefaultValue), new Action(ConfigSheriffQuestionMainCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x0018F548 File Offset: 0x0018D748
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

		// Token: 0x060036D5 RID: 14037 RVA: 0x0018F5C7 File Offset: 0x0018D7C7
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestionMainCsvById.LogPair = null;
			ConfigSheriffQuestionMainCsvById.HandleId = 0;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x0018F5D5 File Offset: 0x0018D7D5
		public static void Init()
		{
			ConfigSheriffQuestionMainCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestionMainCsvById.HandleId, "db_sheriffquestionmaincsv.db", "select BinData from `SheriffQuestionMainCsv` where Id=?");
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x0018F5F0 File Offset: 0x0018D7F0
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

		// Token: 0x04003FC6 RID: 16326
		private const string DB = "db_sheriffquestionmaincsv.db";

		// Token: 0x04003FC7 RID: 16327
		private const string FILE = "k.可视化编辑/c.Csv/t.推理玩法总表/*.csv*";

		// Token: 0x04003FC8 RID: 16328
		private const string TABLE = "SheriffQuestionMainCsv";

		// Token: 0x04003FC9 RID: 16329
		private const string COMMAND = "select BinData from `SheriffQuestionMainCsv` where Id=?";

		// Token: 0x04003FCA RID: 16330
		private const string KEY_PREFIX = "SheriffQuestionMainCsvById";

		// Token: 0x04003FCB RID: 16331
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FCC RID: 16332
		private static int HandleId;
	}
}
