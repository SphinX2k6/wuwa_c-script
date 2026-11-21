using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B13 RID: 2835
	public class ConfigTrapDefenseRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004286 RID: 17030 RVA: 0x001D4E77 File Offset: 0x001D3077
		static ConfigTrapDefenseRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseRewardById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x001D4E98 File Offset: 0x001D3098
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

		// Token: 0x06004288 RID: 17032 RVA: 0x001D4F17 File Offset: 0x001D3117
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseRewardById.LogPair = null;
			ConfigTrapDefenseRewardById.HandleId = 0;
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x001D4F25 File Offset: 0x001D3125
		public static void Init()
		{
			ConfigTrapDefenseRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseRewardById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseReward` where Id=?");
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x001D4F40 File Offset: 0x001D3140
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

		// Token: 0x04004D6B RID: 19819
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D6C RID: 19820
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D6D RID: 19821
		private const string TABLE = "TrapDefenseReward";

		// Token: 0x04004D6E RID: 19822
		private const string COMMAND = "select BinData from `TrapDefenseReward` where Id=?";

		// Token: 0x04004D6F RID: 19823
		private const string KEY_PREFIX = "TrapDefenseRewardById";

		// Token: 0x04004D70 RID: 19824
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D71 RID: 19825
		private static int HandleId;
	}
}
