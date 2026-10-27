using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000069 RID: 105
	public class ConfigAdvertisingTabCostumeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000276 RID: 630 RVA: 0x00067867 File Offset: 0x00065A67
		static ConfigAdvertisingTabCostumeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabCostumeById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabCostumeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00067888 File Offset: 0x00065A88
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

		// Token: 0x06000278 RID: 632 RVA: 0x00067907 File Offset: 0x00065B07
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabCostumeById.LogPair = null;
			ConfigAdvertisingTabCostumeById.HandleId = 0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00067915 File Offset: 0x00065B15
		public static void Init()
		{
			ConfigAdvertisingTabCostumeById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabCostumeById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabCostume` where Id=?");
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00067930 File Offset: 0x00065B30
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

		// Token: 0x040002C3 RID: 707
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002C4 RID: 708
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002C5 RID: 709
		private const string TABLE = "AdvertisingTabCostume";

		// Token: 0x040002C6 RID: 710
		private const string COMMAND = "select BinData from `AdvertisingTabCostume` where Id=?";

		// Token: 0x040002C7 RID: 711
		private const string KEY_PREFIX = "AdvertisingTabCostumeById";

		// Token: 0x040002C8 RID: 712
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002C9 RID: 713
		private static int HandleId;
	}
}
