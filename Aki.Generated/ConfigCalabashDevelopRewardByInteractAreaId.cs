using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000143 RID: 323
	public class ConfigCalabashDevelopRewardByInteractAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000793 RID: 1939 RVA: 0x0008813B File Offset: 0x0008633B
		static ConfigCalabashDevelopRewardByInteractAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashDevelopRewardByInteractAreaId.CreateStaticDefaultValue), new Action(ConfigCalabashDevelopRewardByInteractAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0008815C File Offset: 0x0008635C
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

		// Token: 0x06000795 RID: 1941 RVA: 0x000881DB File Offset: 0x000863DB
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardByInteractAreaId.LogPair = null;
			ConfigCalabashDevelopRewardByInteractAreaId.HandleId = 0;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000881E9 File Offset: 0x000863E9
		public static void Init()
		{
			ConfigCalabashDevelopRewardByInteractAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashDevelopRewardByInteractAreaId.HandleId, "db_calabash.db", "select BinData from `CalabashDevelopReward` where InteractAreaId=?");
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00088204 File Offset: 0x00086404
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

		// Token: 0x040008B9 RID: 2233
		private const string DB = "db_calabash.db";

		// Token: 0x040008BA RID: 2234
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008BB RID: 2235
		private const string TABLE = "CalabashDevelopReward";

		// Token: 0x040008BC RID: 2236
		private const string COMMAND = "select BinData from `CalabashDevelopReward` where InteractAreaId=?";

		// Token: 0x040008BD RID: 2237
		private const string KEY_PREFIX = "CalabashDevelopRewardByInteractAreaId";

		// Token: 0x040008BE RID: 2238
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008BF RID: 2239
		private static int HandleId;
	}
}
