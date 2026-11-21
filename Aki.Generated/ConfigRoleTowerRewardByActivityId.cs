using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FD RID: 2301
	public class ConfigRoleTowerRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003601 RID: 13825 RVA: 0x0018DF4B File Offset: 0x0018C14B
		static ConfigRoleTowerRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleTowerRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x0018DF6C File Offset: 0x0018C16C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerReward` where ActivityId=?")
			});
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x0018DFEB File Offset: 0x0018C1EB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRewardByActivityId.LogPair = null;
			ConfigRoleTowerRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x0018DFF9 File Offset: 0x0018C1F9
		public static void Init()
		{
			ConfigRoleTowerRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRewardByActivityId.HandleId, "db_roletower.db", "select BinData from `RoleTowerReward` where ActivityId=?");
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x0018E014 File Offset: 0x0018C214
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRewardByActivityId.HandleId, ConfigRoleTowerRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoleTowerReward> readOnlyList = (IReadOnlyList<RoleTowerReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerRewardByActivityId.LogPair.Clear();
			ConfigRoleTowerRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerRewardByActivityId.HandleId, 1, p0ActivityId, ConfigRoleTowerRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerRewardByActivityId.HandleId, ConfigRoleTowerRewardByActivityId.LogPair);
				return null;
			}
			List<RoleTowerReward> list = new List<RoleTowerReward>();
			while (ConfigCommon.Step(ConfigRoleTowerRewardByActivityId.HandleId, false, ConfigRoleTowerRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRewardByActivityId.HandleId, 0, ConfigRoleTowerRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerRewardByActivityId.HandleId, ConfigRoleTowerRewardByActivityId.LogPair);
					return null;
				}
				RoleTowerReward rootAsRoleTowerReward = RoleTowerReward.GetRootAsRoleTowerReward(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerRewardByActivityId.HandleId, ConfigRoleTowerRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003ED1 RID: 16081
		private const string DB = "db_roletower.db";

		// Token: 0x04003ED2 RID: 16082
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003ED3 RID: 16083
		private const string TABLE = "RoleTowerReward";

		// Token: 0x04003ED4 RID: 16084
		private const string COMMAND = "select BinData from `RoleTowerReward` where ActivityId=?";

		// Token: 0x04003ED5 RID: 16085
		private const string KEY_PREFIX = "RoleTowerRewardByActivityId";

		// Token: 0x04003ED6 RID: 16086
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003ED7 RID: 16087
		private static int HandleId;
	}
}
