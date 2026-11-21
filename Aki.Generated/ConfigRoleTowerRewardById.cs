using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FE RID: 2302
	public class ConfigRoleTowerRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003607 RID: 13831 RVA: 0x0018E183 File Offset: 0x0018C383
		static ConfigRoleTowerRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRewardById.CreateStaticDefaultValue), new Action(ConfigRoleTowerRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x0018E1A4 File Offset: 0x0018C3A4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerReward` where Id=?")
			});
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x0018E223 File Offset: 0x0018C423
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRewardById.LogPair = null;
			ConfigRoleTowerRewardById.HandleId = 0;
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x0018E231 File Offset: 0x0018C431
		public static void Init()
		{
			ConfigRoleTowerRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRewardById.HandleId, "db_roletower.db", "select BinData from `RoleTowerReward` where Id=?");
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x0018E24C File Offset: 0x0018C44C
		public static RoleTowerReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRewardById.HandleId, ConfigRoleTowerRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerReward?(RoleTowerReward.GetRootAsRoleTowerReward(configBuffer));
				}
			}
			ConfigRoleTowerRewardById.LogPair.Clear();
			ConfigRoleTowerRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerRewardById.HandleId, 1, p0Id, ConfigRoleTowerRewardById.LogPair) || ConfigCommon.Step(ConfigRoleTowerRewardById.HandleId, true, ConfigRoleTowerRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerRewardById.HandleId, ConfigRoleTowerRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRewardById.HandleId, 0, ConfigRoleTowerRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerRewardById.HandleId, ConfigRoleTowerRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerReward rootAsRoleTowerReward = RoleTowerReward.GetRootAsRoleTowerReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerRewardById.HandleId, ConfigRoleTowerRewardById.LogPair);
			return new RoleTowerReward?(rootAsRoleTowerReward);
		}

		// Token: 0x04003ED8 RID: 16088
		private const string DB = "db_roletower.db";

		// Token: 0x04003ED9 RID: 16089
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003EDA RID: 16090
		private const string TABLE = "RoleTowerReward";

		// Token: 0x04003EDB RID: 16091
		private const string COMMAND = "select BinData from `RoleTowerReward` where Id=?";

		// Token: 0x04003EDC RID: 16092
		private const string KEY_PREFIX = "RoleTowerRewardById";

		// Token: 0x04003EDD RID: 16093
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EDE RID: 16094
		private static int HandleId;
	}
}
