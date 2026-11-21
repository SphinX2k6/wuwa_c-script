using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000908 RID: 2312
	public class ConfigRoleTowerScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003643 RID: 13891 RVA: 0x0018F607 File Offset: 0x0018D807
		static ConfigRoleTowerScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerScoreRewardById.CreateStaticDefaultValue), new Action(ConfigRoleTowerScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x0018F628 File Offset: 0x0018D828
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerScoreReward` where Id=?")
			});
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x0018F6A7 File Offset: 0x0018D8A7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerScoreRewardById.LogPair = null;
			ConfigRoleTowerScoreRewardById.HandleId = 0;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0018F6B5 File Offset: 0x0018D8B5
		public static void Init()
		{
			ConfigRoleTowerScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerScoreRewardById.HandleId, "db_roletower.db", "select BinData from `RoleTowerScoreReward` where Id=?");
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0018F6D0 File Offset: 0x0018D8D0
		public static RoleTowerScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerScoreRewardById.HandleId, ConfigRoleTowerScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerScoreReward?(RoleTowerScoreReward.GetRootAsRoleTowerScoreReward(configBuffer));
				}
			}
			ConfigRoleTowerScoreRewardById.LogPair.Clear();
			ConfigRoleTowerScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerScoreRewardById.HandleId, 1, p0Id, ConfigRoleTowerScoreRewardById.LogPair) || ConfigCommon.Step(ConfigRoleTowerScoreRewardById.HandleId, true, ConfigRoleTowerScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerScoreRewardById.HandleId, ConfigRoleTowerScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerScoreRewardById.HandleId, 0, ConfigRoleTowerScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerScoreRewardById.HandleId, ConfigRoleTowerScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerScoreReward rootAsRoleTowerScoreReward = RoleTowerScoreReward.GetRootAsRoleTowerScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerScoreRewardById.HandleId, ConfigRoleTowerScoreRewardById.LogPair);
			return new RoleTowerScoreReward?(rootAsRoleTowerScoreReward);
		}

		// Token: 0x04003F1E RID: 16158
		private const string DB = "db_roletower.db";

		// Token: 0x04003F1F RID: 16159
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003F20 RID: 16160
		private const string TABLE = "RoleTowerScoreReward";

		// Token: 0x04003F21 RID: 16161
		private const string COMMAND = "select BinData from `RoleTowerScoreReward` where Id=?";

		// Token: 0x04003F22 RID: 16162
		private const string KEY_PREFIX = "RoleTowerScoreRewardById";

		// Token: 0x04003F23 RID: 16163
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F24 RID: 16164
		private static int HandleId;
	}
}
