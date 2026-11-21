using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F4 RID: 500
	public class ConfigDangoBrawlShopRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BBB RID: 3003 RVA: 0x0009F75C File Offset: 0x0009D95C
		static ConfigDangoBrawlShopRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlShopRefreshById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlShopRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0009F77C File Offset: 0x0009D97C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlShopRefreshById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlShopRefreshById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗局内.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlShopRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlShopRefresh` where Id=?")
			});
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0009F7FB File Offset: 0x0009D9FB
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlShopRefreshById.LogPair = null;
			ConfigDangoBrawlShopRefreshById.HandleId = 0;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0009F809 File Offset: 0x0009DA09
		public static void Init()
		{
			ConfigDangoBrawlShopRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlShopRefreshById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlShopRefresh` where Id=?");
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0009F824 File Offset: 0x0009DA24
		public static DangoBrawlShopRefresh? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlShopRefreshById.HandleId, ConfigDangoBrawlShopRefreshById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlShopRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlShopRefresh?(DangoBrawlShopRefresh.GetRootAsDangoBrawlShopRefresh(configBuffer));
				}
			}
			ConfigDangoBrawlShopRefreshById.LogPair.Clear();
			ConfigDangoBrawlShopRefreshById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlShopRefreshById.HandleId, 1, p0Id, ConfigDangoBrawlShopRefreshById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlShopRefreshById.HandleId, true, ConfigDangoBrawlShopRefreshById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlShopRefreshById.HandleId, ConfigDangoBrawlShopRefreshById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlShopRefreshById.HandleId, 0, ConfigDangoBrawlShopRefreshById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlShopRefreshById.HandleId, ConfigDangoBrawlShopRefreshById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlShopRefresh rootAsDangoBrawlShopRefresh = DangoBrawlShopRefresh.GetRootAsDangoBrawlShopRefresh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlShopRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlShopRefreshById.HandleId, ConfigDangoBrawlShopRefreshById.LogPair);
			return new DangoBrawlShopRefresh?(rootAsDangoBrawlShopRefresh);
		}

		// Token: 0x04000D90 RID: 3472
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D91 RID: 3473
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000D92 RID: 3474
		private const string TABLE = "DangoBrawlShopRefresh";

		// Token: 0x04000D93 RID: 3475
		private const string COMMAND = "select BinData from `DangoBrawlShopRefresh` where Id=?";

		// Token: 0x04000D94 RID: 3476
		private const string KEY_PREFIX = "DangoBrawlShopRefreshById";

		// Token: 0x04000D95 RID: 3477
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D96 RID: 3478
		private static int HandleId;
	}
}
