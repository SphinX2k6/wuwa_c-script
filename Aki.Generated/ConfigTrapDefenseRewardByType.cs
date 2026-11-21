using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B14 RID: 2836
	public class ConfigTrapDefenseRewardByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600428C RID: 17036 RVA: 0x001D50C0 File Offset: 0x001D32C0
		static ConfigTrapDefenseRewardByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseRewardByType.CreateStaticDefaultValue), new Action(ConfigTrapDefenseRewardByType.ResetStaticDefaultValue));
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x001D50E0 File Offset: 0x001D32E0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseRewardByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseRewardByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseReward` where Type=?")
			});
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x001D515F File Offset: 0x001D335F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseRewardByType.LogPair = null;
			ConfigTrapDefenseRewardByType.HandleId = 0;
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x001D516D File Offset: 0x001D336D
		public static void Init()
		{
			ConfigTrapDefenseRewardByType.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseRewardByType.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseReward` where Type=?");
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x001D5188 File Offset: 0x001D3388
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseReward> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseRewardByType.HandleId, ConfigTrapDefenseRewardByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseRewardByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<TrapDefenseReward> readOnlyList = (IReadOnlyList<TrapDefenseReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseRewardByType.LogPair.Clear();
			ConfigTrapDefenseRewardByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseRewardByType.HandleId, 1, p0Type, ConfigTrapDefenseRewardByType.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseRewardByType.HandleId, ConfigTrapDefenseRewardByType.LogPair);
				return null;
			}
			List<TrapDefenseReward> list = new List<TrapDefenseReward>();
			while (ConfigCommon.Step(ConfigTrapDefenseRewardByType.HandleId, false, ConfigTrapDefenseRewardByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseRewardByType.HandleId, 0, ConfigTrapDefenseRewardByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseRewardByType.HandleId, ConfigTrapDefenseRewardByType.LogPair);
					return null;
				}
				TrapDefenseReward rootAsTrapDefenseReward = TrapDefenseReward.GetRootAsTrapDefenseReward(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseRewardByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseRewardByType.HandleId, ConfigTrapDefenseRewardByType.LogPair);
			return list;
		}

		// Token: 0x04004D72 RID: 19826
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D73 RID: 19827
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D74 RID: 19828
		private const string TABLE = "TrapDefenseReward";

		// Token: 0x04004D75 RID: 19829
		private const string COMMAND = "select BinData from `TrapDefenseReward` where Type=?";

		// Token: 0x04004D76 RID: 19830
		private const string KEY_PREFIX = "TrapDefenseRewardByType";

		// Token: 0x04004D77 RID: 19831
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D78 RID: 19832
		private static int HandleId;
	}
}
