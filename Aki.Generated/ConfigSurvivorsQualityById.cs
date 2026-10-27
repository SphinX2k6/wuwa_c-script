using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A1 RID: 2465
	public class ConfigSurvivorsQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039DA RID: 14810 RVA: 0x001A0CE0 File Offset: 0x0019EEE0
		static ConfigSurvivorsQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsQualityById.CreateStaticDefaultValue), new Action(ConfigSurvivorsQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x001A0D00 File Offset: 0x0019EF00
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

		// Token: 0x060039DC RID: 14812 RVA: 0x001A0D7F File Offset: 0x0019EF7F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsQualityById.LogPair = null;
			ConfigSurvivorsQualityById.HandleId = 0;
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x001A0D8D File Offset: 0x0019EF8D
		public static void Init()
		{
			ConfigSurvivorsQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsQualityById.HandleId, "db_survivors.db", "select BinData from `SurvivorsQuality` where Id=?");
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x001A0DA8 File Offset: 0x0019EFA8
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

		// Token: 0x0400434D RID: 17229
		private const string DB = "db_survivors.db";

		// Token: 0x0400434E RID: 17230
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x0400434F RID: 17231
		private const string TABLE = "SurvivorsQuality";

		// Token: 0x04004350 RID: 17232
		private const string COMMAND = "select BinData from `SurvivorsQuality` where Id=?";

		// Token: 0x04004351 RID: 17233
		private const string KEY_PREFIX = "SurvivorsQualityById";

		// Token: 0x04004352 RID: 17234
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004353 RID: 17235
		private static int HandleId;
	}
}
