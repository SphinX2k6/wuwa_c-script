using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A74 RID: 2676
	public class ConfigVideoDataByBelongBranch : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ECC RID: 16076 RVA: 0x001BD1CD File Offset: 0x001BB3CD
		static ConfigVideoDataByBelongBranch()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoDataByBelongBranch.CreateStaticDefaultValue), new Action(ConfigVideoDataByBelongBranch.ResetStaticDefaultValue));
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x001BD1EC File Offset: 0x001BB3EC
		public static void CreateStaticDefaultValue()
		{
			ConfigVideoDataByBelongBranch.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigVideoDataByBelongBranch.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cgvedio.db"),
				new ValueTuple<string, object>("文件", "g.过场cg.xlsx"),
				new ValueTuple<string, object>("表名", "VideoData"),
				new ValueTuple<string, object>("语句", "select BinData from `VideoData` where BelongBranch=?")
			});
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x001BD26B File Offset: 0x001BB46B
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoDataByBelongBranch.LogPair = null;
			ConfigVideoDataByBelongBranch.HandleId = 0;
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x001BD279 File Offset: 0x001BB479
		public static void Init()
		{
			ConfigVideoDataByBelongBranch.HandleId = ConfigCommon.InitDataStatement(ConfigVideoDataByBelongBranch.HandleId, "db_cgvedio.db", "select BinData from `VideoData` where BelongBranch=?");
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x001BD294 File Offset: 0x001BB494
		[NullableContext(2)]
		public static IReadOnlyList<VideoData> GetConfigList(int p0BelongBranch, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigVideoDataByBelongBranch.HandleId, ConfigVideoDataByBelongBranch.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("VideoDataByBelongBranch");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BelongBranch);
				IReadOnlyList<VideoData> readOnlyList = (IReadOnlyList<VideoData>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigVideoDataByBelongBranch.LogPair.Clear();
			ConfigVideoDataByBelongBranch.LogPair.Add(new ValueTuple<string, object>("BelongBranch", p0BelongBranch));
			if (!ConfigCommon.BindInt(ConfigVideoDataByBelongBranch.HandleId, 1, p0BelongBranch, ConfigVideoDataByBelongBranch.LogPair))
			{
				ConfigCommon.Reset(ConfigVideoDataByBelongBranch.HandleId, ConfigVideoDataByBelongBranch.LogPair);
				return null;
			}
			List<VideoData> list = new List<VideoData>();
			while (ConfigCommon.Step(ConfigVideoDataByBelongBranch.HandleId, false, ConfigVideoDataByBelongBranch.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigVideoDataByBelongBranch.HandleId, 0, ConfigVideoDataByBelongBranch.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigVideoDataByBelongBranch.HandleId, ConfigVideoDataByBelongBranch.LogPair);
					return null;
				}
				VideoData rootAsVideoData = VideoData.GetRootAsVideoData(new ByteBuffer(item2));
				list.Add(rootAsVideoData);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("VideoDataByBelongBranch");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BelongBranch);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigVideoDataByBelongBranch.HandleId, ConfigVideoDataByBelongBranch.LogPair);
			return list;
		}

		// Token: 0x04004912 RID: 18706
		private const string DB = "db_cgvedio.db";

		// Token: 0x04004913 RID: 18707
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x04004914 RID: 18708
		private const string TABLE = "VideoData";

		// Token: 0x04004915 RID: 18709
		private const string COMMAND = "select BinData from `VideoData` where BelongBranch=?";

		// Token: 0x04004916 RID: 18710
		private const string KEY_PREFIX = "VideoDataByBelongBranch";

		// Token: 0x04004917 RID: 18711
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004918 RID: 18712
		private static int HandleId;
	}
}
