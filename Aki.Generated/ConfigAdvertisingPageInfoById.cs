using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000063 RID: 99
	public class ConfigAdvertisingPageInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00066CD4 File Offset: 0x00064ED4
		static ConfigAdvertisingPageInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingPageInfoById.CreateStaticDefaultValue), new Action(ConfigAdvertisingPageInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00066CF4 File Offset: 0x00064EF4
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

		// Token: 0x06000254 RID: 596 RVA: 0x00066D73 File Offset: 0x00064F73
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingPageInfoById.LogPair = null;
			ConfigAdvertisingPageInfoById.HandleId = 0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00066D81 File Offset: 0x00064F81
		public static void Init()
		{
			ConfigAdvertisingPageInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingPageInfoById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingPageInfo` where Id=?");
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00066D9C File Offset: 0x00064F9C
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

		// Token: 0x04000299 RID: 665
		private const string DB = "db_advertisingpage.db";

		// Token: 0x0400029A RID: 666
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x0400029B RID: 667
		private const string TABLE = "AdvertisingPageInfo";

		// Token: 0x0400029C RID: 668
		private const string COMMAND = "select BinData from `AdvertisingPageInfo` where Id=?";

		// Token: 0x0400029D RID: 669
		private const string KEY_PREFIX = "AdvertisingPageInfoById";

		// Token: 0x0400029E RID: 670
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400029F RID: 671
		private static int HandleId;
	}
}
