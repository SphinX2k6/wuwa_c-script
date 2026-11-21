using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000440 RID: 1088
	public class ConfigInfrItemQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001989 RID: 6537 RVA: 0x000ED8EB File Offset: 0x000EBAEB
		static ConfigInfrItemQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrItemQualityById.CreateStaticDefaultValue), new Action(ConfigInfrItemQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000ED90C File Offset: 0x000EBB0C
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

		// Token: 0x0600198B RID: 6539 RVA: 0x000ED98B File Offset: 0x000EBB8B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrItemQualityById.LogPair = null;
			ConfigInfrItemQualityById.HandleId = 0;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x000ED999 File Offset: 0x000EBB99
		public static void Init()
		{
			ConfigInfrItemQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrItemQualityById.HandleId, "db_infrastructure.db", "select BinData from `InfrItemQuality` where Id=?");
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x000ED9B4 File Offset: 0x000EBBB4
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

		// Token: 0x04001DA4 RID: 7588
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DA5 RID: 7589
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001DA6 RID: 7590
		private const string TABLE = "InfrItemQuality";

		// Token: 0x04001DA7 RID: 7591
		private const string COMMAND = "select BinData from `InfrItemQuality` where Id=?";

		// Token: 0x04001DA8 RID: 7592
		private const string KEY_PREFIX = "InfrItemQualityById";

		// Token: 0x04001DA9 RID: 7593
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DAA RID: 7594
		private static int HandleId;
	}
}
