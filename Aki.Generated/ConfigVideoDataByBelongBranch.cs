using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B49 RID: 2889
	public class ConfigVideoDataByBelongBranch : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043CA RID: 17354 RVA: 0x001DC561 File Offset: 0x001DA761
		static ConfigVideoDataByBelongBranch()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoDataByBelongBranch.CreateStaticDefaultValue), new Action(ConfigVideoDataByBelongBranch.ResetStaticDefaultValue));
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x001DC580 File Offset: 0x001DA780
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

		// Token: 0x060043CC RID: 17356 RVA: 0x001DC5FF File Offset: 0x001DA7FF
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoDataByBelongBranch.LogPair = null;
			ConfigVideoDataByBelongBranch.HandleId = 0;
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x001DC60D File Offset: 0x001DA80D
		public static void Init()
		{
			ConfigVideoDataByBelongBranch.HandleId = ConfigCommon.InitDataStatement(ConfigVideoDataByBelongBranch.HandleId, "db_cgvedio.db", "select BinData from `VideoData` where BelongBranch=?");
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x001DC628 File Offset: 0x001DA828
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

		// Token: 0x04004EE5 RID: 20197
		private const string DB = "db_cgvedio.db";

		// Token: 0x04004EE6 RID: 20198
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x04004EE7 RID: 20199
		private const string TABLE = "VideoData";

		// Token: 0x04004EE8 RID: 20200
		private const string COMMAND = "select BinData from `VideoData` where BelongBranch=?";

		// Token: 0x04004EE9 RID: 20201
		private const string KEY_PREFIX = "VideoDataByBelongBranch";

		// Token: 0x04004EEA RID: 20202
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EEB RID: 20203
		private static int HandleId;
	}
}
