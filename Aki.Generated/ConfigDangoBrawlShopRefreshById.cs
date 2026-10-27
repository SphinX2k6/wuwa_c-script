using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E2 RID: 482
	public class ConfigDangoBrawlShopRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B4F RID: 2895 RVA: 0x00099824 File Offset: 0x00097A24
		static ConfigDangoBrawlShopRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlShopRefreshById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlShopRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00099844 File Offset: 0x00097A44
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

		// Token: 0x06000B51 RID: 2897 RVA: 0x000998C3 File Offset: 0x00097AC3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlShopRefreshById.LogPair = null;
			ConfigDangoBrawlShopRefreshById.HandleId = 0;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000998D1 File Offset: 0x00097AD1
		public static void Init()
		{
			ConfigDangoBrawlShopRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlShopRefreshById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlShopRefresh` where Id=?");
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000998EC File Offset: 0x00097AEC
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

		// Token: 0x04000D12 RID: 3346
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D13 RID: 3347
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000D14 RID: 3348
		private const string TABLE = "DangoBrawlShopRefresh";

		// Token: 0x04000D15 RID: 3349
		private const string COMMAND = "select BinData from `DangoBrawlShopRefresh` where Id=?";

		// Token: 0x04000D16 RID: 3350
		private const string KEY_PREFIX = "DangoBrawlShopRefreshById";

		// Token: 0x04000D17 RID: 3351
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D18 RID: 3352
		private static int HandleId;
	}
}
