using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BD RID: 2237
	public class ConfigRoleQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003481 RID: 13441 RVA: 0x00182010 File Offset: 0x00180210
		static ConfigRoleQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleQuestById.CreateStaticDefaultValue), new Action(ConfigRoleQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00182030 File Offset: 0x00180230
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rolequest.db"),
				new ValueTuple<string, object>("文件", "j.角色任务.xlsx"),
				new ValueTuple<string, object>("表名", "RoleQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleQuest` where Id = ?")
			});
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x001820AF File Offset: 0x001802AF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleQuestById.LogPair = null;
			ConfigRoleQuestById.HandleId = 0;
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x001820BD File Offset: 0x001802BD
		public static void Init()
		{
			ConfigRoleQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleQuestById.HandleId, "db_rolequest.db", "select BinData from `RoleQuest` where Id = ?");
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x001820D8 File Offset: 0x001802D8
		public static RoleQuest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleQuestById.HandleId, ConfigRoleQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleQuest?(RoleQuest.GetRootAsRoleQuest(configBuffer));
				}
			}
			ConfigRoleQuestById.LogPair.Clear();
			ConfigRoleQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleQuestById.HandleId, 1, p0Id, ConfigRoleQuestById.LogPair) || ConfigCommon.Step(ConfigRoleQuestById.HandleId, true, ConfigRoleQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleQuestById.HandleId, ConfigRoleQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleQuestById.HandleId, 0, ConfigRoleQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleQuestById.HandleId, ConfigRoleQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleQuest rootAsRoleQuest = RoleQuest.GetRootAsRoleQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleQuestById.HandleId, ConfigRoleQuestById.LogPair);
			return new RoleQuest?(rootAsRoleQuest);
		}

		// Token: 0x04003D11 RID: 15633
		private const string DB = "db_rolequest.db";

		// Token: 0x04003D12 RID: 15634
		private const string FILE = "j.角色任务.xlsx";

		// Token: 0x04003D13 RID: 15635
		private const string TABLE = "RoleQuest";

		// Token: 0x04003D14 RID: 15636
		private const string COMMAND = "select BinData from `RoleQuest` where Id = ?";

		// Token: 0x04003D15 RID: 15637
		private const string KEY_PREFIX = "RoleQuestById";

		// Token: 0x04003D16 RID: 15638
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D17 RID: 15639
		private static int HandleId;
	}
}
