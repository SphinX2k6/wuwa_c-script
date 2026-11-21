using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096A RID: 2410
	public class ConfigSheriffQuestionCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600388F RID: 14479 RVA: 0x0019C4FF File Offset: 0x0019A6FF
		static ConfigSheriffQuestionCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestionCsvById.CreateStaticDefaultValue), new Action(ConfigSheriffQuestionCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x0019C520 File Offset: 0x0019A720
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

		// Token: 0x06003891 RID: 14481 RVA: 0x0019C59F File Offset: 0x0019A79F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestionCsvById.LogPair = null;
			ConfigSheriffQuestionCsvById.HandleId = 0;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x0019C5AD File Offset: 0x0019A7AD
		public static void Init()
		{
			ConfigSheriffQuestionCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestionCsvById.HandleId, "db_sheriffquestioncsv.db", "select BinData from `SheriffQuestionCsv` where Id=?");
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0019C5C8 File Offset: 0x0019A7C8
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

		// Token: 0x040041CC RID: 16844
		private const string DB = "db_sheriffquestioncsv.db";

		// Token: 0x040041CD RID: 16845
		private const string FILE = "k.可视化编辑/c.Csv/t.推理玩法问题/*.csv*";

		// Token: 0x040041CE RID: 16846
		private const string TABLE = "SheriffQuestionCsv";

		// Token: 0x040041CF RID: 16847
		private const string COMMAND = "select BinData from `SheriffQuestionCsv` where Id=?";

		// Token: 0x040041D0 RID: 16848
		private const string KEY_PREFIX = "SheriffQuestionCsvById";

		// Token: 0x040041D1 RID: 16849
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041D2 RID: 16850
		private static int HandleId;
	}
}
