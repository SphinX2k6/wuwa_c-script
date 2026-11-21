using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000902 RID: 2306
	public class ConfigRoleTowerRewardTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600361F RID: 13855 RVA: 0x0018E9CF File Offset: 0x0018CBCF
		static ConfigRoleTowerRewardTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRewardTabById.CreateStaticDefaultValue), new Action(ConfigRoleTowerRewardTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0018E9F0 File Offset: 0x0018CBF0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRewardTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRewardTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerRewardTab` where Id=?")
			});
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x0018EA6F File Offset: 0x0018CC6F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRewardTabById.LogPair = null;
			ConfigRoleTowerRewardTabById.HandleId = 0;
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x0018EA7D File Offset: 0x0018CC7D
		public static void Init()
		{
			ConfigRoleTowerRewardTabById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRewardTabById.HandleId, "db_roletower.db", "select BinData from `RoleTowerRewardTab` where Id=?");
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x0018EA98 File Offset: 0x0018CC98
		public static RoleTowerRewardTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRewardTabById.HandleId, ConfigRoleTowerRewardTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerRewardTab?(RoleTowerRewardTab.GetRootAsRoleTowerRewardTab(configBuffer));
				}
			}
			ConfigRoleTowerRewardTabById.LogPair.Clear();
			ConfigRoleTowerRewardTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerRewardTabById.HandleId, 1, p0Id, ConfigRoleTowerRewardTabById.LogPair) || ConfigCommon.Step(ConfigRoleTowerRewardTabById.HandleId, true, ConfigRoleTowerRewardTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerRewardTabById.HandleId, ConfigRoleTowerRewardTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRewardTabById.HandleId, 0, ConfigRoleTowerRewardTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerRewardTabById.HandleId, ConfigRoleTowerRewardTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerRewardTab rootAsRoleTowerRewardTab = RoleTowerRewardTab.GetRootAsRoleTowerRewardTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerRewardTabById.HandleId, ConfigRoleTowerRewardTabById.LogPair);
			return new RoleTowerRewardTab?(rootAsRoleTowerRewardTab);
		}

		// Token: 0x04003EF4 RID: 16116
		private const string DB = "db_roletower.db";

		// Token: 0x04003EF5 RID: 16117
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003EF6 RID: 16118
		private const string TABLE = "RoleTowerRewardTab";

		// Token: 0x04003EF7 RID: 16119
		private const string COMMAND = "select BinData from `RoleTowerRewardTab` where Id=?";

		// Token: 0x04003EF8 RID: 16120
		private const string KEY_PREFIX = "RoleTowerRewardTabById";

		// Token: 0x04003EF9 RID: 16121
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EFA RID: 16122
		private static int HandleId;
	}
}
