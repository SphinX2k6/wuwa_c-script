using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000134 RID: 308
	public class ConfigCalabashDevelopRewardByInteractAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x000827D7 File Offset: 0x000809D7
		static ConfigCalabashDevelopRewardByInteractAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashDevelopRewardByInteractAreaId.CreateStaticDefaultValue), new Action(ConfigCalabashDevelopRewardByInteractAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000827F8 File Offset: 0x000809F8
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardByInteractAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashDevelopRewardByInteractAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashDevelopReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashDevelopReward` where InteractAreaId=?")
			});
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00082877 File Offset: 0x00080A77
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardByInteractAreaId.LogPair = null;
			ConfigCalabashDevelopRewardByInteractAreaId.HandleId = 0;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00082885 File Offset: 0x00080A85
		public static void Init()
		{
			ConfigCalabashDevelopRewardByInteractAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, "db_calabash.db", "select BinData from `CalabashDevelopReward` where InteractAreaId=?");
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000828A0 File Offset: 0x00080AA0
		[NullableContext(2)]
		public static IReadOnlyList<CalabashDevelopReward> GetConfigList(int p0InteractAreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, ConfigCalabashDevelopRewardByInteractAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashDevelopRewardByInteractAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InteractAreaId);
				IReadOnlyList<CalabashDevelopReward> readOnlyList = (IReadOnlyList<CalabashDevelopReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCalabashDevelopRewardByInteractAreaId.LogPair.Clear();
			ConfigCalabashDevelopRewardByInteractAreaId.LogPair.Add(new ValueTuple<string, object>("InteractAreaId", p0InteractAreaId));
			if (!ConfigCommon.BindInt(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, 1, p0InteractAreaId, ConfigCalabashDevelopRewardByInteractAreaId.LogPair))
			{
				ConfigCommon.Reset(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, ConfigCalabashDevelopRewardByInteractAreaId.LogPair);
				return null;
			}
			List<CalabashDevelopReward> list = new List<CalabashDevelopReward>();
			while (ConfigCommon.Step(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, false, ConfigCalabashDevelopRewardByInteractAreaId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, 0, ConfigCalabashDevelopRewardByInteractAreaId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, ConfigCalabashDevelopRewardByInteractAreaId.LogPair);
					return null;
				}
				CalabashDevelopReward rootAsCalabashDevelopReward = CalabashDevelopReward.GetRootAsCalabashDevelopReward(new ByteBuffer(item2));
				list.Add(rootAsCalabashDevelopReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashDevelopRewardByInteractAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InteractAreaId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, ConfigCalabashDevelopRewardByInteractAreaId.LogPair);
			return list;
		}

		// Token: 0x04000850 RID: 2128
		private const string DB = "db_calabash.db";

		// Token: 0x04000851 RID: 2129
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04000852 RID: 2130
		private const string TABLE = "CalabashDevelopReward";

		// Token: 0x04000853 RID: 2131
		private const string COMMAND = "select BinData from `CalabashDevelopReward` where InteractAreaId=?";

		// Token: 0x04000854 RID: 2132
		private const string KEY_PREFIX = "CalabashDevelopRewardByInteractAreaId";

		// Token: 0x04000855 RID: 2133
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000856 RID: 2134
		private static int HandleId;
	}
}
