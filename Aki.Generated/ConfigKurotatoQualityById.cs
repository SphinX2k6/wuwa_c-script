using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AF RID: 1199
	public class ConfigKurotatoQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C25 RID: 7205 RVA: 0x000F86A3 File Offset: 0x000F68A3
		static ConfigKurotatoQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoQualityById.CreateStaticDefaultValue), new Action(ConfigKurotatoQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000F86C4 File Offset: 0x000F68C4
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

		// Token: 0x06001C27 RID: 7207 RVA: 0x000F8743 File Offset: 0x000F6943
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoQualityById.LogPair = null;
			ConfigKurotatoQualityById.HandleId = 0;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000F8751 File Offset: 0x000F6951
		public static void Init()
		{
			ConfigKurotatoQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoQualityById.HandleId, "db_kurotato.db", "select BinData from `KurotatoQuality` where Id=?");
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000F876C File Offset: 0x000F696C
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

		// Token: 0x040020AD RID: 8365
		private const string DB = "db_kurotato.db";

		// Token: 0x040020AE RID: 8366
		private const string FILE = "t.土豆兄弟_道具.xlsx";

		// Token: 0x040020AF RID: 8367
		private const string TABLE = "KurotatoQuality";

		// Token: 0x040020B0 RID: 8368
		private const string COMMAND = "select BinData from `KurotatoQuality` where Id=?";

		// Token: 0x040020B1 RID: 8369
		private const string KEY_PREFIX = "KurotatoQualityById";

		// Token: 0x040020B2 RID: 8370
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020B3 RID: 8371
		private static int HandleId;
	}
}
