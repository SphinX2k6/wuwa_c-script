using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000071 RID: 113
	public class ConfigAdvertisingTabStoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x000687D7 File Offset: 0x000669D7
		static ConfigAdvertisingTabStoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabStoryById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabStoryById.ResetStaticDefaultValue));
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000687F8 File Offset: 0x000669F8
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

		// Token: 0x060002A8 RID: 680 RVA: 0x00068877 File Offset: 0x00066A77
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabStoryById.LogPair = null;
			ConfigAdvertisingTabStoryById.HandleId = 0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00068885 File Offset: 0x00066A85
		public static void Init()
		{
			ConfigAdvertisingTabStoryById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabStoryById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabStory` where Id=?");
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000688A0 File Offset: 0x00066AA0
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

		// Token: 0x040002FB RID: 763
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002FC RID: 764
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002FD RID: 765
		private const string TABLE = "AdvertisingTabStory";

		// Token: 0x040002FE RID: 766
		private const string COMMAND = "select BinData from `AdvertisingTabStory` where Id=?";

		// Token: 0x040002FF RID: 767
		private const string KEY_PREFIX = "AdvertisingTabStoryById";

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
