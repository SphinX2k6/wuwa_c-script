using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067F RID: 1663
	public class ConfigPhantomBattleCardRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600270A RID: 9994 RVA: 0x00139E4C File Offset: 0x0013804C
		static ConfigPhantomBattleCardRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00139E6C File Offset: 0x0013806C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardReward"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardReward` where ActivityId=?")
			});
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00139EEB File Offset: 0x001380EB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRewardByActivityId.LogPair = null;
			ConfigPhantomBattleCardRewardByActivityId.HandleId = 0;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00139EF9 File Offset: 0x001380F9
		public static void Init()
		{
			ConfigPhantomBattleCardRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRewardByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardReward` where ActivityId=?");
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00139F14 File Offset: 0x00138114
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCardReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardRewardByActivityId.HandleId, ConfigPhantomBattleCardRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleCardReward> readOnlyList = (IReadOnlyList<PhantomBattleCardReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleCardRewardByActivityId.LogPair.Clear();
			ConfigPhantomBattleCardRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardRewardByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleCardRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardRewardByActivityId.HandleId, ConfigPhantomBattleCardRewardByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleCardReward> list = new List<PhantomBattleCardReward>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardRewardByActivityId.HandleId, false, ConfigPhantomBattleCardRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardRewardByActivityId.HandleId, 0, ConfigPhantomBattleCardRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardRewardByActivityId.HandleId, ConfigPhantomBattleCardRewardByActivityId.LogPair);
					return null;
				}
				PhantomBattleCardReward rootAsPhantomBattleCardReward = PhantomBattleCardReward.GetRootAsPhantomBattleCardReward(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCardReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardRewardByActivityId.HandleId, ConfigPhantomBattleCardRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002D5F RID: 11615
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D60 RID: 11616
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D61 RID: 11617
		private const string TABLE = "PhantomBattleCardReward";

		// Token: 0x04002D62 RID: 11618
		private const string COMMAND = "select BinData from `PhantomBattleCardReward` where ActivityId=?";

		// Token: 0x04002D63 RID: 11619
		private const string KEY_PREFIX = "PhantomBattleCardRewardByActivityId";

		// Token: 0x04002D64 RID: 11620
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D65 RID: 11621
		private static int HandleId;
	}
}
