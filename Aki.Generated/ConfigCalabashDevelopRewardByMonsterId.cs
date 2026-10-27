using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000135 RID: 309
	public class ConfigCalabashDevelopRewardByMonsterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x00082A0F File Offset: 0x00080C0F
		static ConfigCalabashDevelopRewardByMonsterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashDevelopRewardByMonsterId.CreateStaticDefaultValue), new Action(ConfigCalabashDevelopRewardByMonsterId.ResetStaticDefaultValue));
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00082A30 File Offset: 0x00080C30
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardByMonsterId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashDevelopRewardByMonsterId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashDevelopReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashDevelopReward` where MonsterId=?")
			});
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00082AAF File Offset: 0x00080CAF
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardByMonsterId.LogPair = null;
			ConfigCalabashDevelopRewardByMonsterId.HandleId = 0;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00082ABD File Offset: 0x00080CBD
		public static void Init()
		{
			ConfigCalabashDevelopRewardByMonsterId.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashDevelopRewardByMonsterId.HandleId, "db_calabash.db", "select BinData from `CalabashDevelopReward` where MonsterId=?");
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00082AD8 File Offset: 0x00080CD8
		public static CalabashDevelopReward? GetConfig(int p0MonsterId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashDevelopRewardByMonsterId.HandleId, ConfigCalabashDevelopRewardByMonsterId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashDevelopRewardByMonsterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MonsterId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashDevelopReward?(CalabashDevelopReward.GetRootAsCalabashDevelopReward(configBuffer));
				}
			}
			ConfigCalabashDevelopRewardByMonsterId.LogPair.Clear();
			ConfigCalabashDevelopRewardByMonsterId.LogPair.Add(new ValueTuple<string, object>("MonsterId", p0MonsterId));
			if (!ConfigCommon.BindInt(ConfigCalabashDevelopRewardByMonsterId.HandleId, 1, p0MonsterId, ConfigCalabashDevelopRewardByMonsterId.LogPair) || ConfigCommon.Step(ConfigCalabashDevelopRewardByMonsterId.HandleId, true, ConfigCalabashDevelopRewardByMonsterId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashDevelopRewardByMonsterId.HandleId, ConfigCalabashDevelopRewardByMonsterId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashDevelopRewardByMonsterId.HandleId, 0, ConfigCalabashDevelopRewardByMonsterId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashDevelopRewardByMonsterId.HandleId, ConfigCalabashDevelopRewardByMonsterId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashDevelopReward rootAsCalabashDevelopReward = CalabashDevelopReward.GetRootAsCalabashDevelopReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashDevelopRewardByMonsterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MonsterId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashDevelopRewardByMonsterId.HandleId, ConfigCalabashDevelopRewardByMonsterId.LogPair);
			return new CalabashDevelopReward?(rootAsCalabashDevelopReward);
		}

		// Token: 0x04000857 RID: 2135
		private const string DB = "db_calabash.db";

		// Token: 0x04000858 RID: 2136
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04000859 RID: 2137
		private const string TABLE = "CalabashDevelopReward";

		// Token: 0x0400085A RID: 2138
		private const string COMMAND = "select BinData from `CalabashDevelopReward` where MonsterId=?";

		// Token: 0x0400085B RID: 2139
		private const string KEY_PREFIX = "CalabashDevelopRewardByMonsterId";

		// Token: 0x0400085C RID: 2140
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400085D RID: 2141
		private static int HandleId;
	}
}
