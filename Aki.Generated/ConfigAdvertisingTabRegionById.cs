using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006F RID: 111
	public class ConfigAdvertisingTabRegionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600029A RID: 666 RVA: 0x000683FB File Offset: 0x000665FB
		static ConfigAdvertisingTabRegionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabRegionById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabRegionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0006841C File Offset: 0x0006661C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabRegionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabRegionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabRegion"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabRegion` where Id=?")
			});
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0006849B File Offset: 0x0006669B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabRegionById.LogPair = null;
			ConfigAdvertisingTabRegionById.HandleId = 0;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000684A9 File Offset: 0x000666A9
		public static void Init()
		{
			ConfigAdvertisingTabRegionById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabRegionById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabRegion` where Id=?");
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000684C4 File Offset: 0x000666C4
		public static AdvertisingTabRegion? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabRegionById.HandleId, ConfigAdvertisingTabRegionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabRegionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabRegion?(AdvertisingTabRegion.GetRootAsAdvertisingTabRegion(configBuffer));
				}
			}
			ConfigAdvertisingTabRegionById.LogPair.Clear();
			ConfigAdvertisingTabRegionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabRegionById.HandleId, 1, p0Id, ConfigAdvertisingTabRegionById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabRegionById.HandleId, true, ConfigAdvertisingTabRegionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabRegionById.HandleId, ConfigAdvertisingTabRegionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabRegionById.HandleId, 0, ConfigAdvertisingTabRegionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabRegionById.HandleId, ConfigAdvertisingTabRegionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabRegion rootAsAdvertisingTabRegion = AdvertisingTabRegion.GetRootAsAdvertisingTabRegion(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabRegionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabRegionById.HandleId, ConfigAdvertisingTabRegionById.LogPair);
			return new AdvertisingTabRegion?(rootAsAdvertisingTabRegion);
		}

		// Token: 0x040002ED RID: 749
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002EE RID: 750
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002EF RID: 751
		private const string TABLE = "AdvertisingTabRegion";

		// Token: 0x040002F0 RID: 752
		private const string COMMAND = "select BinData from `AdvertisingTabRegion` where Id=?";

		// Token: 0x040002F1 RID: 753
		private const string KEY_PREFIX = "AdvertisingTabRegionById";

		// Token: 0x040002F2 RID: 754
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002F3 RID: 755
		private static int HandleId;
	}
}
