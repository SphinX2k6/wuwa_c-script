using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CC RID: 460
	public class ConfigDangoBrawlItemQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ACB RID: 2763 RVA: 0x00096998 File Offset: 0x00094B98
		static ConfigDangoBrawlItemQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemQualityById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000969B8 File Offset: 0x00094BB8
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

		// Token: 0x06000ACD RID: 2765 RVA: 0x00096A37 File Offset: 0x00094C37
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemQualityById.LogPair = null;
			ConfigDangoBrawlItemQualityById.HandleId = 0;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00096A45 File Offset: 0x00094C45
		public static void Init()
		{
			ConfigDangoBrawlItemQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemQualityById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemQuality` where Id=?");
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00096A60 File Offset: 0x00094C60
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

		// Token: 0x04000C78 RID: 3192
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C79 RID: 3193
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000C7A RID: 3194
		private const string TABLE = "DangoBrawlItemQuality";

		// Token: 0x04000C7B RID: 3195
		private const string COMMAND = "select BinData from `DangoBrawlItemQuality` where Id=?";

		// Token: 0x04000C7C RID: 3196
		private const string KEY_PREFIX = "DangoBrawlItemQualityById";

		// Token: 0x04000C7D RID: 3197
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C7E RID: 3198
		private static int HandleId;
	}
}
