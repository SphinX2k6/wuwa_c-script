using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042A RID: 1066
	public class ConfigInfrItemQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001905 RID: 6405 RVA: 0x000E7197 File Offset: 0x000E5397
		static ConfigInfrItemQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrItemQualityById.CreateStaticDefaultValue), new Action(ConfigInfrItemQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000E71B8 File Offset: 0x000E53B8
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrItemQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrItemQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrItemQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrItemQuality` where Id=?")
			});
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x000E7237 File Offset: 0x000E5437
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrItemQualityById.LogPair = null;
			ConfigInfrItemQualityById.HandleId = 0;
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x000E7245 File Offset: 0x000E5445
		public static void Init()
		{
			ConfigInfrItemQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrItemQualityById.HandleId, "db_infrastructure.db", "select BinData from `InfrItemQuality` where Id=?");
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000E7260 File Offset: 0x000E5460
		public static InfrItemQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrItemQualityById.HandleId, ConfigInfrItemQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrItemQuality?(InfrItemQuality.GetRootAsInfrItemQuality(configBuffer));
				}
			}
			ConfigInfrItemQualityById.LogPair.Clear();
			ConfigInfrItemQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrItemQualityById.HandleId, 1, p0Id, ConfigInfrItemQualityById.LogPair) || ConfigCommon.Step(ConfigInfrItemQualityById.HandleId, true, ConfigInfrItemQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrItemQualityById.HandleId, ConfigInfrItemQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrItemQualityById.HandleId, 0, ConfigInfrItemQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrItemQualityById.HandleId, ConfigInfrItemQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrItemQuality rootAsInfrItemQuality = InfrItemQuality.GetRootAsInfrItemQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrItemQualityById.HandleId, ConfigInfrItemQualityById.LogPair);
			return new InfrItemQuality?(rootAsInfrItemQuality);
		}

		// Token: 0x04001D0A RID: 7434
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D0B RID: 7435
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D0C RID: 7436
		private const string TABLE = "InfrItemQuality";

		// Token: 0x04001D0D RID: 7437
		private const string COMMAND = "select BinData from `InfrItemQuality` where Id=?";

		// Token: 0x04001D0E RID: 7438
		private const string KEY_PREFIX = "InfrItemQualityById";

		// Token: 0x04001D0F RID: 7439
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D10 RID: 7440
		private static int HandleId;
	}
}
