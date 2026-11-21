using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006B RID: 107
	public class ConfigAdvertisingPageInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000282 RID: 642 RVA: 0x0006B588 File Offset: 0x00069788
		static ConfigAdvertisingPageInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingPageInfoById.CreateStaticDefaultValue), new Action(ConfigAdvertisingPageInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0006B5A8 File Offset: 0x000697A8
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingPageInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingPageInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingPageInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingPageInfo` where Id=?")
			});
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0006B627 File Offset: 0x00069827
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingPageInfoById.LogPair = null;
			ConfigAdvertisingPageInfoById.HandleId = 0;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0006B635 File Offset: 0x00069835
		public static void Init()
		{
			ConfigAdvertisingPageInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingPageInfoById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingPageInfo` where Id=?");
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0006B650 File Offset: 0x00069850
		public static AdvertisingPageInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingPageInfoById.HandleId, ConfigAdvertisingPageInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingPageInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingPageInfo?(AdvertisingPageInfo.GetRootAsAdvertisingPageInfo(configBuffer));
				}
			}
			ConfigAdvertisingPageInfoById.LogPair.Clear();
			ConfigAdvertisingPageInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingPageInfoById.HandleId, 1, p0Id, ConfigAdvertisingPageInfoById.LogPair) || ConfigCommon.Step(ConfigAdvertisingPageInfoById.HandleId, true, ConfigAdvertisingPageInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingPageInfoById.HandleId, ConfigAdvertisingPageInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingPageInfoById.HandleId, 0, ConfigAdvertisingPageInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingPageInfoById.HandleId, ConfigAdvertisingPageInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingPageInfo rootAsAdvertisingPageInfo = AdvertisingPageInfo.GetRootAsAdvertisingPageInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingPageInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingPageInfoById.HandleId, ConfigAdvertisingPageInfoById.LogPair);
			return new AdvertisingPageInfo?(rootAsAdvertisingPageInfo);
		}

		// Token: 0x040002D1 RID: 721
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002D2 RID: 722
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002D3 RID: 723
		private const string TABLE = "AdvertisingPageInfo";

		// Token: 0x040002D4 RID: 724
		private const string COMMAND = "select BinData from `AdvertisingPageInfo` where Id=?";

		// Token: 0x040002D5 RID: 725
		private const string KEY_PREFIX = "AdvertisingPageInfoById";

		// Token: 0x040002D6 RID: 726
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002D7 RID: 727
		private static int HandleId;
	}
}
