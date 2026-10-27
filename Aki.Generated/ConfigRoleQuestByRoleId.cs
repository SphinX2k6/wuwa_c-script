using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BE RID: 2238
	public class ConfigRoleQuestByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003487 RID: 13447 RVA: 0x00182258 File Offset: 0x00180458
		static ConfigRoleQuestByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleQuestByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleQuestByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00182278 File Offset: 0x00180478
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleQuestByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleQuestByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rolequest.db"),
				new ValueTuple<string, object>("文件", "j.角色任务.xlsx"),
				new ValueTuple<string, object>("表名", "RoleQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleQuest` where RoleId =?")
			});
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x001822F7 File Offset: 0x001804F7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleQuestByRoleId.LogPair = null;
			ConfigRoleQuestByRoleId.HandleId = 0;
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00182305 File Offset: 0x00180505
		public static void Init()
		{
			ConfigRoleQuestByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleQuestByRoleId.HandleId, "db_rolequest.db", "select BinData from `RoleQuest` where RoleId =?");
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00182320 File Offset: 0x00180520
		public static RoleQuest? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleQuestByRoleId.HandleId, ConfigRoleQuestByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQuestByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleQuest?(RoleQuest.GetRootAsRoleQuest(configBuffer));
				}
			}
			ConfigRoleQuestByRoleId.LogPair.Clear();
			ConfigRoleQuestByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleQuestByRoleId.HandleId, 1, p0RoleId, ConfigRoleQuestByRoleId.LogPair) || ConfigCommon.Step(ConfigRoleQuestByRoleId.HandleId, true, ConfigRoleQuestByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleQuestByRoleId.HandleId, ConfigRoleQuestByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleQuestByRoleId.HandleId, 0, ConfigRoleQuestByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleQuestByRoleId.HandleId, ConfigRoleQuestByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleQuest rootAsRoleQuest = RoleQuest.GetRootAsRoleQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQuestByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleQuestByRoleId.HandleId, ConfigRoleQuestByRoleId.LogPair);
			return new RoleQuest?(rootAsRoleQuest);
		}

		// Token: 0x04003D18 RID: 15640
		private const string DB = "db_rolequest.db";

		// Token: 0x04003D19 RID: 15641
		private const string FILE = "j.角色任务.xlsx";

		// Token: 0x04003D1A RID: 15642
		private const string TABLE = "RoleQuest";

		// Token: 0x04003D1B RID: 15643
		private const string COMMAND = "select BinData from `RoleQuest` where RoleId =?";

		// Token: 0x04003D1C RID: 15644
		private const string KEY_PREFIX = "RoleQuestByRoleId";

		// Token: 0x04003D1D RID: 15645
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D1E RID: 15646
		private static int HandleId;
	}
}
