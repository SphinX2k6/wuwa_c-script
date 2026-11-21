using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DE RID: 478
	public class ConfigDangoBrawlItemQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B37 RID: 2871 RVA: 0x0009C8D0 File Offset: 0x0009AAD0
		static ConfigDangoBrawlItemQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemQualityById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0009C8F0 File Offset: 0x0009AAF0
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemQuality` where Id=?")
			});
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0009C96F File Offset: 0x0009AB6F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemQualityById.LogPair = null;
			ConfigDangoBrawlItemQualityById.HandleId = 0;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0009C97D File Offset: 0x0009AB7D
		public static void Init()
		{
			ConfigDangoBrawlItemQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemQualityById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemQuality` where Id=?");
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0009C998 File Offset: 0x0009AB98
		public static DangoBrawlItemQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemQualityById.HandleId, ConfigDangoBrawlItemQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlItemQuality?(DangoBrawlItemQuality.GetRootAsDangoBrawlItemQuality(configBuffer));
				}
			}
			ConfigDangoBrawlItemQualityById.LogPair.Clear();
			ConfigDangoBrawlItemQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlItemQualityById.HandleId, 1, p0Id, ConfigDangoBrawlItemQualityById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlItemQualityById.HandleId, true, ConfigDangoBrawlItemQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemQualityById.HandleId, ConfigDangoBrawlItemQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemQualityById.HandleId, 0, ConfigDangoBrawlItemQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemQualityById.HandleId, ConfigDangoBrawlItemQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlItemQuality rootAsDangoBrawlItemQuality = DangoBrawlItemQuality.GetRootAsDangoBrawlItemQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemQualityById.HandleId, ConfigDangoBrawlItemQualityById.LogPair);
			return new DangoBrawlItemQuality?(rootAsDangoBrawlItemQuality);
		}

		// Token: 0x04000CF6 RID: 3318
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CF7 RID: 3319
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CF8 RID: 3320
		private const string TABLE = "DangoBrawlItemQuality";

		// Token: 0x04000CF9 RID: 3321
		private const string COMMAND = "select BinData from `DangoBrawlItemQuality` where Id=?";

		// Token: 0x04000CFA RID: 3322
		private const string KEY_PREFIX = "DangoBrawlItemQualityById";

		// Token: 0x04000CFB RID: 3323
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CFC RID: 3324
		private static int HandleId;
	}
}
