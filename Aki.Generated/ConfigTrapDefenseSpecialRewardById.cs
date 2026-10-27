using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A43 RID: 2627
	public class ConfigTrapDefenseSpecialRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DA6 RID: 15782 RVA: 0x001B662B File Offset: 0x001B482B
		static ConfigTrapDefenseSpecialRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseSpecialRewardById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseSpecialRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x001B664C File Offset: 0x001B484C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseSpecialRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseSpecialReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseSpecialReward` where Id=?")
			});
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x001B66CB File Offset: 0x001B48CB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialRewardById.LogPair = null;
			ConfigTrapDefenseSpecialRewardById.HandleId = 0;
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x001B66D9 File Offset: 0x001B48D9
		public static void Init()
		{
			ConfigTrapDefenseSpecialRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseSpecialRewardById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseSpecialReward` where Id=?");
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x001B66F4 File Offset: 0x001B48F4
		public static TrapDefenseSpecialReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseSpecialRewardById.HandleId, ConfigTrapDefenseSpecialRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseSpecialReward?(TrapDefenseSpecialReward.GetRootAsTrapDefenseSpecialReward(configBuffer));
				}
			}
			ConfigTrapDefenseSpecialRewardById.LogPair.Clear();
			ConfigTrapDefenseSpecialRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseSpecialRewardById.HandleId, 1, p0Id, ConfigTrapDefenseSpecialRewardById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseSpecialRewardById.HandleId, true, ConfigTrapDefenseSpecialRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardById.HandleId, ConfigTrapDefenseSpecialRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseSpecialRewardById.HandleId, 0, ConfigTrapDefenseSpecialRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardById.HandleId, ConfigTrapDefenseSpecialRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseSpecialReward rootAsTrapDefenseSpecialReward = TrapDefenseSpecialReward.GetRootAsTrapDefenseSpecialReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardById.HandleId, ConfigTrapDefenseSpecialRewardById.LogPair);
			return new TrapDefenseSpecialReward?(rootAsTrapDefenseSpecialReward);
		}

		// Token: 0x040047BB RID: 18363
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047BC RID: 18364
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x040047BD RID: 18365
		private const string TABLE = "TrapDefenseSpecialReward";

		// Token: 0x040047BE RID: 18366
		private const string COMMAND = "select BinData from `TrapDefenseSpecialReward` where Id=?";

		// Token: 0x040047BF RID: 18367
		private const string KEY_PREFIX = "TrapDefenseSpecialRewardById";

		// Token: 0x040047C0 RID: 18368
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047C1 RID: 18369
		private static int HandleId;
	}
}
