using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000071 RID: 113
	public class ConfigAdvertisingTabCostumeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x0006C11B File Offset: 0x0006A31B
		static ConfigAdvertisingTabCostumeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabCostumeById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabCostumeById.ResetStaticDefaultValue));
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0006C13C File Offset: 0x0006A33C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabCostumeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabCostumeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabCostume"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabCostume` where Id=?")
			});
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0006C1BB File Offset: 0x0006A3BB
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabCostumeById.LogPair = null;
			ConfigAdvertisingTabCostumeById.HandleId = 0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0006C1C9 File Offset: 0x0006A3C9
		public static void Init()
		{
			ConfigAdvertisingTabCostumeById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabCostumeById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabCostume` where Id=?");
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0006C1E4 File Offset: 0x0006A3E4
		public static AdvertisingTabCostume? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabCostumeById.HandleId, ConfigAdvertisingTabCostumeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabCostumeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabCostume?(AdvertisingTabCostume.GetRootAsAdvertisingTabCostume(configBuffer));
				}
			}
			ConfigAdvertisingTabCostumeById.LogPair.Clear();
			ConfigAdvertisingTabCostumeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabCostumeById.HandleId, 1, p0Id, ConfigAdvertisingTabCostumeById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabCostumeById.HandleId, true, ConfigAdvertisingTabCostumeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabCostumeById.HandleId, ConfigAdvertisingTabCostumeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabCostumeById.HandleId, 0, ConfigAdvertisingTabCostumeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabCostumeById.HandleId, ConfigAdvertisingTabCostumeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabCostume rootAsAdvertisingTabCostume = AdvertisingTabCostume.GetRootAsAdvertisingTabCostume(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabCostumeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabCostumeById.HandleId, ConfigAdvertisingTabCostumeById.LogPair);
			return new AdvertisingTabCostume?(rootAsAdvertisingTabCostume);
		}

		// Token: 0x040002FB RID: 763
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002FC RID: 764
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002FD RID: 765
		private const string TABLE = "AdvertisingTabCostume";

		// Token: 0x040002FE RID: 766
		private const string COMMAND = "select BinData from `AdvertisingTabCostume` where Id=?";

		// Token: 0x040002FF RID: 767
		private const string KEY_PREFIX = "AdvertisingTabCostumeById";

		// Token: 0x04000300 RID: 768
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000301 RID: 769
		private static int HandleId;
	}
}
