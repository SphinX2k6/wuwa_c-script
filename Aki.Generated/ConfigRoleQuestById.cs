using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D9 RID: 2265
	public class ConfigRoleQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003529 RID: 13609 RVA: 0x001892F8 File Offset: 0x001874F8
		static ConfigRoleQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleQuestById.CreateStaticDefaultValue), new Action(ConfigRoleQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00189318 File Offset: 0x00187518
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

		// Token: 0x0600352B RID: 13611 RVA: 0x00189397 File Offset: 0x00187597
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleQuestById.LogPair = null;
			ConfigRoleQuestById.HandleId = 0;
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x001893A5 File Offset: 0x001875A5
		public static void Init()
		{
			ConfigRoleQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleQuestById.HandleId, "db_rolequest.db", "select BinData from `RoleQuest` where Id = ?");
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x001893C0 File Offset: 0x001875C0
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

		// Token: 0x04003DD5 RID: 15829
		private const string DB = "db_rolequest.db";

		// Token: 0x04003DD6 RID: 15830
		private const string FILE = "j.角色任务.xlsx";

		// Token: 0x04003DD7 RID: 15831
		private const string TABLE = "RoleQuest";

		// Token: 0x04003DD8 RID: 15832
		private const string COMMAND = "select BinData from `RoleQuest` where Id = ?";

		// Token: 0x04003DD9 RID: 15833
		private const string KEY_PREFIX = "RoleQuestById";

		// Token: 0x04003DDA RID: 15834
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DDB RID: 15835
		private static int HandleId;
	}
}
