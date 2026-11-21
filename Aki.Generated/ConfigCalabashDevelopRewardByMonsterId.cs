using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000144 RID: 324
	public class ConfigCalabashDevelopRewardByMonsterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x00088373 File Offset: 0x00086573
		static ConfigCalabashDevelopRewardByMonsterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashDevelopRewardByMonsterId.CreateStaticDefaultValue), new Action(ConfigCalabashDevelopRewardByMonsterId.ResetStaticDefaultValue));
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00088394 File Offset: 0x00086594
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

		// Token: 0x0600079B RID: 1947 RVA: 0x00088413 File Offset: 0x00086613
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardByMonsterId.LogPair = null;
			ConfigCalabashDevelopRewardByMonsterId.HandleId = 0;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00088421 File Offset: 0x00086621
		public static void Init()
		{
			ConfigCalabashDevelopRewardByMonsterId.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashDevelopRewardByMonsterId.HandleId, "db_calabash.db", "select BinData from `CalabashDevelopReward` where MonsterId=?");
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0008843C File Offset: 0x0008663C
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

		// Token: 0x040008C0 RID: 2240
		private const string DB = "db_calabash.db";

		// Token: 0x040008C1 RID: 2241
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008C2 RID: 2242
		private const string TABLE = "CalabashDevelopReward";

		// Token: 0x040008C3 RID: 2243
		private const string COMMAND = "select BinData from `CalabashDevelopReward` where MonsterId=?";

		// Token: 0x040008C4 RID: 2244
		private const string KEY_PREFIX = "CalabashDevelopRewardByMonsterId";

		// Token: 0x040008C5 RID: 2245
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008C6 RID: 2246
		private static int HandleId;
	}
}
