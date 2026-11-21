using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A76 RID: 2678
	public class ConfigSurvivorsQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ED8 RID: 16088 RVA: 0x001C0074 File Offset: 0x001BE274
		static ConfigSurvivorsQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsQualityById.CreateStaticDefaultValue), new Action(ConfigSurvivorsQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x001C0094 File Offset: 0x001BE294
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局外.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsQuality` where Id=?")
			});
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x001C0113 File Offset: 0x001BE313
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsQualityById.LogPair = null;
			ConfigSurvivorsQualityById.HandleId = 0;
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x001C0121 File Offset: 0x001BE321
		public static void Init()
		{
			ConfigSurvivorsQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsQualityById.HandleId, "db_survivors.db", "select BinData from `SurvivorsQuality` where Id=?");
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x001C013C File Offset: 0x001BE33C
		public static SurvivorsQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsQualityById.HandleId, ConfigSurvivorsQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsQuality?(SurvivorsQuality.GetRootAsSurvivorsQuality(configBuffer));
				}
			}
			ConfigSurvivorsQualityById.LogPair.Clear();
			ConfigSurvivorsQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsQualityById.HandleId, 1, p0Id, ConfigSurvivorsQualityById.LogPair) || ConfigCommon.Step(ConfigSurvivorsQualityById.HandleId, true, ConfigSurvivorsQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsQualityById.HandleId, ConfigSurvivorsQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsQualityById.HandleId, 0, ConfigSurvivorsQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsQualityById.HandleId, ConfigSurvivorsQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsQuality rootAsSurvivorsQuality = SurvivorsQuality.GetRootAsSurvivorsQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsQualityById.HandleId, ConfigSurvivorsQualityById.LogPair);
			return new SurvivorsQuality?(rootAsSurvivorsQuality);
		}

		// Token: 0x04004920 RID: 18720
		private const string DB = "db_survivors.db";

		// Token: 0x04004921 RID: 18721
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x04004922 RID: 18722
		private const string TABLE = "SurvivorsQuality";

		// Token: 0x04004923 RID: 18723
		private const string COMMAND = "select BinData from `SurvivorsQuality` where Id=?";

		// Token: 0x04004924 RID: 18724
		private const string KEY_PREFIX = "SurvivorsQualityById";

		// Token: 0x04004925 RID: 18725
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004926 RID: 18726
		private static int HandleId;
	}
}
