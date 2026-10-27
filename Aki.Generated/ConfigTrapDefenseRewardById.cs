using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3E RID: 2622
	public class ConfigTrapDefenseRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D88 RID: 15752 RVA: 0x001B5AE3 File Offset: 0x001B3CE3
		static ConfigTrapDefenseRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseRewardById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x001B5B04 File Offset: 0x001B3D04
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseReward` where Id=?")
			});
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x001B5B83 File Offset: 0x001B3D83
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseRewardById.LogPair = null;
			ConfigTrapDefenseRewardById.HandleId = 0;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x001B5B91 File Offset: 0x001B3D91
		public static void Init()
		{
			ConfigTrapDefenseRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseRewardById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseReward` where Id=?");
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x001B5BAC File Offset: 0x001B3DAC
		public static TrapDefenseReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseRewardById.HandleId, ConfigTrapDefenseRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseReward?(TrapDefenseReward.GetRootAsTrapDefenseReward(configBuffer));
				}
			}
			ConfigTrapDefenseRewardById.LogPair.Clear();
			ConfigTrapDefenseRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseRewardById.HandleId, 1, p0Id, ConfigTrapDefenseRewardById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseRewardById.HandleId, true, ConfigTrapDefenseRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseRewardById.HandleId, ConfigTrapDefenseRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseRewardById.HandleId, 0, ConfigTrapDefenseRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseRewardById.HandleId, ConfigTrapDefenseRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseReward rootAsTrapDefenseReward = TrapDefenseReward.GetRootAsTrapDefenseReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseRewardById.HandleId, ConfigTrapDefenseRewardById.LogPair);
			return new TrapDefenseReward?(rootAsTrapDefenseReward);
		}

		// Token: 0x04004798 RID: 18328
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004799 RID: 18329
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x0400479A RID: 18330
		private const string TABLE = "TrapDefenseReward";

		// Token: 0x0400479B RID: 18331
		private const string COMMAND = "select BinData from `TrapDefenseReward` where Id=?";

		// Token: 0x0400479C RID: 18332
		private const string KEY_PREFIX = "TrapDefenseRewardById";

		// Token: 0x0400479D RID: 18333
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400479E RID: 18334
		private static int HandleId;
	}
}
