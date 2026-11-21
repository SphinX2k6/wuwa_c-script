using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000079 RID: 121
	public class ConfigAdvertisingTabStoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0006D08B File Offset: 0x0006B28B
		static ConfigAdvertisingTabStoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabStoryById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabStoryById.ResetStaticDefaultValue));
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0006D0AC File Offset: 0x0006B2AC
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabStoryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabStoryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabStory"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabStory` where Id=?")
			});
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0006D12B File Offset: 0x0006B32B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabStoryById.LogPair = null;
			ConfigAdvertisingTabStoryById.HandleId = 0;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0006D139 File Offset: 0x0006B339
		public static void Init()
		{
			ConfigAdvertisingTabStoryById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabStoryById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabStory` where Id=?");
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0006D154 File Offset: 0x0006B354
		public static AdvertisingTabStory? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabStoryById.HandleId, ConfigAdvertisingTabStoryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabStoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabStory?(AdvertisingTabStory.GetRootAsAdvertisingTabStory(configBuffer));
				}
			}
			ConfigAdvertisingTabStoryById.LogPair.Clear();
			ConfigAdvertisingTabStoryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabStoryById.HandleId, 1, p0Id, ConfigAdvertisingTabStoryById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabStoryById.HandleId, true, ConfigAdvertisingTabStoryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabStoryById.HandleId, ConfigAdvertisingTabStoryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabStoryById.HandleId, 0, ConfigAdvertisingTabStoryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabStoryById.HandleId, ConfigAdvertisingTabStoryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabStory rootAsAdvertisingTabStory = AdvertisingTabStory.GetRootAsAdvertisingTabStory(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabStoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabStoryById.HandleId, ConfigAdvertisingTabStoryById.LogPair);
			return new AdvertisingTabStory?(rootAsAdvertisingTabStory);
		}

		// Token: 0x04000333 RID: 819
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000334 RID: 820
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000335 RID: 821
		private const string TABLE = "AdvertisingTabStory";

		// Token: 0x04000336 RID: 822
		private const string COMMAND = "select BinData from `AdvertisingTabStory` where Id=?";

		// Token: 0x04000337 RID: 823
		private const string KEY_PREFIX = "AdvertisingTabStoryById";

		// Token: 0x04000338 RID: 824
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000339 RID: 825
		private static int HandleId;
	}
}
