using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091F RID: 2335
	public class ConfigSheriffQuestionCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036CD RID: 14029 RVA: 0x0018F2DF File Offset: 0x0018D4DF
		static ConfigSheriffQuestionCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestionCsvById.CreateStaticDefaultValue), new Action(ConfigSheriffQuestionCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x0018F300 File Offset: 0x0018D500
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffQuestionCsvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffQuestionCsvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriffquestioncsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.推理玩法问题/*.csv*"),
				new ValueTuple<string, object>("表名", "SheriffQuestionCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffQuestionCsv` where Id=?")
			});
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0018F37F File Offset: 0x0018D57F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestionCsvById.LogPair = null;
			ConfigSheriffQuestionCsvById.HandleId = 0;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x0018F38D File Offset: 0x0018D58D
		public static void Init()
		{
			ConfigSheriffQuestionCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestionCsvById.HandleId, "db_sheriffquestioncsv.db", "select BinData from `SheriffQuestionCsv` where Id=?");
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0018F3A8 File Offset: 0x0018D5A8
		public static SheriffQuestionCsv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffQuestionCsvById.HandleId, ConfigSheriffQuestionCsvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestionCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffQuestionCsv?(SheriffQuestionCsv.GetRootAsSheriffQuestionCsv(configBuffer));
				}
			}
			ConfigSheriffQuestionCsvById.LogPair.Clear();
			ConfigSheriffQuestionCsvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffQuestionCsvById.HandleId, 1, p0Id, ConfigSheriffQuestionCsvById.LogPair) || ConfigCommon.Step(ConfigSheriffQuestionCsvById.HandleId, true, ConfigSheriffQuestionCsvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffQuestionCsvById.HandleId, ConfigSheriffQuestionCsvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffQuestionCsvById.HandleId, 0, ConfigSheriffQuestionCsvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffQuestionCsvById.HandleId, ConfigSheriffQuestionCsvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffQuestionCsv rootAsSheriffQuestionCsv = SheriffQuestionCsv.GetRootAsSheriffQuestionCsv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestionCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffQuestionCsvById.HandleId, ConfigSheriffQuestionCsvById.LogPair);
			return new SheriffQuestionCsv?(rootAsSheriffQuestionCsv);
		}

		// Token: 0x04003FBF RID: 16319
		private const string DB = "db_sheriffquestioncsv.db";

		// Token: 0x04003FC0 RID: 16320
		private const string FILE = "k.可视化编辑/c.Csv/t.推理玩法问题/*.csv*";

		// Token: 0x04003FC1 RID: 16321
		private const string TABLE = "SheriffQuestionCsv";

		// Token: 0x04003FC2 RID: 16322
		private const string COMMAND = "select BinData from `SheriffQuestionCsv` where Id=?";

		// Token: 0x04003FC3 RID: 16323
		private const string KEY_PREFIX = "SheriffQuestionCsvById";

		// Token: 0x04003FC4 RID: 16324
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FC5 RID: 16325
		private static int HandleId;
	}
}
