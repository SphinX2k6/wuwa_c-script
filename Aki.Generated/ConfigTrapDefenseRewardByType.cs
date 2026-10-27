using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3F RID: 2623
	public class ConfigTrapDefenseRewardByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D8E RID: 15758 RVA: 0x001B5D2C File Offset: 0x001B3F2C
		static ConfigTrapDefenseRewardByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseRewardByType.CreateStaticDefaultValue), new Action(ConfigTrapDefenseRewardByType.ResetStaticDefaultValue));
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x001B5D4C File Offset: 0x001B3F4C
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

		// Token: 0x06003D90 RID: 15760 RVA: 0x001B5DCB File Offset: 0x001B3FCB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseRewardByType.LogPair = null;
			ConfigTrapDefenseRewardByType.HandleId = 0;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x001B5DD9 File Offset: 0x001B3FD9
		public static void Init()
		{
			ConfigTrapDefenseRewardByType.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseRewardByType.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseReward` where Type=?");
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x001B5DF4 File Offset: 0x001B3FF4
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

		// Token: 0x0400479F RID: 18335
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047A0 RID: 18336
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x040047A1 RID: 18337
		private const string TABLE = "TrapDefenseReward";

		// Token: 0x040047A2 RID: 18338
		private const string COMMAND = "select BinData from `TrapDefenseReward` where Type=?";

		// Token: 0x040047A3 RID: 18339
		private const string KEY_PREFIX = "TrapDefenseRewardByType";

		// Token: 0x040047A4 RID: 18340
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047A5 RID: 18341
		private static int HandleId;
	}
}
