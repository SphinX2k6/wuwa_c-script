using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000424 RID: 1060
	public class ConfigInfrArchiveItemQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018E1 RID: 6369 RVA: 0x000E6560 File Offset: 0x000E4760
		static ConfigInfrArchiveItemQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveItemQualityById.CreateStaticDefaultValue), new Action(ConfigInfrArchiveItemQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000E6580 File Offset: 0x000E4780
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

		// Token: 0x060018E3 RID: 6371 RVA: 0x000E65FF File Offset: 0x000E47FF
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveItemQualityById.LogPair = null;
			ConfigInfrArchiveItemQualityById.HandleId = 0;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x000E660D File Offset: 0x000E480D
		public static void Init()
		{
			ConfigInfrArchiveItemQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveItemQualityById.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveItemQuality` where Id=?");
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x000E6628 File Offset: 0x000E4828
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

		// Token: 0x04001CE0 RID: 7392
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CE1 RID: 7393
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001CE2 RID: 7394
		private const string TABLE = "InfrArchiveItemQuality";

		// Token: 0x04001CE3 RID: 7395
		private const string COMMAND = "select BinData from `InfrArchiveItemQuality` where Id=?";

		// Token: 0x04001CE4 RID: 7396
		private const string KEY_PREFIX = "InfrArchiveItemQualityById";

		// Token: 0x04001CE5 RID: 7397
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CE6 RID: 7398
		private static int HandleId;
	}
}
