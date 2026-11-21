using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B18 RID: 2840
	public class ConfigTrapDefenseSpecialRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042A4 RID: 17060 RVA: 0x001D59BF File Offset: 0x001D3BBF
		static ConfigTrapDefenseSpecialRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseSpecialRewardById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseSpecialRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x001D59E0 File Offset: 0x001D3BE0
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

		// Token: 0x060042A6 RID: 17062 RVA: 0x001D5A5F File Offset: 0x001D3C5F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialRewardById.LogPair = null;
			ConfigTrapDefenseSpecialRewardById.HandleId = 0;
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x001D5A6D File Offset: 0x001D3C6D
		public static void Init()
		{
			ConfigTrapDefenseSpecialRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseSpecialRewardById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseSpecialReward` where Id=?");
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x001D5A88 File Offset: 0x001D3C88
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

		// Token: 0x04004D8E RID: 19854
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D8F RID: 19855
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D90 RID: 19856
		private const string TABLE = "TrapDefenseSpecialReward";

		// Token: 0x04004D91 RID: 19857
		private const string COMMAND = "select BinData from `TrapDefenseSpecialReward` where Id=?";

		// Token: 0x04004D92 RID: 19858
		private const string KEY_PREFIX = "TrapDefenseSpecialRewardById";

		// Token: 0x04004D93 RID: 19859
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D94 RID: 19860
		private static int HandleId;
	}
}
