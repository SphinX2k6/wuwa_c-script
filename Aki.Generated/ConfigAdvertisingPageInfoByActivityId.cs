using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000062 RID: 98
	public class ConfigAdvertisingPageInfoByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600024C RID: 588 RVA: 0x00066A8B File Offset: 0x00064C8B
		static ConfigAdvertisingPageInfoByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingPageInfoByActivityId.CreateStaticDefaultValue), new Action(ConfigAdvertisingPageInfoByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00066AAC File Offset: 0x00064CAC
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingPageInfoByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingPageInfoByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingPageInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingPageInfo` where ActivityId=?")
			});
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00066B2B File Offset: 0x00064D2B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingPageInfoByActivityId.LogPair = null;
			ConfigAdvertisingPageInfoByActivityId.HandleId = 0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00066B39 File Offset: 0x00064D39
		public static void Init()
		{
			ConfigAdvertisingPageInfoByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingPageInfoByActivityId.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingPageInfo` where ActivityId=?");
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00066B54 File Offset: 0x00064D54
		public static AdvertisingPageInfo? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingPageInfoByActivityId.HandleId, ConfigAdvertisingPageInfoByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingPageInfoByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingPageInfo?(AdvertisingPageInfo.GetRootAsAdvertisingPageInfo(configBuffer));
				}
			}
			ConfigAdvertisingPageInfoByActivityId.LogPair.Clear();
			ConfigAdvertisingPageInfoByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigAdvertisingPageInfoByActivityId.HandleId, 1, p0ActivityId, ConfigAdvertisingPageInfoByActivityId.LogPair) || ConfigCommon.Step(ConfigAdvertisingPageInfoByActivityId.HandleId, true, ConfigAdvertisingPageInfoByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingPageInfoByActivityId.HandleId, ConfigAdvertisingPageInfoByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingPageInfoByActivityId.HandleId, 0, ConfigAdvertisingPageInfoByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingPageInfoByActivityId.HandleId, ConfigAdvertisingPageInfoByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingPageInfo rootAsAdvertisingPageInfo = AdvertisingPageInfo.GetRootAsAdvertisingPageInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingPageInfoByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingPageInfoByActivityId.HandleId, ConfigAdvertisingPageInfoByActivityId.LogPair);
			return new AdvertisingPageInfo?(rootAsAdvertisingPageInfo);
		}

		// Token: 0x04000292 RID: 658
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000293 RID: 659
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000294 RID: 660
		private const string TABLE = "AdvertisingPageInfo";

		// Token: 0x04000295 RID: 661
		private const string COMMAND = "select BinData from `AdvertisingPageInfo` where ActivityId=?";

		// Token: 0x04000296 RID: 662
		private const string KEY_PREFIX = "AdvertisingPageInfoByActivityId";

		// Token: 0x04000297 RID: 663
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000298 RID: 664
		private static int HandleId;
	}
}
