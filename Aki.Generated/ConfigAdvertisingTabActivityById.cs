using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000065 RID: 101
	public class ConfigAdvertisingTabActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600025E RID: 606 RVA: 0x000670AF File Offset: 0x000652AF
		static ConfigAdvertisingTabActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabActivityById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000670D0 File Offset: 0x000652D0
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabActivity` where Id=?")
			});
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0006714F File Offset: 0x0006534F
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabActivityById.LogPair = null;
			ConfigAdvertisingTabActivityById.HandleId = 0;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0006715D File Offset: 0x0006535D
		public static void Init()
		{
			ConfigAdvertisingTabActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabActivityById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabActivity` where Id=?");
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00067178 File Offset: 0x00065378
		public static AdvertisingTabActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabActivityById.HandleId, ConfigAdvertisingTabActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabActivity?(AdvertisingTabActivity.GetRootAsAdvertisingTabActivity(configBuffer));
				}
			}
			ConfigAdvertisingTabActivityById.LogPair.Clear();
			ConfigAdvertisingTabActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabActivityById.HandleId, 1, p0Id, ConfigAdvertisingTabActivityById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabActivityById.HandleId, true, ConfigAdvertisingTabActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabActivityById.HandleId, ConfigAdvertisingTabActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabActivityById.HandleId, 0, ConfigAdvertisingTabActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabActivityById.HandleId, ConfigAdvertisingTabActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabActivity rootAsAdvertisingTabActivity = AdvertisingTabActivity.GetRootAsAdvertisingTabActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabActivityById.HandleId, ConfigAdvertisingTabActivityById.LogPair);
			return new AdvertisingTabActivity?(rootAsAdvertisingTabActivity);
		}

		// Token: 0x040002A7 RID: 679
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002A8 RID: 680
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002A9 RID: 681
		private const string TABLE = "AdvertisingTabActivity";

		// Token: 0x040002AA RID: 682
		private const string COMMAND = "select BinData from `AdvertisingTabActivity` where Id=?";

		// Token: 0x040002AB RID: 683
		private const string KEY_PREFIX = "AdvertisingTabActivityById";

		// Token: 0x040002AC RID: 684
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002AD RID: 685
		private static int HandleId;
	}
}
