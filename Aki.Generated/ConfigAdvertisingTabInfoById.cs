using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000075 RID: 117
	public class ConfigAdvertisingTabInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002BE RID: 702 RVA: 0x0006C8D3 File Offset: 0x0006AAD3
		static ConfigAdvertisingTabInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabInfoById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0006C8F4 File Offset: 0x0006AAF4
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabInfo` where Id=?")
			});
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0006C973 File Offset: 0x0006AB73
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabInfoById.LogPair = null;
			ConfigAdvertisingTabInfoById.HandleId = 0;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0006C981 File Offset: 0x0006AB81
		public static void Init()
		{
			ConfigAdvertisingTabInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabInfoById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabInfo` where Id=?");
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0006C99C File Offset: 0x0006AB9C
		public static AdvertisingTabInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabInfoById.HandleId, ConfigAdvertisingTabInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabInfo?(AdvertisingTabInfo.GetRootAsAdvertisingTabInfo(configBuffer));
				}
			}
			ConfigAdvertisingTabInfoById.LogPair.Clear();
			ConfigAdvertisingTabInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabInfoById.HandleId, 1, p0Id, ConfigAdvertisingTabInfoById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabInfoById.HandleId, true, ConfigAdvertisingTabInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabInfoById.HandleId, ConfigAdvertisingTabInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabInfoById.HandleId, 0, ConfigAdvertisingTabInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabInfoById.HandleId, ConfigAdvertisingTabInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabInfo rootAsAdvertisingTabInfo = AdvertisingTabInfo.GetRootAsAdvertisingTabInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabInfoById.HandleId, ConfigAdvertisingTabInfoById.LogPair);
			return new AdvertisingTabInfo?(rootAsAdvertisingTabInfo);
		}

		// Token: 0x04000317 RID: 791
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000318 RID: 792
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000319 RID: 793
		private const string TABLE = "AdvertisingTabInfo";

		// Token: 0x0400031A RID: 794
		private const string COMMAND = "select BinData from `AdvertisingTabInfo` where Id=?";

		// Token: 0x0400031B RID: 795
		private const string KEY_PREFIX = "AdvertisingTabInfoById";

		// Token: 0x0400031C RID: 796
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400031D RID: 797
		private static int HandleId;
	}
}
