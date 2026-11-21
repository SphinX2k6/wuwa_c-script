using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000077 RID: 119
	public class ConfigAdvertisingTabRegionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002CA RID: 714 RVA: 0x0006CCAF File Offset: 0x0006AEAF
		static ConfigAdvertisingTabRegionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabRegionById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabRegionById.ResetStaticDefaultValue));
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0006CCD0 File Offset: 0x0006AED0
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

		// Token: 0x060002CC RID: 716 RVA: 0x0006CD4F File Offset: 0x0006AF4F
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabRegionById.LogPair = null;
			ConfigAdvertisingTabRegionById.HandleId = 0;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0006CD5D File Offset: 0x0006AF5D
		public static void Init()
		{
			ConfigAdvertisingTabRegionById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabRegionById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabRegion` where Id=?");
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0006CD78 File Offset: 0x0006AF78
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

		// Token: 0x04000325 RID: 805
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000326 RID: 806
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000327 RID: 807
		private const string TABLE = "AdvertisingTabRegion";

		// Token: 0x04000328 RID: 808
		private const string COMMAND = "select BinData from `AdvertisingTabRegion` where Id=?";

		// Token: 0x04000329 RID: 809
		private const string KEY_PREFIX = "AdvertisingTabRegionById";

		// Token: 0x0400032A RID: 810
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400032B RID: 811
		private static int HandleId;
	}
}
