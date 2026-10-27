using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006D RID: 109
	public class ConfigAdvertisingTabInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600028E RID: 654 RVA: 0x0006801F File Offset: 0x0006621F
		static ConfigAdvertisingTabInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabInfoById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00068040 File Offset: 0x00066240
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

		// Token: 0x06000290 RID: 656 RVA: 0x000680BF File Offset: 0x000662BF
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabInfoById.LogPair = null;
			ConfigAdvertisingTabInfoById.HandleId = 0;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000680CD File Offset: 0x000662CD
		public static void Init()
		{
			ConfigAdvertisingTabInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabInfoById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabInfo` where Id=?");
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000680E8 File Offset: 0x000662E8
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

		// Token: 0x040002DF RID: 735
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002E0 RID: 736
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002E1 RID: 737
		private const string TABLE = "AdvertisingTabInfo";

		// Token: 0x040002E2 RID: 738
		private const string COMMAND = "select BinData from `AdvertisingTabInfo` where Id=?";

		// Token: 0x040002E3 RID: 739
		private const string KEY_PREFIX = "AdvertisingTabInfoById";

		// Token: 0x040002E4 RID: 740
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002E5 RID: 741
		private static int HandleId;
	}
}
