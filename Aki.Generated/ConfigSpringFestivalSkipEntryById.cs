using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000984 RID: 2436
	public class ConfigSpringFestivalSkipEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600392C RID: 14636 RVA: 0x0019CDB3 File Offset: 0x0019AFB3
		static ConfigSpringFestivalSkipEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSkipEntryById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSkipEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0019CDD4 File Offset: 0x0019AFD4
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalSkipEntryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalSkipEntryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalSkipEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalSkipEntry` where Id=?")
			});
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x0019CE53 File Offset: 0x0019B053
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSkipEntryById.LogPair = null;
			ConfigSpringFestivalSkipEntryById.HandleId = 0;
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x0019CE61 File Offset: 0x0019B061
		public static void Init()
		{
			ConfigSpringFestivalSkipEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSkipEntryById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSkipEntry` where Id=?");
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x0019CE7C File Offset: 0x0019B07C
		public static SpringFestivalSkipEntry? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalSkipEntryById.HandleId, ConfigSpringFestivalSkipEntryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSkipEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalSkipEntry?(SpringFestivalSkipEntry.GetRootAsSpringFestivalSkipEntry(configBuffer));
				}
			}
			ConfigSpringFestivalSkipEntryById.LogPair.Clear();
			ConfigSpringFestivalSkipEntryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalSkipEntryById.HandleId, 1, p0Id, ConfigSpringFestivalSkipEntryById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalSkipEntryById.HandleId, true, ConfigSpringFestivalSkipEntryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalSkipEntryById.HandleId, ConfigSpringFestivalSkipEntryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalSkipEntryById.HandleId, 0, ConfigSpringFestivalSkipEntryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalSkipEntryById.HandleId, ConfigSpringFestivalSkipEntryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalSkipEntry rootAsSpringFestivalSkipEntry = SpringFestivalSkipEntry.GetRootAsSpringFestivalSkipEntry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSkipEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalSkipEntryById.HandleId, ConfigSpringFestivalSkipEntryById.LogPair);
			return new SpringFestivalSkipEntry?(rootAsSpringFestivalSkipEntry);
		}

		// Token: 0x04004282 RID: 17026
		private const string DB = "db_spring26.db";

		// Token: 0x04004283 RID: 17027
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004284 RID: 17028
		private const string TABLE = "SpringFestivalSkipEntry";

		// Token: 0x04004285 RID: 17029
		private const string COMMAND = "select BinData from `SpringFestivalSkipEntry` where Id=?";

		// Token: 0x04004286 RID: 17030
		private const string KEY_PREFIX = "SpringFestivalSkipEntryById";

		// Token: 0x04004287 RID: 17031
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004288 RID: 17032
		private static int HandleId;
	}
}
