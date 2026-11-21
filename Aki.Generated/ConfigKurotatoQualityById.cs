using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C5 RID: 1221
	public class ConfigKurotatoQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CA9 RID: 7337 RVA: 0x000FEDF7 File Offset: 0x000FCFF7
		static ConfigKurotatoQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoQualityById.CreateStaticDefaultValue), new Action(ConfigKurotatoQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000FEE18 File Offset: 0x000FD018
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_道具.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoQuality` where Id=?")
			});
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x000FEE97 File Offset: 0x000FD097
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoQualityById.LogPair = null;
			ConfigKurotatoQualityById.HandleId = 0;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x000FEEA5 File Offset: 0x000FD0A5
		public static void Init()
		{
			ConfigKurotatoQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoQualityById.HandleId, "db_kurotato.db", "select BinData from `KurotatoQuality` where Id=?");
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x000FEEC0 File Offset: 0x000FD0C0
		public static KurotatoQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoQualityById.HandleId, ConfigKurotatoQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoQuality?(KurotatoQuality.GetRootAsKurotatoQuality(configBuffer));
				}
			}
			ConfigKurotatoQualityById.LogPair.Clear();
			ConfigKurotatoQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoQualityById.HandleId, 1, p0Id, ConfigKurotatoQualityById.LogPair) || ConfigCommon.Step(ConfigKurotatoQualityById.HandleId, true, ConfigKurotatoQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoQualityById.HandleId, ConfigKurotatoQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoQualityById.HandleId, 0, ConfigKurotatoQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoQualityById.HandleId, ConfigKurotatoQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoQuality rootAsKurotatoQuality = KurotatoQuality.GetRootAsKurotatoQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoQualityById.HandleId, ConfigKurotatoQualityById.LogPair);
			return new KurotatoQuality?(rootAsKurotatoQuality);
		}

		// Token: 0x04002147 RID: 8519
		private const string DB = "db_kurotato.db";

		// Token: 0x04002148 RID: 8520
		private const string FILE = "t.土豆兄弟_道具.xlsx";

		// Token: 0x04002149 RID: 8521
		private const string TABLE = "KurotatoQuality";

		// Token: 0x0400214A RID: 8522
		private const string COMMAND = "select BinData from `KurotatoQuality` where Id=?";

		// Token: 0x0400214B RID: 8523
		private const string KEY_PREFIX = "KurotatoQualityById";

		// Token: 0x0400214C RID: 8524
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400214D RID: 8525
		private static int HandleId;
	}
}
