using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A42 RID: 2626
	public class ConfigTrapDefenseSpecialRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DA0 RID: 15776 RVA: 0x001B63F4 File Offset: 0x001B45F4
		static ConfigTrapDefenseSpecialRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseSpecialRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseSpecialRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x001B6414 File Offset: 0x001B4614
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseSpecialReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseSpecialReward` where ActivityId=?")
			});
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x001B6493 File Offset: 0x001B4693
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair = null;
			ConfigTrapDefenseSpecialRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x001B64A1 File Offset: 0x001B46A1
		public static void Init()
		{
			ConfigTrapDefenseSpecialRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseSpecialReward` where ActivityId=?");
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x001B64BC File Offset: 0x001B46BC
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseSpecialReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TrapDefenseSpecialReward> readOnlyList = (IReadOnlyList<TrapDefenseSpecialReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair.Clear();
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, 1, p0ActivityId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair);
				return null;
			}
			List<TrapDefenseSpecialReward> list = new List<TrapDefenseSpecialReward>();
			while (ConfigCommon.Step(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, false, ConfigTrapDefenseSpecialRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, 0, ConfigTrapDefenseSpecialRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair);
					return null;
				}
				TrapDefenseSpecialReward rootAsTrapDefenseSpecialReward = TrapDefenseSpecialReward.GetRootAsTrapDefenseSpecialReward(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseSpecialReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x040047B4 RID: 18356
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047B5 RID: 18357
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x040047B6 RID: 18358
		private const string TABLE = "TrapDefenseSpecialReward";

		// Token: 0x040047B7 RID: 18359
		private const string COMMAND = "select BinData from `TrapDefenseSpecialReward` where ActivityId=?";

		// Token: 0x040047B8 RID: 18360
		private const string KEY_PREFIX = "TrapDefenseSpecialRewardByActivityId";

		// Token: 0x040047B9 RID: 18361
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047BA RID: 18362
		private static int HandleId;
	}
}
