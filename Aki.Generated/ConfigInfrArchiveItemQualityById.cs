using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043A RID: 1082
	public class ConfigInfrArchiveItemQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001965 RID: 6501 RVA: 0x000ECCB4 File Offset: 0x000EAEB4
		static ConfigInfrArchiveItemQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveItemQualityById.CreateStaticDefaultValue), new Action(ConfigInfrArchiveItemQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x000ECCD4 File Offset: 0x000EAED4
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrArchiveItemQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrArchiveItemQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrArchiveItemQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrArchiveItemQuality` where Id=?")
			});
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x000ECD53 File Offset: 0x000EAF53
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveItemQualityById.LogPair = null;
			ConfigInfrArchiveItemQualityById.HandleId = 0;
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x000ECD61 File Offset: 0x000EAF61
		public static void Init()
		{
			ConfigInfrArchiveItemQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveItemQualityById.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveItemQuality` where Id=?");
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000ECD7C File Offset: 0x000EAF7C
		public static InfrArchiveItemQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrArchiveItemQualityById.HandleId, ConfigInfrArchiveItemQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrArchiveItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrArchiveItemQuality?(InfrArchiveItemQuality.GetRootAsInfrArchiveItemQuality(configBuffer));
				}
			}
			ConfigInfrArchiveItemQualityById.LogPair.Clear();
			ConfigInfrArchiveItemQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrArchiveItemQualityById.HandleId, 1, p0Id, ConfigInfrArchiveItemQualityById.LogPair) || ConfigCommon.Step(ConfigInfrArchiveItemQualityById.HandleId, true, ConfigInfrArchiveItemQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrArchiveItemQualityById.HandleId, ConfigInfrArchiveItemQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrArchiveItemQualityById.HandleId, 0, ConfigInfrArchiveItemQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrArchiveItemQualityById.HandleId, ConfigInfrArchiveItemQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrArchiveItemQuality rootAsInfrArchiveItemQuality = InfrArchiveItemQuality.GetRootAsInfrArchiveItemQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrArchiveItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrArchiveItemQualityById.HandleId, ConfigInfrArchiveItemQualityById.LogPair);
			return new InfrArchiveItemQuality?(rootAsInfrArchiveItemQuality);
		}

		// Token: 0x04001D7A RID: 7546
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D7B RID: 7547
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D7C RID: 7548
		private const string TABLE = "InfrArchiveItemQuality";

		// Token: 0x04001D7D RID: 7549
		private const string COMMAND = "select BinData from `InfrArchiveItemQuality` where Id=?";

		// Token: 0x04001D7E RID: 7550
		private const string KEY_PREFIX = "InfrArchiveItemQualityById";

		// Token: 0x04001D7F RID: 7551
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D80 RID: 7552
		private static int HandleId;
	}
}
